using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=kayıtlar;Uid=root;Pwd=123456;");


        void baglantiackapa()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                else if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
                if (baglanti.State == ConnectionState.Open)
                {
                    MessageBox.Show("bağlantı açıldı");
                }
                else
                {
                    MessageBox.Show("bağlantı kapatıldı");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("hata meydana geldi. Hata:" + ex.Message.ToString());








            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            
            try 
            {
                baglanti.Open();
                MySqlCommand komut = new MySqlCommand();
                komut.CommandText =" insert into kisiler(isim,Soyisim,TcNo,cinsiyet)"+"values("+textBox1.Text+","+textBox2.Text +","+textBox3.Text + "," + comboBox1.Text+")";
                komut.Connection = baglanti;
                komut.ExecuteNonQuery();

                MessageBox.Show("Veri Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception hata)
            {
                MessageBox.Show("hata Meydana GEldi. Hata:" + hata.Message.ToString());
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 Giriş = new Form1();
            Giriş.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            baglantiackapa();
        }
    }
}
