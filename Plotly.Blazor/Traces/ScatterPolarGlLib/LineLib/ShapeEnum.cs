/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;
#pragma warning disable 1591

namespace Plotly.Blazor.Traces.ScatterPolarGlLib.LineLib
{
    /// <summary>
    ///     Determines the line shape. The values correspond to step-wise line shapes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", null)]
    [JsonConverter(typeof(EnumConverter))]
    public enum ShapeEnum
    {
        [EnumMember(Value=@"linear")]
        Linear = 0,
        [EnumMember(Value=@"hv")]
        Hv,
        [EnumMember(Value=@"vh")]
        Vh,
        [EnumMember(Value=@"hvh")]
        Hvh,
        [EnumMember(Value=@"vhv")]
        Vhv
    }
}