using System.Drawing;

namespace ConturLaba
{
    public static class ImageProcessor
    {
        public static Bitmap Process(Bitmap image, AlgoType algo)
        {
            if (algo >= AlgoType.HorizontalLineMask && algo <= AlgoType.Laplass_3)
                return LinearEdgeDetection.Process(image, GetMaskForLinearAlgo(algo));

            if (algo >= AlgoType.Previt && algo < AlgoType.Kirsh)
            {
                var masks = GetMasksForNonLinearAlgo(algo);
                return SobelEdgeDetection.Process(image, masks.Item1, masks.Item2);
            }

            if (algo == AlgoType.Kirsh)
            {
                return LinearEdgeDetection.Process(image, Kirsh);
            }

            return null;
        }

        private static int[,,] GetMaskForLinearAlgo(AlgoType algo)
        {
            switch (algo)
            {
                case AlgoType.HorizontalLineMask:
                    return HotizontalLineMask;

                case AlgoType.VerticalLineMask:
                    return VerticalLineMask;

                case AlgoType.DiagonalMask_1:
                    return DiagonalLineMask_1;

                case AlgoType.DiagonalMask_2:
                    return DiagonalLineMask_2;

                case AlgoType.Gradient_1:
                    return Gradient_1;

                case AlgoType.Gradient_2:
                    return Gradient_2;

                case AlgoType.Gradient_3:
                    return Gradient_3;

                case AlgoType.Gradient_4:
                    return Gradient_4;

                case AlgoType.Gradient_5:
                    return Gradient_5;

                case AlgoType.Gradient_6:
                    return Gradient_6;

                case AlgoType.Gradient_7:
                    return Gradient_7;

                case AlgoType.Gradient_8:
                    return Gradient_8;

                case AlgoType.Laplass_1:
                    return Laplass_1;

                case AlgoType.Laplass_2:
                    return Laplass_2;

                case AlgoType.Laplass_3:
                    return Laplass_3;

                default:
                    return null;
            }
        }

        private static (int[,], int[,]) GetMasksForNonLinearAlgo(AlgoType algo)
        {
            switch (algo)
            {
                case AlgoType.Previt:
                    return (Previt_1, Previt_2);

                case AlgoType.Sobel_1:
                    return (Sobel_1, Sobel_2);

                case AlgoType.Sobel_2:
                    return (Sobel_3, Sobel_4);

                case AlgoType.Sobel_3:
                    return (Solbel_5, Sobel_6);

                case AlgoType.Roberts:
                    return (Roberts_1, Roberts_2);

                default:
                    return (null, null);
            }
        }


        private static int[,,] HotizontalLineMask = new int[,,] {
            {
            { -1, -1, -1 },
            { 2, 2, 2 },
            { -1, -1, -1 }
        }
        };

        private static int[,,] VerticalLineMask = new int[,,] {
            {
            { -1, 2, -1 },
            { -1, 2, -1 },
            { -1, 2, -1 }
            }
        };

        private static int[,,] DiagonalLineMask_1 = new int[,,] {
            {
            { 2, -1, -1 },
            { -1, 2, -1 },
            { -1, -1, 2 }
                }
        };

        private static int[,,] DiagonalLineMask_2 = new int[,,] {
            {
            { -1, -1, 2 },
            { -1, 2, -1 },
            { 2, -1, -1 }
                }
        };

        private static int[,,] Gradient_1 = new int[,,] {
            {
            { 1, 1, 1 },
            { 1, -2, 1 },
            { -1, -1, -1 }
                 }
        };

        private static int[,,] Gradient_2 = new int[,,] {
            {
            { 1, 1, 1 },
            { -1, -2, 1 },
            { -1, -1, 1 }
                }
        };

        private static int[,,] Gradient_3 = new int[,,] {
            {
            { -1, 1, 1 },
            { -1, -2, 1 },
            { -1, 1, 1 }
                 }
        };

        private static int[,,] Gradient_4 = new int[,,] {
            {
            { -1, -1, 1 },
            { -1, -2, 1 },
            { 1, 1, 1 }
                 }
        };

        private static int[,,] Gradient_5 = new int[,,] {
            {
            { -1, -1, -1 },
            { 1, -2, 1 },
            { 1, 1, 1 }
                 }
        };

        private static int[,,] Gradient_6 = new int[,,] {
            {
            { 1, -1, -1 },
            { 1, -2, -1 },
            { 1, 1, 1 }
                 }
        };

        private static int[,,] Gradient_7 = new int[,,] {
            {
            { 1, 1, -1 },
            { 1, -2, -1 },
            { 1, 1, -1 }
                 }
        };

        private static int[,,] Gradient_8 = new int[,,] {
            {
            { 1, 1, 1 },
            { 1, -2, -1 },
            { 1, -1, -1 }
                 }
        };

        private static int[,,] Laplass_1 = new int[,,] {
            {
            { 0, -1, 0 },
            { -1, 4, -1 },
            { 0, -1, 0 }
                 }
        };

        private static int[,,] Laplass_2 = new int[,,] {
            {
            { -1, -1, -1 },
            { -1, 8, -1 },
            { -1, -1, -1 }
                 }
        };

        private static int[,,] Laplass_3 = new int[,,] {
            {
            { 1, -2, 1 },
            { -2, 4, -2 },
            { 1, -2, 1 }
                 }
        };

        private static int[,] Previt_1 = new int[,] {
            { -1, 0, 1 },
            { -1, 0, 1 },
            { -1, 0, 1 }
        };

        private static int[,] Previt_2 = new int[,] {
            { -1, -1, -1 },
            { 0, 0, 0 },
            { 1, 1, 1 }
        };

        private static int[,] Sobel_1 = new int[,] {
            { -1, 0, 1 },
            { -2, 0, 2 },
            { -1, 0, 1 }
        };


        private static int[,] Sobel_2 = new int[,] {
            { -1, -2, -1 },
            { 0, 0, 0 },
            { 1, 2, 1 }
        };

        private static int[,] Sobel_3 = new int[,] {
            { 0, 1, 1 },
            { -1, 0, 1 },
            { -1, -1, 0 }
        };

        private static int[,] Sobel_4 = new int[,] {
            { -1, -1, 0 },
            { -1, 0, 1 },
            { 0, 1, 1 }
        };

        private static int[,] Solbel_5 = new int[,] {
            { 0, 1, 2 },
            { -1, 0, 1 },
            { -2, -1, 0 }
        };


        private static int[,] Sobel_6 = new int[,] {
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


        private static int[,,] Kirsh = new int[,,] {
            {
                { 5, 5, 5 },
                { -3, 0, -3 },
                { -3, -3, -3 }
            },
             {
                { -3, 5, 5 },
                { -3, 0, 5 },
                { -3, -3, -3 }
            },
              {
                { -3, -3, 5 },
                { -3, 0, 5 },
                { -3, -3, 5 }
            },
               {
                { -3, -3, -3 },
                { -3, 0, 5 },
                { -3, 5, 5 }
            },
               {
                { -3, -3, -3 },
                { -3, 0, -3 },
                { 5, 5, 5 }
            },
                {
                { -3, -3, -3 },
                { 5, 0, -3 },
                { 5, 5, -3 }
            },
                 {
                { 5, -3, -3 },
                { 5, 0, -3 },
                { 5, -3, -3 }
            },
                 {
                { 5, 5, -3 },
                { 5, 0, -3 },
                { -3, -3, -3 }
            }

        };
    }
}
