namespace CajeroAutomatico
{
    partial class FrmGenerarReporte
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
            btnReporteClientes = new Button();
            btnReporteReposicion = new Button();
            SuspendLayout();
            // 
            // btnReporteClientes
            // 
            btnReporteClientes.BackColor = SystemColors.ActiveCaption;
            btnReporteClientes.BackgroundImage = Properties.Resources._7;
            btnReporteClientes.BackgroundImageLayout = ImageLayout.Stretch;
            btnReporteClientes.FlatStyle = FlatStyle.Popup;
            btnReporteClientes.Font = new Font("MingLiU_MSCS-ExtB", 26.25F, FontStyle.Bold | FontStyle.Italic);
            btnReporteClientes.Location = new Point(610, 302);
            btnReporteClientes.Name = "btnReporteClientes";
            btnReporteClientes.Size = new Size(265, 256);
            btnReporteClientes.TabIndex = 1;
            btnReporteClientes.UseVisualStyleBackColor = false;
            btnReporteClientes.Click += btnReporteClientes_Click;
            // 
            // btnReporteReposicion
            // 
            btnReporteReposicion.BackColor = SystemColors.ActiveCaption;
            btnReporteReposicion.BackgroundImage = Properties.Resources._61;
            btnReporteReposicion.BackgroundImageLayout = ImageLayout.Stretch;
            btnReporteReposicion.FlatStyle = FlatStyle.Popup;
            btnReporteReposicion.Font = new Font("MingLiU_MSCS-ExtB", 26.25F, FontStyle.Bold | FontStyle.Italic);
            btnReporteReposicion.Location = new Point(321, 302);
            btnReporteReposicion.Name = "btnReporteReposicion";
            btnReporteReposicion.Size = new Size(265, 256);
            btnReporteReposicion.TabIndex = 2;
            btnReporteReposicion.UseVisualStyleBackColor = false;
            btnReporteReposicion.Click += button1_Click;
            // 
            // FrmGenerarReporte
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.GenerarReportefondo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1218, 737);
            Controls.Add(btnReporteReposicion);
            Controls.Add(btnReporteClientes);
            Name = "FrmGenerarReporte";
            Text = "FormGenerarReporte";
            ResumeLayout(false);
        }

        #endregion

        private Button btnReporteClientes;
        private Button btnReporteReposicion;
    }
}