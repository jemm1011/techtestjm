using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechTestJM.Support.JsonHelper
{
    public interface IJsonRequestHelper
    {
        Task<T> Get<T>(string url);
    }
}
