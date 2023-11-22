/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;
#pragma warning disable 1591

namespace Plotly.Blazor.LayoutLib.TernaryLib.BAxisLib
{
    /// <summary>
    ///     Determines whether ticks are drawn or not. If **, this axis&#39; ticks are
    ///     not drawn. If <c>outside</c> (<c>inside</c>), this axis&#39; are drawn outside
    ///     (inside) the axis lines.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", null)]
    [JsonConverter(typeof(EnumConverter))]
    public enum TicksEnum
    {
        [EnumMember(Value=@"outside")]
        Outside,
        [EnumMember(Value=@"inside")]
        Inside,
        [EnumMember(Value=@"")]
        Empty
    }
}