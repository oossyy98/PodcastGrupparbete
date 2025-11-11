using DAL_DataAccess;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_BusinessLogic
{
    public class PodcastService : IPodcastService
    {
        private readonly IRepository<Podcast> _podcastRepo;

        public PodcastService(IRepository<Podcast> podcastRepo)
        {
            _podcastRepo = podcastRepo;
        }

        //CREATE
        public async Task LaggTill(Podcast podcast)
        {
            if (podcast == null)
            {
                throw new ArgumentNullException(nameof(podcast), "Podcast kan inte vara null");
            }

            if (string.IsNullOrWhiteSpace(podcast.Namn))
            {
                throw new ArgumentException("Podcast måste ha ett namn");
            }

            if (string.IsNullOrWhiteSpace(podcast.Url))
            {
                throw new ArgumentException("Podcast måste ha en URL");
            }

            await _podcastRepo.Create(podcast);
        }

        //READ
        public async Task<Podcast> HamtaMedId(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                throw new ArgumentException("Id kan inte vara tomt");
            }

            return await _podcastRepo.GetById(id);
        }

        public async Task<IEnumerable<Podcast>> HamtaAllaPodcasts()
        {
            return await _podcastRepo.GetAllAsync();
        }

        //UPDATE
        public async Task<bool> Uppdatera(string id, Podcast podcast)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                throw new ArgumentException("Id kan inte vara tomt");
            }

            if (podcast == null)
            {
                throw new ArgumentNullException(nameof(podcast), "Podcast kan inte vara null");
            }

            if (string.IsNullOrWhiteSpace(podcast.Namn))
            {
                throw new ArgumentException("Podcast måste ha ett namn");
            }

            var befintligPodcast = await _podcastRepo.GetById(id);
            if (befintligPodcast == null)
            {
                return false;
            }

            await _podcastRepo.Update(id, podcast);
            return true;
        }

        //DELETE
        public async Task<bool> TaBort(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                throw new ArgumentException("Id kan inte vara tomt");
            }

            var podcast = await _podcastRepo.GetById(id);
            if (podcast == null)
            {
                return false;
            }

            await _podcastRepo.Delete(id);
            return true;
        }

    }
}
