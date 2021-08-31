using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VisualDrugs
{
    public partial class Unusual : Fractal
    {
        public Unusual()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Комментарии излишни.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int eye))
            {
                if (eye > 0)
                {
                    if (eye < 500)
                    {

                    }
                    else
                        MessageBox.Show("Ахаха, да конечно, нет у тебя столько сил, успокойся)");
                }
                else
                    MessageBox.Show("Я конечно понимаю, у всех свои физические возможности, но не настолько же");
            }
            else
                MessageBox.Show("Ну хватит играться, введи целое число)");
        }
    }
}
