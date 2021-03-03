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
    public partial class KitapPaneli : Form
    {
        //1488; 1000
        
        public KitapPaneli()
        {
            InitializeComponent();
        }
        public void TabloDuzenle(DataGridView dgv)
        {
            dgv.Columns["KITAP_NO"].HeaderText = "No";
            dgv.Columns["KITAP_ADI"].HeaderText = "Kitap Adı";
            dgv.Columns["KITAP_YAZAR"].HeaderText = "Yazar";
            dgv.Columns["TUR"].HeaderText = "Tür";
            dgv.Columns["SAYFA_SAYISI"].HeaderText = "Sayfa S.";
            dgv.Columns["BASIM_YILI"].HeaderText = "Basım Yılı";
            dgv.Columns["KITAP_YAYINEVI"].HeaderText = "Yayınevi";
            dgv.Columns["KITAP_DURUMU"].HeaderText = "E. Durumu";
            dgv.Columns.Remove("ToplamKitap");
            dgv.Columns.Remove("HazirKitapSayisi");
            dgv.Columns.Remove("HazirOlmayanKitapSayisi");
            for (int i = 0; i < 7; i++)
            {
                dgv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            
        }

        //Kitap Ekle
        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Kitap kitap = new Kitap();
                kitap.KITAP_ADI = txtAd.Text.ToUpper();
                kitap.KITAP_YAZAR = txtYazar.Text.ToUpper();
                kitap.TUR = comboTur.SelectedItem.ToString();
                kitap.SAYFA_SAYISI = txtSayfa.Text;
                kitap.BASIM_YILI = txtBasimYili.Text;
                kitap.KITAP_YAYINEVI = txtYayinevi.Text.ToUpper();

                KitapBLL bll = new KitapBLL();
                bll.KitapEkle(kitap);
                MessageBox.Show("Kitap eklendi!", "Başarılı İşlem", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen bilgileri kontrol ediniz!", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        //Kitap Ara
        private void btnAra_Click(object sender, EventArgs e)
        {
            try
            {
                Kitap kitap = new Kitap();
                kitap.KITAP_ADI = txtAdAra.Text;
                kitap.KITAP_YAZAR = txtYazarAra.Text;
                kitap.KITAP_YAYINEVI = txtYayineviAra.Text;

                KitapBLL bll = new KitapBLL();
                //Hangi arama opsiyonu seçilmiş ise ona uygun metod çağırılıyor
                if (txtAdAra.Enabled == true)
                    dataGridViewAra.DataSource = bll.KitapAra(kitap);

                if (txtYazarAra.Enabled == true)
                    dataGridViewAra.DataSource = bll.KitapAraYazar(kitap);

                if (txtYayineviAra.Enabled == true)
                    dataGridViewAra.DataSource = bll.KitapAraYayinevi(kitap);

                TabloDuzenle(dataGridViewAra);

                if (dataGridViewAra.RowCount == 0)
                    MessageBox.Show("Aradığınız kitap bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen bilgileri kontrol ediniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
             
        }

        //Kitap Güncellemek için Kitap Getir
        private void btnKitapGetir_Click(object sender, EventArgs e)
        {
            Kitap kitap = new Kitap();
            Kitap tmpKitap = new Kitap();
            if (txtKitapNoGuncelleme.Text == "")
            {
                MessageBox.Show("Lütfen bir kitap numarası giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                kitap.KITAP_NO = Convert.ToInt32(txtKitapNoGuncelleme.Text);
                KitapBLL bll = new KitapBLL();
                try
                {
                    kitap = bll.KitapAraNo(kitap);

                    txtAdGuncelle.Text = kitap.KITAP_ADI;
                    txtYazarGuncelle.Text = kitap.KITAP_YAZAR;
                    txtYayineviGuncelle.Text = kitap.KITAP_YAYINEVI;
                    txtBasimYiliGuncelle.Text = kitap.BASIM_YILI;
                    txtSayfaGuncelle.Text = kitap.SAYFA_SAYISI;
                    comboTurGuncelle.SelectedItem = kitap.TUR;

                    if (kitap.KITAP_ADI == null)
                    {
                        MessageBox.Show("Aradığınız kitap bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        //Bulunamaz ise Güncelle butonu pasif hale geliyor
                        btnGuncelle.Enabled = false;
                        btnGuncelle.BackColor = Color.Gray;
                        btnGuncelle.ForeColor = Color.DarkGray;
                        btnGuncelle.FlatAppearance.BorderColor = Color.DarkGray;
                    }
                    else
                    {
                        //Bulunur ise Güncelle butonu aktif hale geliyor
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
            
        }

        //Kitap Arama işlemi için opsiyon1
        private void txtAdAra_TextChanged(object sender, EventArgs e)
        {
            txtYazarAra.Enabled = false;
            txtYayineviAra.Enabled = false;
            labelYazar.Enabled = false;
            labelYayinevi.Enabled = false;
            if (txtAdAra.Text == "")
            {
                txtYazarAra.Enabled = true;
                txtYayineviAra.Enabled = true;
                labelYazar.Enabled = true;
                labelYayinevi.Enabled = true;
            }
        }
        //Kitap Arama işlemi için opsiyon2
        private void txtYazarAra_TextChanged(object sender, EventArgs e)
        {
            txtAdAra.Enabled = false;
            txtYayineviAra.Enabled = false;
            labelAd.Enabled = false;
            labelYayinevi.Enabled = false;
            if (txtYazarAra.Text == "")
            {
                txtAdAra.Enabled = true;
                txtYayineviAra.Enabled = true;
                labelAd.Enabled = true;
                labelYayinevi.Enabled = true;
            }
        }
        //Kitap Arama işlemi için opsiyon3
        private void txtYayineviAra_TextChanged(object sender, EventArgs e)
        {
            txtYazarAra.Enabled = false;
            txtAdAra.Enabled = false;
            labelYazar.Enabled = false;
            labelAd.Enabled = false;
            if (txtYayineviAra.Text == "")
            {
                txtYazarAra.Enabled = true;
                txtAdAra.Enabled = true;
                labelYazar.Enabled = true;
                labelAd.Enabled = true;
            }
        }

        //Kitap Güncelle
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Kitap kitap = new Kitap();
            kitap.KITAP_NO = Convert.ToInt32(txtKitapNoGuncelleme.Text);

            kitap.KITAP_ADI = txtAdGuncelle.Text.ToUpper();
            kitap.KITAP_YAZAR = txtYazarGuncelle.Text.ToUpper();
            kitap.TUR = comboTurGuncelle.SelectedItem.ToString();
            kitap.SAYFA_SAYISI = txtSayfaGuncelle.Text;
            kitap.BASIM_YILI = txtBasimYiliGuncelle.Text;
            kitap.KITAP_YAYINEVI = txtYayineviGuncelle.Text.ToUpper();

            try
            {
                KitapBLL bll = new KitapBLL();
                bll.KitapGuncelle(kitap);
                MessageBox.Show("Kitap güncellendi!", "Başarılı İşlem", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen bilgileri kontrol ediniz!", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //Kitap Silmek için Ara
        private void btnAraSil_Click(object sender, EventArgs e)
        {
            try
            {
                Kitap kitap = new Kitap();
                kitap.KITAP_NO = Convert.ToInt32(txtKitapNoSil.Text);

                KitapBLL bll = new KitapBLL();
                List<Kitap> kitapListe = new List<Kitap>();

                kitap = bll.KitapAraNo(kitap);
                kitapListe.Add(kitap);


                if (kitap.KITAP_ADI == null)
                {
                    MessageBox.Show("Aradığınız kitap bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //Bulunamaz ise Sil butonu pasif hale geliyor
                    btnSil.Enabled = false;
                    btnSil.BackColor = Color.Gray;
                    btnSil.ForeColor = Color.DarkGray;
                    btnSil.FlatAppearance.BorderColor = Color.DarkGray;
                }
                else
                {
                    //Bulunur ise Sil butonu aktif hale geliyor
                    dataGridViewSil.DataSource = kitapListe;
                    TabloDuzenle(dataGridViewSil);
                    btnSil.Enabled = true;
                    btnSil.BackColor = Color.MistyRose;
                    btnSil.ForeColor = Color.Red;
                    btnSil.FlatAppearance.BorderColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen bilgileri kontrol ediniz!", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //Kitap Sil
        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                Kitap kitap = new Kitap();
                kitap.KITAP_NO = Convert.ToInt32(txtKitapNoSil.Text);

                KitapBLL bll = new KitapBLL();
                bll.KitapSil(kitap);
                MessageBox.Show("Kitap silindi!", "Başarılı İşlem", MessageBoxButtons.OK);
                dataGridViewSil.DataSource = null;   
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silmek istediğiniz Kitap Emanet Listesinde yer almaktadır. Silinemez!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //Load
        private void KitapPaneli_Load(object sender, EventArgs e)
        {
            //Başlangıçta Güncelle ve Sil butonları pasif hale getirilir
            
            btnGuncelle.Enabled = false;
            btnGuncelle.BackColor = Color.Gray;
            btnGuncelle.ForeColor = Color.DarkGray;
            btnGuncelle.FlatAppearance.BorderColor = Color.DarkGray;

            btnSil.Enabled = false;
            btnSil.BackColor = Color.Gray;
            btnSil.ForeColor = Color.DarkGray;
            btnSil.FlatAppearance.BorderColor = Color.DarkGray;

            //Stil değişiklikleri yapılır
            groupBox1.BackColor = Color.Transparent;
            groupBox2.BackColor = Color.Transparent;
            groupBox3.BackColor = Color.Transparent;
            groupBox4.BackColor = Color.Transparent;

            dataGridViewAra.ForeColor = Color.Black;
            dataGridViewSil.ForeColor = Color.Black;
        }

        //Tüm Kitaplar Listesi
        private void btnTumKitaplar_Click(object sender, EventArgs e)
        {
            TumKitaplarListesi yeniForm = new TumKitaplarListesi();
            yeniForm.Show();
            KitapBLL bll = new KitapBLL();
            try
            {
                yeniForm.dataGridViewTumKitaplar.DataSource = bll.TumKitaplarıListele();
                TabloDuzenle(yeniForm.dataGridViewTumKitaplar);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

    }
}
