using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConturLaba
{
    public static class ImageProcessor
    {
        public static Bitmap ApplyMask(Bitmap image, MaskType maskType)
        {
            var mask = GetMask(maskType);

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

        private static int[,] GetMask(MaskType mask)
        {
            switch (mask)
            {
                case MaskType.HorizontalLineMask:
                    return HotizontalLineMask;
                case MaskType.VerticalLineMask:
                    return VerticalLineMask;
                case MaskType.DiagonalMask_1:
                    return DiagonalLineMask_1;
                case MaskType.DiagonalMask_2:
                    return DiagonalLineMask_2;
                case MaskType.Gradient_1:
                    return Gradient_1;
                case MaskType.Gradient_2:
                    return Gradient_2;
                case MaskType.Gradient_3:
                    return Gradient_3;
                default:
                    return null;
            }
        }


        private static int[,] HotizontalLineMask = new int[,] {
            { -1, -1, -1 },
            { 2, 2, 2 },
            { -1, -1, -1 }
        };

        private static int[,] VerticalLineMask = new int[,] {
            { -1, 2, -1 },
            { -1, 2, -1 },
            { -1, 2, -1 }
        };

        private static int[,] DiagonalLineMask_1 = new int[,] {
            { 2, -1, -1 },
            { -1, 2, -1 },
            { -1, -1, 2 }
        };

        private static int[,] DiagonalLineMask_2 = new int[,] {
            { -1, -1, 2 },
            { -1, 2, -1 },
            { 2, -1, -1 }
        };

        private static int[,] Gradient_1 = new int[,] {
            { 1, 1, 1 },
            { 1, -2, 1 },
            { -1, -1, -1 }
        };

        private static int[,] Gradient_2 = new int[,] {
            { 1, 1, 1 },
            { -1, -2, 1 },
            { -1, -1, 1 }
        };

        private static int[,] Gradient_3 = new int[,] {
            { -1, 1, 1 },
            { -1, -2, 1 },
            { -1, 1, 1 }
        };

    }
}
