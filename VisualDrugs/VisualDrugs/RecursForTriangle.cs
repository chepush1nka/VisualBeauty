using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VisualDrugs
{
    public partial class RecursForTriangle : Fractal
    {
        public RecursForTriangle()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Метод считывает введенное пользователем значение и проверяет его.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRecN_Click(object sender, EventArgs e)
        {
            string recNStr = RecN.Text;
            if (int.TryParse(recNStr, out int recN)&&(recN>0) &&(recN<=base.maxRecForTriangle))
            {
                this.Close();
                Triangle triangle = new Triangle();
                triangle.recN = recN;
                triangle.ShowDialog();
            }
            else
                MessageBox.Show("Число рекурсий целое число, большее нуля и меньшее 10, все пока, мне пора кушать");
        }
    }
}
