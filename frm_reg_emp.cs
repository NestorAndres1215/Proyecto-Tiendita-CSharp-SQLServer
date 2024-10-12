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
    public partial class frm_reg_emp : Form
    {
        CD_Conexion c = new CD_Conexion();
        public frm_reg_emp()
        {
            InitializeComponent();
        }

        private void frm_reg_emp_Load(object sender, EventArgs e)
        {
            cbx_sexo.SelectedIndex = 0;
            cbx_cargo.SelectedIndex = 0;

            mostrar();

        }

        private void btn_conf_Click(object sender, EventArgs e)
        {
            try
            {
                validar();

                txt_nom.Text = "";
                txt_ape.Text = "";
                txt_dni.Text = "";
                txt_edad.Text = "";
                txt_contra.Text = "";
                txt_pregunta.Text = "";
                txt_respuesta.Text = "";
                mostrar();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void validar()
        {
            if (txt_nom.Text != "" && txt_ape.Text != ""&&txt_dni.Text!=""&&Convert.ToInt32(txt_edad.Text)>=18&&
                Convert.ToInt32(txt_edad.Text)<=60&&txt_contra.Text.Length>=6&&txt_pregunta.Text!=""&&
                txt_respuesta.Text != "")
            {
                string codcar = cbx_cargo.Text,car="";
                if (codcar == "VENDEDOR") { car = "1"; }
                else if (codcar == "ADMINISTRADOR") { car = "2"; }
                else { car = "3"; }
                
                c.agregar("empleado","'"+txt_nom.Text+"','"+txt_ape.Text+"','"+txt_dni.Text+"',"+txt_edad.Text+",'"+
                  cbx_sexo.Text+"',"+car+",'"+txt_pregunta.Text+"','"+txt_respuesta.Text+"','"+txt_contra.Text+"'");
            }
            else { MessageBox.Show("Ha ingresado un valor incorrecto.","SISTEMA",MessageBoxButtons.OK,
                MessageBoxIcon.Information); }
        }

        private void mostrar()
        {
            DataSet ds = c.select("empleado inner join CargoEmple on Empleado.CodCar=CargoEmple.CodCar ", "CodEmp,NomEmp,ApeEmp," +
            "DniEmp,SexEmp,Cargo", "");

            this.datos.DataSource = ds.Tables[0];
        }

        private void btn_eli_Click(object sender, EventArgs e)
        {
            if (datos.SelectedRows.Count == 1)
            {
                int dni = Convert.ToInt32(datos.Rows[datos.SelectedRows[0].Index].Cells[3].Value);
                c.borrar("Empleado", "DniEmp=" + dni);
                mostrar();
            }
            else { MessageBox.Show("Debe seleccionar una fila entera"); }
        }
        public bool SoloNumeros(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
            return e.Handled;
        }

        private void txt_dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txt_edad_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }
    }
}
