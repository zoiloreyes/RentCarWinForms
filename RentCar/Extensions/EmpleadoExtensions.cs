using RentCar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Extensions
{
    public static class EmpleadoExtensions
    {
        public static string GenerateUserName(this Empleado empleado)
        {
            if (String.IsNullOrWhiteSpace(empleado.Nombre))
                throw new NullReferenceException("Propiedad Nombre no válida");

            if (String.IsNullOrWhiteSpace(empleado.Apellido))
                throw new NullReferenceException("Propiedad Apellido no válida");

            string username = $"{char.ToLower(empleado.Nombre.First())}{empleado.Apellido.Split().First().ToLower()}";
            return username;
        }
    }
}
