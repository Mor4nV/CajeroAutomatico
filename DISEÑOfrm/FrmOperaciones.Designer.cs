namespace CajeroAutomatico
{
    partial class FrmOperaciones
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
            grpOperaciones = new GroupBox();
            btnGestionUsuario = new Button();
            btnHistorialMovimientos = new Button();
            btnConcultaSaldo = new Button();
            btnTransferencias = new Button();
            btnSinTarjeta = new Button();
            btnRetiros = new Button();
            grpOperaciones.SuspendLayout();
            SuspendLayout();
            // 
            // grpOperaciones
            // 
            grpOperaciones.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            grpOperaciones.BackColor = SystemColors.ActiveCaption;
            grpOperaciones.BackgroundImage = Properties.Resources.Fondo2;
            grpOperaciones.BackgroundImageLayout = ImageLayout.Stretch;
            grpOperaciones.Controls.Add(btnGestionUsuario);
            grpOperaciones.Controls.Add(btnHistorialMovimientos);
            grpOperaciones.Controls.Add(btnConcultaSaldo);
            grpOperaciones.Controls.Add(btnTransferencias);
            grpOperaciones.Controls.Add(btnSinTarjeta);
            grpOperaciones.Controls.Add(btnRetiros);
            grpOperaciones.FlatStyle = FlatStyle.Popup;
            grpOperaciones.ForeColor = SystemColors.ControlText;
            grpOperaciones.Location = new Point(190, 203);
            grpOperaciones.Name = "grpOperaciones";
            grpOperaciones.Size = new Size(787, 503);
            grpOperaciones.TabIndex = 1;
            grpOperaciones.TabStop = false;
            // 
            // btnGestionUsuario
            // 
            btnGestionUsuario.BackgroundImage = Properties.Resources.GestionUsuario;
            btnGestionUsuario.BackgroundImageLayout = ImageLayout.Stretch;
            btnGestionUsuario.Location = new Point(522, 255);
            btnGestionUsuario.Name = "btnGestionUsuario";
            btnGestionUsuario.Size = new Size(245, 227);
            btnGestionUsuario.TabIndex = 7;
            btnGestionUsuario.UseVisualStyleBackColor = true;
            // 
            // btnHistorialMovimientos
            // 
            btnHistorialMovimientos.BackgroundImage = Properties.Resources.HistorialMovimientos;
            btnHistorialMovimientos.BackgroundImageLayout = ImageLayout.Stretch;
            btnHistorialMovimientos.Location = new Point(271, 255);
            btnHistorialMovimientos.Name = "btnHistorialMovimientos";
            btnHistorialMovimientos.Size = new Size(245, 227);
            btnHistorialMovimientos.TabIndex = 6;
            btnHistorialMovimientos.UseVisualStyleBackColor = true;
            // 
            // btnConcultaSaldo
            // 
            btnConcultaSaldo.BackgroundImage = Properties.Resources.ConsultaSaldo;
            btnConcultaSaldo.BackgroundImageLayout = ImageLayout.Stretch;
            btnConcultaSaldo.Location = new Point(20, 255);
            btnConcultaSaldo.Name = "btnConcultaSaldo";
            btnConcultaSaldo.Size = new Size(245, 227);
            btnConcultaSaldo.TabIndex = 4;
            btnConcultaSaldo.UseVisualStyleBackColor = true;
            // 
            // btnTransferencias
            // 
            btnTransferencias.BackgroundImage = Properties.Resources.Transferencias;
            btnTransferencias.BackgroundImageLayout = ImageLayout.Stretch;
            btnTransferencias.Location = new Point(522, 22);
            btnTransferencias.Name = "btnTransferencias";
            btnTransferencias.Size = new Size(245, 227);
            btnTransferencias.TabIndex = 2;
            btnTransferencias.UseVisualStyleBackColor = true;
            btnTransferencias.Click += btnTransferencias_Click;
            // 
            // btnSinTarjeta
            // 
            btnSinTarjeta.BackgroundImage = Properties.Resources.RSinTarjeta1;
            btnSinTarjeta.BackgroundImageLayout = ImageLayout.Stretch;
            btnSinTarjeta.Location = new Point(271, 22);
            btnSinTarjeta.Name = "btnSinTarjeta";
            btnSinTarjeta.Size = new Size(245, 227);
            btnSinTarjeta.TabIndex = 1;
            btnSinTarjeta.UseVisualStyleBackColor = true;
            btnSinTarjeta.Click += btnSinTarjeta_Click;
            // 
            // btnRetiros
            // 
            btnRetiros.BackgroundImage = Properties.Resources.RetirosTarjeta;
            btnRetiros.BackgroundImageLayout = ImageLayout.Stretch;
            btnRetiros.Location = new Point(20, 22);
            btnRetiros.Name = "btnRetiros";
            btnRetiros.Size = new Size(245, 227);
            btnRetiros.TabIndex = 0;
            btnRetiros.UseVisualStyleBackColor = true;
            btnRetiros.Click += btnRetiros_Click;
            // 
            // FrmOperaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ImgOperaciones;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1160, 749);
            Controls.Add(grpOperaciones);
            Name = "FrmOperaciones";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormOperaciones";
            grpOperaciones.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpOperaciones;
        private Button btnGestionUsuario;
        private Button btnHistorialMovimientos;
        private Button btnConcultaSaldo;
        private Button btnTransferencias;
        private Button btnSinTarjeta;
        private Button btnRetiros;
    }
}