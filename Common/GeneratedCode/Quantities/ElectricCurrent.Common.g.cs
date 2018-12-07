﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add Extensions\MyQuantityExtensions.cs to decorate quantities with new behavior.
//     Add UnitDefinitions\MyQuantity.json and run GeneratUnits.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Copyright (c) 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com).
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
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Linq;
using JetBrains.Annotations;
using UnitsNet.Units;

// ReSharper disable once CheckNamespace

namespace UnitsNet
{
    /// <summary>
    ///     An electric current is a flow of electric charge. In electric circuits this charge is often carried by moving electrons in a wire. It can also be carried by ions in an electrolyte, or by both ions and electrons such as in a plasma.
    /// </summary>
    // ReSharper disable once PartialTypeWithSinglePart

    // Windows Runtime Component has constraints on public types: https://msdn.microsoft.com/en-us/library/br230301.aspx#Declaring types in Windows Runtime Components
    // Public structures can't have any members other than public fields, and those fields must be value types or strings.
    // Public classes must be sealed (NotInheritable in Visual Basic). If your programming model requires polymorphism, you can create a public interface and implement that interface on the classes that must be polymorphic.
#if WINDOWS_UWP
    public sealed partial class ElectricCurrent : IQuantity
#else
    public partial struct ElectricCurrent : IQuantity, IComparable, IComparable<ElectricCurrent>
#endif
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly ElectricCurrentUnit? _unit;

        /// <summary>
        ///     The unit this quantity was constructed with -or- <see cref="BaseUnit" /> if default ctor was used.
        /// </summary>
        public ElectricCurrentUnit Unit => _unit.GetValueOrDefault(BaseUnit);

        static ElectricCurrent()
        {
            BaseDimensions = new BaseDimensions(0, 0, 0, 1, 0, 0, 0);
        }

        /// <summary>
        ///     Creates the quantity with the given value in the base unit Ampere.
        /// </summary>
        [Obsolete("Use the constructor that takes a unit parameter. This constructor will be removed in a future version.")]
        public ElectricCurrent(double amperes)
        {
            _value = Convert.ToDouble(amperes);
            _unit = BaseUnit;
        }

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="numericValue">Numeric value.</param>
        /// <param name="unit">Unit representation.</param>
        /// <remarks>Value parameter cannot be named 'value' due to constraint when targeting Windows Runtime Component.</remarks>
#if WINDOWS_UWP
        private
#else
        public
#endif
        ElectricCurrent(double numericValue, ElectricCurrentUnit unit)
        {
            _value = numericValue;
            _unit = unit;
        }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
        /// <summary>
        ///     Creates the quantity with the given value assuming the base unit Ampere.
        /// </summary>
        /// <param name="amperes">Value assuming base unit Ampere.</param>
#if WINDOWS_UWP
        private
#else
        [Obsolete("Use the constructor that takes a unit parameter. This constructor will be removed in a future version.")]
        public
#endif
        ElectricCurrent(long amperes) : this(Convert.ToDouble(amperes), BaseUnit) { }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
        // Windows Runtime Component does not support decimal type
        /// <summary>
        ///     Creates the quantity with the given value assuming the base unit Ampere.
        /// </summary>
        /// <param name="amperes">Value assuming base unit Ampere.</param>
#if WINDOWS_UWP
        private
#else
        [Obsolete("Use the constructor that takes a unit parameter. This constructor will be removed in a future version.")]
        public
#endif
        ElectricCurrent(decimal amperes) : this(Convert.ToDouble(amperes), BaseUnit) { }

        #region Properties

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        public static QuantityType QuantityType => QuantityType.ElectricCurrent;

        /// <summary>
        ///     The base unit representation of this quantity for the numeric value stored internally. All conversions go via this value.
        /// </summary>
        public static ElectricCurrentUnit BaseUnit => ElectricCurrentUnit.Ampere;

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public static BaseDimensions BaseDimensions
        {
            get;
        }

