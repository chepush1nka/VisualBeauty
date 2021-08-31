namespace VisualDrugs
{
    partial class PaintStandTree
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
            this.TreePaintStnd = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // TreePaintStnd
            // 
            this.TreePaintStnd.Location = new System.Drawing.Point(0, 0);
            this.TreePaintStnd.Name = "TreePaintStnd";
            this.TreePaintStnd.Size = new System.Drawing.Size(1277, 914);
            this.TreePaintStnd.TabIndex = 0;
            this.TreePaintStnd.Paint += new System.Windows.Forms.PaintEventHandler(this.TreePaintStnd_Paint);
            // 
            // PaintStandTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(0)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(1277, 914);
            this.Controls.Add(this.TreePaintStnd);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(185)))), ((int)(((byte)(241)))));
            this.MinimumSize = new System.Drawing.Size(1295, 961);
            this.Name = "PaintStandTree";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TreePaintStnd;
    }
}