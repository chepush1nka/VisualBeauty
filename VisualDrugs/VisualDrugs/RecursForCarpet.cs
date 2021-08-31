using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VisualDrugs
{
    public partial class RecursForCarpet : Fractal
    {
        public RecursForCarpet()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Метод считывает введенное пользователем значение и проверяет его.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RecursButtom_Click(object sender, EventArgs e)
        {
            string recNStr = RecN.Text;
            if (int.TryParse(recNStr, out int recNInt)&&(recNInt>0)&&(recNInt<=base.maxRecForCarpet))
            {
                this.Close();
                Carpet carpet = new Carpet();
                carpet.recN = recNInt;
                // Вызываем окно с фракталом.
                carpet.ShowDialog();
            }
            else
                // Ругаемся.
                MessageBox.Show("Число рекурсий целое число, большее нуля и меньшее 8, все пока, мне надо мерить шапку");
        }
    }
}
