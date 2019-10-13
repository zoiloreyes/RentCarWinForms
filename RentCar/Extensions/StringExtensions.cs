using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Extensions
{
    public static class StringExtensions
    {
        public static bool CedulaValida(this string cedula)
        {
            var cedulaLimpia = cedula.Replace("-", "");
            int verificador = 0;
            int digito = 0;
            int digitoVerificador = 0;
            int digitoImpar = 0;
            int sumaPar = 0;
            int sumaImpar = 0;
            int longitud = Convert.ToInt32(cedulaLimpia.Length);


            try
            {
                if(longitud == 11) {
                    digitoVerificador = Convert.ToInt32(cedulaLimpia.Substring(10, 1));

                    for(int i = 9; i >= 0; i--)
                    {
                        digito = Convert.ToInt32(cedulaLimpia.Substring(i, 1));
                        if((i % 2) != 0)
                        {
                            digitoImpar = digito * 2;

                            if(digitoImpar >= 10)
                            {
                                digitoImpar = digitoImpar - 9;
                            }
                            sumaImpar = sumaImpar + digitoImpar;
                        }
                        else
                        {
                            sumaPar = sumaPar + digito;
                        }
                    }

                    verificador = 10 - ((sumaPar + sumaImpar) % 10);

                    if((verificador == 10) && (digitoVerificador == 0) || (verificador == digitoVerificador) )  {
                        return true; 
                    }
                }
            }catch(Exception e)
            {
                return false;
            }
            return false;
        }
    }
}
