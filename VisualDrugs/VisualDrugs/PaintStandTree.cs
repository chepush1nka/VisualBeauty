using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VisualDrugs
{
    public partial class PaintStandTree : Fractal
    {
        public int N;
        public int TurnX;
        public int TurnY;
        public double k;
        public PaintStandTree()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Создаем метод для рисования фрактала.
        /// </summary>
        /// <param name="x">координата х</param>
        /// <param name="y">координата у</param>
        /// <param name="len">длина отрезка</param>
        /// <param name="angle">величина угла</param>
        /// <param name="e"></param>
        public void draw(int x, int y, int len, double angle, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            double x1, y1;
            // Коэфициент k положителен, если координата х больше у.
            if (k > 0)
            {
                x1 = x + len * Math.Sin(angle * Math.PI * 2 / 360.0);
                y1 = y + len *k* Math.Cos(angle * Math.PI * 2 / 360.0);
                graphics.DrawLine(new Pen(Color.MediumPurple), x, TreePaintStnd.Height - y, (int)x1, TreePaintStnd.Height - (int)y1);
                if (len > 300 / (Math.Pow(1.5, N)))
                {
                    // Вызываем метод для получившихся ветвей.
                    draw((int)x1, (int)y1, (int)(len / 1.5), angle + TurnX, e);
                    draw((int)x1, (int)y1, (int)(len / 1.5), angle - TurnY, e);
                }
            }
            // Коэфициент k не положителен, если координата х не больше у.
            else
            {
                x1 = x + len *(-k)* Math.Sin(angle * Math.PI * 2 / 360.0);
                y1 = y + len * Math.Cos(angle * Math.PI * 2 / 360.0);
                graphics.DrawLine(new Pen(Color.MediumPurple), x, TreePaintStnd.Height - y, (int)x1, TreePaintStnd.Height - (int)y1);
                if (len > 300 / (Math.Pow(1.5, N)))
                {
                    // Вызываем метод для получившихся ветвей.
                    draw((int)x1, (int)y1, (int)(len / 1.5), angle + TurnX, e);
                    draw((int)x1, (int)y1, (int)(len / 1.5), angle - TurnY, e);
                }
            }
        }
        /// <summary>
        /// Вызываем метод для отрисовки, указав начальные координаты.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TreePaintStnd_Paint(object sender, PaintEventArgs e)
        {
            draw(TreePaintStnd.Width/2, 0 , 300, 0, e);
        }
    }
}
