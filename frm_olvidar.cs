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
    public partial class frm_olvidar : Form
    {
        public frm_olvidar()
        {
            InitializeComponent();
            txtpregunta.Text = Program.pregun;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (label1.Text == "¿Pregunta Secreta?")
            {
                txtrespuesta.Focus();
            }
            else
            {
                txtpregunta.Focus();
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            txtrespuesta.Focus();
        }

        private void txtpregunta_Enter(object sender, EventArgs e)
        {
            if (label1.Text == "¿Pregunta Secreta?")
            {
                txtrespuesta.Focus();
            }
            else
            {
                txtpregunta.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {    
            if (label1.Text == "¿Pregunta Secreta?")
            {
                if (txtrespuesta.Text.ToUpper() == Program.respu.ToUpper())
                {
                    txtpregunta.ReadOnly = false;
                    label1.Text = "Nueva Contraseña:";
                    label2.Text = "Repetir Nueva Contraseña:";
                    txtpregunta.Clear();
                    txtrespuesta.Clear();
                    MessageBox.Show("Datos Correctos", "Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtpregunta.Focus();
                }
                else
                {
                    MessageBox.Show("Uppps!! Respuesta incorrecta", "Fuiste manito", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (txtpregunta.Text == txtrespuesta.Text)
                {
                    new CD_Conexion().actualizar("empleado", "Contra='"+txtrespuesta.Text+"'", "where CodEmp=" + Program.idem);
                    MessageBox.Show("La contraseña se ha actualizado", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    new Form1().Show();
                }
                else
                {
                    MessageBox.Show("Uppps!! La contraseñas no coinciden", "Fuiste manito", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frm_olvidar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                new Form1().Show();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
            
        }
    }
}
