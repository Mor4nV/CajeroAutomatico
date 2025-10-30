namespace CajeroAutomatico
{
    partial class FrmRetirosSinTarejta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRetirosSinTarejta));
            BtnRegresar = new Button();
            TxtMontoRetiro = new TextBox();
            TxtNumeroCelular = new TextBox();
            LblNumero = new Label();
            LblMonto = new Label();
            BtnContinuar = new Button();
            SuspendLayout();
            // 
            // BtnRegresar
            // 
            BtnRegresar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            BtnRegresar.BackgroundImage = (Image)resources.GetObject("BtnRegresar.BackgroundImage");
            BtnRegresar.BackgroundImageLayout = ImageLayout.Stretch;
            BtnRegresar.Location = new Point(923, 33);
            BtnRegresar.Name = "BtnRegresar";
            BtnRegresar.Size = new Size(130, 126);
            BtnRegresar.TabIndex = 4;
            BtnRegresar.UseVisualStyleBackColor = true;
            BtnRegresar.Click += BtnRegresar_Click;
            // 
            // TxtMontoRetiro
            // 
            TxtMontoRetiro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            TxtMontoRetiro.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtMontoRetiro.ForeColor = Color.DodgerBlue;
            TxtMontoRetiro.Location = new Point(200, 390);
            TxtMontoRetiro.Name = "TxtMontoRetiro";
            TxtMontoRetiro.Size = new Size(351, 52);
            TxtMontoRetiro.TabIndex = 5;
            // 
            // TxtNumeroCelular
            // 
            TxtNumeroCelular.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            TxtNumeroCelular.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtNumeroCelular.ForeColor = Color.DodgerBlue;
            TxtNumeroCelular.Location = new Point(200, 292);
            TxtNumeroCelular.Name = "TxtNumeroCelular";
            TxtNumeroCelular.Size = new Size(351, 52);
            TxtNumeroCelular.TabIndex = 6;
            // 
            // LblNumero
            // 
            LblNumero.AutoSize = true;
            LblNumero.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblNumero.ForeColor = Color.Azure;
            LblNumero.Location = new Point(588, 282);
            LblNumero.Name = "LblNumero";
            LblNumero.Size = new Size(342, 76);
            LblNumero.TabIndex = 7;
            LblNumero.Text = "INGRESA TU NÚMERO \r\nDE CELULAR";
            LblNumero.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblMonto
            // 
            LblMonto.AutoSize = true;
            LblMonto.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblMonto.ForeColor = Color.Azure;
            LblMonto.Location = new Point(608, 380);
            LblMonto.Name = "LblMonto";
            LblMonto.Size = new Size(310, 76);
            LblMonto.TabIndex = 8;
            LblMonto.Text = "INGRESA EL MONTO\r\nA RETIRAR";
            LblMonto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BtnContinuar
            // 
            BtnContinuar.BackgroundImage = (Image)resources.GetObject("BtnContinuar.BackgroundImage");
            BtnContinuar.BackgroundImageLayout = ImageLayout.Stretch;
            BtnContinuar.Location = new Point(456, 497);
            BtnContinuar.Name = "BtnContinuar";
            BtnContinuar.Size = new Size(227, 91);
            BtnContinuar.TabIndex = 9;
            BtnContinuar.UseVisualStyleBackColor = true;
            // 
            // FrmRetirosSinTarejta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.SinTarjeta;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1160, 749);
            Controls.Add(BtnContinuar);
            Controls.Add(LblMonto);
            Controls.Add(LblNumero);
            Controls.Add(TxtNumeroCelular);
            Controls.Add(TxtMontoRetiro);
            Controls.Add(BtnRegresar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmRetirosSinTarejta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RetirosSinTarejta";
            WindowState = FormWindowState.Maximized;
            Load += FrmRetirosSinTarejta_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnRegresar;
        private TextBox TxtMontoRetiro;
        private TextBox TxtNumeroCelular;
        private Label label1;
        private Label LblNumero;
        private Label LblMonto;
        private Button BtnContinuar;
    }
}