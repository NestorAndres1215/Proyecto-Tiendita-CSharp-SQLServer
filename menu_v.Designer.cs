
namespace Prototipo
{
    partial class menu_v
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu_v));
            this.label1 = new System.Windows.Forms.Label();
            this.pbventa = new System.Windows.Forms.PictureBox();
            this.pbinventario = new System.Windows.Forms.PictureBox();
            this.picsalir = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbventa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbinventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picsalir)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.GhostWhite;
            this.label1.CausesValidation = false;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(988, 117);
            this.label1.TabIndex = 0;
            this.label1.Text = "BIENVENIDO, ELIJA UNA OPCIÓN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbventa
            // 
            this.pbventa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbventa.BackgroundImage")));
            this.pbventa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbventa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbventa.Location = new System.Drawing.Point(209, 194);
            this.pbventa.Name = "pbventa";
            this.pbventa.Size = new System.Drawing.Size(172, 151);
            this.pbventa.TabIndex = 1;
            this.pbventa.TabStop = false;
            this.pbventa.Click += new System.EventHandler(this.pbventa_Click);
            this.pbventa.MouseEnter += new System.EventHandler(this.pbventa_MouseEnter);
            this.pbventa.MouseLeave += new System.EventHandler(this.pbventa_MouseLeave);
            // 
            // pbinventario
            // 
            this.pbinventario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbinventario.BackgroundImage")));
            this.pbinventario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbinventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbinventario.Location = new System.Drawing.Point(580, 196);
            this.pbinventario.Name = "pbinventario";
            this.pbinventario.Size = new System.Drawing.Size(169, 138);
            this.pbinventario.TabIndex = 3;
            this.pbinventario.TabStop = false;
            this.pbinventario.Click += new System.EventHandler(this.pbinventario_Click);
            this.pbinventario.MouseEnter += new System.EventHandler(this.pbinventario_MouseEnter);
            this.pbinventario.MouseLeave += new System.EventHandler(this.pbinventario_MouseLeave);
            // 
            // picsalir
            // 
            this.picsalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picsalir.BackgroundImage")));
            this.picsalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picsalir.Location = new System.Drawing.Point(902, 527);
            this.picsalir.Name = "picsalir";
            this.picsalir.Size = new System.Drawing.Size(86, 67);
            this.picsalir.TabIndex = 6;
            this.picsalir.TabStop = false;
            this.picsalir.Click += new System.EventHandler(this.picsalir_Click);
            // 
            // menu_v
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(988, 592);
            this.Controls.Add(this.picsalir);
            this.Controls.Add(this.pbinventario);
            this.Controls.Add(this.pbventa);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MinimizeBox = false;
            this.Name = "menu_v";
            ((System.ComponentModel.ISupportInitialize)(this.pbventa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbinventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picsalir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbventa;
        private System.Windows.Forms.PictureBox pbinventario;
        private System.Windows.Forms.PictureBox picsalir;
    }
}