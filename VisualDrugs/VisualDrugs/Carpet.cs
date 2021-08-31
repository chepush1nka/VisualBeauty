using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VisualDrugs
{
    public partial class Carpet : Fractal
    {
        // Тут будем хранить введенное количество рекурсий.
        public int recN;
        /// <summary>
        /// Инициализируем.
        /// </summary>
        public Carpet()
        {
            InitializeComponent();
        }
        // Текущая итерация.
        static int iter;
        // Этим будем закрашивать квадраты.
        static SolidBrush purpBrush = new SolidBrush(Color.MediumPurple);
        static SolidBrush plumBrush = new SolidBrush(Color.Plum);
        /// <summary>
        /// Переопределяем родительский класс для рисования.
        /// </summary>
        /// <param name="p1">первая точка</param>
        /// <param name="p2">вторая точка</param>
        /// <param name="p3">третья точка</param>
        /// <param name="N">номер рекурсии</param>
        public override void draw(PointF p1, PointF pX, PointF pY, int N, PaintEventArgs e)
        {
            // На самой первой итерации рисуем основной квадрат.
            if (N == recN)
            {
                e.Graphics.FillRectangle(purpBrush, p1.X, p1.Y, pX.X, pY.Y);
                draw(p1, pX, pY, N - 1, e);
            }
            // Если это не первая итерация, то заливаем квадрат цвета фона в середину основного квадрата и вызываем метод для восьми квадратов рядом.
            else if (N>0)
            {
                e.Graphics.FillRectangle(plumBrush, (float)pX.X / 3 + p1.X,
                    (float)pY.Y / 3 + p1.Y,
                    (float)pX.X / 3 ,
                    (float)pY.Y /3);
                draw(p1, new PointF((float)pX.X / 3, 1), new PointF(1, (float)pX.X / 3), N - 1, e);
                draw(new PointF(p1.X+(float)pX.X / 3, p1.Y), new PointF((float)pX.X / 3, 1), new PointF(1, (float)pY.Y / 3), N - 1, e);
                draw(new PointF(p1.X + (float)(2*pX.X) / 3, p1.Y), new PointF((float)pX.X / 3, 1), new PointF(1, (float)pY.Y / 3), N - 1, e);
                draw(new PointF(p1.X, p1.Y+ (float)pY.Y / 3), new PointF((float)pX.X / 3, 1), new PointF(1, (float)pY.Y / 3), N - 1, e);
                draw(new PointF(p1.X, p1.Y + (float)(2*pY.Y) / 3), new PointF((float)pX.X / 3, 1), new PointF(1, (float)pY.Y / 3), N - 1, e);
                draw(new PointF(p1.X+(float)pX.X / 3, p1.Y + (float)(2 * pY.Y) / 3), new PointF((float)pX.X / 3, 1), new PointF(1, (float)pY.Y / 3), N - 1, e);
                draw(new PointF(p1.X + (float)(2 * pX.X) / 3, p1.Y + (float)(2 * pY.Y) / 3), new PointF((float)pX.X / 3, 1), new PointF(1, (float)pY.Y / 3), N - 1, e);
                draw(new PointF(p1.X + (float)(2 * pX.X) / 3, p1.Y + (float)pY.Y / 3), new PointF((float)pX.X / 3, 1), new PointF(1, (float)pY.Y / 3), N - 1, e);
            }
        }
        /// <summary>
        /// Задаем начальные координаты для посторения квадрата.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printCarpet_Paint(object sender, PaintEventArgs e)
        {
            iter = recN;
            float w = printCarpet.Width;
            draw(new PointF((float)w / 5-100 , (float)w / 5-150),
                new PointF(700, 700),
                new PointF(700, 700),
                iter, e);
        }
    }
}
