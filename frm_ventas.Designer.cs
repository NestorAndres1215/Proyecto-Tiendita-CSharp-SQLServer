
namespace Prototipo
{
    partial class frm_ventas
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ventas));
            this.label1 = new System.Windows.Forms.Label();
            this.txtproducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.DataGridView();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.lbltotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.picagregar = new System.Windows.Forms.PictureBox();
            this.piceliminar = new System.Windows.Forms.PictureBox();
            this.piclimpiar = new System.Windows.Forms.PictureBox();
            this.picfinalizar = new System.Windows.Forms.PictureBox();
            this.txtnventa = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sub_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picagregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piceliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piclimpiar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picfinalizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(59, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del producto:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtproducto
            // 
            this.txtproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtproducto.Location = new System.Drawing.Point(264, 112);
            this.txtproducto.Name = "txtproducto";
            this.txtproducto.Size = new System.Drawing.Size(192, 26);
            this.txtproducto.TabIndex = 3;
            this.txtproducto.TextChanged += new System.EventHandler(this.txtproducto_TextChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(117, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Precio:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtcantidad
            // 
            this.txtcantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtcantidad.Location = new System.Drawing.Point(264, 215);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(137, 26);
            this.txtcantidad.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(117, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cantidad:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // data
            // 
            this.data.AllowUserToAddRows = false;
            this.data.AllowUserToDeleteRows = false;
            this.data.AllowUserToOrderColumns = true;
            this.data.AllowUserToResizeColumns = false;
            this.data.AllowUserToResizeRows = false;
            this.data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreProducto,
            this.Precio,
            this.Cantidad,
            this.Sub_Total,
            this.cid});
            this.data.Location = new System.Drawing.Point(68, 310);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(841, 288);
            this.data.TabIndex = 6;
            this.data.TabStop = false;
            // 
            // txtprecio
            // 
            this.txtprecio.Cursor = System.Windows.Forms.Cursors.No;
            this.txtprecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtprecio.Location = new System.Drawing.Point(264, 163);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.ReadOnly = true;
            this.txtprecio.Size = new System.Drawing.Size(137, 26);
            this.txtprecio.TabIndex = 3;
            this.txtprecio.TabStop = false;
            // 
            // lbltotal
            // 
            this.lbltotal.BackColor = System.Drawing.Color.White;
            this.lbltotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbltotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbltotal.Location = new System.Drawing.Point(809, 631);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(100, 23);
            this.lbltotal.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(758, 635);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Total:";
            // 
            // picagregar
            // 
            this.picagregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picagregar.BackgroundImage")));
            this.picagregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picagregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picagregar.Location = new System.Drawing.Point(958, 116);
            this.picagregar.Name = "picagregar";
            this.picagregar.Size = new System.Drawing.Size(134, 82);
            this.picagregar.TabIndex = 23;
            this.picagregar.TabStop = false;
            this.picagregar.Click += new System.EventHandler(this.picagregar_Click);
            this.picagregar.MouseEnter += new System.EventHandler(this.picagregar_MouseEnter);
            this.picagregar.MouseLeave += new System.EventHandler(this.picagregar_MouseLeave);
            // 
            // piceliminar
            // 
            this.piceliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("piceliminar.BackgroundImage")));
            this.piceliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.piceliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.piceliminar.Location = new System.Drawing.Point(958, 253);
            this.piceliminar.Name = "piceliminar";
            this.piceliminar.Size = new System.Drawing.Size(134, 82);
            this.piceliminar.TabIndex = 24;
            this.piceliminar.TabStop = false;
            this.piceliminar.Click += new System.EventHandler(this.piceliminar_Click);
            this.piceliminar.MouseEnter += new System.EventHandler(this.piceliminar_MouseEnter);
            this.piceliminar.MouseLeave += new System.EventHandler(this.piceliminar_MouseLeave);
            // 
            // piclimpiar
            // 
            this.piclimpiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("piclimpiar.BackgroundImage")));
            this.piclimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.piclimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.piclimpiar.Location = new System.Drawing.Point(958, 376);
            this.piclimpiar.Name = "piclimpiar";
            this.piclimpiar.Size = new System.Drawing.Size(134, 82);
            this.piclimpiar.TabIndex = 25;
            this.piclimpiar.TabStop = false;
            this.piclimpiar.MouseEnter += new System.EventHandler(this.piclimpiar_MouseEnter);
            this.piclimpiar.MouseLeave += new System.EventHandler(this.piclimpiar_MouseLeave);
            // 
            // picfinalizar
            // 
            this.picfinalizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picfinalizar.BackgroundImage")));
            this.picfinalizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picfinalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picfinalizar.Location = new System.Drawing.Point(958, 509);
            this.picfinalizar.Name = "picfinalizar";
            this.picfinalizar.Size = new System.Drawing.Size(134, 82);
            this.picfinalizar.TabIndex = 30;
            this.picfinalizar.TabStop = false;
            this.picfinalizar.Click += new System.EventHandler(this.picfinalizar_Click);
            this.picfinalizar.MouseEnter += new System.EventHandler(this.picfinalizar_MouseEnter);
            this.picfinalizar.MouseLeave += new System.EventHandler(this.picfinalizar_MouseLeave);
            // 
            // txtnventa
            // 
            this.txtnventa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtnventa.Location = new System.Drawing.Point(68, 624);
            this.txtnventa.Name = "txtnventa";
            this.txtnventa.ReadOnly = true;
            this.txtnventa.Size = new System.Drawing.Size(80, 26);
            this.txtnventa.TabIndex = 14;
            this.txtnventa.TabStop = false;
            this.txtnventa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(626, 116);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 176);
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1153, 73);
            this.label4.TabIndex = 37;
            this.label4.Text = "REGISTRO DE VENTAS";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.Location = new System.Drawing.Point(117, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 29);
            this.label5.TabIndex = 39;
            this.label5.Text = "Stock :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtstock
            // 
            this.txtstock.Cursor = System.Windows.Forms.Cursors.No;
            this.txtstock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtstock.Location = new System.Drawing.Point(264, 252);
            this.txtstock.Name = "txtstock";
            this.txtstock.ReadOnly = true;
            this.txtstock.Size = new System.Drawing.Size(137, 26);
            this.txtstock.TabIndex = 40;
            this.txtstock.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // NombreProducto
            // 
            this.NombreProducto.HeaderText = "Nombre del Producto";
            this.NombreProducto.Name = "NombreProducto";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Sub_Total
            // 
            this.Sub_Total.HeaderText = "Sub Total";
            this.Sub_Total.Name = "Sub_Total";
            // 
            // cid
            // 
            this.cid.HeaderText = "Id";
            this.cid.Name = "cid";
            this.cid.ReadOnly = true;
            this.cid.Visible = false;
            // 
            // frm_ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1153, 688);
            this.Controls.Add(this.txtstock);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picfinalizar);
            this.Controls.Add(this.piclimpiar);
            this.Controls.Add(this.piceliminar);
            this.Controls.Add(this.picagregar);
            this.Controls.Add(this.txtnventa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.data);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtproducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "frm_ventas";
            this.Text = "Venta";
            this.Load += new System.EventHandler(this.frm_ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picagregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piceliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piclimpiar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picfinalizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtproducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox picagregar;
        private System.Windows.Forms.PictureBox piceliminar;
        private System.Windows.Forms.PictureBox piclimpiar;
        private System.Windows.Forms.PictureBox picfinalizar;
        private System.Windows.Forms.TextBox txtnventa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtstock;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sub_Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn cid;
    }
}