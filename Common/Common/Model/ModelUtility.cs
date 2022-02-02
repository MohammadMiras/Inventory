using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cactus.Common.Model
{
  public static  class ModelUtility
    {
        public enum RecordStatusEnum
        {
            Insert = 1,

            Update = 2,

            Delete = 3,

            Fix = 0
        }

        public enum ValidationTypeEnum
        {
            Client = 0,

            Server = 1
        }

        public enum ServerValidationEnum
        {
            NoProblem = 0,

            DuplicateCode = 1,

            ConversionCode = 2,

            InsertMoreStock = 3,

            Error = 4,

            ThereIsTransaction = 5,

            NoCategory = 6,

            NovalidUser = 7,

            DuplicateUserName = 8,

            ConversionUserName = 9,

            noRole = 10,

            DuplicateRoleTitle = 11,

            ThereIsCategoryInGoods =12
        }

        public enum ClientValidationEnum
        {
            NoProblem = 0,

            NationalcodelengtIsLong = 1,

            PhonePatternIsIncorrect = 2
        }

        public enum StatusHasDitailEnum
        {
            No = 0,

            Yes = 1
        }

        public enum FormModeEnum
        {
            New = 0,

            Edit = 1,

            Review = 2,

            Select = 3,

            SelectMultiple = 4
        }

        public enum ObjectSystemEnum
        {
            InsertInventory = 1,
            DeleteInsert = 2,
            UpdateInventory = 3,
            InsertGoods = 4,
            DeleteGoods = 5,
            UpdateGoods = 6,
            InsertCustomer = 7,
            DeleteCustomer = 8,
            UpdateCustomer = 9,
            InsertTransaction = 10,
            DeleteTransaction = 11,
            UpdateTransaction = 12,
            GetReport = 13,
            PrintReport = 14,
            InsertUser = 15,
            DeleteUser = 16,
            UpdateUsers = 17,
            UpdateUser = 18,
            AddConectionString = 19,
            Inventory = 20,
            Goods = 21,
            Customer = 22,
            Report = 23,
            SystemManagement = 24,
            UpdateCurrentUser = 25,
            Transaction = 26
        }
    }
}
