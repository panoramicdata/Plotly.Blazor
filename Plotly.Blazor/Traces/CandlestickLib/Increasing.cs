/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json.Serialization;

namespace Plotly.Blazor.Traces.CandlestickLib
{
    /// <summary>
    ///     The Increasing class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", null)]
    [Serializable]
    public class Increasing : IEquatable<Increasing>
    {
        /// <summary>
        ///     Sets the fill color. Defaults to a half-transparent variant of the line
        ///     color, marker color, or marker line color, whichever is available.
        /// </summary>
        [JsonPropertyName(@"fillcolor")]
        public object FillColor { get; set;} 

        /// <summary>
        ///     Gets or sets the Line.
        /// </summary>
        [JsonPropertyName(@"line")]
        public Plotly.Blazor.Traces.CandlestickLib.IncreasingLib.Line Line { get; set;} 

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (!(obj is Increasing other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        /// <inheritdoc />
        public bool Equals([AllowNull] Increasing other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    FillColor == other.FillColor ||
                    FillColor != null &&
                    FillColor.Equals(other.FillColor)
                ) && 
                (
                    Line == other.Line ||
                    Line != null &&
                    Line.Equals(other.Line)
                );
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (FillColor != null) hashCode = hashCode * 59 + FillColor.GetHashCode();
                if (Line != null) hashCode = hashCode * 59 + Line.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Increasing and the right Increasing.
        /// </summary>
        /// <param name="left">Left Increasing.</param>
        /// <param name="right">Right Increasing.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (Increasing left, Increasing right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Increasing and the right Increasing.
        /// </summary>
        /// <param name="left">Left Increasing.</param>
        /// <param name="right">Right Increasing.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (Increasing left, Increasing right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Increasing</returns>
        public Increasing DeepClone()
        {
            return this.Copy();
        }
    }
}