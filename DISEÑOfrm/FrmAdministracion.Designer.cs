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
            btnGenerarReporte = new Button();
            btnListadoClientes = new Button();
            btnManejoClientes = new Button();
            grpAdministracion.SuspendLayout();
            SuspendLayout();
            // 
            // grpAdministracion
            // 
            grpAdministracion.BackColor = SystemColors.ActiveCaption;
            grpAdministracion.BackgroundImage = Properties.Resources.Fondo2;
            grpAdministracion.BackgroundImageLayout = ImageLayout.Stretch;
            grpAdministracion.Controls.Add(btnGenerarReporte);
            grpAdministracion.Controls.Add(btnListadoClientes);
            grpAdministracion.Controls.Add(btnManejoClientes);
            grpAdministracion.FlatStyle = FlatStyle.Popup;
            grpAdministracion.ForeColor = SystemColors.ControlText;
            grpAdministracion.Location = new Point(174, 266);
            grpAdministracion.Name = "grpAdministracion";
            grpAdministracion.Size = new Size(787, 281);
            grpAdministracion.TabIndex = 0;
            grpAdministracion.TabStop = false;
            // 
            // btnGenerarReporte
            // 
            btnGenerarReporte.BackgroundImage = Properties.Resources.GenerarReporte;
            btnGenerarReporte.BackgroundImageLayout = ImageLayout.Stretch;
            btnGenerarReporte.Location = new Point(522, 22);
            btnGenerarReporte.Name = "btnGenerarReporte";
            btnGenerarReporte.Size = new Size(245, 227);
            btnGenerarReporte.TabIndex = 2;
            btnGenerarReporte.UseVisualStyleBackColor = true;
            btnGenerarReporte.Click += btnGenerarReporte_Click;
            // 
            // btnListadoClientes
            // 
            btnListadoClientes.BackgroundImage = Properties.Resources.RecargarEfectivo;
            btnListadoClientes.BackgroundImageLayout = ImageLayout.Stretch;
            btnListadoClientes.Location = new Point(271, 22);
            btnListadoClientes.Name = "btnListadoClientes";
            btnListadoClientes.Size = new Size(245, 227);
            btnListadoClientes.TabIndex = 1;
            btnListadoClientes.UseVisualStyleBackColor = true;
            btnListadoClientes.Click += btnListadoClientes_Click;
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
            // FormAdministracion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ImgAdministracion;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1154, 708);
            Controls.Add(grpAdministracion);
            Name = "FormAdministracion";
            Text = "FormAdministracion";
            grpAdministracion.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpAdministracion;
        private Button btnGenerarReporte;
        private Button btnListadoClientes;
        private Button btnManejoClientes;
    }
}