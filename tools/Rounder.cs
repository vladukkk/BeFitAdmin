using System.Drawing.Drawing2D;
using System.Drawing;
using System.Web.UI;
using System.Windows.Forms;

namespace BeFitAdmin.tools
{
    public class Rounder
    {
        public static void roundBorders(System.Windows.Forms.Control control, int cornerRadius)
        {
            GraphicsPath path = new GraphicsPath();

            // Додаємо верхній лівий кут
            path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);

            // Додаємо верхній правий кут
            path.AddArc(control.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);

            // Додаємо нижній правий кут
            path.AddArc(control.Width - cornerRadius, control.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);

            // Додаємо нижній лівий кут
            path.AddArc(0, control.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);

            // Закриваємо шлях
            path.CloseAllFigures();

            // Обрізаємо область контролу
            control.Region = new Region(path);
        }
    }
}
