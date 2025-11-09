namespace CajeroAutomatico.DISEÑOfrm
{
    partial class FrmTarjeta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTarjeta));
            BtnRegresar = new Button();
            BtnBorrar = new Button();
            BtnContinuar = new Button();
            TxtNumeroTarjeta = new TextBox();
            SuspendLayout();
            // 
            // BtnRegresar
            // 
            BtnRegresar.Anchor = AnchorStyles.Top;
            BtnRegresar.BackgroundImage = (Image)resources.GetObject("BtnRegresar.BackgroundImage");
            BtnRegresar.BackgroundImageLayout = ImageLayout.Stretch;
            BtnRegresar.Location = new Point(699, 355);
            BtnRegresar.Name = "BtnRegresar";
            BtnRegresar.Size = new Size(163, 161);
            BtnRegresar.TabIndex = 6;
            BtnRegresar.UseVisualStyleBackColor = true;
            BtnRegresar.Click += BtnRegresar_Click;
            // 
            // BtnBorrar
            // 
            BtnBorrar.Anchor = AnchorStyles.Top;
            BtnBorrar.BackgroundImage = (Image)resources.GetObject("BtnBorrar.BackgroundImage");
            BtnBorrar.BackgroundImageLayout = ImageLayout.Stretch;
            BtnBorrar.Location = new Point(504, 355);
            BtnBorrar.Name = "BtnBorrar";
            BtnBorrar.Size = new Size(163, 161);
            BtnBorrar.TabIndex = 5;
            BtnBorrar.UseVisualStyleBackColor = true;
            BtnBorrar.Click += BtnBorrar_Click;
            // 
            // BtnContinuar
            // 
            BtnContinuar.Anchor = AnchorStyles.Top;
            BtnContinuar.BackgroundImage = (Image)resources.GetObject("BtnContinuar.BackgroundImage");
            BtnContinuar.BackgroundImageLayout = ImageLayout.Stretch;
            BtnContinuar.Location = new Point(308, 355);
            BtnContinuar.Name = "BtnContinuar";
            BtnContinuar.Size = new Size(163, 161);
            BtnContinuar.TabIndex = 4;
            BtnContinuar.UseVisualStyleBackColor = true;
            BtnContinuar.Click += BtnContinuar_Click;
            // 
            // TxtNumeroTarjeta
            // 
            TxtNumeroTarjeta.Anchor = AnchorStyles.Top;
            TxtNumeroTarjeta.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtNumeroTarjeta.ForeColor = Color.DodgerBlue;
            TxtNumeroTarjeta.Location = new Point(408, 261);
            TxtNumeroTarjeta.Name = "TxtNumeroTarjeta";
            TxtNumeroTarjeta.Size = new Size(351, 52);
            TxtNumeroTarjeta.TabIndex = 1;
            // 
            // FrmTarjeta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1160, 749);
            Controls.Add(BtnRegresar);
            Controls.Add(BtnBorrar);
            Controls.Add(BtnContinuar);
            Controls.Add(TxtNumeroTarjeta);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmTarjeta";
            Text = "FrmTarjeta";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button BtnRegresar;
        private Button BtnBorrar;
        private Button BtnContinuar;
        private TextBox TxtNumeroTarjeta;
    }
}