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
        }
        private void btnCategorias_Click(object sender, EventArgs e)
        {
            frmCategorias frmCategoria = new frmCategorias();
            AbrirFormHijo(frmCategoria);
        }
    }
}
