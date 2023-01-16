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
        public int IdCuenta { get; set; }
        public int IdCategoria { get; set; }
        public decimal Monto { get; set; }
        public string Moneda { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
    }
}
