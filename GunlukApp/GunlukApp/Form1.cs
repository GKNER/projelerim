using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GunlukApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string kategoriAdi = txtKategori.Text.Trim();
            if (trvKategoriler.SelectedNode!=null)
            {
                trvKategoriler.SelectedNode.Nodes.Add(kategoriAdi);
            }
            else
            {
                trvKategoriler.Nodes.Add(kategoriAdi);
            }
        }

        private void mcSimdiki_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime minOnceki = mcSimdiki.SelectionRange.Start.AddMonths(-1);
            DateTime maxOnceki = mcSimdiki.SelectionRange.End.AddMonths(-1);
            mcOnceki.SelectionRange = new SelectionRange(minOnceki, maxOnceki);


            DateTime minSonraki = mcSimdiki.SelectionRange.Start.AddMonths(1);
            DateTime maxSonraki = mcSimdiki.SelectionRange.End.AddMonths(1);
            mcSonraki.SelectionRange = new SelectionRange(minSonraki,maxSonraki);
        }

        private void mcSonraki_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime minSimdiki = mcSonraki.SelectionRange.Start.AddMonths(-1);
            DateTime maxSimdiki = mcSonraki.SelectionRange.End.AddMonths(-1);
            mcSimdiki.SelectionRange = new SelectionRange(minSimdiki, maxSimdiki);

            DateTime minOnceki = mcSonraki.SelectionRange.Start.AddMonths(-2);
            DateTime maxOnceki = mcSonraki.SelectionRange.End.AddMonths(-2);
            mcOnceki.SelectionRange = new SelectionRange(minOnceki, maxOnceki);

        }

        private void mcOnceki_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime minSimdiki = mcOnceki.SelectionRange.Start.AddMonths(1);
            DateTime maxSimdiki = mcOnceki.SelectionRange.End.AddMonths(1);
            mcSimdiki.SelectionRange = new SelectionRange(minSimdiki,maxSimdiki);


            DateTime minSonraki = mcOnceki.SelectionRange.Start.AddMonths(2);
            DateTime maxSonraki = mcOnceki.SelectionRange.End.AddMonths(2);
            mcSonraki.SelectionRange = new SelectionRange(minSonraki,maxSonraki);
        }

        private void cmsNotOlustur_Click(object sender, EventArgs e)
        {
            if (trvKategoriler.SelectedNode==null)
            {
                MessageBox.Show("Lütfen bir kategori seçiniz.");
                return;
            }

            DateTime seciliTarih = mcSimdiki.SelectionStart;
            string kategori = trvKategoriler.SelectedNode.Text;

            string tabPageBaslik = $"{kategori}-{seciliTarih.ToShortDateString()}";

            TabPage tp = new TabPage();
            tp.Text = tabPageBaslik;
            tabControl1.TabPages.Add(tp);

            RichTextBox rtb = new RichTextBox();
            rtb.Dock = DockStyle.Fill;
            rtb.ContextMenuStrip = contextMenuStrip2;
            tp.Controls.Add(rtb);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mcSimdiki.SelectionStart = DateTime.Now;
        }

        private void cmsKaydet_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            sfd.Filter = "Metin Belgesi | *.txt";
            sfd.OverwritePrompt = true;

            if (sfd.ShowDialog()==DialogResult.OK)
            {
                if (contextMenuStrip2.SourceControl is RichTextBox)
                {
                    RichTextBox rtb = contextMenuStrip2.SourceControl as RichTextBox;
                    File.WriteAllText(sfd.FileName, rtb.Text);
                }
            }
        }
    }
}
