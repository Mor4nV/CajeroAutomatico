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
            btnAdministracion = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnAdministracion
            // 
            btnAdministracion.BackColor = SystemColors.ActiveCaption;
            btnAdministracion.BackgroundImage = Properties.Resources.ImprimirNuevoReport;
            btnAdministracion.BackgroundImageLayout = ImageLayout.Stretch;
            btnAdministracion.FlatStyle = FlatStyle.Popup;
            btnAdministracion.Font = new Font("MingLiU_MSCS-ExtB", 26.25F, FontStyle.Bold | FontStyle.Italic);
            btnAdministracion.Location = new Point(610, 302);
            btnAdministracion.Name = "btnAdministracion";
            btnAdministracion.Size = new Size(265, 256);
            btnAdministracion.TabIndex = 1;
            btnAdministracion.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.BackgroundImage = Properties.Resources.ImprimirUltimoReport;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("MingLiU_MSCS-ExtB", 26.25F, FontStyle.Bold | FontStyle.Italic);
            button1.Location = new Point(321, 302);
            button1.Name = "button1";
            button1.Size = new Size(265, 256);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = false;
            // 
            // FrmGenerarReporte
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.GenerarReportefondo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1218, 737);
            Controls.Add(button1);
            Controls.Add(btnAdministracion);
            Name = "FrmGenerarReporte";
            Text = "FormGenerarReporte";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAdministracion;
        private Button button1;
    }
}