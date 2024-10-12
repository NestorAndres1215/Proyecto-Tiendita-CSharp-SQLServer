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
    


    public partial class frm_ventas : Form
    {
        
        CD_Conexion con = new CD_Conexion();

        


        public frm_ventas()
        {
            InitializeComponent();
            actualizarboleta();
        }

        int idpe = -1;

        private void txtproducto_TextChanged(object sender, EventArgs e)
        {
            try
            {

                string CMD = string.Format("select CodPro, NomPro, PrePro,StoPro from Producto where NomPro = '{0}'", txtproducto.Text.Trim());
                DataSet ds = new CD_Conexion().User(CMD);

                string nompro = ds.Tables[0].Rows[0]["NomPro"].ToString().Trim();
                if (nompro.ToUpper() == txtproducto.Text.Trim().ToUpper())
                {
                    //MessageBox.Show("Encontro  ");
                    string prepro = ds.Tables[0].Rows[0]["PrePro"].ToString().Trim();
                    idpe = Convert.ToInt32(ds.Tables[0].Rows[0]["CodPro"].ToString().Trim());
                    txtprecio.Text = prepro;

                    string stock = ds.Tables[0].Rows[0]["StoPro"].ToString().Trim();
                    txtstock.Text = stock;

                }
            }
            catch (Exception)
            {
                //MessageBox.Show("Error: ", a.Message);
                txtprecio.Clear();
                txtstock.Clear();
                
                idpe = -1;
            }
            
        }

        private void picagregar_Click(object sender, EventArgs e)
        {
            
            string pe = validar();
            if (pe.Length >= 1)
            {
                MessageBox.Show(pe, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataSet ds=con.select("producto", "StoPro", "where CodPro=" + idpe);

            int stock=Convert.ToInt32(ds.Tables[0].Rows[0]["StoPro"].ToString().Trim());
            
            if (stock >= Convert.ToInt32(txtcantidad.Text))
            {
                int n = data.Rows.Add();
                data.Rows[n].Cells[0].Value = txtproducto.Text;
                data.Rows[n].Cells[1].Value = txtprecio.Text;
                data.Rows[n].Cells[2].Value = txtcantidad.Text;
                data.Rows[n].Cells[3].Value = "" + Convert.ToDouble(txtprecio.Text) * Convert.ToInt32(txtcantidad.Text);
                data.Rows[n].Cells[4].Value = "" + idpe;

                stock = stock - Convert.ToInt32(txtcantidad.Text);
                con.actualizar("producto", "StoPro=" + stock, "where CodPro=" + idpe);
                txtstock.Text = stock+"";
                lbltotal.Text = "" + aea();
            }
            else { MessageBox.Show("Insuficiente stock."); }




            
        }

        private void piceliminar_Click(object sender, EventArgs e)
        {
            if (data.SelectedRows.Count == 0)
            {
                MessageBox.Show("PARA ELIMINAR DEBES SELECCIONAR UNA FILA", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var yesono = MessageBox.Show("¿Desea descartar el producto seleccionado?", "Terminar la Venta", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (yesono == DialogResult.Yes)
            {
                int num2 = Convert.ToInt32(data.Rows[data.SelectedRows[0].Index].Cells[4].Value);
                int num=Convert.ToInt32(data.Rows[data.SelectedRows[0].Index].Cells[2].Value);
                
                con.actualizar("producto","StoPro=(select StoPro from Producto where CodPro="+num2+")+"+num,
                    "where CodPro="+num2);
                txtproducto.Text = "";
                txtcantidad.Text = "";

                data.Rows.RemoveAt(data.SelectedRows[0].Index);
                lbltotal.Text = "" + aea();
            }
        }

        public double aea()
        {
            double cant = 0.0;
            for (int i = 0; i < data.Rows.Count; i++)
            {
                cant = cant + Convert.ToDouble(data.Rows[i].Cells[3].Value);
            }

            return cant;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtproducto.Clear();
            txtprecio.Clear();
            txtcantidad.Clear();
        }

        private void picagregar_MouseEnter(object sender, EventArgs e)
        {
            agrandar(picagregar);
        }

        private void picagregar_MouseLeave(object sender, EventArgs e)
        {
            achicar(picagregar);
        }

        private void piceliminar_MouseEnter(object sender, EventArgs e)
        {
            agrandar(piceliminar);
        }

        private void piceliminar_MouseLeave(object sender, EventArgs e)
        {
            achicar(piceliminar);
        }

        private void piclimpiar_MouseEnter(object sender, EventArgs e)
        {
            agrandar(piclimpiar);
        }

        private void piclimpiar_MouseLeave(object sender, EventArgs e)
        {
            achicar(piclimpiar);
        }

        private void picfinalizar_MouseEnter(object sender, EventArgs e)
        {
            agrandar(picfinalizar);
        }

        private void picfinalizar_MouseLeave(object sender, EventArgs e)
        {
            achicar(picfinalizar);
        }

        public void agrandar(PictureBox aea)
        {
            aea.Size = new Size(182, 109);
            aea.Left -= 15;
            aea.Top -= 10;
        }

        public void achicar(PictureBox aea)
        {
            aea.Size = new Size(134, 82);
            aea.Left += 15;
            aea.Top += 10;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_boleta f = new frm_boleta();
            f.Show();
            this.Close();
        }

        private void picfinalizar_Click(object sender, EventArgs e)
        {  
            if (data.Rows.Count == 0)
            {
                MessageBox.Show("   No hay nada   ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var yesono = MessageBox.Show("¿Desea terminar la venta?", "Terminar la Venta", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (yesono == DialogResult.Yes)
            {
                try
                {
                    Console.WriteLine(Program.emp);
                    //CodPago,CodEmp,DniCli,Fecha,Monto,Estado
                    con.agregar("boleta", txtnventa.Text + ",1,"+Program.emp+","+ "'asd'" + ",default," + lbltotal.Text + ",default");

                    for (int i = 0; i < data.Rows.Count; i++)
                    {
                        // Codigo identity PK, CodPro , CanPro , CodBol
                        con.agregar("Pedido_Producto", "" + data.Rows[i].Cells[4].Value + ", " + data.Rows[i].Cells[2].Value + ", " + txtnventa.Text);
                    }
                }
                catch (Exception aeas)
                {
                    MessageBox.Show(aeas.Message + "");
                }
            }
        }

        public string validar()
        {
            if (txtproducto.Text.Trim()=="" || txtprecio.Text.Trim()=="" || txtcantidad.Text.Trim()=="")
            {
                return "   Llena los datos   ";
            }
            return "";
        }

        public void actualizarboleta()
        {
            string CMD = string.Format("Select Count(*) from boleta");
            DataSet a = new CD_Conexion().User(CMD);

            int conteo = Convert.ToInt32(a.Tables[0].Rows[0][0].ToString().Trim());
            txtnventa.Text = "" + (conteo+1);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            frm_boleta f = new frm_boleta();
            f.Show();
        }

        private void frm_ventas_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            actualizarboleta();
        }


    }
}




//un tq