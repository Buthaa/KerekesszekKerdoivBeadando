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
    public partial class admin_FM : Form
    {
        List<valasz> valaszok = new List<valasz>();
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader dr;
        public admin_FM()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost; Database=kerdoiv; Uid=root; Pwd=; CharSet=utf8;");
            conn.Open();
            nevListazas();
            beOlvas();
            statisztika();
        }
        public void nevListazas()
        {
            valaszNev_lb.Items.Clear();
            cmd = conn.CreateCommand();
            cmd.CommandText = (@"SELECT * 
                                 FROM valaszok
                                 ORDER BY nev");
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var id = reader.GetInt32("id");
                    var nev = reader.GetString("nev");
                    var eletkor = reader.GetInt32("eletkor");
                    var valaszok = new valasz(id, nev, eletkor);
                    valaszNev_lb.Items.Add(valaszok);
                }
            }
        }
        public void beOlvas()
        {
            valaszok.Clear();
            cmd = conn.CreateCommand();
            cmd.CommandText = (@"SELECT * 
                                 FROM valaszok
                                 ORDER BY nev");
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    valasz valasz=null;
                    var id = reader.GetInt32("id");
                    var nev = reader.GetString("nev");
                    var nem = reader.GetBoolean("nem");
                    var eletkor = reader.GetInt32("eletkor");
                    var onRendelkezikE = !reader.GetBoolean("onRendelkezikE");
                    if (onRendelkezikE)
                    {
                        var marka = reader.GetString("marka");
                        var modell = reader.GetString("modell");
                        var szekKora = reader.GetInt32("szekKora");
                        var suly = reader.GetInt32("suly");
                        var szine = reader.GetString("szine");
                        var ulesTipus = reader.GetString("ulesTipus");
                        var akkumlatorokSzama = reader.GetInt32("akkumlatorokSzama");
                        var maxSebesseg = reader.GetInt32("maxSebesseg");
                        var rendelkezikExtrakkal = reader.GetBoolean("rendelkezikExtrakkal");
                        var pohartarto = reader.GetBoolean("pohartarto");
                        var tomorgumi = reader.GetBoolean("tomorgumi");
                        var ulesmagasitas = reader.GetBoolean("ulesmagasitas");
                        var ulesdontes = reader.GetBoolean("ulesdontes");
                        valasz = new valasz(id, nev, nem, eletkor, onRendelkezikE, marka, modell, szekKora, suly, szine, ulesTipus, akkumlatorokSzama, maxSebesseg, rendelkezikExtrakkal, pohartarto, tomorgumi, ulesmagasitas, ulesdontes);
                    }
                    else
                    {
                        valasz = new valasz(id, nev, nem, eletkor, onRendelkezikE);
                    }
                    valaszok.Add(valasz);
                    statisztika();
                }
            }
        }
        public void statisztika()
        {
            Dictionary<string, int> szekek = new Dictionary<string, int>();
            sum_lb.Text = string.Format("Össválasz: {0}", valaszok.Count);
            if (valaszok.Count>0)
            {
                StatisztikaRendelkezikIgen_lb.Text = string.Format("Akik rendelkeznek kerekesszékkel: {0} fő", valaszok.Count(x => x.OnRendelkezikE));
                StatisztikaRendelkezikNem_lb.Text = string.Format("Akik nem rendelkeznek kerekesszékkel: {0} fő", valaszok.Count(x => !x.OnRendelkezikE));
                atlagEletkor_lb.Text = string.Format("Átlag életkor: {0}", valaszok.Average(x => x.Eletkor));
                foreach (var valasz in valaszok)
                {
                    if (valasz.OnRendelkezikE)
                    {
                        if (szekek.ContainsKey(valasz.Marka))
                        {
                            szekek[valasz.Marka]++;
                        }
                    }
                }
                foreach (var markak in szekek)
                {
                    if (szekek.ContainsKey("Ottobock"))
                    {
                        ottobock_lb.Text = string.Format("Ottobock: {0} db", markak.Value);
                    }
                    else
                    {
                        ottobock_lb.Text = "nem";
                    }
                }
            }
        }
        private void VisszaAdmin_bt_Click(object sender, EventArgs e)
        {
            this.Hide();
            nyito_FM nyito_fm = new nyito_FM();
            nyito_fm.ShowDialog();
            this.Close();
        }
        private void ValaszTorles_Click(object sender, EventArgs e)
        {
            if (valaszNev_lb.SelectedIndex == -1)
            {
                MessageBox.Show("Nincs város kiválasztva");
                return;
            }
            cmd = conn.CreateCommand();
            cmd.CommandText = @"DELETE FROM valaszok
                               WHERE id = @id";
            var valaszok = (valasz)valaszNev_lb.SelectedItem;
            cmd.Parameters.AddWithValue("@id", valaszok.Id);
            cmd.ExecuteNonQuery();
            beOlvas();
            nevListazas();
            statisztika();
        }
    }
}