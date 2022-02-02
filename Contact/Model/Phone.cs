using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Cactus.Common.Model.ModelUtility;

namespace Cactus.Contact.Model
{
    public class Phone
    {
        #region Property

        public int ID { get; set; }

        public int ContactID { get; set; }

        public string PhoneNumber { get; set; }

        public int PhoneType { get; set; }

        public int RecordStatus { get; set; }

        #endregion

        #region Constructoes

        public Phone()
        {
            this.RecordStatus = (int)RecordStatusEnum.Fix;
        }

        #endregion
    }
}
