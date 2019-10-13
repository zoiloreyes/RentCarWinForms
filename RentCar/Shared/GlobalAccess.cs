using RentCar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCar.Shared
{
    public class GlobalAccess
    {
        public static Usuario Usuario { get; set; }
        public static Form  BaseAccesForm { get; set; }
    }
}
