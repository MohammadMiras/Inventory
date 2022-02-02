using Cactus.Common.Interface;
using System;
using System.Collections.Generic;
using System.Data;

namespace Cactus.Contact.Model
{
    public class Contact :ITableBase,IFillDataTable
    {
        #region Property

        public int? ID { get; set; }

        public string Code { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string NationalCode { get; set; }

        public List<Address> Addresses { get; set; }

        public List<Phone> Phones { get; set; }

        public string FatherName { get; set; }

        public DataTable dtPhone { get; set; }

        public DataTable dtAddres { get; set; }       

        #endregion

        #region Constructor

        public Contact()
        {
            dtAddres = new DataTable();

            dtPhone = new DataTable();

            Phones = new List<Phone>();

            Addresses = new List<Address>();

            InitializeTables();
        }

        #endregion

        #region Metodes

        #region Fill Data Tables

        public void FillDataTable()
        {
            //=================<Fill Data Table Phone >====================

            dtPhone.Rows.Clear();

            foreach (var phone in Phones)

                dtPhone.Rows.Add
                    (
                         phone.ID,
                         phone.PhoneNumber,
                         (int)phone.PhoneType,
                         this.ID,
                         (int)phone.RecordStatus
                    );

            //=================<Fill Data Table Address >===================

            dtAddres.Rows.Clear();

            foreach (Address address in Addresses)

                dtAddres.Rows.Add
                    (
                        address.ID,
                        address.AddressTitle,
                        (int)address.AddressType,
                        this.ID,
                        (int)address.RecordStatus
                    );
        }

        #endregion

        #region Initialize Tables 

        public void InitializeTables()
        {
            //=================<Initialize Phone Table Data>====================

            dtPhone.Columns.AddRange
                (
                    new DataColumn[]
                    {
                        new DataColumn("ID" ,typeof(int)),

                        new DataColumn("PhoneNumber" ,typeof(String)),

                        new DataColumn("PhoneTypeID" ,typeof(int)),

                        new DataColumn("CustomerID" ,typeof(int)),

                        new DataColumn ("RecordStatus",typeof(int)),
                    }
                );

            //=================<Initialize Address Table Data>====================

            dtAddres.Columns.AddRange
                (
                    new DataColumn[]
                    {
                        new DataColumn("ID",typeof(int)),

                        new DataColumn("Address",typeof(string)),

                        new DataColumn("AddressTypeID",typeof(int)),

                        new DataColumn("CustomerID",typeof(int)),

                        new DataColumn ("RecordStstus",typeof(int))
                    }
                );
        }

        #endregion

        #endregion
    }
}
