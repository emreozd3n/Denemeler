using KatMimD1.BLL;
using KatMimD1.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KatMimD1.WinUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnBul_Click(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Ekle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Sil();
        }

        CRUD islem = new CRUD();

        private void Listele()
        {
            dgvKategoriListe.DataSource = islem.SelectAll();
        }

        private void Ekle()
        {

        }

        private void Guncelle()
        {

        }

        private void Sil()
        {

        }

      
    }
}
