using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechTestJM.Data.Service.Abstract
{
    public abstract class BaseService
    {
        public string BaseUrl = ConfigurationManager.AppSettings["baseServiceUrl"];
    }
}
