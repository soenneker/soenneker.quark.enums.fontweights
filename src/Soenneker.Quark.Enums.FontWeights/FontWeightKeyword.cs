using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Typed values for the CSS font-weight property in .NET enumeration form.
/// </summary>
[EnumValue<string>]
[IncludeEnumValues(typeof(GlobalKeyword))]
public sealed partial class FontWeightKeyword
{
    /// <summary>
    /// The lighter.
    /// </summary>
    public static readonly FontWeightKeyword Lighter = new("lighter");
    /// <summary>
    /// The light.
    /// </summary>
    public static readonly FontWeightKeyword Light = new("light");
    /// <summary>
    /// The normal.
    /// </summary>
    public static readonly FontWeightKeyword Normal = new("normal");
    /// <summary>
    /// The semibold.
    /// </summary>
    public static readonly FontWeightKeyword Semibold = new("semibold");
    /// <summary>
    /// The bold.
    /// </summary>
    public static readonly FontWeightKeyword Bold = new("bold");
    /// <summary>
    /// The bolder.
    /// </summary>
    public static readonly FontWeightKeyword Bolder = new("bolder");
}
