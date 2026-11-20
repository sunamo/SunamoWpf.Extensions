namespace SunamoWpf.Extensions.Color;

/// <summary>
/// Represents the system windows media color extensions type.
/// </summary>
public static class SystemWindowsMediaColorExtensions
{
    /// <summary>
    /// To system drawing.
    /// </summary>
    /// <param name="color">The color.</param>
    /// <returns>The to system drawing result.</returns>
    public static System.Drawing.Color ToSystemDrawing(this System.Windows.Media.Color color)
    {
        return System.Drawing.Color.FromArgb(color.A, color.R, color.G, color.B);
    }
}