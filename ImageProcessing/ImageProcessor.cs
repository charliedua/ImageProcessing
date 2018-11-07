using System.Drawing;

namespace ImageProcessing
{
    public static class ImageProcessor
    {
        public static void ConvertToGrascale(Bitmap bitmap)
        {
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    Color pixelColor = bitmap.GetPixel(i, j);
                    int R, G, B;
                    R = pixelColor.R;
                    G = pixelColor.B;
                    B = pixelColor.G;
                    R = B = G = (byte)(R * 0.2126 + G * 0.7152 + B * 0.0722);
                    bitmap.SetPixel(i, j, Color.FromArgb(R, B, G));
                }
            }
        }

        public static void ConvertToNegative(Bitmap bitmap)
        {
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    Color pixelColor = bitmap.GetPixel(i, j);
                    int R, G, B;
                    R = 255 - pixelColor.R;
                    G = 255 - pixelColor.B;
                    B = 255 - pixelColor.G;
                    bitmap.SetPixel(i, j, Color.FromArgb(R, B, G));
                }
            }
        }
    }
}