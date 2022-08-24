using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartmanDeneme
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        public  string adres = @"Data Source=DESKTOP-EFQ7F2I;Initial Catalog = apartmandeneme; Integrated Security = True";
 
        private void button1_Click(object sender, EventArgs e)
        {
            string icerik = textBox2.Text;
            string baslik = textBox1.Text;
            int alicidr = Convert.ToInt32(comboBox1.Text);
            Yonetici.mailGonder(icerik, baslik,alicidr);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Anasayfa ana=new Anasayfa();
            ana.Show();
            this.Hide();
        }
        private void Form7_Load(object sender, EventArgs e)
        {
            string sorgu = "select d_no from Daireler";
            comboBox1.DisplayMember = "d_no";
            comboBox1.ValueMember = "d_no";
            comboBox1.DropDownHeight = 150;
            comboBox1.DataSource = Yonetici.Sorgu(sorgu, adres);


        }
        

        
    }
}
 