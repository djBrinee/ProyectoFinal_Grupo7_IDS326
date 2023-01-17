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
        public List<Categorias> categorias { get; set; } =  new List<Categorias>();

        public bool crearCuenta(string NoCuenta, string Alias, decimal balance, string tipo)
        {
            try
            {
                Cuentas cuenta = new Cuentas(NoCuenta, Alias, balance, tipo);               
                cuentas.Add(cuenta);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool crearCategoria(string nombre)
        {
            try
            {
                Categorias categoria = new Categorias(nombre);
                categorias.Add(categoria);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }


}
