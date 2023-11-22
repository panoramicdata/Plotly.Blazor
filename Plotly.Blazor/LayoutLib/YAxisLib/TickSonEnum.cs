/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;
#pragma warning disable 1591

namespace Plotly.Blazor.LayoutLib.YAxisLib
{
    /// <summary>
    ///     Determines where ticks and grid lines are drawn with respect to their corresponding
    ///     tick labels. Only has an effect for axes of <c>type</c> <c>category</c>
    ///     or <c>multicategory</c>. When set to <c>boundaries</c>, ticks and grid lines
    ///     are drawn half a category to the left/bottom of labels.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "4.0.1.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum TickSonEnum
    {
        [EnumMember(Value=@"labels")]
        Labels = 0,
        [EnumMember(Value=@"boundaries")]
        Boundaries
    }
}