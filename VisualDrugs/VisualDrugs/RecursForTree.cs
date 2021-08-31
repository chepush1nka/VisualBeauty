using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VisualDrugs
{
    public partial class RecursForTree : Fractal
    {
        public RecursForTree()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Метод считывает введенные пользователем значения и проверяет их.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void buttonOfNumb_Click(object sender, EventArgs e)
        {
            string recursNumbStr = RecursNumb.Text;
            string firstTurnStr = FirstTurn.Text;
            string secondTurnStr = SecondTurn.Text;
            string xStr = X.Text;
            string yStr = Y.Text;
            int sgn;
            // Проверочка.
            if ((int.TryParse(recursNumbStr, out int recursNumb)) && (recursNumb > 0)&&(recursNumb<base.maxRecForTree)) { 
                if ((int.TryParse(firstTurnStr, out int firstTurn)) && (int.TryParse(secondTurnStr, out int secondTurn))
                    && (firstTurn > 20) && (firstTurn < 100) && (secondTurn > 20) && (secondTurn < 100)) {
                    if ((double.TryParse(xStr, out double x)) && (x > 0) && (double.TryParse(yStr, out double y)) && (y > 0)
                        &&((double)Math.Min(x, y) / Math.Max(x, y)>(double)1/3)) {
                        if (x > y)
                            sgn = 1;
                        else
                            sgn = -1;
                        this.Close();
                        PaintStandTree paintStandTree = new PaintStandTree();
                        paintStandTree.N = recursNumb;
                        paintStandTree.TurnX = firstTurn;
                        paintStandTree.TurnY = secondTurn;
                        paintStandTree.k = sgn*(double)Math.Min(x,y) / Math.Max(x, y);
                        paintStandTree.ShowDialog();
                    }
                    else
                        MessageBox.Show("У тебя проблемы в отношениях( отношение не должно быть меньше 1/3");
                }
                else
                    MessageBox.Show("Углы должны быть целыми, большими 20 и меньшими 100");
            }
            else
                MessageBox.Show("Число рекурсий целое число, большее 0 и меньшее 15, все пока, мне нужно мерить шорты");
        }
    }
}
