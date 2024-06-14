using System.Drawing;

namespace _2048
{
    public class LabelStyle
    {
        public Color ForegroundColor { get; set; }
        public Color BackgroundColor { get; set; }
        public Font Font { get; set; }

        public LabelStyle(Color foregroundColor, Color backgroundColor, Font font)
        {
            ForegroundColor = foregroundColor;
            BackgroundColor = backgroundColor;
            Font = font;
        }
    }
}
