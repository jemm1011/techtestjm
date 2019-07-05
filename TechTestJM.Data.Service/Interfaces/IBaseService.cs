using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechTestJM.Data.Service.Interfaces
{
    public interface IBaseService<T> where T: class
    {
        Task<T> GetById(int id);
        Task<List<T>> GetAll();
    }
}
