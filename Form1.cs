using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartmanDeneme
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }
        public static SqlConnection conn = new SqlConnection();
        
        public static string adres= @"Data Source = DESKTOP - EFQ7F2I; Initial Catalog = apartmandeneme; Integrated Security = True";


        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void Giderler_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
            this.Hide();

        }

        private void mailat_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            

        }
    }
}
