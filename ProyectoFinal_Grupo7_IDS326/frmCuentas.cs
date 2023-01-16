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
        DataTable dt = new DataTable();
        
        public frmCuentas()
        {
            InitializeComponent();
        }

        private void frmCuentas_Load(object sender, EventArgs e)
        {
            pnlLateral.Visible = false;
            dt.Columns.Add("No. Cuenta", typeof(string));
            dt.Columns.Add("Alias", typeof(string));
            dt.Columns.Add("Balance", typeof(decimal));
            dt.Columns.Add("Tipo", typeof(string));
            CargarDatos();
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
                CargarDatos();
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

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void CargarDatos()
        {
            if (Program.usuario.cuentas.Count > 0)
            {
                foreach (var item in Program.usuario.cuentas)
                {
                    string[] lst = {item.NoCuenta, item.Alias, item.Balance.ToString(), item.Tipo};
                    dt.Rows.Add(lst);
                }
            }
            dgvCuentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCuentas.DataSource = dt;
        }
    }
}
