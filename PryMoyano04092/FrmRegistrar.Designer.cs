namespace PryMoyano04092
{
    partial class FrmRegistrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistrar));
            this.gbregistro = new System.Windows.Forms.GroupBox();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btngrabar = new System.Windows.Forms.Button();
            this.txtLresponsable = new System.Windows.Forms.TextBox();
            this.txtjurisdiccion = new System.Windows.Forms.TextBox();
            this.txtNdeexpendiente = new System.Windows.Forms.TextBox();
            this.txtentidad = new System.Windows.Forms.TextBox();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.txtjuzgado = new System.Windows.Forms.TextBox();
            this.txtapertura = new System.Windows.Forms.TextBox();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.btnvolver = new System.Windows.Forms.Button();
            this.gbregistro.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbregistro
            // 
            this.gbregistro.BackgroundImage = global::PryMoyano04092.Properties.Resources.groupbox2;
            this.gbregistro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbregistro.Controls.Add(this.btnvolver);
            this.gbregistro.Controls.Add(this.btnmodificar);
            this.gbregistro.Controls.Add(this.btngrabar);
            this.gbregistro.Controls.Add(this.txtLresponsable);
            this.gbregistro.Controls.Add(this.txtjurisdiccion);
            this.gbregistro.Controls.Add(this.txtNdeexpendiente);
            this.gbregistro.Controls.Add(this.txtentidad);
            this.gbregistro.Controls.Add(this.txtdireccion);
            this.gbregistro.Controls.Add(this.txtjuzgado);
            this.gbregistro.Controls.Add(this.txtapertura);
            this.gbregistro.Controls.Add(this.txtnumero);
            this.gbregistro.Location = new System.Drawing.Point(12, 12);
            this.gbregistro.Name = "gbregistro";
            this.gbregistro.Size = new System.Drawing.Size(776, 426);
            this.gbregistro.TabIndex = 0;
            this.gbregistro.TabStop = false;
            // 
            // btnmodificar
            // 
            this.btnmodificar.BackColor = System.Drawing.Color.Lavender;
            this.btnmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnmodificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodificar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnmodificar.Location = new System.Drawing.Point(645, 360);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(109, 36);
            this.btnmodificar.TabIndex = 9;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = false;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btngrabar
            // 
            this.btngrabar.BackColor = System.Drawing.Color.Lavender;
            this.btngrabar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btngrabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngrabar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btngrabar.Location = new System.Drawing.Point(457, 360);
            this.btngrabar.Name = "btngrabar";
            this.btngrabar.Size = new System.Drawing.Size(109, 36);
            this.btngrabar.TabIndex = 8;
            this.btngrabar.Text = "Grabar";
            this.btngrabar.UseVisualStyleBackColor = false;
            this.btngrabar.Click += new System.EventHandler(this.btngrabar_Click);
            // 
            // txtLresponsable
            // 
            this.txtLresponsable.Location = new System.Drawing.Point(584, 296);
            this.txtLresponsable.Multiline = true;
            this.txtLresponsable.Name = "txtLresponsable";
            this.txtLresponsable.Size = new System.Drawing.Size(170, 22);
            this.txtLresponsable.TabIndex = 7;
            // 
            // txtjurisdiccion
            // 
            this.txtjurisdiccion.Location = new System.Drawing.Point(457, 217);
            this.txtjurisdiccion.Multiline = true;
            this.txtjurisdiccion.Name = "txtjurisdiccion";
            this.txtjurisdiccion.Size = new System.Drawing.Size(170, 22);
            this.txtjurisdiccion.TabIndex = 6;
            // 
            // txtNdeexpendiente
            // 
            this.txtNdeexpendiente.Location = new System.Drawing.Point(519, 143);
            this.txtNdeexpendiente.Multiline = true;
            this.txtNdeexpendiente.Name = "txtNdeexpendiente";
            this.txtNdeexpendiente.Size = new System.Drawing.Size(170, 22);
            this.txtNdeexpendiente.TabIndex = 5;
            // 
            // txtentidad
            // 
            this.txtentidad.Location = new System.Drawing.Point(457, 67);
            this.txtentidad.Multiline = true;
            this.txtentidad.Name = "txtentidad";
            this.txtentidad.Size = new System.Drawing.Size(170, 22);
            this.txtentidad.TabIndex = 4;
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(137, 296);
            this.txtdireccion.Multiline = true;
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(170, 22);
            this.txtdireccion.TabIndex = 3;
            // 
            // txtjuzgado
            // 
            this.txtjuzgado.Location = new System.Drawing.Point(137, 217);
            this.txtjuzgado.Multiline = true;
            this.txtjuzgado.Name = "txtjuzgado";
            this.txtjuzgado.Size = new System.Drawing.Size(170, 22);
            this.txtjuzgado.TabIndex = 2;
            // 
            // txtapertura
            // 
            this.txtapertura.Location = new System.Drawing.Point(137, 143);
            this.txtapertura.Multiline = true;
            this.txtapertura.Name = "txtapertura";
            this.txtapertura.Size = new System.Drawing.Size(170, 22);
            this.txtapertura.TabIndex = 1;
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(98, 67);
            this.txtnumero.Multiline = true;
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(170, 22);
            this.txtnumero.TabIndex = 0;
            // 
            // btnvolver
            // 
            this.btnvolver.BackColor = System.Drawing.Color.Lavender;
            this.btnvolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnvolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvolver.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnvolver.Location = new System.Drawing.Point(6, 360);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(109, 36);
            this.btnvolver.TabIndex = 10;
            this.btnvolver.Text = "volver";
            this.btnvolver.UseVisualStyleBackColor = false;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // FrmRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(798, 445);
            this.Controls.Add(this.gbregistro);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRegistrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registra un nuevo Proveedor";
            this.gbregistro.ResumeLayout(false);
            this.gbregistro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbregistro;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btngrabar;
        public System.Windows.Forms.TextBox txtnumero;
        public System.Windows.Forms.TextBox txtLresponsable;
        public System.Windows.Forms.TextBox txtjurisdiccion;
        public System.Windows.Forms.TextBox txtNdeexpendiente;
        public System.Windows.Forms.TextBox txtentidad;
        public System.Windows.Forms.TextBox txtdireccion;
        public System.Windows.Forms.TextBox txtjuzgado;
        public System.Windows.Forms.TextBox txtapertura;
        private System.Windows.Forms.Button btnvolver;
    }
}