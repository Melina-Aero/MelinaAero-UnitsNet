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

// Windows Runtime Component does not support extension methods and method overloads: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
namespace UnitsNet.Extensions.NumberToVolume
{
    public static class NumberToVolumeExtensions
    {

        #region Centiliter

        /// <inheritdoc cref="Volume.FromCentiliters(UnitsNet.QuantityValue)" />
        public static Volume Centiliters<T>(this T value) => Volume.FromCentiliters(Convert.ToDouble(value));

        #endregion

        #region CubicCentimeter

        /// <inheritdoc cref="Volume.FromCubicCentimeters(UnitsNet.QuantityValue)" />
        public static Volume CubicCentimeters<T>(this T value) => Volume.FromCubicCentimeters(Convert.ToDouble(value));

        #endregion

        #region CubicDecimeter

        /// <inheritdoc cref="Volume.FromCubicDecimeters(UnitsNet.QuantityValue)" />
        public static Volume CubicDecimeters<T>(this T value) => Volume.FromCubicDecimeters(Convert.ToDouble(value));

        #endregion

        #region CubicFoot

        /// <inheritdoc cref="Volume.FromCubicFeet(UnitsNet.QuantityValue)" />
        public static Volume CubicFeet<T>(this T value) => Volume.FromCubicFeet(Convert.ToDouble(value));

        #endregion

        #region CubicInch

        /// <inheritdoc cref="Volume.FromCubicInches(UnitsNet.QuantityValue)" />
        public static Volume CubicInches<T>(this T value) => Volume.FromCubicInches(Convert.ToDouble(value));

        #endregion

        #region CubicKilometer

        /// <inheritdoc cref="Volume.FromCubicKilometers(UnitsNet.QuantityValue)" />
        public static Volume CubicKilometers<T>(this T value) => Volume.FromCubicKilometers(Convert.ToDouble(value));

        #endregion

        #region CubicMeter

        /// <inheritdoc cref="Volume.FromCubicMeters(UnitsNet.QuantityValue)" />
        public static Volume CubicMeters<T>(this T value) => Volume.FromCubicMeters(Convert.ToDouble(value));

        #endregion

        #region CubicMicrometer

        /// <inheritdoc cref="Volume.FromCubicMicrometers(UnitsNet.QuantityValue)" />
        public static Volume CubicMicrometers<T>(this T value) => Volume.FromCubicMicrometers(Convert.ToDouble(value));

        #endregion

        #region CubicMile

        /// <inheritdoc cref="Volume.FromCubicMiles(UnitsNet.QuantityValue)" />
        public static Volume CubicMiles<T>(this T value) => Volume.FromCubicMiles(Convert.ToDouble(value));

        #endregion

        #region CubicMillimeter

        /// <inheritdoc cref="Volume.FromCubicMillimeters(UnitsNet.QuantityValue)" />
        public static Volume CubicMillimeters<T>(this T value) => Volume.FromCubicMillimeters(Convert.ToDouble(value));

        #endregion

        #region CubicYard

        /// <inheritdoc cref="Volume.FromCubicYards(UnitsNet.QuantityValue)" />
        public static Volume CubicYards<T>(this T value) => Volume.FromCubicYards(Convert.ToDouble(value));

        #endregion

        #region Deciliter

        /// <inheritdoc cref="Volume.FromDeciliters(UnitsNet.QuantityValue)" />
        public static Volume Deciliters<T>(this T value) => Volume.FromDeciliters(Convert.ToDouble(value));

        #endregion

        #region HectocubicFoot

        /// <inheritdoc cref="Volume.FromHectocubicFeet(UnitsNet.QuantityValue)" />
        public static Volume HectocubicFeet<T>(this T value) => Volume.FromHectocubicFeet(Convert.ToDouble(value));

        #endregion

        #region HectocubicMeter

        /// <inheritdoc cref="Volume.FromHectocubicMeters(UnitsNet.QuantityValue)" />
        public static Volume HectocubicMeters<T>(this T value) => Volume.FromHectocubicMeters(Convert.ToDouble(value));

        #endregion

        #region Hectoliter

        /// <inheritdoc cref="Volume.FromHectoliters(UnitsNet.QuantityValue)" />
        public static Volume Hectoliters<T>(this T value) => Volume.FromHectoliters(Convert.ToDouble(value));

        #endregion

        #region ImperialBeerBarrel

        /// <inheritdoc cref="Volume.FromImperialBeerBarrels(UnitsNet.QuantityValue)" />
        public static Volume ImperialBeerBarrels<T>(this T value) => Volume.FromImperialBeerBarrels(Convert.ToDouble(value));

        #endregion

        #region ImperialGallon

        /// <inheritdoc cref="Volume.FromImperialGallons(UnitsNet.QuantityValue)" />
        public static Volume ImperialGallons<T>(this T value) => Volume.FromImperialGallons(Convert.ToDouble(value));

