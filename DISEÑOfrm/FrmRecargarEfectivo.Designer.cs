namespace CajeroAutomatico.DISEÑOfrm
{
    partial class FrmRecargarEfectivo
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
            txtUsuario = new TextBox();
            this.lblFechaReposicion = new Label();
            lblCantidadReposicion = new Label();
            btnContinuar = new Button();
            dateTimePicker1 = new DateTimePicker();
            grpValidacion.SuspendLayout();
            SuspendLayout();
            // 
            // grpValidacion
            // 
            grpValidacion.BackgroundImage = Properties.Resources.Fondo2;
            grpValidacion.BackgroundImageLayout = ImageLayout.Stretch;
            grpValidacion.Controls.Add(dateTimePicker1);
            grpValidacion.Controls.Add(txtUsuario);
            grpValidacion.Controls.Add(this.lblFechaReposicion);
            grpValidacion.Controls.Add(lblCantidadReposicion);
            grpValidacion.Controls.Add(btnContinuar);
            grpValidacion.Font = new Font("Impact", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpValidacion.Location = new Point(237, 219);
            grpValidacion.Name = "grpValidacion";
            grpValidacion.Size = new Size(729, 355);
            grpValidacion.TabIndex = 2;
            grpValidacion.TabStop = false;
            grpValidacion.Text = "Validación";
            grpValidacion.UseWaitCursor = true;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(304, 63);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(312, 31);
            txtUsuario.TabIndex = 3;
            txtUsuario.UseWaitCursor = true;
            // 
            // lblFechaReposicion
            // 
            this.lblFechaReposicion.AutoSize = true;
            this.lblFechaReposicion.Location = new Point(30, 121);
            this.lblFechaReposicion.Name = "lblFechaReposicion";
            this.lblFechaReposicion.Size = new Size(190, 23);
            this.lblFechaReposicion.TabIndex = 2;
            this.lblFechaReposicion.Text = "Fecha de Reposición";
            this.lblFechaReposicion.UseWaitCursor = true;
            // 
            // lblCantidadReposicion
            // 
            lblCantidadReposicion.AutoSize = true;
            lblCantidadReposicion.Location = new Point(30, 66);
            lblCantidadReposicion.Name = "lblCantidadReposicion";
            lblCantidadReposicion.Size = new Size(218, 23);
            lblCantidadReposicion.TabIndex = 1;
            lblCantidadReposicion.Text = "Cantidad de Reposicion";
            lblCantidadReposicion.UseWaitCursor = true;
            // 
            // btnContinuar
            // 
            btnContinuar.BackColor = SystemColors.ControlText;
            btnContinuar.FlatStyle = FlatStyle.Popup;
            btnContinuar.Font = new Font("Impact", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnContinuar.ForeColor = SystemColors.ButtonHighlight;
            btnContinuar.Location = new Point(280, 209);
            btnContinuar.Name = "btnContinuar";
            btnContinuar.Size = new Size(156, 66);
            btnContinuar.TabIndex = 0;
            btnContinuar.Text = "Continuar";
            btnContinuar.UseVisualStyleBackColor = false;
            btnContinuar.UseWaitCursor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(304, 115);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(312, 31);
            dateTimePicker1.TabIndex = 5;
            // 
            // FrmRecargarEfectivo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.RecargarEfectivofondo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1195, 666);
            Controls.Add(grpValidacion);
            Name = "FrmRecargarEfectivo";
            Text = "FrmRecargarEfectivo";
            grpValidacion.ResumeLayout(false);
            grpValidacion.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpValidacion;
        private TextBox txtContraseña;
        private TextBox txtUsuario;
        private Label lblContraseña;
        private Label lblCantidadReposicion;
        private Button btnContinuar;
        private DateTimePicker dateTimePicker1;
    }
}