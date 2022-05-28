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
    public partial class Navigasi1 : Form
    {
        public Navigasi1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainMenu mn = new MainMenu();
            mn.Show();
            this.Close();
        }
    }
}
