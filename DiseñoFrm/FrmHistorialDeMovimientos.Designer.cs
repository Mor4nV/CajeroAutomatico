namespace CajeroAutomatico
{
    partial class FrmHistorialDeMovimientos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHistorialDeMovimientos));
            BtnRegresar = new Button();
            SuspendLayout();
            // 
            // BtnRegresar
            // 
            BtnRegresar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            BtnRegresar.BackgroundImage = (Image)resources.GetObject("BtnRegresar.BackgroundImage");
            BtnRegresar.BackgroundImageLayout = ImageLayout.Stretch;
            BtnRegresar.Location = new Point(925, 64);
            BtnRegresar.Name = "BtnRegresar";
            BtnRegresar.Size = new Size(130, 126);
            BtnRegresar.TabIndex = 8;
            BtnRegresar.UseVisualStyleBackColor = true;
            BtnRegresar.Click += BtnRegresar_Click;
            // 
            // FrmHistorialDeMovimientos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Historial;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1160, 749);
            Controls.Add(BtnRegresar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmHistorialDeMovimientos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HistorialDeMovimientos";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
        }

        #endregion

        private Button BtnRegresar;
    }
}