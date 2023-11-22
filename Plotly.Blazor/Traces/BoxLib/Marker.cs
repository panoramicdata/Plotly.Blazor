/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json.Serialization;

namespace Plotly.Blazor.Traces.BoxLib
{
    /// <summary>
    ///     The Marker class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "4.0.1.0")]
    [Serializable]
    public class Marker : IEquatable<Marker>
    {
        /// <summary>
        ///     Sets the marker angle in respect to <c>angleref</c>.
        /// </summary>
        [JsonPropertyName(@"angle")]
        public decimal? Angle { get; set;} 

        /// <summary>
        ///     Sets the marker color. It accepts either a specific color or an array of
        ///     numbers that are mapped to the colorscale relative to the max and min values
        ///     of the array or relative to <c>marker.cmin</c> and <c>marker.cmax</c> if
        ///     set.
        /// </summary>
        [JsonPropertyName(@"color")]
        public object Color { get; set;} 

        /// <summary>
        ///     Gets or sets the Line.
        /// </summary>
        [JsonPropertyName(@"line")]
        public Plotly.Blazor.Traces.BoxLib.MarkerLib.Line Line { get; set;} 

        /// <summary>
        ///     Sets the marker opacity.
        /// </summary>
        [JsonPropertyName(@"opacity")]
        public decimal? Opacity { get; set;} 

        /// <summary>
        ///     Sets the color of the outlier sample points.
        /// </summary>
        [JsonPropertyName(@"outliercolor")]
        public object OutlierColor { get; set;} 

        /// <summary>
        ///     Sets the marker size (in px).
        /// </summary>
        [JsonPropertyName(@"size")]
        public decimal? Size { get; set;} 

        /// <summary>
        ///     Sets the marker symbol type. Adding 100 is equivalent to appending <c>-open</c>
        ///     to a symbol name. Adding 200 is equivalent to appending <c>-dot</c> to a
        ///     symbol name. Adding 300 is equivalent to appending <c>-open-dot</c> or <c>dot-open</c>
        ///     to a symbol name.
        /// </summary>
        [JsonPropertyName(@"symbol")]
        public Plotly.Blazor.Traces.BoxLib.MarkerLib.SymbolEnum? Symbol { get; set;} 

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (!(obj is Marker other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        /// <inheritdoc />
        public bool Equals([AllowNull] Marker other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Angle == other.Angle ||
                    Angle != null &&
                    Angle.Equals(other.Angle)
                ) && 
                (
                    Color == other.Color ||
                    Color != null &&
                    Color.Equals(other.Color)
                ) && 
                (
                    Line == other.Line ||
                    Line != null &&
                    Line.Equals(other.Line)
                ) && 
                (
                    Opacity == other.Opacity ||
                    Opacity != null &&
                    Opacity.Equals(other.Opacity)
                ) && 
                (
                    OutlierColor == other.OutlierColor ||
                    OutlierColor != null &&
                    OutlierColor.Equals(other.OutlierColor)
                ) && 
                (
                    Size == other.Size ||
                    Size != null &&
                    Size.Equals(other.Size)
                ) && 
                (
                    Symbol == other.Symbol ||
                    Symbol != null &&
                    Symbol.Equals(other.Symbol)
                );
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (Angle != null) hashCode = hashCode * 59 + Angle.GetHashCode();
                if (Color != null) hashCode = hashCode * 59 + Color.GetHashCode();
                if (Line != null) hashCode = hashCode * 59 + Line.GetHashCode();
                if (Opacity != null) hashCode = hashCode * 59 + Opacity.GetHashCode();
                if (OutlierColor != null) hashCode = hashCode * 59 + OutlierColor.GetHashCode();
                if (Size != null) hashCode = hashCode * 59 + Size.GetHashCode();
                if (Symbol != null) hashCode = hashCode * 59 + Symbol.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Marker and the right Marker.
        /// </summary>
        /// <param name="left">Left Marker.</param>
        /// <param name="right">Right Marker.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (Marker left, Marker right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Marker and the right Marker.
        /// </summary>
        /// <param name="left">Left Marker.</param>
        /// <param name="right">Right Marker.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (Marker left, Marker right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Marker</returns>
        public Marker DeepClone()
        {
            return this.Copy();
        }
    }
}