using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace KerekesszekKerdoivBeadando
{
    public partial class Kerdoiv_FM : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        public Kerdoiv_FM()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost; Database=kerdoiv; Uid=root; Pwd=; CharSet=utf8;");
            conn.Open();
        }
        public void comboxok()
        {
            marka_CBOX.Items.Add("Ottobock");
            marka_CBOX.Items.Add("Invacare");
            marka_CBOX.Items.Add("Meyra");
            marka_CBOX.Items.Add("Rehab Rt.");
            ules_CBOX.Items.Add("Alap");
            ules_CBOX.Items.Add("Recaro");
        }
        public void kifajl()
        {
            if (nev_TB.Text=="" || eletkor_NUD.Value<0)
            {
                MessageBox.Show("Kérem tölse ki a kötelező adatokat!");
            }
            else
            {
                StreamWriter sw = new StreamWriter(Application.StartupPath + "\\valaszok\\" + nev_TB.Text + ".txt");
                sw.WriteLine(nev_LB.Text + " " + nev_TB.Text);
                sw.Write(neme_GB.Text);
                if (ferfi_RB.Checked)
                {
                    sw.WriteLine(" Férfi");
                }
                else
                {
                    sw.WriteLine(" Nő");
                }
                sw.WriteLine(eletkor_LB.Text + " " + eletkor_NUD.Value);
                sw.Write(rendelkezik_GB.Text);
                if (rendelkezikIgen_RB.Checked)
                {
                    sw.WriteLine(" Igen");
                    sw.WriteLine(marka_LB.Text + " " + marka_CBOX.Text);
                    sw.WriteLine(modell_LB.Text + " " + modell_TBOX.Text);
                    sw.WriteLine(Suly_LB.Text + " " + suly_NUD.Value + " kg");
                    sw.WriteLine(szin_LB.Text + " " + szin_CBOX.Text);
                    sw.WriteLine(ules_LB.Text + " " + ules_CBOX.Text);
                    sw.WriteLine(akkumlatorSzam_LB.Text + " " + akkumlator_NUD.Value);
                    sw.WriteLine(sebesseg_LB.Text + " " + sebesseg_TBOX.Text + " km/h");
                    sw.Write(rendelkezik_LB.Text);
                    if (extrakkalIgen_RB.Checked)
                    {
                        sw.WriteLine(" Igen");
                        sw.Write(harendelkezik_GB.Text);
                        if (pohartarto_CHBOX.Checked)
                        {
                            sw.Write(" " + pohartarto_CHBOX.Text + " ");
                        }
                        if (tomorgumi_CHBOX.Checked)
                        {
                            sw.Write(" " + tomorgumi_CHBOX.Text + " ");
                        }
                        if (ulesmagasitas_CHBOX.Checked)
                        {
                            sw.Write(" " + ulesmagasitas_CHBOX.Text + " ");
                        }
                        if (ulesdontes_CHBOX.Checked)
                        {
                            sw.Write(" " + ulesdontes_CHBOX.Text + " ");
                        }
                    }
                    else
                    {
                        sw.WriteLine(" Nem");
                    }
                }
                else
                {
                    sw.WriteLine(" Nem");
                }
                sw.Close();
            }
        }
        public void torles()
        {
            nev_TB.Clear();
            ferfi_RB.Checked = true;
            eletkor_NUD.Value = 0;
            rendelkezikIgen_RB.Checked = false;
            sajatKerekesszek_GB.Enabled = false;
            kerekesszeke_GB.Enabled = false;
            marka_CBOX.Text = "Kérem Válasszon!";
            modell_TBOX.Clear();
            hanyEves_TBOX.Clear();
            suly_NUD.Value = 0;
            szin_CBOX.Text = "Kérem Válasszon!";
            ules_CBOX.Text = "Kérem Válasszon!";
            akkumlator_NUD.Value = 0;
            sebesseg_TBOX.Clear();
            harendelkezik_GB.Enabled = true;
            extrakkalIgen_RB.Checked = false;
            pohartarto_CHBOX.Checked = false;
            tomorgumi_CHBOX.Checked = false;
            ulesmagasitas_CHBOX.Checked = false;
            ulesdontes_CHBOX.Checked = false;
            extrak_GB.Enabled = false;
        }
        private void kifajlSQL()
        {
            var cmd = conn.CreateCommand();
            cmd.CommandText = @"INSERT INTO `valaszok`(nev, nem, eletkor, onRendelkezikE, marka, modell,
                                                       szekKora, suly, szine, ulesTipus, akkumlatorokSzama, maxSebesseg,
                                                       rendelkezikExtrakkal, pohartarto, tomorgumi, ulesmagasitas, ulesdontes)

                                VALUES (@nev, @nem, @eletkor, @onRendelkezikE, @marka, @modell, @szekKora, @suly, @szine, @ulesTipus,
                                        @akkumlatorokSzama, @maxSebesseg, @rendelkezikExtrakkal, @pohartarto, @tomorgumi, @ulesmagasitas, @ulesdontes)";
            cmd.Parameters.AddWithValue("@nev", nev_TB.Text);
            cmd.Parameters.AddWithValue("@nem", ferfi_RB.Checked ? 0 : 1);
            cmd.Parameters.AddWithValue("@eletkor", eletkor_NUD.Value);
            if (rendelkezikIgen_RB.Checked)
            {
                cmd.Parameters.AddWithValue("@onRendelkezikE", 0);
                cmd.Parameters.AddWithValue("@marka", marka_CBOX.SelectedItem);
                cmd.Parameters.AddWithValue("@modell", modell_TBOX.Text);
                cmd.Parameters.AddWithValue("@szekKora", hanyEves_TBOX.Text);
                cmd.Parameters.AddWithValue("@suly", suly_NUD.Value);
                cmd.Parameters.AddWithValue("@szine", szin_CBOX.SelectedItem);
                cmd.Parameters.AddWithValue("@ulesTipus", ules_CBOX.SelectedItem);
                cmd.Parameters.AddWithValue("@akkumlatorokSzama", akkumlator_NUD.Value);
                cmd.Parameters.AddWithValue("@maxSebesseg", sebesseg_TBOX.Text);
                if (extrakkalIgen_RB.Checked)
                {
                    cmd.Parameters.AddWithValue("@rendelkezikExtrakkal", 0);
                    cmd.Parameters.AddWithValue("@pohartarto", pohartarto_CHBOX.Checked ? 0 : 1);
                    cmd.Parameters.AddWithValue("@tomorgumi", tomorgumi_CHBOX.Checked ? 0 : 1);
                    cmd.Parameters.AddWithValue("@ulesmagasitas", ulesmagasitas_CHBOX.Checked ? 0 : 1);
                    cmd.Parameters.AddWithValue("@ulesdontes", ulesdontes_CHBOX.Checked ? 0 : 1);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@rendelkezikExtrakkal", 1);
                    cmd.Parameters.AddWithValue("@pohartarto", pohartarto_CHBOX.Checked ? 0 : 1);
                    cmd.Parameters.AddWithValue("@tomorgumi", tomorgumi_CHBOX.Checked ? 0 : 1);
                    cmd.Parameters.AddWithValue("@ulesmagasitas", ulesmagasitas_CHBOX.Checked ? 0 : 1);
                    cmd.Parameters.AddWithValue("@ulesdontes", ulesdontes_CHBOX.Checked ? 0 : 1);
                }
                cmd.ExecuteNonQuery();
            }
            else
            {
                cmd.Parameters.AddWithValue("@onRendelkezikE", 1);
                cmd.Parameters.AddWithValue("@marka", null);
                cmd.Parameters.AddWithValue("@modell", null);
                cmd.Parameters.AddWithValue("@szekKora", null);
                cmd.Parameters.AddWithValue("@suly", null);
                cmd.Parameters.AddWithValue("@szine", null);
                cmd.Parameters.AddWithValue("@ulesTipus", null);
                cmd.Parameters.AddWithValue("@akkumlatorokSzama", null);
                cmd.Parameters.AddWithValue("@maxSebesseg", null);
                cmd.Parameters.AddWithValue("@rendelkezikExtrakkal", null);
                cmd.Parameters.AddWithValue("@pohartarto", null);
                cmd.Parameters.AddWithValue("@tomorgumi", null);
                cmd.Parameters.AddWithValue("@ulesmagasitas", null);
                cmd.Parameters.AddWithValue("@ulesdontes", null);
                cmd.ExecuteNonQuery();
            }
        }
        private void Kerdoiv_FM_Load(object sender, EventArgs e)
        {
            sajatKerekesszek_GB.Enabled = false;
            kerekesszeke_GB.Enabled = false;
            extrak_GB.Enabled = false;
            harendelkezik_GB.Enabled = false;
            szin_CBOX.Items.Clear();
            string[] szin = Enum.GetNames(typeof(System.Drawing.KnownColor));
            szin_CBOX.Items.AddRange(szin);
            comboxok();
        }
        private void szin_CBOX_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                e.DrawBackground();
                string szoveg = szin_CBOX.Items[e.Index].ToString();
                Brush bord = new SolidBrush(e.ForeColor);
                Color color = Color.FromName(szoveg);
                Brush pinc = new SolidBrush(color);
                Pen bol = new Pen(e.ForeColor);
                e.Graphics.DrawRectangle(bol, new Rectangle(e.Bounds.Left + 2, e.Bounds.Top + 2, 50, e.Bounds.Height - 4));
                e.Graphics.FillRectangle(pinc, new Rectangle(e.Bounds.Left + 3, e.Bounds.Top + 3, 48, e.Bounds.Height - 6));
                e.Graphics.DrawString(szoveg, e.Font, bord, e.Bounds.Left + 65, e.Bounds.Top + 2);
                e.DrawFocusRectangle();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void kesz_BTN_Click(object sender, EventArgs e)
        {
            kifajl();
            kifajlSQL();
            torles();
        }
        private void rendelkezikIgen_RB_Click(object sender, EventArgs e)
        {
            sajatKerekesszek_GB.Enabled = true;
            kerekesszeke_GB.Enabled = true;
            extrak_GB.Enabled = true;
        }
        private void extrakkalIgen_RB_Click(object sender, EventArgs e)
        {
            harendelkezik_GB.Enabled = true;
        }
        private void VisszaKer_bt_Click(object sender, EventArgs e)
        {
            this.Hide();
            nyito_FM nyito_fm = new nyito_FM();
            nyito_fm.ShowDialog();
            this.Close();
        }
    }
}