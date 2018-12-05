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
    ///     Mass flow is the ratio of the mass change to the time during which the change occurred (value of mass changes per unit time).
    /// </summary>
    // ReSharper disable once PartialTypeWithSinglePart

    // Windows Runtime Component has constraints on public types: https://msdn.microsoft.com/en-us/library/br230301.aspx#Declaring types in Windows Runtime Components
    // Public structures can't have any members other than public fields, and those fields must be value types or strings.
    // Public classes must be sealed (NotInheritable in Visual Basic). If your programming model requires polymorphism, you can create a public interface and implement that interface on the classes that must be polymorphic.
#if WINDOWS_UWP
    public sealed partial class MassFlow : IQuantity
#else
    public partial class MassFlow : IQuantity, IComparable, IComparable<MassFlow>
#endif
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly MassFlowUnit? _unit;

        /// <summary>
        ///     The unit this quantity was constructed with -or- <see cref="BaseUnit" /> if default ctor was used.
        /// </summary>
        public MassFlowUnit Unit => _unit.GetValueOrDefault(BaseUnit);

        static MassFlow()
        {
            BaseDimensions = new BaseDimensions(0, 1, -1, 0, 0, 0, 0);
        }

        /// <summary>
        ///     Creates the quantity with the given value in the base unit GramPerSecond.
        /// </summary>
        [Obsolete("Use the constructor that takes a unit parameter. This constructor will be removed in a future version.")]
        public MassFlow(double gramspersecond)
        {
            _value = Convert.ToDouble(gramspersecond);
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
        MassFlow(double numericValue, MassFlowUnit unit)
        {
            _value = numericValue;
            _unit = unit;
        }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
        /// <summary>
        ///     Creates the quantity with the given value assuming the base unit GramPerSecond.
        /// </summary>
        /// <param name="gramspersecond">Value assuming base unit GramPerSecond.</param>
#if WINDOWS_UWP
        private
#else
        [Obsolete("Use the constructor that takes a unit parameter. This constructor will be removed in a future version.")]
        public
#endif
        MassFlow(long gramspersecond) : this(Convert.ToDouble(gramspersecond), BaseUnit) { }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
        // Windows Runtime Component does not support decimal type
        /// <summary>
        ///     Creates the quantity with the given value assuming the base unit GramPerSecond.
        /// </summary>
        /// <param name="gramspersecond">Value assuming base unit GramPerSecond.</param>
#if WINDOWS_UWP
        private
#else
        [Obsolete("Use the constructor that takes a unit parameter. This constructor will be removed in a future version.")]
        public
#endif
        MassFlow(decimal gramspersecond) : this(Convert.ToDouble(gramspersecond), BaseUnit) { }

        #region Properties

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        public static QuantityType QuantityType => QuantityType.MassFlow;

        /// <summary>
        ///     The base unit representation of this quantity for the numeric value stored internally. All conversions go via this value.
        /// </summary>
        public static MassFlowUnit BaseUnit => MassFlowUnit.GramPerSecond;

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public static BaseDimensions BaseDimensions
        {
            get;
        }

        /// <summary>
        ///     All units of measurement for the MassFlow quantity.
        /// </summary>
        public static MassFlowUnit[] Units { get; } = Enum.GetValues(typeof(MassFlowUnit)).Cast<MassFlowUnit>().Except(new MassFlowUnit[]{ MassFlowUnit.Undefined }).ToArray();

        /// <summary>
        ///     Get MassFlow in CentigramsPerSecond.
        /// </summary>
        public double CentigramsPerSecond => As(MassFlowUnit.CentigramPerSecond);

        /// <summary>
        ///     Get MassFlow in DecagramsPerSecond.
        /// </summary>
        public double DecagramsPerSecond => As(MassFlowUnit.DecagramPerSecond);

        /// <summary>
        ///     Get MassFlow in DecigramsPerSecond.
        /// </summary>
        public double DecigramsPerSecond => As(MassFlowUnit.DecigramPerSecond);

        /// <summary>
        ///     Get MassFlow in GramsPerSecond.
        /// </summary>
        public double GramsPerSecond => As(MassFlowUnit.GramPerSecond);

        /// <summary>
        ///     Get MassFlow in HectogramsPerSecond.
        /// </summary>
        public double HectogramsPerSecond => As(MassFlowUnit.HectogramPerSecond);

        /// <summary>
        ///     Get MassFlow in KilogramsPerHour.
        /// </summary>
        public double KilogramsPerHour => As(MassFlowUnit.KilogramPerHour);

        /// <summary>
        ///     Get MassFlow in KilogramsPerMinute.
        /// </summary>
        public double KilogramsPerMinute => As(MassFlowUnit.KilogramPerMinute);

        /// <summary>
        ///     Get MassFlow in KilogramsPerSecond.
        /// </summary>
        public double KilogramsPerSecond => As(MassFlowUnit.KilogramPerSecond);

        /// <summary>
        ///     Get MassFlow in MegapoundsPerHour.
        /// </summary>
        public double MegapoundsPerHour => As(MassFlowUnit.MegapoundPerHour);

        /// <summary>
        ///     Get MassFlow in MegapoundsPerMinute.
        /// </summary>
        public double MegapoundsPerMinute => As(MassFlowUnit.MegapoundPerMinute);

        /// <summary>
        ///     Get MassFlow in MicrogramsPerSecond.
        /// </summary>
        public double MicrogramsPerSecond => As(MassFlowUnit.MicrogramPerSecond);

        /// <summary>
        ///     Get MassFlow in MilligramsPerSecond.
        /// </summary>
        public double MilligramsPerSecond => As(MassFlowUnit.MilligramPerSecond);

        /// <summary>
        ///     Get MassFlow in NanogramsPerSecond.
        /// </summary>
        public double NanogramsPerSecond => As(MassFlowUnit.NanogramPerSecond);

        /// <summary>
        ///     Get MassFlow in PoundsPerHour.
        /// </summary>
        public double PoundsPerHour => As(MassFlowUnit.PoundPerHour);

        /// <summary>
        ///     Get MassFlow in PoundsPerMinute.
        /// </summary>
        public double PoundsPerMinute => As(MassFlowUnit.PoundPerMinute);

        /// <summary>
        ///     Get MassFlow in PoundsPerSecond.
        /// </summary>
        public double PoundsPerSecond => As(MassFlowUnit.PoundPerSecond);

        /// <summary>
        ///     Get MassFlow in ShortTonsPerHour.
        /// </summary>
        public double ShortTonsPerHour => As(MassFlowUnit.ShortTonPerHour);

        /// <summary>
        ///     Get MassFlow in TonnesPerDay.
        /// </summary>
        public double TonnesPerDay => As(MassFlowUnit.TonnePerDay);

        /// <summary>
        ///     Get MassFlow in TonnesPerHour.
        /// </summary>
        public double TonnesPerHour => As(MassFlowUnit.TonnePerHour);

        #endregion

        #region Static

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit GramPerSecond.
        /// </summary>
        public static MassFlow Zero => new MassFlow(0, BaseUnit);

        /// <summary>
        ///     Get MassFlow from CentigramsPerSecond.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static MassFlow FromCentigramsPerSecond(double centigramspersecond)
#else
        public static MassFlow FromCentigramsPerSecond(QuantityValue centigramspersecond)
#endif
        {
            double value = (double) centigramspersecond;
            return new MassFlow(value, MassFlowUnit.CentigramPerSecond);
        }

        /// <summary>
        ///     Get MassFlow from DecagramsPerSecond.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static MassFlow FromDecagramsPerSecond(double decagramspersecond)
#else
        public static MassFlow FromDecagramsPerSecond(QuantityValue decagramspersecond)
#endif
        {
            double value = (double) decagramspersecond;
            return new MassFlow(value, MassFlowUnit.DecagramPerSecond);
        }

        /// <summary>
        ///     Get MassFlow from DecigramsPerSecond.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static MassFlow FromDecigramsPerSecond(double decigramspersecond)
#else
        public static MassFlow FromDecigramsPerSecond(QuantityValue decigramspersecond)
#endif
        {
            double value = (double) decigramspersecond;
            return new MassFlow(value, MassFlowUnit.DecigramPerSecond);
        }

        /// <summary>
        ///     Get MassFlow from GramsPerSecond.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static MassFlow FromGramsPerSecond(double gramspersecond)
#else
        public static MassFlow FromGramsPerSecond(QuantityValue gramspersecond)
#endif
        {
            double value = (double) gramspersecond;
            return new MassFlow(value, MassFlowUnit.GramPerSecond);
        }

        /// <summary>
        ///     Get MassFlow from HectogramsPerSecond.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static MassFlow FromHectogramsPerSecond(double hectogramspersecond)
#else
        public static MassFlow FromHectogramsPerSecond(QuantityValue hectogramspersecond)
#endif
        {
            double value = (double) hectogramspersecond;
            return new MassFlow(value, MassFlowUnit.HectogramPerSecond);
        }

        /// <summary>
        ///     Get MassFlow from KilogramsPerHour.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static MassFlow FromKilogramsPerHour(double kilogramsperhour)
#else
        public static MassFlow FromKilogramsPerHour(QuantityValue kilogramsperhour)
#endif
        {
            double value = (double) kilogramsperhour;
            return new MassFlow(value, MassFlowUnit.KilogramPerHour);
        }

        /// <summary>
        ///     Get MassFlow from KilogramsPerMinute.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static MassFlow FromKilogramsPerMinute(double kilogramsperminute)
#else
        public static MassFlow FromKilogramsPerMinute(QuantityValue kilogramsperminute)
#endif
        {
            double value = (double) kilogramsperminute;
            return new MassFlow(value, MassFlowUnit.KilogramPerMinute);
        }

        /// <summary>
        ///     Get MassFlow from KilogramsPerSecond.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static MassFlow FromKilogramsPerSecond(double kilogramspersecond)
#else
        public static MassFlow FromKilogramsPerSecond(QuantityValue kilogramspersecond)
#endif
        {
            double value = (double) kilogramspersecond;
            return new MassFlow(value, MassFlowUnit.KilogramPerSecond);
        }

        /// <summary>
        ///     Get MassFlow from MegapoundsPerHour.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static MassFlow FromMegapoundsPerHour(double megapoundsperhour)
#else
        public static MassFlow FromMegapoundsPerHour(QuantityValue megapoundsperhour)
#endif
        {
            double value = (double) megapoundsperhour;
            return new MassFlow(value, MassFlowUnit.MegapoundPerHour);
        }

        /// <summary>
        ///     Get MassFlow from MegapoundsPerMinute.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static MassFlow FromMegapoundsPerMinute(double megapoundsperminute)
#else
        public static MassFlow FromMegapoundsPerMinute(QuantityValue megapoundsperminute)
#endif
        {
            double value = (double) megapoundsperminute;
            return new MassFlow(value, MassFlowUnit.MegapoundPerMinute);
        }

        /// <summary>
        ///     Get MassFlow from MicrogramsPerSecond.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static MassFlow FromMicrogramsPerSecond(double microgramspersecond)
#else
        public static MassFlow FromMicrogramsPerSecond(QuantityValue microgramspersecond)
#endif
        {
            double value = (double) microgramspersecond;
            return new MassFlow(value, MassFlowUnit.MicrogramPerSecond);
        }

        /// <summary>
        ///     Get MassFlow from MilligramsPerSecond.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static MassFlow FromMilligramsPerSecond(double milligramspersecond)
#else
        public static MassFlow FromMilligramsPerSecond(QuantityValue milligramspersecond)
#endif
        {
            double value = (double) milligramspersecond;
            return new MassFlow(value, MassFlowUnit.MilligramPerSecond);
        }

        /// <summary>
        ///     Get MassFlow from NanogramsPerSecond.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static MassFlow FromNanogramsPerSecond(double nanogramspersecond)
#else
        public static MassFlow FromNanogramsPerSecond(QuantityValue nanogramspersecond)
#endif
        {
            double value = (double) nanogramspersecond;
            return new MassFlow(value, MassFlowUnit.NanogramPerSecond);
        }

        /// <summary>
        ///     Get MassFlow from PoundsPerHour.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static MassFlow FromPoundsPerHour(double poundsperhour)
#else
        public static MassFlow FromPoundsPerHour(QuantityValue poundsperhour)
#endif
        {
            double value = (double) poundsperhour;
            return new MassFlow(value, MassFlowUnit.PoundPerHour);
        }

        /// <summary>
        ///     Get MassFlow from PoundsPerMinute.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static MassFlow FromPoundsPerMinute(double poundsperminute)
#else
        public static MassFlow FromPoundsPerMinute(QuantityValue poundsperminute)
#endif
        {
            double value = (double) poundsperminute;
            return new MassFlow(value, MassFlowUnit.PoundPerMinute);
        }

        /// <summary>
        ///     Get MassFlow from PoundsPerSecond.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static MassFlow FromPoundsPerMinute(double poundsperminute)
#else
        public static MassFlow FromPoundsPerSecond(QuantityValue poundspersecond)
#endif
        {
            double value = (double)poundspersecond;
            return new MassFlow(value, MassFlowUnit.PoundPerSecond);
        }

        /// <summary>
        ///     Get MassFlow from ShortTonsPerHour.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static MassFlow FromShortTonsPerHour(double shorttonsperhour)
#else
        public static MassFlow FromShortTonsPerHour(QuantityValue shorttonsperhour)
#endif
        {
            double value = (double) shorttonsperhour;
            return new MassFlow(value, MassFlowUnit.ShortTonPerHour);
        }

        /// <summary>
        ///     Get MassFlow from TonnesPerDay.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static MassFlow FromTonnesPerDay(double tonnesperday)
#else
        public static MassFlow FromTonnesPerDay(QuantityValue tonnesperday)
#endif
        {
            double value = (double) tonnesperday;
            return new MassFlow(value, MassFlowUnit.TonnePerDay);
        }

        /// <summary>
        ///     Get MassFlow from TonnesPerHour.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static MassFlow FromTonnesPerHour(double tonnesperhour)
#else
        public static MassFlow FromTonnesPerHour(QuantityValue tonnesperhour)
#endif
        {
            double value = (double) tonnesperhour;
            return new MassFlow(value, MassFlowUnit.TonnePerHour);
        }


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="MassFlowUnit" /> to <see cref="MassFlow" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>MassFlow unit value.</returns>
#if WINDOWS_UWP
        // Fix name conflict with parameter "value"
        [return: System.Runtime.InteropServices.WindowsRuntime.ReturnValueName("returnValue")]
        public static MassFlow From(double value, MassFlowUnit fromUnit)
#else
        public static MassFlow From(QuantityValue value, MassFlowUnit fromUnit)
#endif
        {
            return new MassFlow((double)value, fromUnit);
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        [UsedImplicitly]
        public static string GetAbbreviation(MassFlowUnit unit)
        {
            return GetAbbreviation(unit, null);
        }

        #endregion

        #region Equality / IComparable

        public int CompareTo(object obj)
        {
            if(obj is null) throw new ArgumentNullException(nameof(obj));
            if(!(obj is MassFlow)) throw new ArgumentException("Expected type MassFlow.", nameof(obj));

            return CompareTo((MassFlow)obj);
        }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
#if WINDOWS_UWP
        internal
#else
        public
#endif
        int CompareTo(MassFlow other)
        {
            return _value.CompareTo(other.AsBaseNumericType(this.Unit));
        }

        [Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals(MassFlow, double, ComparisonType) to provide the max allowed absolute or relative error.")]
        public override bool Equals(object obj)
        {
            if(obj is null || !(obj is MassFlow))
                return false;

            var objQuantity = (MassFlow)obj;
            return _value.Equals(objQuantity.AsBaseNumericType(this.Unit));
        }

        /// <summary>
        ///     <para>
        ///     Compare equality to another MassFlow within the given absolute or relative tolerance.
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
        public bool Equals(MassFlow other, double tolerance, ComparisonType comparisonType)
        {
            if(tolerance < 0)
                throw new ArgumentOutOfRangeException("tolerance", "Tolerance must be greater than or equal to 0.");

            double thisValue = (double)this.Value;
            double otherValueInThisUnits = other.As(this.Unit);

            return UnitsNet.Comparison.Equals(thisValue, otherValueInThisUnits, tolerance, comparisonType);
        }

        /// <summary>
        ///     Compare equality to another MassFlow by specifying a max allowed difference.
        ///     Note that it is advised against specifying zero difference, due to the nature
        ///     of floating point operations and using System.Double internally.
        /// </summary>
        /// <param name="other">Other quantity to compare to.</param>
        /// <param name="maxError">Max error allowed.</param>
        /// <returns>True if the difference between the two values is not greater than the specified max.</returns>
        [Obsolete("Please use the Equals(MassFlow, double, ComparisonType) overload. This method will be removed in a future version.")]
        public bool Equals(MassFlow other, MassFlow maxError)
        {
            return Math.Abs(_value - other.AsBaseNumericType(this.Unit)) <= maxError.AsBaseNumericType(this.Unit);
        }

        /// <summary>
        ///     Returns the hash code for this instance.
        /// </summary>
        /// <returns>A hash code for the current MassFlow.</returns>
        public override int GetHashCode()
        {
            return new { type = typeof(MassFlow), Value, Unit }.GetHashCode();
        }

        #endregion

        #region Conversion

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(MassFlowUnit unit)
        {
            if(Unit == unit)
                return Convert.ToDouble(Value);

            var converted = AsBaseNumericType(unit);
            return Convert.ToDouble(converted);
        }

        /// <summary>
        ///     Converts this MassFlow to another MassFlow with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A MassFlow with the specified unit.</returns>
        public MassFlow ToUnit(MassFlowUnit unit)
        {
            var convertedValue = AsBaseNumericType(unit);
            return new MassFlow(convertedValue, unit);
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
                case MassFlowUnit.CentigramPerSecond: return (_value) * 1e-2d;
                case MassFlowUnit.DecagramPerSecond: return (_value) * 1e1d;
                case MassFlowUnit.DecigramPerSecond: return (_value) * 1e-1d;
                case MassFlowUnit.GramPerSecond: return _value;
                case MassFlowUnit.HectogramPerSecond: return (_value) * 1e2d;
                case MassFlowUnit.KilogramPerHour: return _value/3.6;
                case MassFlowUnit.KilogramPerMinute: return _value/0.06;
                case MassFlowUnit.KilogramPerSecond: return (_value) * 1e3d;
                case MassFlowUnit.MegapoundPerHour: return (_value/7.93664) * 1e6d;
                case MassFlowUnit.MegapoundPerMinute: return (_value/0.132277) * 1e6d;
                case MassFlowUnit.MicrogramPerSecond: return (_value) * 1e-6d;
                case MassFlowUnit.MilligramPerSecond: return (_value) * 1e-3d;
                case MassFlowUnit.NanogramPerSecond: return (_value) * 1e-9d;
                case MassFlowUnit.PoundPerHour: return _value/7.93664;
                case MassFlowUnit.PoundPerMinute: return _value/0.132277;
                case MassFlowUnit.PoundPerSecond: return _value / 0.002204;
                case MassFlowUnit.ShortTonPerHour: return _value*251.9957611;
                case MassFlowUnit.TonnePerDay: return _value/0.0864000;
                case MassFlowUnit.TonnePerHour: return 1000*_value/3.6;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to base units.");
            }
        }

        private double AsBaseNumericType(MassFlowUnit unit)
        {
            if(Unit == unit)
                return _value;

            var baseUnitValue = AsBaseUnit();

            switch(unit)
            {
                case MassFlowUnit.CentigramPerSecond: return (baseUnitValue) / 1e-2d;
                case MassFlowUnit.DecagramPerSecond: return (baseUnitValue) / 1e1d;
                case MassFlowUnit.DecigramPerSecond: return (baseUnitValue) / 1e-1d;
                case MassFlowUnit.GramPerSecond: return baseUnitValue;
                case MassFlowUnit.HectogramPerSecond: return (baseUnitValue) / 1e2d;
                case MassFlowUnit.KilogramPerHour: return baseUnitValue*3.6;
                case MassFlowUnit.KilogramPerMinute: return baseUnitValue*0.06;
                case MassFlowUnit.KilogramPerSecond: return (baseUnitValue) / 1e3d;
                case MassFlowUnit.MegapoundPerHour: return (baseUnitValue*7.93664) / 1e6d;
                case MassFlowUnit.MegapoundPerMinute: return (baseUnitValue*0.132277) / 1e6d;
                case MassFlowUnit.MicrogramPerSecond: return (baseUnitValue) / 1e-6d;
                case MassFlowUnit.MilligramPerSecond: return (baseUnitValue) / 1e-3d;
                case MassFlowUnit.NanogramPerSecond: return (baseUnitValue) / 1e-9d;
                case MassFlowUnit.PoundPerHour: return baseUnitValue*7.93664;
                case MassFlowUnit.PoundPerMinute: return baseUnitValue*0.132277;
                case MassFlowUnit.PoundPerSecond: return _value*0.002204;
                case MassFlowUnit.ShortTonPerHour: return baseUnitValue/251.9957611;
                case MassFlowUnit.TonnePerDay: return baseUnitValue*0.0864000;
                case MassFlowUnit.TonnePerHour: return baseUnitValue*3.6/1000;
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
        public static MassFlow Parse(string str)
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
        public static bool TryParse([CanBeNull] string str, out MassFlow result)
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
        public static MassFlowUnit ParseUnit(string str)
        {
            return ParseUnit(str, (IFormatProvider)null);
        }

        #endregion

        /// <summary>
        ///     Set the default unit used by ToString(). Default is GramPerSecond
        /// </summary>
        [Obsolete("This is no longer used since we will instead use the quantity's Unit value as default.")]
        public static MassFlowUnit ToStringDefaultUnit { get; set; } = MassFlowUnit.GramPerSecond;

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
        public string ToString(MassFlowUnit unit)
        {
            return ToString(unit, null, 2);
        }

        /// <summary>
        /// Represents the largest possible value of MassFlow
        /// </summary>
        public static MassFlow MaxValue => new MassFlow(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of MassFlow
        /// </summary>
        public static MassFlow MinValue => new MassFlow(double.MinValue, BaseUnit);

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        public QuantityType Type => MassFlow.QuantityType;

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public BaseDimensions Dimensions => MassFlow.BaseDimensions;
    }
}
