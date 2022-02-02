using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Cactus.Contact.Model
{
    public class Address
    {
        #region Property

        public int ID { get; set; }

        public int ContactID { get; set; }

        public string AddressTitle { get; set; }

        public int AddressType { get; set; }

        public int RecordStatus { get; set; }

        #endregion

        #region Constructor

        public Address()
        {
            this.RecordStatus = 0;
        }

        #endregion
    }
}
