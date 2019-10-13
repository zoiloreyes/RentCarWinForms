using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Extensions
{
    public static class DateTimeExtensions
    {
        public static string ToString(this DateTime? dt, string format)
    => dt == null ? "N/A" : ((DateTime)dt).ToString(format);
    }
}
