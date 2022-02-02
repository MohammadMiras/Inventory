using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static Cactus.Common.Model.ModelUtility;
using static Cactus.Contact.Model.ModelUtility;

namespace Cactus.Contact.Model
{
  public static  class Validatin
    {
        #region Is Chacking  NationalCode

        public static bool IsValidIranianNationalCode( this Contact contact)
        {
            if (!Regex.IsMatch(contact.NationalCode, Patterns.NationalCodeLength))
                return false;

            var check = Convert.ToInt32(contact.NationalCode.Substring(9, 1));

            var sum = Enumerable.Range(0, 9)

                .Select(x => Convert.ToInt32(contact.NationalCode.Substring(x, 1)) * (10 - x))

                .Sum() % 11;

            return sum < 2 ? check == sum : check + sum == 11;
        }

        #endregion

        #region Checking phone number 

        public static ClientValidationEnum IsValidPhone(this Phone phone)
        {
            switch ((PhoneTypeEnum)phone.PhoneType)
            {
                case PhoneTypeEnum.Mobile:
                    {
                        if (IsMatchPattern(phone.PhoneNumber, Patterns.Mobile))

                            return ClientValidationEnum.NoProblem;
                        else
                            return ClientValidationEnum.PhonePatternIsIncorrect;
                    }

                default:
                    {
                        if (IsMatchPattern(phone.PhoneNumber, Patterns.Home))

                            return
                               ClientValidationEnum.NoProblem;

                        return
                            ClientValidationEnum.PhonePatternIsIncorrect;
                    }
            }
        }

        #endregion

        #region Chack Code length

        public static bool AreContactCodeValid( string code, int len = 4)
        {
            return
                code.Length == len ? true : false;
        }

        #endregion

        #region Is Match  Pattern

        private static bool IsMatchPattern(this string PhoneNumber, string Pattern)
        {
            return
                  Regex.IsMatch
                  (
                      PhoneNumber,
                      Pattern
                   );
        }

        #endregion
    }
}
