using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_Grupo7_IDS326.Models
{
    public class Cuentas
    {
        public string NoCuenta { get; set; }
        public string Alias { get; set; }
        public decimal Balance { get; set; }
        public string Tipo { get; set; }
        public DateTime? FechaCreacion { get; set; } = DateTime.Now;
        public List<Transacciones> Transacciones { get; set; } = new List<Transacciones>();

        public Cuentas(string NoCuenta, string Alias, decimal Balance, string Tipo)
        {
            this.NoCuenta = NoCuenta;
            this.Alias = Alias;
            this.Balance = Balance;
            this.Tipo = Tipo;
            this.FechaCreacion = DateTime.Now;
        }
        
        public bool ActualizarCuenta(string tipo, string alias)
        {
            try
            {
                Tipo = tipo;
                Alias = alias;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public decimal calcularBalance()
        {
            decimal balance = 0;    
         
            
               

            foreach (Transacciones transaccion in Transacciones)
            {
                if (transaccion.Tipo == "Ingreso" || transaccion.Tipo == "Inicial")
                {
                    balance += transaccion.Monto;
                }
                else
                {
                    balance -= transaccion.Monto;
                }                
            }
            return balance;
        }

    }

}
