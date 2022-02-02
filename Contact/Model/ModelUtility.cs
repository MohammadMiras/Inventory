using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cactus.Contact.Model
{
    public class ModelUtility
    {                
        public enum ContactControlsNameEnum
        {
            txtCode,

            txtFristName,

            txtlastName,

            txtFatherName,

            txtNationalCode,
        }

        public enum PhoneTypeEnum
        {
            Mobile = 1,

            Phone = 2,

            fax = 3 
        }

        public enum AddresstypeEnum
        {
            WorkPlace = 1,

            Address = 2
        }

        public enum TypeEnum
        {
            PhoneType = 0,

            AddressType = 1 
        }
    }
}
