// Copyright (c) William Kent. See LICENSE file for more information.

namespace System.Windows.Markup;

/// <summary>
/// Specifies that child content of this class's attribute in the XAML should be stored in the named property.
/// </summary>
[AttributeUsage(AttributeTargets.Class)]
public sealed class ContentPropertyAttribute : Attribute
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ContentPropertyAttribute"/> class.
    /// </summary>
    public ContentPropertyAttribute()
    {
        this.Name = null;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ContentPropertyAttribute"/> class.
    /// </summary>
    /// <param name="name">
    /// The name of the property that receives the XAML element's content.
    /// </param>
    public ContentPropertyAttribute(string name)
    {
        this.Name = name;
    }

    /// <summary>
    /// Gets the name of the property that receives the XAML element's content.
    /// </summary>
    public string? Name { get; }
}
