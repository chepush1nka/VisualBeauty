namespace VisualDrugs
{
    partial class Carpet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.printCarpet = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // printCarpet
            // 
            this.printCarpet.BackColor = System.Drawing.Color.Plum;
            this.printCarpet.Location = new System.Drawing.Point(0, 0);
            this.printCarpet.Name = "printCarpet";
            this.printCarpet.Size = new System.Drawing.Size(1203, 884);
            this.printCarpet.TabIndex = 0;
            this.printCarpet.Paint += new System.Windows.Forms.PaintEventHandler(this.printCarpet_Paint);
            // 
            // Carpet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(1203, 884);
            this.Controls.Add(this.printCarpet);
            this.MinimumSize = new System.Drawing.Size(1221, 931);
            this.Name = "Carpet";
            this.Text = "Carpet";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel printCarpet;
    }
}