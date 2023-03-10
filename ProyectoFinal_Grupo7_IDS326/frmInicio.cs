using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinal_Grupo7_IDS326.Models;
using System.Runtime.InteropServices;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProyectoFinal_Grupo7_IDS326
{
    public partial class frmInicio : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg,
        int wparam, int lparam);


        public frmInicio()
        {
            InitializeComponent();
        }
        
        private Form formActivo = null;
        private void AbrirFormHijo(Form formHijo)
        {
            if (formActivo != null)
                formActivo.Close();
            formActivo = formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(formHijo);
            pnlContenedor.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();
        }

        private void btnCuentas_Click(object sender, EventArgs e)
        {
            frmCuentas frmCuenta = new frmCuentas();
            AbrirFormHijo(frmCuenta);
        }
        private void btnInicio_Click(object sender, EventArgs e)
        {
            if (formActivo != null)
                formActivo.Close();
            object senderObj = new object();
            EventArgs eventObj = new EventArgs();
            frmInicio_Load(senderObj, eventObj);
        }
        private void btnCategorias_Click(object sender, EventArgs e)
        {
            frmCategorias frmCategoria = new frmCategorias();
            AbrirFormHijo(frmCategoria);
        }

        private void btnTransacciones_Click(object sender, EventArgs e)
        {
            frmTransacciones frmTransacciones = new frmTransacciones();
            AbrirFormHijo(frmTransacciones);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            var confirmacion = MessageBox.Show("¿Está seguro de cerrar la aplicación? Se eliminarán todos los cambios no guardados.", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmacion == DialogResult.Yes)
                Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnlSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            var cuentas = Program.usuario.cuentas.ToDictionary(keySelector: m => m.Alias, elementSelector: m => m.Balance);
            percentageChart.Series[0].ChartType = SeriesChartType.Doughnut;
            percentageChart.Series[0].Points.DataBindXY(cuentas.Keys, cuentas.Values);
            percentageChart.Legends[0].Enabled = true;            
            percentageChart.Legends[0].Alignment = StringAlignment.Center;            
            balanceChart.Series[0].ChartType = SeriesChartType.Bar;
            balanceChart.Series[0].Points.DataBindXY(cuentas.Keys, cuentas.Values);
            balanceChart.Legends[0].Enabled = false;



        }

        private void btnTransaccionesDolar_Click(object sender, EventArgs e)
        {
            frmDolares frmDolares = new frmDolares();
            AbrirFormHijo(frmDolares);
        }
    }
}
