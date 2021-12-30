// Copyright (c) William Kent. All rights reserved.

namespace System.Windows.Markup;

/// <summary>
/// Specifies that one property depends on another.
/// </summary>
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Method, AllowMultiple = true)]
public sealed class DependsOnAttribute : Attribute
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DependsOnAttribute"/> class.
    /// </summary>
    /// <param name="name">
    /// The name of the property that is the dependency.
    /// </param>
    public DependsOnAttribute(string name)
    {
        this.Name = name;
    }

    /// <summary>
    /// Gets the name of the property that is the dependency.
    /// </summary>
    public string Name { get; }

    /// <inheritdoc/>
    public override object TypeId => this;
}
