namespace SunamoWpf.Extensions.SIze;

/// <summary>
/// Represents the system windows size extensions type.
/// </summary>
public static partial class SystemWindowsSizeExtensions
{
    /// <summary>
    /// To system windows.
    /// </summary>
    /// <param name="size">The size.</param>
    /// <returns>The to system windows result.</returns>
    public static System.Windows.Size ToSystemWindows(this System.Windows.Size size)
    {
        return new System.Windows.Size(size.Width, size.Height);
    }

    #region Musí být zde páč je vyžadovaná v PicturesHelperFw
    /// <summary>
    /// To system drawing.
    /// </summary>
    /// <param name="size">The size.</param>
    /// <returns>The to system drawing result.</returns>
    public static System.Drawing.Size ToSystemDrawing(this System.Windows.Size size)
    {
        return new System.Drawing.Size((int)size.Width, (int)size.Height);
    }
    #endregion
}