/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json.Serialization;

namespace Plotly.Blazor.Traces.IndicatorLib.GaugeLib
{
    /// <summary>
    ///     The Bar class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [Serializable]
    public class Bar : IEquatable<Bar>
    {
        /// <summary>
        ///     Sets the background color of the arc.
        /// </summary>
        [JsonPropertyName(@"color")]
        public object Color { get; set;} 

        /// <summary>
        ///     Gets or sets the Line.
        /// </summary>
        [JsonPropertyName(@"line")]
        public Plotly.Blazor.Traces.IndicatorLib.GaugeLib.BarLib.Line Line { get; set;} 

        /// <summary>
        ///     Sets the thickness of the bar as a fraction of the total thickness of the
        ///     gauge.
        /// </summary>
        [JsonPropertyName(@"thickness")]
        public decimal? Thickness { get; set;} 

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (!(obj is Bar other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        /// <inheritdoc />
        public bool Equals([AllowNull] Bar other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
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
                    Thickness == other.Thickness ||
                    Thickness != null &&
                    Thickness.Equals(other.Thickness)
                );
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (Color != null) hashCode = hashCode * 59 + Color.GetHashCode();
                if (Line != null) hashCode = hashCode * 59 + Line.GetHashCode();
                if (Thickness != null) hashCode = hashCode * 59 + Thickness.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Bar and the right Bar.
        /// </summary>
        /// <param name="left">Left Bar.</param>
        /// <param name="right">Right Bar.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (Bar left, Bar right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Bar and the right Bar.
        /// </summary>
        /// <param name="left">Left Bar.</param>
        /// <param name="right">Right Bar.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (Bar left, Bar right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Bar</returns>
        public Bar DeepClone()
        {
            return this.Copy();
        }
    }
}