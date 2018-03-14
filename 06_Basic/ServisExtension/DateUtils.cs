using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceExtension
{
    public class DateUtils
    {
        public static int DateDifference(DateTime first, DateTime substruct)
        {
            int yearDifference = first.Year - substruct.Year;
            if (first.Month > substruct.Month || (first.Month == substruct.Month && first.Day < substruct.Day))
            {
                yearDifference--;
            }
            return yearDifference;
        }
    }
}
