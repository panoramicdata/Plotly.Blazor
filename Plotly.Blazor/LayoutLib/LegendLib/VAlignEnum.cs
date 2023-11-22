/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;
#pragma warning disable 1591

namespace Plotly.Blazor.LayoutLib.LegendLib
{
    /// <summary>
    ///     Sets the vertical alignment of the symbols with respect to their associated
    ///     text.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", null)]
    [JsonConverter(typeof(EnumConverter))]
    public enum VAlignEnum
    {
        [EnumMember(Value=@"middle")]
        Middle = 0,
        [EnumMember(Value=@"top")]
        Top,
        [EnumMember(Value=@"bottom")]
        Bottom
    }
}