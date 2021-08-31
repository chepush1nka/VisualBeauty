using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VisualDrugs
{
    public partial class Koh : Fractal
    {
        // Тут будем хранить введенное количество рекурсий.
        public int recN;
        /// <summary>
        /// Инициализируем.
        /// </summary>
        public Koh()
        {
            InitializeComponent();
        }
        // Создаем два объекта, один для отрисовки фигуры, другой для закрашивания ее частей.
        static Pen pen1= new Pen(Color.MediumPurple, 3), pen2= new Pen(Color.Plum, 3);
        // Тут будем хранить номер текущей итерации.
        static int iter;
        /// <summary>
        /// Задаем начальные координаты для посторения квадрата.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printMe_Paint(object sender, PaintEventArgs e)
        {
            iter = recN;
            float w = printMe.Width;
            float h = printMe.Height;
            draw(new PointF((float)(w / 2 - 3 * w / (5 * Math.Sqrt(3))), 4 * h / 5),
                new PointF((float)(w / 2 + 3 * w / (5 * Math.Sqrt(3))), 4 * h / 5), new PointF((float)(w / 2), 8*h / 5),
                iter, e);
        }
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
            if (N == recN)
            {
                graphics.DrawLine(pen1, p1, p2);
                draw(p1, p2, p3, N-1, e);
            }
            else if (N>0)
            {
                var p4 = new PointF((2*p1.X+p2.X)/3, (2 * p1.Y + p2.Y) / 3);
                var p5 = new PointF((p1.X + 2 * p2.X) / 3, (p1.Y + 2 * p2.Y) / 3);
                var ps = new PointF((p1.X + p2.X) / 2, (p1.Y + p2.Y) / 2);
                var pn = new PointF((4*ps.X-p3.X)/3,(4 * ps.Y -p3.Y) / 3);
                graphics.DrawLine(pen1, p4, pn);
                graphics.DrawLine(pen1, p5, pn);
                graphics.DrawLine(pen2, p4, p5);
                // Вызываем метод для четырех отрезков.
                draw(p4,pn,p5,N-1, e);
                draw(pn, p5, p4, N - 1, e);
                draw(p1,p4,new PointF((2*p1.X+p3.X)/3,(2 * p1.Y + p3.Y) / 3), N-1, e);
                draw(p5, p2, new PointF((2 * p2.X + p3.X) / 3, (2 * p2.Y + p3.Y) / 3), N - 1, e);
            }
        }
    }
}
