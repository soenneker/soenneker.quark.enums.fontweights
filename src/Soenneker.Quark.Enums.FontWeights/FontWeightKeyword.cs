using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents a font-weight token used by Quark style composition.
/// </summary>
[EnumValue<string>]
[IncludeEnumValues(typeof(GlobalKeyword))]
public sealed partial class FontWeightKeyword
{
    /// <summary>
    /// The <c>lighter</c> token.
    /// </summary>
    public static readonly FontWeightKeyword Lighter = new("lighter");
    /// <summary>
    /// The <c>light</c> design-system token.
    /// </summary>
    public static readonly FontWeightKeyword Light = new("light");
    /// <summary>
    /// The <c>normal</c> token.
    /// </summary>
    public static readonly FontWeightKeyword Normal = new("normal");
    /// <summary>
    /// The <c>semibold</c> design-system token.
    /// </summary>
    public static readonly FontWeightKeyword Semibold = new("semibold");
    /// <summary>
    /// The <c>bold</c> token.
    /// </summary>
    public static readonly FontWeightKeyword Bold = new("bold");
    /// <summary>
    /// The <c>bolder</c> token.
    /// </summary>
    public static readonly FontWeightKeyword Bolder = new("bolder");
}
