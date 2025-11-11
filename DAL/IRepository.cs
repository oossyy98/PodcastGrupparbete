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
       void Insert(T item)

        //READ
        T GetById(int id);
        IEnumerable<T> GetAll(); //Kolla vad den gör

        //UPDATE
        void Update(T item);

        //DELETE
        void Delete(int id);
    }
}
// Ska vi ha Async metoder här också?