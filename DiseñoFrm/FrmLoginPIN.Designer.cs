namespace CajeroAutomatico
{
    partial class FrmLoginPIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoginPIN));
            TxtPIN = new TextBox();
            BtnPIN = new Button();
            BtnBorrar = new Button();
            BtnRegresar = new Button();
            PbxContinuar = new PictureBox();
            PbxBorrar = new PictureBox();
            PbxRegresar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)PbxContinuar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PbxBorrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PbxRegresar).BeginInit();
            SuspendLayout();
            // 
            // TxtPIN
            // 
            TxtPIN.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtPIN.ForeColor = SystemColors.MenuHighlight;
            TxtPIN.Location = new Point(400, 200);
            TxtPIN.Name = "TxtPIN";
            TxtPIN.Size = new Size(276, 52);
            TxtPIN.TabIndex = 0;
            // 
            // BtnPIN
            // 
            BtnPIN.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnPIN.Location = new Point(698, 138);
            BtnPIN.Name = "BtnPIN";
            BtnPIN.Size = new Size(139, 38);
            BtnPIN.TabIndex = 1;
            BtnPIN.Text = "CONTINUAR";
            BtnPIN.UseVisualStyleBackColor = true;
            BtnPIN.Click += BtnPIN_Click;
            // 
            // BtnBorrar
            // 
            BtnBorrar.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnBorrar.Location = new Point(698, 209);
            BtnBorrar.Name = "BtnBorrar";
            BtnBorrar.Size = new Size(139, 38);
            BtnBorrar.TabIndex = 2;
            BtnBorrar.Text = "BORRAR";
            BtnBorrar.UseVisualStyleBackColor = true;
            // 
            // BtnRegresar
            // 
            BtnRegresar.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnRegresar.Location = new Point(698, 278);
            BtnRegresar.Name = "BtnRegresar";
            BtnRegresar.Size = new Size(139, 38);
            BtnRegresar.TabIndex = 3;
            BtnRegresar.Text = "REGRESAR";
            BtnRegresar.UseVisualStyleBackColor = true;
            // 
            // PbxContinuar
            // 
            PbxContinuar.Image = (Image)resources.GetObject("PbxContinuar.Image");
            PbxContinuar.Location = new Point(843, 133);
            PbxContinuar.Name = "PbxContinuar";
            PbxContinuar.Size = new Size(52, 50);
            PbxContinuar.SizeMode = PictureBoxSizeMode.Zoom;
            PbxContinuar.TabIndex = 4;
            PbxContinuar.TabStop = false;
            // 
            // PbxBorrar
            // 
            PbxBorrar.Image = (Image)resources.GetObject("PbxBorrar.Image");
            PbxBorrar.Location = new Point(843, 202);
            PbxBorrar.Name = "PbxBorrar";
            PbxBorrar.Size = new Size(52, 50);
            PbxBorrar.SizeMode = PictureBoxSizeMode.Zoom;
            PbxBorrar.TabIndex = 5;
            PbxBorrar.TabStop = false;
            // 
            // PbxRegresar
            // 
            PbxRegresar.Image = (Image)resources.GetObject("PbxRegresar.Image");
            PbxRegresar.Location = new Point(843, 270);
            PbxRegresar.Name = "PbxRegresar";
            PbxRegresar.Size = new Size(52, 50);
            PbxRegresar.SizeMode = PictureBoxSizeMode.Zoom;
            PbxRegresar.TabIndex = 6;
            PbxRegresar.TabStop = false;
            // 
            // FrmLoginPIN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondo2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1126, 622);
            Controls.Add(PbxRegresar);
            Controls.Add(PbxBorrar);
            Controls.Add(PbxContinuar);
            Controls.Add(BtnRegresar);
            Controls.Add(BtnBorrar);
            Controls.Add(BtnPIN);
            Controls.Add(TxtPIN);
            Name = "FrmLoginPIN";
            Text = "FrmLoginPIN";
            Load += FrmLoginPIN_Load;
            ((System.ComponentModel.ISupportInitialize)PbxContinuar).EndInit();
            ((System.ComponentModel.ISupportInitialize)PbxBorrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)PbxRegresar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtPIN;
        private Button BtnPIN;
        private Button BtnBorrar;
        private Button BtnRegresar;
        private PictureBox PbxContinuar;
        private PictureBox PbxBorrar;
        private PictureBox PbxRegresar;
    }
}