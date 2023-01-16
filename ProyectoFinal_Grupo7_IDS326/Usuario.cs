using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinal_Grupo7_IDS326.Models;

namespace ProyectoFinal_Grupo7_IDS326
{
    public class Usuario
    {
        public List<Cuentas> cuentas { get; set; } =  new List<Cuentas>();

        public bool crearCuenta(string NoCuenta, string Alias, decimal balance, string tipo)
        {
            try
            {
                Cuentas cuenta = new Cuentas()
                {
                    NoCuenta = NoCuenta,
                    Alias = Alias,
                    Balance = balance,
                    Tipo = tipo
                };
                cuentas.Add(cuenta);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        } 

    }


}
