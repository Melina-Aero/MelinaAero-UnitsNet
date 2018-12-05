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
namespace UnitsNet.Extensions.NumberToDuration
{
    public static class NumberToDurationExtensions
    {
        #region Day

        /// <inheritdoc cref="Duration.FromDays(UnitsNet.QuantityValue)" />
        public static Duration Days<T>(this T value) => Duration.FromDays(Convert.ToDouble(value));

        #endregion

        #region Hour

        /// <inheritdoc cref="Duration.FromHours(UnitsNet.QuantityValue)" />
        public static Duration Hours<T>(this T value) => Duration.FromHours(Convert.ToDouble(value));

        #endregion

        #region Microsecond

        /// <inheritdoc cref="Duration.FromMicroseconds(UnitsNet.QuantityValue)" />
        public static Duration Microseconds<T>(this T value) => Duration.FromMicroseconds(Convert.ToDouble(value));

        #endregion

        #region Millisecond

        /// <inheritdoc cref="Duration.FromMilliseconds(UnitsNet.QuantityValue)" />
        public static Duration Milliseconds<T>(this T value) => Duration.FromMilliseconds(Convert.ToDouble(value));

        #endregion

        #region Minute

        /// <inheritdoc cref="Duration.FromMinutes(UnitsNet.QuantityValue)" />
        public static Duration Minutes<T>(this T value) => Duration.FromMinutes(Convert.ToDouble(value));

        #endregion

        #region Month

        /// <inheritdoc cref="Duration.FromMonths(UnitsNet.QuantityValue)" />
        [System.Obsolete("Use Month30 instead, which makes it clear that this is an approximate unit based on 30 days per month. The duration of a month varies, but the Gregorian solar calendar has 365.2425/12 = 30.44 days on average.")]
        public static Duration Months<T>(this T value) => Duration.FromMonths(Convert.ToDouble(value));

        #endregion

        #region Month30

        /// <inheritdoc cref="Duration.FromMonths30(UnitsNet.QuantityValue)" />
        public static Duration Months30<T>(this T value) => Duration.FromMonths30(Convert.ToDouble(value));

        #endregion

        #region Nanosecond

        /// <inheritdoc cref="Duration.FromNanoseconds(UnitsNet.QuantityValue)" />
        public static Duration Nanoseconds<T>(this T value) => Duration.FromNanoseconds(Convert.ToDouble(value));

        #endregion

        #region Second

        /// <inheritdoc cref="Duration.FromSeconds(UnitsNet.QuantityValue)" />
        public static Duration Seconds<T>(this T value) => Duration.FromSeconds(Convert.ToDouble(value));

        #endregion

        #region Week

        /// <inheritdoc cref="Duration.FromWeeks(UnitsNet.QuantityValue)" />
        public static Duration Weeks<T>(this T value) => Duration.FromWeeks(Convert.ToDouble(value));

        #endregion

        #region Year

        /// <inheritdoc cref="Duration.FromYears(UnitsNet.QuantityValue)" />
        [System.Obsolete("Use Year365 instead, which makes it clear that this is an approximate unit based on 365 days per year. The duration of a year varies due to corrections such as leap years, since a Gregorian solar calendar has 365.2425 days.")]
        public static Duration Years<T>(this T value) => Duration.FromYears(Convert.ToDouble(value));

        #endregion

        #region Year365

        /// <inheritdoc cref="Duration.FromYears365(UnitsNet.QuantityValue)" />
        public static Duration Years365<T>(this T value) => Duration.FromYears365(Convert.ToDouble(value));

        #endregion

    }
}
#endif
