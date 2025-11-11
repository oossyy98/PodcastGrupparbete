using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_DataAccess
{
    public interface IRepository<T> where T : class
    {
        //CREATE
        Task Create(T item);

        //READ
        Task<T> GetById(string id);
        Task<IEnumerable<T>> GetAllAsync();

        //UPDATE
        Task Update(string id, T item);

        //DELETE
        Task Delete(string id);
    }
}
