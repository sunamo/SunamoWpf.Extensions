namespace SunamoWpf.Extensions;

public static partial class ToggleButtonExtensions{ 
public static bool IsCheckedSimple(this ToggleButton toggleButton)
    {
        if (toggleButton.IsChecked.HasValue)
        {
            return toggleButton.IsChecked.Value;
        }

        return false;
    }
}