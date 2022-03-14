using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LineasDeBresenham.MathClass
{
    internal class LineasBresenham {

        private static Graphics graphics;
        private static SolidBrush brushBlack = new SolidBrush(Color.Black);
        private static SolidBrush brushRed = new SolidBrush(Color.Red);

        public static void LinearBresenham(int X1, int Y1, int X2, int Y2, Panel panel) {

            int x = panel.Width / 2;
            int y = panel.Height / 2;

            graphics = panel.CreateGraphics();
            graphics.TranslateTransform(x, y);

        }
        
        public static void bresenham(int x1, int y1, int x2, int y2, Panel panel) {

            int slope;
            int dx, dy, incE, incNE, d, x, y;

            if (x1 > x2) {
                bresenham(x2, y2, x1, y1, panel);
                return;
            }

            dx = x2 - x1;
            dy = y2 - y1;

            if (dy < 0) {
                slope = -1;
                dy = -dy;
            } else{
                slope = 1;
            }

            incE = 2 * dy;
            incNE = 2 * dy - 2*dx;
            d = 2 * dy - dx;
            y = y1;
            int cont = 0;

            for (x = x1; x <= x2; x++) {
                paintBlock(x, y, brushRed);
                if (d <= 0) {
                    d += incE;
                } else {
                    d += incNE;
                    y += slope;
                }
                cont += 20;
            }

        }


        private static void paintBlock(int x, int y, SolidBrush brush) {
            
            MessageBox.Show("X: " + x + " - Y: " + y);
            Rectangle recangle = new Rectangle(x, y, 5, 5);
            
            graphics.FillRectangle(brush, recangle);

        }

        public static void plano(Panel panel)
        {

            Pen pen = new Pen(Color.Black);

            int x = panel.Width / 2;
            int y = panel.Height / 2;

            graphics = panel.CreateGraphics();
            graphics.TranslateTransform(x,y);
            graphics.ScaleTransform(1, -1);

            graphics.DrawLine(pen, x * -1, 0, x*1, 0);

            graphics.DrawLine(pen, 0, y * -1, 0, y*1);

        }
    }
}
