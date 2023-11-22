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

namespace Plotly.Blazor.LayoutLib.XAxisLib
{
    /// <summary>
    ///     The TickFormatStop class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", null)]
    [Serializable]
    public class TickFormatStop : IEquatable<TickFormatStop>
    {
        /// <summary>
        ///     range [<c>min</c>, <c>max</c>], where <c>min</c>, <c>max</c> - dtick values
        ///     which describe some zoom level, it is possible to omit <c>min</c> or <c>max</c>
        ///     value by passing <c>null</c>
        /// </summary>
        [JsonPropertyName(@"dtickrange")]
        public IList<object> DTickRange { get; set;} 

        /// <summary>
        ///     Determines whether or not this stop is used. If <c>false</c>, this stop
        ///     is ignored even within its <c>dtickrange</c>.
        /// </summary>
        [JsonPropertyName(@"enabled")]
        public bool? Enabled { get; set;} 

        /// <summary>
        ///     When used in a template, named items are created in the output figure in
        ///     addition to any items the figure already has in this array. You can modify
        ///     these items in the output figure by making your own item with <c>templateitemname</c>
        ///     matching this <c>name</c> alongside your modifications (including &#39;visible:
        ///     false&#39; or &#39;enabled: false&#39; to hide it). Has no effect outside
        ///     of a template.
        /// </summary>
        [JsonPropertyName(@"name")]
        public string Name { get; set;} 

        /// <summary>
        ///     Used to refer to a named item in this array in the template. Named items
        ///     from the template will be created even without a matching item in the input
        ///     figure, but you can modify one by making an item with <c>templateitemname</c>
        ///     matching its <c>name</c>, alongside your modifications (including &#39;visible:
        ///     false&#39; or &#39;enabled: false&#39; to hide it). If there is no template
        ///     or no matching item, this item will be hidden unless you explicitly show
        ///     it with &#39;visible: true&#39;.
        /// </summary>
        [JsonPropertyName(@"templateitemname")]
        public string TemplateItemName { get; set;} 

        /// <summary>
        ///     string - dtickformat for described zoom level, the same as <c>tickformat</c>
        /// </summary>
        [JsonPropertyName(@"value")]
        public string Value { get; set;} 

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (!(obj is TickFormatStop other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        /// <inheritdoc />
        public bool Equals([AllowNull] TickFormatStop other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Equals(DTickRange, other.DTickRange) ||
                    DTickRange != null && other.DTickRange != null &&
                    DTickRange.SequenceEqual(other.DTickRange)
                ) &&
                (
                    Enabled == other.Enabled ||
                    Enabled != null &&
                    Enabled.Equals(other.Enabled)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    TemplateItemName == other.TemplateItemName ||
                    TemplateItemName != null &&
                    TemplateItemName.Equals(other.TemplateItemName)
                ) && 
                (
                    Value == other.Value ||
                    Value != null &&
                    Value.Equals(other.Value)
                );
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (DTickRange != null) hashCode = hashCode * 59 + DTickRange.GetHashCode();
                if (Enabled != null) hashCode = hashCode * 59 + Enabled.GetHashCode();
                if (Name != null) hashCode = hashCode * 59 + Name.GetHashCode();
                if (TemplateItemName != null) hashCode = hashCode * 59 + TemplateItemName.GetHashCode();
                if (Value != null) hashCode = hashCode * 59 + Value.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left TickFormatStop and the right TickFormatStop.
        /// </summary>
        /// <param name="left">Left TickFormatStop.</param>
        /// <param name="right">Right TickFormatStop.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (TickFormatStop left, TickFormatStop right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left TickFormatStop and the right TickFormatStop.
        /// </summary>
        /// <param name="left">Left TickFormatStop.</param>
        /// <param name="right">Right TickFormatStop.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (TickFormatStop left, TickFormatStop right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>TickFormatStop</returns>
        public TickFormatStop DeepClone()
        {
            return this.Copy();
        }
    }
}