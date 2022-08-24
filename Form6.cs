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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
      

        


        private void button1_Click(object sender, EventArgs e)
        {
            string tur;
            if (radioButton1.Checked == true)
                tur = radioButton1.Text;
            else if (radioButton4.Checked == true)
                tur = textBox1.Text;
            else if (radioButton3.Checked == true)
                tur = radioButton3.Text;
            else
                tur = radioButton2.Text;

            int tutar =Convert.ToInt32(textBox2.Text);
            Yonetici yn=new Yonetici();
            yn.giderEkle(tur, tutar);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa=new Anasayfa();
            anasayfa.Show();
            this.Hide();

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
