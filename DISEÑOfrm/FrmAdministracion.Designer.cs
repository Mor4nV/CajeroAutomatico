namespace CajeroAutomatico
{
    partial class FrmAdministracion
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
            grpAdministracion = new GroupBox();
            btnGestionCuentas = new Button();
            btnCreacionUsuarios = new Button();
            btnManejoClientes = new Button();
            btnCerrar = new Button();
            grpAdministracion.SuspendLayout();
            SuspendLayout();
            // 
            // grpAdministracion
            // 
            grpAdministracion.Anchor = AnchorStyles.None;
            grpAdministracion.BackColor = SystemColors.ActiveCaption;
            grpAdministracion.BackgroundImage = Properties.Resources.Fondo2;
            grpAdministracion.BackgroundImageLayout = ImageLayout.Stretch;
            grpAdministracion.Controls.Add(btnGestionCuentas);
            grpAdministracion.Controls.Add(btnCreacionUsuarios);
            grpAdministracion.Controls.Add(btnManejoClientes);
            grpAdministracion.FlatStyle = FlatStyle.Popup;
            grpAdministracion.ForeColor = SystemColors.ControlText;
            grpAdministracion.Location = new Point(180, 287);
            grpAdministracion.Name = "grpAdministracion";
            grpAdministracion.Size = new Size(786, 282);
            grpAdministracion.TabIndex = 0;
            grpAdministracion.TabStop = false;
            // 
            // btnGestionCuentas
            // 
            btnGestionCuentas.AccessibleDescription = "";
            btnGestionCuentas.AccessibleName = "";
            btnGestionCuentas.BackgroundImage = Properties.Resources.btnGestionCuentas;
            btnGestionCuentas.BackgroundImageLayout = ImageLayout.Stretch;
            btnGestionCuentas.Location = new Point(271, 22);
            btnGestionCuentas.Name = "btnGestionCuentas";
            btnGestionCuentas.Size = new Size(245, 227);
            btnGestionCuentas.TabIndex = 4;
            btnGestionCuentas.UseVisualStyleBackColor = true;
            btnGestionCuentas.Click += btnGestionCuentas_Click;
            // 
            // btnCreacionUsuarios
            // 
            btnCreacionUsuarios.BackgroundImage = Properties.Resources.btnCreacionUsuarios1;
            btnCreacionUsuarios.BackgroundImageLayout = ImageLayout.Stretch;
            btnCreacionUsuarios.Location = new Point(522, 22);
            btnCreacionUsuarios.Name = "btnCreacionUsuarios";
            btnCreacionUsuarios.Size = new Size(245, 227);
            btnCreacionUsuarios.TabIndex = 3;
            btnCreacionUsuarios.UseVisualStyleBackColor = true;
            btnCreacionUsuarios.Click += btnCreacionUsuarios_Click;
            // 
            // btnManejoClientes
            // 
            btnManejoClientes.BackgroundImage = Properties.Resources.ManejoClientes;
            btnManejoClientes.BackgroundImageLayout = ImageLayout.Stretch;
            btnManejoClientes.Location = new Point(20, 22);
            btnManejoClientes.Name = "btnManejoClientes";
            btnManejoClientes.Size = new Size(245, 227);
            btnManejoClientes.TabIndex = 0;
            btnManejoClientes.UseVisualStyleBackColor = true;
            btnManejoClientes.Click += btnManejoClientes_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = SystemColors.Desktop;
            btnCerrar.BackgroundImage = Properties.Resources.btnCerrar;
            btnCerrar.BackgroundImageLayout = ImageLayout.Stretch;
            btnCerrar.FlatStyle = FlatStyle.Popup;
            btnCerrar.Location = new Point(12, 12);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(81, 78);
            btnCerrar.TabIndex = 9;
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // FrmAdministracion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            BackgroundImage = Properties.Resources.ImgAdministracion;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1154, 708);
            Controls.Add(btnCerrar);
            Controls.Add(grpAdministracion);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAdministracion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmAdministracion";
            WindowState = FormWindowState.Maximized;
            grpAdministracion.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpAdministracion;
        private Button btnManejoClientes;
        private Button btnCreacionUsuarios;
        private Button btnGestionCuentas;
        private Button btnCerrar;
    }
}