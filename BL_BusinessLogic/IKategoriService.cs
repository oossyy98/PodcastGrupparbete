using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_BusinessLogic
{
    public interface IKategoriService
    {
        //CREATE
        Task LaggTill(Kategori kategori);

        //READ
        Task<List<Kategori>> HamtaAlla();
        Task<Kategori> HamtaMedId(string id);

        //UPDATE
        Task<bool> Uppdatera(string id, Kategori kategori);

        //DELETE
        Task<bool> TaBort(string id);
    }
}
