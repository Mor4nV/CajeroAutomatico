namespace CajeroAutomatico.DiseñoFrm
{
    partial class FrmGestionCuentasBancarias
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
            grpInformacionCliente = new GroupBox();
            cmbTipoCuenta = new ComboBox();
            lblTipoCuenta = new Label();
            txtCorreoElectronico = new TextBox();
            lblCorreoElectronico = new Label();
            txtNumeroDPI = new TextBox();
            lblNumeroDPI = new Label();
            txtNumeroTelefono = new TextBox();
            lblNumeroTelefono = new Label();
            txtSaldoInicial = new TextBox();
            lblSaldoInicial = new Label();
            txtApellidos = new TextBox();
            txtNombres = new TextBox();
            lblApellidos = new Label();
            lblNombres = new Label();
            groupBox3 = new GroupBox();
            btnEdiarInformacion = new Button();
            btnEliminar = new Button();
            btnAgregar = new Button();
            dgvListadoClientes = new DataGridView();
            btnVolver = new Button();
            grpInformacionCliente.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListadoClientes).BeginInit();
            SuspendLayout();
            // 
            // grpInformacionCliente
            // 
            grpInformacionCliente.Anchor = AnchorStyles.None;
            grpInformacionCliente.BackgroundImage = Properties.Resources.Fondo2;
            grpInformacionCliente.BackgroundImageLayout = ImageLayout.Stretch;
            grpInformacionCliente.Controls.Add(cmbTipoCuenta);
            grpInformacionCliente.Controls.Add(lblTipoCuenta);
            grpInformacionCliente.Controls.Add(txtCorreoElectronico);
            grpInformacionCliente.Controls.Add(lblCorreoElectronico);
            grpInformacionCliente.Controls.Add(txtNumeroDPI);
            grpInformacionCliente.Controls.Add(lblNumeroDPI);
            grpInformacionCliente.Controls.Add(txtNumeroTelefono);
            grpInformacionCliente.Controls.Add(lblNumeroTelefono);
            grpInformacionCliente.Controls.Add(txtSaldoInicial);
            grpInformacionCliente.Controls.Add(lblSaldoInicial);
            grpInformacionCliente.Controls.Add(txtApellidos);
            grpInformacionCliente.Controls.Add(txtNombres);
            grpInformacionCliente.Controls.Add(lblApellidos);
            grpInformacionCliente.Controls.Add(lblNombres);
            grpInformacionCliente.Font = new Font("Javanese Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpInformacionCliente.ForeColor = SystemColors.ActiveCaptionText;
            grpInformacionCliente.Location = new Point(131, 232);
            grpInformacionCliente.Name = "grpInformacionCliente";
            grpInformacionCliente.Size = new Size(725, 476);
            grpInformacionCliente.TabIndex = 4;
            grpInformacionCliente.TabStop = false;
            grpInformacionCliente.Text = "Informacion Cliente";
            // 
            // cmbTipoCuenta
            // 
            cmbTipoCuenta.FormattingEnabled = true;
            cmbTipoCuenta.Location = new Point(265, 408);
            cmbTipoCuenta.Name = "cmbTipoCuenta";
            cmbTipoCuenta.Size = new Size(305, 44);
            cmbTipoCuenta.TabIndex = 17;
            // 
            // lblTipoCuenta
            // 
            lblTipoCuenta.AutoSize = true;
            lblTipoCuenta.Location = new Point(25, 411);
            lblTipoCuenta.Name = "lblTipoCuenta";
            lblTipoCuenta.Size = new Size(138, 36);
            lblTipoCuenta.TabIndex = 16;
            lblTipoCuenta.Text = "Tipo de Cuenta";
            // 
            // txtCorreoElectronico
            // 
            txtCorreoElectronico.BackColor = SystemColors.ButtonFace;
            txtCorreoElectronico.BorderStyle = BorderStyle.None;
            txtCorreoElectronico.Cursor = Cursors.No;
            txtCorreoElectronico.Location = new Point(265, 296);
            txtCorreoElectronico.Name = "txtCorreoElectronico";
            txtCorreoElectronico.Size = new Size(305, 37);
            txtCorreoElectronico.TabIndex = 15;
            // 
            // lblCorreoElectronico
            // 
            lblCorreoElectronico.AutoSize = true;
            lblCorreoElectronico.Location = new Point(25, 296);
            lblCorreoElectronico.Name = "lblCorreoElectronico";
            lblCorreoElectronico.Size = new Size(164, 36);
            lblCorreoElectronico.TabIndex = 14;
            lblCorreoElectronico.Text = "Correo Electrónico";
            // 
            // txtNumeroDPI
            // 
            txtNumeroDPI.BackColor = SystemColors.ButtonFace;
            txtNumeroDPI.BorderStyle = BorderStyle.None;
            txtNumeroDPI.Cursor = Cursors.No;
            txtNumeroDPI.Location = new Point(265, 176);
            txtNumeroDPI.Name = "txtNumeroDPI";
            txtNumeroDPI.Size = new Size(305, 37);
            txtNumeroDPI.TabIndex = 13;
            // 
            // lblNumeroDPI
            // 
            lblNumeroDPI.AutoSize = true;
            lblNumeroDPI.Location = new Point(25, 176);
            lblNumeroDPI.Name = "lblNumeroDPI";
            lblNumeroDPI.Size = new Size(137, 36);
            lblNumeroDPI.TabIndex = 12;
            lblNumeroDPI.Text = "Número de DPI";
            // 
            // txtNumeroTelefono
            // 
            txtNumeroTelefono.BackColor = SystemColors.ButtonFace;
            txtNumeroTelefono.BorderStyle = BorderStyle.None;
            txtNumeroTelefono.Cursor = Cursors.No;
            txtNumeroTelefono.Location = new Point(265, 238);
            txtNumeroTelefono.Name = "txtNumeroTelefono";
            txtNumeroTelefono.Size = new Size(305, 37);
            txtNumeroTelefono.TabIndex = 11;
            // 
            // lblNumeroTelefono
            // 
            lblNumeroTelefono.AutoSize = true;
            lblNumeroTelefono.Location = new Point(25, 238);
            lblNumeroTelefono.Name = "lblNumeroTelefono";
            lblNumeroTelefono.Size = new Size(175, 36);
            lblNumeroTelefono.TabIndex = 10;
            lblNumeroTelefono.Text = "Número de Teléfono";
            // 
            // txtSaldoInicial
            // 
            txtSaldoInicial.BackColor = SystemColors.ButtonFace;
            txtSaldoInicial.BorderStyle = BorderStyle.None;
            txtSaldoInicial.Cursor = Cursors.No;
            txtSaldoInicial.Location = new Point(265, 354);
            txtSaldoInicial.Name = "txtSaldoInicial";
            txtSaldoInicial.Size = new Size(305, 37);
            txtSaldoInicial.TabIndex = 9;
            // 
            // lblSaldoInicial
            // 
            lblSaldoInicial.AutoSize = true;
            lblSaldoInicial.Location = new Point(25, 355);
            lblSaldoInicial.Name = "lblSaldoInicial";
            lblSaldoInicial.Size = new Size(116, 36);
            lblSaldoInicial.TabIndex = 8;
            lblSaldoInicial.Text = "Saldo Inicial";
            // 
            // txtApellidos
            // 
            txtApellidos.BackColor = SystemColors.ButtonFace;
            txtApellidos.BorderStyle = BorderStyle.None;
            txtApellidos.Cursor = Cursors.No;
            txtApellidos.Location = new Point(265, 111);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(305, 37);
            txtApellidos.TabIndex = 5;
            txtApellidos.TextChanged += txtApellidos_TextChanged;
            // 
            // txtNombres
            // 
            txtNombres.BackColor = SystemColors.ButtonFace;
            txtNombres.BorderStyle = BorderStyle.None;
            txtNombres.Cursor = Cursors.No;
            txtNombres.Location = new Point(265, 44);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(305, 37);
            txtNombres.TabIndex = 4;
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.Location = new Point(28, 111);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(91, 36);
            lblApellidos.TabIndex = 2;
            lblApellidos.Text = "Apellidos";
            // 
            // lblNombres
            // 
            lblNombres.AutoSize = true;
            lblNombres.Location = new Point(28, 44);
            lblNombres.Name = "lblNombres";
            lblNombres.Size = new Size(85, 36);
            lblNombres.TabIndex = 1;
            lblNombres.Text = "Nombres";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.None;
            groupBox3.BackgroundImage = Properties.Resources.Fondo2;
            groupBox3.Controls.Add(btnEdiarInformacion);
            groupBox3.Controls.Add(btnEliminar);
            groupBox3.Controls.Add(btnAgregar);
            groupBox3.Font = new Font("Javanese Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(250, 714);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(474, 113);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Mantenimiento";
            // 
            // btnEdiarInformacion
            // 
            btnEdiarInformacion.Location = new Point(184, 37);
            btnEdiarInformacion.Name = "btnEdiarInformacion";
            btnEdiarInformacion.Size = new Size(118, 50);
            btnEdiarInformacion.TabIndex = 19;
            btnEdiarInformacion.Text = "Editar";
            btnEdiarInformacion.UseVisualStyleBackColor = true;
            btnEdiarInformacion.Click += btnEdiarInformacion_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(312, 37);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(118, 50);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(60, 37);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(118, 50);
            btnAgregar.TabIndex = 13;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgvListadoClientes
            // 
            dgvListadoClientes.Anchor = AnchorStyles.None;
            dgvListadoClientes.BackgroundColor = SystemColors.ActiveCaption;
            dgvListadoClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListadoClientes.Location = new Point(862, 232);
            dgvListadoClientes.Name = "dgvListadoClientes";
            dgvListadoClientes.Size = new Size(556, 589);
            dgvListadoClientes.TabIndex = 7;
            dgvListadoClientes.CellContentClick += dgvListadoClientes_CellContentClick;
            dgvListadoClientes.SelectionChanged += dgvListadoClientes_SelectionChanged;
            // 
            // btnVolver
            // 
            btnVolver.BackgroundImage = Properties.Resources.btnVolver;
            btnVolver.BackgroundImageLayout = ImageLayout.Stretch;
            btnVolver.Location = new Point(12, 12);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(81, 78);
            btnVolver.TabIndex = 8;
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // FrmGestionCuentasBancarias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            BackgroundImage = Properties.Resources.FondoGestionCuentasBanc;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1466, 833);
            Controls.Add(btnVolver);
            Controls.Add(dgvListadoClientes);
            Controls.Add(groupBox3);
            Controls.Add(grpInformacionCliente);
            Name = "FrmGestionCuentasBancarias";
            Text = "FrmGestionCuentasBancarias";
            WindowState = FormWindowState.Maximized;
            Load += FrmGestionCuentasBancarias_Load;
            grpInformacionCliente.ResumeLayout(false);
            grpInformacionCliente.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListadoClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpInformacionCliente;
        private TextBox txtApellidos;
        private TextBox txtNombres;
        private Label lblApellidos;
        private Label lblNombres;
        private GroupBox groupBox3;
        private Button btnEdiarInformacion;
        private Button btnEliminar;
        private Button btnAgregar;
        private DataGridView dgvListadoClientes;
        private TextBox txtNumeroTelefono;
        private Label lblNumeroTelefono;
        private TextBox txtNumeroDPI;
        private Label lblNumeroDPI;
        private TextBox txtCorreoElectronico;
        private Label lblCorreoElectronico;
        private ComboBox cmbTipoCuenta;
        private Label lblTipoCuenta;
        private TextBox txtSaldoInicial;
        private Label lblSaldoInicial;
        private Button btnVolver;
    }
}