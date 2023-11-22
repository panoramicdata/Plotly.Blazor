/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;
#pragma warning disable 1591

namespace Plotly.Blazor.Traces.ParCatsLib.LineLib.ColorBarLib
{
    /// <summary>
    ///     Sets this color bar&#39;s vertical position anchor This anchor binds the
    ///     <c>y</c> position to the <c>top</c>, <c>middle</c> or <c>bottom</c> of the
    ///     color bar. Defaults to <c>middle</c> when <c>orientation</c> is <c>v</c>
    ///     and <c>bottom</c> when <c>orientation</c> is <c>h</c>.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", null)]
    [JsonConverter(typeof(EnumConverter))]
    public enum YAnchorEnum
    {
        [EnumMember(Value=@"top")]
        Top,
        [EnumMember(Value=@"middle")]
        Middle,
        [EnumMember(Value=@"bottom")]
        Bottom
    }
}