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
    public partial class EmanetPaneli : Form
    {
        public EmanetPaneli()
        {
            InitializeComponent();
        }
        //Kitap Tablosunun düzenini sağlar
        public void TabloDuzenleKitap(DataGridView dgv)
        {
            //Kolon başlıklarını değiştirir, görünüm oluşturur
            dgv.Columns["KITAP_NO"].HeaderText = "Kitap No:";
            dgv.Columns["KITAP_ADI"].HeaderText = "Kitap Adı";
            dgv.Columns["KITAP_YAZAR"].HeaderText = "Yazar";
            dgv.Columns["TUR"].HeaderText = "Tür";
            dgv.Columns["SAYFA_SAYISI"].HeaderText = "Sayfa S.";
            dgv.Columns["BASIM_YILI"].HeaderText = "Basım Yılı";
            dgv.Columns["KITAP_YAYINEVI"].HeaderText = "Yayinevi";
            dgv.Columns["KITAP_DURUMU"].HeaderText = "E. Durumu";
            dgv.Columns.Remove("ToplamKitap");
            dgv.Columns.Remove("HazirKitapSayisi");
            dgv.Columns.Remove("HazirOlmayanKitapSayisi");
            //Hücre boyutlandırma işlemleri
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        //Emanet Tablosunun düzenini sağlar
        public void TabloDuzenleEmanet(DataGridView dgv)
        {
            //Kolon başlıklarını değiştirir, görünüm oluşturur
            dgv.Columns["EMANET_NO"].HeaderText = "Emanet No";
            dgv.Columns["UYE_TCKNO"].HeaderText = "TCKNO";
            dgv.Columns["UYE_AD"].HeaderText = "Ad";
            dgv.Columns["UYE_SOYAD"].HeaderText = "Soyad";
            dgv.Columns["KITAP_NO"].HeaderText = "Kitap No";
            dgv.Columns["KITAP_ADI"].HeaderText = "Kitap Adı";
            dgv.Columns["KITAP_YAZAR"].HeaderText = "Yazar";
            dgv.Columns["KITAP_DURUMU"].HeaderText = "E. Durumu";
            dgv.Columns["EMANET_TARIHI"].HeaderText = "Emanet Tarihi";
            dgv.Columns["SON_TESLIM_TARIHI"].HeaderText = "Son Teslim Tarihi";
            dgv.Columns["TESLIM_TARIHI"].HeaderText = "Teslim Tarihi";
            dgv.Columns["TESLIM_DURUMU"].HeaderText = "Teslim Durumu";
            dgv.Columns["BORC"].HeaderText = "Borç";

            //Hücre boyutlandırma işlemleri
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        //Load
        private void EmanetPaneli_Load(object sender, EventArgs e)
        {
            //Hataların önüne geçmek için teslim et butonu inaktif hale getirilir
            btnTeslimEt.Enabled = false;

            //Bu kısım tasarım amaçlı renklendirmeler içermektedir
            btnTeslimEt.BackColor = Color.Gray;
            btnTeslimEt.ForeColor = Color.DarkGray;
            btnTeslimEt.FlatAppearance.BorderColor = Color.DarkGray;

            groupBox1.BackColor = Color.Transparent;
            groupBox2.BackColor = Color.Transparent;

            dataGridViewAra.ForeColor = Color.Black;
        }

        int KitapNo;
        
        //Emanet Kaydı İçin Kitap Seç Butonu
        private void btnKitapSec_Click(object sender, EventArgs e)
        {
            //Kitap Seçim Paneli Formu açılır
            KitapSecimPaneli yeniForm = new KitapSecimPaneli();
            yeniForm.Show();
            KitapBLL bll = new KitapBLL();
            try
            {
                //dataGridView objesine veri kaynağı gösterilir
                yeniForm.dataGridKitapSecim.DataSource = bll.HazırKitaplariListele();
                TabloDuzenleKitap(yeniForm.dataGridKitapSecim);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //Emanet Kayıt Butonu
        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Uye uye = new Uye();
                uye.UYE_TCKNO = txtTCKNO.Text;
                //Nesne eşleştirmesi için tmpUye nesnesi oluşturulur
                Uye tmpUye = new Uye();
                UyeBLL uyeBLL = new UyeBLL();
                tmpUye = uyeBLL.UyeAra2(uye); //return edilen nesne eşleştirildi

                //Üye Adı alanı boş ise bulunamadı uyarısı verir
                if (tmpUye.UYE_AD == null)
                {
                    MessageBox.Show("Kayıtlı üye bulunamadı, TCKNO'yu kontrol ediniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Emanet emanet = new Emanet();
                    emanet.UYE_TCKNO = txtTCKNO.Text;
                    emanet.KITAP_NO = Convert.ToInt32(kitapNoLabel.Text);
                    emanet.KITAP_DURUMU = "EMANETTE";//Emanet kaydı sırasında Kitap Durumu'da değiştirilir
                    EmanetBLL bll = new EmanetBLL();
                    //BLL katmanı nesnesiyle ekle ve kitap guncelle metodu çağırılır
                    bll.EmanetEkle(emanet);
                    bll.EmanetKitapGuncelleme(emanet);
                    MessageBox.Show("Kayıt oluşturuldu!", "Başarılı!", MessageBoxButtons.OK);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen bilgileri kontrol ediniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        //Emanet Ara Butonu
        private void btnAra_Click(object sender, EventArgs e)
        {
            try
            {
                Emanet emanet = new Emanet();
                EmanetBLL bll = new EmanetBLL();
                emanet.UYE_TCKNO = txtAraTckno.Text;
                //BLL katmanı nesnesiyle dataGridView objesine veri kaynağı gösterilir
                dataGridViewAra.DataSource = bll.EmanetAra(emanet);
                TabloDuzenleEmanet(dataGridViewAra);

                //Uygun emanet bulunamazsa uyarı verir
                if (dataGridViewAra.RowCount == 0)
                {
                    MessageBox.Show("Aradığınız emanet kaydı bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //Kayıt bulunamazsa emanet et butonu inaktif olacaktır
                    btnTeslimEt.Enabled = false;
                    btnTeslimEt.BackColor = Color.Gray;
                    btnTeslimEt.ForeColor = Color.DarkGray;
                    btnTeslimEt.FlatAppearance.BorderColor = Color.DarkGray;
                }
                else
                {
                    //Kayıt bulunursa emanet et butonu aktif olacaktır
                    btnTeslimEt.Enabled = true;
                    btnTeslimEt.BackColor = Color.Honeydew;
                    btnTeslimEt.ForeColor = Color.DarkGreen;
                    btnTeslimEt.FlatAppearance.BorderColor = Color.DarkGreen;

                    //Emanetlerin teslim durumlarına göre satır rengi değiştirilir
                    for (int i = 0; i < dataGridViewAra.Rows.Count; i++)
                    {
                        TimeSpan zamanFarki = DateTime.Now - Convert.ToDateTime(dataGridViewAra.Rows[i].Cells["SON_TESLIM_TARIHI"].Value.ToString());
                        double gun = zamanFarki.TotalDays;

                        //Teslim tarihine 2 gün kalanlar sarı
                        if ((gun <= 0) && (gun >= -2))
                            dataGridViewAra.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;

                        //Teslim edilenler yeşil
                        if (dataGridViewAra.Rows[i].Cells["TESLIM_DURUMU"].Value.ToString() == "TESLİM EDİLDİ")
                            dataGridViewAra.Rows[i].DefaultCellStyle.BackColor = Color.Green;

                        //Teslim edilmeyenler kırmızı
                        if (dataGridViewAra.Rows[i].Cells["TESLIM_DURUMU"].Value.ToString() == "TESLİM EDİLMEDİ")
                            dataGridViewAra.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    }
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen bilgileri kontrol ediniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        //Kitap Teslimi için gerekli bilgilerin tutulmasını sağlamak adına iki adet tmp değişken oluşturulur
        int tmpEmanetNo;
        int tmpKitapNo;
        string tmpTeslimDurumu;
        //Tablodan emanet seçimi yapmaya olanak sağlar
        private void dataGridViewAra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Seçilen satırın gerekli alanlarını tmp değişkenlere aktarır
                DataGridViewRow row = this.dataGridViewAra.Rows[e.RowIndex];
                //Teslim edilmiş bir kitabın tekrar teslim edilmemesi için gerekli kontrol yapılıyor
                if (row.Cells["TESLIM_DURUMU"].Value.ToString() == "TESLİM EDİLDİ")
                {
                    MessageBox.Show("Bu emanet teslim edilmiş, lütfen başka bir emanet kaydı seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tmpTeslimDurumu = "TESLİM EDİLDİ";
                }
                else
                {
                    //Aynı işlem tekrarlandığında hatayı engellemek için temizleniyor
                    tmpTeslimDurumu = "";
                    tmpEmanetNo = Convert.ToInt32(row.Cells["EMANET_NO"].Value);
                    tmpKitapNo = Convert.ToInt32(row.Cells["KITAP_NO"].Value);
                }
                
            }
        }

        //Teslim Et Butonu
        private void btnTeslimEt_Click(object sender, EventArgs e)
        {
            try
            {
                //Seçilen emanet kaydı teslim edildiyse uyarı vericektir
                if (tmpTeslimDurumu == "TESLİM EDİLDİ")
                {
                    MessageBox.Show("Bu emanet teslim edilmiş, lütfen başka bir emanet kaydı seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Emanet emanet = new Emanet();
                    emanet.EMANET_NO = tmpEmanetNo;
                    emanet.KITAP_NO = tmpKitapNo;
                    emanet.TESLIM_DURUMU = "TESLİM EDİLDİ";
                    emanet.KITAP_DURUMU = "HAZIR";
                    emanet.TESLIM_TARIHI = DateTime.Today.Date.ToString(); //Teslim Tarihi = Sistem Tarihi
                    EmanetBLL bll = new EmanetBLL();
                    //BLL katmanı nesnesiyle önce teslim işlemi yapılır daha sonra da teslim edilen kitabın durumu güncellenir
                    bll.EmanetTeslim(emanet);
                    bll.EmanetKitapGuncelleme(emanet);
                    MessageBox.Show("Kitap teslim edildi!", "Başarılı", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen bilgileri kontrol ediniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //Tüm Emanetlerin Listesi Butonu
        private void btnTumEmanetler_Click(object sender, EventArgs e)
        {
            //Tüm Emanetler Listesi Formu açılır
            TumEmanetlerListesi yeniForm = new TumEmanetlerListesi();
            yeniForm.Show();
            EmanetBLL bll = new EmanetBLL();
            try
            {
                //BLL katmanı nesnesiyle dataGridView objesine veri kaynağı gösterilir
                yeniForm.dataGridViewTumEmanetler.DataSource = bll.TumEmanetleriListele();
                TabloDuzenleEmanet(yeniForm.dataGridViewTumEmanetler);

                //Hücre boyut ayarları
                yeniForm.dataGridViewTumEmanetler.Columns[0].Width = 40;
                yeniForm.dataGridViewTumEmanetler.Columns[1].Width = 120;
                yeniForm.dataGridViewTumEmanetler.Columns[2].Width = 80;
                yeniForm.dataGridViewTumEmanetler.Columns[3].Width = 80;
                yeniForm.dataGridViewTumEmanetler.Columns[4].Width = 40;
                yeniForm.dataGridViewTumEmanetler.Columns[5].Width = 150;
                yeniForm.dataGridViewTumEmanetler.Columns[6].Width = 120;

                //Emanetlerin teslim durumlarına göre satır rengi değiştirilir
                for (int i = 0; i < yeniForm.dataGridViewTumEmanetler.Rows.Count; i++)
                {
                    TimeSpan zamanFarki = DateTime.Now - Convert.ToDateTime(yeniForm.dataGridViewTumEmanetler.Rows[i].Cells["SON_TESLIM_TARIHI"].Value.ToString());
                    double gun = zamanFarki.TotalDays;

                    //Teslim tarihine 2 gün kalanlar sarı
                    if ((gun <= 0) && (gun >= -2))
                        yeniForm.dataGridViewTumEmanetler.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;

                    //Teslim edilenler yeşil
                    if (yeniForm.dataGridViewTumEmanetler.Rows[i].Cells["TESLIM_DURUMU"].Value.ToString() == "TESLİM EDİLDİ")
                        yeniForm.dataGridViewTumEmanetler.Rows[i].DefaultCellStyle.BackColor = Color.Green;

                    //Teslim edilmeyenler kırmızı
                    if (yeniForm.dataGridViewTumEmanetler.Rows[i].Cells["TESLIM_DURUMU"].Value.ToString() == "TESLİM EDİLMEDİ")
                        yeniForm.dataGridViewTumEmanetler.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen bilgileri kontrol ediniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

    }
}
