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
namespace UnitsNet.Extensions.NumberToSpecificWeight
{
    public static class NumberToSpecificWeightExtensions
    {
        #region KilogramForcePerCubicCentimeter

        /// <inheritdoc cref="SpecificWeight.FromKilogramsForcePerCubicCentimeter(UnitsNet.QuantityValue)" />
        public static SpecificWeight KilogramsForcePerCubicCentimeter<T>(this T value) => SpecificWeight.FromKilogramsForcePerCubicCentimeter(Convert.ToDouble(value));

        #endregion

        #region KilogramForcePerCubicMeter

        /// <inheritdoc cref="SpecificWeight.FromKilogramsForcePerCubicMeter(UnitsNet.QuantityValue)" />
        public static SpecificWeight KilogramsForcePerCubicMeter<T>(this T value) => SpecificWeight.FromKilogramsForcePerCubicMeter(Convert.ToDouble(value));

        #endregion

        #region KilogramForcePerCubicMillimeter

        /// <inheritdoc cref="SpecificWeight.FromKilogramsForcePerCubicMillimeter(UnitsNet.QuantityValue)" />
        public static SpecificWeight KilogramsForcePerCubicMillimeter<T>(this T value) => SpecificWeight.FromKilogramsForcePerCubicMillimeter(Convert.ToDouble(value));

        #endregion

        #region KilonewtonPerCubicCentimeter

        /// <inheritdoc cref="SpecificWeight.FromKilonewtonsPerCubicCentimeter(UnitsNet.QuantityValue)" />
        public static SpecificWeight KilonewtonsPerCubicCentimeter<T>(this T value) => SpecificWeight.FromKilonewtonsPerCubicCentimeter(Convert.ToDouble(value));

        #endregion

        #region KilonewtonPerCubicMeter

        /// <inheritdoc cref="SpecificWeight.FromKilonewtonsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static SpecificWeight KilonewtonsPerCubicMeter<T>(this T value) => SpecificWeight.FromKilonewtonsPerCubicMeter(Convert.ToDouble(value));

        #endregion

        #region KilonewtonPerCubicMillimeter

        /// <inheritdoc cref="SpecificWeight.FromKilonewtonsPerCubicMillimeter(UnitsNet.QuantityValue)" />
        public static SpecificWeight KilonewtonsPerCubicMillimeter<T>(this T value) => SpecificWeight.FromKilonewtonsPerCubicMillimeter(Convert.ToDouble(value));

        #endregion

        #region KilopoundForcePerCubicFoot

        /// <inheritdoc cref="SpecificWeight.FromKilopoundsForcePerCubicFoot(UnitsNet.QuantityValue)" />
        public static SpecificWeight KilopoundsForcePerCubicFoot<T>(this T value) => SpecificWeight.FromKilopoundsForcePerCubicFoot(Convert.ToDouble(value));

        #endregion

        #region KilopoundForcePerCubicInch

        /// <inheritdoc cref="SpecificWeight.FromKilopoundsForcePerCubicInch(UnitsNet.QuantityValue)" />
        public static SpecificWeight KilopoundsForcePerCubicInch<T>(this T value) => SpecificWeight.FromKilopoundsForcePerCubicInch(Convert.ToDouble(value));

        #endregion

        #region MeganewtonPerCubicMeter

        /// <inheritdoc cref="SpecificWeight.FromMeganewtonsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static SpecificWeight MeganewtonsPerCubicMeter<T>(this T value) => SpecificWeight.FromMeganewtonsPerCubicMeter(Convert.ToDouble(value));

        #endregion

        #region NewtonPerCubicCentimeter

        /// <inheritdoc cref="SpecificWeight.FromNewtonsPerCubicCentimeter(UnitsNet.QuantityValue)" />
        public static SpecificWeight NewtonsPerCubicCentimeter<T>(this T value) => SpecificWeight.FromNewtonsPerCubicCentimeter(Convert.ToDouble(value));

        #endregion

        #region NewtonPerCubicMeter

        /// <inheritdoc cref="SpecificWeight.FromNewtonsPerCubicMeter(UnitsNet.QuantityValue)" />
        public static SpecificWeight NewtonsPerCubicMeter<T>(this T value) => SpecificWeight.FromNewtonsPerCubicMeter(Convert.ToDouble(value));

        #endregion

        #region NewtonPerCubicMillimeter

        /// <inheritdoc cref="SpecificWeight.FromNewtonsPerCubicMillimeter(UnitsNet.QuantityValue)" />
        public static SpecificWeight NewtonsPerCubicMillimeter<T>(this T value) => SpecificWeight.FromNewtonsPerCubicMillimeter(Convert.ToDouble(value));

        #endregion

        #region PoundForcePerCubicFoot

        /// <inheritdoc cref="SpecificWeight.FromPoundsForcePerCubicFoot(UnitsNet.QuantityValue)" />
        public static SpecificWeight PoundsForcePerCubicFoot<T>(this T value) => SpecificWeight.FromPoundsForcePerCubicFoot(Convert.ToDouble(value));

        #endregion

        #region PoundForcePerCubicInch

        /// <inheritdoc cref="SpecificWeight.FromPoundsForcePerCubicInch(UnitsNet.QuantityValue)" />
        public static SpecificWeight PoundsForcePerCubicInch<T>(this T value) => SpecificWeight.FromPoundsForcePerCubicInch(Convert.ToDouble(value));

        #endregion

        #region TonneForcePerCubicCentimeter

        /// <inheritdoc cref="SpecificWeight.FromTonnesForcePerCubicCentimeter(UnitsNet.QuantityValue)" />
        public static SpecificWeight TonnesForcePerCubicCentimeter<T>(this T value) => SpecificWeight.FromTonnesForcePerCubicCentimeter(Convert.ToDouble(value));

        #endregion

        #region TonneForcePerCubicMeter

        /// <inheritdoc cref="SpecificWeight.FromTonnesForcePerCubicMeter(UnitsNet.QuantityValue)" />
        public static SpecificWeight TonnesForcePerCubicMeter<T>(this T value) => SpecificWeight.FromTonnesForcePerCubicMeter(Convert.ToDouble(value));

        #endregion

        #region TonneForcePerCubicMillimeter

        /// <inheritdoc cref="SpecificWeight.FromTonnesForcePerCubicMillimeter(UnitsNet.QuantityValue)" />
        public static SpecificWeight TonnesForcePerCubicMillimeter<T>(this T value) => SpecificWeight.FromTonnesForcePerCubicMillimeter(Convert.ToDouble(value));

        #endregion

    }
}
#endif
