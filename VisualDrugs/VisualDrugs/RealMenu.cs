using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VisualDrugs
{
    /// <summary>
    /// При нажатии определенной кнопки открывается окно, относящееся к определенному фракталу.
    /// </summary>
    public partial class RealMenu : Form
    {
        public RealMenu()
        {
            InitializeComponent();
        }
        private void Tree_button_Click(object sender, EventArgs e)
        {
            RecursForTree numbStandartTree = new RecursForTree();
            numbStandartTree.ShowDialog();
        }
        private void Koh_button_Click(object sender, EventArgs e)
        {
            RecursForKoh recursDeepOnly = new RecursForKoh();
            recursDeepOnly.ShowDialog();
        }
        private void Serp_carpet_button_Click(object sender, EventArgs e)
        {
            RecursForCarpet recForCarpet = new RecursForCarpet();
            recForCarpet.ShowDialog();
        }
        private void SerpButton_Click(object sender, EventArgs e)
        {
            RecursForTriangle recursOnlForTr = new RecursForTriangle();
            recursOnlForTr.ShowDialog();
        }

        private void RealMenu_FormClosing(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Kantor_button_Click_1(object sender, EventArgs e)
        {
            RecursForKantor recAndLen = new RecursForKantor();
            recAndLen.ShowDialog();
        }

        private void Eye_button_Click(object sender, EventArgs e)
        {
            Unusual unusual = new Unusual();
            unusual.ShowDialog();
        }
    }
}
