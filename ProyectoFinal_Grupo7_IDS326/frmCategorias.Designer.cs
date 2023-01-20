namespace ProyectoFinal_Grupo7_IDS326
{
    partial class frmCategorias
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTransaccion = new System.Windows.Forms.Button();
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.btnEditarCategoria = new System.Windows.Forms.PictureBox();
            this.btnEliminarCuenta = new System.Windows.Forms.PictureBox();
            this.btnCrearCuenta = new System.Windows.Forms.PictureBox();
            this.pnlLateral = new System.Windows.Forms.Panel();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditarCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminarCuenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCrearCuenta)).BeginInit();
            this.pnlLateral.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTransaccion
            // 
            this.btnTransaccion.Location = new System.Drawing.Point(441, 391);
            this.btnTransaccion.Margin = new System.Windows.Forms.Padding(2);
            this.btnTransaccion.Name = "btnTransaccion";
            this.btnTransaccion.Size = new System.Drawing.Size(110, 19);
            this.btnTransaccion.TabIndex = 15;
            this.btnTransaccion.Text = "Crear transaccion";
            this.btnTransaccion.UseVisualStyleBackColor = true;
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.Controls.Add(this.btnEditarCategoria);
            this.pnlSuperior.Controls.Add(this.btnEliminarCuenta);
            this.pnlSuperior.Controls.Add(this.btnCrearCuenta);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(729, 41);
            this.pnlSuperior.TabIndex = 20;
            // 
            // btnEditarCategoria
            // 
            this.btnEditarCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarCategoria.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEditarCategoria.Image = global::ProyectoFinal_Grupo7_IDS326.Properties.Resources.update;
            this.btnEditarCategoria.Location = new System.Drawing.Point(617, 0);
            this.btnEditarCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditarCategoria.Name = "btnEditarCategoria";
            this.btnEditarCategoria.Size = new System.Drawing.Size(37, 41);
            this.btnEditarCategoria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEditarCategoria.TabIndex = 18;
            this.btnEditarCategoria.TabStop = false;
            this.btnEditarCategoria.Click += new System.EventHandler(this.btnEditarCategoria_Click);
            // 
            // btnEliminarCuenta
            // 
            this.btnEliminarCuenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarCuenta.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEliminarCuenta.Image = global::ProyectoFinal_Grupo7_IDS326.Properties.Resources.delete;
            this.btnEliminarCuenta.Location = new System.Drawing.Point(654, 0);
            this.btnEliminarCuenta.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarCuenta.Name = "btnEliminarCuenta";
            this.btnEliminarCuenta.Size = new System.Drawing.Size(38, 41);
            this.btnEliminarCuenta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEliminarCuenta.TabIndex = 16;
            this.btnEliminarCuenta.TabStop = false;
            this.btnEliminarCuenta.Click += new System.EventHandler(this.btnEliminarCategoria_Click);
            // 
            // btnCrearCuenta
            // 
            this.btnCrearCuenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearCuenta.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCrearCuenta.Image = global::ProyectoFinal_Grupo7_IDS326.Properties.Resources.add;
            this.btnCrearCuenta.Location = new System.Drawing.Point(692, 0);
            this.btnCrearCuenta.Margin = new System.Windows.Forms.Padding(2);
            this.btnCrearCuenta.Name = "btnCrearCuenta";
            this.btnCrearCuenta.Size = new System.Drawing.Size(37, 41);
            this.btnCrearCuenta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCrearCuenta.TabIndex = 17;
            this.btnCrearCuenta.TabStop = false;
            this.btnCrearCuenta.Click += new System.EventHandler(this.btnCrearCategoria_Click);
            // 
            // pnlLateral
            // 
            this.pnlLateral.Controls.Add(this.cmbTipo);
            this.pnlLateral.Controls.Add(this.label3);
            this.pnlLateral.Controls.Add(this.btnCerrar);
            this.pnlLateral.Controls.Add(this.btnEditar);
            this.pnlLateral.Controls.Add(this.label1);
            this.pnlLateral.Controls.Add(this.txtNombre);
            this.pnlLateral.Controls.Add(this.label2);
            this.pnlLateral.Controls.Add(this.btnCrear);
            this.pnlLateral.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlLateral.Location = new System.Drawing.Point(463, 41);
            this.pnlLateral.Margin = new System.Windows.Forms.Padding(2);
            this.pnlLateral.Name = "pnlLateral";
            this.pnlLateral.Size = new System.Drawing.Size(266, 360);
            this.pnlLateral.TabIndex = 21;
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Ingreso",
            "Gasto"});
            this.cmbTipo.Location = new System.Drawing.Point(96, 159);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(164, 21);
            this.cmbTipo.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 159);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Tipo";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(154, 191);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(56, 19);
            this.btnCerrar.TabIndex = 24;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(82, 191);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(56, 19);
            this.btnEditar.TabIndex = 23;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categorías";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(96, 122);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(164, 21);
            this.txtNombre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(82, 191);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(2);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(56, 19);
            this.btnCrear.TabIndex = 9;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvCategorias);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 41);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 360);
            this.panel1.TabIndex = 24;
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.AllowUserToAddRows = false;
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCategorias.Location = new System.Drawing.Point(0, 0);
            this.dgvCategorias.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.RowHeadersWidth = 51;
            this.dgvCategorias.RowTemplate.Height = 24;
            this.dgvCategorias.Size = new System.Drawing.Size(463, 360);
            this.dgvCategorias.TabIndex = 0;
            // 
            // frmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 401);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlLateral);
            this.Controls.Add(this.pnlSuperior);
            this.Controls.Add(this.btnTransaccion);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmCategorias";
            this.Text = "Cuentas";
            this.Load += new System.EventHandler(this.frmCategorias_Load);
            this.pnlSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnEditarCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminarCuenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCrearCuenta)).EndInit();
            this.pnlLateral.ResumeLayout(false);
            this.pnlLateral.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox btnEditarCategoria;
        private System.Windows.Forms.PictureBox btnCrearCuenta;
        private System.Windows.Forms.PictureBox btnEliminarCuenta;
        private System.Windows.Forms.Button btnTransaccion;
        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Panel pnlLateral;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnEditar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label label3;
    }
}