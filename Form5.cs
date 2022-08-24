﻿using System;
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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        private static string adres = @"Data Source=DESKTOP-EFQ7F2I;Initial Catalog = apartmandeneme; Integrated Security = True";
        SqlConnection conn = new SqlConnection(adres);
    
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int daire = Convert.ToInt32(comboBox1.Text);
            SqlDataAdapter sda = new SqlDataAdapter($"Select d_no,tutar,tarih from Aidat where d_no={daire}", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }


        
        private void Form5_Load(object sender, EventArgs e)
        {
            string sorgu = "select d_no from Daireler";
            comboBox1.DisplayMember = "d_no";
            comboBox1.ValueMember = "d_no";
            comboBox1.DropDownHeight = 150;
            comboBox1.DataSource = Yonetici.Sorgu(sorgu, adres);
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
           
        }
        
        
        
       
    }
}
