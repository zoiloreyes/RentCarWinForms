using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Helpers
{
    public static class  StringExtensions
    {
        public static string GenerateUsername(this string name)
        {
            var nombres = name.Split(' ');
            if (nombres.Length == 1)
                return name;

            string username = "";
            for(int i = 0; i < nombres.Length - 1; i++)
            {
                if (String.IsNullOrWhiteSpace(nombres[i]))
                    continue;

                username += nombres[i][0];
            }
            username += nombres[nombres.Length - 1];

            return username;
        }
    }
}
