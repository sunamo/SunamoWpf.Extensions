namespace SunamoWpf.Extensions;

public static class RadioButtonExtensions
{
    public static bool IsCheckedSimple(this RadioButton radioButton)
    {
        if (radioButton.IsChecked.HasValue)
        {
            return radioButton.IsChecked.Value;
        }
        return false;

    }
}