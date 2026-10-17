namespace SunamoWpf.Extensions.Color;

public static class SystemWindowsMediaColorExtensions
{
    public static System.Drawing.Color ToSystemDrawing(this System.Windows.Media.Color color)
    {
        return System.Drawing.Color.FromArgb(color.A, color.R, color.G, color.B);
    }
}