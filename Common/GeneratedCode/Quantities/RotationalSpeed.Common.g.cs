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
    ///     Rotational speed (sometimes called speed of revolution) is the number of complete rotations, revolutions, cycles, or turns per time unit. Rotational speed is a cyclic frequency, measured in radians per second or in hertz in the SI System by scientists, or in revolutions per minute (rpm or min-1) or revolutions per second in everyday life. The symbol for rotational speed is ω (the Greek lowercase letter "omega").
    /// </summary>
    // ReSharper disable once PartialTypeWithSinglePart

    // Windows Runtime Component has constraints on public types: https://msdn.microsoft.com/en-us/library/br230301.aspx#Declaring types in Windows Runtime Components
    // Public structures can't have any members other than public fields, and those fields must be value types or strings.
    // Public classes must be sealed (NotInheritable in Visual Basic). If your programming model requires polymorphism, you can create a public interface and implement that interface on the classes that must be polymorphic.
#if WINDOWS_UWP
    public sealed partial class RotationalSpeed : IQuantity
#else
    public partial struct RotationalSpeed : IQuantity, IComparable, IComparable<RotationalSpeed>
#endif
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly RotationalSpeedUnit? _unit;

        /// <summary>
        ///     The unit this quantity was constructed with -or- <see cref="BaseUnit" /> if default ctor was used.
        /// </summary>
        public RotationalSpeedUnit Unit => _unit.GetValueOrDefault(BaseUnit);

        static RotationalSpeed()
        {
            BaseDimensions = new BaseDimensions(0, 0, -1, 0, 0, 0, 0);
        }

        /// <summary>
        ///     Creates the quantity with the given value in the base unit RadianPerSecond.
        /// </summary>
        [Obsolete("Use the constructor that takes a unit parameter. This constructor will be removed in a future version.")]
        public RotationalSpeed(double radianspersecond)
        {
            _value = Convert.ToDouble(radianspersecond);
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
        RotationalSpeed(double numericValue, RotationalSpeedUnit unit)
        {
            _value = numericValue;
            _unit = unit;
        }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
        /// <summary>
        ///     Creates the quantity with the given value assuming the base unit RadianPerSecond.
        /// </summary>
        /// <param name="radianspersecond">Value assuming base unit RadianPerSecond.</param>
#if WINDOWS_UWP
        private
#else
        [Obsolete("Use the constructor that takes a unit parameter. This constructor will be removed in a future version.")]
        public
#endif
        RotationalSpeed(long radianspersecond) : this(Convert.ToDouble(radianspersecond), BaseUnit) { }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
        // Windows Runtime Component does not support decimal type
        /// <summary>
        ///     Creates the quantity with the given value assuming the base unit RadianPerSecond.
        /// </summary>
        /// <param name="radianspersecond">Value assuming base unit RadianPerSecond.</param>
#if WINDOWS_UWP
        private
#else
        [Obsolete("Use the constructor that takes a unit parameter. This constructor will be removed in a future version.")]
        public
#endif
        RotationalSpeed(decimal radianspersecond) : this(Convert.ToDouble(radianspersecond), BaseUnit) { }

        #region Properties

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        public static QuantityType QuantityType => QuantityType.RotationalSpeed;

        /// <summary>
        ///     The base unit representation of this quantity for the numeric value stored internally. All conversions go via this value.
        /// </summary>
        public static RotationalSpeedUnit BaseUnit => RotationalSpeedUnit.RadianPerSecond;

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public static BaseDimensions BaseDimensions
        {
            get;
        }

        /// <summary>
        ///     All units of measurement for the RotationalSpeed quantity.
        /// </summary>
        public static RotationalSpeedUnit[] Units { get; } = Enum.GetValues(typeof(RotationalSpeedUnit)).Cast<RotationalSpeedUnit>().Except(new RotationalSpeedUnit[]{ RotationalSpeedUnit.Undefined }).ToArray();

        /// <summary>
        ///     Get RotationalSpeed in CentiradiansPerSecond.
        /// </summary>
        public double CentiradiansPerSecond => As(RotationalSpeedUnit.CentiradianPerSecond);

        /// <summary>
        ///     Get RotationalSpeed in DeciradiansPerSecond.
        /// </summary>
        public double DeciradiansPerSecond => As(RotationalSpeedUnit.DeciradianPerSecond);

        /// <summary>
        ///     Get RotationalSpeed in DegreesPerMinute.
        /// </summary>
        public double DegreesPerMinute => As(RotationalSpeedUnit.DegreePerMinute);

        /// <summary>
        ///     Get RotationalSpeed in DegreesPerSecond.
        /// </summary>
        public double DegreesPerSecond => As(RotationalSpeedUnit.DegreePerSecond);

        /// <summary>
        ///     Get RotationalSpeed in MicrodegreesPerSecond.
        /// </summary>
        public double MicrodegreesPerSecond => As(RotationalSpeedUnit.MicrodegreePerSecond);

        /// <summary>
        ///     Get RotationalSpeed in MicroradiansPerSecond.
        /// </summary>
        public double MicroradiansPerSecond => As(RotationalSpeedUnit.MicroradianPerSecond);

        /// <summary>
        ///     Get RotationalSpeed in MillidegreesPerSecond.
        /// </summary>
        public double MillidegreesPerSecond => As(RotationalSpeedUnit.MillidegreePerSecond);

        /// <summary>
        ///     Get RotationalSpeed in MilliradiansPerSecond.
        /// </summary>
        public double MilliradiansPerSecond => As(RotationalSpeedUnit.MilliradianPerSecond);

        /// <summary>
        ///     Get RotationalSpeed in NanodegreesPerSecond.
        /// </summary>
        public double NanodegreesPerSecond => As(RotationalSpeedUnit.NanodegreePerSecond);

        /// <summary>
        ///     Get RotationalSpeed in NanoradiansPerSecond.
        /// </summary>
        public double NanoradiansPerSecond => As(RotationalSpeedUnit.NanoradianPerSecond);

        /// <summary>
        ///     Get RotationalSpeed in RadiansPerSecond.
        /// </summary>
        public double RadiansPerSecond => As(RotationalSpeedUnit.RadianPerSecond);

        /// <summary>
        ///     Get RotationalSpeed in RevolutionsPerMinute.
        /// </summary>
        public double RevolutionsPerMinute => As(RotationalSpeedUnit.RevolutionPerMinute);

        /// <summary>
        ///     Get RotationalSpeed in RevolutionsPerSecond.
        /// </summary>
        public double RevolutionsPerSecond => As(RotationalSpeedUnit.RevolutionPerSecond);

        #endregion

        #region Static

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit RadianPerSecond.
        /// </summary>
        public static RotationalSpeed Zero => new RotationalSpeed(0, BaseUnit);

        /// <summary>
        ///     Get RotationalSpeed from CentiradiansPerSecond.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static RotationalSpeed FromCentiradiansPerSecond(double centiradianspersecond)
#else
        public static RotationalSpeed FromCentiradiansPerSecond(QuantityValue centiradianspersecond)
#endif
        {
            double value = (double) centiradianspersecond;
            return new RotationalSpeed(value, RotationalSpeedUnit.CentiradianPerSecond);
        }

        /// <summary>
        ///     Get RotationalSpeed from DeciradiansPerSecond.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static RotationalSpeed FromDeciradiansPerSecond(double deciradianspersecond)
#else
        public static RotationalSpeed FromDeciradiansPerSecond(QuantityValue deciradianspersecond)
#endif
        {
            double value = (double) deciradianspersecond;
            return new RotationalSpeed(value, RotationalSpeedUnit.DeciradianPerSecond);
        }

        /// <summary>
        ///     Get RotationalSpeed from DegreesPerMinute.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static RotationalSpeed FromDegreesPerMinute(double degreesperminute)
#else
        public static RotationalSpeed FromDegreesPerMinute(QuantityValue degreesperminute)
#endif
        {
            double value = (double) degreesperminute;
            return new RotationalSpeed(value, RotationalSpeedUnit.DegreePerMinute);
        }

        /// <summary>
        ///     Get RotationalSpeed from DegreesPerSecond.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static RotationalSpeed FromDegreesPerSecond(double degreespersecond)
#else
        public static RotationalSpeed FromDegreesPerSecond(QuantityValue degreespersecond)
#endif
        {
            double value = (double) degreespersecond;
            return new RotationalSpeed(value, RotationalSpeedUnit.DegreePerSecond);
        }

        /// <summary>
        ///     Get RotationalSpeed from MicrodegreesPerSecond.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static RotationalSpeed FromMicrodegreesPerSecond(double microdegreespersecond)
#else
        public static RotationalSpeed FromMicrodegreesPerSecond(QuantityValue microdegreespersecond)
#endif
        {
            double value = (double) microdegreespersecond;
            return new RotationalSpeed(value, RotationalSpeedUnit.MicrodegreePerSecond);
        }

        /// <summary>
        ///     Get RotationalSpeed from MicroradiansPerSecond.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static RotationalSpeed FromMicroradiansPerSecond(double microradianspersecond)
#else
        public static RotationalSpeed FromMicroradiansPerSecond(QuantityValue microradianspersecond)
#endif
        {
            double value = (double) microradianspersecond;
            return new RotationalSpeed(value, RotationalSpeedUnit.MicroradianPerSecond);
        }

        /// <summary>
        ///     Get RotationalSpeed from MillidegreesPerSecond.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static RotationalSpeed FromMillidegreesPerSecond(double millidegreespersecond)
#else
        public static RotationalSpeed FromMillidegreesPerSecond(QuantityValue millidegreespersecond)
#endif
        {
            double value = (double) millidegreespersecond;
            return new RotationalSpeed(value, RotationalSpeedUnit.MillidegreePerSecond);
        }

        /// <summary>
        ///     Get RotationalSpeed from MilliradiansPerSecond.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static RotationalSpeed FromMilliradiansPerSecond(double milliradianspersecond)
#else
        public static RotationalSpeed FromMilliradiansPerSecond(QuantityValue milliradianspersecond)
#endif
        {
            double value = (double) milliradianspersecond;
            return new RotationalSpeed(value, RotationalSpeedUnit.MilliradianPerSecond);
        }

        /// <summary>
        ///     Get RotationalSpeed from NanodegreesPerSecond.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static RotationalSpeed FromNanodegreesPerSecond(double nanodegreespersecond)
#else
        public static RotationalSpeed FromNanodegreesPerSecond(QuantityValue nanodegreespersecond)
#endif
        {
            double value = (double) nanodegreespersecond;
            return new RotationalSpeed(value, RotationalSpeedUnit.NanodegreePerSecond);
        }

        /// <summary>
        ///     Get RotationalSpeed from NanoradiansPerSecond.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static RotationalSpeed FromNanoradiansPerSecond(double nanoradianspersecond)
#else
        public static RotationalSpeed FromNanoradiansPerSecond(QuantityValue nanoradianspersecond)
#endif
        {
            double value = (double) nanoradianspersecond;
            return new RotationalSpeed(value, RotationalSpeedUnit.NanoradianPerSecond);
        }

        /// <summary>
        ///     Get RotationalSpeed from RadiansPerSecond.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static RotationalSpeed FromRadiansPerSecond(double radianspersecond)
#else
        public static RotationalSpeed FromRadiansPerSecond(QuantityValue radianspersecond)
#endif
        {
            double value = (double) radianspersecond;
            return new RotationalSpeed(value, RotationalSpeedUnit.RadianPerSecond);
        }

        /// <summary>
        ///     Get RotationalSpeed from RevolutionsPerMinute.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static RotationalSpeed FromRevolutionsPerMinute(double revolutionsperminute)
#else
        public static RotationalSpeed FromRevolutionsPerMinute(QuantityValue revolutionsperminute)
#endif
        {
            double value = (double) revolutionsperminute;
            return new RotationalSpeed(value, RotationalSpeedUnit.RevolutionPerMinute);
        }

        /// <summary>
        ///     Get RotationalSpeed from RevolutionsPerSecond.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static RotationalSpeed FromRevolutionsPerSecond(double revolutionspersecond)
#else
        public static RotationalSpeed FromRevolutionsPerSecond(QuantityValue revolutionspersecond)
#endif
        {
            double value = (double) revolutionspersecond;
            return new RotationalSpeed(value, RotationalSpeedUnit.RevolutionPerSecond);
        }


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="RotationalSpeedUnit" /> to <see cref="RotationalSpeed" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>RotationalSpeed unit value.</returns>
#if WINDOWS_UWP
        // Fix name conflict with parameter "value"
        [return: System.Runtime.InteropServices.WindowsRuntime.ReturnValueName("returnValue")]
        public static RotationalSpeed From(double value, RotationalSpeedUnit fromUnit)
#else
        public static RotationalSpeed From(QuantityValue value, RotationalSpeedUnit fromUnit)
#endif
        {
            return new RotationalSpeed((double)value, fromUnit);
        }

        public IQuantity From(double value, int fromUnit)
        {
            return new RotationalSpeed((double)value, (RotationalSpeedUnit)fromUnit);
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        [UsedImplicitly]
        public static string GetAbbreviation(RotationalSpeedUnit unit)
        {
            return GetAbbreviation(unit, null);
        }

        #endregion

        #region Equality / IComparable

        public int CompareTo(object obj)
        {
            if(obj is null) throw new ArgumentNullException(nameof(obj));
            if(!(obj is RotationalSpeed)) throw new ArgumentException("Expected type RotationalSpeed.", nameof(obj));

            return CompareTo((RotationalSpeed)obj);
        }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
#if WINDOWS_UWP
        internal
#else
        public
#endif
        int CompareTo(RotationalSpeed other)
        {
            return _value.CompareTo(other.AsBaseNumericType(this.Unit));
        }

        [Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals(RotationalSpeed, double, ComparisonType) to provide the max allowed absolute or relative error.")]
        public override bool Equals(object obj)
        {
            if(obj is null || !(obj is RotationalSpeed))
                return false;

            var objQuantity = (RotationalSpeed)obj;
            return _value.Equals(objQuantity.AsBaseNumericType(this.Unit));
        }

        /// <summary>
        ///     <para>
        ///     Compare equality to another RotationalSpeed within the given absolute or relative tolerance.
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
        public bool Equals(RotationalSpeed other, double tolerance, ComparisonType comparisonType)
        {
            if(tolerance < 0)
                throw new ArgumentOutOfRangeException("tolerance", "Tolerance must be greater than or equal to 0.");

            double thisValue = (double)this.Value;
            double otherValueInThisUnits = other.As(this.Unit);

            return UnitsNet.Comparison.Equals(thisValue, otherValueInThisUnits, tolerance, comparisonType);
        }

        /// <summary>
        ///     Compare equality to another RotationalSpeed by specifying a max allowed difference.
        ///     Note that it is advised against specifying zero difference, due to the nature
        ///     of floating point operations and using System.Double internally.
        /// </summary>
        /// <param name="other">Other quantity to compare to.</param>
        /// <param name="maxError">Max error allowed.</param>
        /// <returns>True if the difference between the two values is not greater than the specified max.</returns>
        [Obsolete("Please use the Equals(RotationalSpeed, double, ComparisonType) overload. This method will be removed in a future version.")]
        public bool Equals(RotationalSpeed other, RotationalSpeed maxError)
        {
            return Math.Abs(_value - other.AsBaseNumericType(this.Unit)) <= maxError.AsBaseNumericType(this.Unit);
        }

        /// <summary>
        ///     Returns the hash code for this instance.
        /// </summary>
        /// <returns>A hash code for the current RotationalSpeed.</returns>
        public override int GetHashCode()
        {
            return new { type = typeof(RotationalSpeed), Value, Unit }.GetHashCode();
        }

        #endregion

        #region Conversion

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(RotationalSpeedUnit unit)
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
            var unit = (RotationalSpeedUnit)unitEnumIndex;
            return As(unit);
        }

        /// <summary>
        ///     Converts this RotationalSpeed to another RotationalSpeed with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A RotationalSpeed with the specified unit.</returns>
        public RotationalSpeed ToUnit(RotationalSpeedUnit unit)
        {
            var convertedValue = AsBaseNumericType(unit);
            return new RotationalSpeed(convertedValue, unit);
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
                case RotationalSpeedUnit.CentiradianPerSecond: return (_value) * 1e-2d;
                case RotationalSpeedUnit.DeciradianPerSecond: return (_value) * 1e-1d;
                case RotationalSpeedUnit.DegreePerMinute: return (Math.PI/(180*60))*_value;
                case RotationalSpeedUnit.DegreePerSecond: return (Math.PI/180)*_value;
                case RotationalSpeedUnit.MicrodegreePerSecond: return ((Math.PI/180)*_value) * 1e-6d;
                case RotationalSpeedUnit.MicroradianPerSecond: return (_value) * 1e-6d;
                case RotationalSpeedUnit.MillidegreePerSecond: return ((Math.PI/180)*_value) * 1e-3d;
                case RotationalSpeedUnit.MilliradianPerSecond: return (_value) * 1e-3d;
                case RotationalSpeedUnit.NanodegreePerSecond: return ((Math.PI/180)*_value) * 1e-9d;
                case RotationalSpeedUnit.NanoradianPerSecond: return (_value) * 1e-9d;
                case RotationalSpeedUnit.RadianPerSecond: return _value;
                case RotationalSpeedUnit.RevolutionPerMinute: return (_value*6.2831853072)/60;
                case RotationalSpeedUnit.RevolutionPerSecond: return _value*6.2831853072;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to base units.");
            }
        }

        private double AsBaseNumericType(RotationalSpeedUnit unit)
        {
            if(Unit == unit)
                return _value;

            var baseUnitValue = AsBaseUnit();

            switch(unit)
            {
                case RotationalSpeedUnit.CentiradianPerSecond: return (baseUnitValue) / 1e-2d;
                case RotationalSpeedUnit.DeciradianPerSecond: return (baseUnitValue) / 1e-1d;
                case RotationalSpeedUnit.DegreePerMinute: return (180*60/Math.PI)*baseUnitValue;
                case RotationalSpeedUnit.DegreePerSecond: return (180/Math.PI)*baseUnitValue;
                case RotationalSpeedUnit.MicrodegreePerSecond: return ((180/Math.PI)*baseUnitValue) / 1e-6d;
                case RotationalSpeedUnit.MicroradianPerSecond: return (baseUnitValue) / 1e-6d;
                case RotationalSpeedUnit.MillidegreePerSecond: return ((180/Math.PI)*baseUnitValue) / 1e-3d;
                case RotationalSpeedUnit.MilliradianPerSecond: return (baseUnitValue) / 1e-3d;
                case RotationalSpeedUnit.NanodegreePerSecond: return ((180/Math.PI)*baseUnitValue) / 1e-9d;
                case RotationalSpeedUnit.NanoradianPerSecond: return (baseUnitValue) / 1e-9d;
                case RotationalSpeedUnit.RadianPerSecond: return baseUnitValue;
                case RotationalSpeedUnit.RevolutionPerMinute: return (baseUnitValue/6.2831853072)*60;
                case RotationalSpeedUnit.RevolutionPerSecond: return baseUnitValue/6.2831853072;
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
        public static RotationalSpeed Parse(string str)
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
        public static bool TryParse([CanBeNull] string str, out RotationalSpeed result)
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
        public static RotationalSpeedUnit ParseUnit(string str)
        {
            return ParseUnit(str, (IFormatProvider)null);
        }

        #endregion

        /// <summary>
        ///     Set the default unit used by ToString(). Default is RadianPerSecond
        /// </summary>
        [Obsolete("This is no longer used since we will instead use the quantity's Unit value as default.")]
        public static RotationalSpeedUnit ToStringDefaultUnit { get; set; } = RotationalSpeedUnit.RadianPerSecond;

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
        public string ToString(RotationalSpeedUnit unit)
        {
            return ToString(unit, null, 2);
        }

        /// <summary>
        /// Represents the largest possible value of RotationalSpeed
        /// </summary>
        public static RotationalSpeed MaxValue => new RotationalSpeed(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of RotationalSpeed
        /// </summary>
        public static RotationalSpeed MinValue => new RotationalSpeed(double.MinValue, BaseUnit);

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        public QuantityType Type => RotationalSpeed.QuantityType;

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public BaseDimensions Dimensions => RotationalSpeed.BaseDimensions;
    }
}
