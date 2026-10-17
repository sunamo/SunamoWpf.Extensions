namespace SunamoWpf.Extensions;

public static partial class FrameworkElementExtensions{ 
public static double ActualHeight(this FrameworkElement element)
    {
        if (element == null)
        {
            return 0;
        }

        return element.ActualHeight;
    }
}