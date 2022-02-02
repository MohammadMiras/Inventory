using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Cactus.Common.Model.ModelUtility;
using static Cactus.Contact.Model.ModelUtility;
using ContactClass = Cactus.Contact.Model.Contact;
namespace Cactus.Contact.Model
{
    public interface IContactDAL
    {
        List<ContactClass> GetContacts(ContactClass contact, StatusHasDitailEnum statusHasDitail);
        DataTable GetPhoneAndAddressType(TypeEnum type);
        ServerValidationEnum InsertContact(ContactClass contact, bool? JustToChaking = null);
        ServerValidationEnum UpdateContact(ContactClass contact);
        ServerValidationEnum DeleteContact(int ID);
    }
}
