using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechTestJM.Model.Interfaces
{
    public interface IBaseFactory<T> where T : class
    {
        T Create(object param);
    }
}
