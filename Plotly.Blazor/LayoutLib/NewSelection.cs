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
    ///     The NewSelection class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "4.0.1.0")]
    [Serializable]
    public class NewSelection : IEquatable<NewSelection>
    {
        /// <summary>
        ///     Gets or sets the Line.
        /// </summary>
        [JsonPropertyName(@"line")]
        public Plotly.Blazor.LayoutLib.NewSelectionLib.Line Line { get; set;} 

        /// <summary>
        ///     Describes how a new selection is created. If <c>immediate</c>, a new selection
        ///     is created after first mouse up. If <c>gradual</c>, a new selection is not
        ///     created after first mouse. By adding to and subtracting from the initial
        ///     selection, this option allows declaring extra outlines of the selection.
        /// </summary>
        [JsonPropertyName(@"mode")]
        public Plotly.Blazor.LayoutLib.NewSelectionLib.ModeEnum? Mode { get; set;} 

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (!(obj is NewSelection other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        /// <inheritdoc />
        public bool Equals([AllowNull] NewSelection other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Line == other.Line ||
                    Line != null &&
                    Line.Equals(other.Line)
                ) && 
                (
                    Mode == other.Mode ||
                    Mode != null &&
                    Mode.Equals(other.Mode)
                );
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (Line != null) hashCode = hashCode * 59 + Line.GetHashCode();
                if (Mode != null) hashCode = hashCode * 59 + Mode.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left NewSelection and the right NewSelection.
        /// </summary>
        /// <param name="left">Left NewSelection.</param>
        /// <param name="right">Right NewSelection.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (NewSelection left, NewSelection right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left NewSelection and the right NewSelection.
        /// </summary>
        /// <param name="left">Left NewSelection.</param>
        /// <param name="right">Right NewSelection.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (NewSelection left, NewSelection right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>NewSelection</returns>
        public NewSelection DeepClone()
        {
            return this.Copy();
        }
    }
}