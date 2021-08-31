using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VisualDrugs
{
    public partial class RecursForKoh : Fractal
    {
        public RecursForKoh()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Метод считывает введенное пользователем значение и проверяет его.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void buttonKoh_Click(object sender, EventArgs e)
        {
            string recNStr = textRecN.Text;
            if (int.TryParse(recNStr, out int recN) && (recN > 0) && (recN <= base.maxRecForKoh))
            {
                this.Close();
                Koh koh = new Koh();
                koh.recN = recN;
                // Вызываем окно с фракталом.
                koh.ShowDialog();
            }
            else
                // Ругаемся.
                MessageBox.Show("Число рекурсий целое число, большее нуля и меньшее 8, все пока, мне нужно мерить кросовки");
        }
    }
}
