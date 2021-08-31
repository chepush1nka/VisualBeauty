namespace VisualDrugs
{
    partial class Kantor
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
            this.DrawKantor = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // DrawKantor
            // 
            this.DrawKantor.Location = new System.Drawing.Point(-1, 0);
            this.DrawKantor.Name = "DrawKantor";
            this.DrawKantor.Size = new System.Drawing.Size(1153, 910);
            this.DrawKantor.TabIndex = 1;
            this.DrawKantor.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawKantor_Paint);
            // 
            // Kantor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(1198, 910);
            this.Controls.Add(this.DrawKantor);
            this.MinimumSize = new System.Drawing.Size(1216, 957);
            this.Name = "Kantor";
            this.Text = "Kantor";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel DrawKantor;
    }
}