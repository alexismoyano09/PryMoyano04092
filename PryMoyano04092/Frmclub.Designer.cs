namespace PryMoyano04092
{
    partial class Frmclub
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
            this.dgvgrillasocios = new System.Windows.Forms.DataGridView();
            this.lblestado1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvgrillasocios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvgrillasocios
            // 
            this.dgvgrillasocios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvgrillasocios.Location = new System.Drawing.Point(12, 12);
            this.dgvgrillasocios.Name = "dgvgrillasocios";
            this.dgvgrillasocios.Size = new System.Drawing.Size(826, 277);
            this.dgvgrillasocios.TabIndex = 0;
            // 
            // lblestado1
            // 
            this.lblestado1.AutoSize = true;
            this.lblestado1.BackColor = System.Drawing.Color.Transparent;
            this.lblestado1.Location = new System.Drawing.Point(9, 494);
            this.lblestado1.Name = "lblestado1";
            this.lblestado1.Size = new System.Drawing.Size(35, 13);
            this.lblestado1.TabIndex = 5;
            this.lblestado1.Text = "label1";
            // 
            // Frmclub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 516);
            this.Controls.Add(this.lblestado1);
            this.Controls.Add(this.dgvgrillasocios);
            this.Name = "Frmclub";
            this.Text = "Frmclub";
            this.Load += new System.EventHandler(this.Frmclub_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvgrillasocios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvgrillasocios;
        private System.Windows.Forms.Label lblestado1;
    }
}