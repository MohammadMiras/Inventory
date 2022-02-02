using Cactus.Common;
using Cactus.Common.Interface;
using Cactus.Common.Model;
using Cactus.Contact.Bll;
using Cactus.Contact.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Cactus.Common.Model.ModelUtility;
using ClassContact = Cactus.Contact.Model.Contact;
namespace Cactus.Contact.UI
{
    public class ContactSubSystem : IContact
    {
        private ContactViewModel _contactViewModel;

        private ClassContact _contact;

        private IContactBLL _contactBLL;

        public ContactSubSystem()
        {
            Bootstrapper.Init();

            _contactBLL = DependencyInjector.Retrieve<ContactBLL>();
        }

        public ContactViewModel GetCustomer(int ContactID)
        {
            _contactViewModel = new ContactViewModel();

            _contact = new ClassContact();

            ClassContact contact = new ClassContact
            {
                ID = ContactID
            };

            List<ClassContact> contacts = new List<ClassContact>();

            contacts = _contactBLL.GetContact(contact, StatusHasDitailEnum.No);

            if (contacts == null)
                return null;

            _contact = contacts.First();

            ConvertToViewModel();

            return _contactViewModel;
        }

        public ContactViewModel ShowUCSelectCustomer()
        {
            _contactViewModel = new ContactViewModel();

            _contact = new ClassContact();

            UC_Contact_List UC = new UC_Contact_List(contact: _contact, formMode: FormModeEnum.Select);

            var result = ShowForm.Show(UC);

            if (result == DialogResult.Yes)
            {
                ConvertToViewModel();

                return _contactViewModel;
            }

            return null;
        }

        public void ConvertToViewModel()
        {
            _contactViewModel.FirstName = _contact.FirstName;

            _contactViewModel.LastName = _contact.LastName;

            _contactViewModel.Code = _contact.Code;

            _contactViewModel.ID = _contact.ID == null ? 0 : _contact.ID.Value;

            _contact = new ClassContact();
        }

        public UserControl GetUCContactList()
        {
            return new UC_Contact_List();
        }
    }
}
