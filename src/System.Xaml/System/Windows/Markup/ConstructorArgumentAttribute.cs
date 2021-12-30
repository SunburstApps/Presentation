// Copyright (c) William Kent. See LICENSE file for more information.

namespace System.Windows.Markup;

/// <summary>
/// Specifies that the annotated XAML property is to be passed as a constructor argument.
/// </summary>
[AttributeUsage(AttributeTargets.Property)]
public sealed class ConstructorArgumentAttribute : Attribute
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ConstructorArgumentAttribute"/> class.
    /// </summary>
    /// <param name="argumentName">
    /// The name of the argument to be used when passing this value.
    /// </param>
    public ConstructorArgumentAttribute(string argumentName)
    {
        this.ArgumentName = argumentName;
    }

    /// <summary>
    /// Gets the name of the argument to be used.
    /// </summary>
    public string ArgumentName { get; }
}
