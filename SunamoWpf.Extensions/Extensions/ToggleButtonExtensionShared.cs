namespace SunamoWpf.Extensions;

/// <summary>
/// Represents the toggle button extensions type.
/// </summary>
public static partial class ToggleButtonExtensions{ 
/// <summary>
/// Is checked simple.
/// </summary>
/// <param name="toggleButton">The toggle button.</param>
/// <returns>The is checked simple result.</returns>
public static bool IsCheckedSimple(this ToggleButton toggleButton)
    {
        if (toggleButton.IsChecked.HasValue)
        {
            return toggleButton.IsChecked.Value;
        }

        return false;
    }
}