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

        private void veriSecBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog veriFile = new OpenFileDialog();
            veriFile.Filter = "Metin Dosyası |*.txt";
            veriFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if(veriFile.ShowDialog() == DialogResult.OK)
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

            }
        }

        private void girisEkrani_Load(object sender, EventArgs e)
        {

        }

        private void girisEkrani_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Close();
        }
    }
}
