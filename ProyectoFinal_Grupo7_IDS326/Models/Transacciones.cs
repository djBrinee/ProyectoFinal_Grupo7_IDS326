using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_Grupo7_IDS326.Models
{
    public class Transacciones
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string NoCuenta { get; set; }
        public string Categoria { get; set; }
        public decimal Monto { get; set; }
        public string Moneda { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public DateTime FechaTransaccion { get; set; }


        public Transacciones(int Id, string Tipo, string NoCuenta, string Categoria, decimal Monto, string Moneda, string Descripcion, DateTime FechaTransaccion)
        {
            this.Id = Id;
            this.Tipo = Tipo;
            this.NoCuenta = NoCuenta;
            this.Categoria = Categoria;
            this.Monto = Monto;
            this.Moneda = Moneda;
            this.Descripcion = Descripcion;
            this.FechaCreacion = DateTime.Now;
            this.FechaTransaccion = FechaTransaccion;
        }

        public bool ActualizarTransaccion(string Categoria, decimal Monto, string Moneda, string Descripcion, DateTime FechaTransaccion, Cuentas cuenta)
        {
            try
            {
                this.Categoria = Categoria;
                this.Monto = Monto;
                this.Moneda = Moneda;
                this.Descripcion = Descripcion;
                this.FechaTransaccion = FechaTransaccion;
                cuenta.Balance = cuenta.calcularBalance();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
