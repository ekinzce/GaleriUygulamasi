using System.Text.Json;
using System.Windows.Forms;
using Ganss.Excel;

namespace GaleriUygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class GaleriUygulaması
        {
            public string GaleriAdi { get; set; }
            public string GaleriAciklama { get; set; }
            public string ImagePath { get; set; }

            public override string ToString()
            {
                return $"{GaleriAdi}";
            }
        }



        private List<GaleriUygulaması> GaleriListesi = new List<GaleriUygulaması>();
        private string pathGaleriListesi = Application.StartupPath + "GaleriListesi.json";
        private void btnResimEkle_Click(object sender, EventArgs e)
        {
            //Flow Layout Panel İçine Fotoğraf Ekleme

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Resim Seç";

            openFileDialog.RestoreDirectory = true;
            openFileDialog.Multiselect = false;
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            openFileDialog.Filter = "Resim Dosyları|*.jpg;*.jpeg;*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                PictureBox Resim = new PictureBox();
                Resim.SizeMode = PictureBoxSizeMode.Zoom;
                Resim.ImageLocation = openFileDialog.FileName;
                flowLayoutPanel1.Controls.Add(Resim);
            }
            
        }
        
        private void btnGaleriKaydet_Click(object sender, EventArgs e)
        {

            GaleriUygulaması galeriUygulaması = new GaleriUygulaması();
            galeriUygulaması.GaleriAdi = txtGaleriAdi.Text;
            galeriUygulaması.GaleriAciklama = txtAciklama.Text;
            galeriUygulaması.ImagePath = Resim.ImageLocation;

            GaleriListesi.Add(galeriUygulaması);
            lstGaleriler.DataSource = null;
            lstGaleriler.DataSource = GaleriListesi;


        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string jsonGaleriListesi = JsonSerializer.Serialize(GaleriListesi, new JsonSerializerOptions() { WriteIndented = true });
            File.WriteAllText(pathGaleriListesi, jsonGaleriListesi);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(pathGaleriListesi))
            {
                string json = File.ReadAllText(pathGaleriListesi);
                GaleriListesi = JsonSerializer.Deserialize<List<GaleriUygulaması>>(json);
                lstGaleriler.DataSource = null;
                lstGaleriler.DataSource = GaleriListesi;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstGaleriler.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Bir Kayıt Seçiniz..");
                return;
            }
            GaleriListesi.RemoveAt(lstGaleriler.SelectedIndex);
            lstGaleriler.DataSource = null;
            lstGaleriler.DataSource = GaleriListesi;
        }

        private void resmiSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.RemoveAt(lstGaleriler.SelectedIndex);
            lstGaleriler.DataSource = null;
            lstGaleriler.DataSource = GaleriListesi;          
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            ExcelMapper excelMapper = new ExcelMapper();
            excelMapper.Save("GaleriListesi.xlsx", GaleriListesi, "GaleriListesi");

            MessageBox.Show("Kaydedildi.");
        }
    }
}