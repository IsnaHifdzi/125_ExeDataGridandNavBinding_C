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
    public partial class Form9 : Form
    {
        DataTable dt;
        DataRow dr;
        string code;
        public Form9()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dt = prodiTIDataSet.Tables["mahasiswa"];
            dr = dt.NewRow();
          
            dr[0] = txtnomhs.Text;
            dr[1] = textname.Text;
            dr[2] = textalamat.Text;
            dr[3] = cbkelamin.Text;
            dr[4] = txthp.Text;

            dt.Rows.Add(dr);
            mahasiswaTableAdapter.Update(prodiTIDataSet);
           
            txtnomhs.Enabled = false; 
            textname.Enabled = false;
            textalamat.Enabled = false; 
            txthp.Enabled = false;
            cbkelamin.Enabled = false;
            this.mahasiswaTableAdapter.Fill(this.prodiTIDataSet.Mahasiswa);
            cmdAdd.Enabled = true;
            cmdSave.Enabled = false;
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prodiTIDataSet.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.prodiTIDataSet.Mahasiswa);
           
            txtnomhs.Enabled = false; textname.Enabled = false;
            textalamat.Enabled = false; txthp.Enabled = false;
            cbkelamin.Enabled = false;
            cbkelamin.Items.Add("P");
            cbkelamin.Items.Add("L");
            cmdSave.Enabled = false;
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            cmdSave.Enabled = true;
           
            txtnomhs.Enabled = true; textname.Enabled = true;
            textalamat.Enabled = true; txthp.Enabled = true;
            cbkelamin.Enabled = true;

            txtnomhs.Text = "";
            textname.Text = "";
            textalamat.Text = "";
            txthp.Text = "";
            cbkelamin.Text = "";
           
            dt = prodiTIDataSet.Tables["mahasiswa"];
           
           
            cmdAdd.Enabled = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            string code;
            code = txtnomhs.Text;
            dr = prodiTIDataSet.Tables["mahasiswa"].Rows.Find(code);
            dr.Delete();
            mahasiswaTableAdapter.Update(prodiTIDataSet);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainMenu kembali = new MainMenu();
            kembali.Show();
            this.Close();
        }
    }
}
