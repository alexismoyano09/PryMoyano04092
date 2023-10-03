namespace PryMoyano04092
{
    partial class frmdatosgrilla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmdatosgrilla));
            this.DtgGrillaMostrar = new System.Windows.Forms.DataGridView();
            this.Nº = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APERTURA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JUZG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JURISD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIRECCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DtgGrillaMostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // DtgGrillaMostrar
            // 
            this.DtgGrillaMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgGrillaMostrar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nº,
            this.Entidad,
            this.APERTURA,
            this.Column4,
            this.JUZG,
            this.JURISD,
            this.DIRECCION,
            this.LR});
            this.DtgGrillaMostrar.Location = new System.Drawing.Point(12, 12);
            this.DtgGrillaMostrar.Name = "DtgGrillaMostrar";
            this.DtgGrillaMostrar.Size = new System.Drawing.Size(853, 426);
            this.DtgGrillaMostrar.TabIndex = 5;
            // 
            // Nº
            // 
            this.Nº.HeaderText = "Nº";
            this.Nº.Name = "Nº";
            // 
            // Entidad
            // 
            this.Entidad.HeaderText = "Entidad";
            this.Entidad.Name = "Entidad";
            // 
            // APERTURA
            // 
            this.APERTURA.HeaderText = "APERTURA";
            this.APERTURA.Name = "APERTURA";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Nº EXPTE.";
            this.Column4.Name = "Column4";
            // 
            // JUZG
            // 
            this.JUZG.HeaderText = "JUZG.";
            this.JUZG.Name = "JUZG";
            // 
            // JURISD
            // 
            this.JURISD.HeaderText = "JURISD";
            this.JURISD.Name = "JURISD";
            // 
            // DIRECCION
            // 
            this.DIRECCION.HeaderText = "DIRECCION";
            this.DIRECCION.Name = "DIRECCION";
            // 
            // LR
            // 
            this.LR.HeaderText = "LIQUIDADOR RESPONSABLE";
            this.LR.Name = "LR";
            // 
            // frmdatosgrilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PryMoyano04092.Properties.Resources.PACIFÍCO_SEGUROS__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(871, 450);
            this.Controls.Add(this.DtgGrillaMostrar);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmdatosgrilla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proveedores";
            ((System.ComponentModel.ISupportInitialize)(this.DtgGrillaMostrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn Nº;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn APERTURA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn JUZG;
        private System.Windows.Forms.DataGridViewTextBoxColumn JURISD;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIRECCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn LR;
        public System.Windows.Forms.DataGridView DtgGrillaMostrar;
    }
}