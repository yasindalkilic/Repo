using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using excel = Microsoft.Office.Interop.Excel;

namespace excele_aktarım
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'dersDataSet.ders' table. You can move, or remove it, as needed.
            this.dersTableAdapter.Fill(this.dersDataSet.ders);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            excel.Application dosya = new excel.Application();//excel acar
            dosya.Visible = true;//exceli gösterir 
            object a =Type.Missing;
            excel.Workbook kitap = dosya.Workbooks.Add(a);//calısma sayfası olusturur.
            excel.Worksheet sayfa = (excel.Worksheet)kitap.Sheets[1];//calısma alanı çalısma sayfası 1 rakamı kacıncı sayfada calısacaksak
            int sutun = 1;//excele yazdıracagımız satır
            int satır = 1;//excele yazdıracagımız sutun
            for (int i = 0; i < dataGridView1.Columns.Count; i++)//5 alan varsa 5 dönecek
            {
                excel.Range hücre = (excel.Range)sayfa.Cells[satır, sutun + i];//alan hangi alan hücre biri sıfırdan digeri biroldugu için +2
                hücre.Value2 = dataGridView1.Columns[i].HeaderText;//alanın o degerine
            }
            satır++;
            for (int z = 0; z < dataGridView1.Rows.Count; z++)
            {
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    try
                    {
                        excel.Range hücre = (excel.Range)sayfa.Cells[satır + z, sutun + i];
                        hücre.Value2 = dataGridView1[i, z].Value;
                    }
                    catch (Exception AAA)
                    {

                        MessageBox.Show(AAA.ToString());
                    }
                    
                }
            }
        }

       
    }
}
