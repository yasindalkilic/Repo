using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Directory_Class_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string yol = @"C:\Users\Administrator\Desktop\Directory";
            Directory.CreateDirectory(yol);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string yol = @"C:\Users\Administrator\Desktop\Directory";
            //Directory.Delete(yol);//klasörü siler
            Directory.Delete(yol, true);//klasör ve alt klasör ve dosyalarını da siler
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string yol = @"C:\Users\Administrator\Desktop\Directory";
            //MessageBox.Show(Directory.Exists(yol).ToString());
            if (Directory.Exists(yol)) //klasörün belirtilen yolda olup olmadıgını kontrol eder.
            {
                MessageBox.Show("Klasör Var");
            }
            else
            {
                MessageBox.Show("Klasör yok");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string yol = @"C:\Users\Administrator\Desktop\Directory";
            MessageBox.Show(Directory.GetCreationTime(yol).ToShortDateString());//klasörün olusturuldugu tarih
            //MessageBox.Show(Directory.GetCreationTimeUtc(yol).ToShortTimeString());
            MessageBox.Show(Directory.GetCreationTime(yol).ToShortTimeString());//oluşturuldugu saati gösterir
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //string yol = @"C:\Users\Administrator\Desktop\Directory";
            MessageBox.Show(Directory.GetCurrentDirectory()); //Şuan Çalışan Projenin yolunu gösterir
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string yol=@"C:\Users\Administrator\Desktop";
            string[] klasör = Directory.GetDirectories(yol);//belirtilen yol daki tüm klasörleri string dizi ile geri dönderir
            foreach (string item in klasör)
            {
                MessageBox.Show(item.ToString());
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string yol = @"C:\Users\Administrator\Desktop\Directory";
            MessageBox.Show(Directory.GetLastAccessTime(yol).ToShortTimeString()); //en son hangi saatte eriştigini gösterir
            MessageBox.Show(Directory.GetLastAccessTime(yol).ToShortDateString()); //en son hangi tarihte eriştigini gösterir.
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string yol = @"C:\Users\Administrator\Desktop\Directory\12.txt";
            File.Delete(yol);//belirtilen yoldaki dosyayı siler 
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string yol = @"C:\Users\Administrator\Desktop\Directory\asd";
           
            MessageBox.Show(Directory.GetParent(yol).ToString());//bi üst dizinlerle birlikte yolu gösterir
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string yol = @"C:\Users\Administrator\Desktop\Directory\asd";
            MessageBox.Show(Directory.GetDirectoryRoot(yol).ToString());//en kök dizinin gösterir
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string yol = @"C:\Users\Administrator\Desktop\Directory\asd";
            MessageBox.Show(Directory.GetLastWriteTime(yol).ToShortDateString());//son yazılma zamanı gösterir
        }

        
    }
}
