/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;
#pragma warning disable 1591

namespace Plotly.Blazor.Transforms.SortLib
{
    /// <summary>
    ///     Sets the sort transform order.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "4.0.1.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum OrderEnum
    {
        [EnumMember(Value=@"ascending")]
        Ascending = 0,
        [EnumMember(Value=@"descending")]
        Descending
    }
}