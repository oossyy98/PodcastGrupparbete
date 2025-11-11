using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IRepository<T> where T : class
    {
        //CREATE
       Task Insert(T item)

        //READ
        Task<T> GetById(string id);
        IEnumerable<T> GetAll(); //Kolla vad den gör

        //UPDATE
        Task Update(T item);

        //DELETE
        Task Delete(string id);
    }
}
// Ska vi ha Async metoder här också?