using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace jay.recipe.common.Service
{
    public interface IService
    {
        void executeService(Hashtable cmd, TextWriter output);

        
    }
}
