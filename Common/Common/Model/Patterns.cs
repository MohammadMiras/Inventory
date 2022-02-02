using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cactus.Common.Model
{
  public static class  Patterns
    {
        public static string ConnectionStringPatternNoUP = @"Data Source={0};Initial Catalog={1};Integrated Security=True";

        public static string ConnectionStringPatternWithUP = @"Data Source = {0};Initial Catalog ={1};Integrated Security = False;User ID = {2};Password = {3}";

    }
}
