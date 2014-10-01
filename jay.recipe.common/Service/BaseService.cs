using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace jay.recipe.common.Service
{
    public abstract class BaseService : IService
    {
        public abstract void executeService(Hashtable cmd,TextWriter output);

    }
}
