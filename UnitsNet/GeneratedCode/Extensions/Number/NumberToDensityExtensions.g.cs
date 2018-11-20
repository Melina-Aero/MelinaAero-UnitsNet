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
namespace UnitsNet.Extensions.NumberToDensity
{
    public static class NumberToDensityExtensions
    {
        #region DecigramPerDeciliter

        /// <inheritdoc cref="Density.FromDecigramsPerDeciLiter(UnitsNet.QuantityValue)" />
        public static Density DecigramsPerDeciLiter<T>(this T value) => Density.FromDecigramsPerDeciLiter(Convert.ToDouble(value));

        /// <inheritdoc cref="Density.FromDecigramsPerDeciLiter(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static Density? DecigramsPerDeciLiter<T>(this T? value) where T : struct => Density.FromDecigramsPerDeciLiter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region DecigramPerLiter

        /// <inheritdoc cref="Density.FromDecigramsPerLiter(UnitsNet.QuantityValue)" />
        public static Density DecigramsPerLiter<T>(this T value) => Density.FromDecigramsPerLiter(Convert.ToDouble(value));

        /// <inheritdoc cref="Density.FromDecigramsPerLiter(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static Density? DecigramsPerLiter<T>(this T? value) where T : struct => Density.FromDecigramsPerLiter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region DecigramPerMilliliter

        /// <inheritdoc cref="Density.FromDecigramsPerMilliliter(UnitsNet.QuantityValue)" />
        public static Density DecigramsPerMilliliter<T>(this T value) => Density.FromDecigramsPerMilliliter(Convert.ToDouble(value));

        /// <inheritdoc cref="Density.FromDecigramsPerMilliliter(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static Density? DecigramsPerMilliliter<T>(this T? value) where T : struct => Density.FromDecigramsPerMilliliter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region GramPerCubicCentimeter

