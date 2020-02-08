using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KerekesszekKerdoivBeadando
{
    public partial class nyito_FM : Form
    {
        public nyito_FM()
        {
            InitializeComponent();
            Udvozlo_szoveg.Text = "Üdvözlöm!\nHa ön a kérdőívet szeretné kitölteni, akkor kérem nyomja meg az 'Irány a kérdőívre' gombot.\nHa az adatokra kíváncsi és van hozzá jogoltsága akkor,\nkérem nyomja meg az 'Irány a bejelentkezésre!' gombot.";
        }

        private void iranyKerdoiv_bt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kerdoiv_FM kerdo_FM = new Kerdoiv_FM();
            kerdo_FM.ShowDialog();
            this.Close();
        }

        private void IranyBejentkezes_bt_Click(object sender, EventArgs e)
        {
            this.Hide();
            bejentkezes_FM beJ_FM = new bejentkezes_FM();
            beJ_FM.ShowDialog();
            this.Close();
        }
    }
}
