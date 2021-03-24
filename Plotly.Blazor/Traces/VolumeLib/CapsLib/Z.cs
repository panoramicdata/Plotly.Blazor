/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json.Serialization;

namespace Plotly.Blazor.Traces.VolumeLib.CapsLib
{
    /// <summary>
    ///     The Z class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [Serializable]
    public class Z : IEquatable<Z>
    {
        /// <summary>
        ///     Sets the fill ratio of the <c>slices</c>. The default fill value of the
        ///     z <c>slices</c> is 1 meaning that they are entirely shaded. On the other
        ///     hand Applying a <c>fill</c> ratio less than one would allow the creation
        ///     of openings parallel to the edges.
        /// </summary>
        [JsonPropertyName(@"show")]
        public bool? Show { get; set;} 

        /// <summary>
        ///     Sets the fill ratio of the <c>caps</c>. The default fill value of the <c>caps</c>
        ///     is 1 meaning that they are entirely shaded. On the other hand Applying a
        ///     <c>fill</c> ratio less than one would allow the creation of openings parallel
        ///     to the edges.
        /// </summary>
        [JsonPropertyName(@"fill")]
        public decimal? Fill { get; set;} 

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (!(obj is Z other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        /// <inheritdoc />
        public bool Equals([AllowNull] Z other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Show == other.Show ||
                    Show != null &&
                    Show.Equals(other.Show)
                ) && 
                (
                    Fill == other.Fill ||
                    Fill != null &&
                    Fill.Equals(other.Fill)
                );
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (Show != null) hashCode = hashCode * 59 + Show.GetHashCode();
                if (Fill != null) hashCode = hashCode * 59 + Fill.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Z and the right Z.
        /// </summary>
        /// <param name="left">Left Z.</param>
        /// <param name="right">Right Z.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (Z left, Z right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Z and the right Z.
        /// </summary>
        /// <param name="left">Left Z.</param>
        /// <param name="right">Right Z.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (Z left, Z right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Z</returns>
        public Z DeepClone()
        {
            return this.Copy();
        }
    }
}