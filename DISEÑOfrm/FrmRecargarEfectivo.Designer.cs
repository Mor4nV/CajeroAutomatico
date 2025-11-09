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
<<<<<<< HEAD
            txtUsuario = new TextBox();
            //this.lblFechaReposicion = new Label();
            lblCantidadReposicion = new Label();
            btnContinuar = new Button();
            dateTimePicker1 = new DateTimePicker();
=======
            lblFechaReposicion = new Label();
            txtNombreEmpleado = new TextBox();
            lblNombreEmpleado = new Label();
            dtpFechaReposicion = new DateTimePicker();
            txtMontoReposicion = new TextBox();
            lblCantidadReposicion = new Label();
            btnContinuar = new Button();
>>>>>>> ParteAdmin
            grpValidacion.SuspendLayout();
            SuspendLayout();
            // 
            // grpValidacion
            // 
            grpValidacion.BackgroundImage = Properties.Resources.Fondo2;
            grpValidacion.BackgroundImageLayout = ImageLayout.Stretch;
<<<<<<< HEAD
            grpValidacion.Controls.Add(dateTimePicker1);
            grpValidacion.Controls.Add(txtUsuario);
            //grpValidacion.Controls.Add(this.lblFechaReposicion);
=======
            grpValidacion.Controls.Add(lblFechaReposicion);
            grpValidacion.Controls.Add(txtNombreEmpleado);
            grpValidacion.Controls.Add(lblNombreEmpleado);
            grpValidacion.Controls.Add(dtpFechaReposicion);
            grpValidacion.Controls.Add(txtMontoReposicion);
>>>>>>> ParteAdmin
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
<<<<<<< HEAD
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
            /*
            this.lblFechaReposicion.AutoSize = true;
            this.lblFechaReposicion.Location = new Point(30, 121);
            this.lblFechaReposicion.Name = "lblFechaReposicion";
            this.lblFechaReposicion.Size = new Size(190, 23);
            this.lblFechaReposicion.TabIndex = 2;
            this.lblFechaReposicion.Text = "Fecha de Reposición";
            this.lblFechaReposicion.UseWaitCursor = true;
            */
=======
            // lblFechaReposicion
            // 
            lblFechaReposicion.AutoSize = true;
            lblFechaReposicion.Location = new Point(30, 178);
            lblFechaReposicion.Name = "lblFechaReposicion";
            lblFechaReposicion.Size = new Size(211, 23);
            lblFechaReposicion.TabIndex = 8;
            lblFechaReposicion.Text = "Fecha de la Reposición";
            lblFechaReposicion.UseWaitCursor = true;
            // 
            // txtNombreEmpleado
            // 
            txtNombreEmpleado.Location = new Point(344, 116);
            txtNombreEmpleado.Name = "txtNombreEmpleado";
            txtNombreEmpleado.Size = new Size(312, 31);
            txtNombreEmpleado.TabIndex = 7;
            txtNombreEmpleado.UseWaitCursor = true;
            // 
            // lblNombreEmpleado
            // 
            lblNombreEmpleado.AutoSize = true;
            lblNombreEmpleado.Location = new Point(30, 119);
            lblNombreEmpleado.Name = "lblNombreEmpleado";
            lblNombreEmpleado.Size = new Size(272, 23);
            lblNombreEmpleado.TabIndex = 6;
            lblNombreEmpleado.Text = "Nombre del Empleado a Cargo";
            lblNombreEmpleado.UseWaitCursor = true;
            // 
            // dtpFechaReposicion
            // 
            dtpFechaReposicion.Location = new Point(344, 172);
            dtpFechaReposicion.Name = "dtpFechaReposicion";
            dtpFechaReposicion.Size = new Size(379, 31);
            dtpFechaReposicion.TabIndex = 5;
            dtpFechaReposicion.UseWaitCursor = true;
            // 
            // txtMontoReposicion
            // 
            txtMontoReposicion.Location = new Point(344, 63);
            txtMontoReposicion.Name = "txtMontoReposicion";
            txtMontoReposicion.Size = new Size(312, 31);
            txtMontoReposicion.TabIndex = 3;
            txtMontoReposicion.UseWaitCursor = true;
>>>>>>> ParteAdmin
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
<<<<<<< HEAD
            btnContinuar.Location = new Point(280, 209);
=======
            btnContinuar.Location = new Point(279, 238);
>>>>>>> ParteAdmin
            btnContinuar.Name = "btnContinuar";
            btnContinuar.Size = new Size(156, 66);
            btnContinuar.TabIndex = 0;
            btnContinuar.Text = "Continuar";
            btnContinuar.UseVisualStyleBackColor = false;
            btnContinuar.UseWaitCursor = true;
<<<<<<< HEAD
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(304, 115);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(312, 31);
            dateTimePicker1.TabIndex = 5;
=======
            btnContinuar.Click += btnContinuar_Click;
>>>>>>> ParteAdmin
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
<<<<<<< HEAD
=======
            Load += FrmRecargarEfectivo_Load;
>>>>>>> ParteAdmin
            grpValidacion.ResumeLayout(false);
            grpValidacion.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpValidacion;
<<<<<<< HEAD
        private TextBox txtContraseña;
        private TextBox txtUsuario;
        private Label lblContraseña;
        private Label lblCantidadReposicion;
        private Button btnContinuar;
        private DateTimePicker dateTimePicker1;
=======
        private TextBox txtMontoReposicion;
        private Label lblCantidadReposicion;
        private Button btnContinuar;
        private DateTimePicker dtpFechaReposicion;
        private Label lblFechaReposicion;
        private TextBox txtNombreEmpleado;
        private Label lblNombreEmpleado;
>>>>>>> ParteAdmin
    }
}