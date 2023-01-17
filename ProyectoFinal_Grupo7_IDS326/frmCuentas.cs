using ProyectoFinal_Grupo7_IDS326.Models;
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
            btnCrear.Visible = true;

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbTipo.SelectedIndex >= 0 && !String.IsNullOrEmpty(txtNoCuenta.Text) && !String.IsNullOrEmpty(txtAlias.Text) && !String.IsNullOrEmpty(txtBalance.Text))
                {
                    if(decimal.TryParse(txtBalance.Text,out decimal balance))
                    {
                        Program.usuario.crearCuenta(txtNoCuenta.Text, txtAlias.Text, balance, cmbTipo.SelectedItem.ToString());
                        MessageBox.Show("Cuenta creada correctamente", "Cuenta creada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarDatos();
                        VaciarCampos();
                    }
                    else
                        MessageBox.Show("El balance debe ser un numero.", "Balance no es númerico", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                    Helpers.MessageBoxCamposVacios();

            }
            catch (Exception ex)
            {
                Helpers.MessageBoxError(ex);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (cmbTipo.SelectedIndex >= 0 && String.IsNullOrEmpty(txtAlias.Text))
            {
                Cuentas cuenta = Program.usuario.cuentas.Find(c => c.NoCuenta == txtNoCuenta.Text);
                cuenta.ActualizarCuenta(cmbTipo.Text, txtAlias.Text);
                MessageBox.Show("Cuenta editada correctamente", "Cuenta editada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarDatos();
            }
            else
                Helpers.MessageBoxCamposVacios();


        }

        private void CargarDatos()
        {
            dt.Rows.Clear();
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

        private void VaciarCampos()
        {
            txtNoCuenta.Text = "";
            txtBalance.Text = "";
            txtAlias.Text = "";
            cmbTipo.ResetText();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            pnlLateral.Visible = false;
        }

        private void btnEditarCuenta_Click(object sender, EventArgs e)
        {
            if (dgvCuentas.SelectedCells.Count > 0)
            {
                pnlLateral.Visible = true;
                txtBalance.Enabled = false;
                txtNoCuenta.Enabled = false;
                btnCrear.Visible = false;
                btnEditar.Visible = true;
                int index = dgvCuentas.CurrentCell.RowIndex;
                DataGridViewRow dr = dgvCuentas.Rows[index];
                txtNoCuenta.Text = (string)dr.Cells[0].Value;
                txtAlias.Text = (string)dr.Cells[1].Value;
                txtBalance.Text = dr.Cells[2].Value.ToString();
                cmbTipo.SelectedText = (string)dr.Cells[3].Value;
            }
            else
                MessageBox.Show("Debe seleccionar una cuenta para editarla", "Seleccione una cuenta", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void btnEliminarCuenta_Click(object sender, EventArgs e)
        {
            if (dgvCuentas.SelectedCells.Count > 0)
            {
                DialogResult confirmacion = MessageBox.Show("¿Estás seguro que desea eliminar esta cuenta?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    int index = dgvCuentas.CurrentCell.RowIndex;
                    DataGridViewRow dr = dgvCuentas.Rows[index];
                    Program.usuario.cuentas.Remove(Program.usuario.cuentas.Find(x => x.NoCuenta == (string)dr.Cells[0].Value));
                    CargarDatos();
                    MessageBox.Show("Cuenta eliminada correctamente", "Cuenta eliminada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
                MessageBox.Show("Debe seleccionar una cuenta para eliminarla", "Seleccione una cuenta", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
}
