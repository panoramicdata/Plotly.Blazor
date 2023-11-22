/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;
#pragma warning disable 1591

namespace Plotly.Blazor.Traces.ScatterTernaryLib
{
    /// <summary>
    ///     Determines which trace information appear on hover. If <c>none</c> or <c>skip</c>
    ///     are set, no information is displayed upon hovering. But, if <c>none</c>
    ///     is set, click and hover events are still fired.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "4.0.1.0")]
    [Flags]
    [JsonConverter(typeof(EnumConverter))]
    public enum HoverInfoFlag
    {
        [EnumMember(Value=@"skip")]
        Skip = 0,
        [EnumMember(Value=@"none")]
        None = 1,
        [EnumMember(Value=@"a")]
        A = 2,
        [EnumMember(Value=@"b")]
        B = 4,
        [EnumMember(Value=@"c")]
        C = 8,
        [EnumMember(Value=@"text")]
        Text = 16,
        [EnumMember(Value=@"name")]
        Name = 32,
        [EnumMember(Value=@"all")]
        All = A | B | C | Text | Name
    }
}