        /// <inheritdoc cref="Density.FromGramsPerCubicCentimeter(UnitsNet.QuantityValue)" />
        public static Density GramsPerCubicCentimeter<T>(this T value) => Density.FromGramsPerCubicCentimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Density.FromGramsPerCubicCentimeter(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static Density? GramsPerCubicCentimeter<T>(this T? value) where T : struct => Density.FromGramsPerCubicCentimeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region GramPerCubicMeter

        /// <inheritdoc cref="Density.FromGramsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static Density GramsPerCubicMeter<T>(this T value) => Density.FromGramsPerCubicMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Density.FromGramsPerCubicMeter(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static Density? GramsPerCubicMeter<T>(this T? value) where T : struct => Density.FromGramsPerCubicMeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region GramPerCubicMillimeter

        /// <inheritdoc cref="Density.FromGramsPerCubicMillimeter(UnitsNet.QuantityValue)" />
        public static Density GramsPerCubicMillimeter<T>(this T value) => Density.FromGramsPerCubicMillimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Density.FromGramsPerCubicMillimeter(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static Density? GramsPerCubicMillimeter<T>(this T? value) where T : struct => Density.FromGramsPerCubicMillimeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region GramPerDeciliter

        /// <inheritdoc cref="Density.FromGramsPerDeciLiter(UnitsNet.QuantityValue)" />
        public static Density GramsPerDeciLiter<T>(this T value) => Density.FromGramsPerDeciLiter(Convert.ToDouble(value));

        /// <inheritdoc cref="Density.FromGramsPerDeciLiter(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static Density? GramsPerDeciLiter<T>(this T? value) where T : struct => Density.FromGramsPerDeciLiter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region GramPerLiter

        /// <inheritdoc cref="Density.FromGramsPerLiter(UnitsNet.QuantityValue)" />
        public static Density GramsPerLiter<T>(this T value) => Density.FromGramsPerLiter(Convert.ToDouble(value));

        /// <inheritdoc cref="Density.FromGramsPerLiter(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static Density? GramsPerLiter<T>(this T? value) where T : struct => Density.FromGramsPerLiter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region GramPerMilliliter

        /// <inheritdoc cref="Density.FromGramsPerMilliliter(UnitsNet.QuantityValue)" />
        public static Density GramsPerMilliliter<T>(this T value) => Density.FromGramsPerMilliliter(Convert.ToDouble(value));

        /// <inheritdoc cref="Density.FromGramsPerMilliliter(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static Density? GramsPerMilliliter<T>(this T? value) where T : struct => Density.FromGramsPerMilliliter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region KilogramPerCubicCentimeter

        /// <inheritdoc cref="Density.FromKilogramsPerCubicCentimeter(UnitsNet.QuantityValue)" />
        public static Density KilogramsPerCubicCentimeter<T>(this T value) => Density.FromKilogramsPerCubicCentimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Density.FromKilogramsPerCubicCentimeter(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static Density? KilogramsPerCubicCentimeter<T>(this T? value) where T : struct => Density.FromKilogramsPerCubicCentimeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region KilogramPerCubicMeter

        /// <inheritdoc cref="Density.FromKilogramsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static Density KilogramsPerCubicMeter<T>(this T value) => Density.FromKilogramsPerCubicMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Density.FromKilogramsPerCubicMeter(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static Density? KilogramsPerCubicMeter<T>(this T? value) where T : struct => Density.FromKilogramsPerCubicMeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region KilogramPerCubicMillimeter

        /// <inheritdoc cref="Density.FromKilogramsPerCubicMillimeter(UnitsNet.QuantityValue)" />
        public static Density KilogramsPerCubicMillimeter<T>(this T value) => Density.FromKilogramsPerCubicMillimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Density.FromKilogramsPerCubicMillimeter(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static Density? KilogramsPerCubicMillimeter<T>(this T? value) where T : struct => Density.FromKilogramsPerCubicMillimeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region KilopoundPerCubicFoot

        /// <inheritdoc cref="Density.FromKilopoundsPerCubicFoot(UnitsNet.QuantityValue)" />
        public static Density KilopoundsPerCubicFoot<T>(this T value) => Density.FromKilopoundsPerCubicFoot(Convert.ToDouble(value));

        /// <inheritdoc cref="Density.FromKilopoundsPerCubicFoot(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static Density? KilopoundsPerCubicFoot<T>(this T? value) where T : struct => Density.FromKilopoundsPerCubicFoot(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region KilopoundPerCubicInch

        /// <inheritdoc cref="Density.FromKilopoundsPerCubicInch(UnitsNet.QuantityValue)" />
        public static Density KilopoundsPerCubicInch<T>(this T value) => Density.FromKilopoundsPerCubicInch(Convert.ToDouble(value));

        /// <inheritdoc cref="Density.FromKilopoundsPerCubicInch(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static Density? KilopoundsPerCubicInch<T>(this T? value) where T : struct => Density.FromKilopoundsPerCubicInch(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MilligramPerCubicMeter

        /// <inheritdoc cref="Density.FromMilligramsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static Density MilligramsPerCubicMeter<T>(this T value) => Density.FromMilligramsPerCubicMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Density.FromMilligramsPerCubicMeter(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static Density? MilligramsPerCubicMeter<T>(this T? value) where T : struct => Density.FromMilligramsPerCubicMeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MilligramPerDeciliter

        /// <inheritdoc cref="Density.FromMilligramsPerDeciLiter(UnitsNet.QuantityValue)" />
        public static Density MilligramsPerDeciLiter<T>(this T value) => Density.FromMilligramsPerDeciLiter(Convert.ToDouble(value));

        /// <inheritdoc cref="Density.FromMilligramsPerDeciLiter(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static Density? MilligramsPerDeciLiter<T>(this T? value) where T : struct => Density.FromMilligramsPerDeciLiter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MilligramPerLiter

        /// <inheritdoc cref="Density.FromMilligramsPerLiter(UnitsNet.QuantityValue)" />
        public static Density MilligramsPerLiter<T>(this T value) => Density.FromMilligramsPerLiter(Convert.ToDouble(value));

        /// <inheritdoc cref="Density.FromMilligramsPerLiter(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static Density? MilligramsPerLiter<T>(this T? value) where T : struct => Density.FromMilligramsPerLiter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MilligramPerMilliliter

        /// <inheritdoc cref="Density.FromMilligramsPerMilliliter(UnitsNet.QuantityValue)" />
        public static Density MilligramsPerMilliliter<T>(this T value) => Density.FromMilligramsPerMilliliter(Convert.ToDouble(value));

        /// <inheritdoc cref="Density.FromMilligramsPerMilliliter(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static Density? MilligramsPerMilliliter<T>(this T? value) where T : struct => Density.FromMilligramsPerMilliliter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region PoundPerCubicFoot

        /// <inheritdoc cref="Density.FromPoundsPerCubicFoot(UnitsNet.QuantityValue)" />
        public static Density PoundsPerCubicFoot<T>(this T value) => Density.FromPoundsPerCubicFoot(Convert.ToDouble(value));

        /// <inheritdoc cref="Density.FromPoundsPerCubicFoot(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static Density? PoundsPerCubicFoot<T>(this T? value) where T : struct => Density.FromPoundsPerCubicFoot(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region PoundPerCubicInch

        /// <inheritdoc cref="Density.FromPoundsPerCubicInch(UnitsNet.QuantityValue)" />
        public static Density PoundsPerCubicInch<T>(this T value) => Density.FromPoundsPerCubicInch(Convert.ToDouble(value));

        /// <inheritdoc cref="Density.FromPoundsPerCubicInch(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static Density? PoundsPerCubicInch<T>(this T? value) where T : struct => Density.FromPoundsPerCubicInch(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region PoundPerImperialGallon

        /// <inheritdoc cref="Density.FromPoundsPerImperialGallon(UnitsNet.QuantityValue)" />
        public static Density PoundsPerImperialGallon<T>(this T value) => Density.FromPoundsPerImperialGallon(Convert.ToDouble(value));

        /// <inheritdoc cref="Density.FromPoundsPerImperialGallon(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static Density? PoundsPerImperialGallon<T>(this T? value) where T : struct => Density.FromPoundsPerImperialGallon(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region PoundPerUSGallon

        /// <inheritdoc cref="Density.FromPoundsPerUSGallon(UnitsNet.QuantityValue)" />
        public static Density PoundsPerUSGallon<T>(this T value) => Density.FromPoundsPerUSGallon(Convert.ToDouble(value));

        /// <inheritdoc cref="Density.FromPoundsPerUSGallon(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static Density? PoundsPerUSGallon<T>(this T? value) where T : struct => Density.FromPoundsPerUSGallon(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region SlugPerCubicFoot

        /// <inheritdoc cref="Density.FromSlugsPerCubicFoot(UnitsNet.QuantityValue)" />
        public static Density SlugsPerCubicFoot<T>(this T value) => Density.FromSlugsPerCubicFoot(Convert.ToDouble(value));

        /// <inheritdoc cref="Density.FromSlugsPerCubicFoot(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static Density? SlugsPerCubicFoot<T>(this T? value) where T : struct => Density.FromSlugsPerCubicFoot(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region TonnePerCubicCentimeter

        /// <inheritdoc cref="Density.FromTonnesPerCubicCentimeter(UnitsNet.QuantityValue)" />
        public static Density TonnesPerCubicCentimeter<T>(this T value) => Density.FromTonnesPerCubicCentimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Density.FromTonnesPerCubicCentimeter(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static Density? TonnesPerCubicCentimeter<T>(this T? value) where T : struct => Density.FromTonnesPerCubicCentimeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region TonnePerCubicMeter

        /// <inheritdoc cref="Density.FromTonnesPerCubicMeter(UnitsNet.QuantityValue)" />
        public static Density TonnesPerCubicMeter<T>(this T value) => Density.FromTonnesPerCubicMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Density.FromTonnesPerCubicMeter(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static Density? TonnesPerCubicMeter<T>(this T? value) where T : struct => Density.FromTonnesPerCubicMeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region TonnePerCubicMillimeter

        /// <inheritdoc cref="Density.FromTonnesPerCubicMillimeter(UnitsNet.QuantityValue)" />
        public static Density TonnesPerCubicMillimeter<T>(this T value) => Density.FromTonnesPerCubicMillimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Density.FromTonnesPerCubicMillimeter(UnitsNet.QuantityValue)" />
        [Obsolete("Nullable type support has been deprecated and will be removed in a future release.")]
        public static Density? TonnesPerCubicMillimeter<T>(this T? value) where T : struct => Density.FromTonnesPerCubicMillimeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

    }
}
#endif
