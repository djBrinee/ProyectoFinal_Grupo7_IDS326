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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.pnlLateral = new System.Windows.Forms.Panel();
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnTransacciones = new System.Windows.Forms.Button();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pnlLateral.SuspendLayout();
            this.pnlSuperior.SuspendLayout();
            this.pnlContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLateral
            // 
            this.pnlLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(33)))), ((int)(((byte)(75)))));
            this.pnlLateral.Controls.Add(this.btnTransacciones);
            this.pnlLateral.Controls.Add(this.btnCategorias);
            this.pnlLateral.Controls.Add(this.button1);
            this.pnlLateral.Controls.Add(this.btnInicio);
            this.pnlLateral.Controls.Add(this.pnlLogo);
            this.pnlLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLateral.Location = new System.Drawing.Point(0, 0);
            this.pnlLateral.Margin = new System.Windows.Forms.Padding(2);
            this.pnlLateral.Name = "pnlLateral";
            this.pnlLateral.Size = new System.Drawing.Size(187, 480);
            this.pnlLateral.TabIndex = 9;
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.pnlSuperior.Controls.Add(this.btnMinimizar);
            this.pnlSuperior.Controls.Add(this.btnCerrar);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(187, 0);
            this.pnlSuperior.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(745, 36);
            this.pnlSuperior.TabIndex = 11;
            this.pnlSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlSuperior_MouseDown);
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Controls.Add(this.label2);
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(187, 36);
            this.pnlContenedor.Margin = new System.Windows.Forms.Padding(2);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(745, 444);
            this.pnlContenedor.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 203);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Info Inicial";
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = global::ProyectoFinal_Grupo7_IDS326.Properties.Resources.minimize;
            this.btnMinimizar.Location = new System.Drawing.Point(675, 2);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(31, 34);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::ProyectoFinal_Grupo7_IDS326.Properties.Resources.close1;
            this.btnCerrar.Location = new System.Drawing.Point(711, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(31, 34);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnTransacciones
            // 
            this.btnTransacciones.FlatAppearance.BorderSize = 0;
            this.btnTransacciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransacciones.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransacciones.ForeColor = System.Drawing.Color.White;
            this.btnTransacciones.Image = global::ProyectoFinal_Grupo7_IDS326.Properties.Resources.money_exchange;
            this.btnTransacciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransacciones.Location = new System.Drawing.Point(-2, 284);
            this.btnTransacciones.Margin = new System.Windows.Forms.Padding(2);
            this.btnTransacciones.Name = "btnTransacciones";
            this.btnTransacciones.Size = new System.Drawing.Size(187, 37);
            this.btnTransacciones.TabIndex = 16;
            this.btnTransacciones.Text = "Transacciones";
            this.btnTransacciones.UseVisualStyleBackColor = true;
            this.btnTransacciones.Click += new System.EventHandler(this.btnTransacciones_Click);
            // 
            // btnCategorias
            // 
            this.btnCategorias.FlatAppearance.BorderSize = 0;
            this.btnCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategorias.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategorias.ForeColor = System.Drawing.Color.White;
            this.btnCategorias.Image = global::ProyectoFinal_Grupo7_IDS326.Properties.Resources.list;
            this.btnCategorias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategorias.Location = new System.Drawing.Point(-2, 247);
            this.btnCategorias.Margin = new System.Windows.Forms.Padding(2);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(187, 37);
            this.btnCategorias.TabIndex = 15;
            this.btnCategorias.Text = "Categorías";
            this.btnCategorias.UseVisualStyleBackColor = true;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::ProyectoFinal_Grupo7_IDS326.Properties.Resources.accounting;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(-2, 210);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 37);
            this.button1.TabIndex = 14;
            this.button1.Text = "Cuentas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnCuentas_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.White;
            this.btnInicio.Image = ((System.Drawing.Image)(resources.GetObject("btnInicio.Image")));
            this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.Location = new System.Drawing.Point(-2, 173);
            this.btnInicio.Margin = new System.Windows.Forms.Padding(2);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(187, 37);
            this.btnInicio.TabIndex = 11;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlLogo.BackgroundImage")));
            this.pnlLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlLogo.Location = new System.Drawing.Point(41, 11);
            this.pnlLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(88, 82);
            this.pnlLogo.TabIndex = 11;
            this.pnlLogo.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 480);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.pnlSuperior);
            this.Controls.Add(this.pnlLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnlLateral.ResumeLayout(false);
            this.pnlSuperior.ResumeLayout(false);
            this.pnlContenedor.ResumeLayout(false);
            this.pnlContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlLateral;
        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTransacciones;
        private System.Windows.Forms.Button btnCategorias;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMinimizar;
    }
}

