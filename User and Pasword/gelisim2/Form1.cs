using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace gelisim2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            SqlConnection baglan = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True;User Instance=True");
            baglan.Open();
            SqlCommand komut = new SqlCommand("select * from parola where ad=@ad AND sifre=@sifre",baglan);
            komut.Parameters.AddWithValue("@ad", textBox1.Text);
            komut.Parameters.AddWithValue("@sifre", textBox2.Text);
            SqlDataReader oku = komut.ExecuteReader();
            try
            {
                if (oku.Read())
                {

                    Form2 f = new Form2();
                    f.ShowDialog();



                }
               
            }
            catch (Exception ee)
            {

                MessageBox.Show(ee.ToString());
            }
           
            baglan.Close();
        }
    }
}
