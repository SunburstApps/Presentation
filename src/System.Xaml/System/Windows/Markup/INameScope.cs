// Copyright (c) William Kent. See LICENSE file for more information.

namespace System.Windows.Markup;

public interface INameScope
{
    void RegisterName(string name, object scopedElement);

    void UnregisterName(string name);

    object? FindName(string name);
}
