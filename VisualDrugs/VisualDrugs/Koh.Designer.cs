namespace VisualDrugs
{
    partial class Koh
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
            this.printMe = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // printMe
            // 
            this.printMe.Location = new System.Drawing.Point(-2, 0);
            this.printMe.Name = "printMe";
            this.printMe.Size = new System.Drawing.Size(1247, 813);
            this.printMe.TabIndex = 2;
            this.printMe.Paint += new System.Windows.Forms.PaintEventHandler(this.printMe_Paint);
            // 
            // Koh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(1247, 808);
            this.Controls.Add(this.printMe);
            this.MinimumSize = new System.Drawing.Size(1265, 855);
            this.Name = "Koh";
            this.Text = "Koh";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel printMe;
    }
}