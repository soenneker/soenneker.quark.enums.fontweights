using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark.Enums;

/// <summary>
/// Typed values for the CSS font-weight property in .NET enumeration form.
/// </summary>
[EnumValue<string>]
[IncludeEnumValues(typeof(GlobalKeyword))]
public sealed partial class FontWeightKeyword
{
    public static readonly FontWeightKeyword Lighter = new("lighter");
    public static readonly FontWeightKeyword Light = new("light");
    public static readonly FontWeightKeyword Normal = new("normal");
    public static readonly FontWeightKeyword Semibold = new("semibold");
    public static readonly FontWeightKeyword Bold = new("bold");
    public static readonly FontWeightKeyword Bolder = new("bolder");
}
