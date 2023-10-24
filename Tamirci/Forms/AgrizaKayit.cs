using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tamirci.Class;
using Tamirci.Utilities;
using Tamirci.Forms;

namespace Tamirci
{
    public partial class AgrizaKayit : Form
    {
        public AgrizaKayit()
        {
            InitializeComponent();
            dtpArabaGetirilisTarihi.MinDate = DateTime.Today;
        }


        public void btnKaydet_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri();
            musteri.AdSoyad = txtAdSoayd.Text;
            musteri.TelefonNo = mtbTelefon.Text;
            musteri.Email = txtEmail.Text;
            musteri.AraçGetirilisTarihi = dtpArabaGetirilisTarihi.Value;
            musteri.Adres = txtAdres.Text;
            
            Arac arac = new Arac();
            arac.Marka = txtMarka.Text;
            arac.Model = txtModel.Text;
            arac.KasaTipi = cbKasaTipi.Text;

            ServisKaydi servisKaydi = new ServisKaydi();
            servisKaydi.YapilanIslem = cbYapilanIslem. ValueMember;
            servisKaydi.EkIslem = txtEkIslem.Text;
            FiyatHesabi();
            Ucret ucret = new Ucret();
            ucret.EkIslemUcreti = double.Parse(txtEkUcret.Text);
            ucret.ToplamUcret = ToplamFiyat;

            DialogResult dr = MessageBox.Show("İşleme devam etmek istiyor musun ?", "Onay Mesajı", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                MainForm.musteriler.Add(musteri);
                MainForm.araclar.Add(arac);
                MainForm.agrizaKayitlar.Add(servisKaydi);
                MainForm.ucretler.Add(ucret);
                Helper.Temizle(this.Controls);
                MessageBox.Show("Kayıt Başarılı");
            }
        }

        double ToplamFiyat;
        private void FiyatHesabi()
        {
            if (cbYapilanIslem.Text == "Muayene")
            {
                ToplamFiyat = 1500;
            }
            else if (cbYapilanIslem.Text == "Fren Balata Değişimi")
            {
                ToplamFiyat = 500;
            }
            else if (cbYapilanIslem.Text == "Kaporta Değişimi")
            {
                ToplamFiyat = 3000;
            }
            else if (cbYapilanIslem.Text == "Parça Boya")
            {
                ToplamFiyat = 1000;
            }
            else if (cbYapilanIslem.Text == "Lastik Değişimi")
            {
                ToplamFiyat = 2000;
            }

            ToplamFiyat += double.Parse(txtEkUcret.Text);
            lblTutar.Text = ToplamFiyat.ToString("C2");
        }
    }
}