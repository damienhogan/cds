using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace jay.recipe.common.Service
{
    public class ServiceFactory
    {
        public static IService createInstance(string type)
        {
            IService da = (IService)Assembly.LoadFile("jay.recipe.service.dll").CreateInstance(type);
            return da;
        }
    }
}
