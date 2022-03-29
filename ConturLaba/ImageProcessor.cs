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

                case MaskType.Gradient_4:
                    return Gradient_4;

                case MaskType.Gradient_5:
                    return Gradient_5;

                case MaskType.Gradient_6:
                    return Gradient_6;

                case MaskType.Gradient_7:
                    return Gradient_7;

                case MaskType.Gradient_8:
                    return Gradient_8;

                case MaskType.Laplass_1:
                    return Laplass_1;

                case MaskType.Laplass_2:
                    return Laplass_2;

                case MaskType.Laplass_3:
                    return Laplass_3;

                case MaskType.PrevitAndSobel_1:
                    return PrevitAndSobel_1;

                case MaskType.PrevitAndSobel_2:
                    return PrevitAndSobel_2;

                case MaskType.PrevitAndSobel_3:
                    return PrevitAndSobel_3;

                case MaskType.PrevitAndSobel_4:
                    return PrevitAndSobel_4;

                case MaskType.PrevitAndSobel_5:
                    return PrevitAndSobel_5;

                case MaskType.PrevitAndSobel_6:
                    return PrevitAndSobel_6;

                case MaskType.PrevitAndSobel_7:
                    return PrevitAndSobel_7;

                case MaskType.PrevitAndSobel_8:
                    return PrevitAndSobel_8;

                case MaskType.Roberts_1:
                    return Roberts_1;

                case MaskType.Roberts_2:
                    return Roberts_2;

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

        private static int[,] Gradient_4 = new int[,] {
            { -1, -1, 1 },
            { -1, -2, 1 },
            { 1, 1, 1 }
        };

        private static int[,] Gradient_5 = new int[,] {
            { -1, -1, -1 },
            { 1, -2, 1 },
            { 1, 1, 1 }
        };

        private static int[,] Gradient_6 = new int[,] {
            { 1, -1, -1 },
            { 1, -2, -1 },
            { 1, 1, 1 }
        };

        private static int[,] Gradient_7 = new int[,] {
            { 1, 1, -1 },
            { 1, -2, -1 },
            { 1, 1, -1 }
        };

        private static int[,] Gradient_8 = new int[,] {
            { 1, 1, 1 },
            { 1, -2, -1 },
            { 1, -1, -1 }
        };

        private static int[,] Laplass_1 = new int[,] {
            { 0, -1, 0 },
            { -1, 4, -1 },
            { 0, -1, 0 }
        };

        private static int[,] Laplass_2 = new int[,] {
            { -1, -1, -1 },
            { -1, 8, -1 },
            { -1, -1, -1 }
        };

        private static int[,] Laplass_3 = new int[,] {
            { 1, -2, 1 },
            { -2, 4, -2 },
            { 1, -2, 1 }
        };

        private static int[,] PrevitAndSobel_1 = new int[,] {
            { -1, 0, 1 },
            { -1, 0, 1 },
            { -1, 0, 1 }
        };

        private static int[,] PrevitAndSobel_2 = new int[,] {
            { -1, -1, -1 },
            { 0, 0, 0 },
            { 1, 1, 1 }
        };

        private static int[,] PrevitAndSobel_3 = new int[,] {
            { -1, 0, 1 },
            { -2, 0, 2 },
            { -1, 0, 1 }
        };


        private static int[,] PrevitAndSobel_4 = new int[,] {
            { -1, -2, -1 },
            { 0, 0, 0 },
            { 1, 2, 1 }
        };

        private static int[,] PrevitAndSobel_5 = new int[,] {
            { 0, 1, 1 },
            { -1, 0, 1 },
            { -1, -1, 0 }
        };

        private static int[,] PrevitAndSobel_6 = new int[,] {
            { -1, -1, 0 },
            { -1, 0, 1 },
            { 0, 1, 1 }
        };

        private static int[,] PrevitAndSobel_7 = new int[,] {
            { 0, 1, 2 },
            { -1, 0, 1 },
            { -2, -1, 0 }
        };


        private static int[,] PrevitAndSobel_8 = new int[,] {
            { -2, -1, 0 },
            { -1, 0, 1 },
            { 0, 1, 2 }
        };


        private static int[,] Roberts_1 = new int[,] {
            { 1, 0 },
            { 0, -1},
        };

        private static int[,] Roberts_2 = new int[,] {
            { 0, 1 },
            { -1, 0},
        };
    }
}
