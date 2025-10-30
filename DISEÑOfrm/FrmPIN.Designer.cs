namespace CajeroAutomatico.DiseñoFrm
{
    partial class FrmPIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPIN));
            TxtPIN = new TextBox();
            BtnContinuar = new Button();
            BtnBorrar = new Button();
            BtnRegresar = new Button();
            SuspendLayout();
            // 
            // TxtPIN
            // 
            TxtPIN.Anchor = AnchorStyles.Top;
            TxtPIN.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtPIN.ForeColor = Color.DodgerBlue;
            TxtPIN.Location = new Point(408, 261);
            TxtPIN.Name = "TxtPIN";
            TxtPIN.Size = new Size(351, 52);
            TxtPIN.TabIndex = 0;
            // 
            // BtnContinuar
            // 
            BtnContinuar.Anchor = AnchorStyles.Top;
            BtnContinuar.BackgroundImage = (Image)resources.GetObject("BtnContinuar.BackgroundImage");
            BtnContinuar.BackgroundImageLayout = ImageLayout.Stretch;
            BtnContinuar.Location = new Point(308, 355);
            BtnContinuar.Name = "BtnContinuar";
            BtnContinuar.Size = new Size(163, 161);
            BtnContinuar.TabIndex = 1;
            BtnContinuar.UseVisualStyleBackColor = true;
            BtnContinuar.Click += BtnContinuar_Click;
            // 
            // BtnBorrar
            // 
            BtnBorrar.Anchor = AnchorStyles.Top;
            BtnBorrar.BackgroundImage = (Image)resources.GetObject("BtnBorrar.BackgroundImage");
            BtnBorrar.BackgroundImageLayout = ImageLayout.Stretch;
            BtnBorrar.Location = new Point(504, 355);
            BtnBorrar.Name = "BtnBorrar";
            BtnBorrar.Size = new Size(163, 161);
            BtnBorrar.TabIndex = 2;
            BtnBorrar.UseVisualStyleBackColor = true;
            BtnBorrar.Click += BtnBorrar_Click;
            // 
            // BtnRegresar
            // 
            BtnRegresar.Anchor = AnchorStyles.Top;
            BtnRegresar.BackgroundImage = (Image)resources.GetObject("BtnRegresar.BackgroundImage");
            BtnRegresar.BackgroundImageLayout = ImageLayout.Stretch;
            BtnRegresar.Location = new Point(699, 355);
            BtnRegresar.Name = "BtnRegresar";
            BtnRegresar.Size = new Size(163, 161);
            BtnRegresar.TabIndex = 3;
            BtnRegresar.UseVisualStyleBackColor = true;
            BtnRegresar.Click += BtnRegresar_Click;
            // 
            // FrmPIN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1160, 749);
            Controls.Add(BtnRegresar);
            Controls.Add(BtnBorrar);
            Controls.Add(BtnContinuar);
            Controls.Add(TxtPIN);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPIN";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPIN";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtPIN;
        private Button BtnContinuar;
        private Button BtnBorrar;
        private Button BtnRegresar;
    }
}