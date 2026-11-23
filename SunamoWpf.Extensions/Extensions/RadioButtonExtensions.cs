namespace SunamoWpf.Extensions;

/// <summary>
/// Represents the radio button extensions type.
/// </summary>
public static class RadioButtonExtensions
{
    /// <summary>
    /// Is checked simple.
    /// </summary>
    /// <param name="radioButton">The radio button.</param>
    /// <returns>The is checked simple result.</returns>
    public static bool IsCheckedSimple(this RadioButton radioButton)
    {
        if (radioButton.IsChecked.HasValue)
        {
            return radioButton.IsChecked.Value;
        }
        return false;

    }
}