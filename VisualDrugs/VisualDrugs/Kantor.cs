using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VisualDrugs
{
    public partial class Kantor : Fractal
    {
        // В этих переменных храним введенное количество итераций и длину расстояния между отрезками.
        public int recN;
        public int Len;
        /// <summary>
        /// Инициализируем.
        /// </summary>
        public Kantor()
        {
            InitializeComponent();
        }
        // Создаем два объекта, один для отрисовки фигуры, другой для закрашивания ее частей.
        static Pen pen1 = new Pen(Color.MediumPurple, 42), pen2 = new Pen(Color.Plum, 42);
        static int iter;
        /// <summary>
        /// Переопределяем родительский класс для рисования.
        /// </summary>
        /// <param name="p1">первая точка</param>
        /// <param name="p2">вторая точка</param>
        /// <param name="p3">третья точка</param>
        /// <param name="N">номер рекурсии</param>
        public override void draw(PointF p1, PointF p2, PointF pq, int N, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            // На самой первой итерации рисуем один отрезок.
            if (N == recN)
            {
                graphics.DrawLine(pen1, p1, p2);
                draw(p1, p2, pq, N - 1, e);
            }
            // Если это не первая итерация, то мы делим отрезок выше на три части и стираем среднюю.
            else if (N>0)
            {
                p1.Y = p1.Y + Len;
                p2.Y = p2.Y + Len;
                graphics.DrawLine(pen1, p1, p2);
                var p3 = new PointF((2 * p1.X + p2.X) / 3, (2 * p1.Y + p2.Y) / 3);
                var p4 = new PointF((p1.X + 2 * p2.X) / 3, (p1.Y + 2 * p2.Y) / 3);
                graphics.DrawLine(pen1, p1, p3);
                graphics.DrawLine(pen1, p2, p4);
                graphics.DrawLine(pen2, p3, p4);
                // Вызываем метод для получившихся отрезков.
                draw(p1, p3,pq, N - 1, e);
                draw(p4, p2,pq, N - 1, e);
            }
        }
        /// <summary>
        /// Задаем начальные координаты для посторения квадрата.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DrawKantor_Paint(object sender, PaintEventArgs e)
        {
            iter = recN;
            float w = DrawKantor.Width;
            float h = DrawKantor.Height;
            draw(new PointF(-(float)(w / 1.5 + 3 * w / (5 * Math.Sqrt(3)))+w+50, h / 15),
                new PointF((float)(w / 1.5 + 3 * w / (5 * Math.Sqrt(3)))-15, h / 15), new PointF((float)(w / 1.5 + 3 * w / (5 * Math.Sqrt(3))) - 15, h / 15),
                iter, e);
        }
    }
}
