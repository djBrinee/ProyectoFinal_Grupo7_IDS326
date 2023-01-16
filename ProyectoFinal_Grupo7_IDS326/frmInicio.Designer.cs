namespace ProyectoFinal_Grupo7_IDS326
{
    partial class frmInicio
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
            this.lblInicio = new System.Windows.Forms.Label();
            this.cmbCuentas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnTransaccion = new System.Windows.Forms.Button();
            this.btnEditarCuenta = new System.Windows.Forms.PictureBox();
            this.btnCrearCuenta = new System.Windows.Forms.PictureBox();
            this.btnEliminarCuenta = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditarCuenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCrearCuenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminarCuenta)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.Location = new System.Drawing.Point(357, 19);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(81, 32);
            this.lblInicio.TabIndex = 0;
            this.lblInicio.Text = "Inicio";
            // 
            // cmbCuentas
            // 
            this.cmbCuentas.FormattingEnabled = true;
            this.cmbCuentas.Location = new System.Drawing.Point(12, 82);
            this.cmbCuentas.Name = "cmbCuentas";
            this.cmbCuentas.Size = new System.Drawing.Size(201, 24);
            this.cmbCuentas.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(467, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Balance actual";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(642, 82);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(52, 29);
            this.lblBalance.TabIndex = 3;
            this.lblBalance.Text = "200";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 169);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(595, 230);
            this.dataGridView1.TabIndex = 4;
            // 
            // btnTransaccion
            // 
            this.btnTransaccion.Location = new System.Drawing.Point(41, 405);
            this.btnTransaccion.Name = "btnTransaccion";
            this.btnTransaccion.Size = new System.Drawing.Size(146, 23);
            this.btnTransaccion.TabIndex = 5;
            this.btnTransaccion.Text = "Crear transaccion";
            this.btnTransaccion.UseVisualStyleBackColor = true;
            // 
            // btnEditarCuenta
            // 
            this.btnEditarCuenta.Image = global::ProyectoFinal_Grupo7_IDS326.Properties.Resources.update;
            this.btnEditarCuenta.Location = new System.Drawing.Point(274, 70);
            this.btnEditarCuenta.Name = "btnEditarCuenta";
            this.btnEditarCuenta.Size = new System.Drawing.Size(49, 41);
            this.btnEditarCuenta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnEditarCuenta.TabIndex = 8;
            this.btnEditarCuenta.TabStop = false;
            // 
            // btnCrearCuenta
            // 
            this.btnCrearCuenta.Image = global::ProyectoFinal_Grupo7_IDS326.Properties.Resources.add;
            this.btnCrearCuenta.Location = new System.Drawing.Point(219, 70);
            this.btnCrearCuenta.Name = "btnCrearCuenta";
            this.btnCrearCuenta.Size = new System.Drawing.Size(49, 41);
            this.btnCrearCuenta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCrearCuenta.TabIndex = 7;
            this.btnCrearCuenta.TabStop = false;
            this.btnCrearCuenta.Click += new System.EventHandler(this.btnCrearCuenta_Click);
            // 
            // btnEliminarCuenta
            // 
            this.btnEliminarCuenta.Image = global::ProyectoFinal_Grupo7_IDS326.Properties.Resources.delete;
            this.btnEliminarCuenta.Location = new System.Drawing.Point(329, 70);
            this.btnEliminarCuenta.Name = "btnEliminarCuenta";
            this.btnEliminarCuenta.Size = new System.Drawing.Size(49, 41);
            this.btnEliminarCuenta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnEliminarCuenta.TabIndex = 6;
            this.btnEliminarCuenta.TabStop = false;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEditarCuenta);
            this.Controls.Add(this.btnCrearCuenta);
            this.Controls.Add(this.btnEliminarCuenta);
            this.Controls.Add(this.btnTransaccion);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCuentas);
            this.Controls.Add(this.lblInicio);
            this.Name = "frmInicio";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditarCuenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCrearCuenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminarCuenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnTransaccion;
        private System.Windows.Forms.PictureBox btnEliminarCuenta;
        private System.Windows.Forms.PictureBox btnCrearCuenta;
        private System.Windows.Forms.PictureBox btnEditarCuenta;
        public System.Windows.Forms.ComboBox cmbCuentas;
    }
}

