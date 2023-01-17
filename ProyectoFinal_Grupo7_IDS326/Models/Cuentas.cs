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

    }

}
