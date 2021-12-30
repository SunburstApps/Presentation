// Copyright (c) William Kent. All rights reserved.

namespace System.Windows.Markup;

using System.Diagnostics.CodeAnalysis;

[SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1600", Justification = "Will return once I know what it does")]
public interface INameScope
{
    void RegisterName(string name, object scopedElement);

    void UnregisterName(string name);

    object? FindName(string name);
}
