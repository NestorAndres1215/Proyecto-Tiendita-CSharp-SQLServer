namespace Prototipo
{
    partial class FRM_MENU_ADMIN
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
            this.informaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informaciónDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informaciónDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informaciónToolStripMenuItem,
            this.registroToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // informaciónToolStripMenuItem
            // 
            this.informaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informaciónDeVentasToolStripMenuItem,
            this.informaciónDeProductosToolStripMenuItem});
            this.informaciónToolStripMenuItem.Name = "informaciónToolStripMenuItem";
            this.informaciónToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.informaciónToolStripMenuItem.Text = "Información";
            // 
            // informaciónDeVentasToolStripMenuItem
            // 
            this.informaciónDeVentasToolStripMenuItem.Name = "informaciónDeVentasToolStripMenuItem";
            this.informaciónDeVentasToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.informaciónDeVentasToolStripMenuItem.Text = "Información de ventas";
            this.informaciónDeVentasToolStripMenuItem.Click += new System.EventHandler(this.informaciónDeVentasToolStripMenuItem_Click);
            // 
            // informaciónDeProductosToolStripMenuItem
            // 
            this.informaciónDeProductosToolStripMenuItem.Name = "informaciónDeProductosToolStripMenuItem";
            this.informaciónDeProductosToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.informaciónDeProductosToolStripMenuItem.Text = "Información de Productos";
            this.informaciónDeProductosToolStripMenuItem.Click += new System.EventHandler(this.informaciónDeProductosToolStripMenuItem_Click);
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empleadoToolStripMenuItem,
            this.productoToolStripMenuItem});
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.registroToolStripMenuItem.Text = "Registrar/Eliminar";
            this.registroToolStripMenuItem.Click += new System.EventHandler(this.registroToolStripMenuItem_Click);
            // 
            // empleadoToolStripMenuItem
            // 
            this.empleadoToolStripMenuItem.Name = "empleadoToolStripMenuItem";
            this.empleadoToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.empleadoToolStripMenuItem.Text = "Empleado";
            this.empleadoToolStripMenuItem.Click += new System.EventHandler(this.empleadoToolStripMenuItem_Click);
            // 
            // productoToolStripMenuItem
            // 
            this.productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            this.productoToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.productoToolStripMenuItem.Text = "Producto";
            this.productoToolStripMenuItem.Click += new System.EventHandler(this.productoToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // FRM_MENU_ADMIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FRM_MENU_ADMIN";
            this.Text = "FRM_MENU_ADMIN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem informaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informaciónDeVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informaciónDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}