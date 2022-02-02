using Cactus.Common.Interface;
using System;
using System.Collections.Generic;
using System.Data;

namespace Cactus.Inventory.Model
{
    public class Transaction : ITableBase,IFillDataTable 
    {
        #region Property        

        public int? ID { get; set; }     

        public string Number { get; set; }

        public DateTime Date { get; set; }

        public int InventoryID { get; set; }

        public int? CustomerID { get; set; }

        public string CustomerCode { get; set; }

        public int TransactionType { get; set; }

        public IList<TransactionDetail> TransctionDetails;

        public DataTable dtTransctionDetails { get; set; }

        public int RecordStatus { get; set; }

        #endregion

        #region Constructor

       public Transaction()
        {
            RecordStatus = 0;

            this.Date = DateTime.Now;

            TransctionDetails = new List<TransactionDetail>();
        }

        #endregion

        #region Metods

        public void InitializeTables()
        {
            dtTransctionDetails = new DataTable();

            this.dtTransctionDetails.Columns.AddRange
                (
                    new DataColumn[]
                    {
                        new DataColumn("ID",typeof(int)),
                        new DataColumn("TransctionID",typeof(int)),
                        new DataColumn("GoodsID",typeof(int)),
                        new DataColumn("NumberOfGoods",typeof(int)),
                        new DataColumn("Price",typeof(int)),
                        new DataColumn("RecordStatus",typeof(int))
                    }
                );
        }

        public void FillDataTable()
        {
            foreach (TransactionDetail transactionDetail in TransctionDetails)
            {
                DataRow row = this.dtTransctionDetails.NewRow();

                row["ID"] = transactionDetail.ID;
                row["TransctionID"] = 0;
                row["GoodsID"] = transactionDetail.Goods.ID;
                row["NumberOfGoods"] = transactionDetail.NumberOfGoods;
                row["Price"] = transactionDetail.Price;
                row["RecordStatus"] = transactionDetail.RecordStatus;

                dtTransctionDetails.Rows.Add(row);
            }
        }

        #endregion
    }
} 
