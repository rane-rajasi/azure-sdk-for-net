// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary> An object representing the appearance of the text line. </summary>
    internal partial class Appearance
    {
        /// <summary> Initializes a new instance of Appearance. </summary>
        /// <param name="style"> An object representing the style of the text line. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="style"/> is null. </exception>
        internal Appearance(Style style)
        {
            if (style == null)
            {
                throw new ArgumentNullException(nameof(style));
            }

            Style = style;
        }

        /// <summary> An object representing the style of the text line. </summary>
        public Style Style { get; }
    }
}
