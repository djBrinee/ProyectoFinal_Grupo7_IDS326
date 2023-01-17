using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_Grupo7_IDS326.Models
{
    class Helpers
    {
        public static void MessageBoxCamposVacios()
        {
            MessageBox.Show("Cuenta editada correctamente", "Cuenta editada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void MessageBoxError(Exception ex)
        {
            MessageBox.Show(ex.ToString(), "Ha ocurrido un problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
