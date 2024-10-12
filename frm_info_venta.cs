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
    public partial class frm_info_venta : Form
    {
        public frm_info_venta()
        {
            InitializeComponent();
        }

        private void FRM_INFO_VENTAS_Load(object sender, EventArgs e)
        {
            CD_Conexion con = new CD_Conexion();
            DataSet ds=con.select("boleta", "*", "");
            this.dataGridView1.DataSource = ds.Tables[0];

        }
    }
}
