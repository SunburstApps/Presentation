// Copyright (c) William Kent. See LICENSE file for more information.

namespace System.Windows.Markup;

/// <summary>
/// Specifies whether or not the annotated class is usable during before initialization has completed.
/// </summary>
[AttributeUsage(AttributeTargets.Class)]
public sealed class UsableDuringInitializationAttribute : Attribute
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UsableDuringInitializationAttribute"/> class.
    /// </summary>
    /// <param name="usable">
    /// Whether or not the annotated class is usable during before initialization has completed.
    /// </param>
    public UsableDuringInitializationAttribute(bool usable)
    {
        this.Usable = usable;
    }

    /// <summary>
    /// Gets a value indicating whether or not the annotated class is usable during before initialization has completed.
    /// </summary>
    public bool Usable { get; }
}
