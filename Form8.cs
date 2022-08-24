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
namespace ApartmanDeneme
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
      

        

        private void button2_Click(object sender, EventArgs e)
        {
            Anasayfa ana = new Anasayfa();
            ana.Show();
            this.Hide();

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            
            comboBox1.DropDownHeight = 125;
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            int d_no =Convert.ToInt32(comboBox1.SelectedItem);
            string ad = textBox1.Text;
            string soyad = textBox2.Text;
            string mail = textBox3.Text;
            Yonetici yn=new Yonetici();
            yn.kullaniciEkle(d_no, ad, soyad, mail);
            
        }

          
       
    }

}
