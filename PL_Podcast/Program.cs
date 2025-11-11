using DAL_DataAccess;
using Models;

namespace PL_Podcast
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static async Task Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Console.WriteLine("=== Testar PodcastRepository ===\n");

            var podcastRepo = new PodcastRepository();

            // TEST 1: Skapa en podcast
            Console.WriteLine("1. Skapar podcast...");
            var podcast = new Podcast
            {
                Namn = "Min Testpodd",
                Url = "https://example.com/feed.rss",
                KategoriId = "test123",
                Avsnitt = new List<Avsnitt>
                {
                    new Avsnitt
                    {
                        Titel = "Avsnitt 1",
                        Beskrivning = "Detta är första avsnittet",
                        Publiceringsdatum = DateTime.Now
                    }
                }
            };

            try
            {
                await podcastRepo.Create(podcast);
                Console.WriteLine("✓ Podcast skapad!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"✗ FEL: {ex.Message}");
                Console.WriteLine($"Stack: {ex.StackTrace}");
                return;
            }

            // TEST 2: Hämta alla podcasts
            Console.WriteLine("\n2. Hämtar alla podcasts...");
            try
            {
                var allaPodcasts = await podcastRepo.GetAllAsync();
                foreach (var p in allaPodcasts)
                {
                    Console.WriteLine($"   - {p.Namn} ({p.Avsnitt.Count} avsnitt)");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"✗ FEL: {ex.Message}");
                Console.WriteLine($"Stack: {ex.StackTrace}");
            }

            Console.WriteLine("\n=== Test klart! ===");
            Console.WriteLine("Kolla i MongoDB Atlas - kollektionen 'podcasts' ska finnas!");

            Application.Run(new Form1());
           

        }
    }
}