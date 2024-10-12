using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Prototipo
{
    public partial class menu_v : Form
    {
        public menu_v()
        {
            InitializeComponent();
        }

        private void pbventa_Click(object sender, EventArgs e)
        {
            frm_ventas x = new frm_ventas();
            x.Show();
            //this.Close();
        }

        private void lblventa_Click(object sender, EventArgs e)
        {
            pbventa_Click(sender, e);
        }

        private void pbventa_MouseEnter(object sender, EventArgs e)
        {
            pbventa.Size = new Size(205, 155);
            pbventa.Left -= 15;
            pbventa.Top -= 6;
            sounds();
        }

        private void pbventa_MouseLeave(object sender, EventArgs e)
        {
            //pbventa.Size = new Size(157, 138);
            pbventa.Size = new Size(172, 151);
            pbventa.Left += 15;
            pbventa.Top += 6;
        }

        private void pbinventario_MouseEnter(object sender, EventArgs e)
        {
            pbinventario.Size = new Size(217, 155);
            pbinventario.Left -= 15;
            pbinventario.Top -= 6;
            sounds();
        }

        private void pbinventario_MouseLeave(object sender, EventArgs e)
        {
            pbinventario.Size = new Size(169, 138);
            pbinventario.Left += 15;
            pbinventario.Top += 6;
        }

        public void sounds()
        {
            SoundPlayer aea = new SoundPlayer(@"beep23.wav");
            aea.Play();
        }

        private void pbinventario_Click(object sender, EventArgs e)
        {
            frm_productos x = new frm_productos();
            x.ShowDialog();
        }

        private void picsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
