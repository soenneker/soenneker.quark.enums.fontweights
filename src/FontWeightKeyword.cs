using Intellenum;

namespace Soenneker.Quark.Enums;

/// <summary>
/// Typed values for the CSS font-weight property in .NET enumeration form.
/// </summary>
[Intellenum<string>]
public sealed partial class FontWeightKeywordKeyword
{
    public static readonly FontWeightKeyword Light = new("light");
    public static readonly FontWeightKeyword Normal = new("normal");
    public static readonly FontWeightKeyword Medium = new("medium");
    public static readonly FontWeightKeyword Semibold = new("semibold");
    public static readonly FontWeightKeyword Bold = new("bold");
    public static readonly FontWeightKeyword Bolder = new("bolder");

    public static implicit operator FontWeightKeyword(GlobalKeyword style) => new(style.Value);
}
