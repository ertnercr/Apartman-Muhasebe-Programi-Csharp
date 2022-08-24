using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

using Baseline.ImTools;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Net.Mail;

namespace ApartmanDeneme
{
    internal class Yonetici
    {

        public static string adres = @"Data Source=DESKTOP-EFQ7F2I;Initial Catalog = apartmandeneme; Integrated Security = True";

        SqlConnection bagla = new SqlConnection("Data Source=DESKTOP-EFQ7F2I;Initial Catalog = apartmandeneme; Integrated Security = True");



        public void aidatAl(int d_no,bool hata,int Tutar)
        {
            bagla.Open();

            try 
            {
                SqlCommand kontrol = new SqlCommand($"select ad from daireler where d_no={d_no} ", bagla);
                string isim = (string)kontrol.ExecuteScalar();

            }
            catch 
            {

                
                hata = true;
            }


            if (hata == false)
            {
                
                

                SqlCommand gonder = new SqlCommand($"insert into Aidat(d_no,tutar) Values({d_no},{Tutar})", bagla);
                gonder.ExecuteNonQuery();
                bagla.Close();
                MessageBox.Show("Başarılı Bir Şekilde Eklendi.");
            }

            else
            {
                MessageBox.Show("Seçtiğiniz daire boş olduğu için kaydedilmedi.");
                bagla.Close();
            }




        }
        public static DataTable Sorgu(string sorgu, string adres)
        {
            SqlDataAdapter sda = new SqlDataAdapter(sorgu, adres);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public void ekbutceAl(int d_no,bool hata,int Tutar)
        {
            bagla.Open();
            try
            {

                SqlCommand kontrol = new SqlCommand($"select ad from daireler where d_no={d_no} ", bagla);
                string isim = (string)kontrol.ExecuteScalar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                hata = true;
            }
            if (hata == false)
            {



                SqlCommand gonder = new SqlCommand($"insert into EkButce(d_no,tutar) Values({d_no},{Tutar})", bagla);
                gonder.ExecuteNonQuery();
                bagla.Close();
                MessageBox.Show("Başarılı Bir Şekilde Eklendi.");
            }

            else
            {
                MessageBox.Show("Seçtiğiniz daire boş olduğu için kaydedilmedi.");
                bagla.Close();
            }



        }


       
        public static void mailGonder(string icerik, string baslik,int alicidr)
        {

            string sorgu = $"Select mail from daireler where d_no={alicidr}";
            SqlConnection conn = new SqlConnection(adres);
            conn.Open();
            SqlCommand com = new SqlCommand(sorgu, conn);
            string alicimail = (string)com.ExecuteScalar();
            conn.Close();



            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("eracar-ertan@hotmail.com");
            mail.To.Add(alicimail);
            mail.Subject = baslik;
            mail.Body = icerik;
            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new System.Net.NetworkCredential("eracar-ertan@hotmail.com", "Apartmanmuhasebe");
            smtp.Port = 587;
            smtp.Host = "smtp-mail.outlook.com";
            smtp.EnableSsl = true;
            smtp.Send(mail);

            MessageBox.Show("Mail Gönderildi.");

        }



        public void kullaniciEkle(int d_no,string ad,string soyad,string mail)
        {


            if (mail.Contains("gmail.com") == false && mail.Contains("hotmail.com") == false && mail.Contains("") == false)
            {

                MessageBox.Show("Lütfen Doğru bir mail girin.");
            }
            else
            {

                bagla.Open();

                SqlCommand silinenitasi = new SqlCommand($"insert into eskiler (d_no,ad,soyad,tutar,tarih) select aidat.d_no, ad, soyad, tutar, tarih from daireler, aidat where aidat.d_no = Daireler.d_no and aidat.d_no ={d_no}", bagla);
                silinenitasi.ExecuteNonQuery();

                SqlCommand eskiyiSil = new SqlCommand($"Delete from daireler where d_no={d_no}", bagla);
                eskiyiSil.ExecuteNonQuery();
                eskiyiSil.Dispose();
                if (mail == "")
                {
                    SqlCommand gonder = new SqlCommand($"insert into daireler(d_no,ad,soyad,mail) values({d_no},'{ad}','{soyad}','apartmandeneme@gmail.com')", bagla);


                    gonder.ExecuteNonQuery();
                }

                else if (mail != "")
                {
                    SqlCommand gonder = new SqlCommand($"insert into daireler(d_no,ad,soyad,mail) values({d_no},'{ad}','{soyad}','{mail}')", bagla);
                    gonder.ExecuteNonQuery();

                }
                bagla.Close();
                MessageBox.Show("Seçtiğiniz daire sahibi başarıyla güncellendi.");
            }

        }
        public void giderEkle(string tur,int tutar)
        {

            bagla.Open();
            SqlCommand cmd = new SqlCommand($"insert into giderler(gider,tutar) values ('{tur}',{tutar})", bagla);
            cmd.ExecuteNonQuery();
            bagla.Close();
            MessageBox.Show("Gider Başarıyla Eklendi.");

        }


        


    }
}
