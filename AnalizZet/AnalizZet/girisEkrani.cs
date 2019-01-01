using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalizZet
{
    public partial class girisEkrani : Form
    {
        public girisEkrani()
        {
            InitializeComponent();
        }
        Form1 form1;
        Form3 form3;
        string kayitYeri = "";
        string[] etiketDosyaAdi;
        private void veriSecBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog veriFile = new OpenFileDialog();
            veriFile.Filter = "Metin Dosyası |*.txt";
            veriFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (veriFile.ShowDialog() == DialogResult.OK)
            {
                veriYoluTxt.Text = veriFile.FileName;
                veriDosyaAdi.Text = veriFile.SafeFileName;
            }
        }

        private void videoBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog videoFile = new OpenFileDialog();
            videoFile.Filter = "Video Dosyası |*.mp4";
            videoFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (videoFile.ShowDialog() == DialogResult.OK)
            {
                videoTxt.Text = videoFile.FileName;
                videoDosyaAdi.Text = videoFile.SafeFileName;
            }
        }

        private void etiketBtn_Click(object sender, EventArgs e)
        {

            SaveFileDialog etiketliVeriFile = new SaveFileDialog();
            etiketliVeriFile.OverwritePrompt = true;
            etiketliVeriFile.CreatePrompt = true;
            etiketliVeriFile.Filter = "Metin Dosyası|*.txt|CSV Dosyası|*.csv";
            if (etiketliVeriFile.ShowDialog() == DialogResult.OK)
            {
                kayitYeri = etiketliVeriFile.FileName;
                etiketDosyaAdi = kayitYeri.Split('\\');
                kayitYeri = "";
                for (int i = 0; i < etiketDosyaAdi.Length - 1; i++)
                {
                    if(i == etiketDosyaAdi.Length-2)
                        kayitYeri += etiketDosyaAdi[i];
                    else
                        kayitYeri += etiketDosyaAdi[i] + "\\";
                }
                label7.Text = kayitYeri+"\\"+etiketDosyaAdi[etiketDosyaAdi.Length-1];
            }


        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (veriYoluTxt.Text != "-" && videoTxt.Text != "-" && kayitYeri != "")
            {
                form1 = new Form1();
                form1.veriYolu = veriYoluTxt.Text;
                form1.videoYolu = videoTxt.Text;
                form1.kayitYeri = kayitYeri;
                form1.etiketDosyaAdi = label7.Text;
                Form3.yol = veriYoluTxt.Text;
                this.Hide();
                form1.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Verinizi ve Videonuzu girdiğinizden emin olunuz ve etiketli veri için dosya adı girip kaydedilecek yeri seçiniz", "Bilgi", MessageBoxButtons.OKCancel);
            }
        }
    }
}
