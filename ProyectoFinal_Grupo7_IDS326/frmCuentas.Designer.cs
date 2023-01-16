namespace ProyectoFinal_Grupo7_IDS326
{
    partial class frmCuentas
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
            this.dgvCuentas = new System.Windows.Forms.DataGridView();
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.cmbCuentas = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEditarCuenta = new System.Windows.Forms.PictureBox();
            this.btnEliminarCuenta = new System.Windows.Forms.PictureBox();
            this.btnCrearCuenta = new System.Windows.Forms.PictureBox();
            this.pnlLateral = new System.Windows.Forms.Panel();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCerrarPnlSuperior = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNoCuenta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAlias = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.PnlContenedor = new System.Windows.Forms.Panel();
            this.lblBalance = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlInferior = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentas)).BeginInit();
            this.pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditarCuenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminarCuenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCrearCuenta)).BeginInit();
            this.pnlLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarPnlSuperior)).BeginInit();
            this.PnlContenedor.SuspendLayout();
            this.pnlInferior.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTransaccion
            // 
            this.btnTransaccion.Location = new System.Drawing.Point(588, 481);
            this.btnTransaccion.Name = "btnTransaccion";
            this.btnTransaccion.Size = new System.Drawing.Size(146, 23);
            this.btnTransaccion.TabIndex = 15;
            this.btnTransaccion.Text = "Crear transaccion";
            this.btnTransaccion.UseVisualStyleBackColor = true;
            // 
            // dgvCuentas
            // 
            this.dgvCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCuentas.Location = new System.Drawing.Point(0, 0);
            this.dgvCuentas.Name = "dgvCuentas";
            this.dgvCuentas.RowHeadersWidth = 51;
            this.dgvCuentas.RowTemplate.Height = 24;
            this.dgvCuentas.Size = new System.Drawing.Size(975, 457);
            this.dgvCuentas.TabIndex = 14;
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.Controls.Add(this.cmbCuentas);
            this.pnlSuperior.Controls.Add(this.label7);
            this.pnlSuperior.Controls.Add(this.btnEditarCuenta);
            this.pnlSuperior.Controls.Add(this.btnEliminarCuenta);
            this.pnlSuperior.Controls.Add(this.btnCrearCuenta);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(975, 50);
            this.pnlSuperior.TabIndex = 20;
            // 
            // cmbCuentas
            // 
            this.cmbCuentas.FormattingEnabled = true;
            this.cmbCuentas.Location = new System.Drawing.Point(210, 14);
            this.cmbCuentas.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.cmbCuentas.Name = "cmbCuentas";
            this.cmbCuentas.Size = new System.Drawing.Size(234, 24);
            this.cmbCuentas.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 25);
            this.label7.TabIndex = 22;
            this.label7.Text = "Seleccionar cuenta";
            // 
            // btnEditarCuenta
            // 
            this.btnEditarCuenta.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEditarCuenta.Image = global::ProyectoFinal_Grupo7_IDS326.Properties.Resources.update;
            this.btnEditarCuenta.Location = new System.Drawing.Point(827, 0);
            this.btnEditarCuenta.Name = "btnEditarCuenta";
            this.btnEditarCuenta.Size = new System.Drawing.Size(49, 50);
            this.btnEditarCuenta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnEditarCuenta.TabIndex = 18;
            this.btnEditarCuenta.TabStop = false;
            // 
            // btnEliminarCuenta
            // 
            this.btnEliminarCuenta.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEliminarCuenta.Image = global::ProyectoFinal_Grupo7_IDS326.Properties.Resources.delete;
            this.btnEliminarCuenta.Location = new System.Drawing.Point(876, 0);
            this.btnEliminarCuenta.Name = "btnEliminarCuenta";
            this.btnEliminarCuenta.Size = new System.Drawing.Size(50, 50);
            this.btnEliminarCuenta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnEliminarCuenta.TabIndex = 16;
            this.btnEliminarCuenta.TabStop = false;
            // 
            // btnCrearCuenta
            // 
            this.btnCrearCuenta.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCrearCuenta.Image = global::ProyectoFinal_Grupo7_IDS326.Properties.Resources.add;
            this.btnCrearCuenta.Location = new System.Drawing.Point(926, 0);
            this.btnCrearCuenta.Name = "btnCrearCuenta";
            this.btnCrearCuenta.Size = new System.Drawing.Size(49, 50);
            this.btnCrearCuenta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCrearCuenta.TabIndex = 17;
            this.btnCrearCuenta.TabStop = false;
            this.btnCrearCuenta.Click += new System.EventHandler(this.btnCrearCuenta_Click);
            // 
            // pnlLateral
            // 
            this.pnlLateral.Controls.Add(this.btnEditar);
            this.pnlLateral.Controls.Add(this.btnCerrarPnlSuperior);
            this.pnlLateral.Controls.Add(this.label1);
            this.pnlLateral.Controls.Add(this.txtNoCuenta);
            this.pnlLateral.Controls.Add(this.label2);
            this.pnlLateral.Controls.Add(this.label3);
            this.pnlLateral.Controls.Add(this.txtAlias);
            this.pnlLateral.Controls.Add(this.label4);
            this.pnlLateral.Controls.Add(this.txtBalance);
            this.pnlLateral.Controls.Add(this.label5);
            this.pnlLateral.Controls.Add(this.cmbTipo);
            this.pnlLateral.Controls.Add(this.btnCrear);
            this.pnlLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLateral.Location = new System.Drawing.Point(0, 50);
            this.pnlLateral.Name = "pnlLateral";
            this.pnlLateral.Size = new System.Drawing.Size(354, 407);
            this.pnlLateral.TabIndex = 21;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(145, 359);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 23;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnCerrarPnlSuperior
            // 
            this.btnCerrarPnlSuperior.Image = global::ProyectoFinal_Grupo7_IDS326.Properties.Resources.close;
            this.btnCerrarPnlSuperior.Location = new System.Drawing.Point(313, 0);
            this.btnCerrarPnlSuperior.Name = "btnCerrarPnlSuperior";
            this.btnCerrarPnlSuperior.Size = new System.Drawing.Size(41, 36);
            this.btnCerrarPnlSuperior.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrarPnlSuperior.TabIndex = 22;
            this.btnCerrarPnlSuperior.TabStop = false;
            this.btnCerrarPnlSuperior.Click += new System.EventHandler(this.btnCerrarPnlSuperior_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cuentas";
            // 
            // txtNoCuenta
            // 
            this.txtNoCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoCuenta.Location = new System.Drawing.Point(128, 150);
            this.txtNoCuenta.Name = "txtNoCuenta";
            this.txtNoCuenta.Size = new System.Drawing.Size(218, 24);
            this.txtNoCuenta.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "No. de cuenta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Alias";
            // 
            // txtAlias
            // 
            this.txtAlias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlias.Location = new System.Drawing.Point(128, 191);
            this.txtAlias.Name = "txtAlias";
            this.txtAlias.Size = new System.Drawing.Size(218, 24);
            this.txtAlias.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Balance";
            // 
            // txtBalance
            // 
            this.txtBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalance.Location = new System.Drawing.Point(128, 239);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(218, 24);
            this.txtBalance.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(75, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tipo";
            // 
            // cmbTipo
            // 
            this.cmbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "",
            "Corriente",
            "Ahorro"});
            this.cmbTipo.Location = new System.Drawing.Point(128, 282);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(218, 26);
            this.cmbTipo.TabIndex = 8;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(145, 359);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 9;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // PnlContenedor
            // 
            this.PnlContenedor.Controls.Add(this.lblBalance);
            this.PnlContenedor.Controls.Add(this.label6);
            this.PnlContenedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlContenedor.Location = new System.Drawing.Point(354, 50);
            this.PnlContenedor.Name = "PnlContenedor";
            this.PnlContenedor.Size = new System.Drawing.Size(621, 87);
            this.PnlContenedor.TabIndex = 22;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(140, 0);
            this.lblBalance.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.lblBalance.Size = new System.Drawing.Size(45, 50);
            this.lblBalance.TabIndex = 15;
            this.lblBalance.Text = "200";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Left;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.label6.Size = new System.Drawing.Size(140, 50);
            this.label6.TabIndex = 14;
            this.label6.Text = "Balance actual";
            // 
            // pnlInferior
            // 
            this.pnlInferior.Controls.Add(this.btnSalir);
            this.pnlInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlInferior.Location = new System.Drawing.Point(354, 423);
            this.pnlInferior.Name = "pnlInferior";
            this.pnlInferior.Size = new System.Drawing.Size(621, 34);
            this.pnlInferior.TabIndex = 23;
            // 
            // btnSalir
            // 
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSalir.Location = new System.Drawing.Point(504, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(117, 34);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // frmCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 457);
            this.Controls.Add(this.pnlInferior);
            this.Controls.Add(this.PnlContenedor);
            this.Controls.Add(this.pnlLateral);
            this.Controls.Add(this.pnlSuperior);
            this.Controls.Add(this.btnTransaccion);
            this.Controls.Add(this.dgvCuentas);
            this.Name = "frmCuentas";
            this.Text = "Cuentas";
            this.Load += new System.EventHandler(this.frmCuentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentas)).EndInit();
            this.pnlSuperior.ResumeLayout(false);
            this.pnlSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditarCuenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminarCuenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCrearCuenta)).EndInit();
            this.pnlLateral.ResumeLayout(false);
            this.pnlLateral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarPnlSuperior)).EndInit();
            this.PnlContenedor.ResumeLayout(false);
            this.PnlContenedor.PerformLayout();
            this.pnlInferior.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox btnEditarCuenta;
        private System.Windows.Forms.PictureBox btnCrearCuenta;
        private System.Windows.Forms.PictureBox btnEliminarCuenta;
        private System.Windows.Forms.Button btnTransaccion;
        private System.Windows.Forms.DataGridView dgvCuentas;
        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlLateral;
        private System.Windows.Forms.PictureBox btnCerrarPnlSuperior;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNoCuenta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAlias;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Panel PnlContenedor;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlInferior;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEditar;
        public System.Windows.Forms.ComboBox cmbCuentas;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}