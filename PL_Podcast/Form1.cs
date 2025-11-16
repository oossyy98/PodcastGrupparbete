using BL_BusinessLogic;
using DAL_DataAccess;
using Models;
using System.Linq.Expressions;
using System.Threading.Tasks;

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

        private async void Form1_Load(object sender, EventArgs e)
        {
            await LaddaKategorier();
            await LaddaPodcasts();
        }

        private async Task LaddaKategorier()
        {
            try
            {
                var kategorier = await kategoriService.HamtaAlla();

                ListKategorier.DataSource = null;
                ListKategorier.DataSource = kategorier;
                ListKategorier.DisplayMember = "Namn";

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fel vid inläsning av kategorier: {ex.Message}");
            }
        }

        private async Task LaddaPodcasts()
        {
            try
            {
                var podcasts = await podcastService.HamtaAlla();
                ListMinaPodcast.DataSource = null;
                ListMinaPodcast.DataSource = podcasts;
                ListMinaPodcast.DisplayMember = "Namn";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fel vid inläsning av podcasts: {ex.Message}");
            }
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

                await LaddaKategorier();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fel: {ex.Message}");
            }
        }

        private void CBXKategori_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void BtnTaBort_Click(object sender, EventArgs e)
        {
            try
            {
                if (ListKategorier.SelectedItem == null)
                {
                    MessageBox.Show("Välj en kategori att ta bort.");
                    return;
                }

                var valdKategori = (Kategori)ListKategorier.SelectedItem;

                var resultat = MessageBox.Show
                    ($"Är du säker på att du vill ta bort kategorin '{valdKategori.Namn}'?",
                    "Bekräfta borttagning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultat == DialogResult.Yes)
                {
                    await kategoriService.TaBort(valdKategori.Id);
                    MessageBox.Show($"Kategori '{valdKategori.Namn}' har tagits bort.");
                    await LaddaKategorier();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fel: {ex.Message}");
            }
        }

        private void ListKategorier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListKategorier.SelectedItem != null)
            {
                var valdKategori = (Kategori)ListKategorier.SelectedItem;
                TbxKategorier.Text = valdKategori.Namn;
            }

        }

        private async void BtnUppdateraNamn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ListKategorier.SelectedItem == null)
                {
                    MessageBox.Show("Välj en kategori att uppdatera.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(TbxKategorier.Text))
                {
                    MessageBox.Show("Ange ett nytt namn för kategorin.");
                    return;
                }

                var valdKategori = (Kategori)ListKategorier.SelectedItem;

                var uppdateradKategori = new Kategori
                {
                    Namn = TbxKategorier.Text.Trim()
                };

                await kategoriService.Uppdatera(valdKategori.Id, uppdateradKategori);

                MessageBox.Show($"Kategori uppdaterad till '{uppdateradKategori.Namn}'");

                TbxKategorier.Clear();
                await LaddaKategorier();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fel: {ex.Message}");
            }
        }

        private async void BtnTaBortPodcast_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Kontroll: Har användaren valt något?
                if (ListMinaPodcast.SelectedItem == null)
                {
                    MessageBox.Show("Välj en podcast att ta bort.");
                    return;
                }

                // 2. Hämta vald podcast
                var valdPodcast = (Podcast)ListMinaPodcast.SelectedItem;

                // 3. Bekräftelseruta
                var resultat = MessageBox.Show(
                    $"Är du säker på att du vill ta bort podcasten '{valdPodcast.Namn}'?",
                    "Bekräfta borttagning",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                // 4. Om användaren klickar JA → ta bort
                if (resultat == DialogResult.Yes)
                {
                    await podcastService.TaBort(valdPodcast.Id);

                    MessageBox.Show($"Podcast '{valdPodcast.Namn}' har tagits bort.");

                    // 5. Ladda om listan med podcasts
                    await LaddaPodcasts();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fel: {ex.Message}");
            }
        }
    }
}