        #endregion

        #region ImperialOunce

        /// <inheritdoc cref="Volume.FromImperialOunces(UnitsNet.QuantityValue)" />
        public static Volume ImperialOunces<T>(this T value) => Volume.FromImperialOunces(Convert.ToDouble(value));

        #endregion

        #region KilocubicFoot

        /// <inheritdoc cref="Volume.FromKilocubicFeet(UnitsNet.QuantityValue)" />
        public static Volume KilocubicFeet<T>(this T value) => Volume.FromKilocubicFeet(Convert.ToDouble(value));

        #endregion

        #region KilocubicMeter

        /// <inheritdoc cref="Volume.FromKilocubicMeters(UnitsNet.QuantityValue)" />
        public static Volume KilocubicMeters<T>(this T value) => Volume.FromKilocubicMeters(Convert.ToDouble(value));

        #endregion

        #region KiloimperialGallon

        /// <inheritdoc cref="Volume.FromKiloimperialGallons(UnitsNet.QuantityValue)" />
        public static Volume KiloimperialGallons<T>(this T value) => Volume.FromKiloimperialGallons(Convert.ToDouble(value));

        #endregion

        #region Kiloliter

        /// <inheritdoc cref="Volume.FromKiloliters(UnitsNet.QuantityValue)" />
        public static Volume Kiloliters<T>(this T value) => Volume.FromKiloliters(Convert.ToDouble(value));

        #endregion

        #region KilousGallon

        /// <inheritdoc cref="Volume.FromKilousGallons(UnitsNet.QuantityValue)" />
        public static Volume KilousGallons<T>(this T value) => Volume.FromKilousGallons(Convert.ToDouble(value));

        #endregion

        #region Liter

        /// <inheritdoc cref="Volume.FromLiters(UnitsNet.QuantityValue)" />
        public static Volume Liters<T>(this T value) => Volume.FromLiters(Convert.ToDouble(value));

        #endregion

        #region MegacubicFoot

        /// <inheritdoc cref="Volume.FromMegacubicFeet(UnitsNet.QuantityValue)" />
        public static Volume MegacubicFeet<T>(this T value) => Volume.FromMegacubicFeet(Convert.ToDouble(value));

        #endregion

        #region MegaimperialGallon

        /// <inheritdoc cref="Volume.FromMegaimperialGallons(UnitsNet.QuantityValue)" />
        public static Volume MegaimperialGallons<T>(this T value) => Volume.FromMegaimperialGallons(Convert.ToDouble(value));

        #endregion

        #region MegausGallon

        /// <inheritdoc cref="Volume.FromMegausGallons(UnitsNet.QuantityValue)" />
        public static Volume MegausGallons<T>(this T value) => Volume.FromMegausGallons(Convert.ToDouble(value));

        #endregion

        #region Microliter

        /// <inheritdoc cref="Volume.FromMicroliters(UnitsNet.QuantityValue)" />
        public static Volume Microliters<T>(this T value) => Volume.FromMicroliters(Convert.ToDouble(value));

        #endregion

        #region Milliliter

        /// <inheritdoc cref="Volume.FromMilliliters(UnitsNet.QuantityValue)" />
        public static Volume Milliliters<T>(this T value) => Volume.FromMilliliters(Convert.ToDouble(value));

        #endregion

        #region OilBarrel

        /// <inheritdoc cref="Volume.FromOilBarrels(UnitsNet.QuantityValue)" />
        public static Volume OilBarrels<T>(this T value) => Volume.FromOilBarrels(Convert.ToDouble(value));

        #endregion

        #region UsBeerBarrel

        /// <inheritdoc cref="Volume.FromUsBeerBarrels(UnitsNet.QuantityValue)" />
        public static Volume UsBeerBarrels<T>(this T value) => Volume.FromUsBeerBarrels(Convert.ToDouble(value));

        #endregion

        #region UsGallon

        /// <inheritdoc cref="Volume.FromUsGallons(UnitsNet.QuantityValue)" />
        public static Volume UsGallons<T>(this T value) => Volume.FromUsGallons(Convert.ToDouble(value));

        #endregion

        #region UsOunce

        /// <inheritdoc cref="Volume.FromUsOunces(UnitsNet.QuantityValue)" />
        public static Volume UsOunces<T>(this T value) => Volume.FromUsOunces(Convert.ToDouble(value));

        #endregion

        #region UsPint

        /// <inheritdoc cref="Volume.FromUsPints(UnitsNet.QuantityValue)" />
        public static Volume UsPints<T>(this T value) => Volume.FromUsPints(Convert.ToDouble(value));

        #endregion

        #region UsQuart

        /// <inheritdoc cref="Volume.FromUsQuarts(UnitsNet.QuantityValue)" />
        public static Volume UsQuarts<T>(this T value) => Volume.FromUsQuarts(Convert.ToDouble(value));

        #endregion
    }
}
#endif
