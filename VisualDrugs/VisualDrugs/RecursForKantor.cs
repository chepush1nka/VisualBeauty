using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VisualDrugs
{
    public partial class RecursForKantor : Fractal
    {
        public RecursForKantor()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Метод считывает введенное пользователем значение и проверяет его.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonKantor_Click(object sender, EventArgs e)
        {
            string recNStr = RecN.Text;
            string LenStr = Len.Text;
            if ((int.TryParse(recNStr, out int recN)) && (int.TryParse(LenStr, out int LenInt)) && (recN > 0) && (recN < base.maxRecForKantor) && (LenInt > 60) && (LenInt < 110))
            {
                this.Close();
                Kantor kantor = new Kantor();
                kantor.recN = recN;
                kantor.Len = LenInt;
                // Вызываем окно с фракталом.
                kantor.ShowDialog();
            }
            else
                // Ругаемся.
                MessageBox.Show("Число рекурсий целое число, большее нуля и меньшее 9, длина больше 60 и меньше 110, все пока, мне пора спать");
        }
    }
}
