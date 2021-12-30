// Copyright (c) William Kent. All rights reserved.

namespace System.Windows.Markup;

using System.Diagnostics.CodeAnalysis;

[AttributeUsage(AttributeTargets.Class)]
public sealed class ContentWrapperAttribute : Attribute
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ContentWrapperAttribute"/> class.
    /// </summary>
    /// <param name="contentWrapper">
    /// The type to be used as the content wrapper for the annotated class.
    /// </param>
    public ContentWrapperAttribute(Type contentWrapper)
    {
        this.ContentWrapper = contentWrapper;
    }

    /// <summary>
    /// Gets the type to be used as the content wrapper for the annotated class.
    /// </summary>
    public Type ContentWrapper { get; }

    /// <inheritdoc/>
    public override object TypeId => this;

    /// <inheritdoc/>
    public override bool Equals(object? obj)
    {
        if (obj is null) return false;

        var other = (ContentWrapperAttribute)obj;
        return other.ContentWrapper == this.ContentWrapper;
    }

    /// <inheritdoc/>
    public override int GetHashCode() => this.ContentWrapper.GetHashCode();
}
