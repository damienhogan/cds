using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace jay.recipe.common.Data
{
    public class DataFactory
    {
        public static IData createInstance(string type) {
            IData da = (IData)Assembly.LoadFile("jay.recipe.data.dll").CreateInstance(type);
            return da;
        }
    }
}
