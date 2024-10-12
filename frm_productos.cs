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
    public partial class frm_productos : Form
    {
        public frm_productos()
        {
            InitializeComponent();
            CD_Conexion x = new CD_Conexion();
            x.AbrirConexion();
            DataSet ds = x.Consultar();
            this.data.DataSource = ds.Tables[0];
            x.CerrarConexion();
        }

        private void frm_productos_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
