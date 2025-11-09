namespace CajeroAutomatico
{
    partial class FrmManejoClientes
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
            grpMantenimiento = new GroupBox();
            groupBox2 = new GroupBox();
            rbtnActiva = new RadioButton();
            rbtnInactiva = new RadioButton();
            txtNumeroCuenta = new TextBox();
            lvlNumeroCuenta = new Label();
            txtApellidos = new TextBox();
            txtNombres = new TextBox();
            txtID = new TextBox();
            lblApellidos = new Label();
            lblNombres = new Label();
            lblID = new Label();
            groupBox3 = new GroupBox();
            btnActualizar = new Button();
            btnMostrarClientes = new Button();
            btnMostrarActivos = new Button();
            btnMostrarInactivos = new Button();
            btnRefrescar = new Button();
            btnEliminar = new Button();
            btnAgregar = new Button();
            btnBuscar = new Button();
            dgvListadoClientes = new DataGridView();
            grpMantenimiento.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListadoClientes).BeginInit();
            SuspendLayout();
            // 
            // grpMantenimiento
            // 
            grpMantenimiento.BackgroundImage = Properties.Resources.Fondo2;
            grpMantenimiento.BackgroundImageLayout = ImageLayout.Stretch;
            grpMantenimiento.Controls.Add(groupBox2);
            grpMantenimiento.Controls.Add(txtNumeroCuenta);
            grpMantenimiento.Controls.Add(lvlNumeroCuenta);
            grpMantenimiento.Controls.Add(txtApellidos);
            grpMantenimiento.Controls.Add(txtNombres);
            grpMantenimiento.Controls.Add(txtID);
            grpMantenimiento.Controls.Add(lblApellidos);
            grpMantenimiento.Controls.Add(lblNombres);
            grpMantenimiento.Controls.Add(lblID);
            grpMantenimiento.Font = new Font("Javanese Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpMantenimiento.ForeColor = SystemColors.ActiveCaptionText;
            grpMantenimiento.Location = new Point(34, 253);
            grpMantenimiento.Name = "grpMantenimiento";
            grpMantenimiento.Size = new Size(725, 415);
            grpMantenimiento.TabIndex = 3;
            grpMantenimiento.TabStop = false;
            grpMantenimiento.Text = "Mantenimiento";
            // 
            // groupBox2
            // 
            groupBox2.BackgroundImageLayout = ImageLayout.None;
            groupBox2.Controls.Add(rbtnActiva);
            groupBox2.Controls.Add(rbtnInactiva);
            groupBox2.Location = new Point(207, 309);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(222, 100);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Estado de la Cuenta";
            // 
            // rbtnActiva
            // 
            rbtnActiva.AutoSize = true;
            rbtnActiva.Location = new Point(15, 38);
            rbtnActiva.Name = "rbtnActiva";
            rbtnActiva.Size = new Size(84, 40);
            rbtnActiva.TabIndex = 8;
            rbtnActiva.TabStop = true;
            rbtnActiva.Text = "Activa";
            rbtnActiva.UseVisualStyleBackColor = true;
            // 
            // rbtnInactiva
            // 
            rbtnInactiva.AutoSize = true;
            rbtnInactiva.Location = new Point(120, 38);
            rbtnInactiva.Name = "rbtnInactiva";
            rbtnInactiva.Size = new Size(98, 40);
            rbtnInactiva.TabIndex = 9;
            rbtnInactiva.TabStop = true;
            rbtnInactiva.Text = "Inactiva";
            rbtnInactiva.UseVisualStyleBackColor = true;
            // 
            // txtNumeroCuenta
            // 
            txtNumeroCuenta.BackColor = SystemColors.ButtonFace;
            txtNumeroCuenta.BorderStyle = BorderStyle.None;
            txtNumeroCuenta.Cursor = Cursors.No;
            txtNumeroCuenta.Location = new Point(271, 252);
            txtNumeroCuenta.Name = "txtNumeroCuenta";
            txtNumeroCuenta.Size = new Size(305, 37);
            txtNumeroCuenta.TabIndex = 7;
            // 
            // lvlNumeroCuenta
            // 
            lvlNumeroCuenta.AutoSize = true;
            lvlNumeroCuenta.Location = new Point(31, 252);
            lvlNumeroCuenta.Name = "lvlNumeroCuenta";
            lvlNumeroCuenta.Size = new Size(163, 36);
            lvlNumeroCuenta.TabIndex = 6;
            lvlNumeroCuenta.Text = "Numero de Cuenta";
            // 
            // txtApellidos
            // 
            txtApellidos.BackColor = SystemColors.ButtonFace;
            txtApellidos.BorderStyle = BorderStyle.None;
            txtApellidos.Cursor = Cursors.No;
            txtApellidos.Location = new Point(271, 186);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(305, 37);
            txtApellidos.TabIndex = 5;
            // 
            // txtNombres
            // 
            txtNombres.BackColor = SystemColors.ButtonFace;
            txtNombres.BorderStyle = BorderStyle.None;
            txtNombres.Cursor = Cursors.No;
            txtNombres.Location = new Point(271, 119);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(305, 37);
            txtNombres.TabIndex = 4;
            // 
            // txtID
            // 
            txtID.BackColor = SystemColors.ButtonFace;
            txtID.BorderStyle = BorderStyle.None;
            txtID.Location = new Point(271, 47);
            txtID.Name = "txtID";
            txtID.Size = new Size(305, 37);
            txtID.TabIndex = 3;
            txtID.TextChanged += txtID_TextChanged;
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.Location = new Point(31, 187);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(91, 36);
            lblApellidos.TabIndex = 2;
            lblApellidos.Text = "Apellidos";
            // 
            // lblNombres
            // 
            lblNombres.AutoSize = true;
            lblNombres.Location = new Point(31, 120);
            lblNombres.Name = "lblNombres";
            lblNombres.Size = new Size(85, 36);
            lblNombres.TabIndex = 1;
            lblNombres.Text = "Nombres";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(31, 52);
            lblID.Name = "lblID";
            lblID.Size = new Size(35, 36);
            lblID.TabIndex = 0;
            lblID.Text = "ID";
            // 
            // groupBox3
            // 
            groupBox3.BackgroundImage = Properties.Resources.Fondo2;
            groupBox3.Controls.Add(btnActualizar);
            groupBox3.Controls.Add(btnMostrarClientes);
            groupBox3.Controls.Add(btnMostrarActivos);
            groupBox3.Controls.Add(btnMostrarInactivos);
            groupBox3.Controls.Add(btnRefrescar);
            groupBox3.Controls.Add(btnEliminar);
            groupBox3.Controls.Add(btnAgregar);
            groupBox3.Controls.Add(btnBuscar);
            groupBox3.Font = new Font("Javanese Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(34, 674);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(725, 159);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Mantenimiento";
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(307, 30);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(118, 34);
            btnActualizar.TabIndex = 19;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnMostrarClientes
            // 
            btnMostrarClientes.Location = new Point(6, 114);
            btnMostrarClientes.Name = "btnMostrarClientes";
            btnMostrarClientes.Size = new Size(214, 34);
            btnMostrarClientes.TabIndex = 18;
            btnMostrarClientes.Text = "Mostrar Clientes";
            btnMostrarClientes.UseVisualStyleBackColor = true;
            btnMostrarClientes.Click += btnMostrarClientes_Click;
            // 
            // btnMostrarActivos
            // 
            btnMostrarActivos.Location = new Point(495, 115);
            btnMostrarActivos.Name = "btnMostrarActivos";
            btnMostrarActivos.Size = new Size(224, 34);
            btnMostrarActivos.TabIndex = 17;
            btnMostrarActivos.Text = "Mostrar Clientes Activos";
            btnMostrarActivos.UseVisualStyleBackColor = true;
            btnMostrarActivos.Click += btnMostrarActivos_Click;
            // 
            // btnMostrarInactivos
            // 
            btnMostrarInactivos.Location = new Point(241, 115);
            btnMostrarInactivos.Name = "btnMostrarInactivos";
            btnMostrarInactivos.Size = new Size(238, 33);
            btnMostrarInactivos.TabIndex = 16;
            btnMostrarInactivos.Text = "Mostrar Clientes Inactivos";
            btnMostrarInactivos.UseVisualStyleBackColor = true;
            btnMostrarInactivos.Click += btnMostrarInactivos_Click;
            // 
            // btnRefrescar
            // 
            btnRefrescar.Location = new Point(455, 30);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(118, 34);
            btnRefrescar.TabIndex = 15;
            btnRefrescar.Text = "Refrescar";
            btnRefrescar.UseVisualStyleBackColor = true;
            btnRefrescar.Click += btnRefrescar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(601, 30);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(118, 34);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(16, 30);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(118, 34);
            btnAgregar.TabIndex = 13;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(160, 30);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(118, 34);
            btnBuscar.TabIndex = 12;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dgvListadoClientes
            // 
            dgvListadoClientes.BackgroundColor = SystemColors.ActiveCaption;
            dgvListadoClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListadoClientes.Location = new Point(810, 305);
            dgvListadoClientes.Name = "dgvListadoClientes";
            dgvListadoClientes.Size = new Size(441, 528);
            dgvListadoClientes.TabIndex = 6;
            // 
            // FrmManejoClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ManejoClientesfondo2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1263, 836);
            Controls.Add(dgvListadoClientes);
            Controls.Add(groupBox3);
            Controls.Add(grpMantenimiento);
            Name = "FrmManejoClientes";
            Text = "FormManejoClientes";
            Load += FrmManejoClientes_Load;
            grpMantenimiento.ResumeLayout(false);
            grpMantenimiento.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListadoClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpMantenimiento;
        private GroupBox groupBox2;
        private RadioButton rbtnActiva;
        private RadioButton rbtnInactiva;
        private TextBox txtNumeroCuenta;
        private Label lvlNumeroCuenta;
        private TextBox txtApellidos;
        private TextBox txtNombres;
        private TextBox txtID;
        private Label lblApellidos;
        private Label lblNombres;
        private Label lblID;
        private GroupBox groupBox3;
        private Button btnRefrescar;
        private Button btnEliminar;
        private Button btnAgregar;
        private Button btnBuscar;
        private DataGridView dgvListadoClientes;
        private Button btnMostrarActivos;
        private Button btnMostrarInactivos;
        private Button btnMostrarClientes;
        private Button btnActualizar;
    }
}