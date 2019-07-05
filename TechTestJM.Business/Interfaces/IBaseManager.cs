using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechTestJM.Business.Interfaces
{
    public interface IBaseManager<T> where T : class
    {
        Task<T> GetById(int id);
        Task<List<T>> GetAll();
    }
}
