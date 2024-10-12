
namespace Prototipo
{
    partial class frm_olvidar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_olvidar));
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpregunta = new System.Windows.Forms.TextBox();
            this.txtrespuesta = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(205)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(71, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(275, 37);
            this.button1.TabIndex = 13;
            this.button1.Text = "ACEPTAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(305, 27);
            this.label3.TabIndex = 12;
            this.label3.Text = "RECUPERAR CONTRASEÑA";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.LightBlue;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Arial", 13.75F);
            this.textBox2.Location = new System.Drawing.Point(71, 216);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(275, 29);
            this.textBox2.TabIndex = 10;
            this.textBox2.Enter += new System.EventHandler(this.textBox2_Enter);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightBlue;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Arial", 13.75F);
            this.textBox1.Location = new System.Drawing.Point(71, 146);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(275, 29);
            this.textBox1.TabIndex = 9;
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(69, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Respuesta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "¿Pregunta Secreta?";
            // 
            // txtpregunta
            // 
            this.txtpregunta.BackColor = System.Drawing.Color.LightBlue;
            this.txtpregunta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtpregunta.Location = new System.Drawing.Point(77, 152);
            this.txtpregunta.Name = "txtpregunta";
            this.txtpregunta.ReadOnly = true;
            this.txtpregunta.Size = new System.Drawing.Size(264, 17);
            this.txtpregunta.TabIndex = 14;
            this.txtpregunta.Enter += new System.EventHandler(this.txtpregunta_Enter);
            // 
            // txtrespuesta
            // 
            this.txtrespuesta.BackColor = System.Drawing.Color.LightBlue;
            this.txtrespuesta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtrespuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtrespuesta.Location = new System.Drawing.Point(77, 221);
            this.txtrespuesta.Name = "txtrespuesta";
            this.txtrespuesta.Size = new System.Drawing.Size(264, 17);
            this.txtrespuesta.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(448, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(303, 273);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // frm_olvidar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(814, 400);
            this.Controls.Add(this.txtrespuesta);
            this.Controls.Add(this.txtpregunta);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frm_olvidar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_olvidar";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_olvidar_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpregunta;
        private System.Windows.Forms.TextBox txtrespuesta;
    }
}