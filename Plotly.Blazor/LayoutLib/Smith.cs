/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json.Serialization;

namespace Plotly.Blazor.LayoutLib
{
    /// <summary>
    ///     The Smith class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "4.0.1.0")]
    [Serializable]
    public class Smith : IEquatable<Smith>
    {
        /// <summary>
        ///     Set the background color of the subplot
        /// </summary>
        [JsonPropertyName(@"bgcolor")]
        public object BgColor { get; set;} 

        /// <summary>
        ///     Gets or sets the Domain.
        /// </summary>
        [JsonPropertyName(@"domain")]
        public Plotly.Blazor.LayoutLib.SmithLib.Domain Domain { get; set;} 

        /// <summary>
        ///     Gets or sets the ImaginaryAxis.
        /// </summary>
        [JsonPropertyName(@"imaginaryaxis")]
        public Plotly.Blazor.LayoutLib.SmithLib.ImaginaryAxis ImaginaryAxis { get; set;} 

        /// <summary>
        ///     Gets or sets the RealAxis.
        /// </summary>
        [JsonPropertyName(@"realaxis")]
        public Plotly.Blazor.LayoutLib.SmithLib.RealAxis RealAxis { get; set;} 

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (!(obj is Smith other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        /// <inheritdoc />
        public bool Equals([AllowNull] Smith other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    BgColor == other.BgColor ||
                    BgColor != null &&
                    BgColor.Equals(other.BgColor)
                ) && 
                (
                    Domain == other.Domain ||
                    Domain != null &&
                    Domain.Equals(other.Domain)
                ) && 
                (
                    ImaginaryAxis == other.ImaginaryAxis ||
                    ImaginaryAxis != null &&
                    ImaginaryAxis.Equals(other.ImaginaryAxis)
                ) && 
                (
                    RealAxis == other.RealAxis ||
                    RealAxis != null &&
                    RealAxis.Equals(other.RealAxis)
                );
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (BgColor != null) hashCode = hashCode * 59 + BgColor.GetHashCode();
                if (Domain != null) hashCode = hashCode * 59 + Domain.GetHashCode();
                if (ImaginaryAxis != null) hashCode = hashCode * 59 + ImaginaryAxis.GetHashCode();
                if (RealAxis != null) hashCode = hashCode * 59 + RealAxis.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Smith and the right Smith.
        /// </summary>
        /// <param name="left">Left Smith.</param>
        /// <param name="right">Right Smith.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (Smith left, Smith right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Smith and the right Smith.
        /// </summary>
        /// <param name="left">Left Smith.</param>
        /// <param name="right">Right Smith.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (Smith left, Smith right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Smith</returns>
        public Smith DeepClone()
        {
            return this.Copy();
        }
    }
}