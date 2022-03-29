using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConturLaba
{
    public static class SobelEdgeDetection
    {

        public static Bitmap Process(Bitmap b, int[,] gx, int[,] gy)
        {
            int width = b.Width;
            int height = b.Height;


            int[,] allPixR = new int[width, height];
            int[,] allPixG = new int[width, height];
            int[,] allPixB = new int[width, height];

            int limit = 128 * 128;

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    allPixR[i, j] = b.GetPixel(i, j).R;
                    allPixG[i, j] = b.GetPixel(i, j).G;
                    allPixB[i, j] = b.GetPixel(i, j).B;
                }
            }

            int new_rx = 0, new_ry = 0;
            int new_gx = 0, new_gy = 0;
            int new_bx = 0, new_by = 0;
            int rc, gc, bc;
            for (int i = 1; i < b.Width - gx.GetLength(0) + 2; i++)
            {
                for (int j = 1; j < b.Height - gx.GetLength(0) + 2; j++)
                {

                    new_rx = 0;
                    new_ry = 0;
                    new_gx = 0;
                    new_gy = 0;
                    new_bx = 0;
                    new_by = 0;

                    for (int wi = -1; wi < gx.GetLength(0) - 1; wi++)
                    {
                        for (int hw = -1; hw < gx.GetLength(0) - 1; hw++)
                        {
                            rc = allPixR[i + hw, j + wi];
                            new_rx += gx[wi + 1, hw + 1] * rc;
                            new_ry += gy[wi + 1, hw + 1] * rc;

                            gc = allPixG[i + hw, j + wi];
                            new_gx += gx[wi + 1, hw + 1] * gc;
                            new_gy += gy[wi + 1, hw + 1] * gc;

                            bc = allPixB[i + hw, j + wi];
                            new_bx += gx[wi + 1, hw + 1] * bc;
                            new_by += gy[wi + 1, hw + 1] * bc;
                        }
                    }

                    int rr = (int)Math.Sqrt(new_rx * new_rx + new_ry * new_ry);
                    int gg = (int)Math.Sqrt(new_gx * new_gx + new_gy * new_gy);
                    int bb = (int)Math.Sqrt(new_bx * new_bx + new_by * new_by);


                    b.SetPixel(i, j, getColor(rr, gg, bb));

                }
            }

            return b;
        }

        private static Color getColor(int rr, int gg, int bb)
        {
            if (rr > 255 || gg > 255 || bb > 255)
                return Color.White;

            var aver = (rr + gg + bb) / 3;

            return Color.FromArgb(aver, aver, aver);
        }



    }
}

