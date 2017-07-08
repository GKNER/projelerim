namespace GunlukApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtKategori = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.trvKategoriler = new System.Windows.Forms.TreeView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mcOnceki = new System.Windows.Forms.MonthCalendar();
            this.mcSimdiki = new System.Windows.Forms.MonthCalendar();
            this.mcSonraki = new System.Windows.Forms.MonthCalendar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsNotOlustur = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsKaydet = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.btnEkle);
            this.splitContainer1.Panel1.Controls.Add(this.txtKategori);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.mcSonraki);
            this.splitContainer1.Panel2.Controls.Add(this.mcSimdiki);
            this.splitContainer1.Panel2.Controls.Add(this.mcOnceki);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(890, 573);
            this.splitContainer1.SplitterDistance = 289;
            this.splitContainer1.TabIndex = 0;
            // 
            // txtKategori
            // 
            this.txtKategori.Location = new System.Drawing.Point(3, 3);
            this.txtKategori.Multiline = true;
            this.txtKategori.Name = "txtKategori";
            this.txtKategori.Size = new System.Drawing.Size(156, 44);
            this.txtKategori.TabIndex = 0;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(159, 3);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(125, 44);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.trvKategoriler);
            this.panel1.Location = new System.Drawing.Point(3, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 516);
            this.panel1.TabIndex = 2;
            // 
            // trvKategoriler
            // 
            this.trvKategoriler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvKategoriler.Location = new System.Drawing.Point(0, 0);
            this.trvKategoriler.Name = "trvKategoriler";
            this.trvKategoriler.Size = new System.Drawing.Size(281, 516);
            this.trvKategoriler.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(345, 566);
            this.panel2.TabIndex = 0;
            // 
            // mcOnceki
            // 
            this.mcOnceki.ContextMenuStrip = this.contextMenuStrip1;
            this.mcOnceki.Location = new System.Drawing.Point(353, 3);
            this.mcOnceki.Name = "mcOnceki";
            this.mcOnceki.TabIndex = 1;
            this.mcOnceki.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mcOnceki_DateChanged);
            // 
            // mcSimdiki
            // 
            this.mcSimdiki.ContextMenuStrip = this.contextMenuStrip1;
            this.mcSimdiki.Location = new System.Drawing.Point(353, 204);
            this.mcSimdiki.Name = "mcSimdiki";
            this.mcSimdiki.TabIndex = 1;
            this.mcSimdiki.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mcSimdiki_DateChanged);
            // 
            // mcSonraki
            // 
            this.mcSonraki.ContextMenuStrip = this.contextMenuStrip1;
            this.mcSonraki.Location = new System.Drawing.Point(353, 403);
            this.mcSonraki.Name = "mcSonraki";
            this.mcSonraki.TabIndex = 1;
            this.mcSonraki.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mcSonraki_DateChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(345, 566);
            this.tabControl1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsNotOlustur});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(137, 26);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsKaydet});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(153, 48);
            // 
            // cmsNotOlustur
            // 
            this.cmsNotOlustur.Name = "cmsNotOlustur";
            this.cmsNotOlustur.Size = new System.Drawing.Size(152, 22);
            this.cmsNotOlustur.Text = "Not Oluştur";
            this.cmsNotOlustur.Click += new System.EventHandler(this.cmsNotOlustur_Click);
            // 
            // cmsKaydet
            // 
            this.cmsKaydet.Name = "cmsKaydet";
            this.cmsKaydet.Size = new System.Drawing.Size(152, 22);
            this.cmsKaydet.Text = "Kaydet";
            this.cmsKaydet.Click += new System.EventHandler(this.cmsKaydet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 573);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView trvKategoriler;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtKategori;
        private System.Windows.Forms.MonthCalendar mcSonraki;
        private System.Windows.Forms.MonthCalendar mcSimdiki;
        private System.Windows.Forms.MonthCalendar mcOnceki;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cmsNotOlustur;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem cmsKaydet;
    }
}

