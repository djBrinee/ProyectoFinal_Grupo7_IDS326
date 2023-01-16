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

namespace ProyectoFinal_Grupo7_IDS326
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            foreach (var item in Program.usuario.cuentas)
            {
                cmbCuentas.Items.Add(item.Alias);
            }
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            frmCuentas cuentas = new frmCuentas();          
            cuentas.Show();
        }
    }
}
