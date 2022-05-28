using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace pabdexe3
{
    public partial class masuk : Form
    {
        private SqlCommand cm;
        private DataSet ds;
        private SqlDataAdapter sd;
        private SqlDataReader dr;

        Class1 c1 = new Class1();
        public masuk()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prodiTIDataSet.Mahasiswa' table. You can move, or remove it, as needed.
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection kon = c1.Getconn();
            kon.Open();
            cm = new SqlCommand("select * from namaku where nama = '" + textBox1.Text + "'and password = '" + textBox2.Text + "'", kon);
            dr = cm.ExecuteReader();
            dr.Read();

            if(dr.HasRows)
            {
                this.Hide();
                MainMenu mn = new MainMenu();
                mn.Show();
            }
            else
            {
                MessageBox.Show("Ulangi salah bro !!!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
