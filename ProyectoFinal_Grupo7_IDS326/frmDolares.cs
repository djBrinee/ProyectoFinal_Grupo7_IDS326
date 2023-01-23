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
    public partial class frmDolares : Form
    {
        DataTable dt = new DataTable();
        
        public frmDolares()
        {
            InitializeComponent();
        }

        private void frmDolares_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Tipo", typeof(string));
            dt.Columns.Add("No. Cuenta", typeof(string));
            dt.Columns.Add("Categoría", typeof(string));
            dt.Columns.Add("Monto", typeof(decimal));
            dt.Columns.Add("Moneda", typeof(string));
            dt.Columns.Add("Descripción", typeof(string));
            dt.Columns.Add("Fecha Creación", typeof(DateTime));
            dt.Columns.Add("Fecha Transacción", typeof(DateTime));
            foreach (Cuentas cuenta in Program.usuario.cuentas)
            {
                cmbCuentas.Items.Add(cuenta.Alias);
            }
        }

        private async void CargarDatos()
        {
            dt.Rows.Clear();
            Cuentas cuenta = Program.usuario.cuentas.Find(x => x.Alias == cmbCuentas.SelectedItem.ToString());
            if (cuenta.Transacciones.Count > 0)
            {
                BuscadorTasas buscadorTasas = new BuscadorTasas();
                ConvertidorMoneda convertidorMoneda = new ConvertidorMoneda(buscadorTasas);
                List<Task<Transacciones>> listaTasks = new List<Task<Transacciones>>();
                
                foreach (Transacciones transaccion in cuenta.Transacciones)
                {
                    listaTasks.Add(Task.Run(() => convertidorMoneda.ConvertidorTransaccionesPesosADolares(transaccion)));                    
                }
                progressBar1.Visible = true;
                progressBar1.MarqueeAnimationSpeed = 30;
                var TransaccionesEnDolares = await Task.WhenAll(listaTasks);
                progressBar1.Visible = false;
                progressBar1.MarqueeAnimationSpeed = 0;
                foreach (Transacciones transaccion in TransaccionesEnDolares)
                {
                    string[] lst = { transaccion.Id.ToString(), transaccion.Tipo, transaccion.NoCuenta, transaccion.Categoria, transaccion.Monto.ToString(), transaccion.Moneda, transaccion.Descripcion, transaccion.FechaCreacion.ToString(), transaccion.FechaTransaccion.ToString() };
                    dt.Rows.Add(lst);               
                }                 
            }
            dgvTransaccionesDolar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTransaccionesDolar.DataSource = dt;
        }
        private void cmbCuentas_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
