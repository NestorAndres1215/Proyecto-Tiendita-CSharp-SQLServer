namespace Prototipo
{
    partial class frm_reg_prod
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
            this.txt_stock = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_pre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_des = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.datos = new System.Windows.Forms.DataGridView();
            this.btn_eli = new System.Windows.Forms.Button();
            this.btn_conf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datos)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_stock
            // 
            this.txt_stock.Location = new System.Drawing.Point(411, 105);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Size = new System.Drawing.Size(132, 20);
            this.txt_stock.TabIndex = 15;
            this.txt_stock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_stock_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(346, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Stock :";
            // 
            // txt_pre
            // 
            this.txt_pre.Location = new System.Drawing.Point(411, 79);
            this.txt_pre.MaxLength = 8;
            this.txt_pre.Name = "txt_pre";
            this.txt_pre.Size = new System.Drawing.Size(132, 20);
            this.txt_pre.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(340, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Precio :";
            // 
            // txt_des
            // 
            this.txt_des.Location = new System.Drawing.Point(411, 53);
            this.txt_des.MaxLength = 100;
            this.txt_des.Name = "txt_des";
            this.txt_des.Size = new System.Drawing.Size(132, 20);
            this.txt_des.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(210, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Descripción del Producto :";
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(411, 27);
            this.txt_nom.MaxLength = 40;
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(132, 20);
            this.txt_nom.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre del Producto :";
            // 
            // datos
            // 
            this.datos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datos.Location = new System.Drawing.Point(12, 222);
            this.datos.Name = "datos";
            this.datos.Size = new System.Drawing.Size(795, 331);
            this.datos.TabIndex = 16;
            // 
            // btn_eli
            // 
            this.btn_eli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eli.Location = new System.Drawing.Point(554, 165);
            this.btn_eli.Name = "btn_eli";
            this.btn_eli.Size = new System.Drawing.Size(122, 31);
            this.btn_eli.TabIndex = 23;
            this.btn_eli.Text = "ELIMINAR";
            this.btn_eli.UseVisualStyleBackColor = true;
            this.btn_eli.Click += new System.EventHandler(this.btn_eli_Click);
            // 
            // btn_conf
            // 
            this.btn_conf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_conf.Location = new System.Drawing.Point(139, 165);
            this.btn_conf.Name = "btn_conf";
            this.btn_conf.Size = new System.Drawing.Size(122, 31);
            this.btn_conf.TabIndex = 22;
            this.btn_conf.Text = "CONFIRMAR";
            this.btn_conf.UseVisualStyleBackColor = true;
            this.btn_conf.Click += new System.EventHandler(this.btn_conf_Click);
            // 
            // frm_reg_prod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 565);
            this.Controls.Add(this.btn_eli);
            this.Controls.Add(this.btn_conf);
            this.Controls.Add(this.datos);
            this.Controls.Add(this.txt_stock);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_pre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_des);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.label1);
            this.Name = "frm_reg_prod";
            this.Text = "frm_reg_prod";
            this.Load += new System.EventHandler(this.frm_reg_prod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_stock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_pre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_des;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView datos;
        private System.Windows.Forms.Button btn_eli;
        private System.Windows.Forms.Button btn_conf;
    }
}