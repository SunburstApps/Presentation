// Copyright (c) William Kent. All rights reserved.

namespace System.Windows.Markup;

/// <summary>
/// Specifies that the annotated class, property, or method is ambient.
/// </summary>
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Method)]
public sealed class AmbientAttribute : Attribute
{
}
