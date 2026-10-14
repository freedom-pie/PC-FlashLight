using System;
using System.Collections.Generic;
using System.Text;

namespace PC_FlashLight
{
    internal static class LightColorCalculator
    {
        public static Color Calculate(Color baseColor, int brightness)
        {
            brightness = Math.Clamp(brightness, 0, 100);

            double factor = brightness / 100.0;

            int r = (int)(baseColor.R * factor);
            int g = (int)(baseColor.G * factor);
            int b = (int)(baseColor.B * factor);

            return Color.FromArgb(r, g, b);

        }
    }
}
