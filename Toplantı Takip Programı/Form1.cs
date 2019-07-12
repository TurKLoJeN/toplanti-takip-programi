using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toplantı_Takip_Programı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti;
        OleDbCommand komut;
        OleDbDataAdapter da;

        void KisiListele()
        {
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=toplanti1.accdb");
            baglanti.Open();
            da = new OleDbDataAdapter("Select *From kayitlar", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KisiListele();

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "d/M/yyyy h:mm";

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string sorgu = "Insert into kayitlar (isim_soyisim,tarih,teslim_durumu,enstitu,oda) values (@isim_soyisim,@tarih,@teslim_durumu,@enstitu,@oda)";
            komut = new OleDbCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@isim_soyisim", textBox2.Text);
            komut.Parameters.AddWithValue("@tarih", Convert.ToString (dateTimePicker1.Text));
            komut.Parameters.AddWithValue("@teslim_durumu", comboBox1.Text);
            komut.Parameters.AddWithValue("@enstitu", comboBox2.Text);
            komut.Parameters.AddWithValue("@oda", comboBox3.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            KisiListele();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string sorgu = "Delete From kayitlar Where kayit_id=@kayit_id";
            komut = new OleDbCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@kayit_id", dataGridView1.CurrentRow.Cells[0].Value);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            KisiListele();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string sorgu = "Update kayitlar Set isim_soyisim=@isim_soyisim,tarih=@tarih,teslim_durumu=@teslim_durumu,enstitu=@enstitu,oda=@oda Where kayit_id=@kayit_id";
            komut = new OleDbCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@isim_soyisim", textBox2.Text);
            komut.Parameters.AddWithValue("@tarih", Convert.ToString(dateTimePicker1.Text));
            komut.Parameters.AddWithValue("@teslim_durumu", comboBox1.Text);
            komut.Parameters.AddWithValue("@enstitu", comboBox2.Text);
            komut.Parameters.AddWithValue("@oda", comboBox3.Text);
            komut.Parameters.AddWithValue("@kayit_id", Convert.ToInt32(textBox1.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            KisiListele();
        }

        private void DataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            comboBox2.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Ambiance_ThemeContainer1_Click(object sender, EventArgs e)
        {

        }
    }
}
