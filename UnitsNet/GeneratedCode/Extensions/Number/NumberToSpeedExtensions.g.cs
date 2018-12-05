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
namespace UnitsNet.Extensions.NumberToSpeed
{
    public static class NumberToSpeedExtensions
    {
        #region CentimeterPerHour

        /// <inheritdoc cref="Speed.FromCentimetersPerHour(UnitsNet.QuantityValue)" />
        public static Speed CentimetersPerHour<T>(this T value) => Speed.FromCentimetersPerHour(Convert.ToDouble(value));

        #endregion

        #region CentimeterPerMinute

        /// <inheritdoc cref="Speed.FromCentimetersPerMinutes(UnitsNet.QuantityValue)" />
        public static Speed CentimetersPerMinutes<T>(this T value) => Speed.FromCentimetersPerMinutes(Convert.ToDouble(value));

        #endregion

        #region CentimeterPerSecond

        /// <inheritdoc cref="Speed.FromCentimetersPerSecond(UnitsNet.QuantityValue)" />
        public static Speed CentimetersPerSecond<T>(this T value) => Speed.FromCentimetersPerSecond(Convert.ToDouble(value));

        #endregion

        #region DecimeterPerMinute

        /// <inheritdoc cref="Speed.FromDecimetersPerMinutes(UnitsNet.QuantityValue)" />
        public static Speed DecimetersPerMinutes<T>(this T value) => Speed.FromDecimetersPerMinutes(Convert.ToDouble(value));

        #endregion

        #region DecimeterPerSecond

        /// <inheritdoc cref="Speed.FromDecimetersPerSecond(UnitsNet.QuantityValue)" />
        public static Speed DecimetersPerSecond<T>(this T value) => Speed.FromDecimetersPerSecond(Convert.ToDouble(value));

        #endregion

        #region FootPerHour

        /// <inheritdoc cref="Speed.FromFeetPerHour(UnitsNet.QuantityValue)" />
        public static Speed FeetPerHour<T>(this T value) => Speed.FromFeetPerHour(Convert.ToDouble(value));

        #endregion

        #region FootPerMinute

        /// <inheritdoc cref="Speed.FromFeetPerMinute(UnitsNet.QuantityValue)" />
        public static Speed FeetPerMinute<T>(this T value) => Speed.FromFeetPerMinute(Convert.ToDouble(value));

        #endregion

        #region FootPerSecond

        /// <inheritdoc cref="Speed.FromFeetPerSecond(UnitsNet.QuantityValue)" />
        public static Speed FeetPerSecond<T>(this T value) => Speed.FromFeetPerSecond(Convert.ToDouble(value));

        #endregion

        #region InchPerHour

        /// <inheritdoc cref="Speed.FromInchesPerHour(UnitsNet.QuantityValue)" />
        public static Speed InchesPerHour<T>(this T value) => Speed.FromInchesPerHour(Convert.ToDouble(value));

        #endregion

        #region InchPerMinute

        /// <inheritdoc cref="Speed.FromInchesPerMinute(UnitsNet.QuantityValue)" />
        public static Speed InchesPerMinute<T>(this T value) => Speed.FromInchesPerMinute(Convert.ToDouble(value));

        #endregion

        #region InchPerSecond

        /// <inheritdoc cref="Speed.FromInchesPerSecond(UnitsNet.QuantityValue)" />
        public static Speed InchesPerSecond<T>(this T value) => Speed.FromInchesPerSecond(Convert.ToDouble(value));

        #endregion

        #region KilometerPerHour

        /// <inheritdoc cref="Speed.FromKilometersPerHour(UnitsNet.QuantityValue)" />
        public static Speed KilometersPerHour<T>(this T value) => Speed.FromKilometersPerHour(Convert.ToDouble(value));

        #endregion

        #region KilometerPerMinute

        /// <inheritdoc cref="Speed.FromKilometersPerMinutes(UnitsNet.QuantityValue)" />
        public static Speed KilometersPerMinutes<T>(this T value) => Speed.FromKilometersPerMinutes(Convert.ToDouble(value));

        #endregion

        #region KilometerPerSecond

        /// <inheritdoc cref="Speed.FromKilometersPerSecond(UnitsNet.QuantityValue)" />
        public static Speed KilometersPerSecond<T>(this T value) => Speed.FromKilometersPerSecond(Convert.ToDouble(value));

        #endregion

        #region Knot

        /// <inheritdoc cref="Speed.FromKnots(UnitsNet.QuantityValue)" />
        public static Speed Knots<T>(this T value) => Speed.FromKnots(Convert.ToDouble(value));

        #endregion

        #region MeterPerHour

        /// <inheritdoc cref="Speed.FromMetersPerHour(UnitsNet.QuantityValue)" />
        public static Speed MetersPerHour<T>(this T value) => Speed.FromMetersPerHour(Convert.ToDouble(value));

        #endregion

