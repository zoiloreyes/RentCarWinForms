using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Models
{
    public class Usuario : IdentityUser
    {

        [Required]
        [MaxLength(300)]
        public string Nombre { get; set; }

        [Required]
        [MaxLength(300)]
        public string Apellido { get; set; }
    }
}
