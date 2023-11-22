/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;
#pragma warning disable 1591

namespace Plotly.Blazor.Traces.Scatter3DLib.MarkerLib.ColorBarLib.TitleLib
{
    /// <summary>
    ///     Determines the location of color bar&#39;s title with respect to the color
    ///     bar. Defaults to <c>top</c> when <c>orientation</c> if <c>v</c> and  defaults
    ///     to <c>right</c> when <c>orientation</c> if <c>h</c>. Note that the title&#39;s
    ///     location used to be set by the now deprecated <c>titleside</c> attribute.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", null)]
    [JsonConverter(typeof(EnumConverter))]
    public enum SideEnum
    {
        [EnumMember(Value=@"right")]
        Right,
        [EnumMember(Value=@"top")]
        Top,
        [EnumMember(Value=@"bottom")]
        Bottom
    }
}