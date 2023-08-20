using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employer
{
    static class Utility
    {
        public static DateTime ConvertToDate(string input)
        {
            return DateTime.Parse(input);
        }

    }
}
