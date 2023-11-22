/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;
#pragma warning disable 1591

namespace Plotly.Blazor.LayoutLib.SceneLib.YAxisLib
{
    /// <summary>
    ///     If <c>normal</c>, the range is computed in relation to the extrema of the
    ///     input data. If <c>tozero</c>`, the range extends to 0, regardless of the
    ///     input data If <c>nonnegative</c>, the range is non-negative, regardless
    ///     of the input data. Applies only to linear axes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "4.0.1.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum RangeModeEnum
    {
        [EnumMember(Value=@"normal")]
        Normal = 0,
        [EnumMember(Value=@"tozero")]
        ToZero,
        [EnumMember(Value=@"nonnegative")]
        NonNegative
    }
}