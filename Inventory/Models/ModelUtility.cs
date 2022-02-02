namespace Cactus.Inventory.Model
{
    public class ModelUtility
    {
        public enum PhoneTypeEnum
        {
            Mobile = 1,
            Phone = 2,
            fax = 3
        }

        public enum AddressTypeEnum
        {
            WorkPlace = 1,
            Address = 2
        }

        public enum TypeEnum
        {
            PhoneType = 0,
            AddressType = 1
        }

        public enum TransactionTypeEnum
        {
            Input = 1,
            Output=2
        }
    }
}