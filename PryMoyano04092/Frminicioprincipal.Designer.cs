namespace PryMoyano04092
{
    partial class Frminicioprincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.verProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarProveedoresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btncerrar = new System.Windows.Forms.Button();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.cargarProveedoresToolStripMenuItem,
            this.verProveedoresToolStripMenuItem,
            this.toolStripMenuItem2,
            this.cargarProveedoresToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // verProveedoresToolStripMenuItem
            // 
            this.verProveedoresToolStripMenuItem.Name = "verProveedoresToolStripMenuItem";
            this.verProveedoresToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.verProveedoresToolStripMenuItem.Text = "Ver Proveedores";
            this.verProveedoresToolStripMenuItem.Click += new System.EventHandler(this.verProveedoresToolStripMenuItem_Click);
            // 
            // cargarProveedoresToolStripMenuItem
            // 
            this.cargarProveedoresToolStripMenuItem.Name = "cargarProveedoresToolStripMenuItem";
            this.cargarProveedoresToolStripMenuItem.Size = new System.Drawing.Size(22, 20);
            this.cargarProveedoresToolStripMenuItem.Text = "|";
            this.cargarProveedoresToolStripMenuItem.Click += new System.EventHandler(this.cargarProveedoresToolStripMenuItem_Click);
            // 
            // cargarProveedoresToolStripMenuItem1
            // 
            this.cargarProveedoresToolStripMenuItem1.Name = "cargarProveedoresToolStripMenuItem1";
            this.cargarProveedoresToolStripMenuItem1.Size = new System.Drawing.Size(122, 20);
            this.cargarProveedoresToolStripMenuItem1.Text = "Cargar Proveedores";
            this.cargarProveedoresToolStripMenuItem1.Click += new System.EventHandler(this.cargarProveedoresToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(123, 20);
            this.toolStripMenuItem1.Text = "PACÍFICO SEGUROS";
            // 
            // btncerrar
            // 
            this.btncerrar.BackColor = System.Drawing.Color.White;
            this.btncerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncerrar.Location = new System.Drawing.Point(705, 419);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(95, 30);
            this.btncerrar.TabIndex = 1;
            this.btncerrar.Text = "Cerrar";
            this.btncerrar.UseVisualStyleBackColor = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(22, 20);
            this.toolStripMenuItem2.Text = "|";
            // 
            // Frminicioprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PryMoyano04092.Properties.Resources.PACIFÍCO_SEGUROS__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frminicioprincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "¡BIENVENIDOS!";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem verProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarProveedoresToolStripMenuItem1;
        private System.Windows.Forms.Button btncerrar;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}