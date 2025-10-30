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
            BtnRegresar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            BtnRegresar.BackgroundImage = (Image)resources.GetObject("BtnRegresar.BackgroundImage");
            BtnRegresar.BackgroundImageLayout = ImageLayout.Stretch;
            BtnRegresar.Location = new Point(725, 420);
            BtnRegresar.Name = "BtnRegresar";
            BtnRegresar.Size = new Size(163, 133);
            BtnRegresar.TabIndex = 6;
            BtnRegresar.UseVisualStyleBackColor = true;
            BtnRegresar.Click += BtnRegresar_Click;
            // 
            // BtnBorrar
            // 
            BtnBorrar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            BtnBorrar.BackgroundImage = (Image)resources.GetObject("BtnBorrar.BackgroundImage");
            BtnBorrar.BackgroundImageLayout = ImageLayout.Stretch;
            BtnBorrar.Location = new Point(530, 420);
            BtnBorrar.Name = "BtnBorrar";
            BtnBorrar.Size = new Size(163, 133);
            BtnBorrar.TabIndex = 5;
            BtnBorrar.UseVisualStyleBackColor = true;
            BtnBorrar.Click += BtnBorrar_Click;
            // 
            // BtnContinuar
            // 
            BtnContinuar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            BtnContinuar.BackgroundImage = (Image)resources.GetObject("BtnContinuar.BackgroundImage");
            BtnContinuar.BackgroundImageLayout = ImageLayout.Stretch;
            BtnContinuar.Location = new Point(334, 420);
            BtnContinuar.Name = "BtnContinuar";
            BtnContinuar.Size = new Size(163, 133);
            BtnContinuar.TabIndex = 4;
            BtnContinuar.UseVisualStyleBackColor = true;
            BtnContinuar.Click += BtnContinuar_Click;
            // 
            // TxtNumeroTarjeta
            // 
            TxtNumeroTarjeta.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            TxtNumeroTarjeta.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtNumeroTarjeta.ForeColor = Color.DodgerBlue;
            TxtNumeroTarjeta.Location = new Point(421, 304);
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
            Name = "FrmTarjeta";
            Text = "FrmTarjeta";
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