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

        private void frmCuentas_Load(object sender, EventArgs e)
        {
            pnlLateral.Visible = false;
            foreach (var item in Program.usuario.cuentas)
            {
                cmbCuentas.Items.Add(item.Alias);
            }
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            pnlLateral.Visible = true;
            btnEditar.Visible = false;

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                Program.usuario.crearCuenta(txtNoCuenta.Text, txtAlias.Text, decimal.Parse(txtBalance.Text), cmbTipo.SelectedItem.ToString());
                MessageBox.Show("Cuenta creada correctamente", "Cuenta creada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbCuentas.Items.Add(txtAlias.Text);                              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ha ocurrido un problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrarPnlSuperior_Click(object sender, EventArgs e)
        {
            pnlLateral.Visible = false;
        }       
    }
}
