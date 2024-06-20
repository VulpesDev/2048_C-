using System.Collections.Generic;
using System.Drawing;

namespace _2048
{
    public static class Constants
    {
        // Minimum window size
        public const int MinWinSize = 545;

        // Font size calculations
        public const float BaseFontSizeMultiplier = 0.44f;
        public const float DigitSizeReductionFactor = 0.55f;

        // Colors and fonts for different numbers
        public static readonly Color ColorBlack = Color.FromArgb(0, 0, 0);
        public static readonly Color ColorDarkGray = Color.FromArgb(119, 110, 101);
        public static readonly Color ColorLightGray = Color.FromArgb(249, 246, 242);
        public static readonly Color ColorBackground1 = Color.FromArgb(205, 193, 180);
        public static readonly Color ColorBackground2 = Color.FromArgb(238, 228, 218);
        public static readonly Color ColorBackground3 = Color.FromArgb(237, 224, 200);
        public static readonly Color ColorBackground4 = Color.FromArgb(242, 177, 121);
        public static readonly Color ColorBackground5 = Color.FromArgb(245, 149, 99);
        public static readonly Color ColorBackground6 = Color.FromArgb(246, 124, 95);
        public static readonly Color ColorBackground7 = Color.FromArgb(246, 94, 59);
        public static readonly Color ColorBackground8 = Color.FromArgb(237, 207, 114);
        public static readonly Color ColorBackground9 = Color.FromArgb(237, 204, 97);
        public static readonly Color ColorBackground10 = Color.FromArgb(237, 200, 80);
        public static readonly Color ColorBackground11 = Color.FromArgb(237, 197, 63);
        public static readonly Color ColorBackground12 = Color.FromArgb(237, 194, 46);
        public static readonly Color ColorFlick = Color.FromArgb(255, 198, 133, 123);

        // Fonts
        public static readonly Font FontLargeBold = new Font("Arial", 55, FontStyle.Bold);
        public static readonly Font FontMediumBold = new Font("Arial", 50, FontStyle.Bold);
        public static readonly Font FontSmallBold = new Font("Arial", 40, FontStyle.Bold);
        public static readonly Font FontSmallRegular = new Font("Arial", 16, FontStyle.Regular);

        // Number styles dictionary
        public static readonly Dictionary<int, LabelStyle> NumberStyles = new Dictionary<int, LabelStyle>()
        {
            { 0, new LabelStyle(ColorBlack, ColorBackground1, FontSmallBold) },
            { 2, new LabelStyle(ColorDarkGray, ColorBackground2, FontSmallBold) },
            { 4, new LabelStyle(ColorDarkGray, ColorBackground3, FontSmallBold) },
            { 8, new LabelStyle(ColorLightGray, ColorBackground4, FontSmallBold) },
            { 16, new LabelStyle(ColorLightGray, ColorBackground5, FontMediumBold) },
            { 32, new LabelStyle(ColorLightGray, ColorBackground6, FontMediumBold) },
            { 64, new LabelStyle(ColorLightGray, ColorBackground7, FontMediumBold) },
            { 128, new LabelStyle(ColorLightGray, ColorBackground8, FontLargeBold) },
            { 256, new LabelStyle(ColorLightGray, ColorBackground9, FontLargeBold) },
            { 512, new LabelStyle(ColorLightGray, ColorBackground10, FontLargeBold) },
            { 1024, new LabelStyle(ColorLightGray, ColorBackground11, FontLargeBold) },
            { 2048, new LabelStyle(ColorLightGray, ColorBackground12, FontLargeBold) }
        };
    }

    public class LabelStyle
    {
        public Color ForegroundColor { get; }
        public Color BackgroundColor { get; }
        public Font Font { get; }

        public LabelStyle(Color foregroundColor, Color backgroundColor, Font font)
        {
            ForegroundColor = foregroundColor;
            BackgroundColor = backgroundColor;
            Font = font;
        }
    }
}
