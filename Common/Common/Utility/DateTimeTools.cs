using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cactus.Common.Utility
{
 public static  class DateTimeTools
    {
        public static string MinDate = "1350/01/01";//Default Min Date Shamsi

        public static string MaxDate = "3000/01/01";//Default Max Date Shamsi    

        //==================< Data Time >======================

        public static DateTime ConvertStringToDateMiladi(this String Date)
        {
            try
            {
                string[] split = Date.Split('/');

                DateTime date = new DateTime(Convert.ToInt32(split[0]), Convert.ToInt32(split[1]), Convert.ToInt32(split[2]));

                return ConvertShamsiToMiladi(date);

            }
            catch (Exception )
            {
                return new DateTime(); ;
            }
        }

        public static string MiladiToShamsi(this DateTime date)
        {
            PersianCalendar persian = new PersianCalendar();

            string persianDate = string.Format(
                                                    "{0}/{1}/{2}",
                                                    persian.GetYear(date),
                                                    persian.GetMonth(date),
                                                    persian.GetDayOfMonth(date)
                                               );
            return persianDate;
        }

        private static DateTime ConvertShamsiToMiladi(DateTime dateShamsi)
        {
            PersianCalendar p = new PersianCalendar();

            DateTime date = p.ToDateTime
                (
                    dateShamsi.Year,
                    dateShamsi.Month,
                    dateShamsi.Day,
                    dateShamsi.Hour,
                    dateShamsi.Minute,
                    dateShamsi.Second,
                    dateShamsi.Millisecond
                );

            return date;
        }
    }
}