        /// <summary>
        ///     All units of measurement for the ElectricCurrent quantity.
        /// </summary>
        public static ElectricCurrentUnit[] Units { get; } = Enum.GetValues(typeof(ElectricCurrentUnit)).Cast<ElectricCurrentUnit>().Except(new ElectricCurrentUnit[]{ ElectricCurrentUnit.Undefined }).ToArray();

        /// <summary>
        ///     Get ElectricCurrent in Amperes.
        /// </summary>
        public double Amperes => As(ElectricCurrentUnit.Ampere);

        /// <summary>
        ///     Get ElectricCurrent in Centiamperes.
        /// </summary>
        public double Centiamperes => As(ElectricCurrentUnit.Centiampere);

        /// <summary>
        ///     Get ElectricCurrent in Kiloamperes.
        /// </summary>
        public double Kiloamperes => As(ElectricCurrentUnit.Kiloampere);

        /// <summary>
        ///     Get ElectricCurrent in Megaamperes.
        /// </summary>
        public double Megaamperes => As(ElectricCurrentUnit.Megaampere);

        /// <summary>
        ///     Get ElectricCurrent in Microamperes.
        /// </summary>
        public double Microamperes => As(ElectricCurrentUnit.Microampere);

        /// <summary>
        ///     Get ElectricCurrent in Milliamperes.
        /// </summary>
        public double Milliamperes => As(ElectricCurrentUnit.Milliampere);

        /// <summary>
        ///     Get ElectricCurrent in Nanoamperes.
        /// </summary>
        public double Nanoamperes => As(ElectricCurrentUnit.Nanoampere);

        /// <summary>
        ///     Get ElectricCurrent in Picoamperes.
        /// </summary>
        public double Picoamperes => As(ElectricCurrentUnit.Picoampere);

        #endregion

        #region Static

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Ampere.
        /// </summary>
        public static ElectricCurrent Zero => new ElectricCurrent(0, BaseUnit);

        /// <summary>
        ///     Get ElectricCurrent from Amperes.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static ElectricCurrent FromAmperes(double amperes)
#else
        public static ElectricCurrent FromAmperes(QuantityValue amperes)
#endif
        {
            double value = (double) amperes;
            return new ElectricCurrent(value, ElectricCurrentUnit.Ampere);
        }

        /// <summary>
        ///     Get ElectricCurrent from Centiamperes.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static ElectricCurrent FromCentiamperes(double centiamperes)
#else
        public static ElectricCurrent FromCentiamperes(QuantityValue centiamperes)
#endif
        {
            double value = (double) centiamperes;
            return new ElectricCurrent(value, ElectricCurrentUnit.Centiampere);
        }

        /// <summary>
        ///     Get ElectricCurrent from Kiloamperes.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static ElectricCurrent FromKiloamperes(double kiloamperes)
#else
        public static ElectricCurrent FromKiloamperes(QuantityValue kiloamperes)
#endif
        {
            double value = (double) kiloamperes;
            return new ElectricCurrent(value, ElectricCurrentUnit.Kiloampere);
        }

        /// <summary>
        ///     Get ElectricCurrent from Megaamperes.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static ElectricCurrent FromMegaamperes(double megaamperes)
#else
        public static ElectricCurrent FromMegaamperes(QuantityValue megaamperes)
#endif
        {
            double value = (double) megaamperes;
            return new ElectricCurrent(value, ElectricCurrentUnit.Megaampere);
        }

        /// <summary>
        ///     Get ElectricCurrent from Microamperes.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static ElectricCurrent FromMicroamperes(double microamperes)
#else
        public static ElectricCurrent FromMicroamperes(QuantityValue microamperes)
#endif
        {
            double value = (double) microamperes;
            return new ElectricCurrent(value, ElectricCurrentUnit.Microampere);
        }

