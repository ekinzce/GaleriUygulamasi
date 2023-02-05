namespace GaleriUygulaması
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstGaleriler = new System.Windows.Forms.ListBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Resim = new System.Windows.Forms.PictureBox();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnGaleriKaydet = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.resmiSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnResimEkle = new System.Windows.Forms.Button();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.txtGaleriAdi = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnYenile = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Resim)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstGaleriler);
            this.groupBox1.Location = new System.Drawing.Point(29, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 320);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Galeriler";
            // 
            // lstGaleriler
            // 
            this.lstGaleriler.FormattingEnabled = true;
            this.lstGaleriler.ItemHeight = 20;
            this.lstGaleriler.Location = new System.Drawing.Point(6, 26);
            this.lstGaleriler.Name = "lstGaleriler";
            this.lstGaleriler.Size = new System.Drawing.Size(180, 284);
            this.lstGaleriler.TabIndex = 0;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(127, 369);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(94, 29);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Resim);
            this.groupBox2.Controls.Add(this.btnExcel);
            this.groupBox2.Controls.Add(this.btnGaleriKaydet);
            this.groupBox2.Controls.Add(this.flowLayoutPanel1);
            this.groupBox2.Controls.Add(this.btnResimEkle);
            this.groupBox2.Controls.Add(this.txtAciklama);
            this.groupBox2.Controls.Add(this.txtGaleriAdi);
            this.groupBox2.Location = new System.Drawing.Point(265, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(471, 355);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Galeri Bİlgileri ve Resimler";
            // 
            // Resim
            // 
            this.Resim.Location = new System.Drawing.Point(52, 160);
            this.Resim.Name = "Resim";
            this.Resim.Size = new System.Drawing.Size(89, 62);
            this.Resim.TabIndex = 6;
            this.Resim.TabStop = false;
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(6, 265);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(180, 29);
            this.btnExcel.TabIndex = 5;
            this.btnExcel.Text = "Galeri Excel Export";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnGaleriKaydet
            // 
            this.btnGaleriKaydet.Location = new System.Drawing.Point(285, 265);
            this.btnGaleriKaydet.Name = "btnGaleriKaydet";
            this.btnGaleriKaydet.Size = new System.Drawing.Size(180, 29);
            this.btnGaleriKaydet.TabIndex = 4;
            this.btnGaleriKaydet.Text = "Galeri Kaydet";
            this.btnGaleriKaydet.UseVisualStyleBackColor = true;
            this.btnGaleriKaydet.Click += new System.EventHandler(this.btnGaleriKaydet_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.ContextMenuStrip = this.contextMenuStrip1;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(192, 26);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(273, 196);
            this.flowLayoutPanel1.TabIndex = 3;
            this.flowLayoutPanel1.ContextMenuStripChanged += new System.EventHandler(this.Form1_Load);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resmiSilToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(139, 28);
            // 
            // resmiSilToolStripMenuItem
            // 
            this.resmiSilToolStripMenuItem.Name = "resmiSilToolStripMenuItem";
            this.resmiSilToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.resmiSilToolStripMenuItem.Text = "Resmi Sil";
            this.resmiSilToolStripMenuItem.Click += new System.EventHandler(this.resmiSilToolStripMenuItem_Click);
            // 
            // btnResimEkle
            // 
            this.btnResimEkle.Location = new System.Drawing.Point(6, 122);
            this.btnResimEkle.Name = "btnResimEkle";
            this.btnResimEkle.Size = new System.Drawing.Size(180, 29);
            this.btnResimEkle.TabIndex = 2;
            this.btnResimEkle.Text = "Resim Ekle";
            this.btnResimEkle.UseVisualStyleBackColor = true;
            this.btnResimEkle.Click += new System.EventHandler(this.btnResimEkle_Click);
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(6, 70);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.PlaceholderText = "Açıklama";
            this.txtAciklama.Size = new System.Drawing.Size(180, 27);
            this.txtAciklama.TabIndex = 1;
            // 
            // txtGaleriAdi
            // 
            this.txtGaleriAdi.Location = new System.Drawing.Point(6, 26);
            this.txtGaleriAdi.Name = "txtGaleriAdi";
            this.txtGaleriAdi.PlaceholderText = "Galeri Adı";
            this.txtGaleriAdi.Size = new System.Drawing.Size(180, 27);
            this.txtGaleriAdi.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSave,
            this.btnYenile});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSave.Image = global::GaleriUygulamasi.Properties.Resources.floppy_guardar_save_icon;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(29, 24);
            this.btnSave.Text = "toolStripButton1";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnYenile
            // 
            this.btnYenile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnYenile.Image = global::GaleriUygulamasi.Properties.Resources.rotate_refresh_icon;
            this.btnYenile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(29, 24);
            this.btnYenile.Text = "toolStripButton1";
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Resim)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private ListBox lstGaleriler;
        private Button btnSil;
        private GroupBox groupBox2;
        private Button btnExcel;
        private Button btnGaleriKaydet;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnResimEkle;
        private TextBox txtAciklama;
        private TextBox txtGaleriAdi;
        private ToolStrip toolStrip1;
        private ToolStripButton btnSave;
        private PictureBox Resim;
        private ToolStripButton btnYenile;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem resmiSilToolStripMenuItem;
    }
}