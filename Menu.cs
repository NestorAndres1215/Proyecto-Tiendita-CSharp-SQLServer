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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frm_productos f = new frm_productos();
            f.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("xds");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sí");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
            //Form1 f = new Form1();
            //f.Close();
           ///* Program.fo.Close()*/;
           ///

        }
    }
}
