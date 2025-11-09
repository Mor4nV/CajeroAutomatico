namespace CajeroAutomatico.DISEÑOfrm
{
    partial class FrmTipoCuenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTipoCuenta));
            BtnMonetaria = new Button();
            BtnAhorro = new Button();
            SuspendLayout();
            // 
            // BtnMonetaria
            // 
            BtnMonetaria.Anchor = AnchorStyles.Top;
            BtnMonetaria.BackgroundImage = (Image)resources.GetObject("BtnMonetaria.BackgroundImage");
            BtnMonetaria.BackgroundImageLayout = ImageLayout.Stretch;
            BtnMonetaria.Location = new Point(172, 372);
            BtnMonetaria.Name = "BtnMonetaria";
            BtnMonetaria.Size = new Size(380, 173);
            BtnMonetaria.TabIndex = 0;
            BtnMonetaria.UseVisualStyleBackColor = true;
            BtnMonetaria.Click += BtnMonetaria_Click;
            // 
            // BtnAhorro
            // 
            BtnAhorro.Anchor = AnchorStyles.Top;
            BtnAhorro.BackgroundImage = (Image)resources.GetObject("BtnAhorro.BackgroundImage");
            BtnAhorro.BackgroundImageLayout = ImageLayout.Stretch;
            BtnAhorro.Location = new Point(625, 372);
            BtnAhorro.Name = "BtnAhorro";
            BtnAhorro.Size = new Size(380, 173);
            BtnAhorro.TabIndex = 1;
            BtnAhorro.UseVisualStyleBackColor = true;
            BtnAhorro.Click += BtnAhorro_Click;
            // 
            // FrmTipoCuenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1144, 710);
            Controls.Add(BtnAhorro);
            Controls.Add(BtnMonetaria);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmTipoCuenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmTipoCuenta";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
        }

        #endregion

        private Button BtnMonetaria;
        private Button BtnAhorro;
    }
}