using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using Cactus.Contact.Model;
using ContactClass = Cactus.Contact.Model.Contact;
using Cactus.Common.BaseClass;
using static Cactus.Common.Model.ModelUtility;
using Cactus.Common;
using Cactus.Common.Logger;
using static Cactus.Contact.Model.ModelUtility;

namespace Cactus.Contact.Dal
{
    public class ContactDAL : DalBaseClass<ContactClass>, IContactDAL
    {
        #region Get Data

        #region Get Contacts

        public List<ContactClass> GetContacts(ContactClass contact, StatusHasDitailEnum statusHasDitail)
        {
            List<ContactClass> contacts = new List<ContactClass>();

            using (SqlConnection con = new SqlConnection(ConnectionString._ConnectionString))
            {
                try
                {
                    DataSet dsContact = new DataSet();

                    SqlCommand sqlCommand =
                        new SqlCommand(StoreProcedureNames.GetContacts, con);

                    SqlDataAdapter sqlDataAdapter =
                        new SqlDataAdapter(sqlCommand);

                    sqlCommand.CommandType =
                        CommandType.StoredProcedure;
                    //-------------------------------------<Add Parameters>-----------------------------------------------

                    sqlCommand.Parameters.AddWithValue
                        (StorProcedureParametersName.ContactID, contact.ID ?? (object)DBNull.Value);

                    sqlCommand.Parameters.AddWithValue
                        (StorProcedureParametersName.Code, contact.Code ?? (object)DBNull.Value);

                    sqlCommand.Parameters.AddWithValue
                        (StorProcedureParametersName.FirstName, contact.FirstName ?? (object)DBNull.Value);

                    sqlCommand.Parameters.AddWithValue
                        (StorProcedureParametersName.LastName, contact.LastName ?? (object)DBNull.Value);

                    sqlCommand.Parameters.AddWithValue
                        (StorProcedureParametersName.NationalCode, contact.NationalCode ?? (object)DBNull.Value);

                    sqlCommand.Parameters.AddWithValue
                        (StorProcedureParametersName.FatherName, contact.FatherName ?? (object)DBNull.Value);

                    sqlCommand.Parameters.AddWithValue
                        (StorProcedureParametersName.HasDetails, Convert.ToInt32(statusHasDitail));

                    sqlDataAdapter.Fill(dsContact);

                    return
                        ConvertToList(dsContact);
                }
                catch (Exception ex)
                {
                    Logger.Log(ex);

                    return null;
                }
            }
        }

        #endregion

        #region Get Phone And Address Type

