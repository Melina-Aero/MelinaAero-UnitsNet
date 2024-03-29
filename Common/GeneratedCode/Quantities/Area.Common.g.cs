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
    ///     Area is a quantity that expresses the extent of a two-dimensional surface or shape, or planar lamina, in the plane. Area can be understood as the amount of material with a given thickness that would be necessary to fashion a model of the shape, or the amount of paint necessary to cover the surface with a single coat.[1] It is the two-dimensional analog of the length of a curve (a one-dimensional concept) or the volume of a solid (a three-dimensional concept).
    /// </summary>
    // ReSharper disable once PartialTypeWithSinglePart

    // Windows Runtime Component has constraints on public types: https://msdn.microsoft.com/en-us/library/br230301.aspx#Declaring types in Windows Runtime Components
    // Public structures can't have any members other than public fields, and those fields must be value types or strings.
    // Public classes must be sealed (NotInheritable in Visual Basic). If your programming model requires polymorphism, you can create a public interface and implement that interface on the classes that must be polymorphic.
#if WINDOWS_UWP
    public sealed partial class Area : IQuantity
#else
    public partial struct Area : IQuantity, IComparable, IComparable<Area>
#endif
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly AreaUnit? _unit;

        /// <summary>
        ///     The unit this quantity was constructed with -or- <see cref="BaseUnit" /> if default ctor was used.
        /// </summary>
        public AreaUnit Unit => _unit.GetValueOrDefault(BaseUnit);

        static Area()
        {
            BaseDimensions = new BaseDimensions(2, 0, 0, 0, 0, 0, 0);
        }

        /// <summary>
        ///     Creates the quantity with the given value in the base unit SquareMeter.
        /// </summary>
        [Obsolete("Use the constructor that takes a unit parameter. This constructor will be removed in a future version.")]
        public Area(double squaremeters)
        {
            _value = Convert.ToDouble(squaremeters);
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
        Area(double numericValue, AreaUnit unit)
        {
            _value = numericValue;
            _unit = unit;
        }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
        /// <summary>
        ///     Creates the quantity with the given value assuming the base unit SquareMeter.
        /// </summary>
        /// <param name="squaremeters">Value assuming base unit SquareMeter.</param>
#if WINDOWS_UWP
        private
#else
        [Obsolete("Use the constructor that takes a unit parameter. This constructor will be removed in a future version.")]
        public
#endif
        Area(long squaremeters) : this(Convert.ToDouble(squaremeters), BaseUnit) { }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
        // Windows Runtime Component does not support decimal type
        /// <summary>
        ///     Creates the quantity with the given value assuming the base unit SquareMeter.
        /// </summary>
        /// <param name="squaremeters">Value assuming base unit SquareMeter.</param>
#if WINDOWS_UWP
        private
#else
        [Obsolete("Use the constructor that takes a unit parameter. This constructor will be removed in a future version.")]
        public
#endif
        Area(decimal squaremeters) : this(Convert.ToDouble(squaremeters), BaseUnit) { }

        #region Properties

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        public static QuantityType QuantityType => QuantityType.Area;

        /// <summary>
        ///     The base unit representation of this quantity for the numeric value stored internally. All conversions go via this value.
        /// </summary>
        public static AreaUnit BaseUnit => AreaUnit.SquareMeter;

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public static BaseDimensions BaseDimensions
        {
            get;
        }

        /// <summary>
        ///     All units of measurement for the Area quantity.
        /// </summary>
        public static AreaUnit[] Units { get; } = Enum.GetValues(typeof(AreaUnit)).Cast<AreaUnit>().Except(new AreaUnit[]{ AreaUnit.Undefined }).ToArray();

        /// <summary>
        ///     Get Area in Acres.
        /// </summary>
        public double Acres => As(AreaUnit.Acre);

        /// <summary>
        ///     Get Area in Hectares.
        /// </summary>
        public double Hectares => As(AreaUnit.Hectare);

        /// <summary>
        ///     Get Area in SquareCentimeters.
        /// </summary>
        public double SquareCentimeters => As(AreaUnit.SquareCentimeter);

        /// <summary>
        ///     Get Area in SquareDecimeters.
        /// </summary>
        public double SquareDecimeters => As(AreaUnit.SquareDecimeter);

        /// <summary>
        ///     Get Area in SquareFeet.
        /// </summary>
        public double SquareFeet => As(AreaUnit.SquareFoot);

        /// <summary>
        ///     Get Area in SquareInches.
        /// </summary>
        public double SquareInches => As(AreaUnit.SquareInch);

        /// <summary>
        ///     Get Area in SquareKilometers.
        /// </summary>
        public double SquareKilometers => As(AreaUnit.SquareKilometer);

        /// <summary>
        ///     Get Area in SquareMeters.
        /// </summary>
        public double SquareMeters => As(AreaUnit.SquareMeter);

        /// <summary>
        ///     Get Area in SquareMicrometers.
        /// </summary>
        public double SquareMicrometers => As(AreaUnit.SquareMicrometer);

        /// <summary>
        ///     Get Area in SquareMiles.
        /// </summary>
        public double SquareMiles => As(AreaUnit.SquareMile);

        /// <summary>
        ///     Get Area in SquareMillimeters.
        /// </summary>
        public double SquareMillimeters => As(AreaUnit.SquareMillimeter);

        /// <summary>
        ///     Get Area in SquareYards.
        /// </summary>
        public double SquareYards => As(AreaUnit.SquareYard);

        /// <summary>
        ///     Get Area in UsSurveySquareFeet.
        /// </summary>
        public double UsSurveySquareFeet => As(AreaUnit.UsSurveySquareFoot);

        #endregion

        #region Static

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit SquareMeter.
        /// </summary>
        public static Area Zero => new Area(0, BaseUnit);

        /// <summary>
        ///     Get Area from Acres.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Area FromAcres(double acres)
#else
        public static Area FromAcres(QuantityValue acres)
#endif
        {
            double value = (double) acres;
            return new Area(value, AreaUnit.Acre);
        }

        /// <summary>
        ///     Get Area from Hectares.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Area FromHectares(double hectares)
#else
        public static Area FromHectares(QuantityValue hectares)
#endif
        {
            double value = (double) hectares;
            return new Area(value, AreaUnit.Hectare);
        }

        /// <summary>
        ///     Get Area from SquareCentimeters.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Area FromSquareCentimeters(double squarecentimeters)
#else
        public static Area FromSquareCentimeters(QuantityValue squarecentimeters)
#endif
        {
            double value = (double) squarecentimeters;
            return new Area(value, AreaUnit.SquareCentimeter);
        }

        /// <summary>
        ///     Get Area from SquareDecimeters.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Area FromSquareDecimeters(double squaredecimeters)
#else
        public static Area FromSquareDecimeters(QuantityValue squaredecimeters)
#endif
        {
            double value = (double) squaredecimeters;
            return new Area(value, AreaUnit.SquareDecimeter);
        }

        /// <summary>
        ///     Get Area from SquareFeet.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Area FromSquareFeet(double squarefeet)
#else
        public static Area FromSquareFeet(QuantityValue squarefeet)
#endif
        {
            double value = (double) squarefeet;
            return new Area(value, AreaUnit.SquareFoot);
        }

        /// <summary>
        ///     Get Area from SquareInches.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Area FromSquareInches(double squareinches)
#else
        public static Area FromSquareInches(QuantityValue squareinches)
#endif
        {
            double value = (double) squareinches;
            return new Area(value, AreaUnit.SquareInch);
        }

        /// <summary>
        ///     Get Area from SquareKilometers.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Area FromSquareKilometers(double squarekilometers)
#else
        public static Area FromSquareKilometers(QuantityValue squarekilometers)
#endif
        {
            double value = (double) squarekilometers;
            return new Area(value, AreaUnit.SquareKilometer);
        }

        /// <summary>
        ///     Get Area from SquareMeters.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Area FromSquareMeters(double squaremeters)
#else
        public static Area FromSquareMeters(QuantityValue squaremeters)
#endif
        {
            double value = (double) squaremeters;
            return new Area(value, AreaUnit.SquareMeter);
        }

        /// <summary>
        ///     Get Area from SquareMicrometers.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Area FromSquareMicrometers(double squaremicrometers)
#else
        public static Area FromSquareMicrometers(QuantityValue squaremicrometers)
#endif
        {
            double value = (double) squaremicrometers;
            return new Area(value, AreaUnit.SquareMicrometer);
        }

        /// <summary>
        ///     Get Area from SquareMiles.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Area FromSquareMiles(double squaremiles)
#else
        public static Area FromSquareMiles(QuantityValue squaremiles)
#endif
        {
            double value = (double) squaremiles;
            return new Area(value, AreaUnit.SquareMile);
        }

        /// <summary>
        ///     Get Area from SquareMillimeters.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Area FromSquareMillimeters(double squaremillimeters)
#else
        public static Area FromSquareMillimeters(QuantityValue squaremillimeters)
#endif
        {
            double value = (double) squaremillimeters;
            return new Area(value, AreaUnit.SquareMillimeter);
        }

        /// <summary>
        ///     Get Area from SquareYards.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Area FromSquareYards(double squareyards)
#else
        public static Area FromSquareYards(QuantityValue squareyards)
#endif
        {
            double value = (double) squareyards;
            return new Area(value, AreaUnit.SquareYard);
        }

        /// <summary>
        ///     Get Area from UsSurveySquareFeet.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Area FromUsSurveySquareFeet(double ussurveysquarefeet)
#else
        public static Area FromUsSurveySquareFeet(QuantityValue ussurveysquarefeet)
#endif
        {
            double value = (double) ussurveysquarefeet;
            return new Area(value, AreaUnit.UsSurveySquareFoot);
        }


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="AreaUnit" /> to <see cref="Area" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>Area unit value.</returns>
#if WINDOWS_UWP
        // Fix name conflict with parameter "value"
        [return: System.Runtime.InteropServices.WindowsRuntime.ReturnValueName("returnValue")]
        public static Area From(double value, AreaUnit fromUnit)
#else
        public static Area From(QuantityValue value, AreaUnit fromUnit)
#endif
        {
            return new Area((double)value, fromUnit);
        }

        public IQuantity From(double value, int fromUnit)
        {
            return new Area((double)value, (AreaUnit)fromUnit);
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        [UsedImplicitly]
        public static string GetAbbreviation(AreaUnit unit)
        {
            return GetAbbreviation(unit, null);
        }

        #endregion

        #region Equality / IComparable

        public int CompareTo(object obj)
        {
            if(obj is null) throw new ArgumentNullException(nameof(obj));
            if(!(obj is Area)) throw new ArgumentException("Expected type Area.", nameof(obj));

            return CompareTo((Area)obj);
        }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
#if WINDOWS_UWP
        internal
#else
        public
#endif
        int CompareTo(Area other)
        {
            return _value.CompareTo(other.AsBaseNumericType(this.Unit));
        }

        [Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals(Area, double, ComparisonType) to provide the max allowed absolute or relative error.")]
        public override bool Equals(object obj)
        {
            if(obj is null || !(obj is Area))
                return false;

            var objQuantity = (Area)obj;
            return _value.Equals(objQuantity.AsBaseNumericType(this.Unit));
        }

        /// <summary>
        ///     <para>
        ///     Compare equality to another Area within the given absolute or relative tolerance.
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
        public bool Equals(Area other, double tolerance, ComparisonType comparisonType)
        {
            if(tolerance < 0)
                throw new ArgumentOutOfRangeException("tolerance", "Tolerance must be greater than or equal to 0.");

            double thisValue = (double)this.Value;
            double otherValueInThisUnits = other.As(this.Unit);

            return UnitsNet.Comparison.Equals(thisValue, otherValueInThisUnits, tolerance, comparisonType);
        }

        /// <summary>
        ///     Compare equality to another Area by specifying a max allowed difference.
        ///     Note that it is advised against specifying zero difference, due to the nature
        ///     of floating point operations and using System.Double internally.
        /// </summary>
        /// <param name="other">Other quantity to compare to.</param>
        /// <param name="maxError">Max error allowed.</param>
        /// <returns>True if the difference between the two values is not greater than the specified max.</returns>
        [Obsolete("Please use the Equals(Area, double, ComparisonType) overload. This method will be removed in a future version.")]
        public bool Equals(Area other, Area maxError)
        {
            return Math.Abs(_value - other.AsBaseNumericType(this.Unit)) <= maxError.AsBaseNumericType(this.Unit);
        }

        /// <summary>
        ///     Returns the hash code for this instance.
        /// </summary>
        /// <returns>A hash code for the current Area.</returns>
        public override int GetHashCode()
        {
            return new { type = typeof(Area), Value, Unit }.GetHashCode();
        }

        #endregion

        #region Conversion

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(AreaUnit unit)
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
            var unit = (AreaUnit)unitEnumIndex;
            return As(unit);
        }

        /// <summary>
        ///     Converts this Area to another Area with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Area with the specified unit.</returns>
        public Area ToUnit(AreaUnit unit)
        {
            var convertedValue = AsBaseNumericType(unit);
            return new Area(convertedValue, unit);
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
                case AreaUnit.Acre: return _value*4046.85642;
                case AreaUnit.Hectare: return _value*1e4;
                case AreaUnit.SquareCentimeter: return _value*1e-4;
                case AreaUnit.SquareDecimeter: return _value*1e-2;
                case AreaUnit.SquareFoot: return _value*0.092903;
                case AreaUnit.SquareInch: return _value*0.00064516;
                case AreaUnit.SquareKilometer: return _value*1e6;
                case AreaUnit.SquareMeter: return _value;
                case AreaUnit.SquareMicrometer: return _value*1e-12;
                case AreaUnit.SquareMile: return _value*2.59e6;
                case AreaUnit.SquareMillimeter: return _value*1e-6;
                case AreaUnit.SquareYard: return _value*0.836127;
                case AreaUnit.UsSurveySquareFoot: return _value*0.09290341161;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to base units.");
            }
        }

        private double AsBaseNumericType(AreaUnit unit)
        {
            if(Unit == unit)
                return _value;

            var baseUnitValue = AsBaseUnit();

            switch(unit)
            {
                case AreaUnit.Acre: return baseUnitValue/4046.85642;
                case AreaUnit.Hectare: return baseUnitValue/1e4;
                case AreaUnit.SquareCentimeter: return baseUnitValue/1e-4;
                case AreaUnit.SquareDecimeter: return baseUnitValue/1e-2;
                case AreaUnit.SquareFoot: return baseUnitValue/0.092903;
                case AreaUnit.SquareInch: return baseUnitValue/0.00064516;
                case AreaUnit.SquareKilometer: return baseUnitValue/1e6;
                case AreaUnit.SquareMeter: return baseUnitValue;
                case AreaUnit.SquareMicrometer: return baseUnitValue/1e-12;
                case AreaUnit.SquareMile: return baseUnitValue/2.59e6;
                case AreaUnit.SquareMillimeter: return baseUnitValue/1e-6;
                case AreaUnit.SquareYard: return baseUnitValue/0.836127;
                case AreaUnit.UsSurveySquareFoot: return baseUnitValue/0.09290341161;
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
        public static Area Parse(string str)
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
        public static bool TryParse([CanBeNull] string str, out Area result)
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
        public static AreaUnit ParseUnit(string str)
        {
            return ParseUnit(str, (IFormatProvider)null);
        }

        #endregion

        /// <summary>
        ///     Set the default unit used by ToString(). Default is SquareMeter
        /// </summary>
        [Obsolete("This is no longer used since we will instead use the quantity's Unit value as default.")]
        public static AreaUnit ToStringDefaultUnit { get; set; } = AreaUnit.SquareMeter;

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
        public string ToString(AreaUnit unit)
        {
            return ToString(unit, null, 2);
        }

        /// <summary>
        /// Represents the largest possible value of Area
        /// </summary>
        public static Area MaxValue => new Area(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Area
        /// </summary>
        public static Area MinValue => new Area(double.MinValue, BaseUnit);

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        public QuantityType Type => Area.QuantityType;

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public BaseDimensions Dimensions => Area.BaseDimensions;
    }
}
