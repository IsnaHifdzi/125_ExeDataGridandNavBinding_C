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
    public partial class Datagridss1 : Form
    {
        public Datagridss1()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prodiTIDataSet.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.prodiTIDataSet.Mahasiswa);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MainMenu kembali = new MainMenu();
            kembali.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Form7 ft = new Form7();
            ft.textBox1.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            ft.textBox2.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            ft.textBox3.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            ft.textBox5.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            ft.textBox6.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            ft.Show();
            this.Close();
        }
    }
}
