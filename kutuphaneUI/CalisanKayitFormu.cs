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
    public partial class CalisanKayitFormu : Form
    {
        public CalisanKayitFormu()
        {
            InitializeComponent();
        }
        //Kayıt Ol butonu
        private void btnKayit_Click(object sender, EventArgs e)
        {
            try
            {
                CalisanBilgileri calisan = new CalisanBilgileri();
                //TextBox verileri nesneye aktarılır
                calisan.CALISAN_TCKNO = txtTCKNO.Text;
                calisan.CALISAN_SIFRE = txtSifre.Text;

                CalisanBLL bll = new CalisanBLL(); //BLL katmanından nesne üretilir ve metotlar oradan çağırılır

                bll.CalisanEkle(calisan); //bll nesnesi ile ekle metodu çağırılır
                MessageBox.Show("Kayıt Başarıyla Oluşturuldu!", "Başarılı!", MessageBoxButtons.OK);
                
                //Giriş Formu açılır, Kayıt Formu kapanır
                ProgramGirisSayfasi yeni = new ProgramGirisSayfasi();
                yeni.Show();
                Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        //Load
        private void CalisanKayitFormu_Load(object sender, EventArgs e)
        {
            //Bu kısım tasarım amaçlı renklendirmeler içermektedir
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            btnKayit.BackColor = Color.FromArgb(150, Color.Yellow);
            label4.BackColor = Color.Transparent;

            labelGiris.BackColor = Color.Transparent;
            labelGiris.ForeColor = Color.Yellow;
            
        }

        //Giriş Yap butonu
        private void labelGiris_Click(object sender, EventArgs e)
        {
            //Giriş Formu açılır, Kayıt Formu kapanır
            ProgramGirisSayfasi yeni = new ProgramGirisSayfasi();
            yeni.Show();
            Visible = false;
        }
    }
}
