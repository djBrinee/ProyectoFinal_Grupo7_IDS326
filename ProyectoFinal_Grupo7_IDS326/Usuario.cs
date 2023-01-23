using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinal_Grupo7_IDS326.Models;

namespace ProyectoFinal_Grupo7_IDS326
{
    public class Usuario
    {
        public List<Cuentas> cuentas { get; set; } =  new List<Cuentas>();
        public List<Categorias> categorias { get; set; } =  new List<Categorias>();

        public Cuentas crearCuenta(string NoCuenta, string Alias, decimal balance, string tipo)
        {
            if (!long.TryParse(NoCuenta, out long Salida)) 
                throw new ArgumentException("No. Cuenta debe ser digitado como número ") ;
            try

            {
               

                Cuentas cuenta = new Cuentas(NoCuenta, Alias, balance, tipo);               
                this.cuentas.Add(cuenta);
                if (balance > 0)
                {
                    Program.usuario.crearTransaccion("Inicial", cuenta, "Inicial", balance, "DOP", "Monto Inicial", DateTime.Now);
                }

                return cuenta;
            }
            catch (Exception)
            {
                return null;
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
        public bool crearTransaccion(string Tipo, Cuentas cuenta, string Categoria, decimal Monto, string Moneda, string Descripcion, DateTime FechaTransaccion)
        {
            try
            {
                int id;
                //Cuentas cuenta = this.cuentas.Find(c => c.NoCuenta == NoCuenta);
                if(cuenta.Transacciones.Count > 0)
                    id = cuenta.Transacciones.Last().Id + 1;
                else
                    id = 1;
                Transacciones transaccion = new Transacciones(id, Tipo, cuenta.NoCuenta, Categoria, Monto, Moneda, Descripcion, FechaTransaccion); //Usar DI?
                if (Tipo == "Ingreso" || Tipo == "Inicial")
                    cuenta.Balance = cuenta.calcularBalance() + Monto;
                else
                    cuenta.Balance = cuenta.calcularBalance() - Monto;
                cuenta.Transacciones.Add(transaccion);
                
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

    }


}
