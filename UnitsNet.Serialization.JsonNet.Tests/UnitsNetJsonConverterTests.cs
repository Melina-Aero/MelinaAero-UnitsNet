﻿// Copyright (c) 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com).
// https://github.com/angularsen/UnitsNet
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using Newtonsoft.Json;
using Xunit;

namespace UnitsNet.Serialization.JsonNet.Tests
{
    public class UnitsNetJsonConverterTests
    {
        private readonly JsonSerializerSettings _jsonSerializerSettings;

        protected UnitsNetJsonConverterTests()
        {
            _jsonSerializerSettings = new JsonSerializerSettings {Formatting = Formatting.Indented};
            _jsonSerializerSettings.Converters.Add(new UnitsNetJsonConverter());
        }

        private string SerializeObject(object obj)
        {
            return JsonConvert.SerializeObject(obj, _jsonSerializerSettings).Replace("\r\n", "\n");
        }

        private T DeserializeObject<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json, _jsonSerializerSettings);
        }

        public class Serialize : UnitsNetJsonConverterTests
        {
            [Fact]
            public void Mass_ExpectConstructedValueAndUnit()
            {
                Mass mass = Mass.FromPounds(200);
                var expectedJson = "{\n  \"Unit\": \"MassUnit.Pound\",\n  \"Value\": 200.0\n}";

                string json = SerializeObject(mass);

                Assert.Equal(expectedJson, json);
            }

            [Fact]
            public void NonNullNullableValueNestedInObject_ExpectJsonUnaffected()
            {
                var testObj = new TestObj
                {
                    NonNullableFrequency = Frequency.FromHertz(10)
                };
                // Ugly manually formatted JSON string is used because string literals with newlines are rendered differently
                //  on the build server (i.e. the build server uses '\r' instead of '\n')
                string expectedJson = "{\n" +
                                      "  \"NonNullableFrequency\": {\n" +
                                      "    \"Unit\": \"FrequencyUnit.Hertz\",\n" +
                                      "    \"Value\": 10.0\n" +
                                      "  }\n" +
                                      "}";

                string json = SerializeObject(testObj);

                Assert.Equal(expectedJson, json);
            }

            [Fact]
            public void Ratio_ExpectDecimalFractionsUsedAsBaseValueAndUnit()
            {
                Ratio ratio = Ratio.FromPartsPerThousand(250);
                var expectedJson = "{\n  \"Unit\": \"RatioUnit.PartPerThousand\",\n  \"Value\": 250.0\n}";

                string json = SerializeObject(ratio);

                Assert.Equal(expectedJson, json);
            }
        }

        public class Deserialize : UnitsNetJsonConverterTests
        {
            [Fact]
            public void Mass_ExpectJsonCorrectlyDeserialized()
            {
                Mass originalMass = Mass.FromKilograms(33.33);
                string json = SerializeObject(originalMass);

                var deserializedMass = DeserializeObject<Mass>(json);

                Assert.Equal(originalMass, deserializedMass);
            }

            [Fact]
            public void NonNullNullableValueNestedInObject_ExpectValueDeserializedCorrectly()
            {
                var testObj = new TestObj
                {
                    NonNullableFrequency = Frequency.FromHertz(10)
                };
                string json = SerializeObject(testObj);

                var deserializedTestObj = DeserializeObject<TestObj>(json);
            }

            [Fact]
            public void NullValueNestedInObject_ExpectValueDeserializedToNullCorrectly()
            {
                var testObj = new TestObj
                {
                    NonNullableFrequency = Frequency.FromHertz(10)
                };
                string json = SerializeObject(testObj);

                var deserializedTestObj = DeserializeObject<TestObj>(json);
            }

            [Fact]
            public void UnitEnumChangedAfterSerialization_ExpectUnitCorrectlyDeserialized()
            {
                Mass originalMass = Mass.FromKilograms(33.33);
                string json = SerializeObject(originalMass);
                // Someone manually changed the serialized JSON string to 1000 grams.
                json = json.Replace("33.33", "1000");
                json = json.Replace("MassUnit.Kilogram", "MassUnit.Gram");

                var deserializedMass = DeserializeObject<Mass>(json);

                // The original value serialized was 33.33 kg, but someone edited the JSON to be 1000 g. We expect the JSON is
                //  still deserializable, and the correct value of 1000 g is obtained.
                Assert.Equal(1000, deserializedMass.Grams);
            }

            [Fact]
            public void UnitInIComparable_ExpectUnitCorrectlyDeserialized()
            {
                TestObjWithIComparable testObjWithIComparable = new TestObjWithIComparable()
                {
                    Value = Power.FromWatts(10)
                };
                JsonSerializerSettings jsonSerializerSettings = CreateJsonSerializerSettings();

                string json = JsonConvert.SerializeObject(testObjWithIComparable, jsonSerializerSettings);

                var deserializedTestObject = JsonConvert.DeserializeObject<TestObjWithIComparable>(json,jsonSerializerSettings);
               
                Assert.Equal(typeof(Power), deserializedTestObject.Value.GetType());
                Assert.Equal(Power.FromWatts(10), (Power)deserializedTestObject.Value);
            }

            [Fact]
            public void DoubleInIComparable_ExpectUnitCorrectlyDeserialized()
            {
                TestObjWithIComparable testObjWithIComparable = new TestObjWithIComparable()
                {
                    Value = 10.0
                };
                JsonSerializerSettings jsonSerializerSettings = CreateJsonSerializerSettings();

                string json = JsonConvert.SerializeObject(testObjWithIComparable, jsonSerializerSettings);

                var deserializedTestObject = JsonConvert.DeserializeObject<TestObjWithIComparable>(json, jsonSerializerSettings);

                Assert.Equal(typeof(double), deserializedTestObject.Value.GetType());
                Assert.Equal(10d, (double)deserializedTestObject.Value);
            }

            [Fact]
            public void ClassInIComparable_ExpectUnitCorrectlyDeserialized()
            {
                TestObjWithIComparable testObjWithIComparable = new TestObjWithIComparable()
                {
                    Value = new ComparableClass() { Value = 10 }
                };
                JsonSerializerSettings jsonSerializerSettings = CreateJsonSerializerSettings();

                string json = JsonConvert.SerializeObject(testObjWithIComparable, jsonSerializerSettings);
                var deserializedTestObject = JsonConvert.DeserializeObject<TestObjWithIComparable>(json, jsonSerializerSettings);

                Assert.Equal(typeof(ComparableClass), deserializedTestObject.Value.GetType());
                Assert.Equal(10d, ((ComparableClass) deserializedTestObject.Value).Value);
            }

            [Fact]
            public void OtherObjectWithUnitAndValue_ExpectCorrectResturnValues()
            {
                TestObjWithValueAndUnit testObjWithValueAndUnit = new TestObjWithValueAndUnit()
                {
                   Value = 5,
                   Unit = "Test",
                };
                JsonSerializerSettings jsonSerializerSettings = CreateJsonSerializerSettings();

                string json = JsonConvert.SerializeObject(testObjWithValueAndUnit, jsonSerializerSettings);
                TestObjWithValueAndUnit deserializedTestObject = JsonConvert.DeserializeObject<TestObjWithValueAndUnit>(json, jsonSerializerSettings);

                Assert.Equal(typeof(double), deserializedTestObject.Value.GetType());
                Assert.Equal(5d, deserializedTestObject.Value);
                Assert.Equal("Test", deserializedTestObject.Unit);
            }

            [Fact]
            public void ThreeObjectsInIComparableWithDifferentValues_ExpectAllCorrectlyDeserialized()
            {
                TestObjWithThreeIComparable testObjWithIComparable = new TestObjWithThreeIComparable()
                {
                    Value1 = 10.0,
                    Value2 = Power.FromWatts(19),
                    Value3 = new ComparableClass() { Value = 10 },
                };
                JsonSerializerSettings jsonSerializerSettings = CreateJsonSerializerSettings();

                string json = JsonConvert.SerializeObject(testObjWithIComparable, jsonSerializerSettings);
                var deserializedTestObject = JsonConvert.DeserializeObject<TestObjWithThreeIComparable>(json, jsonSerializerSettings);

                Assert.Equal(typeof(double), deserializedTestObject.Value1.GetType());
                Assert.Equal(10d, deserializedTestObject.Value1);
                Assert.Equal(typeof(Power), deserializedTestObject.Value2.GetType());
                Assert.Equal(Power.FromWatts(19), deserializedTestObject.Value2);
                Assert.Equal(typeof(ComparableClass), deserializedTestObject.Value3.GetType());
                Assert.Equal(testObjWithIComparable.Value3, deserializedTestObject.Value3);
            }

            private static JsonSerializerSettings CreateJsonSerializerSettings()
            {
                var jsonSerializerSettings = new JsonSerializerSettings()
                {
                    Formatting = Formatting.Indented,
                    TypeNameHandling = TypeNameHandling.Auto
                };
                jsonSerializerSettings.Converters.Add(new UnitsNetJsonConverter());
                return jsonSerializerSettings;
            }
        }

        private class TestObj
        {
            public Frequency NonNullableFrequency { get; set; }
        }

        private class TestObjWithValueAndUnit : IComparable
        {
            public double Value { get; set; }
            public string Unit { get; set; }

            public int CompareTo(object obj)
            {
                return ((IComparable)Value).CompareTo(obj);
            }
        }

        private class ComparableClass : IComparable
        {
            public int Value { get; set; }
            public int CompareTo(object obj)
            {
                return ((IComparable)Value).CompareTo(obj);
            }

            // Needed for virfying that the deserialized object is the same, should not affect the serilization code
            public override bool Equals(object obj)
            {
                if (obj == null || GetType() != obj.GetType())
                {
                    return false;
                }
                return Value.Equals(((ComparableClass)obj).Value);
            }

            public override int GetHashCode()
            {
                return Value.GetHashCode();
            }
        }

        private class TestObjWithIComparable
        {
            public IComparable Value { get; set; }
        }

        private class TestObjWithThreeIComparable
        {
            public IComparable Value1 { get; set; }

            public IComparable Value2 { get; set; }

            public IComparable Value3 { get; set; }
        }
    }
}
