using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Focus();
            this.txtusers.MinimumSize = new Size(239, 34);
            this.txtpasss.MinimumSize = new Size(239, 34);
            camventana = -1;
            Program.idem = -1;
        }

        int camventana = -1;

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer2.Enabled) return;
            try
            {
                string CMD = string.Format("Select * from empleado where NomEmp = '{0}' and Contra = '{1}'", txtuser.Text.Trim(), txtpass.Text.Trim());
     // Esto imprime el nombre del empleado en la consola
                Console.WriteLine(CMD);
        
                CD_Conexion AEA = new CD_Conexion();
                DataSet ds = AEA.User(CMD);
  
                string user = ds.Tables[0].Rows[0]["NomEmp"].ToString().Trim();
                string pass = ds.Tables[0].Rows[0]["Contra"].ToString().Trim();

             

                if (user == txtuser.Text.Trim() && pass == txtpass.Text.Trim())
                {
                    string car = ds.Tables[0].Rows[0]["CodCar"].ToString().Trim();
                    Program.emp=ds.Tables[0].Rows[0]["CodEmp"].ToString().Trim();

                    if (car == "2")
                    {
                        //new FRM_MENU_ADMIN().Show();
                        camventana = 1;
                        //this.Hide();
                    }
                    else
                    {
                        //new menu_v().Show();
                        camventana = 2;
                        //me.Show();
                        //this.Hide();
                    }
                    timer2.Start();
                
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error de Datos: " + ex.Message);
            }
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void lblolvidaste_MouseEnter(object sender, EventArgs e)
        {
            lblolvidaste.ForeColor = Color.FromArgb(0, 0, 140);
        }

        private void lblolvidaste_MouseLeave(object sender, EventArgs e)
        {
            lblolvidaste.ForeColor = Color.Black;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
            timer1.Start();
        }

        private void txtusers_Enter(object sender, EventArgs e)
        {
            txtuser.Focus();
        }

        private void txtpasss_Enter(object sender, EventArgs e)
        {
            txtpass.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (this.Opacity)
            {
                case 1: 
                    timer1.Stop();
                    return;                       
            }
            this.Opacity += 0.05;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            switch (this.Opacity)
            {
                case 0:
                    if (camventana == 1) new menu_v().Show();
                    else if (camventana == 2) new FRM_MENU_ADMIN().Show();
                    else if (camventana == 3) new frm_olvidar().Show();
                    this.Hide();
                    timer2.Stop();
                    return;
            }
            this.Opacity -= 0.05;
        }

        private void lblolvidaste_Click(object sender, EventArgs e)
        {
            if (timer2.Enabled) return;
            else if (txtuser.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el usuario para poder recuperar la contraseña", "Recuperar Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DataSet ds = new CD_Conexion().select("empleado", "NomEmp,Pregunta,Respuesta,CodEmp", "where NomEmp='" + txtuser.Text.Trim() + "'    ");
                if (ds.Tables[0].Rows[0]["NomEmp"].ToString().Trim().ToUpper() == txtuser.Text.Trim().ToUpper())
                {
                    Program.pregun = ds.Tables[0].Rows[0]["Pregunta"].ToString().Trim();
                    Program.respu = ds.Tables[0].Rows[0]["Respuesta"].ToString();
                    Program.idem = Convert.ToInt32(ds.Tables[0].Rows[0]["CodEmp"]);
                    //new frm_olvidar().Show();
                    this.Hide();
                }

                camventana = 3;
                timer2.Start();
            }
            catch (Exception)
            {
                MessageBox.Show("No se encontro el usuario");
            }

            
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {
            picver.Image = (txtpass.Text.Length > 0) ? ver_nover() : null ;
        }

        private void picver_Click(object sender, EventArgs e)
        {
            if (picver.Image == null) return;
            else if (txtpass.UseSystemPasswordChar)
            {
                txtpass.UseSystemPasswordChar = false;
                picver.Image = Properties.Resources.ver;

            }
            else
            {
                txtpass.UseSystemPasswordChar = true;
                picver.Image = Properties.Resources.nover;
            }
        }

        public Image ver_nover()
        {
            if (txtpass.UseSystemPasswordChar)
            {
                return picver.Image = Properties.Resources.nover;

            }
            else
            {
                return picver.Image = Properties.Resources.ver;
            }
        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
