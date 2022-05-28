using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pabdexe3
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Datagridss1 data = new Datagridss1();
            data.Show();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            Navigasi nav = new Navigasi();
            nav.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            masuk kembali = new masuk();
            kembali.Show();
            this.Close();
        }
    }
}
