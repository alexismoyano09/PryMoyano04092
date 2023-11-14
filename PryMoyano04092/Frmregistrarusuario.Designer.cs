namespace PryMoyano04092
{
    partial class Frmregistrarusuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmregistrarusuario));
            this.btnregistrarse1 = new System.Windows.Forms.Button();
            this.txtusuario1 = new System.Windows.Forms.TextBox();
            this.txtcontraseña1 = new System.Windows.Forms.TextBox();
            this.CBmostrar = new System.Windows.Forms.CheckBox();
            this.txtperfil = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnregistrarse1
            // 
            this.btnregistrarse1.Location = new System.Drawing.Point(416, 325);
            this.btnregistrarse1.Name = "btnregistrarse1";
            this.btnregistrarse1.Size = new System.Drawing.Size(148, 29);
            this.btnregistrarse1.TabIndex = 4;
            this.btnregistrarse1.Text = "Registrarse";
            this.btnregistrarse1.UseVisualStyleBackColor = true;
            this.btnregistrarse1.Click += new System.EventHandler(this.btnregistrarse1_Click);
            // 
            // txtusuario1
            // 
            this.txtusuario1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusuario1.Location = new System.Drawing.Point(487, 123);
            this.txtusuario1.Multiline = true;
            this.txtusuario1.Name = "txtusuario1";
            this.txtusuario1.Size = new System.Drawing.Size(153, 28);
            this.txtusuario1.TabIndex = 5;
            this.txtusuario1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtcontraseña1
            // 
            this.txtcontraseña1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontraseña1.Location = new System.Drawing.Point(487, 185);
            this.txtcontraseña1.Multiline = true;
            this.txtcontraseña1.Name = "txtcontraseña1";
            this.txtcontraseña1.Size = new System.Drawing.Size(153, 28);
            this.txtcontraseña1.TabIndex = 6;
            this.txtcontraseña1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtcontraseña1.TextChanged += new System.EventHandler(this.txtcontraseña1_TextChanged);
            // 
            // CBmostrar
            // 
            this.CBmostrar.AutoSize = true;
            this.CBmostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBmostrar.Location = new System.Drawing.Point(487, 219);
            this.CBmostrar.Name = "CBmostrar";
            this.CBmostrar.Size = new System.Drawing.Size(107, 16);
            this.CBmostrar.TabIndex = 7;
            this.CBmostrar.Text = "Mostrar Contraseña";
            this.CBmostrar.UseVisualStyleBackColor = true;
            this.CBmostrar.CheckedChanged += new System.EventHandler(this.CBmostrar_CheckedChanged);
            // 
            // txtperfil
            // 
            this.txtperfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtperfil.Location = new System.Drawing.Point(487, 250);
            this.txtperfil.Multiline = true;
            this.txtperfil.Name = "txtperfil";
            this.txtperfil.Size = new System.Drawing.Size(153, 28);
            this.txtperfil.TabIndex = 8;
            this.txtperfil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Frmregistrarusuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackgroundImage = global::PryMoyano04092.Properties.Resources.PACIFÍCO_SEGUROS__1_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtperfil);
            this.Controls.Add(this.CBmostrar);
            this.Controls.Add(this.txtcontraseña1);
            this.Controls.Add(this.txtusuario1);
            this.Controls.Add(this.btnregistrarse1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frmregistrarusuario";
            this.Text = "Registrar Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnregistrarse1;
        private System.Windows.Forms.CheckBox CBmostrar;
        public System.Windows.Forms.TextBox txtusuario1;
        public System.Windows.Forms.TextBox txtcontraseña1;
        public System.Windows.Forms.TextBox txtperfil;
    }
}