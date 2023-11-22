/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;
#pragma warning disable 1591

namespace Plotly.Blazor.LayoutLib
{
    /// <summary>
    ///     Determines how bars at the same location coordinate are displayed on the
    ///     graph. With <c>group</c>, the bars are plotted next to one another centered
    ///     around the shared location. With <c>overlay</c>, the bars are plotted over
    ///     one another, you might need to reduce <c>opacity</c> to see multiple bars.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "4.0.1.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum WaterfallModeEnum
    {
        [EnumMember(Value=@"group")]
        Group = 0,
        [EnumMember(Value=@"overlay")]
        Overlay
    }
}