        /// <summary>
        ///     Get ElectricCurrent from Milliamperes.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static ElectricCurrent FromMilliamperes(double milliamperes)
#else
        public static ElectricCurrent FromMilliamperes(QuantityValue milliamperes)
#endif
        {
            double value = (double) milliamperes;
            return new ElectricCurrent(value, ElectricCurrentUnit.Milliampere);
        }

        /// <summary>
        ///     Get ElectricCurrent from Nanoamperes.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static ElectricCurrent FromNanoamperes(double nanoamperes)
#else
        public static ElectricCurrent FromNanoamperes(QuantityValue nanoamperes)
#endif
        {
            double value = (double) nanoamperes;
            return new ElectricCurrent(value, ElectricCurrentUnit.Nanoampere);
        }

        /// <summary>
        ///     Get ElectricCurrent from Picoamperes.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static ElectricCurrent FromPicoamperes(double picoamperes)
#else
        public static ElectricCurrent FromPicoamperes(QuantityValue picoamperes)
#endif
        {
            double value = (double) picoamperes;
            return new ElectricCurrent(value, ElectricCurrentUnit.Picoampere);
        }


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="ElectricCurrentUnit" /> to <see cref="ElectricCurrent" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>ElectricCurrent unit value.</returns>
#if WINDOWS_UWP
        // Fix name conflict with parameter "value"
        [return: System.Runtime.InteropServices.WindowsRuntime.ReturnValueName("returnValue")]
        public static ElectricCurrent From(double value, ElectricCurrentUnit fromUnit)
#else
        public static ElectricCurrent From(QuantityValue value, ElectricCurrentUnit fromUnit)
#endif
        {
            return new ElectricCurrent((double)value, fromUnit);
        }

