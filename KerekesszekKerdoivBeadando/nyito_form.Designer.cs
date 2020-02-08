namespace KerekesszekKerdoivBeadando
{
    partial class nyito_FM
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
            this.iranyKerdoiv_bt = new System.Windows.Forms.Button();
            this.iranyBejentkezes_bt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Udvozlo_szoveg
            // 
            this.Udvozlo_szoveg.AutoSize = true;
            this.Udvozlo_szoveg.Location = new System.Drawing.Point(0, 0);
            this.Udvozlo_szoveg.Name = "Udvozlo_szoveg";
            this.Udvozlo_szoveg.Size = new System.Drawing.Size(0, 13);
            this.Udvozlo_szoveg.TabIndex = 0;
            this.Udvozlo_szoveg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iranyKerdoiv_bt
            // 
            this.iranyKerdoiv_bt.Location = new System.Drawing.Point(66, 108);
            this.iranyKerdoiv_bt.Name = "iranyKerdoiv_bt";
            this.iranyKerdoiv_bt.Size = new System.Drawing.Size(108, 23);
            this.iranyKerdoiv_bt.TabIndex = 1;
            this.iranyKerdoiv_bt.Text = "Irány a kérdőívre!";
            this.iranyKerdoiv_bt.UseVisualStyleBackColor = true;
            this.iranyKerdoiv_bt.Click += new System.EventHandler(this.iranyKerdoiv_bt_Click);
            // 
            // iranyBejentkezes_bt
            // 
            this.iranyBejentkezes_bt.Location = new System.Drawing.Point(234, 108);
            this.iranyBejentkezes_bt.Name = "iranyBejentkezes_bt";
            this.iranyBejentkezes_bt.Size = new System.Drawing.Size(132, 23);
            this.iranyBejentkezes_bt.TabIndex = 2;
            this.iranyBejentkezes_bt.Text = "Irány a bejelentkezésre!";
            this.iranyBejentkezes_bt.UseVisualStyleBackColor = true;
            this.iranyBejentkezes_bt.Click += new System.EventHandler(this.IranyBejentkezes_bt_Click);
            // 
            // nyito_FM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 211);
            this.Controls.Add(this.iranyBejentkezes_bt);
            this.Controls.Add(this.iranyKerdoiv_bt);
            this.Controls.Add(this.Udvozlo_szoveg);
            this.Name = "nyito_FM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Udvozlo_szoveg;
        private System.Windows.Forms.Button iranyKerdoiv_bt;
        private System.Windows.Forms.Button iranyBejentkezes_bt;
    }
}