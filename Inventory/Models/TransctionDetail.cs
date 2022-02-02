namespace Cactus.Inventory.Model
{
    public class TransactionDetail
    {
        #region Property

        public int ID { get; set; }

        public int TransactionID { get; set; }

        public Goods Goods { get; set; }

        public int NumberOfGoods { get; set; }

        public int Price { get; set; }

        public int RecordStatus { get; set; }

        #endregion

        #region Constructor

        public TransactionDetail()
        {
            this.Goods = new Goods();

            this.RecordStatus = 0;
        } 

        #endregion
    }
}
