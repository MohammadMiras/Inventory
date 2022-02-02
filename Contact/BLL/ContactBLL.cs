using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Cactus.Contact.Dal;
using static Cactus.Common.Model.ModelUtility;
using static Cactus.Contact.Model.ModelUtility;
using ContactClass = Cactus.Contact.Model.Contact;
using Cactus.Contact.Model;

namespace Cactus.Contact.Bll
{
    public class ContactBLL : IContactBLL
    {
        #region Member

        private IContactDAL _contactDAL;

        #endregion

        #region Constructors

        public ContactBLL(IContactDAL contactDAL)
        {
            _contactDAL = contactDAL;
        }

        #endregion

        #region Insert Contact

        public ServerValidationEnum InsertContact(ContactClass contact)
        {
            return _contactDAL.InsertContact(contact);
        }

        #endregion

        #region Get Data

        #region Get contact

        public List<ContactClass> GetContact(ContactClass contact, StatusHasDitailEnum statusHasDitail)
        {
            return _contactDAL.GetContacts(contact, statusHasDitail);
        }

        #endregion

        #region Get Phone And Address Type

        public DataTable GetPhoneAndAddressType(TypeEnum type)
        {
            return _contactDAL.GetPhoneAndAddressType(type);
        }

        #endregion

        #endregion

        #region Update Contact

        public ServerValidationEnum UpdateContact(ContactClass contact)
        {
            return _contactDAL.UpdateContact(contact);
        }

        #endregion

        #region Delete Contact

        public ServerValidationEnum DeleteContact(int ContactID)
        {
            return _contactDAL.DeleteContact(ContactID);
        }

        #endregion

        #region Metodes

        #region Is There This Contact ?

        public bool IsThereThisContact(ContactClass contact)
        {
            var result = _contactDAL.InsertContact(contact, true);

            if (result != ServerValidationEnum.DuplicateCode)

                return false;

            return true;
        }

        #endregion

        #region Chaking Existence Contact

        public ServerValidationEnum ChakingExistenceContact(ContactClass contact)
        {
            return _contactDAL.InsertContact(contact, true);
        }

        #endregion

        #endregion
    }
}
