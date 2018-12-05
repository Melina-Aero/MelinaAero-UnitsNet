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
    ///     The SpecificWeight, or more precisely, the volumetric weight density, of a substance is its weight per unit volume.
    /// </summary>
    // ReSharper disable once PartialTypeWithSinglePart

    // Windows Runtime Component has constraints on public types: https://msdn.microsoft.com/en-us/library/br230301.aspx#Declaring types in Windows Runtime Components
    // Public structures can't have any members other than public fields, and those fields must be value types or strings.
    // Public classes must be sealed (NotInheritable in Visual Basic). If your programming model requires polymorphism, you can create a public interface and implement that interface on the classes that must be polymorphic.
#if WINDOWS_UWP
    public sealed partial class SpecificWeight : IQuantity
#else
    public partial class SpecificWeight : IQuantity, IComparable, IComparable<SpecificWeight>
#endif
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly SpecificWeightUnit? _unit;

        /// <summary>
        ///     The unit this quantity was constructed with -or- <see cref="BaseUnit" /> if default ctor was used.
        /// </summary>
        public SpecificWeightUnit Unit => _unit.GetValueOrDefault(BaseUnit);

        static SpecificWeight()
        {
            BaseDimensions = new BaseDimensions(-2, 1, -2, 0, 0, 0, 0);
        }

        /// <summary>
        ///     Creates the quantity with the given value in the base unit NewtonPerCubicMeter.
        /// </summary>
        [Obsolete("Use the constructor that takes a unit parameter. This constructor will be removed in a future version.")]
        public SpecificWeight(double newtonspercubicmeter)
        {
            _value = Convert.ToDouble(newtonspercubicmeter);
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
        SpecificWeight(double numericValue, SpecificWeightUnit unit)
        {
            _value = numericValue;
            _unit = unit;
        }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
        /// <summary>
        ///     Creates the quantity with the given value assuming the base unit NewtonPerCubicMeter.
        /// </summary>
        /// <param name="newtonspercubicmeter">Value assuming base unit NewtonPerCubicMeter.</param>
#if WINDOWS_UWP
        private
#else
        [Obsolete("Use the constructor that takes a unit parameter. This constructor will be removed in a future version.")]
        public
#endif
        SpecificWeight(long newtonspercubicmeter) : this(Convert.ToDouble(newtonspercubicmeter), BaseUnit) { }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
        // Windows Runtime Component does not support decimal type
        /// <summary>
        ///     Creates the quantity with the given value assuming the base unit NewtonPerCubicMeter.
        /// </summary>
        /// <param name="newtonspercubicmeter">Value assuming base unit NewtonPerCubicMeter.</param>
#if WINDOWS_UWP
        private
#else
        [Obsolete("Use the constructor that takes a unit parameter. This constructor will be removed in a future version.")]
        public
#endif
        SpecificWeight(decimal newtonspercubicmeter) : this(Convert.ToDouble(newtonspercubicmeter), BaseUnit) { }

        #region Properties

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        public static QuantityType QuantityType => QuantityType.SpecificWeight;

        /// <summary>
        ///     The base unit representation of this quantity for the numeric value stored internally. All conversions go via this value.
        /// </summary>
        public static SpecificWeightUnit BaseUnit => SpecificWeightUnit.NewtonPerCubicMeter;

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public static BaseDimensions BaseDimensions
        {
            get;
        }

        /// <summary>
        ///     All units of measurement for the SpecificWeight quantity.
        /// </summary>
        public static SpecificWeightUnit[] Units { get; } = Enum.GetValues(typeof(SpecificWeightUnit)).Cast<SpecificWeightUnit>().Except(new SpecificWeightUnit[]{ SpecificWeightUnit.Undefined }).ToArray();

        /// <summary>
        ///     Get SpecificWeight in KilogramsForcePerCubicCentimeter.
        /// </summary>
        public double KilogramsForcePerCubicCentimeter => As(SpecificWeightUnit.KilogramForcePerCubicCentimeter);

        /// <summary>
        ///     Get SpecificWeight in KilogramsForcePerCubicMeter.
        /// </summary>
        public double KilogramsForcePerCubicMeter => As(SpecificWeightUnit.KilogramForcePerCubicMeter);

        /// <summary>
        ///     Get SpecificWeight in KilogramsForcePerCubicMillimeter.
        /// </summary>
        public double KilogramsForcePerCubicMillimeter => As(SpecificWeightUnit.KilogramForcePerCubicMillimeter);

        /// <summary>
        ///     Get SpecificWeight in KilonewtonsPerCubicCentimeter.
        /// </summary>
        public double KilonewtonsPerCubicCentimeter => As(SpecificWeightUnit.KilonewtonPerCubicCentimeter);

        /// <summary>
        ///     Get SpecificWeight in KilonewtonsPerCubicMeter.
        /// </summary>
        public double KilonewtonsPerCubicMeter => As(SpecificWeightUnit.KilonewtonPerCubicMeter);

        /// <summary>
        ///     Get SpecificWeight in KilonewtonsPerCubicMillimeter.
        /// </summary>
        public double KilonewtonsPerCubicMillimeter => As(SpecificWeightUnit.KilonewtonPerCubicMillimeter);

        /// <summary>
        ///     Get SpecificWeight in KilopoundsForcePerCubicFoot.
        /// </summary>
        public double KilopoundsForcePerCubicFoot => As(SpecificWeightUnit.KilopoundForcePerCubicFoot);

        /// <summary>
        ///     Get SpecificWeight in KilopoundsForcePerCubicInch.
        /// </summary>
        public double KilopoundsForcePerCubicInch => As(SpecificWeightUnit.KilopoundForcePerCubicInch);

        /// <summary>
        ///     Get SpecificWeight in MeganewtonsPerCubicMeter.
        /// </summary>
        public double MeganewtonsPerCubicMeter => As(SpecificWeightUnit.MeganewtonPerCubicMeter);

        /// <summary>
        ///     Get SpecificWeight in NewtonsPerCubicCentimeter.
        /// </summary>
        public double NewtonsPerCubicCentimeter => As(SpecificWeightUnit.NewtonPerCubicCentimeter);

        /// <summary>
        ///     Get SpecificWeight in NewtonsPerCubicMeter.
        /// </summary>
        public double NewtonsPerCubicMeter => As(SpecificWeightUnit.NewtonPerCubicMeter);

        /// <summary>
        ///     Get SpecificWeight in NewtonsPerCubicMillimeter.
        /// </summary>
        public double NewtonsPerCubicMillimeter => As(SpecificWeightUnit.NewtonPerCubicMillimeter);

        /// <summary>
        ///     Get SpecificWeight in PoundsForcePerCubicFoot.
        /// </summary>
        public double PoundsForcePerCubicFoot => As(SpecificWeightUnit.PoundForcePerCubicFoot);

        /// <summary>
        ///     Get SpecificWeight in PoundsForcePerCubicInch.
        /// </summary>
        public double PoundsForcePerCubicInch => As(SpecificWeightUnit.PoundForcePerCubicInch);

        /// <summary>
        ///     Get SpecificWeight in TonnesForcePerCubicCentimeter.
        /// </summary>
        public double TonnesForcePerCubicCentimeter => As(SpecificWeightUnit.TonneForcePerCubicCentimeter);

        /// <summary>
        ///     Get SpecificWeight in TonnesForcePerCubicMeter.
        /// </summary>
        public double TonnesForcePerCubicMeter => As(SpecificWeightUnit.TonneForcePerCubicMeter);

        /// <summary>
        ///     Get SpecificWeight in TonnesForcePerCubicMillimeter.
        /// </summary>
        public double TonnesForcePerCubicMillimeter => As(SpecificWeightUnit.TonneForcePerCubicMillimeter);

        #endregion

        #region Static

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit NewtonPerCubicMeter.
        /// </summary>
        public static SpecificWeight Zero => new SpecificWeight(0, BaseUnit);

        /// <summary>
        ///     Get SpecificWeight from KilogramsForcePerCubicCentimeter.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static SpecificWeight FromKilogramsForcePerCubicCentimeter(double kilogramsforcepercubiccentimeter)
#else
        public static SpecificWeight FromKilogramsForcePerCubicCentimeter(QuantityValue kilogramsforcepercubiccentimeter)
#endif
        {
            double value = (double) kilogramsforcepercubiccentimeter;
            return new SpecificWeight(value, SpecificWeightUnit.KilogramForcePerCubicCentimeter);
        }

        /// <summary>
        ///     Get SpecificWeight from KilogramsForcePerCubicMeter.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static SpecificWeight FromKilogramsForcePerCubicMeter(double kilogramsforcepercubicmeter)
#else
        public static SpecificWeight FromKilogramsForcePerCubicMeter(QuantityValue kilogramsforcepercubicmeter)
#endif
        {
            double value = (double) kilogramsforcepercubicmeter;
            return new SpecificWeight(value, SpecificWeightUnit.KilogramForcePerCubicMeter);
        }

        /// <summary>
        ///     Get SpecificWeight from KilogramsForcePerCubicMillimeter.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static SpecificWeight FromKilogramsForcePerCubicMillimeter(double kilogramsforcepercubicmillimeter)
#else
        public static SpecificWeight FromKilogramsForcePerCubicMillimeter(QuantityValue kilogramsforcepercubicmillimeter)
#endif
        {
            double value = (double) kilogramsforcepercubicmillimeter;
            return new SpecificWeight(value, SpecificWeightUnit.KilogramForcePerCubicMillimeter);
        }

        /// <summary>
        ///     Get SpecificWeight from KilonewtonsPerCubicCentimeter.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static SpecificWeight FromKilonewtonsPerCubicCentimeter(double kilonewtonspercubiccentimeter)
#else
        public static SpecificWeight FromKilonewtonsPerCubicCentimeter(QuantityValue kilonewtonspercubiccentimeter)
#endif
        {
            double value = (double) kilonewtonspercubiccentimeter;
            return new SpecificWeight(value, SpecificWeightUnit.KilonewtonPerCubicCentimeter);
        }

        /// <summary>
        ///     Get SpecificWeight from KilonewtonsPerCubicMeter.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static SpecificWeight FromKilonewtonsPerCubicMeter(double kilonewtonspercubicmeter)
#else
        public static SpecificWeight FromKilonewtonsPerCubicMeter(QuantityValue kilonewtonspercubicmeter)
#endif
        {
            double value = (double) kilonewtonspercubicmeter;
            return new SpecificWeight(value, SpecificWeightUnit.KilonewtonPerCubicMeter);
        }

        /// <summary>
        ///     Get SpecificWeight from KilonewtonsPerCubicMillimeter.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static SpecificWeight FromKilonewtonsPerCubicMillimeter(double kilonewtonspercubicmillimeter)
#else
        public static SpecificWeight FromKilonewtonsPerCubicMillimeter(QuantityValue kilonewtonspercubicmillimeter)
#endif
        {
            double value = (double) kilonewtonspercubicmillimeter;
            return new SpecificWeight(value, SpecificWeightUnit.KilonewtonPerCubicMillimeter);
        }

        /// <summary>
        ///     Get SpecificWeight from KilopoundsForcePerCubicFoot.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static SpecificWeight FromKilopoundsForcePerCubicFoot(double kilopoundsforcepercubicfoot)
#else
        public static SpecificWeight FromKilopoundsForcePerCubicFoot(QuantityValue kilopoundsforcepercubicfoot)
#endif
        {
            double value = (double) kilopoundsforcepercubicfoot;
            return new SpecificWeight(value, SpecificWeightUnit.KilopoundForcePerCubicFoot);
        }

        /// <summary>
        ///     Get SpecificWeight from KilopoundsForcePerCubicInch.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static SpecificWeight FromKilopoundsForcePerCubicInch(double kilopoundsforcepercubicinch)
#else
        public static SpecificWeight FromKilopoundsForcePerCubicInch(QuantityValue kilopoundsforcepercubicinch)
#endif
        {
            double value = (double) kilopoundsforcepercubicinch;
            return new SpecificWeight(value, SpecificWeightUnit.KilopoundForcePerCubicInch);
        }

        /// <summary>
        ///     Get SpecificWeight from MeganewtonsPerCubicMeter.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static SpecificWeight FromMeganewtonsPerCubicMeter(double meganewtonspercubicmeter)
#else
        public static SpecificWeight FromMeganewtonsPerCubicMeter(QuantityValue meganewtonspercubicmeter)
#endif
        {
            double value = (double) meganewtonspercubicmeter;
            return new SpecificWeight(value, SpecificWeightUnit.MeganewtonPerCubicMeter);
        }

        /// <summary>
        ///     Get SpecificWeight from NewtonsPerCubicCentimeter.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static SpecificWeight FromNewtonsPerCubicCentimeter(double newtonspercubiccentimeter)
#else
        public static SpecificWeight FromNewtonsPerCubicCentimeter(QuantityValue newtonspercubiccentimeter)
#endif
        {
            double value = (double) newtonspercubiccentimeter;
            return new SpecificWeight(value, SpecificWeightUnit.NewtonPerCubicCentimeter);
        }

        /// <summary>
        ///     Get SpecificWeight from NewtonsPerCubicMeter.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static SpecificWeight FromNewtonsPerCubicMeter(double newtonspercubicmeter)
#else
        public static SpecificWeight FromNewtonsPerCubicMeter(QuantityValue newtonspercubicmeter)
#endif
        {
            double value = (double) newtonspercubicmeter;
            return new SpecificWeight(value, SpecificWeightUnit.NewtonPerCubicMeter);
        }

        /// <summary>
        ///     Get SpecificWeight from NewtonsPerCubicMillimeter.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static SpecificWeight FromNewtonsPerCubicMillimeter(double newtonspercubicmillimeter)
#else
        public static SpecificWeight FromNewtonsPerCubicMillimeter(QuantityValue newtonspercubicmillimeter)
#endif
        {
            double value = (double) newtonspercubicmillimeter;
            return new SpecificWeight(value, SpecificWeightUnit.NewtonPerCubicMillimeter);
        }

        /// <summary>
        ///     Get SpecificWeight from PoundsForcePerCubicFoot.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static SpecificWeight FromPoundsForcePerCubicFoot(double poundsforcepercubicfoot)
#else
        public static SpecificWeight FromPoundsForcePerCubicFoot(QuantityValue poundsforcepercubicfoot)
#endif
        {
            double value = (double) poundsforcepercubicfoot;
            return new SpecificWeight(value, SpecificWeightUnit.PoundForcePerCubicFoot);
        }

        /// <summary>
        ///     Get SpecificWeight from PoundsForcePerCubicInch.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static SpecificWeight FromPoundsForcePerCubicInch(double poundsforcepercubicinch)
#else
        public static SpecificWeight FromPoundsForcePerCubicInch(QuantityValue poundsforcepercubicinch)
#endif
        {
            double value = (double) poundsforcepercubicinch;
            return new SpecificWeight(value, SpecificWeightUnit.PoundForcePerCubicInch);
        }

        /// <summary>
        ///     Get SpecificWeight from TonnesForcePerCubicCentimeter.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static SpecificWeight FromTonnesForcePerCubicCentimeter(double tonnesforcepercubiccentimeter)
#else
        public static SpecificWeight FromTonnesForcePerCubicCentimeter(QuantityValue tonnesforcepercubiccentimeter)
#endif
        {
            double value = (double) tonnesforcepercubiccentimeter;
            return new SpecificWeight(value, SpecificWeightUnit.TonneForcePerCubicCentimeter);
        }

        /// <summary>
        ///     Get SpecificWeight from TonnesForcePerCubicMeter.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static SpecificWeight FromTonnesForcePerCubicMeter(double tonnesforcepercubicmeter)
#else
        public static SpecificWeight FromTonnesForcePerCubicMeter(QuantityValue tonnesforcepercubicmeter)
#endif
        {
            double value = (double) tonnesforcepercubicmeter;
            return new SpecificWeight(value, SpecificWeightUnit.TonneForcePerCubicMeter);
        }

        /// <summary>
        ///     Get SpecificWeight from TonnesForcePerCubicMillimeter.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static SpecificWeight FromTonnesForcePerCubicMillimeter(double tonnesforcepercubicmillimeter)
#else
        public static SpecificWeight FromTonnesForcePerCubicMillimeter(QuantityValue tonnesforcepercubicmillimeter)
#endif
        {
            double value = (double) tonnesforcepercubicmillimeter;
            return new SpecificWeight(value, SpecificWeightUnit.TonneForcePerCubicMillimeter);
        }


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="SpecificWeightUnit" /> to <see cref="SpecificWeight" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>SpecificWeight unit value.</returns>
#if WINDOWS_UWP
        // Fix name conflict with parameter "value"
        [return: System.Runtime.InteropServices.WindowsRuntime.ReturnValueName("returnValue")]
        public static SpecificWeight From(double value, SpecificWeightUnit fromUnit)
#else
        public static SpecificWeight From(QuantityValue value, SpecificWeightUnit fromUnit)
#endif
        {
            return new SpecificWeight((double)value, fromUnit);
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        [UsedImplicitly]
        public static string GetAbbreviation(SpecificWeightUnit unit)
        {
            return GetAbbreviation(unit, null);
        }

        #endregion

        #region Equality / IComparable

        public int CompareTo(object obj)
        {
            if(obj is null) throw new ArgumentNullException(nameof(obj));
            if(!(obj is SpecificWeight)) throw new ArgumentException("Expected type SpecificWeight.", nameof(obj));

            return CompareTo((SpecificWeight)obj);
        }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
#if WINDOWS_UWP
        internal
#else
        public
#endif
        int CompareTo(SpecificWeight other)
        {
            return _value.CompareTo(other.AsBaseNumericType(this.Unit));
        }

        [Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals(SpecificWeight, double, ComparisonType) to provide the max allowed absolute or relative error.")]
        public override bool Equals(object obj)
        {
            if(obj is null || !(obj is SpecificWeight))
                return false;

            var objQuantity = (SpecificWeight)obj;
            return _value.Equals(objQuantity.AsBaseNumericType(this.Unit));
        }

        /// <summary>
        ///     <para>
        ///     Compare equality to another SpecificWeight within the given absolute or relative tolerance.
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
        public bool Equals(SpecificWeight other, double tolerance, ComparisonType comparisonType)
        {
            if(tolerance < 0)
                throw new ArgumentOutOfRangeException("tolerance", "Tolerance must be greater than or equal to 0.");

            double thisValue = (double)this.Value;
            double otherValueInThisUnits = other.As(this.Unit);

            return UnitsNet.Comparison.Equals(thisValue, otherValueInThisUnits, tolerance, comparisonType);
        }

        /// <summary>
        ///     Compare equality to another SpecificWeight by specifying a max allowed difference.
        ///     Note that it is advised against specifying zero difference, due to the nature
        ///     of floating point operations and using System.Double internally.
        /// </summary>
        /// <param name="other">Other quantity to compare to.</param>
        /// <param name="maxError">Max error allowed.</param>
        /// <returns>True if the difference between the two values is not greater than the specified max.</returns>
        [Obsolete("Please use the Equals(SpecificWeight, double, ComparisonType) overload. This method will be removed in a future version.")]
        public bool Equals(SpecificWeight other, SpecificWeight maxError)
        {
            return Math.Abs(_value - other.AsBaseNumericType(this.Unit)) <= maxError.AsBaseNumericType(this.Unit);
        }

        /// <summary>
        ///     Returns the hash code for this instance.
        /// </summary>
        /// <returns>A hash code for the current SpecificWeight.</returns>
        public override int GetHashCode()
        {
            return new { type = typeof(SpecificWeight), Value, Unit }.GetHashCode();
        }

        #endregion

        #region Conversion

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(SpecificWeightUnit unit)
        {
            if(Unit == unit)
                return Convert.ToDouble(Value);

            var converted = AsBaseNumericType(unit);
            return Convert.ToDouble(converted);
        }

        /// <summary>
        ///     Converts this SpecificWeight to another SpecificWeight with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A SpecificWeight with the specified unit.</returns>
        public SpecificWeight ToUnit(SpecificWeightUnit unit)
        {
            var convertedValue = AsBaseNumericType(unit);
            return new SpecificWeight(convertedValue, unit);
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
                case SpecificWeightUnit.KilogramForcePerCubicCentimeter: return _value*9.80665e6;
                case SpecificWeightUnit.KilogramForcePerCubicMeter: return _value*9.80665;
                case SpecificWeightUnit.KilogramForcePerCubicMillimeter: return _value*9.80665e9;
                case SpecificWeightUnit.KilonewtonPerCubicCentimeter: return (_value*1000000) * 1e3d;
                case SpecificWeightUnit.KilonewtonPerCubicMeter: return (_value) * 1e3d;
                case SpecificWeightUnit.KilonewtonPerCubicMillimeter: return (_value*1000000000) * 1e3d;
                case SpecificWeightUnit.KilopoundForcePerCubicFoot: return (_value*1.570874638462462e2) * 1e3d;
                case SpecificWeightUnit.KilopoundForcePerCubicInch: return (_value*2.714471375263134e5) * 1e3d;
                case SpecificWeightUnit.MeganewtonPerCubicMeter: return (_value) * 1e6d;
                case SpecificWeightUnit.NewtonPerCubicCentimeter: return _value*1000000;
                case SpecificWeightUnit.NewtonPerCubicMeter: return _value;
                case SpecificWeightUnit.NewtonPerCubicMillimeter: return _value*1000000000;
                case SpecificWeightUnit.PoundForcePerCubicFoot: return _value*1.570874638462462e2;
                case SpecificWeightUnit.PoundForcePerCubicInch: return _value*2.714471375263134e5;
                case SpecificWeightUnit.TonneForcePerCubicCentimeter: return _value*9.80665e9;
                case SpecificWeightUnit.TonneForcePerCubicMeter: return _value*9.80665e3;
                case SpecificWeightUnit.TonneForcePerCubicMillimeter: return _value*9.80665e12;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to base units.");
            }
        }

        private double AsBaseNumericType(SpecificWeightUnit unit)
        {
            if(Unit == unit)
                return _value;

            var baseUnitValue = AsBaseUnit();

            switch(unit)
            {
                case SpecificWeightUnit.KilogramForcePerCubicCentimeter: return baseUnitValue/9.80665e6;
                case SpecificWeightUnit.KilogramForcePerCubicMeter: return baseUnitValue/9.80665;
                case SpecificWeightUnit.KilogramForcePerCubicMillimeter: return baseUnitValue/9.80665e9;
                case SpecificWeightUnit.KilonewtonPerCubicCentimeter: return (baseUnitValue*0.000001) / 1e3d;
                case SpecificWeightUnit.KilonewtonPerCubicMeter: return (baseUnitValue) / 1e3d;
                case SpecificWeightUnit.KilonewtonPerCubicMillimeter: return (baseUnitValue*0.000000001) / 1e3d;
                case SpecificWeightUnit.KilopoundForcePerCubicFoot: return (baseUnitValue/1.570874638462462e2) / 1e3d;
                case SpecificWeightUnit.KilopoundForcePerCubicInch: return (baseUnitValue/2.714471375263134e5) / 1e3d;
                case SpecificWeightUnit.MeganewtonPerCubicMeter: return (baseUnitValue) / 1e6d;
                case SpecificWeightUnit.NewtonPerCubicCentimeter: return baseUnitValue*0.000001;
                case SpecificWeightUnit.NewtonPerCubicMeter: return baseUnitValue;
                case SpecificWeightUnit.NewtonPerCubicMillimeter: return baseUnitValue*0.000000001;
                case SpecificWeightUnit.PoundForcePerCubicFoot: return baseUnitValue/1.570874638462462e2;
                case SpecificWeightUnit.PoundForcePerCubicInch: return baseUnitValue/2.714471375263134e5;
                case SpecificWeightUnit.TonneForcePerCubicCentimeter: return baseUnitValue/9.80665e9;
                case SpecificWeightUnit.TonneForcePerCubicMeter: return baseUnitValue/9.80665e3;
                case SpecificWeightUnit.TonneForcePerCubicMillimeter: return baseUnitValue/9.80665e12;
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
        public static SpecificWeight Parse(string str)
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
        public static bool TryParse([CanBeNull] string str, out SpecificWeight result)
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
        public static SpecificWeightUnit ParseUnit(string str)
        {
            return ParseUnit(str, (IFormatProvider)null);
        }

        #endregion

        /// <summary>
        ///     Set the default unit used by ToString(). Default is NewtonPerCubicMeter
        /// </summary>
        [Obsolete("This is no longer used since we will instead use the quantity's Unit value as default.")]
        public static SpecificWeightUnit ToStringDefaultUnit { get; set; } = SpecificWeightUnit.NewtonPerCubicMeter;

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
        public string ToString(SpecificWeightUnit unit)
        {
            return ToString(unit, null, 2);
        }

        /// <summary>
        /// Represents the largest possible value of SpecificWeight
        /// </summary>
        public static SpecificWeight MaxValue => new SpecificWeight(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of SpecificWeight
        /// </summary>
        public static SpecificWeight MinValue => new SpecificWeight(double.MinValue, BaseUnit);

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        public QuantityType Type => SpecificWeight.QuantityType;

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public BaseDimensions Dimensions => SpecificWeight.BaseDimensions;
    }
}
