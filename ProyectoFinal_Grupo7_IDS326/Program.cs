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
            usuario.crearCategoria("Servicios", "Gasto");
            usuario.crearCategoria("Salario", "Ingreso");
            Cuentas cuenta = usuario.crearCuenta("4023145535", "Popular", 14500, "Ahorro"); //Cuenta ejemplo 1            
            usuario.crearTransaccion("Ingreso", cuenta, "Salario", 15000, "DOP", "Quincena", DateTime.Now);
            usuario.crearTransaccion("Gasto", cuenta, "Servicios", 500, "DOP", "Gasto de energía",DateTime.Now); //Cuenta ejemplo 2
            usuario.crearCuenta("4023145535", "Personal", 38000, "Ahorro");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmInicio());
        }
    }
}
