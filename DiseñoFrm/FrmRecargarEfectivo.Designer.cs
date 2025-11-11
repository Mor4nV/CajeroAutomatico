namespace CajeroAutomatico.DiseñoFrm
{
    partial class FrmRecargarEfectivo
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
            grpRecargarEfectivo = new GroupBox();
            SuspendLayout();
            // 
            // grpRecargarEfectivo
            // 
            grpRecargarEfectivo.Location = new Point(175, 140);
            grpRecargarEfectivo.Name = "grpRecargarEfectivo";
            grpRecargarEfectivo.Size = new Size(403, 184);
            grpRecargarEfectivo.TabIndex = 0;
            grpRecargarEfectivo.TabStop = false;
            grpRecargarEfectivo.Text = "Reposición de Efectivo";
            // 
            // FrmRecargarEfectivo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grpRecargarEfectivo);
            Name = "FrmRecargarEfectivo";
            Text = "FrmRecargarEfectivo";
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpRecargarEfectivo;
    }
}