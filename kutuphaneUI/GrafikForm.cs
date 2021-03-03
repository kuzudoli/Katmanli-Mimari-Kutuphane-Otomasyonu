using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;
using kutuphaneBLL;
using kutuphaneEntity;
namespace kutuphaneUI
{
    public partial class GrafikForm : Form
    {
        GraphPane myPane;
        public GrafikForm()
        {
            InitializeComponent();
            myPane = zg1.GraphPane;
            CreateGraph(zg1);
        }

        private void CreateGraph(ZedGraphControl zg1)
        {
            KitapBLL bll = new KitapBLL();
            Kitap kitap = new Kitap();
            bll.GrafikHesap(kitap);

            GraphPane myPane = zg1.GraphPane;

            //Başlıklar yazdırılıyor
            myPane.Title.Text = "Kütüphanedeki Genel Kitap Durumu";
            myPane.XAxis.Title.Text = "Kitap Durumu";
            myPane.YAxis.Title.Text = "Kitap Sayısı";

            //Değişkenlere sayı verileri aktarılıyor
            int kitap_uygundegil = kitap.HazirOlmayanKitapSayisi;
            int kitap_uygun = kitap.HazirKitapSayisi;
            int kitap_total = kitap.ToplamKitap;


            double[] y = { kitap_total }; //X GRAFİK X PARAMETRE X DEĞER ANLAMINDA
            double[] y2 = { kitap_uygun };
            double[] y3 = { kitap_uygundegil };

            //Sütun grafikleri ekleniyor, renkleri düzenleniyor
            BarItem myBar = myPane.AddBar("Toplam Kitap Sayısı", null, y, Color.Blue);
            myBar.Bar.Fill = new Fill(Color.Blue, Color.White, Color.Blue);

            myBar = myPane.AddBar("Emanet Verilmeye Hazır Kitaplar", null, y2, Color.Green);
            myBar.Bar.Fill = new Fill(Color.Green, Color.White, Color.Green);

            myBar = myPane.AddBar("Emanet Verilen Kitaplar", null, y3, Color.Red);
            myBar.Bar.Fill = new Fill(Color.Red, Color.White, Color.Red);

            myPane.XAxis.MajorTic.IsBetweenLabels = true;

            myPane.XAxis.Type = AxisType.Text;

            //Arkaplan rengi düzenleniyor
            myPane.Chart.Fill = new Fill(Color.LightSkyBlue, Color.FromArgb(255, 255, 166), -45F);
            myPane.Fill = new Fill(Color.FromArgb(250, 250, 255));

            zg1.AxisChange();
        }

        private void GrafikForm_Load(object sender, EventArgs e)
        {

        }

        //Eğer yakınlaştırma işlemi yapıldıysa, çift tıklandığında İlk görüntüsüne geri dönüyor
        private void zg1_DoubleClick(object sender, EventArgs e)
        {
            zg1.ZoomOutAll(myPane);
        }
    }
}
