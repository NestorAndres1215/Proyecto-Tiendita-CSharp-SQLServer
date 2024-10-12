namespace Prototipo
{
    partial class frm_reg_emp
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.txt_ape = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_dni = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_edad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbx_sexo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbx_cargo = new System.Windows.Forms.ComboBox();
            this.txt_contra = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_pregunta = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_respuesta = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_conf = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.datos = new System.Windows.Forms.DataGridView();
            this.btn_eli = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombe del Empleado :";
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(217, 27);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(132, 20);
            this.txt_nom.TabIndex = 1;
            // 
            // txt_ape
            // 
            this.txt_ape.Location = new System.Drawing.Point(217, 53);
            this.txt_ape.Name = "txt_ape";
            this.txt_ape.Size = new System.Drawing.Size(132, 20);
            this.txt_ape.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido del Empleado :";
            // 
            // txt_dni
            // 
            this.txt_dni.Location = new System.Drawing.Point(217, 79);
            this.txt_dni.MaxLength = 8;
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.Size = new System.Drawing.Size(132, 20);
            this.txt_dni.TabIndex = 5;
            this.txt_dni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_dni_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "DNI del Empleado :";
            // 
            // txt_edad
            // 
            this.txt_edad.Location = new System.Drawing.Point(217, 105);
            this.txt_edad.Name = "txt_edad";
            this.txt_edad.Size = new System.Drawing.Size(132, 20);
            this.txt_edad.TabIndex = 7;
            this.txt_edad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_edad_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(158, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Edad :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(158, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sexo :";
            // 
            // cbx_sexo
            // 
            this.cbx_sexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_sexo.FormattingEnabled = true;
            this.cbx_sexo.Items.AddRange(new object[] {
            "F",
            "M"});
            this.cbx_sexo.Location = new System.Drawing.Point(217, 132);
            this.cbx_sexo.Name = "cbx_sexo";
            this.cbx_sexo.Size = new System.Drawing.Size(132, 21);
            this.cbx_sexo.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(153, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cargo :";
            // 
            // cbx_cargo
            // 
            this.cbx_cargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_cargo.FormattingEnabled = true;
            this.cbx_cargo.Items.AddRange(new object[] {
            "VENDEDOR",
            "CAJERO",
            "ADMINISTRADOR"});
            this.cbx_cargo.Location = new System.Drawing.Point(217, 159);
            this.cbx_cargo.Name = "cbx_cargo";
            this.cbx_cargo.Size = new System.Drawing.Size(132, 21);
            this.cbx_cargo.TabIndex = 11;
            // 
            // txt_contra
            // 
            this.txt_contra.Location = new System.Drawing.Point(217, 186);
            this.txt_contra.MaxLength = 20;
            this.txt_contra.Name = "txt_contra";
            this.txt_contra.Size = new System.Drawing.Size(185, 20);
            this.txt_contra.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(116, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Contraseña :";
            // 
            // txt_pregunta
            // 
            this.txt_pregunta.Location = new System.Drawing.Point(217, 216);
            this.txt_pregunta.MaxLength = 100;
            this.txt_pregunta.Name = "txt_pregunta";
            this.txt_pregunta.Size = new System.Drawing.Size(519, 20);
            this.txt_pregunta.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(131, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Pregunta :";
            // 
            // txt_respuesta
            // 
            this.txt_respuesta.Location = new System.Drawing.Point(216, 245);
            this.txt_respuesta.MaxLength = 100;
            this.txt_respuesta.Name = "txt_respuesta";
            this.txt_respuesta.Size = new System.Drawing.Size(519, 20);
            this.txt_respuesta.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(118, 245);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Respuesta :";
            // 
            // btn_conf
            // 
            this.btn_conf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_conf.Location = new System.Drawing.Point(107, 292);
            this.btn_conf.Name = "btn_conf";
            this.btn_conf.Size = new System.Drawing.Size(122, 31);
            this.btn_conf.TabIndex = 18;
            this.btn_conf.Text = "CONFIRMAR";
            this.btn_conf.UseVisualStyleBackColor = true;
            this.btn_conf.Click += new System.EventHandler(this.btn_conf_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(408, 190);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(236, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Mínimo 6 caracteres y máximo 20";
            // 
            // datos
            // 
            this.datos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datos.Location = new System.Drawing.Point(12, 351);
            this.datos.Name = "datos";
            this.datos.Size = new System.Drawing.Size(736, 308);
            this.datos.TabIndex = 20;
            // 
            // btn_eli
            // 
            this.btn_eli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eli.Location = new System.Drawing.Point(522, 292);
            this.btn_eli.Name = "btn_eli";
            this.btn_eli.Size = new System.Drawing.Size(122, 31);
            this.btn_eli.TabIndex = 21;
            this.btn_eli.Text = "ELIMINAR";
            this.btn_eli.UseVisualStyleBackColor = true;
            this.btn_eli.Click += new System.EventHandler(this.btn_eli_Click);
            // 
            // frm_reg_emp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 671);
            this.Controls.Add(this.btn_eli);
            this.Controls.Add(this.datos);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_conf);
            this.Controls.Add(this.txt_respuesta);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_pregunta);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_contra);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbx_cargo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbx_sexo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_edad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_dni);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_ape);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.label1);
            this.Name = "frm_reg_emp";
            this.Text = "frm_reg_emp";
            this.Load += new System.EventHandler(this.frm_reg_emp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.TextBox txt_ape;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_dni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_edad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbx_sexo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbx_cargo;
        private System.Windows.Forms.TextBox txt_contra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_pregunta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_respuesta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_conf;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView datos;
        private System.Windows.Forms.Button btn_eli;
    }
}