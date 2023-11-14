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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmclub));
            this.dgvgrillasocios = new System.Windows.Forms.DataGridView();
            this.lblestado1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.btnbuscarclub = new System.Windows.Forms.Button();
            this.btnbuscarapellido = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvgrillasocios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvgrillasocios
            // 
            this.dgvgrillasocios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvgrillasocios.Location = new System.Drawing.Point(12, 12);
            this.dgvgrillasocios.Name = "dgvgrillasocios";
            this.dgvgrillasocios.Size = new System.Drawing.Size(906, 277);
            this.dgvgrillasocios.TabIndex = 0;
            // 
            // lblestado1
            // 
            this.lblestado1.AutoSize = true;
            this.lblestado1.BackColor = System.Drawing.Color.Transparent;
            this.lblestado1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblestado1.Location = new System.Drawing.Point(9, 494);
            this.lblestado1.Name = "lblestado1";
            this.lblestado1.Size = new System.Drawing.Size(47, 15);
            this.lblestado1.TabIndex = 5;
            this.lblestado1.Text = "label1";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(406, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Buscar por ID :";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(406, 423);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Buscar por Apellido :";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(592, 342);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(113, 22);
            this.txtID.TabIndex = 8;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(592, 423);
            this.txtApellido.Multiline = true;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(113, 22);
            this.txtApellido.TabIndex = 9;
            // 
            // btnbuscarclub
            // 
            this.btnbuscarclub.BackColor = System.Drawing.Color.White;
            this.btnbuscarclub.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscarclub.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnbuscarclub.Location = new System.Drawing.Point(749, 331);
            this.btnbuscarclub.Name = "btnbuscarclub";
            this.btnbuscarclub.Size = new System.Drawing.Size(112, 33);
            this.btnbuscarclub.TabIndex = 10;
            this.btnbuscarclub.Text = "Buscar";
            this.btnbuscarclub.UseVisualStyleBackColor = false;
            this.btnbuscarclub.Click += new System.EventHandler(this.btnbuscarclub_Click);
            // 
            // btnbuscarapellido
            // 
            this.btnbuscarapellido.BackColor = System.Drawing.Color.White;
            this.btnbuscarapellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscarapellido.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnbuscarapellido.Location = new System.Drawing.Point(749, 413);
            this.btnbuscarapellido.Name = "btnbuscarapellido";
            this.btnbuscarapellido.Size = new System.Drawing.Size(112, 33);
            this.btnbuscarapellido.TabIndex = 11;
            this.btnbuscarapellido.Text = "Buscar";
            this.btnbuscarapellido.UseVisualStyleBackColor = false;
            this.btnbuscarapellido.Click += new System.EventHandler(this.btnbuscarapellido_Click);
            // 
            // Frmclub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PryMoyano04092.Properties.Resources.PACIFÍCO_SEGUROS__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(930, 516);
            this.Controls.Add(this.btnbuscarapellido);
            this.Controls.Add(this.btnbuscarclub);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblestado1);
            this.Controls.Add(this.dgvgrillasocios);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frmclub";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Socios Club";
            this.Load += new System.EventHandler(this.Frmclub_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvgrillasocios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvgrillasocios;
        private System.Windows.Forms.Label lblestado1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Button btnbuscarclub;
        private System.Windows.Forms.Button btnbuscarapellido;
    }
}