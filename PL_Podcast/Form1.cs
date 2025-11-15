using BL_BusinessLogic;
using DAL_DataAccess;
using Models;

namespace PL_Podcast
{
    public partial class Form1 : Form
    {
        private MongoDBConnection dbConnection;
        private PodcastService podcastService;
        private KategoriService kategoriService;
        private RssService rssService;
        public Form1()
        {
            InitializeComponent();

            dbConnection = new MongoDBConnection();
            var podcastRepo = new PodcastRepository(dbConnection);
            var kategoriRepo = new KategoriRepository(dbConnection); //kolla om man kan instansiera repos genom en anslutning istället för varje repo.

            podcastService = new PodcastService(podcastRepo);
            kategoriService = new KategoriService(kategoriRepo);
            rssService = new RssService();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnLaggtillPodcast_Click(object sender, EventArgs e)
        {

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var nyKategori = new Kategori
                {
                    Namn = TbxKategorier.Text.Trim()
                };

                await kategoriService.LaggTill(nyKategori);

                MessageBox.Show($"Kategori {nyKategori.Namn} tillagd!");
                TbxKategorier.Clear();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fel: {ex.Message}");
            }
        }
    }
}
