using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using kutuphaneBLL;
using kutuphaneEntity;
namespace kutuphaneUI
{
    public partial class PanelSecimEkrani : Form
    {
        public PanelSecimEkrani()
        {
            InitializeComponent();
        }
        //Üye Paneli
        private void button1_Click(object sender, EventArgs e)
        {
            UyePaneli yeni = new UyePaneli();
            yeni.Show();
        }
        
        //Emanet Paneli
        private void button2_Click(object sender, EventArgs e)
        {
            EmanetPaneli yeni = new EmanetPaneli();
            yeni.Show();
        }

        //Kitap Paneli
        private void button3_Click(object sender, EventArgs e)
        {
            KitapPaneli yeni = new KitapPaneli();
            yeni.Show();
        }

        //Grafik Paneli
        private void button4_Click(object sender, EventArgs e)
        {
            GrafikForm yeni = new GrafikForm();
            yeni.Show();
        }

        //Butonların renkleri düzenleniyor
        public void buttonOp(Button btn)
        {
            btn.BackColor = Color.FromArgb(200, Color.White);
        }

        //Load
        private void Form1_Load(object sender, EventArgs e)
        {
            EmanetBLL bll = new EmanetBLL();
            //Panel Seçim Formu her açıldığında günlük borç güncelleme metodu çağırılır
            bll.EmanetGunlukGuncelleme();

            buttonOp(button1);
            buttonOp(button2);
            buttonOp(button3);
            buttonOp(button4);

        }

        


        
    }
}
