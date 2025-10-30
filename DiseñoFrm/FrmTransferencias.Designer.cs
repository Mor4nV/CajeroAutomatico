namespace CajeroAutomatico
{
    partial class FrmTransferencias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTransferencias));
            BtnRegresar = new Button();
            SuspendLayout();
            // 
            // BtnRegresar
            // 
            BtnRegresar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnRegresar.BackgroundImage = (Image)resources.GetObject("BtnRegresar.BackgroundImage");
            BtnRegresar.BackgroundImageLayout = ImageLayout.Stretch;
            BtnRegresar.Location = new Point(923, 33);
            BtnRegresar.Name = "BtnRegresar";
            BtnRegresar.Size = new Size(130, 126);
            BtnRegresar.TabIndex = 6;
            BtnRegresar.UseVisualStyleBackColor = true;
            BtnRegresar.Click += BtnRegresar_Click;
            // 
            // FrmTransferencias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Transferencia;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1160, 749);
            Controls.Add(BtnRegresar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmTransferencias";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Transferencias";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
        }

        #endregion

        private Button BtnRegresar;
    }
}