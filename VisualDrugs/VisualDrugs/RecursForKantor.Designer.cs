namespace VisualDrugs
{
    partial class RecursForKantor
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Len = new System.Windows.Forms.TextBox();
            this.RecN = new System.Windows.Forms.TextBox();
            this.buttonKantor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(0)))), ((int)(((byte)(104)))));
            this.panel1.Controls.Add(this.Len);
            this.panel1.Controls.Add(this.RecN);
            this.panel1.Controls.Add(this.buttonKantor);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 516);
            this.panel1.TabIndex = 0;
            // 
            // Len
            // 
            this.Len.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(185)))), ((int)(((byte)(241)))));
            this.Len.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Len.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(0)))), ((int)(((byte)(104)))));
            this.Len.Location = new System.Drawing.Point(233, 323);
            this.Len.Name = "Len";
            this.Len.Size = new System.Drawing.Size(185, 51);
            this.Len.TabIndex = 4;
            // 
            // RecN
            // 
            this.RecN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(185)))), ((int)(((byte)(241)))));
            this.RecN.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RecN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(0)))), ((int)(((byte)(104)))));
            this.RecN.Location = new System.Drawing.Point(233, 145);
            this.RecN.Name = "RecN";
            this.RecN.Size = new System.Drawing.Size(185, 51);
            this.RecN.TabIndex = 3;
            // 
            // buttonKantor
            // 
            this.buttonKantor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(185)))), ((int)(((byte)(241)))));
            this.buttonKantor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKantor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(0)))), ((int)(((byte)(104)))));
            this.buttonKantor.Location = new System.Drawing.Point(149, 428);
            this.buttonKantor.Name = "buttonKantor";
            this.buttonKantor.Size = new System.Drawing.Size(354, 54);
            this.buttonKantor.TabIndex = 2;
            this.buttonKantor.Text = "окей";
            this.buttonKantor.UseVisualStyleBackColor = false;
            this.buttonKantor.Click += new System.EventHandler(this.buttonKantor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(185)))), ((int)(((byte)(241)))));
            this.label2.Location = new System.Drawing.Point(54, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(586, 41);
            this.label2.TabIndex = 0;
            this.label2.Text = "Укажите расстояние между отрезками";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(185)))), ((int)(((byte)(241)))));
            this.label1.Location = new System.Drawing.Point(87, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(511, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Укажите глубину рекурсии";
            // 
            // RecursForKantor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 516);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(704, 563);
            this.Name = "RecursForKantor";
            this.Text = "Kantor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Len;
        private System.Windows.Forms.TextBox RecN;
        private System.Windows.Forms.Button buttonKantor;
    }
}