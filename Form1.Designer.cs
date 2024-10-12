
namespace Prototipo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtpasss = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblolvidaste = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtusers = new System.Windows.Forms.TextBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.picver = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtpasss
            // 
            this.txtpasss.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtpasss.Location = new System.Drawing.Point(125, 291);
            this.txtpasss.Name = "txtpasss";
            this.txtpasss.Size = new System.Drawing.Size(238, 26);
            this.txtpasss.TabIndex = 1;
            this.txtpasss.Enter += new System.EventHandler(this.txtpasss_Enter);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(205)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(151, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "LOGIN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblolvidaste
            // 
            this.lblolvidaste.AutoSize = true;
            this.lblolvidaste.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblolvidaste.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
            this.lblolvidaste.Location = new System.Drawing.Point(163, 346);
            this.lblolvidaste.Name = "lblolvidaste";
            this.lblolvidaste.Size = new System.Drawing.Size(150, 15);
            this.lblolvidaste.TabIndex = 4;
            this.lblolvidaste.Text = "¿Olvidaste tu Contraseña?";
            this.lblolvidaste.Click += new System.EventHandler(this.lblolvidaste_Click);
            this.lblolvidaste.MouseEnter += new System.EventHandler(this.lblolvidaste_MouseEnter);
            this.lblolvidaste.MouseLeave += new System.EventHandler(this.lblolvidaste_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.label2.Location = new System.Drawing.Point(170, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "MEMBER LOGIN";
            // 
            // txtusers
            // 
            this.txtusers.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusers.Location = new System.Drawing.Point(125, 237);
            this.txtusers.Name = "txtusers";
            this.txtusers.Size = new System.Drawing.Size(238, 26);
            this.txtusers.TabIndex = 0;
            this.txtusers.Enter += new System.EventHandler(this.txtusers_Enter);
            // 
            // txtuser
            // 
            this.txtuser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtuser.Location = new System.Drawing.Point(166, 244);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(185, 17);
            this.txtuser.TabIndex = 12;
            this.txtuser.TextChanged += new System.EventHandler(this.txtuser_TextChanged);
            // 
            // txtpass
            // 
            this.txtpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtpass.Location = new System.Drawing.Point(166, 297);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(185, 17);
            this.txtpass.TabIndex = 13;
            this.txtpass.UseSystemPasswordChar = true;
            this.txtpass.TextChanged += new System.EventHandler(this.txtpass_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 20;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // picver
            // 
            this.picver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picver.Location = new System.Drawing.Point(330, 297);
            this.picver.Name = "picver";
            this.picver.Size = new System.Drawing.Size(28, 23);
            this.picver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picver.TabIndex = 14;
            this.picver.TabStop = false;
            this.picver.Click += new System.EventHandler(this.picver_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(169, 62);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(142, 112);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(128, 241);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(128, 296);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(490, 496);
            this.Controls.Add(this.picver);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblolvidaste);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtpasss);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.txtusers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtpasss;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblolvidaste;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtusers;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox picver;
    }
}

