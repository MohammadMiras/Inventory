using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cactus.Contact.Model
{
  public static  class Patterns
    {
        public static string Mobile = "^09[-.\\s]?\\d{2}[-.\\s]?\\d{3}[-.\\s]?\\d{4}$";

        public static String Home = "^(\\+98|0)?\\d{10}$";

        public static string NationalCodeLength = @"^\d{10}$";
    }
}
