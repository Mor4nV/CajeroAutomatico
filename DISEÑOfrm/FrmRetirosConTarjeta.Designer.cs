namespace CajeroAutomatico
{
    partial class FrmRetirosConTarjeta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRetirosConTarjeta));
            BtnRegresar = new Button();
            Btn100 = new Button();
            Btn200 = new Button();
            Btn300 = new Button();
            BtnMontoVariable = new Button();
            Btn1000 = new Button();
            Btn500 = new Button();
            SuspendLayout();
            // 
            // BtnRegresar
            // 
            BtnRegresar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnRegresar.BackgroundImage = (Image)resources.GetObject("BtnRegresar.BackgroundImage");
            BtnRegresar.BackgroundImageLayout = ImageLayout.Stretch;
            BtnRegresar.Cursor = Cursors.Hand;
            BtnRegresar.Location = new Point(923, 33);
            BtnRegresar.Name = "BtnRegresar";
            BtnRegresar.Size = new Size(130, 126);
            BtnRegresar.TabIndex = 5;
            BtnRegresar.UseVisualStyleBackColor = true;
            BtnRegresar.Click += BtnRegresar_Click;
            // 
            // Btn100
            // 
            Btn100.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            Btn100.BackgroundImage = (Image)resources.GetObject("Btn100.BackgroundImage");
            Btn100.BackgroundImageLayout = ImageLayout.Zoom;
            Btn100.Location = new Point(216, 267);
            Btn100.Name = "Btn100";
            Btn100.Size = new Size(248, 117);
            Btn100.TabIndex = 6;
            Btn100.UseVisualStyleBackColor = true;
            // 
            // Btn200
            // 
            Btn200.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            Btn200.BackgroundImage = (Image)resources.GetObject("Btn200.BackgroundImage");
            Btn200.BackgroundImageLayout = ImageLayout.Zoom;
            Btn200.Location = new Point(216, 422);
            Btn200.Name = "Btn200";
            Btn200.Size = new Size(248, 117);
            Btn200.TabIndex = 7;
            Btn200.UseVisualStyleBackColor = true;
            // 
            // Btn300
            // 
            Btn300.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            Btn300.BackgroundImage = (Image)resources.GetObject("Btn300.BackgroundImage");
            Btn300.BackgroundImageLayout = ImageLayout.Zoom;
            Btn300.Location = new Point(216, 567);
            Btn300.Name = "Btn300";
            Btn300.Size = new Size(248, 117);
            Btn300.TabIndex = 8;
            Btn300.UseVisualStyleBackColor = true;
            // 
            // BtnMontoVariable
            // 
            BtnMontoVariable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            BtnMontoVariable.BackgroundImage = (Image)resources.GetObject("BtnMontoVariable.BackgroundImage");
            BtnMontoVariable.BackgroundImageLayout = ImageLayout.Zoom;
            BtnMontoVariable.Location = new Point(681, 567);
            BtnMontoVariable.Name = "BtnMontoVariable";
            BtnMontoVariable.Size = new Size(248, 117);
            BtnMontoVariable.TabIndex = 11;
            BtnMontoVariable.UseVisualStyleBackColor = true;
            // 
            // Btn1000
            // 
            Btn1000.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            Btn1000.BackgroundImage = (Image)resources.GetObject("Btn1000.BackgroundImage");
            Btn1000.BackgroundImageLayout = ImageLayout.Zoom;
            Btn1000.Location = new Point(681, 422);
            Btn1000.Name = "Btn1000";
            Btn1000.Size = new Size(248, 117);
            Btn1000.TabIndex = 10;
            Btn1000.UseVisualStyleBackColor = true;
            // 
            // Btn500
            // 
            Btn500.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            Btn500.BackgroundImage = (Image)resources.GetObject("Btn500.BackgroundImage");
            Btn500.BackgroundImageLayout = ImageLayout.Zoom;
            Btn500.Location = new Point(681, 267);
            Btn500.Name = "Btn500";
            Btn500.Size = new Size(248, 117);
            Btn500.TabIndex = 9;
            Btn500.UseVisualStyleBackColor = true;
            // 
            // FrmRetirosConTarjeta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ConTarjeta;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1160, 749);
            Controls.Add(BtnMontoVariable);
            Controls.Add(Btn1000);
            Controls.Add(Btn500);
            Controls.Add(Btn300);
            Controls.Add(Btn200);
            Controls.Add(Btn100);
            Controls.Add(BtnRegresar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmRetirosConTarjeta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RetirosConTarjeta";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
        }

        #endregion

        private Button BtnRegresar;
        private Button Btn100;
        private Button Btn200;
        private Button Btn300;
        private Button BtnMontoVariable;
        private Button Btn1000;
        private Button Btn500;
    }
}