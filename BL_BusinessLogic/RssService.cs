using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BL_BusinessLogic
{
    public class RssService
    {
        public async Task<List<Avsnitt>> HamtaAvsnittFranRss(string url)
        {
            try
            {
                using (XmlReader reader = XmlReader.Create(url))
                {
                    var rssFlode = SyndicationFeed.Load(reader);

                    var avsnittLista = new List<Avsnitt>();

                    foreach (var avsnitt in rssFlode.Items)
                    {
                        avsnittLista.Add(new Avsnitt
                        {
                            Titel = avsnitt.Title.Text ?? "Ingen titel",
                            Beskrivning = avsnitt.Summary.Text ?? "Ingen beskrivning",
                            Publiceringsdatum = avsnitt.PublishDate.DateTime
                        });
                    }
                    return avsnittLista;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Fel vid hämtning av RSS-flöde: {ex.Message}");
            }
        } 

        public string HamtaPodcastNamn(string url) 
        {
            try
            {
                using (XmlReader reader = XmlReader.Create(url))
                {
                    var rssFlode = SyndicationFeed.Load(reader);
                    return rssFlode.Title?.Text ?? "Okänd podcast";
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Fel vid hämtning av podcastnamn: {ex.Message}");
            }
        }
    } 
} 