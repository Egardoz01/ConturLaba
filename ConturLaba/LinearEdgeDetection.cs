using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConturLaba
{
    public static class LinearEdgeDetection
    {

        public static Bitmap Process(Bitmap image, int[,] mask)
        {

            Color[,] matrix = new Color[image.Height, image.Width];

            for (int i = 0; i < image.Height; i++)
                for (int j = 0; j < image.Width; j++)
                {
                    matrix[i, j] = image.GetPixel(j, i);

                }

            for (int i = 1; i < image.Height - 1; i++)
                for (int j = 1; j < image.Width - 1; j++)
                {
                    int r = 0, g = 0, b = 0;

                    for (int k = 0; k < mask.GetLength(0); k++)
                        for (int l = 0; l < mask.GetLength(1); l++)
                        {
                            int x = j - 1 + l;
                            int y = i - 1 + k;

                            r += mask[k, l] * matrix[y, x].R;
                            g += mask[k, l] * matrix[y, x].G;
                            b += mask[k, l] * matrix[y, x].B;
                        }


                    image.SetPixel(j, i, Color.FromArgb(255, GetValue(r), GetValue(g), GetValue(b)));
                }

            return image;
        }

        private static int GetValue(int val)
        {
            if (val < 0)
                return 0;
            if (val > 255)
                return 255;

            return val;
        }
    }
}
