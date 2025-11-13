namespace CajeroAutomatico.DiseñoFrm
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
            btnVolver = new Button();
            grpValidacion = new GroupBox();
            txtPIN = new TextBox();
            txtUsuario = new TextBox();
            lblPIN = new Label();
            lblUsuario = new Label();
            btnVerificacion = new Button();
            btnCerrar = new Button();
            grpValidacion.SuspendLayout();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.BackgroundImage = Properties.Resources.btnVolver;
            btnVolver.BackgroundImageLayout = ImageLayout.Stretch;
            btnVolver.Location = new Point(-40, -80);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(81, 78);
            btnVolver.TabIndex = 10;
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.UseWaitCursor = true;
            // 
            // grpValidacion
            // 
            grpValidacion.Anchor = AnchorStyles.None;
            grpValidacion.BackgroundImage = Properties.Resources.Fondo2;
            grpValidacion.BackgroundImageLayout = ImageLayout.Stretch;
            grpValidacion.Controls.Add(txtPIN);
            grpValidacion.Controls.Add(txtUsuario);
            grpValidacion.Controls.Add(lblPIN);
            grpValidacion.Controls.Add(lblUsuario);
            grpValidacion.Controls.Add(btnVerificacion);
            grpValidacion.Font = new Font("Impact", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpValidacion.Location = new Point(328, 277);
            grpValidacion.Name = "grpValidacion";
            grpValidacion.Size = new Size(607, 335);
            grpValidacion.TabIndex = 9;
            grpValidacion.TabStop = false;
            grpValidacion.Text = "Validación";
            grpValidacion.UseWaitCursor = true;
            // 
            // txtPIN
            // 
            txtPIN.Location = new Point(215, 115);
            txtPIN.Name = "txtPIN";
            txtPIN.Size = new Size(325, 31);
            txtPIN.TabIndex = 4;
            txtPIN.UseWaitCursor = true;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(215, 60);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(325, 31);
            txtUsuario.TabIndex = 3;
            txtUsuario.UseWaitCursor = true;
            // 
            // lblPIN
            // 
            lblPIN.AutoSize = true;
            lblPIN.Location = new Point(61, 123);
            lblPIN.Name = "lblPIN";
            lblPIN.Size = new Size(38, 23);
            lblPIN.TabIndex = 2;
            lblPIN.Text = "PIN";
            lblPIN.UseWaitCursor = true;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(61, 68);
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
            btnVerificacion.Location = new Point(239, 211);
            btnVerificacion.Name = "btnVerificacion";
            btnVerificacion.Size = new Size(156, 66);
            btnVerificacion.TabIndex = 0;
            btnVerificacion.Text = "Verificar";
            btnVerificacion.UseVisualStyleBackColor = true;
            btnVerificacion.UseWaitCursor = true;
            btnVerificacion.Click += btnVerificacion_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = SystemColors.ButtonFace;
            btnCerrar.BackgroundImage = Properties.Resources.btnVolver;
            btnCerrar.BackgroundImageLayout = ImageLayout.Zoom;
            btnCerrar.FlatStyle = FlatStyle.Popup;
            btnCerrar.Location = new Point(12, 12);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(81, 78);
            btnCerrar.TabIndex = 11;
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // FrmValidacionAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ImgAdministracion;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1258, 752);
            Controls.Add(btnCerrar);
            Controls.Add(btnVolver);
            Controls.Add(grpValidacion);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmValidacionAdmin";
            Text = "FrmValidacionAdmin";
            WindowState = FormWindowState.Maximized;
            Load += FrmValidacionAdmin_Load;
            grpValidacion.ResumeLayout(false);
            grpValidacion.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnVolver;
        private GroupBox grpValidacion;
        private TextBox txtPIN;
        private TextBox txtUsuario;
        private Label lblPIN;
        private Label lblUsuario;
        private Button btnVerificacion;
        private Button btnCerrar;
    }
}