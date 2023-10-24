using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tamirci.Class;
using Tamirci;

namespace Tamirci.Forms
{
    public partial class GecmisIslemler : Form
    {
        public GecmisIslemler()
        {
            InitializeComponent();
        }


        List<Musteri> musteriler;
        List<Arac> araclar;
        List<ServisKaydi> servisKaydi;
        List<Ucret> ucretler;


        public GecmisIslemler(List<Musteri> musteriler, List<Arac> araclar, List<ServisKaydi> servisKaydi, List<Ucret> ucretler):this()
        {
            this.musteriler = musteriler;
            this.araclar = araclar;
            this.servisKaydi = servisKaydi;
            this.ucretler = ucretler;
        }

        private void GecmisIslemler_Load(object sender, EventArgs e)
        {
            lbVeriler.Items.Clear();

            int index = 0;
            while (index < musteriler.Count && index < araclar.Count && index < servisKaydi.Count && index < ucretler.Count)
            {
                Musteri musteri = musteriler[index];
                Arac arac = araclar[index];
                ServisKaydi servisKaydi1 = servisKaydi[index];
                Ucret fiyat = ucretler[index];

                string bilgiSatiri = $"{musteri.AdSoyad} - {musteri.TelefonNo} - {musteri.Email} {musteri.AraçGetirilisTarihi} - {musteri.Adres}  " +
                    $"{arac.Marka} - {arac.Model} - {arac.KasaTipi} - {servisKaydi1.YapilanIslem} {servisKaydi1.EkIslem} - {fiyat.ToplamUcret}";

                lbVeriler.Items.Add(bilgiSatiri);
                index++;
            }
        }
    }
}