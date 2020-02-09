namespace KerekesszekKerdoivBeadando
{
    partial class bejentkezes_FM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bejentkezes_FM));
            this.felhasznalonev_tb = new System.Windows.Forms.TextBox();
            this.jelszo_tb = new System.Windows.Forms.TextBox();
            this.bejelentkezes_bt = new System.Windows.Forms.Button();
            this.felhasznalonev_lb = new System.Windows.Forms.Label();
            this.jelszo_lb = new System.Windows.Forms.Label();
            this.visszaBe_bt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // felhasznalonev_tb
            // 
            this.felhasznalonev_tb.Location = new System.Drawing.Point(102, 70);
            this.felhasznalonev_tb.Name = "felhasznalonev_tb";
            this.felhasznalonev_tb.Size = new System.Drawing.Size(283, 20);
            this.felhasznalonev_tb.TabIndex = 0;
            // 
            // jelszo_tb
            // 
            this.jelszo_tb.Location = new System.Drawing.Point(100, 96);
            this.jelszo_tb.Name = "jelszo_tb";
            this.jelszo_tb.Size = new System.Drawing.Size(283, 20);
            this.jelszo_tb.TabIndex = 1;
            // 
            // bejelentkezes_bt
            // 
            this.bejelentkezes_bt.Location = new System.Drawing.Point(190, 137);
            this.bejelentkezes_bt.Name = "bejelentkezes_bt";
            this.bejelentkezes_bt.Size = new System.Drawing.Size(75, 23);
            this.bejelentkezes_bt.TabIndex = 2;
            this.bejelentkezes_bt.Text = "Bejelentkezés!";
            this.bejelentkezes_bt.UseVisualStyleBackColor = true;
            this.bejelentkezes_bt.Click += new System.EventHandler(this.Bejelentkezes_bt_Click);
            // 
            // felhasznalonev_lb
            // 
            this.felhasznalonev_lb.AutoSize = true;
            this.felhasznalonev_lb.Location = new System.Drawing.Point(12, 73);
            this.felhasznalonev_lb.Name = "felhasznalonev_lb";
            this.felhasznalonev_lb.Size = new System.Drawing.Size(84, 13);
            this.felhasznalonev_lb.TabIndex = 3;
            this.felhasznalonev_lb.Text = "Felhasználónév:";
            // 
            // jelszo_lb
            // 
            this.jelszo_lb.AutoSize = true;
            this.jelszo_lb.Location = new System.Drawing.Point(55, 99);
            this.jelszo_lb.Name = "jelszo_lb";
            this.jelszo_lb.Size = new System.Drawing.Size(39, 13);
            this.jelszo_lb.TabIndex = 4;
            this.jelszo_lb.Text = "Jelszó:";
            // 
            // visszaBe_bt
            // 
            this.visszaBe_bt.Location = new System.Drawing.Point(297, 193);
            this.visszaBe_bt.Name = "visszaBe_bt";
            this.visszaBe_bt.Size = new System.Drawing.Size(112, 23);
            this.visszaBe_bt.TabIndex = 5;
            this.visszaBe_bt.Text = "Viszza a főoldalra!";
            this.visszaBe_bt.UseVisualStyleBackColor = true;
            this.visszaBe_bt.Click += new System.EventHandler(this.VisszaBe_bt_Click);
            // 
            // bejentkezes_FM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 228);
            this.Controls.Add(this.visszaBe_bt);
            this.Controls.Add(this.jelszo_lb);
            this.Controls.Add(this.felhasznalonev_lb);
            this.Controls.Add(this.bejelentkezes_bt);
            this.Controls.Add(this.jelszo_tb);
            this.Controls.Add(this.felhasznalonev_tb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "bejentkezes_FM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bejelentkezés!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox felhasznalonev_tb;
        private System.Windows.Forms.TextBox jelszo_tb;
        private System.Windows.Forms.Button bejelentkezes_bt;
        private System.Windows.Forms.Label felhasznalonev_lb;
        private System.Windows.Forms.Label jelszo_lb;
        private System.Windows.Forms.Button visszaBe_bt;
    }
}