using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using jay.recipe.common.Data;

namespace jay.recipe.data
{
    public class Order : BaseData
    {
        #region Fields
        private long _Id = -1;
        private Customer _customer = null;
        private decimal _tax = 0;
        private decimal _subTotal = 0;
        #endregion

        #region Properties
        public long Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public Customer Customer
        {
            get { return _customer; }
            set { _customer = value; }
        }

        public decimal Tax
        {
            get { return _tax; }
            set { _tax = value; }
        }


        public decimal SubTotal
        {
            get { return _subTotal; }
            set { _subTotal = value; }
        }
        #endregion

        #region Methods
        #endregion
    }
}
