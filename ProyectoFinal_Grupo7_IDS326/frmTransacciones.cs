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
    public partial class frmTransacciones : Form
    {
        IBuscadorTasas buscadorTasas = new BuscadorTasas();

        DataTable dt = new DataTable();

        public frmTransacciones()
        {
            InitializeComponent();
        }
        private void frmTransacciones_Load(object sender, EventArgs e)
        {
            pnlLateral.Visible = false;
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Tipo", typeof(string));
            dt.Columns.Add("No. Cuenta", typeof(string));
            dt.Columns.Add("Categoría", typeof(string));
            dt.Columns.Add("Monto", typeof(decimal));
            dt.Columns.Add("Moneda", typeof(string));
            dt.Columns.Add("Descripción", typeof(string));
            dt.Columns.Add("Fecha Creación", typeof(DateTime));
            dt.Columns.Add("Fecha Transacción", typeof(DateTime));
            foreach(Cuentas cuenta in Program.usuario.cuentas)
            {
                cmbCuentas.Items.Add(cuenta.Alias);
                cmbNoCuenta.Items.Add(cuenta.NoCuenta);
            }
            foreach (Categorias categoria in Program.usuario.categorias)
            {
                cmbCategoria.Items.Add(categoria.Nombre);
            }
        }

        private void btnCrearTransaccion_Click(object sender, EventArgs e)
        {
            var sv = cmbMoneda.SelectedValue;
            pnlLateral.Visible = true;
            btnEditar.Visible = false;
            btnCrear.Visible = true;
            txtMonto.Enabled = true;
            cmbNoCuenta.Enabled = true;
            txtDescripcion.Enabled = true;
            cmbCategoria.Enabled = true;
            cmbCuentas.Enabled = true;
            cmbMoneda.Enabled = true;
            cmbTipo.Enabled = true;
        }

        private async void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbTipo.SelectedIndex >= 0 && cmbNoCuenta.SelectedIndex >= 0 && cmbCategoria.SelectedIndex >= 0 && !String.IsNullOrEmpty(txtMonto.Text) && cmbMoneda.SelectedIndex >= 0 && !String.IsNullOrEmpty(txtDescripcion.Text) && !String.IsNullOrEmpty(dtpFechaTransaccion.Text))
                {
                    if(decimal.TryParse(txtMonto.Text,out decimal monto))
                    {
                        string moneda = cmbMoneda.SelectedItem.ToString();
                        
                        if (cmbMoneda.Text == "USD")
                        {
                            ConvertidorMoneda convertidor = new ConvertidorMoneda(buscadorTasas);
                            Task<decimal> task = convertidor.ConvertidorDolaresAPesos(monto);
                            progressBar1.Visible = true;
                            progressBar1.MarqueeAnimationSpeed = 30;
                            monto = await task;
                            progressBar1.Visible = false;
                            progressBar1.MarqueeAnimationSpeed = 0;
                            moneda = "DOP";
                        }
                        Cuentas cuenta = Program.usuario.cuentas.Find(c => c.NoCuenta == cmbNoCuenta.SelectedItem.ToString());
                        Program.usuario.crearTransaccion(cmbTipo.SelectedItem.ToString(), cuenta, cmbCategoria.SelectedItem.ToString(), monto, moneda, txtDescripcion.Text, dtpFechaTransaccion.Value);
                        MessageBox.Show("Transacción creada correctamente", "Transacción creada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarDatos();
                        VaciarCampos();
                    }
                    else
                        MessageBox.Show("El monto debe ser un numero.", "Monto no es númerico", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                    Helpers.MessageBoxCamposVacios();

            }
            catch (Exception ex)
            {
                Helpers.MessageBoxError(ex);
            }
        }
        private void btnEditarTransaccion_Click(object sender, EventArgs e)
        {
            if (dgvTransacciones.SelectedCells.Count > 0)
            {
                pnlLateral.Visible = true;
                txtMonto.Enabled = true;
                cmbNoCuenta.Enabled = false;
                txtDescripcion.Enabled = true;
                cmbCategoria.Enabled = true;
                cmbCuentas.Enabled = true;
                cmbMoneda.Enabled = true;
                cmbTipo.Enabled = false;
                dtpFechaTransaccion.Enabled = true;
                btnCrear.Visible = false;
                btnEditar.Visible = true;
                int index = dgvTransacciones.CurrentCell.RowIndex;
                DataGridViewRow dr = dgvTransacciones.Rows[index];
                if((string)dr.Cells[1].Value == "Ingreso")
                    cmbTipo.SelectedIndex = 0;
                else
                    cmbTipo.SelectedIndex = 1;
                cmbNoCuenta.Text = (string)dr.Cells[2].Value;
                EventArgs env = new EventArgs();
                object mSender = new object();
                cmbTipo_SelectedIndexChanged(mSender,env);
                cmbCategoria.Text = dr.Cells[3].Value.ToString();
                txtMonto.Text = dr.Cells[4].Value.ToString();
                cmbMoneda.Text = (string)dr.Cells[5].Value;
                txtDescripcion.Text = (string)dr.Cells[6].Value;
                dtpFechaTransaccion.Value = (DateTime)dr.Cells[8].Value;
            }
            else
                MessageBox.Show("Debe seleccionar una transacción para editarla", "Seleccione una transacción", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
        private async void btnEditar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(dtpFechaTransaccion.Text) && !String.IsNullOrEmpty(txtMonto.Text) && !String.IsNullOrEmpty(cmbCategoria.Text) && !String.IsNullOrEmpty(cmbMoneda.Text) && !String.IsNullOrEmpty(txtDescripcion.Text))
            {
                int index = dgvTransacciones.CurrentCell.RowIndex;
                DataGridViewRow dr = dgvTransacciones.Rows[index];
                Cuentas cuenta = Program.usuario.cuentas.Find(c => c.NoCuenta == (string)dr.Cells[2].Value);
                Transacciones transaccion = cuenta.Transacciones.Find(c => c.Id == (int)dr.Cells[0].Value);
                if(Decimal.TryParse(txtMonto.Text, out decimal monto))
                {
                    string moneda = cmbMoneda.SelectedItem.ToString();
                    if (cmbMoneda.Text == "USD")
                    {
                        ConvertidorMoneda convertidor = new ConvertidorMoneda(buscadorTasas);
                        monto = await convertidor.ConvertidorDolaresAPesos(monto);
                        moneda = "DOP";
                    }
                    MessageBox.Show("Transacción editada correctamente", "Transacción editada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    transaccion.ActualizarTransaccion(cmbCategoria.Text, monto, moneda, txtDescripcion.Text, dtpFechaTransaccion.Value, cuenta);
                }
                else
                    MessageBox.Show("El monto debe ser un número.", "Monto no numerico", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarDatos();
            }
            else
                Helpers.MessageBoxCamposVacios();


        }
        private void btnEliminarTransaccion_Click(object sender, EventArgs e)
        {
            if (dgvTransacciones.SelectedCells.Count > 0)
            {
                DialogResult confirmacion = MessageBox.Show("¿Está seguro que desea eliminar esta transacción?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    int index = dgvTransacciones.CurrentCell.RowIndex;
                    DataGridViewRow dr = dgvTransacciones.Rows[index];
                    Cuentas cuenta = Program.usuario.cuentas.Find(x => x.NoCuenta == (string)dr.Cells[2].Value);
                    cuenta.Transacciones.Remove(cuenta.Transacciones.Find(x => x.Id == (int)dr.Cells[0].Value));
                    cuenta.Balance = cuenta.calcularBalance();
                    CargarDatos();
                    MessageBox.Show("Transacción eliminada correctamente", "Transacción eliminada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
                MessageBox.Show("Debe seleccionar una transacción para eliminarla", "Seleccione una transacción", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void CargarDatos()
        {
            dt.Rows.Clear();
            if (cmbCuentas.SelectedIndex != -1)
            {
                Cuentas cuenta = Program.usuario.cuentas.Find(x => x.Alias == cmbCuentas.SelectedItem.ToString());
                if (cuenta.Transacciones.Count > 0)
                {
                    foreach (Transacciones transaccion in cuenta.Transacciones)
                    {
                        string[] lst = { transaccion.Id.ToString(), transaccion.Tipo, transaccion.NoCuenta, transaccion.Categoria, transaccion.Monto.ToString(), transaccion.Moneda, transaccion.Descripcion, transaccion.FechaCreacion.ToString(), transaccion.FechaTransaccion.ToString() };
                        dt.Rows.Add(lst);
                    }
                }
                dgvTransacciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvTransacciones.DataSource = dt;
            }
        }

        private void VaciarCampos()
        {
            cmbNoCuenta.SelectedItem = null;
            cmbCategoria.SelectedItem = null;
            cmbMoneda.SelectedItem = null; 
            cmbTipo.Text = ""; 
            txtMonto.Clear();
            txtDescripcion.Clear();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            pnlLateral.Visible = false;
        }     

        private void cmbCuentas_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }
        
        public void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCategoria.Items.Clear();
            List<Categorias> categorias = Helpers.filtrarCategorias(Program.usuario.categorias, cmbTipo.Items[cmbTipo.SelectedIndex].ToString());
            foreach(Categorias categoria in categorias)
            {
                cmbCategoria.Items.Add(categoria.Nombre);
            }            
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helpers.SoloNumeros(sender, e);
        }
    }
}
