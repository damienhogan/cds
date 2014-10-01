using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using jay.recipe.common.Service;
using jay.recipe.data;
using System.IO;
using System.Collections;

namespace jay.recipe.service
{
    class OrderService : BaseService
    {
        public OrderService()
        {

        }
        public override void executeService(System.Collections.Hashtable cmd, TextWriter output)
        {
            string serviceName = (String)cmd["serviceName"];
            switch (serviceName)
            {
                case "CreateOrder":
                    CreateOrder(cmd, output);
                    break;
            }
        }
        public Order CreateOrder(Hashtable cmd, TextWriter output) {
            throw new NotImplementedException("Not Implemented");
        }
        public Order UpdateOrder(Order order){
            throw new NotImplementedException("Not Implemented");
        }
        public Order CancelOrder(Order order) {
            throw new NotImplementedException("Not Implemented");
        }
    }
}
