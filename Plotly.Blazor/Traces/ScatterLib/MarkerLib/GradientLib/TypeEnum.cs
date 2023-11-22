/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;
#pragma warning disable 1591

namespace Plotly.Blazor.Traces.ScatterLib.MarkerLib.GradientLib
{
    /// <summary>
    ///     Sets the type of gradient used to fill the markers
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "4.0.1.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum TypeEnum
    {
        [EnumMember(Value=@"none")]
        None = 0,
        [EnumMember(Value=@"radial")]
        Radial,
        [EnumMember(Value=@"horizontal")]
        Horizontal,
        [EnumMember(Value=@"vertical")]
        Vertical
    }
}