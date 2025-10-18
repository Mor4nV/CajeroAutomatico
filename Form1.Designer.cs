namespace CajeroAutomatico
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
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
            btnAdministracion.BackgroundImageLayout = ImageLayout.Stretch;
            btnAdministracion.FlatStyle = FlatStyle.Popup;
            btnAdministracion.Font = new Font("MingLiU_MSCS-ExtB", 26.25F, FontStyle.Bold | FontStyle.Italic);
            btnAdministracion.Location = new Point(215, 316);
            btnAdministracion.Name = "btnAdministracion";
            btnAdministracion.Size = new Size(291, 87);
            btnAdministracion.TabIndex = 0;
            btnAdministracion.Text = "ADMINISTRACIÓN";
            btnAdministracion.UseVisualStyleBackColor = false;
            btnAdministracion.Click += btnAdministracion_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("MingLiU_MSCS-ExtB", 26.25F, FontStyle.Bold | FontStyle.Italic);
            button1.Location = new Point(622, 316);
            button1.Name = "button1";
            button1.Size = new Size(291, 87);
            button1.TabIndex = 1;
            button1.Text = "OPERACIONES GENERALES";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ImagenInicio;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1126, 622);
            Controls.Add(button1);
            Controls.Add(btnAdministracion);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAdministracion;
        private Button button1;
    }
}
