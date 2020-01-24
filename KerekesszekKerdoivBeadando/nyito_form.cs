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
    public partial class nyito_form : Form
    {
        public nyito_form()
        {
            InitializeComponent();
            Udvozlo_szoveg.Text = "Üdvözlöm!\nHa ön a kérdőívet szeretné kitölteni, akkor kérem nyomja meg az 'Irány a kérdőívre' gombot. Ha az adatokra kíváncsi és van hozzá jogoltsága akkor kérem nyomja meg az 'Irány az adatokra' gombot.";
        }
    }
}
