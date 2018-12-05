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
namespace UnitsNet.Extensions.NumberToMass
{
    public static class NumberToMassExtensions
    {
        #region Centigram

        /// <inheritdoc cref="Mass.FromCentigrams(UnitsNet.QuantityValue)" />
        public static Mass Centigrams<T>(this T value) => Mass.FromCentigrams(Convert.ToDouble(value));


        #endregion

        #region Decagram

        /// <inheritdoc cref="Mass.FromDecagrams(UnitsNet.QuantityValue)" />
        public static Mass Decagrams<T>(this T value) => Mass.FromDecagrams(Convert.ToDouble(value));

        #endregion

        #region Decigram

        /// <inheritdoc cref="Mass.FromDecigrams(UnitsNet.QuantityValue)" />
        public static Mass Decigrams<T>(this T value) => Mass.FromDecigrams(Convert.ToDouble(value));

        #endregion

        #region Gram

        /// <inheritdoc cref="Mass.FromGrams(UnitsNet.QuantityValue)" />
        public static Mass Grams<T>(this T value) => Mass.FromGrams(Convert.ToDouble(value));


        #endregion

        #region Hectogram

        /// <inheritdoc cref="Mass.FromHectograms(UnitsNet.QuantityValue)" />
        public static Mass Hectograms<T>(this T value) => Mass.FromHectograms(Convert.ToDouble(value));
        

        #endregion

        #region Kilogram

        /// <inheritdoc cref="Mass.FromKilograms(UnitsNet.QuantityValue)" />
        public static Mass Kilograms<T>(this T value) => Mass.FromKilograms(Convert.ToDouble(value));

        #endregion

        #region Kilopound

        /// <inheritdoc cref="Mass.FromKilopounds(UnitsNet.QuantityValue)" />
        public static Mass Kilopounds<T>(this T value) => Mass.FromKilopounds(Convert.ToDouble(value));

        #endregion

        #region Kilotonne

        /// <inheritdoc cref="Mass.FromKilotonnes(UnitsNet.QuantityValue)" />
        public static Mass Kilotonnes<T>(this T value) => Mass.FromKilotonnes(Convert.ToDouble(value));

        #endregion

        #region LongHundredweight

        /// <inheritdoc cref="Mass.FromLongHundredweight(UnitsNet.QuantityValue)" />
        public static Mass LongHundredweight<T>(this T value) => Mass.FromLongHundredweight(Convert.ToDouble(value));

        #endregion

        #region LongTon

        /// <inheritdoc cref="Mass.FromLongTons(UnitsNet.QuantityValue)" />
        public static Mass LongTons<T>(this T value) => Mass.FromLongTons(Convert.ToDouble(value));

        #endregion

        #region Megapound

        /// <inheritdoc cref="Mass.FromMegapounds(UnitsNet.QuantityValue)" />
        public static Mass Megapounds<T>(this T value) => Mass.FromMegapounds(Convert.ToDouble(value));
        #endregion

        #region Megatonne

        /// <inheritdoc cref="Mass.FromMegatonnes(UnitsNet.QuantityValue)" />
        public static Mass Megatonnes<T>(this T value) => Mass.FromMegatonnes(Convert.ToDouble(value));

        #endregion

        #region Microgram

        /// <inheritdoc cref="Mass.FromMicrograms(UnitsNet.QuantityValue)" />
        public static Mass Micrograms<T>(this T value) => Mass.FromMicrograms(Convert.ToDouble(value));

        #endregion

        #region Milligram

        /// <inheritdoc cref="Mass.FromMilligrams(UnitsNet.QuantityValue)" />
        public static Mass Milligrams<T>(this T value) => Mass.FromMilligrams(Convert.ToDouble(value));

        #endregion

        #region Nanogram

        /// <inheritdoc cref="Mass.FromNanograms(UnitsNet.QuantityValue)" />
        public static Mass Nanograms<T>(this T value) => Mass.FromNanograms(Convert.ToDouble(value));

        #endregion

        #region Ounce

        /// <inheritdoc cref="Mass.FromOunces(UnitsNet.QuantityValue)" />
        public static Mass Ounces<T>(this T value) => Mass.FromOunces(Convert.ToDouble(value));

        #endregion

        #region Pound

        /// <inheritdoc cref="Mass.FromPounds(UnitsNet.QuantityValue)" />
        public static Mass Pounds<T>(this T value) => Mass.FromPounds(Convert.ToDouble(value));

        #endregion

        #region ShortHundredweight

        /// <inheritdoc cref="Mass.FromShortHundredweight(UnitsNet.QuantityValue)" />
        public static Mass ShortHundredweight<T>(this T value) => Mass.FromShortHundredweight(Convert.ToDouble(value));

        #endregion

        #region ShortTon

        /// <inheritdoc cref="Mass.FromShortTons(UnitsNet.QuantityValue)" />
        public static Mass ShortTons<T>(this T value) => Mass.FromShortTons(Convert.ToDouble(value));

        #endregion

        #region Slug

        /// <inheritdoc cref="Mass.FromSlugs(UnitsNet.QuantityValue)" />
        public static Mass Slugs<T>(this T value) => Mass.FromSlugs(Convert.ToDouble(value));

        #endregion

        #region Stone

        /// <inheritdoc cref="Mass.FromStone(UnitsNet.QuantityValue)" />
        public static Mass Stone<T>(this T value) => Mass.FromStone(Convert.ToDouble(value));

        #endregion

        #region Tonne

        /// <inheritdoc cref="Mass.FromTonnes(UnitsNet.QuantityValue)" />
        public static Mass Tonnes<T>(this T value) => Mass.FromTonnes(Convert.ToDouble(value));

        #endregion

    }
}
#endif
