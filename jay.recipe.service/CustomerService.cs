using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using jay.recipe.common.Service;
using jay.recipe.data;
using System.IO;
namespace jay.recipe.service
{
    public class CustomerService: BaseService, IService
    {
        public CustomerService()
        {

        }
        public override void executeService(System.Collections.Hashtable cmd, TextWriter output)
        {
            
        }
        public Customer CreateCustomer()
        {
            throw new NotImplementedException("Not Implemented");
        }

        public Customer SaveCustomer()
        {
            throw new NotImplementedException("Not Implemented");
        }
        public Customer DeleteCustomer()
        {
            throw new NotImplementedException("Not Implemented");
        }
    }
}
