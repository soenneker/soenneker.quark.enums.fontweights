[![](https://img.shields.io/nuget/v/soenneker.quark.enums.fontweights.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.quark.enums.fontweights/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quark.enums.fontweights/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.quark.enums.fontweights/actions/workflows/publish-package.yml)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quark.enums.fontweights/build-and-test.yml?label=Build&style=for-the-badge)](https://github.com/soenneker/soenneker.quark.enums.fontweights/actions/workflows/build-and-test.yml)
[![](https://img.shields.io/nuget/dt/soenneker.quark.enums.fontweights.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.quark.enums.fontweights/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quark.enums.fontweights/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.quark.enums.fontweights/actions/workflows/codeql.yml)

# Soenneker.Quark.Enums.FontWeights

Strongly typed font-weight tokens for Quark components and styles.

## Install

```bash
dotnet add package Soenneker.Quark.Enums.FontWeights
```

## Usage

```csharp
FontWeightKeyword weight = FontWeightKeyword.Semibold;
string token = weight.Value; // "semibold"
```

The values can be passed through Quark style composition without scattering string literals through component code. The type also includes CSS-wide values from `GlobalKeyword`, such as `Inherit`, `Initial`, `Revert`, `RevertLayer`, and `Unset`.

`Light` and `Semibold` are named design-system tokens. Their raw values are not standalone CSS `font-weight` values; translate them to the appropriate numeric weight when writing a CSS declaration directly.

## Values

| Member | Value |
| --- | --- |
| `Lighter` | `lighter` |
| `Light` | `light` |
| `Normal` | `normal` |
| `Semibold` | `semibold` |
| `Bold` | `bold` |
| `Bolder` | `bolder` |
