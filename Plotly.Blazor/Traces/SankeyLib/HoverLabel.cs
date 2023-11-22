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

namespace Plotly.Blazor.Traces.SankeyLib
{
    /// <summary>
    ///     The HoverLabel class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", null)]
    [JsonConverter(typeof(PlotlyConverter))]
    [Serializable]
    public class HoverLabel : IEquatable<HoverLabel>
    {
        /// <summary>
        ///     Sets the horizontal alignment of the text content within hover label box.
        ///     Has an effect only if the hover label text spans more two or more lines
        /// </summary>
        [JsonPropertyName(@"align")]
        public Plotly.Blazor.Traces.SankeyLib.HoverLabelLib.AlignEnum? Align { get; set;} 

        /// <summary>
        ///     Sets the horizontal alignment of the text content within hover label box.
        ///     Has an effect only if the hover label text spans more two or more lines
        /// </summary>
        [JsonPropertyName(@"align")]
        [Array]
        public IList<Plotly.Blazor.Traces.SankeyLib.HoverLabelLib.AlignEnum?> AlignArray { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for <c>align</c>.
        /// </summary>
        [JsonPropertyName(@"alignsrc")]
        public string AlignSrc { get; set;} 

        /// <summary>
        ///     Sets the background color of the hover labels for this trace
        /// </summary>
        [JsonPropertyName(@"bgcolor")]
        public object BgColor { get; set;} 

        /// <summary>
        ///     Sets the background color of the hover labels for this trace
        /// </summary>
        [JsonPropertyName(@"bgcolor")]
        [Array]
        public IList<object> BgColorArray { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for <c>bgcolor</c>.
        /// </summary>
        [JsonPropertyName(@"bgcolorsrc")]
        public string BgColorSrc { get; set;} 

        /// <summary>
        ///     Sets the border color of the hover labels for this trace.
        /// </summary>
        [JsonPropertyName(@"bordercolor")]
        public object BorderColor { get; set;} 

        /// <summary>
        ///     Sets the border color of the hover labels for this trace.
        /// </summary>
        [JsonPropertyName(@"bordercolor")]
        [Array]
        public IList<object> BorderColorArray { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for <c>bordercolor</c>.
        /// </summary>
        [JsonPropertyName(@"bordercolorsrc")]
        public string BorderColorSrc { get; set;} 

        /// <summary>
        ///     Sets the font used in hover labels.
        /// </summary>
        [JsonPropertyName(@"font")]
        public Plotly.Blazor.Traces.SankeyLib.HoverLabelLib.Font Font { get; set;} 

        /// <summary>
        ///     Sets the default length (in number of characters) of the trace name in the
        ///     hover labels for all traces. -1 shows the whole name regardless of length.
        ///     0-3 shows the first 0-3 characters, and an integer &gt;3 will show the whole
        ///     name if it is less than that many characters, but if it is longer, will
        ///     truncate to &#39;namelength - 3&#39; characters and add an ellipsis.
        /// </summary>
        [JsonPropertyName(@"namelength")]
        public int? NameLength { get; set;} 

        /// <summary>
        ///     Sets the default length (in number of characters) of the trace name in the
        ///     hover labels for all traces. -1 shows the whole name regardless of length.
        ///     0-3 shows the first 0-3 characters, and an integer &gt;3 will show the whole
        ///     name if it is less than that many characters, but if it is longer, will
        ///     truncate to &#39;namelength - 3&#39; characters and add an ellipsis.
        /// </summary>
        [JsonPropertyName(@"namelength")]
        [Array]
        public IList<int?> NameLengthArray { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for <c>namelength</c>.
        /// </summary>
        [JsonPropertyName(@"namelengthsrc")]
        public string NameLengthSrc { get; set;} 

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (!(obj is HoverLabel other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        /// <inheritdoc />
        public bool Equals([AllowNull] HoverLabel other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Align == other.Align ||
                    Align != null &&
                    Align.Equals(other.Align)
                ) && 
                (
                    Equals(AlignArray, other.AlignArray) ||
                    AlignArray != null && other.AlignArray != null &&
                    AlignArray.SequenceEqual(other.AlignArray)
                ) &&
                (
                    AlignSrc == other.AlignSrc ||
                    AlignSrc != null &&
                    AlignSrc.Equals(other.AlignSrc)
                ) && 
                (
                    BgColor == other.BgColor ||
                    BgColor != null &&
                    BgColor.Equals(other.BgColor)
                ) && 
                (
                    Equals(BgColorArray, other.BgColorArray) ||
                    BgColorArray != null && other.BgColorArray != null &&
                    BgColorArray.SequenceEqual(other.BgColorArray)
                ) &&
                (
                    BgColorSrc == other.BgColorSrc ||
                    BgColorSrc != null &&
                    BgColorSrc.Equals(other.BgColorSrc)
                ) && 
                (
                    BorderColor == other.BorderColor ||
                    BorderColor != null &&
                    BorderColor.Equals(other.BorderColor)
                ) && 
                (
                    Equals(BorderColorArray, other.BorderColorArray) ||
                    BorderColorArray != null && other.BorderColorArray != null &&
                    BorderColorArray.SequenceEqual(other.BorderColorArray)
                ) &&
                (
                    BorderColorSrc == other.BorderColorSrc ||
                    BorderColorSrc != null &&
                    BorderColorSrc.Equals(other.BorderColorSrc)
                ) && 
                (
                    Font == other.Font ||
                    Font != null &&
                    Font.Equals(other.Font)
                ) && 
                (
                    NameLength == other.NameLength ||
                    NameLength != null &&
                    NameLength.Equals(other.NameLength)
                ) && 
                (
                    Equals(NameLengthArray, other.NameLengthArray) ||
                    NameLengthArray != null && other.NameLengthArray != null &&
                    NameLengthArray.SequenceEqual(other.NameLengthArray)
                ) &&
                (
                    NameLengthSrc == other.NameLengthSrc ||
                    NameLengthSrc != null &&
                    NameLengthSrc.Equals(other.NameLengthSrc)
                );
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (Align != null) hashCode = hashCode * 59 + Align.GetHashCode();
                if (AlignArray != null) hashCode = hashCode * 59 + AlignArray.GetHashCode();
                if (AlignSrc != null) hashCode = hashCode * 59 + AlignSrc.GetHashCode();
                if (BgColor != null) hashCode = hashCode * 59 + BgColor.GetHashCode();
                if (BgColorArray != null) hashCode = hashCode * 59 + BgColorArray.GetHashCode();
                if (BgColorSrc != null) hashCode = hashCode * 59 + BgColorSrc.GetHashCode();
                if (BorderColor != null) hashCode = hashCode * 59 + BorderColor.GetHashCode();
                if (BorderColorArray != null) hashCode = hashCode * 59 + BorderColorArray.GetHashCode();
                if (BorderColorSrc != null) hashCode = hashCode * 59 + BorderColorSrc.GetHashCode();
                if (Font != null) hashCode = hashCode * 59 + Font.GetHashCode();
                if (NameLength != null) hashCode = hashCode * 59 + NameLength.GetHashCode();
                if (NameLengthArray != null) hashCode = hashCode * 59 + NameLengthArray.GetHashCode();
                if (NameLengthSrc != null) hashCode = hashCode * 59 + NameLengthSrc.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left HoverLabel and the right HoverLabel.
        /// </summary>
        /// <param name="left">Left HoverLabel.</param>
        /// <param name="right">Right HoverLabel.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (HoverLabel left, HoverLabel right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left HoverLabel and the right HoverLabel.
        /// </summary>
        /// <param name="left">Left HoverLabel.</param>
        /// <param name="right">Right HoverLabel.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (HoverLabel left, HoverLabel right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>HoverLabel</returns>
        public HoverLabel DeepClone()
        {
            return this.Copy();
        }
    }
}