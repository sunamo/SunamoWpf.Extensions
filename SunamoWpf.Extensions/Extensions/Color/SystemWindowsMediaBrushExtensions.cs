namespace SunamoWpf.Extensions.Color;

/// <summary>
/// Represents the system windows media solid color brush extensions type.
/// </summary>
[System.Runtime.Versioning.SupportedOSPlatform("windows")]
public static class SystemWindowsMediaSolidColorBrushExtensions
{
    /// <summary>
    /// To system drawing.
    /// </summary>
    /// <param name="brush">The brush.</param>
    /// <returns>The to system drawing result.</returns>
    public static System.Drawing.Brush ToSystemDrawing(this System.Windows.Media.SolidColorBrush brush)
    {
        var color = brush.Color;
        return new System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(color.A, color.R, color.G, color.B));
    }
}