        public DataTable GetPhoneAndAddressType(TypeEnum type)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString._ConnectionString))
            {
                try
                {
                    SqlCommand sqlCommand =
                        new SqlCommand(StoreProcedureNames.GetPhoneAndAddressType, sqlConnection);

                    SqlDataAdapter sqlDataAdapter =
                        new SqlDataAdapter(sqlCommand);

                    sqlCommand.Parameters.AddWithValue
                        (StorProcedureParametersName.WhichType, (int)type);

                    sqlCommand.CommandType =
                        CommandType.StoredProcedure;

                    DataTable dataTable = new DataTable();

                    sqlDataAdapter.Fill(dataTable);

                    return dataTable;
                }
                catch (Exception ex)
                {
                    Logger.Log(ex);

                    return null;
                }
            }
        }

        #endregion

        #endregion

        #region Insert Contact 

        public ServerValidationEnum InsertContact(ContactClass contact, bool? JustToChaking = null)
        {
            try
            {
                ServerValidationEnum validationResult = ServerValidationEnum.NoProblem;

                contact.FillDataTable();

                using (SqlConnection sqlConnection = new SqlConnection(ConnectionString._ConnectionString))
                {
                    SqlCommand sqlCommand =
                        new SqlCommand(StoreProcedureNames.InsertContact, sqlConnection);

                    sqlCommand.CommandType =
                        CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue
                         (StorProcedureParametersName.Code, contact.Code);

                    sqlCommand.Parameters.AddWithValue
                        (StorProcedureParametersName.FirstName, contact.FirstName.Trim() ?? (object)DBNull.Value);

                    sqlCommand.Parameters.AddWithValue
                        (StorProcedureParametersName.LastName, contact.LastName.Trim() ?? (object)DBNull.Value);

                    sqlCommand.Parameters.AddWithValue
                        (StorProcedureParametersName.FatherName, contact.FatherName.Trim() ?? (object)DBNull.Value);

                    sqlCommand.Parameters.AddWithValue
                         (StorProcedureParametersName.NationalCode, contact.NationalCode.Trim() ?? (object)DBNull.Value);

                    sqlCommand.Parameters.AddWithValue
                        (StorProcedureParametersName.AddresTable, contact.dtAddres ?? (object)DBNull.Value);

                    sqlCommand.Parameters.AddWithValue
                        (StorProcedureParametersName.PhoneTable, contact.dtPhone ?? (object)DBNull.Value);

                    sqlCommand.Parameters.AddWithValue
                        (StorProcedureParametersName.JustToChaking, JustToChaking == null ? 0 : Convert.ToInt32(JustToChaking));

                    var returnParameter =
                        sqlCommand.Parameters.Add
                             (StorProcedureParametersName.ValidationResutlt, SqlDbType.Int);

                    returnParameter.Direction = ParameterDirection.Output;

                    sqlCommand.Parameters[StorProcedureParametersName.PhoneTable].SqlDbType =
                        SqlDbType.Structured;

                    sqlCommand.Parameters[StorProcedureParametersName.AddresTable].SqlDbType =
                        SqlDbType.Structured;

                    sqlConnection.Open();

                    sqlCommand.ExecuteNonQuery();

                    validationResult = (ServerValidationEnum)returnParameter.Value;

                    sqlConnection.Close();

                    return
                        validationResult;
                }
            }
            catch (Exception ex)
            {
                Logger.Log(ex);

                return ServerValidationEnum.Error;
            }
        }

        #endregion

        #region Update Contact

        public ServerValidationEnum UpdateContact(ContactClass contact)
        {
            try
            {
                contact.FillDataTable();

                ServerValidationEnum ServerValidationResutlt = new ServerValidationEnum();

                using (SqlConnection con =
                    new SqlConnection(ConnectionString._ConnectionString))
                {
                    SqlCommand sqlCommand =
                        new SqlCommand(StoreProcedureNames.UpdateContact, con);

                    sqlCommand.CommandType =
                        CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue
                        (StorProcedureParametersName.ContactID, contact.ID ?? (object)DBNull.Value);

                    sqlCommand.Parameters.AddWithValue
                        (StorProcedureParametersName.Code, contact.Code.Trim() ?? (object)DBNull.Value);

                    sqlCommand.Parameters.AddWithValue
                        (StorProcedureParametersName.FirstName, contact.FirstName.Trim() ?? (object)DBNull.Value);

                    sqlCommand.Parameters.AddWithValue
                        (StorProcedureParametersName.LastName, contact.LastName.Trim() ?? (object)DBNull.Value);

                    sqlCommand.Parameters.AddWithValue
                        (StorProcedureParametersName.FatherName, contact.FatherName.Trim() ?? (object)DBNull.Value);

                    sqlCommand.Parameters.AddWithValue
                        (StorProcedureParametersName.NationalCode, contact.NationalCode.Trim() ?? (object)DBNull.Value);

                    sqlCommand.Parameters.AddWithValue
                        (StorProcedureParametersName.AddresTable, contact.dtAddres ?? (object)DBNull.Value);

                    sqlCommand.Parameters.AddWithValue
                        (StorProcedureParametersName.PhoneTable, contact.dtPhone ?? (object)DBNull.Value);

                    var returnParameter =
                        sqlCommand.Parameters.Add(StorProcedureParametersName.ValidationResutlt, SqlDbType.Int);

                    returnParameter.Direction = ParameterDirection.Output;

                    sqlCommand.Parameters[StorProcedureParametersName.PhoneTable].SqlDbType =
                        SqlDbType.Structured;

                    sqlCommand.Parameters[StorProcedureParametersName.AddresTable].SqlDbType =
                        SqlDbType.Structured;

                    con.Open();

                    sqlCommand.ExecuteNonQuery();

                    ServerValidationResutlt = (ServerValidationEnum)returnParameter.Value;

                    con.Close();

                    return ServerValidationResutlt;
                }
            }
            catch (Exception ex)
            {
                Logger.Log(ex);

                return ServerValidationEnum.Error;
            }
        }

        #endregion

        #region Delete Contact

        public ServerValidationEnum DeleteContact(int ID)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString._ConnectionString))
            {
                try
                {
                    ServerValidationEnum validationResult =
                         new ServerValidationEnum();

                    SqlCommand sqlCommand =
                        new SqlCommand(StoreProcedureNames.DeleteContact, sqlConnection);

                    sqlCommand.CommandType =
                        CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue
                        (StorProcedureParametersName.ContactID, ID);

                    var returnParameter =
                        sqlCommand.Parameters.Add
                            (StorProcedureParametersName.ValidationResutlt, SqlDbType.Int);

                    returnParameter.Direction = ParameterDirection.Output;

                    sqlConnection.Open();

                    sqlCommand.ExecuteNonQuery();

                    validationResult = (ServerValidationEnum)returnParameter.Value;

                    sqlConnection.Close();

                    return validationResult;
                }

                catch (Exception ex)
                {
                    Logger.Log(ex);

                    return ServerValidationEnum.Error;
                }
            }

        }

        #endregion

        #region Metods

        #region Convert DataSet To list      

        protected override List<ContactClass> ConvertToList(DataSet dataSet)
        {
            try
            {
                ContactClass customer;

                List<ContactClass> contactList = new List<ContactClass>();

                foreach (DataRow dr in dataSet.Tables[0].Rows)
                {
                    customer = new ContactClass
                    {
                        ID = (int)dr["CustomerID"],
                        Code = (dr["Code"] == DBNull.Value ? null : dr["Code"].ToString()),
                        FirstName = (dr["FirstName"] == DBNull.Value ? null : dr["FirstName"].ToString()),
                        LastName = (dr["LastName"] == DBNull.Value ? null : dr["LastName"].ToString()),
                        NationalCode = (dr["NationalCode"] == DBNull.Value ? null : dr["NationalCode"].ToString()),
                        FatherName = (dr["FatherName"] == DBNull.Value ? null : dr["FatherName"].ToString())
                    };

                    contactList.Add(customer);
                }

                if (dataSet.Tables.Count == 1)
                    return contactList;

                for (int Counter = 0; Counter < dataSet.Tables[1].Rows.Count; Counter++)
                {
                    Phone phone = new Phone
                    {
                        ID =
                        int.Parse(dataSet.Tables[1].Rows[Counter]["PhoneID"].ToString()),
                        ContactID = int.Parse(dataSet.Tables[1].Rows[Counter]["CustomerID"].ToString()),
                        PhoneNumber = dataSet.Tables[1].Rows[Counter]["PhoneNumber"].ToString(),
                        PhoneType = int.Parse(dataSet.Tables[1].Rows[Counter]["PhoneTypeID"].ToString()),
                        RecordStatus = (int)RecordStatusEnum.Fix
                    };

                    foreach (ContactClass customerItem in contactList)
                        if (customerItem.ID == phone.ContactID)
                            customerItem.Phones.Add(phone);

                }

                for (int Counter = 0; Counter < dataSet.Tables[2].Rows.Count; Counter++)
                {
                    Address address = new Address
                    {
                        ID = int.Parse(dataSet.Tables[2].Rows[Counter]["AddressID"].ToString()),
                        ContactID = int.Parse(dataSet.Tables[2].Rows[Counter]["CustomerID"].ToString()),
                        AddressTitle = dataSet.Tables[2].Rows[Counter]["Address"].ToString(),
                        AddressType = int.Parse(dataSet.Tables[2].Rows[Counter]["AddressTypeID"].ToString()),
                        RecordStatus = (int)RecordStatusEnum.Fix
                    };

                    foreach (ContactClass CustomerItem in contactList)
                        if (CustomerItem.ID == address.ContactID)
                            CustomerItem.Addresses.Add(address);
                }
                return
                    contactList;
            }
            catch (Exception ex)
            {
                Logger.Log(ex);

                return null;
            }
        }

        #endregion

        #endregion
    }
}
