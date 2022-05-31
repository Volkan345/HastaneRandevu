using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;




namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
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


        private void Form1_Load(object sender, EventArgs e)
        {
            baglantiackapa();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 Kayıt = new Form2();
            Kayıt.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 Seç = new Form4();
            Seç.Show();
            this.Hide();
        }
    }
}
