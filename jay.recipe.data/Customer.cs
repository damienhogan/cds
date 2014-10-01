using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using jay.recipe.common.Data;

namespace jay.recipe.data
{
    public class Customer: BaseData
    {
        #region Fields
        private long _Id = -1;
        private string _firstName = string.Empty;
        private string _lastName = string.Empty;
        private string _address1 = string.Empty;
        private string _address2 = string.Empty;
        private string _city = string.Empty;
        private string _state = string.Empty;
        private string _postalCode = string.Empty;
        #endregion

        #region Properties
        public long Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public string Address1
        {
            get { return _address1; }
            set { _address1 = value; }
        }
        public string Address2
        {
            get { return _address2; }
            set { _address2 = value; }
        }
        public string City
        {
            get { return _city; }
            set { _city = value; }
        }
        public string State
        {
            get { return _state; }
            set { _state = value; }
        }
        public string PostalCode
        {
            get { return _postalCode; }
            set { _postalCode = value; }
        }
        #endregion

        #region Methods

        #endregion

    }
}
