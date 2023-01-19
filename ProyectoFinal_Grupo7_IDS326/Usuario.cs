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
        public bool crearCategoria(string nombre, string tipo)
        {
            try
            {
                Categorias categoria = new Categorias(nombre, tipo);
                categorias.Add(categoria);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool crearTransaccion(string Tipo, string NoCuenta, string Categoria, decimal Monto, string Moneda, string Descripcion, DateTime FechaTransaccion)
        {
            try
            {
                int id;
                Cuentas cuenta = cuentas.Find(c => c.NoCuenta == NoCuenta);
                if(cuenta.Transacciones.Count > 0)
                    id = cuenta.Transacciones.Last().Id + 1;
                else
                    id = 1;
                Transacciones transaccion = new Transacciones(id, Tipo, NoCuenta, Categoria, Monto, Moneda, Descripcion, FechaTransaccion); //Usar DI?
                cuenta.Transacciones.Add(transaccion);
                cuenta.Balance = cuenta.calcularBalance();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

    }


}