        #region MeterPerMinute

        /// <inheritdoc cref="Speed.FromMetersPerMinutes(UnitsNet.QuantityValue)" />
        public static Speed MetersPerMinutes<T>(this T value) => Speed.FromMetersPerMinutes(Convert.ToDouble(value));

        #endregion

        #region MeterPerSecond

        /// <inheritdoc cref="Speed.FromMetersPerSecond(UnitsNet.QuantityValue)" />
        public static Speed MetersPerSecond<T>(this T value) => Speed.FromMetersPerSecond(Convert.ToDouble(value));

        #endregion

        #region MicrometerPerMinute

        /// <inheritdoc cref="Speed.FromMicrometersPerMinutes(UnitsNet.QuantityValue)" />
        public static Speed MicrometersPerMinutes<T>(this T value) => Speed.FromMicrometersPerMinutes(Convert.ToDouble(value));

        #endregion

        #region MicrometerPerSecond

        /// <inheritdoc cref="Speed.FromMicrometersPerSecond(UnitsNet.QuantityValue)" />
        public static Speed MicrometersPerSecond<T>(this T value) => Speed.FromMicrometersPerSecond(Convert.ToDouble(value));

        #endregion

        #region MilePerHour

        /// <inheritdoc cref="Speed.FromMilesPerHour(UnitsNet.QuantityValue)" />
        public static Speed MilesPerHour<T>(this T value) => Speed.FromMilesPerHour(Convert.ToDouble(value));

        #endregion

        #region MillimeterPerHour

        /// <inheritdoc cref="Speed.FromMillimetersPerHour(UnitsNet.QuantityValue)" />
        public static Speed MillimetersPerHour<T>(this T value) => Speed.FromMillimetersPerHour(Convert.ToDouble(value));

        #endregion

        #region MillimeterPerMinute

        /// <inheritdoc cref="Speed.FromMillimetersPerMinutes(UnitsNet.QuantityValue)" />
        public static Speed MillimetersPerMinutes<T>(this T value) => Speed.FromMillimetersPerMinutes(Convert.ToDouble(value));

        #endregion

        #region MillimeterPerSecond

        /// <inheritdoc cref="Speed.FromMillimetersPerSecond(UnitsNet.QuantityValue)" />
        public static Speed MillimetersPerSecond<T>(this T value) => Speed.FromMillimetersPerSecond(Convert.ToDouble(value));

        #endregion

        #region NanometerPerMinute

        /// <inheritdoc cref="Speed.FromNanometersPerMinutes(UnitsNet.QuantityValue)" />
        public static Speed NanometersPerMinutes<T>(this T value) => Speed.FromNanometersPerMinutes(Convert.ToDouble(value));

        #endregion

        #region NanometerPerSecond

        /// <inheritdoc cref="Speed.FromNanometersPerSecond(UnitsNet.QuantityValue)" />
        public static Speed NanometersPerSecond<T>(this T value) => Speed.FromNanometersPerSecond(Convert.ToDouble(value));

        #endregion

        #region UsSurveyFootPerHour

        /// <inheritdoc cref="Speed.FromUsSurveyFeetPerHour(UnitsNet.QuantityValue)" />
        public static Speed UsSurveyFeetPerHour<T>(this T value) => Speed.FromUsSurveyFeetPerHour(Convert.ToDouble(value));

        #endregion

        #region UsSurveyFootPerMinute

        /// <inheritdoc cref="Speed.FromUsSurveyFeetPerMinute(UnitsNet.QuantityValue)" />
        public static Speed UsSurveyFeetPerMinute<T>(this T value) => Speed.FromUsSurveyFeetPerMinute(Convert.ToDouble(value));

        #endregion

        #region UsSurveyFootPerSecond

        /// <inheritdoc cref="Speed.FromUsSurveyFeetPerSecond(UnitsNet.QuantityValue)" />
        public static Speed UsSurveyFeetPerSecond<T>(this T value) => Speed.FromUsSurveyFeetPerSecond(Convert.ToDouble(value));

        #endregion

        #region YardPerHour

        /// <inheritdoc cref="Speed.FromYardsPerHour(UnitsNet.QuantityValue)" />
        public static Speed YardsPerHour<T>(this T value) => Speed.FromYardsPerHour(Convert.ToDouble(value));

        #endregion

        #region YardPerMinute

        /// <inheritdoc cref="Speed.FromYardsPerMinute(UnitsNet.QuantityValue)" />
        public static Speed YardsPerMinute<T>(this T value) => Speed.FromYardsPerMinute(Convert.ToDouble(value));

        #endregion

        #region YardPerSecond

        /// <inheritdoc cref="Speed.FromYardsPerSecond(UnitsNet.QuantityValue)" />
        public static Speed YardsPerSecond<T>(this T value) => Speed.FromYardsPerSecond(Convert.ToDouble(value));

        #endregion

    }
}
#endif
