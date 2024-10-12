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

    
    public partial class frm_reg_prod : Form
    {

        CD_Conexion con = new CD_Conexion();


        public frm_reg_prod()
        {
            InitializeComponent();
        }

        private void btn_conf_Click(object sender, EventArgs e)
        {
            try
            {
                double res = 0;
                if (txt_nom.Text != "" && txt_des.Text != "" && double.TryParse(txt_pre.Text, out res) &&
                    Convert.ToDouble(txt_pre.Text) > 0 && Convert.ToInt32(txt_stock.Text) >= 0)
                {
                    con.agregar("Producto", "'" + txt_nom.Text + "','" + txt_des.Text + "'," + txt_pre.Text + "," + txt_stock.Text);
                    mostrar();
                }
                else { MessageBox.Show("Ha ingresado algún dato incorrecto."); }
            }
            catch
            {
                MessageBox.Show("Error.");
            }

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

        private void txt_stock_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void mostrar()
        {
            DataSet ds = con.select("Producto", "*", "");
            this.datos.DataSource = ds.Tables[0];
        }

        private void frm_reg_prod_Load(object sender, EventArgs e)
        {
            mostrar();
        }

        private void btn_eli_Click(object sender, EventArgs e)
        {
            if (datos.SelectedRows.Count == 1)
            {
                int cod = Convert.ToInt32(datos.Rows[datos.SelectedRows[0].Index].Cells[0].Value);
                con.borrar("Producto", "CodPro=" + cod);
                mostrar();
            }
            else { MessageBox.Show("Debe seleccionar una fila entera"); }
        }
    }

}
