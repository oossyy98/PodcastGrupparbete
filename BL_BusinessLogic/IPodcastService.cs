using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_BusinessLogic
{
    public interface IPodcastService
    {
        //CREATE
        Task LaggTill(Podcast podcast);

        //READ
        Task<List<Podcast>> HamtaAlla();
        Task<Podcast> HamtaMedId(string id);

        //UPDATE
        Task<bool> Uppdatera(string id, Podcast podcast);

        //DELETE
        Task<bool> TaBort(string id);
    }
}
