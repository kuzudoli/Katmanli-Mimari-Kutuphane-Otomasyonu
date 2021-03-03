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
using System.Windows.Forms;
namespace kutuphaneUI
{
    public partial class UyePaneli : Form
    {
        public UyePaneli()
        {
            InitializeComponent();
        }
        
        //Tablo düzenini sağlar
        public void TabloDuzenle(DataGridView dgv)
        {
            //Kolon başlıklarını değiştirir, görünüm oluşturur
            dgv.Columns["UYE_TCKNO"].HeaderText = "TCKNO";
            dgv.Columns["UYE_AD"].HeaderText = "Ad";
            dgv.Columns["UYE_SOYAD"].HeaderText = "Soyad";
            dgv.Columns["DOGUM_TARIHI"].HeaderText = "D. Tarihi";
            dgv.Columns["CINSIYET"].HeaderText = "Cinsiyet";
            dgv.Columns["TELEFON"].HeaderText = "Telefon";
            dgv.Columns["EMAIL"].HeaderText = "E-Posta";

            //Hücre boyutlandırma işlemleri
            for (int i = 0; i < 7; i++)
            {
                dgv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            
            dgv.AutoResizeColumns();
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        //Load
        private void UyePaneli_Load(object sender, EventArgs e)
        {
            //Sil ve Güncelle butonlarını inaktif duruma getirerek karşılacak sorunlar engellenir
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;

            //Bu kısım tasarım amaçlı renklendirmeler içermektedir
            btnGuncelle.BackColor = Color.Gray;
            btnGuncelle.ForeColor = Color.DarkGray;
            btnGuncelle.FlatAppearance.BorderColor = Color.DarkGray;

            btnSil.BackColor = Color.Gray;
            btnSil.ForeColor = Color.DarkGray;
            btnSil.FlatAppearance.BorderColor = Color.DarkGray;

            groupBox1.BackColor = Color.Transparent;
            groupBox2.BackColor = Color.Transparent;
            groupBox3.BackColor = Color.Transparent;
            groupBox4.BackColor = Color.Transparent;

            dataGridViewAra.ForeColor = Color.Black;
            dataGridViewSil.ForeColor = Color.Black;
        }

        //Üye Ekle Butonu
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Uye uye = new Uye();

            //Veri girişleri oluşturulan üye nesnesine aktarılır
            uye.UYE_AD = txtAd.Text.ToUpper();
            uye.UYE_SOYAD = txtSoyad.Text.ToUpper();
            uye.UYE_TCKNO = txtTckno.Text;

            if (radioErkek.Checked == true)
                uye.CINSIYET = "ERKEK";
            if (radioKadin.Checked == true)
                uye.CINSIYET = "KIZ";

            uye.DOGUM_TARIHI = txtDogumTarihi.Text;
            uye.TELEFON = txtTelefon.Text;
            uye.EMAIL = txtMail.Text;

            UyeBLL bll = new UyeBLL();
            try
            { 
                //BLL katmanı nesnesiyle ekle metodu çağırılır
                bll.UyeEkle(uye);
                MessageBox.Show("Üye eklendi!","Başarılı İşlem",MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen bilgileri kontrol ediniz!", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //Üye Ara Butonu
        private void btnAra_Click(object sender, EventArgs e)
        {
            Uye uye = new Uye();
            uye.UYE_TCKNO = txtTcknoAra.Text;

            UyeBLL bll = new UyeBLL();
            try
            {
                //dataGridView objesine veri kaynağı gösterilir
                dataGridViewAra.DataSource = bll.UyeAra(uye);
                
                TabloDuzenle(dataGridViewAra);

                //Tabloda satır yoksa üye bulunamadı uyarısı verir
                if (dataGridViewAra.RowCount == 0)
                    MessageBox.Show("Böyle bir üye bulunamadı!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen bilgileri kontrol ediniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //Üye Getir Butonu
        private void btnUyeGetir_Click(object sender, EventArgs e)
        {
            //uye nesnesi ile "nesne return eden" bir metot çağırılacağı için tmpUye nesnesi oluşturuldu
            Uye uye = new Uye();
            Uye tmpUye = new Uye();
            uye.UYE_TCKNO = txtTcknoGuncelleme.Text;

            UyeBLL bll = new UyeBLL();
            try
            {
                //return edilen nesne tmpUye ile eşleştirildi
                tmpUye = bll.UyeAra2(uye);
                txtAdGuncelleme.Text = tmpUye.UYE_AD;
                txtSoyadGuncelleme.Text = tmpUye.UYE_SOYAD;
                if (tmpUye.CINSIYET == "ERKEK")
                    radioErkekGuncelleme.Checked = true;
                if (tmpUye.CINSIYET == "KIZ")
                    radioKadinGuncelleme.Checked = true;
                txtDogumTarihiGuncelleme.Text = tmpUye.DOGUM_TARIHI;
                txtTelefonGuncelleme.Text = tmpUye.TELEFON;
                txtMailGuncelleme.Text = tmpUye.EMAIL;

                //Uye Adı alanı boş ise bulunamadı uyarısı verir
                if (tmpUye.UYE_AD == null)
                {
                    MessageBox.Show("Böyle bir üye bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //Güncelleme butonu inaktif olur böylece hata çıkmasını önler
                    btnGuncelle.Enabled = false;
                    btnGuncelle.BackColor = Color.Gray;
                    btnGuncelle.ForeColor = Color.DarkGray;
                    btnGuncelle.FlatAppearance.BorderColor = Color.DarkGray;
                }
                else
                {
                    //Eğer üye bulunursa güncelleme butonu aktifleşir
                    btnGuncelle.Enabled = true;
                    btnGuncelle.BackColor = Color.Honeydew;
                    btnGuncelle.ForeColor = Color.DarkGreen;
                    btnGuncelle.FlatAppearance.BorderColor = Color.DarkGreen;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen bilgileri kontrol ediniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //Güncelle Butonu 
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Uye uye = new Uye();
            //Veri girişleri oluşturulan üye nesnesine aktarılır
            uye.UYE_AD = txtAdGuncelleme.Text.ToUpper();
            uye.UYE_SOYAD = txtSoyadGuncelleme.Text.ToUpper();
            uye.UYE_TCKNO = txtTcknoGuncelleme.Text;
            if (radioErkekGuncelleme.Checked == true)
                uye.CINSIYET = "ERKEK";
            if (radioKadinGuncelleme.Checked == true)
                uye.CINSIYET = "KIZ";
            uye.DOGUM_TARIHI = txtDogumTarihiGuncelleme.Text;
            uye.TELEFON = txtTelefonGuncelleme.Text;
            uye.EMAIL = txtMailGuncelleme.Text;

            UyeBLL bll = new UyeBLL();
            try
            {
                //BLL katmanı nesnesiyle güncelle metodu çağırılır
                bll.UyeGuncelle(uye);
                MessageBox.Show("Başarıyla güncellendi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen bilgileri kontrol ediniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //Silmek İşlemi İçin Kullanılan Arama Butonu
        private void btnAraSil_Click(object sender, EventArgs e)
        {
            Uye uye = new Uye();
            uye.UYE_TCKNO = txtTcknoSil.Text;

            UyeBLL bll = new UyeBLL();
            try
            {
                //dataGridView objesine veri kaynağı gösterilir
                dataGridViewSil.DataSource = bll.UyeAra(uye);
                TabloDuzenle(dataGridViewSil);

                //Uygun üye bulunamazsa uyarı verir
                if (dataGridViewSil.RowCount == 0)
                {
                    MessageBox.Show("Böyle bir üye bulunamadı!");
                    //Silme butonu inaktif olur böylece hata çıkmasını önler
                    btnSil.Enabled = false;
                    btnSil.BackColor = Color.Gray;
                    btnSil.ForeColor = Color.DarkGray;
                    btnSil.FlatAppearance.BorderColor = Color.DarkGray;
                }
                //Bulunursa
                else
                {
                    //Silme butonu aktifleşir
                    btnSil.Enabled = true;
                    btnSil.BackColor = Color.MistyRose;
                    btnSil.ForeColor = Color.Red;
                    btnSil.FlatAppearance.BorderColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen bilgileri kontrol ediniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            
            try
            {
                Uye uye = new Uye();
                uye.UYE_TCKNO = txtTcknoSil.Text;

                UyeBLL bll = new UyeBLL();
                //BLL katmanı nesnesiyle sil metodu çağırılır
                bll.UyeSil(uye);
                MessageBox.Show("Başarıyla silindi!");
                dataGridViewSil.DataSource = null;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Silmek istediğiniz Üye Emanet Listesinde yer almaktadır. Silinemez!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        //Kayıtlı tüm üyeleri listeler
        private void btnTumUyeler_Click(object sender, EventArgs e)
        {
            TümUyeListesi yeniPencere = new TümUyeListesi();
            yeniPencere.Show();
            UyeBLL bll = new UyeBLL();
            try
            {
                //BLL katmanı nesnesi ile dataGridView objesine veri kaynağı gösterilir
                yeniPencere.dataGridTumUyeler.DataSource = bll.TumUyeleriListele();
                TabloDuzenle(yeniPencere.dataGridTumUyeler);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
