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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
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
            this.prbPorcentaje.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.prbPorcentaje.Location = new System.Drawing.Point(13, 373);
            this.prbPorcentaje.Name = "prbPorcentaje";
            this.prbPorcentaje.Size = new System.Drawing.Size(47, 49);
            this.prbPorcentaje.TabIndex = 0;
            this.prbPorcentaje.Visible = false;
            this.prbPorcentaje.Click += new System.EventHandler(this.prbPorcentaje_Click);
            // 
            // lblporcentaje
            // 
            this.lblporcentaje.BackColor = System.Drawing.Color.Transparent;
            this.lblporcentaje.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblporcentaje.ForeColor = System.Drawing.Color.White;
            this.lblporcentaje.Location = new System.Drawing.Point(66, 362);
            this.lblporcentaje.Name = "lblporcentaje";
            this.lblporcentaje.Size = new System.Drawing.Size(50, 49);
            this.lblporcentaje.TabIndex = 1;
            this.lblporcentaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblporcentaje.Click += new System.EventHandler(this.lblporcentaje_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FrmLogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::PryMoyano04092.Properties.Resources.PACIFÍCO_SEGUROS;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblporcentaje);
            this.Controls.Add(this.prbPorcentaje);
            this.DoubleBuffered = true;
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
        private System.Windows.Forms.ImageList imageList1;
    }
}

