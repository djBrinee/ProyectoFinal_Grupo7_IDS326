using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_Grupo7_IDS326
{
    public partial class frmCuentas : Form
    {
        public frmCuentas()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Program.usuario.crearCuenta(txtNoCuenta.Text, txtAlias.Text, decimal.Parse(txtBalance.Text), cmbTipo.SelectedItem.ToString());
            MessageBox.Show("Cuenta creada");
        }
    }
}
