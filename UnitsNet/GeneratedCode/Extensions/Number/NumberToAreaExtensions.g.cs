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
namespace UnitsNet.Extensions.NumberToArea
{
    public static class NumberToAreaExtensions
    {
        #region Acre

        /// <inheritdoc cref="Area.FromAcres(UnitsNet.QuantityValue)" />
        public static Area Acres<T>(this T value) => Area.FromAcres(Convert.ToDouble(value));

        #endregion

        #region Hectare

        /// <inheritdoc cref="Area.FromHectares(UnitsNet.QuantityValue)" />
        public static Area Hectares<T>(this T value) => Area.FromHectares(Convert.ToDouble(value));

        #endregion

        #region SquareCentimeter

        /// <inheritdoc cref="Area.FromSquareCentimeters(UnitsNet.QuantityValue)" />
        public static Area SquareCentimeters<T>(this T value) => Area.FromSquareCentimeters(Convert.ToDouble(value));

        #endregion

        #region SquareDecimeter

        /// <inheritdoc cref="Area.FromSquareDecimeters(UnitsNet.QuantityValue)" />
        public static Area SquareDecimeters<T>(this T value) => Area.FromSquareDecimeters(Convert.ToDouble(value));

        #endregion

        #region SquareFoot

        /// <inheritdoc cref="Area.FromSquareFeet(UnitsNet.QuantityValue)" />
        public static Area SquareFeet<T>(this T value) => Area.FromSquareFeet(Convert.ToDouble(value));

        #endregion

        #region SquareInch

        /// <inheritdoc cref="Area.FromSquareInches(UnitsNet.QuantityValue)" />
        public static Area SquareInches<T>(this T value) => Area.FromSquareInches(Convert.ToDouble(value));

        #endregion

        #region SquareKilometer

        /// <inheritdoc cref="Area.FromSquareKilometers(UnitsNet.QuantityValue)" />
        public static Area SquareKilometers<T>(this T value) => Area.FromSquareKilometers(Convert.ToDouble(value));

        #endregion

        #region SquareMeter

        /// <inheritdoc cref="Area.FromSquareMeters(UnitsNet.QuantityValue)" />
        public static Area SquareMeters<T>(this T value) => Area.FromSquareMeters(Convert.ToDouble(value));

        #endregion

        #region SquareMicrometer

        /// <inheritdoc cref="Area.FromSquareMicrometers(UnitsNet.QuantityValue)" />
        public static Area SquareMicrometers<T>(this T value) => Area.FromSquareMicrometers(Convert.ToDouble(value));

        #endregion

        #region SquareMile

        /// <inheritdoc cref="Area.FromSquareMiles(UnitsNet.QuantityValue)" />
        public static Area SquareMiles<T>(this T value) => Area.FromSquareMiles(Convert.ToDouble(value));

        #endregion

        #region SquareMillimeter

        /// <inheritdoc cref="Area.FromSquareMillimeters(UnitsNet.QuantityValue)" />
        public static Area SquareMillimeters<T>(this T value) => Area.FromSquareMillimeters(Convert.ToDouble(value));

        #endregion

        #region SquareYard

        /// <inheritdoc cref="Area.FromSquareYards(UnitsNet.QuantityValue)" />
        public static Area SquareYards<T>(this T value) => Area.FromSquareYards(Convert.ToDouble(value));

        #endregion

        #region UsSurveySquareFoot

        /// <inheritdoc cref="Area.FromUsSurveySquareFeet(UnitsNet.QuantityValue)" />
        public static Area UsSurveySquareFeet<T>(this T value) => Area.FromUsSurveySquareFeet(Convert.ToDouble(value));

        #endregion

    }
}
#endif
