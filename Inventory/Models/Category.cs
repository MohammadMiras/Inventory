namespace Cactus.Inventory.Model
{
    public  class Category
    {
        #region property

        public int ID { get; set; }

        public string Name { get; set; }

        public int RecordStatus { get; set; }

        #endregion

        #region Constructor

        public Category()
        {
            this.RecordStatus = 0;
        } 

        #endregion
    }
}
