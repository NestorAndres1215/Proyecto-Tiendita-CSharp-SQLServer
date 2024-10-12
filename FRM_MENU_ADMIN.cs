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
    public partial class FRM_MENU_ADMIN : Form
    {

        private frm_productos prod;
        private frm_info_venta vent;
        private frm_reg_emp emp;
        private frm_reg_prod producto;

        public FRM_MENU_ADMIN()
        {
            InitializeComponent();
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (producto == null)
            {
                producto = new frm_reg_prod();
                producto.MdiParent = this;
                producto.Show();
                producto.FormClosed += new FormClosedEventHandler(SalirProducto);
            }
            else
            {
                prod.Activate();
            }
        }

        private void informaciónDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (vent == null)
            {
                vent = new frm_info_venta();
                vent.MdiParent = this;
                vent.Show();
                vent.FormClosed += new FormClosedEventHandler(SalirVent);
            }
            else
            {
                vent.Activate();
            }
        }

        private void informaciónDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (prod == null)
            {
                prod = new frm_productos();
                prod.MdiParent = this;
                prod.Show();
                prod.FormClosed += new FormClosedEventHandler(SalirProd);
            }
            else
            {
                prod.Activate();
            }
        }

        public void SalirProd(object sender, FormClosedEventArgs e)
        {
            prod = null;
        }

        public void SalirVent(object sender, FormClosedEventArgs e)
        {
            vent = null;
        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (emp == null)
            {
                emp = new frm_reg_emp();
                emp.MdiParent = this;
                emp.Show();
                emp.FormClosed += new FormClosedEventHandler(SalirEmp);
            }
            else
            {
                emp.Activate();
            }
        }

        public void SalirEmp(object sender, FormClosedEventArgs e)
        {
            emp = null;
        }
        public void SalirProducto(object sender, FormClosedEventArgs e)
        {
            producto = null;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }
    }
}
