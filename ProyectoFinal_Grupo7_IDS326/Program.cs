using ProyectoFinal_Grupo7_IDS326.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ProyectoFinal_Grupo7_IDS326
{
    internal static class Program
    {
        public static Usuario usuario = new Usuario();        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            usuario.crearCuenta("4023145535", "Popular", 14500, "Ahorro");
            usuario.crearCategoria("Servicios", "Gasto");
            usuario.crearCategoria("Salario", "Ingreso");
            usuario.crearTransaccion("Ingreso", "4023145535", "Salario", 15000, "DOP", "Quincena", DateTime.Now);
            usuario.crearTransaccion("Gasto", "4023145535", "Servicios", 500, "DOP", "Gasto de energía",DateTime.Now);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmInicio());
        }
    }
}
