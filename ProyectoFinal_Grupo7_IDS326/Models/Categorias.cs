using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_Grupo7_IDS326.Models
{
    public class Categorias
    {
        public string Nombre { get; set; }
        public string Tipo { get; set; }

        public Categorias(string nombre, string tipo)
        {
            this.Nombre = nombre;
            this.Tipo = tipo;
        }

        public bool ActualizarCategoria(string nombre)
        {
            try
            {
                Nombre = nombre;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }

   
}
