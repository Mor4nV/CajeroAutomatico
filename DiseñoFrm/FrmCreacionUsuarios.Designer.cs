namespace CajeroAutomatico.DiseñoFrm
{
    partial class FrmCreacionUsuarios
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
            btnVolver = new Button();
            grpCreacionUsuariosAdmin = new GroupBox();
            txtNombreUsuario = new TextBox();
            lblNombreUsuario = new Label();
            txtCodigoEmpresarial = new TextBox();
            lblCodigoEmpresa = new Label();
            grpOpciones = new GroupBox();
            btnEliminarUsuario = new Button();
            lblPINGenerado = new Label();
            btnCambiarPIN = new Button();
            btnConsultarPIN = new Button();
            btnCrearUsuario = new Button();
            txtNumeroTelefono = new TextBox();
            lblTelefono = new Label();
            txtCorreoElectronico = new TextBox();
            lblCorreoElectronico = new Label();
            txtNombreYApellido = new TextBox();
            lblNombreYApellido = new Label();
            dgvUsuariosAdmin = new DataGridView();
            grpCreacionUsuariosAdmin.SuspendLayout();
            grpOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuariosAdmin).BeginInit();
            SuspendLayout();
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
            // grpCreacionUsuariosAdmin
            // 
            grpCreacionUsuariosAdmin.Anchor = AnchorStyles.None;
            grpCreacionUsuariosAdmin.BackgroundImage = Properties.Resources.Fondo2;
            grpCreacionUsuariosAdmin.BackgroundImageLayout = ImageLayout.Stretch;
            grpCreacionUsuariosAdmin.Controls.Add(txtNombreUsuario);
            grpCreacionUsuariosAdmin.Controls.Add(lblNombreUsuario);
            grpCreacionUsuariosAdmin.Controls.Add(txtCodigoEmpresarial);
            grpCreacionUsuariosAdmin.Controls.Add(lblCodigoEmpresa);
            grpCreacionUsuariosAdmin.Controls.Add(grpOpciones);
            grpCreacionUsuariosAdmin.Controls.Add(txtNumeroTelefono);
            grpCreacionUsuariosAdmin.Controls.Add(lblTelefono);
            grpCreacionUsuariosAdmin.Controls.Add(txtCorreoElectronico);
            grpCreacionUsuariosAdmin.Controls.Add(lblCorreoElectronico);
            grpCreacionUsuariosAdmin.Controls.Add(txtNombreYApellido);
            grpCreacionUsuariosAdmin.Controls.Add(lblNombreYApellido);
            grpCreacionUsuariosAdmin.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpCreacionUsuariosAdmin.Location = new Point(241, 270);
            grpCreacionUsuariosAdmin.Name = "grpCreacionUsuariosAdmin";
            grpCreacionUsuariosAdmin.Size = new Size(789, 406);
            grpCreacionUsuariosAdmin.TabIndex = 9;
            grpCreacionUsuariosAdmin.TabStop = false;
            grpCreacionUsuariosAdmin.Text = "Creación De Usuario";
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(44, 132);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(379, 29);
            txtNombreUsuario.TabIndex = 10;
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Location = new Point(44, 107);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(334, 22);
            lblNombreUsuario.TabIndex = 9;
            lblNombreUsuario.Text = "Ingrese el Nombre de Usuario a Utilizar";
            // 
            // txtCodigoEmpresarial
            // 
            txtCodigoEmpresarial.Location = new Point(44, 361);
            txtCodigoEmpresarial.Name = "txtCodigoEmpresarial";
            txtCodigoEmpresarial.Size = new Size(379, 29);
            txtCodigoEmpresarial.TabIndex = 8;
            // 
            // lblCodigoEmpresa
            // 
            lblCodigoEmpresa.AutoSize = true;
            lblCodigoEmpresa.Location = new Point(44, 336);
            lblCodigoEmpresa.Name = "lblCodigoEmpresa";
            lblCodigoEmpresa.Size = new Size(338, 22);
            lblCodigoEmpresa.TabIndex = 7;
            lblCodigoEmpresa.Text = "Ingrese el Codigo (dado por la empresa)";
            // 
            // grpOpciones
            // 
            grpOpciones.Anchor = AnchorStyles.None;
            grpOpciones.BackgroundImage = Properties.Resources.Fondo2;
            grpOpciones.Controls.Add(btnEliminarUsuario);
            grpOpciones.Controls.Add(lblPINGenerado);
            grpOpciones.Controls.Add(btnCambiarPIN);
            grpOpciones.Controls.Add(btnConsultarPIN);
            grpOpciones.Controls.Add(btnCrearUsuario);
            grpOpciones.Location = new Point(455, 0);
            grpOpciones.Name = "grpOpciones";
            grpOpciones.Size = new Size(339, 406);
            grpOpciones.TabIndex = 6;
            grpOpciones.TabStop = false;
            grpOpciones.Text = "Opciones";
            // 
            // btnEliminarUsuario
            // 
            btnEliminarUsuario.Location = new Point(41, 210);
            btnEliminarUsuario.Name = "btnEliminarUsuario";
            btnEliminarUsuario.Size = new Size(126, 54);
            btnEliminarUsuario.TabIndex = 5;
            btnEliminarUsuario.Text = "Eliminar Usuario";
            btnEliminarUsuario.UseVisualStyleBackColor = true;
            btnEliminarUsuario.Click += btnEliminarUsuario_Click_1;
            // 
            // lblPINGenerado
            // 
            lblPINGenerado.AutoSize = true;
            lblPINGenerado.Location = new Point(41, 293);
            lblPINGenerado.Name = "lblPINGenerado";
            lblPINGenerado.Size = new Size(16, 22);
            lblPINGenerado.TabIndex = 4;
            lblPINGenerado.Text = "-";
            // 
            // btnCambiarPIN
            // 
            btnCambiarPIN.Location = new Point(173, 210);
            btnCambiarPIN.Name = "btnCambiarPIN";
            btnCambiarPIN.Size = new Size(126, 54);
            btnCambiarPIN.TabIndex = 3;
            btnCambiarPIN.Text = "Cambiar PIN";
            btnCambiarPIN.UseVisualStyleBackColor = true;
            btnCambiarPIN.Click += btnCambiarPIN_Click;
            // 
            // btnConsultarPIN
            // 
            btnConsultarPIN.Location = new Point(173, 150);
            btnConsultarPIN.Name = "btnConsultarPIN";
            btnConsultarPIN.Size = new Size(126, 54);
            btnConsultarPIN.TabIndex = 1;
            btnConsultarPIN.Text = "Consultar PIN";
            btnConsultarPIN.UseVisualStyleBackColor = true;
            btnConsultarPIN.Click += btnConsultarPIN_Click;
            // 
            // btnCrearUsuario
            // 
            btnCrearUsuario.Location = new Point(41, 150);
            btnCrearUsuario.Name = "btnCrearUsuario";
            btnCrearUsuario.Size = new Size(126, 54);
            btnCrearUsuario.TabIndex = 0;
            btnCrearUsuario.Text = "Crear Usuario";
            btnCrearUsuario.UseVisualStyleBackColor = true;
            btnCrearUsuario.Click += btnCrearUsuario_Click;
            // 
            // txtNumeroTelefono
            // 
            txtNumeroTelefono.Location = new Point(44, 286);
            txtNumeroTelefono.Name = "txtNumeroTelefono";
            txtNumeroTelefono.Size = new Size(379, 29);
            txtNumeroTelefono.TabIndex = 5;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(44, 261);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(263, 22);
            lblTelefono.TabIndex = 4;
            lblTelefono.Text = "Ingresa tu Número de Teléfono";
            // 
            // txtCorreoElectronico
            // 
            txtCorreoElectronico.Location = new Point(44, 210);
            txtCorreoElectronico.Name = "txtCorreoElectronico";
            txtCorreoElectronico.Size = new Size(379, 29);
            txtCorreoElectronico.TabIndex = 3;
            // 
            // lblCorreoElectronico
            // 
            lblCorreoElectronico.AutoSize = true;
            lblCorreoElectronico.Location = new Point(44, 185);
            lblCorreoElectronico.Name = "lblCorreoElectronico";
            lblCorreoElectronico.Size = new Size(362, 22);
            lblCorreoElectronico.TabIndex = 2;
            lblCorreoElectronico.Text = "Ingresa tu Correo Electronico Empresarial";
            // 
            // txtNombreYApellido
            // 
            txtNombreYApellido.Location = new Point(44, 59);
            txtNombreYApellido.Name = "txtNombreYApellido";
            txtNombreYApellido.Size = new Size(379, 29);
            txtNombreYApellido.TabIndex = 1;
            // 
            // lblNombreYApellido
            // 
            lblNombreYApellido.AutoSize = true;
            lblNombreYApellido.Location = new Point(44, 34);
            lblNombreYApellido.Name = "lblNombreYApellido";
            lblNombreYApellido.Size = new Size(275, 22);
            lblNombreYApellido.TabIndex = 0;
            lblNombreYApellido.Text = "Ingresa tu Nombre y Tu Apellido";
            // 
            // dgvUsuariosAdmin
            // 
            dgvUsuariosAdmin.Anchor = AnchorStyles.None;
            dgvUsuariosAdmin.BackgroundColor = Color.FromArgb(192, 192, 255);
            dgvUsuariosAdmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuariosAdmin.Location = new Point(241, 682);
            dgvUsuariosAdmin.Name = "dgvUsuariosAdmin";
            dgvUsuariosAdmin.Size = new Size(789, 132);
            dgvUsuariosAdmin.TabIndex = 10;
            dgvUsuariosAdmin.CellContentClick += dgvUsuariosAdmin_CellContentClick;
            // 
            // FrmCreacionUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.FondoCreacionUsuarios;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1281, 831);
            Controls.Add(dgvUsuariosAdmin);
            Controls.Add(grpCreacionUsuariosAdmin);
            Controls.Add(btnVolver);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCreacionUsuarios";
            Text = "FrmCreacionUsuarios";
            WindowState = FormWindowState.Maximized;
            Load += FrmCreacionUsuarios_Load;
            grpCreacionUsuariosAdmin.ResumeLayout(false);
            grpCreacionUsuariosAdmin.PerformLayout();
            grpOpciones.ResumeLayout(false);
            grpOpciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuariosAdmin).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnVolver;
        private GroupBox grpCreacionUsuariosAdmin;
        private TextBox txtCorreoElectronico;
        private Label lblCorreoElectronico;
        private TextBox txtNombreYApellido;
        private Label lblNombreYApellido;
        private GroupBox grpOpciones;
        private TextBox txtNumeroTelefono;
        private Label lblTelefono;
        private Button btnCambiarPIN;
        private Button btnConsultarPIN;
        private Button btnCrearUsuario;
        private TextBox txtCodigoEmpresarial;
        private Label lblCodigoEmpresa;
        private TextBox txtNombreUsuario;
        private Label lblNombreUsuario;
        private DataGridView dgvUsuariosAdmin;
        private Label lblPINGenerado;
        private Button btnEliminarUsuario;
    }
}