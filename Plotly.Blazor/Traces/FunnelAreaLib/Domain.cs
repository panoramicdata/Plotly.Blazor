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

namespace Plotly.Blazor.Traces.FunnelAreaLib
{
    /// <summary>
    ///     The Domain class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [Serializable]
    public class Domain : IEquatable<Domain>
    {
        /// <summary>
        ///     Sets the horizontal domain of this funnelarea trace (in plot fraction).
        /// </summary>
        [JsonPropertyName(@"x")]
        public IList<object> X { get; set;} 

        /// <summary>
        ///     Sets the vertical domain of this funnelarea trace (in plot fraction).
        /// </summary>
        [JsonPropertyName(@"y")]
        public IList<object> Y { get; set;} 

        /// <summary>
        ///     If there is a layout grid, use the domain for this row in the grid for this
        ///     funnelarea trace .
        /// </summary>
        [JsonPropertyName(@"row")]
        public int? Row { get; set;} 

        /// <summary>
        ///     If there is a layout grid, use the domain for this column in the grid for
        ///     this funnelarea trace .
        /// </summary>
        [JsonPropertyName(@"column")]
        public int? Column { get; set;} 

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (!(obj is Domain other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        /// <inheritdoc />
        public bool Equals([AllowNull] Domain other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Equals(X, other.X) ||
                    X != null && other.X != null &&
                    X.SequenceEqual(other.X)
                ) &&
                (
                    Equals(Y, other.Y) ||
                    Y != null && other.Y != null &&
                    Y.SequenceEqual(other.Y)
                ) &&
                (
                    Row == other.Row ||
                    Row != null &&
                    Row.Equals(other.Row)
                ) && 
                (
                    Column == other.Column ||
                    Column != null &&
                    Column.Equals(other.Column)
                );
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (X != null) hashCode = hashCode * 59 + X.GetHashCode();
                if (Y != null) hashCode = hashCode * 59 + Y.GetHashCode();
                if (Row != null) hashCode = hashCode * 59 + Row.GetHashCode();
                if (Column != null) hashCode = hashCode * 59 + Column.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Domain and the right Domain.
        /// </summary>
        /// <param name="left">Left Domain.</param>
        /// <param name="right">Right Domain.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (Domain left, Domain right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Domain and the right Domain.
        /// </summary>
        /// <param name="left">Left Domain.</param>
        /// <param name="right">Right Domain.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (Domain left, Domain right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Domain</returns>
        public Domain DeepClone()
        {
            return this.Copy();
        }
    }
}