        public IQuantity From(double value, int fromUnit)
        {
            return new ElectricCurrent((double)value, (ElectricCurrentUnit)fromUnit);
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        [UsedImplicitly]
        public static string GetAbbreviation(ElectricCurrentUnit unit)
        {
            return GetAbbreviation(unit, null);
        }

        #endregion

        #region Equality / IComparable

        public int CompareTo(object obj)
        {
            if(obj is null) throw new ArgumentNullException(nameof(obj));
            if(!(obj is ElectricCurrent)) throw new ArgumentException("Expected type ElectricCurrent.", nameof(obj));

            return CompareTo((ElectricCurrent)obj);
        }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
#if WINDOWS_UWP
        internal
#else
        public
#endif
        int CompareTo(ElectricCurrent other)
        {
            return _value.CompareTo(other.AsBaseNumericType(this.Unit));
        }

        [Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals(ElectricCurrent, double, ComparisonType) to provide the max allowed absolute or relative error.")]
        public override bool Equals(object obj)
        {
            if(obj is null || !(obj is ElectricCurrent))
                return false;

            var objQuantity = (ElectricCurrent)obj;
            return _value.Equals(objQuantity.AsBaseNumericType(this.Unit));
        }

        /// <summary>
        ///     <para>
        ///     Compare equality to another ElectricCurrent within the given absolute or relative tolerance.
        ///     </para>
        ///     <para>
        ///     Relative tolerance is defined as the maximum allowable absolute difference between this quantity's value and
        ///     <paramref name="other"/> as a percentage of this quantity's value. <paramref name="other"/> will be converted into
        ///     this quantity's unit for comparison. A relative tolerance of 0.01 means the absolute difference must be within +/- 1% of
        ///     this quantity's value to be considered equal.
        ///     <example>
        ///     In this example, the two quantities will be equal if the value of b is within +/- 1% of a (0.02m or 2cm).
        ///     <code>
        ///     var a = Length.FromMeters(2.0);
        ///     var b = Length.FromInches(50.0);
        ///     a.Equals(b, 0.01, ComparisonType.Relative);
        ///     </code>
        ///     </example>
        ///     </para>
        ///     <para>
        ///     Absolute tolerance is defined as the maximum allowable absolute difference between this quantity's value and
        ///     <paramref name="other"/> as a fixed number in this quantity's unit. <paramref name="other"/> will be converted into
        ///     this quantity's unit for comparison.
        ///     <example>
        ///     In this example, the two quantities will be equal if the value of b is within 0.01 of a (0.01m or 1cm).
        ///     <code>
        ///     var a = Length.FromMeters(2.0);
        ///     var b = Length.FromInches(50.0);
        ///     a.Equals(b, 0.01, ComparisonType.Absolute);
        ///     </code>
        ///     </example>
        ///     </para>
        ///     <para>
        ///     Note that it is advised against specifying zero difference, due to the nature
        ///     of floating point operations and using System.Double internally.
        ///     </para>
        /// </summary>
        /// <param name="other">The other quantity to compare to.</param>
        /// <param name="tolerance">The absolute or relative tolerance value. Must be greater than or equal to 0.</param>
        /// <param name="comparisonType">The comparison type: either relative or absolute.</param>
        /// <returns>True if the absolute difference between the two values is not greater than the specified relative or absolute tolerance.</returns>
        public bool Equals(ElectricCurrent other, double tolerance, ComparisonType comparisonType)
        {
            if(tolerance < 0)
                throw new ArgumentOutOfRangeException("tolerance", "Tolerance must be greater than or equal to 0.");

            double thisValue = (double)this.Value;
            double otherValueInThisUnits = other.As(this.Unit);

            return UnitsNet.Comparison.Equals(thisValue, otherValueInThisUnits, tolerance, comparisonType);
        }

        /// <summary>
        ///     Compare equality to another ElectricCurrent by specifying a max allowed difference.
        ///     Note that it is advised against specifying zero difference, due to the nature
        ///     of floating point operations and using System.Double internally.
        /// </summary>
        /// <param name="other">Other quantity to compare to.</param>
        /// <param name="maxError">Max error allowed.</param>
        /// <returns>True if the difference between the two values is not greater than the specified max.</returns>
        [Obsolete("Please use the Equals(ElectricCurrent, double, ComparisonType) overload. This method will be removed in a future version.")]
        public bool Equals(ElectricCurrent other, ElectricCurrent maxError)
        {
            return Math.Abs(_value - other.AsBaseNumericType(this.Unit)) <= maxError.AsBaseNumericType(this.Unit);
        }

        /// <summary>
        ///     Returns the hash code for this instance.
        /// </summary>
        /// <returns>A hash code for the current ElectricCurrent.</returns>
        public override int GetHashCode()
        {
            return new { type = typeof(ElectricCurrent), Value, Unit }.GetHashCode();
        }

        #endregion

        #region Conversion

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(ElectricCurrentUnit unit)
        {
            if(Unit == unit)
                return Convert.ToDouble(Value);

            var converted = AsBaseNumericType(unit);
            return Convert.ToDouble(converted);
        }

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(int unitEnumIndex)
        {
            var unit = (ElectricCurrentUnit)unitEnumIndex;
            return As(unit);
        }

        /// <summary>
        ///     Converts this ElectricCurrent to another ElectricCurrent with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A ElectricCurrent with the specified unit.</returns>
        public ElectricCurrent ToUnit(ElectricCurrentUnit unit)
        {
            var convertedValue = AsBaseNumericType(unit);
            return new ElectricCurrent(convertedValue, unit);
        }

        /// <summary>
        ///     Converts the current value + unit to the base unit.
        ///     This is typically the first step in converting from one unit to another.
        /// </summary>
        /// <returns>The value in the base unit representation.</returns>
        private double AsBaseUnit()
        {
            switch(Unit)
            {
                case ElectricCurrentUnit.Ampere: return _value;
                case ElectricCurrentUnit.Centiampere: return (_value) * 1e-2d;
                case ElectricCurrentUnit.Kiloampere: return (_value) * 1e3d;
                case ElectricCurrentUnit.Megaampere: return (_value) * 1e6d;
                case ElectricCurrentUnit.Microampere: return (_value) * 1e-6d;
                case ElectricCurrentUnit.Milliampere: return (_value) * 1e-3d;
                case ElectricCurrentUnit.Nanoampere: return (_value) * 1e-9d;
                case ElectricCurrentUnit.Picoampere: return (_value) * 1e-12d;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to base units.");
            }
        }

        private double AsBaseNumericType(ElectricCurrentUnit unit)
        {
            if(Unit == unit)
                return _value;

            var baseUnitValue = AsBaseUnit();

            switch(unit)
            {
                case ElectricCurrentUnit.Ampere: return baseUnitValue;
                case ElectricCurrentUnit.Centiampere: return (baseUnitValue) / 1e-2d;
                case ElectricCurrentUnit.Kiloampere: return (baseUnitValue) / 1e3d;
                case ElectricCurrentUnit.Megaampere: return (baseUnitValue) / 1e6d;
                case ElectricCurrentUnit.Microampere: return (baseUnitValue) / 1e-6d;
                case ElectricCurrentUnit.Milliampere: return (baseUnitValue) / 1e-3d;
                case ElectricCurrentUnit.Nanoampere: return (baseUnitValue) / 1e-9d;
                case ElectricCurrentUnit.Picoampere: return (baseUnitValue) / 1e-12d;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to {unit}.");
            }
        }

        #endregion

        #region Parsing

        /// <summary>
        ///     Parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="ArgumentException">
        ///     Expected string to have one or two pairs of quantity and unit in the format
        ///     "&lt;quantity&gt; &lt;unit&gt;". Eg. "5.5 m" or "1ft 2in"
        /// </exception>
        /// <exception cref="AmbiguousUnitParseException">
        ///     More than one unit is represented by the specified unit abbreviation.
        ///     Example: Volume.Parse("1 cup") will throw, because it can refer to any of
        ///     <see cref="VolumeUnit.MetricCup" />, <see cref="VolumeUnit.UsLegalCup" /> and <see cref="VolumeUnit.UsCustomaryCup" />.
        /// </exception>
        /// <exception cref="UnitsNetException">
        ///     If anything else goes wrong, typically due to a bug or unhandled case.
        ///     We wrap exceptions in <see cref="UnitsNetException" /> to allow you to distinguish
        ///     Units.NET exceptions from other exceptions.
        /// </exception>
        public static ElectricCurrent Parse(string str)
        {
            return Parse(str, null);
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        public static bool TryParse([CanBeNull] string str, out ElectricCurrent result)
        {
            return TryParse(str, null, out result);
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        public static ElectricCurrentUnit ParseUnit(string str)
        {
            return ParseUnit(str, (IFormatProvider)null);
        }

        #endregion

        /// <summary>
        ///     Set the default unit used by ToString(). Default is Ampere
        /// </summary>
        [Obsolete("This is no longer used since we will instead use the quantity's Unit value as default.")]
        public static ElectricCurrentUnit ToStringDefaultUnit { get; set; } = ElectricCurrentUnit.Ampere;

        /// <summary>
        ///     Get default string representation of value and unit.
        /// </summary>
        /// <returns>String representation.</returns>
        public override string ToString()
        {
            return ToString(Unit);
        }

        /// <summary>
        ///     Get string representation of value and unit. Using current UI culture and two significant digits after radix.
        /// </summary>
        /// <param name="unit">Unit representation to use.</param>
        /// <returns>String representation.</returns>
        public string ToString(ElectricCurrentUnit unit)
        {
            return ToString(unit, null, 2);
        }

        /// <summary>
        /// Represents the largest possible value of ElectricCurrent
        /// </summary>
        public static ElectricCurrent MaxValue => new ElectricCurrent(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of ElectricCurrent
        /// </summary>
        public static ElectricCurrent MinValue => new ElectricCurrent(double.MinValue, BaseUnit);

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        public QuantityType Type => ElectricCurrent.QuantityType;

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public BaseDimensions Dimensions => ElectricCurrent.BaseDimensions;
    }
}
