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
namespace UnitsNet.Extensions.NumberToTemperatureDelta
{
    public static class NumberToTemperatureDeltaExtensions
    {
        #region DegreeCelsius

        /// <inheritdoc cref="TemperatureDelta.FromDegreesCelsius(UnitsNet.QuantityValue)" />
        public static TemperatureDelta DegreesCelsius<T>(this T value) => TemperatureDelta.FromDegreesCelsius(Convert.ToDouble(value));

        #endregion

        #region DegreeCelsiusDelta

        /// <inheritdoc cref="TemperatureDelta.FromDegreesCelsiusDelta(UnitsNet.QuantityValue)" />
        [System.Obsolete("Deprecated due to github issue #180, please use DegreeCelsius instead")]
        public static TemperatureDelta DegreesCelsiusDelta<T>(this T value) => TemperatureDelta.FromDegreesCelsiusDelta(Convert.ToDouble(value));

        #endregion

        #region DegreeFahrenheit

        /// <inheritdoc cref="TemperatureDelta.FromDegreesFahrenheit(UnitsNet.QuantityValue)" />
        public static TemperatureDelta DegreesFahrenheit<T>(this T value) => TemperatureDelta.FromDegreesFahrenheit(Convert.ToDouble(value));

        #endregion

        #region DegreeFahrenheitDelta

        /// <inheritdoc cref="TemperatureDelta.FromDegreesFahrenheitDelta(UnitsNet.QuantityValue)" />
        [System.Obsolete("Deprecated due to github issue #180, please use DegreeFahrenheit instead")]
        public static TemperatureDelta DegreesFahrenheitDelta<T>(this T value) => TemperatureDelta.FromDegreesFahrenheitDelta(Convert.ToDouble(value));

        #endregion

        #region DegreeNewton

        /// <inheritdoc cref="TemperatureDelta.FromDegreesNewton(UnitsNet.QuantityValue)" />
        public static TemperatureDelta DegreesNewton<T>(this T value) => TemperatureDelta.FromDegreesNewton(Convert.ToDouble(value));

        #endregion

        #region DegreeNewtonDelta

        /// <inheritdoc cref="TemperatureDelta.FromDegreesNewtonDelta(UnitsNet.QuantityValue)" />
        [System.Obsolete("Deprecated due to github issue #180, please use DegreeNewton instead")]
        public static TemperatureDelta DegreesNewtonDelta<T>(this T value) => TemperatureDelta.FromDegreesNewtonDelta(Convert.ToDouble(value));

        #endregion

        #region DegreeRankine

        /// <inheritdoc cref="TemperatureDelta.FromDegreesRankine(UnitsNet.QuantityValue)" />
        public static TemperatureDelta DegreesRankine<T>(this T value) => TemperatureDelta.FromDegreesRankine(Convert.ToDouble(value));

        #endregion

        #region DegreeRankineDelta

        /// <inheritdoc cref="TemperatureDelta.FromDegreesRankineDelta(UnitsNet.QuantityValue)" />
        [System.Obsolete("Deprecated due to github issue #180, please use DegreeRankine instead")]
        public static TemperatureDelta DegreesRankineDelta<T>(this T value) => TemperatureDelta.FromDegreesRankineDelta(Convert.ToDouble(value));

        #endregion

        #region Kelvin

        /// <inheritdoc cref="TemperatureDelta.FromKelvins(UnitsNet.QuantityValue)" />
        public static TemperatureDelta Kelvins<T>(this T value) => TemperatureDelta.FromKelvins(Convert.ToDouble(value));

        #endregion

        #region KelvinDelta

        /// <inheritdoc cref="TemperatureDelta.FromKelvinsDelta(UnitsNet.QuantityValue)" />
        [System.Obsolete("Deprecated due to github issue #180, please use Kelvin instead")]
        public static TemperatureDelta KelvinsDelta<T>(this T value) => TemperatureDelta.FromKelvinsDelta(Convert.ToDouble(value));

        #endregion

    }
}
#endif
