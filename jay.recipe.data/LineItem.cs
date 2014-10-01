using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using jay.recipe.common.Data;

namespace jay.recipe.data
{
    public class LineItem : BaseData
    {
        #region Fields
        private long _Id = -1;
        private string _prodCode = string.Empty;
        private Int32 _qty = -1;
        private decimal _price = 0;
        #endregion

        #region Properties
        public long Id
        {
            get { return _Id; }
            set { _Id = value; }
        }
        public string ProdCode
        {
            get { return _prodCode; }
            set { _prodCode = value; }
        }
        public Int32 Qty
        {
            get { return _qty; }
            set { _qty = value; }
        }
        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }
        #endregion

        #region Methods
        public LineItem()
        {

        }
        #endregion
    }
}
