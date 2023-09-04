namespace PryMoyano04092
{
    partial class FrmLogo
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.prbPorcentaje = new System.Windows.Forms.ProgressBar();
            this.lblporcentaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // prbPorcentaje
            // 
            this.prbPorcentaje.Location = new System.Drawing.Point(13, 373);
            this.prbPorcentaje.Name = "prbPorcentaje";
            this.prbPorcentaje.Size = new System.Drawing.Size(47, 49);
            this.prbPorcentaje.TabIndex = 0;
            this.prbPorcentaje.Visible = false;
            // 
            // lblporcentaje
            // 
            this.lblporcentaje.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblporcentaje.Location = new System.Drawing.Point(401, 373);
            this.lblporcentaje.Name = "lblporcentaje";
            this.lblporcentaje.Size = new System.Drawing.Size(50, 49);
            this.lblporcentaje.TabIndex = 1;
            this.lblporcentaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmLogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblporcentaje);
            this.Controls.Add(this.prbPorcentaje);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eslogan";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ProgressBar prbPorcentaje;
        private System.Windows.Forms.Label lblporcentaje;
        private System.Windows.Forms.Timer timer1;
    }
}

