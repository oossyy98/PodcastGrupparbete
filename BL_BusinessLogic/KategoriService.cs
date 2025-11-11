using DAL_DataAccess;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_BusinessLogic
{
    public class KategoriService : IKategoriService
    {
        private readonly IRepository<Kategori> _kategoriRepo;

        public KategoriService(IRepository<Kategori> kategoriRepo)
        {
            _kategoriRepo = kategoriRepo;
        }

        //CREATE
        public async Task LaggTill(Kategori kategori)
        {
            if (kategori == null)
            {
                throw new ArgumentNullException(nameof(kategori), "Kategori kan inte vara null");
            }
            if (string.IsNullOrWhiteSpace(kategori.Namn))
            {
                throw new ArgumentException("Kategori måste ha ett namn");
            }
            await _kategoriRepo.Create(kategori);
        }

        //READ
        public async Task<List<Kategori>> HamtaAlla()
        {
            var result = await _kategoriRepo.GetAllAsync();
            return result.ToList();
        }

        public async Task<Kategori> HamtaMedId(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                throw new ArgumentException("Id kan inte vara tomt");
            }
            return await _kategoriRepo.GetById(id);
        }

        //UPDATE
        public async Task<bool> Uppdatera(string id, Kategori kategori)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                throw new ArgumentException("Id kan inte vara tomt");
            }

            if (kategori == null)
            {
                throw new ArgumentNullException(nameof(kategori), "Kategori kan inte vara null");
            }

            if (string.IsNullOrWhiteSpace(kategori.Namn))
            {
                throw new ArgumentException("Kategori måste ha ett namn");
            }

            var befintligKategori = await _kategoriRepo.GetById(id);
            if (befintligKategori == null)
            {
                return false;
            }

            await _kategoriRepo.Update(id, kategori);
            return true;
        }

        //DELETE
        public async Task<bool> TaBort(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                throw new ArgumentException("Id kan inte vara tomt");
            }

            var kategori = await _kategoriRepo.GetById(id);
            if (kategori == null)
            {
                return false;
            }

            await _kategoriRepo.Delete(id);
            return true;
        }
    }
}
