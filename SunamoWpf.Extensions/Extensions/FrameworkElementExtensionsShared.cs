namespace SunamoWpf.Extensions;

/// <summary>
/// Represents the framework element extensions type.
/// </summary>
public static partial class FrameworkElementExtensions{ 
/// <summary>
/// Actual height.
/// </summary>
/// <param name="element">The element.</param>
/// <returns>The actual height result.</returns>
public static double ActualHeight(this FrameworkElement element)
    {
        if (element == null)
        {
            return 0;
        }

        return element.ActualHeight;
    }
}