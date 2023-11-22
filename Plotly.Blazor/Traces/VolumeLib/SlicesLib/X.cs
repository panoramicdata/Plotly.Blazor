/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json.Serialization;

namespace Plotly.Blazor.Traces.VolumeLib.SlicesLib
{
    /// <summary>
    ///     The X class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "4.0.1.0")]
    [Serializable]
    public class X : IEquatable<X>
    {
        /// <summary>
        ///     Sets the fill ratio of the <c>slices</c>. The default fill value of the
        ///     <c>slices</c> is 1 meaning that they are entirely shaded. On the other hand
        ///     Applying a <c>fill</c> ratio less than one would allow the creation of openings
        ///     parallel to the edges.
        /// </summary>
        [JsonPropertyName(@"fill")]
        public decimal? Fill { get; set;} 

        /// <summary>
        ///     Specifies the location(s) of slices on the axis. When not specified slices
        ///     would be created for all points of the axis x except start and end.
        /// </summary>
        [JsonPropertyName(@"locations")]
        public IList<object> Locations { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for <c>locations</c>.
        /// </summary>
        [JsonPropertyName(@"locationssrc")]
        public string LocationsSrc { get; set;} 

        /// <summary>
        ///     Determines whether or not slice planes about the x dimension are drawn.
        /// </summary>
        [JsonPropertyName(@"show")]
        public bool? Show { get; set;} 

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (!(obj is X other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        /// <inheritdoc />
        public bool Equals([AllowNull] X other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Fill == other.Fill ||
                    Fill != null &&
                    Fill.Equals(other.Fill)
                ) && 
                (
                    Equals(Locations, other.Locations) ||
                    Locations != null && other.Locations != null &&
                    Locations.SequenceEqual(other.Locations)
                ) &&
                (
                    LocationsSrc == other.LocationsSrc ||
                    LocationsSrc != null &&
                    LocationsSrc.Equals(other.LocationsSrc)
                ) && 
                (
                    Show == other.Show ||
                    Show != null &&
                    Show.Equals(other.Show)
                );
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (Fill != null) hashCode = hashCode * 59 + Fill.GetHashCode();
                if (Locations != null) hashCode = hashCode * 59 + Locations.GetHashCode();
                if (LocationsSrc != null) hashCode = hashCode * 59 + LocationsSrc.GetHashCode();
                if (Show != null) hashCode = hashCode * 59 + Show.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left X and the right X.
        /// </summary>
        /// <param name="left">Left X.</param>
        /// <param name="right">Right X.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (X left, X right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left X and the right X.
        /// </summary>
        /// <param name="left">Left X.</param>
        /// <param name="right">Right X.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (X left, X right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>X</returns>
        public X DeepClone()
        {
            return this.Copy();
        }
    }
}