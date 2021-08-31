namespace VisualDrugs
{
    partial class Triangle
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
            this.printTriangle = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // printTriangle
            // 
            this.printTriangle.BackColor = System.Drawing.Color.Plum;
            this.printTriangle.Location = new System.Drawing.Point(0, 0);
            this.printTriangle.Name = "printTriangle";
            this.printTriangle.Size = new System.Drawing.Size(976, 752);
            this.printTriangle.TabIndex = 0;
            this.printTriangle.Paint += new System.Windows.Forms.PaintEventHandler(this.printTriangle_Paint);
            // 
            // Triangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(978, 752);
            this.Controls.Add(this.printTriangle);
            this.MinimumSize = new System.Drawing.Size(996, 799);
            this.Name = "Triangle";
            this.Text = "Triangle";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel printTriangle;
    }
}