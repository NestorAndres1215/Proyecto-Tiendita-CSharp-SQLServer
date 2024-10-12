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
    public partial class frm_boleta : Form
    {

        CD_Conexion con = new CD_Conexion();

        public frm_boleta()
        {
            InitializeComponent();
        }

        private void rdb_registrado_CheckedChanged(object sender, EventArgs e)
        {
            lbl_user.Text = "DNI del usuario :";
            txt_dni.Text = "";
            txt_dni.ReadOnly = false;


        }

        private void rdb_anonimo_CheckedChanged(object sender, EventArgs e)
        {
            lbl_user.Text = "Usuario :";
            txt_dni.ReadOnly = true;
            txt_dni.Text = "Anónimo";
        }

        private void btn_conf_Click(object sender, EventArgs e)
        {
            if (txt_dni.Text.Length == 8 || txt_dni.Text=="Anónimo")
            {
                string tipPago = "";

                data.Rows.Clear();
                txt_tex.Items.Clear();
                if (rbndinero.Checked == true) { tipPago = "1"; }
                else if (rbnfiado.Checked == true) { tipPago = "2"; }
                else if (rbnyape.Checked == true) { tipPago = "3"; }
                else if (rbntarjeta.Checked == true) { tipPago = "4"; }
                else if (rbnplin.Checked == true) { tipPago = "5"; }
                else { tipPago = "6"; }



                try
                {
                    string dni = txt_dni.Text;

                    string CMD = string.Format("Select Count(*) from boleta");
                    DataSet a = new CD_Conexion().User(CMD);

                    int conteo = Convert.ToInt32(a.Tables[0].Rows[0][0].ToString().Trim());

                    if (tipPago != "2") {
                        Console.WriteLine("1");
                        con.actualizar("Boleta", "CodPag=" + tipPago + ", DniCli='" + dni + "', EstBol='Pagado'", "where CodBol=" + txt_bol.Text);
                        
                    }
                    else {
                        Console.WriteLine("2");
                         con.actualizar("Boleta", "CodPag=" + tipPago + ", DniCli='" + dni + "', EstBol='No pagado'", "where CodBol=" + txt_bol.Text);
                    }
                    
                    DataSet datos = con.select("Pedido_Producto inner join Boleta on Pedido_Producto.CodBol = Boleta.CodBol inner join producto on producto.CodPro = Pedido_Producto.CodPro inner join TipPago on Boleta.CodPag=TipPago.CodPag",
                        "Producto.Codpro,Boleta.CodBol,DesPag,DniCli,NomPro,DesPro,CanPro,PrePro,MonBol,EstBol", "where Boleta.CodBol=" + txt_bol.Text);


                    txt_tex.Items.Add("Código de Boleta=" + datos.Tables[0].Rows[0][1]
                    + "        Tipo de Pago=" + datos.Tables[0].Rows[0][2] +
                        "\tDNI del Cliente=" + datos.Tables[0].Rows[0][3] +
                    "\tEstado de Boleta=" + datos.Tables[0].Rows[0]["EstBol"]);

                    try
                    {
                        for (int i = 0; i < datos.Tables[0].Rows.Count; i++)
                        {

                            int da = data.Rows.Add();
                            data.Rows[da].Cells[0].Value = datos.Tables[0].Rows[i][0];
                            data.Rows[da].Cells[1].Value = datos.Tables[0].Rows[i]["NomPro"];
                            data.Rows[da].Cells[2].Value = datos.Tables[0].Rows[i]["DesPro"];
                            data.Rows[da].Cells[3].Value = datos.Tables[0].Rows[i]["PrePro"];
                            data.Rows[da].Cells[4].Value = datos.Tables[0].Rows[i]["CanPro"];
                            data.Rows[da].Cells[5].Value = (Convert.ToDouble(datos.Tables[0].Rows[i]["PrePro"]) * Convert.ToDouble(datos.Tables[0].Rows[i]["CanPro"]));

                        }
                        txt_tex.Items.Add("");
                        txt_tex.Items.Add("Monto total=" + datos.Tables[0].Rows[0]["MonBol"]);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


                
            }
        }

        private void txt_dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
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

        private void frm_boleta_Load(object sender, EventArgs e)
        {

        }

        private void txt_bol_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = con.select("Boleta", "FecPag,MonBol", "where CodBol=" + txt_bol.Text);
                lbl_fecha.Text = ds.Tables[0].Rows[0]["FecPag"].ToString().Trim();
                lbl_total.Text = ds.Tables[0].Rows[0]["MonBol"].ToString().Trim();
            }
            catch
            {
                lbl_fecha.Text = "";
                lbl_total.Text = "";
            }

            
        }

        private void txt_dni_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
