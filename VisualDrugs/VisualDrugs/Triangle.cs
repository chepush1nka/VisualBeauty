using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VisualDrugs
{
    public partial class Triangle : Fractal
    {
        // Тут будем хранить введенное количество рекурсий.
        public int recN;
        /// <summary>
        /// Инициализируем.
        /// </summary>
        public Triangle()
        {
            InitializeComponent();
        }
        // Создаем объект для рисования и переменную, хранящюю номер текущей итерации.
        static Pen pen1 = new Pen(Color.MediumPurple, 1);
        static int iter;
        /// <summary>
        /// Переопределяем родительский класс для рисования.
        /// </summary>
        /// <param name="p1">первая точка</param>
        /// <param name="p2">вторая точка</param>
        /// <param name="p3">третья точка</param>
        /// <param name="N">номер рекурсии</param>
        public override void draw(PointF p1, PointF p2, PointF p3, int N, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            // На самой первой итерации рисуем один треугольник.
            if (N == recN)
            {
                graphics.DrawLine(pen1, p1, p2);
                graphics.DrawLine(pen1, p3, p2);
                graphics.DrawLine(pen1, p1, p3);
                draw(p1, p2, p3, N - 1, e);
            }
            // Если это не первая итерация, то сначала рисуем треугольник по переданным координатам, а потом вызываем метод для еще трех треугольников.
            else if (N > 0)
            {
                var p4 = new PointF((float)(p3.X-p1.X) / 2+p1.X, p3.Y + (float)(p1.Y-p3.Y)/2);
                var p5 = new PointF(-(float)(p2.X - p3.X) / 2 + p2.X, p3.Y + (float)(p2.Y - p3.Y) / 2);
                var p6 = new PointF((float)(p2.X - p1.X) / 2 + p1.X, p1.Y);
                graphics.DrawLine(pen1, p4, p5);
                graphics.DrawLine(pen1, p5, p6);
                graphics.DrawLine(pen1, p4, p6);
                draw(p1, p6, p4, N - 1, e);
                draw(p6, p2, p5, N - 1, e);
                draw(p4, p5,p3 , N - 1, e);
            }
        }
        /// <summary>
        /// Задаем начальные координаты для посторения квадрата.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printTriangle_Paint(object sender, PaintEventArgs e)
        {
            iter = recN;
            float w = printTriangle.Width;
            float h = printTriangle.Height;
            draw(new PointF((float)(w / 2 - 3 * w / (5 * Math.Sqrt(3))), 9 * h / 10),
                new PointF((float)(w / 2 + 3 * w / (5 * Math.Sqrt(3))), 9 * h / 10), new PointF((float)(w / 2),  h / 10),
                iter, e);
        }
    }
}
