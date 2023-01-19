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
    public partial class frmCategorias : Form
    {
        DataTable dt = new DataTable();
        
        public frmCategorias()
        {
            InitializeComponent();
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            pnlLateral.Visible = false;
            dt.Columns.Add("Nombre", typeof(string));
            dt.Columns.Add("Tipo", typeof(string));
            CargarDatos();
        }

        private void btnCrearCategoria_Click(object sender, EventArgs e)
        {
            pnlLateral.Visible = true;
            btnEditar.Visible = false;
            cmbTipo.Enabled = true;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(txtNombre.Text) && !String.IsNullOrEmpty(cmbTipo.SelectedItem.ToString()))
                {
                    Program.usuario.crearCategoria(txtNombre.Text, cmbTipo.SelectedItem.ToString());
                    MessageBox.Show("Categoría creada correctamente", "Categoría creada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDatos();
                    VaciarCampos();

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
            if (txtNombre.Text != "")
            {
                string valorAnterior = dgvCategorias.Rows[dgvCategorias.CurrentCell.RowIndex].Cells[0].Value.ToString();
                Categorias categoria = Program.usuario.categorias.Find(c => c.Nombre == valorAnterior);
                categoria.ActualizarCategoria(txtNombre.Text);
                MessageBox.Show("Categoría editada correctamente", "Categoría editada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarDatos();
            }
            else
                Helpers.MessageBoxCamposVacios();
        }

        private void CargarDatos()
        {
            dt.Rows.Clear();
            if (Program.usuario.categorias.Count > 0)
            {
                foreach (var item in Program.usuario.categorias)
                {
                    string[] lst = {item.Nombre, item.Tipo};
                    dt.Rows.Add(lst);
                }
            }
            dgvCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategorias.DataSource = dt;
        }

        private void VaciarCampos()
        {
            txtNombre.Text = "";            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            pnlLateral.Visible = false;
        }

        private void btnEditarCategoria_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.SelectedCells.Count > 0)
            {
                pnlLateral.Visible = true;
                btnCrear.Visible = false;
                btnEditar.Visible = true;
                cmbTipo.Enabled = false;
                int index = dgvCategorias.CurrentCell.RowIndex;
                DataGridViewRow dr = dgvCategorias.Rows[index];
                txtNombre.Text = (string)dr.Cells[0].Value;
            }
            else
                MessageBox.Show("Debe seleccionar una categoría para editarla", "Seleccione una categoría", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.SelectedCells.Count > 0)
            {
                DialogResult confirmacion = MessageBox.Show("¿Estás seguro que desea eliminar esta categoría?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    int index = dgvCategorias.CurrentCell.RowIndex;
                    DataGridViewRow dr = dgvCategorias.Rows[index];
                    Program.usuario.categorias.Remove(Program.usuario.categorias.Find(x => x.Nombre == (string)dr.Cells[0].Value));
                    CargarDatos();
                    MessageBox.Show("Categoría eliminada correctamente", "Categoría eliminada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                MessageBox.Show("Debe seleccionar una categoría para eliminarla", "Seleccione una categoría", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }      
    }
}
