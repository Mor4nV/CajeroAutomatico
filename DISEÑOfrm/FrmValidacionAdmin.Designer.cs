namespace CajeroAutomatico.DISEÑOfrm
{
    partial class FrmValidacionAdmin
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
            grpValidacion = new GroupBox();
            txtContraseña = new TextBox();
            txtUsuario = new TextBox();
            lblContraseña = new Label();
            lblUsuario = new Label();
            btnVerificacion = new Button();
            grpValidacion.SuspendLayout();
            SuspendLayout();
            // 
            // grpValidacion
            // 
            grpValidacion.BackgroundImage = Properties.Resources.Fondo2;
            grpValidacion.BackgroundImageLayout = ImageLayout.Stretch;
            grpValidacion.Controls.Add(txtContraseña);
            grpValidacion.Controls.Add(txtUsuario);
            grpValidacion.Controls.Add(lblContraseña);
            grpValidacion.Controls.Add(lblUsuario);
            grpValidacion.Controls.Add(btnVerificacion);
            grpValidacion.Font = new Font("Impact", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpValidacion.Location = new Point(317, 270);
            grpValidacion.Name = "grpValidacion";
            grpValidacion.Size = new Size(537, 293);
            grpValidacion.TabIndex = 1;
            grpValidacion.TabStop = false;
            grpValidacion.Text = "Validación";
            grpValidacion.UseWaitCursor = true;
            grpValidacion.Enter += grpValidacion_Enter;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(184, 113);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(325, 31);
            txtContraseña.TabIndex = 4;
            txtContraseña.UseWaitCursor = true;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(184, 58);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(325, 31);
            txtUsuario.TabIndex = 3;
            txtUsuario.UseWaitCursor = true;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new Point(30, 121);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(113, 23);
            lblContraseña.TabIndex = 2;
            lblContraseña.Text = "Contraseña";
            lblContraseña.UseWaitCursor = true;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(30, 66);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(78, 23);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuario";
            lblUsuario.UseWaitCursor = true;
            // 
            // btnVerificacion
            // 
            btnVerificacion.BackgroundImage = Properties.Resources.Fondo2;
            btnVerificacion.FlatStyle = FlatStyle.Popup;
            btnVerificacion.Font = new Font("Impact", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnVerificacion.ForeColor = SystemColors.ActiveCaptionText;
            btnVerificacion.Location = new Point(207, 194);
            btnVerificacion.Name = "btnVerificacion";
            btnVerificacion.Size = new Size(156, 66);
            btnVerificacion.TabIndex = 0;
            btnVerificacion.Text = "Verificar";
            btnVerificacion.UseVisualStyleBackColor = true;
            btnVerificacion.UseWaitCursor = true;
            btnVerificacion.Click += btnVerificacion_Click;
            // 
            // FrmValidacionAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ManejoClientesfondo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1195, 665);
            Controls.Add(grpValidacion);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FrmValidacionAdmin";
            Text = "FrmValidacionAdmin";
            UseWaitCursor = true;
            grpValidacion.ResumeLayout(false);
            grpValidacion.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpValidacion;
        private TextBox txtContraseña;
        private TextBox txtUsuario;
        private Label lblContraseña;
        private Label lblUsuario;
        private Button btnVerificacion;
    }
}