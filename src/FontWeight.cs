using Intellenum;

namespace Soenneker.Quark;

/// <summary>
/// Typed values for the CSS font-weight property in .NET enumeration form.
/// </summary>
[Intellenum<string>]
public sealed partial class FontWeight
{
    public static readonly FontWeight Light = new("light");
    public static readonly FontWeight Normal = new("normal");
    public static readonly FontWeight Medium = new("medium");
    public static readonly FontWeight Semibold = new("semibold");
    public static readonly FontWeight Bold = new("bold");
    public static readonly FontWeight Bolder = new("bolder");

    public static implicit operator FontWeight(GlobalKeyword style) => new(style.Value);
}
