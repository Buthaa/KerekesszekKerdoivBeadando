namespace KerekesszekKerdoivBeadando
{
    partial class nyito_form
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
            this.Udvozlo_szoveg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Udvozlo_szoveg
            // 
            this.Udvozlo_szoveg.AutoSize = true;
            this.Udvozlo_szoveg.Location = new System.Drawing.Point(0, 0);
            this.Udvozlo_szoveg.Name = "Udvozlo_szoveg";
            this.Udvozlo_szoveg.Size = new System.Drawing.Size(0, 13);
            this.Udvozlo_szoveg.TabIndex = 0;
            // 
            // nyito_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 367);
            this.Controls.Add(this.Udvozlo_szoveg);
            this.Name = "nyito_form";
            this.Text = "nyito_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Udvozlo_szoveg;
    }
}