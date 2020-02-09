using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KerekesszekKerdoivBeadando
{
    public partial class bejentkezes_FM : Form
    {
        string tablaLetrehozas = @"CREATE TABLE  IF NOT EXISTS `felhasznalok` (
                                        `id` int(11) PRIMARY KEY AUTO_INCREMENT,
                                        `felhasznalonev` varchar(255) COLLATE utf8_hungarian_ci NOT NULL UNIQUE,
                                        `jelszo` varchar(255) NOT NULL
                                 ) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;";
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader dr;
        public bejentkezes_FM()
        {
            InitializeComponent();
            jelszo_tb.PasswordChar = '*';
            conn = new MySqlConnection("Server=localhost; Database=bejelentkezes; Uid=root; Pwd=;");
            conn.Open();
        }
        private void Bejelentkezes_bt_Click(object sender, EventArgs e)
        {
            string felhasznalonev = felhasznalonev_tb.Text;
            string jelszo = jelszo_tb.Text;
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM felhasznalok where felhasznalonev='" + felhasznalonev_tb.Text + "' AND jelszo='" + jelszo_tb.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                this.Hide();
                admin_FM admin = new admin_FM();
                admin.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Sikertelen belépés!\nKérem ellenőrizze a Felhasználónevét és Jeszavát!");
            }
            conn.Close();
        }

        private void VisszaBe_bt_Click(object sender, EventArgs e)
        {
            this.Hide();
            nyito_FM nyito_fm = new nyito_FM();
            nyito_fm.ShowDialog();
            this.Close();
        }
    }
}
