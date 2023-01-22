using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_Grupo7_IDS326.Models
{
    class Helpers //static
    {
        public static void MessageBoxCamposVacios()
        {
            MessageBox.Show("Debe llenar todos los campos", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static void MessageBoxError(Exception ex)
        {
            MessageBox.Show(ex.ToString(), "Ha ocurrido un problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static List<Categorias> filtrarCategorias(List<Categorias> categorias, string tipo)
        {
            return categorias.FindAll(c => c.Tipo == tipo);            
        } 
        public static void SoloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }
    }
}
