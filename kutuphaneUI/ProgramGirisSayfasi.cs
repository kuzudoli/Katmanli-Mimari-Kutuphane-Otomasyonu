using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using kutuphaneEntity;
using kutuphaneBLL;
namespace kutuphaneUI
{
    public partial class ProgramGirisSayfasi : Form
    {
        public ProgramGirisSayfasi()
        {
            InitializeComponent();
        }

        //Giriş Butonu
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                CalisanBilgileri calisan = new CalisanBilgileri();
                //TextBox verileri nesneye aktarılır
                calisan.CALISAN_TCKNO = txtTCKNO.Text;
                calisan.CALISAN_SIFRE = txtSifre.Text;
                
                CalisanBLL bll = new CalisanBLL(); //BLL katmanından nesne üretilir ve metotlar oradan çağırılır
                
                int CalisanNo;
                CalisanNo = bll.CalisanAraNo(calisan); //Girilen TCKNO ve Şifreye uygun bir kullanıcı varsa numarası return edilir
                
                if (CalisanNo!=0) //No 0'dan farklıysa üye bulunmuştur
                {
                    MessageBox.Show("Giriş Başarılı!", "Başarılı!", MessageBoxButtons.OK);
                    PanelSecimEkrani yeni = new PanelSecimEkrani();
                    yeni.Show();
                    Visible = false;
                }
                if(CalisanNo==0) //0'a eşitse üye bulunamamıştır
                {
                    MessageBox.Show("Böyle bir kullanıcı bulunamadı!", "Hata", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            
        }

        //Kayıt Ol Butonu
        private void labelKayit_Click(object sender, EventArgs e)
        {
            //Kayıt Formu açılır ve Giriş Formu kapanır
            CalisanKayitFormu yeni = new CalisanKayitFormu();
            yeni.Show();
            Visible = false;
        }

        //Load
        private void ProgramGirisSayfasi_Load(object sender, EventArgs e)
        {
            //Bu kısım tasarım amaçlı renklendirmeler içermektedir
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            btnGirisYap.BackColor = Color.FromArgb(150, Color.LightGreen);

            labelKayit.BackColor = Color.Transparent;
            labelKayit.ForeColor = Color.Yellow;
        }
    }
}
