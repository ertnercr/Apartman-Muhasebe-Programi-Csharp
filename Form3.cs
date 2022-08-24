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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public static string adres = @"Data Source=DESKTOP-EFQ7F2I;Initial Catalog = apartmandeneme; Integrated Security = True";

        SqlConnection bagla = new SqlConnection("Data Source=DESKTOP-EFQ7F2I;Initial Catalog = apartmandeneme; Integrated Security = True");
        

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string sorgu = "select d_no from Daireler";
            comboBox1.DisplayMember = "d_no";
            comboBox1.ValueMember = "d_no";
            comboBox1.DropDownHeight = 150;
            comboBox1.DataSource = Yonetici.Sorgu(sorgu, adres);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // bagla.Open();
            int d_no =Convert.ToInt32(comboBox1.Text);
            bool hata = false;
            int Tutar = Convert.ToInt32(textBox1.Text);
            Yonetici yn = new Yonetici();
            yn.ekbutceAl(d_no, hata, Tutar);

        }


        

        
    }
}
