﻿namespace PryMoyano04092
{
    partial class FrmInicio
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
            this.fbdcarpetas = new System.Windows.Forms.FolderBrowserDialog();
            this.btnmostrar = new System.Windows.Forms.Button();
            this.lbldireccioncarpeta = new System.Windows.Forms.Label();
            this.txtMostrar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnmostrar
            // 
            this.btnmostrar.Location = new System.Drawing.Point(12, 47);
            this.btnmostrar.Name = "btnmostrar";
            this.btnmostrar.Size = new System.Drawing.Size(118, 33);
            this.btnmostrar.TabIndex = 0;
            this.btnmostrar.Text = "BUSCAR";
            this.btnmostrar.UseVisualStyleBackColor = true;
            this.btnmostrar.Click += new System.EventHandler(this.btnmostrar_Click);
            // 
            // lbldireccioncarpeta
            // 
            this.lbldireccioncarpeta.Location = new System.Drawing.Point(13, 87);
            this.lbldireccioncarpeta.Name = "lbldireccioncarpeta";
            this.lbldireccioncarpeta.Size = new System.Drawing.Size(117, 23);
            this.lbldireccioncarpeta.TabIndex = 1;
            // 
            // txtMostrar
            // 
            this.txtMostrar.Location = new System.Drawing.Point(374, 47);
            this.txtMostrar.Multiline = true;
            this.txtMostrar.Name = "txtMostrar";
            this.txtMostrar.Size = new System.Drawing.Size(271, 273);
            this.txtMostrar.TabIndex = 2;
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(686, 427);
            this.Controls.Add(this.txtMostrar);
            this.Controls.Add(this.lbldireccioncarpeta);
            this.Controls.Add(this.btnmostrar);
            this.Name = "FrmInicio";
            this.Text = "FrmInicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog fbdcarpetas;
        private System.Windows.Forms.Button btnmostrar;
        private System.Windows.Forms.Label lbldireccioncarpeta;
        private System.Windows.Forms.TextBox txtMostrar;
    }
}