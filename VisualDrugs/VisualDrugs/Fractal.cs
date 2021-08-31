using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace VisualDrugs
{
    public class Fractal : Form
    {
        // Все максимальные значения рекурсий для каждого фрактала.
        public int maxRecForTree = 15;
        public int maxRecForKoh = 7;
        public int maxRecForCarpet = 7;
        public int maxRecForTriangle = 9;
        public int maxRecForKantor = 9;
        /// <summary>
        /// Основной метод отрисовки фрактала, который будет переопределен в классе с фракталом.
        /// </summary>
        /// <param name="p1">первая точка</param>
        /// <param name="p2">вторая точка</param>
        /// <param name="p3">третья точка</param>
        /// <param name="N">номер рекурсии</param>
        public virtual void draw(PointF p1, PointF p2, PointF p3, int N, PaintEventArgs e)
        {

        }
    }
}
