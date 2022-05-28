
namespace pabdexe3
{
    partial class Navigasi1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mahasiswaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prodiTIDataSet = new pabdexe3.ProdiTIDataSet();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mahasiswaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mahasiswaTableAdapter = new pabdexe3.ProdiTIDataSetTableAdapters.MahasiswaTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.mahasiswaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodiTIDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // prodiTIDataSet
            // 
            this.prodiTIDataSet.DataSetName = "ProdiTIDataSet";
            this.prodiTIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "No. Mahasiswa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Jenis Kelamin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Alamat Mahasiswa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "NIM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nama Mahasiswa";
            // 
            // mahasiswaBindingSource1
            // 
            this.mahasiswaBindingSource1.DataMember = "Mahasiswa";
            this.mahasiswaBindingSource1.DataSource = this.prodiTIDataSet;
            // 
            // mahasiswaTableAdapter
            // 
            this.mahasiswaTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("News706 BT", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(127, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(273, 39);
            this.label6.TabIndex = 22;
            this.label6.Text = "Data Mahasiswa";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pabdexe3.Properties.Resources.left_arrow;
            this.pictureBox1.Location = new System.Drawing.Point(61, 374);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahasiswaBindingSource1, "NIM", true));
            this.textBox1.Location = new System.Drawing.Point(277, 158);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 26);
            this.textBox1.TabIndex = 24;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahasiswaBindingSource2, "NIM", true));
            this.textBox2.Location = new System.Drawing.Point(277, 207);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(197, 26);
            this.textBox2.TabIndex = 25;
            // 
            // mahasiswaBindingSource2
            // 
            this.mahasiswaBindingSource2.DataMember = "Mahasiswa";
            this.mahasiswaBindingSource2.DataSource = this.prodiTIDataSet;
            // 
            // Navigasi1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(540, 431);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "Navigasi1";
            this.Text = "Binding Data";
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodiTIDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource mahasiswaBindingSource;
        private ProdiTIDataSet prodiTIDataSet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ProdiTIDataSetTableAdapters.MahasiswaTableAdapter mahasiswaTableAdapter;
        private System.Windows.Forms.BindingSource mahasiswaBindingSource1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.BindingSource mahasiswaBindingSource2;
    }
}