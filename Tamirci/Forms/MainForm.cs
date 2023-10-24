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
using Tamirci.Forms;

namespace Tamirci
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public static List<Musteri> musteriler = new List<Musteri>();
        public static List<Arac> araclar = new List<Arac>();
        public static List<ServisKaydi> agrizaKayitlar = new List<ServisKaydi>();
        public static List<Ucret> ucretler = new List<Ucret>();

        private void MainForm_Load(object sender, EventArgs e)
        {
            FiyatListesiEkraniGetir();
        }

        private void FiyatListesiEkraniGetir()
        {
            FormlarıKapat();

            FiyatListesi fiyatListesi = new FiyatListesi();
            fiyatListesi.MdiParent = this;
            fiyatListesi.Dock = DockStyle.Fill;
            this.Width = fiyatListesi.Width + 40;
            this.Height = fiyatListesi.Height +50;
            fiyatListesi.Show();
        }

        private void fİyatListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FiyatListesiEkraniGetir();
        }

        private void ağrızaKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgrizaKayit agrizaKayit = new AgrizaKayit();
            agrizaKayit.MdiParent = this;
            agrizaKayit.Dock = DockStyle.Fill;
            this.Width = agrizaKayit.Width + 30;
            this.Height = agrizaKayit.Height + 60;
            agrizaKayit.Show();
        }

        private void FormlarıKapat()
        {
            Form[] forms = this.MdiChildren;
            foreach (Form form in forms)
            {
                form.Close();
            }
        }
        private void geçmişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormlarıKapat();
            GecmisIslemler gecmisIslemler = new GecmisIslemler(musteriler, araclar, agrizaKayitlar, ucretler);
            gecmisIslemler.MdiParent = this;
            gecmisIslemler.Dock = DockStyle.Fill;
            this.Width = gecmisIslemler.Width + 30;
            this.Height = gecmisIslemler.Height + 60;
            gecmisIslemler.Show();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Çıkış yapmak istiyor musunuz?", "Çıkış Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

    }
}
