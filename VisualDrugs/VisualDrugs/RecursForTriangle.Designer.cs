﻿namespace VisualDrugs
{
    partial class RecursForTriangle
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
            this.RecN = new System.Windows.Forms.TextBox();
            this.buttonRecN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RecN
            // 
            this.RecN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(185)))), ((int)(((byte)(241)))));
            this.RecN.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RecN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(0)))), ((int)(((byte)(104)))));
            this.RecN.Location = new System.Drawing.Point(201, 216);
            this.RecN.Name = "RecN";
            this.RecN.Size = new System.Drawing.Size(190, 47);
            this.RecN.TabIndex = 3;
            // 
            // buttonRecN
            // 
            this.buttonRecN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(185)))), ((int)(((byte)(241)))));
            this.buttonRecN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRecN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(0)))), ((int)(((byte)(104)))));
            this.buttonRecN.Location = new System.Drawing.Point(110, 343);
            this.buttonRecN.Name = "buttonRecN";
            this.buttonRecN.Size = new System.Drawing.Size(354, 54);
            this.buttonRecN.TabIndex = 2;
            this.buttonRecN.Text = "окей";
            this.buttonRecN.UseVisualStyleBackColor = false;
            this.buttonRecN.Click += new System.EventHandler(this.buttonRecN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(185)))), ((int)(((byte)(241)))));
            this.label1.Location = new System.Drawing.Point(236, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "пожалуйста";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(185)))), ((int)(((byte)(241)))));
            this.label2.Location = new System.Drawing.Point(47, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(511, 50);
            this.label2.TabIndex = 0;
            this.label2.Text = "Укажите глубину рекурсии";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(0)))), ((int)(((byte)(104)))));
            this.panel1.Controls.Add(this.RecN);
            this.panel1.Controls.Add(this.buttonRecN);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(606, 450);
            this.panel1.TabIndex = 0;
            // 
            // RecursForTriangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 450);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(624, 497);
            this.Name = "RecursForTriangle";
            this.Text = "RecursOnlForTr";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox RecN;
        private System.Windows.Forms.Button buttonRecN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}