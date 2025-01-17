using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public static class RoundedCornersHelper
{
    public static void ApplyRoundedCorners(Control control, int cornerRadius)
    {
        Rectangle rect = control.ClientRectangle;

        using (GraphicsPath path = new GraphicsPath())
        {
            path.AddArc(rect.X, rect.Y, cornerRadius, cornerRadius, 180, 90);
            path.AddArc(rect.Right - cornerRadius, rect.Y, cornerRadius, cornerRadius, 270, 90);
            path.AddArc(rect.Right - cornerRadius, rect.Bottom - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - cornerRadius, cornerRadius, cornerRadius, 90, 90);
            path.CloseFigure();

            control.Region = new Region(path);
        }
    }
}
