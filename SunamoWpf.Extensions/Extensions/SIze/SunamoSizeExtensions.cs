namespace SunamoWpf.Extensions.SIze;

public static partial class SystemWindowsSizeExtensions
{
    public static System.Windows.Size ToSystemWindows(this System.Windows.Size size)
    {
        return new System.Windows.Size(size.Width, size.Height);
    }

    #region Musí být zde páč je vyžadovaná v PicturesHelperFw
    public static System.Drawing.Size ToSystemDrawing(this System.Windows.Size size)
    {
        return new System.Drawing.Size((int)size.Width, (int)size.Height);
    }
    #endregion
}