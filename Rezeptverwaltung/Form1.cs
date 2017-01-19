using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rezeptverwaltung
{
    public partial class MasterDetailForm : Form
    {
        public MasterDetailForm()
        {
            InitializeComponent();
        }
        #region EVENTS
        
        private void MasterDetailForm_Click(object sender, EventArgs e)
        {
            //Wenn gerade kein Rezept bearbeitet oder erstellt wird
            if (PNLDetails.Enabled == false)
            {
                    LIBORezepte.SelectedIndex = -1;
                    RezeptelementeLeeren();
                    ZutatelementeLeeren();
            }
            
            
        }
        private void PNLDetails_Click(object sender, EventArgs e)
        {
            if (LIBOrezZutaten.SelectedIndex != -1)
            {
                LIBOrezZutaten.SelectedIndex = -1;
                ZutatelementeLeeren();
            }
            
        }

        private void TSBneuesRezept_Click(object sender, EventArgs e)
        {
            NeuesRezeptErstellen();
        }
        private void erstellenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NeuesRezeptErstellen();
        }

        private void TSBrezeptLöschen_Click(object sender, EventArgs e)
        {
            RezeptLöschen();
        }
        private void löschenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RezeptLöschen();
        }


        private void CLBrezKategorien_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CLBrezKategorien.SelectedIndex = -1;
        }

        private void LIBORezepte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LIBORezepte.SelectedIndex == -1)
            {
                RezeptelementeLeeren();
                ZutatelementeLeeren();
                PNLDetails.Enabled = false;
            }
            else
            {
                PNLDetails.Enabled = true;
                RezeptdetailsAnzeigen();
            }

        }

        private void LIBOrezZutaten_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LIBOrezZutaten.SelectedIndex == -1)
            {
                BTNzutLöschen.Enabled = false;
                ZutatelementeLeeren();
            }
            else
            {
                BTNzutLöschen.Enabled = true;
                ZutatendetailsAnzeigen();
            }
        }

        private void BTNrezSpeichern_Click(object sender, EventArgs e)
        {
            bool überprüfung = RezeptattributeAktualisieren();

            if (überprüfung == true)
            {
                RezeptelementeLeeren();
                ZutatelementeLeeren();
                PNLDetails.Enabled = false;
            }
            
        }

        private void BTNzutHinzufuegen_Click(object sender, EventArgs e)
        {
            ZutatattributeAktualisieren();
            ZutatelementeLeeren();
            LIBOrezZutaten.SelectedIndex = -1;
        }

        private void BTNzutLöschen_Click(object sender, EventArgs e)
        {
            LIBOrezZutaten.Items.Remove(LIBOrezZutaten.SelectedItem);
        }

        private void BTNrezAbbrechen_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sind Sie sicher, dass Sie das Rezept nicht speichern möchten?","Achtung!",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                RezeptelementeLeeren();
                ZutatelementeLeeren();
                PNLDetails.Enabled = false;
                LIBORezepte.SelectedIndex = -1;
            }
        }

        #endregion




        #region METHODEN

        private void RezeptdetailsAnzeigen()
        {
            try
            {
                Rezept r = LIBORezepte.SelectedItem as Rezept;
                TBrezName.Text = r.GetSetRName;
                NMRCrezPersonen.Value = r.GetSetRpersonen;

                LIBOrezZutaten.Items.Clear();
                foreach (Zutat z in r.GetSetRzutaten)
                {
                    LIBOrezZutaten.Items.Add(z);
                }

                RTBrezZubereitung.Text = r.GetSetRzubereitung;
                NMRCrezDauer.Value = r.GetSetRdauer;

                foreach (string s in r.GetSetRkategorie)
                {
                    for (int i = 0; i < CLBrezKategorien.Items.Count; i++)
                    {
                        if (CLBrezKategorien.Items[i].ToString() == s)
                        {
                            CLBrezKategorien.SetItemChecked(i, true);
                            //Um den Rest der Schleif nicht auszuführen da dort nie ein treffer sein kann
                            i = CLBrezKategorien.Items.Count;
                        }
                    }
                }

                RTBrezNotizen.Text = r.GetSetRNotiz;
            }
            catch (Exception)
            {

                return;
            }
            

        }

        private void ZutatendetailsAnzeigen()
        {
            Zutat z = LIBOrezZutaten.SelectedItem as Zutat;
            TBzutName.Text = z.GetSetZName;
            TBzutMenge.Text = z.GetSetZmenge;
            TBzutEinheit.Text = z.GetSetZeinheit;
        }

        private bool RezeptattributeAktualisieren()
        {
            Rezept r = new Rezept();

            if (TBrezName.Text != "")
            {
                r.GetSetRName = TBrezName.Text;
            }
            else
            {
                MessageBox.Show("Es muss ein Name Eingetragen sein!");
            }
            
            
            r.GetSetRpersonen = NMRCrezPersonen.Value;

            
            List<Zutat> zutat = new List<Zutat>();
            if (LIBOrezZutaten.Items.Count > 0)
            {
                foreach (Zutat z in LIBOrezZutaten.Items)
                {
                    zutat.Add(z);
                }
            }
            else
            {
                MessageBox.Show("Es muss mindesten eine Zutat geben!");
                return false;
            }
            r.GetSetRzutaten = zutat;

            r.GetSetRzubereitung = RTBrezZubereitung.Text;
            r.GetSetRdauer = NMRCrezDauer.Value;

            List<string> kategorie = new List<string>();
            if (CLBrezKategorien.CheckedItems.Count > 0)
            {
                foreach (string cb in CLBrezKategorien.CheckedItems)
                {
                    kategorie.Add(cb);
                }
            }
            else
            {
                MessageBox.Show("Es muss mindesten eine Kategorie ausgewählt sein!");
                return false;
            }
            r.GetSetRkategorie = kategorie;

            r.GetSetRNotiz = RTBrezNotizen.Text;

            LIBORezepte.Items.Add(r);
            if (LIBORezepte.SelectedIndex != -1)
            {
                LIBORezepte.Items.Remove(LIBORezepte.SelectedItem);
            }
            return true;
        }

        private void ZutatattributeAktualisieren()
        {
            if (TBzutName.Text != "" && TBzutMenge.Text != "" && TBzutEinheit.Text != "")
            {
                Zutat zutat = new Zutat();
                zutat.GetSetZName = TBzutName.Text;
                zutat.GetSetZmenge = TBzutMenge.Text;
                zutat.GetSetZeinheit = TBzutEinheit.Text;

                LIBOrezZutaten.Items.Add(zutat);
                LIBOrezZutaten.Items.Remove(LIBOrezZutaten.SelectedItem);
            }
            else
            {
                MessageBox.Show("Die Zutat muss einen Namen, eine Menge und eine Einheit haben!");
            }
            
        }

        private void ZutatelementeLeeren()
        {
            TBzutEinheit.Clear();
            TBzutMenge.Clear();
            TBzutName.Clear();
        }

        private void RezeptelementeLeeren()
        {
            TBrezName.Clear();
            NMRCrezPersonen.Value = 0;
            LIBOrezZutaten.Items.Clear();
            RTBrezZubereitung.Clear();
            NMRCrezDauer.Value = 0;
            for (int i = 0; i < CLBrezKategorien.Items.Count; i++)
            {
                CLBrezKategorien.SetItemChecked(i, false);
            }
            RTBrezNotizen.Clear();
        }

        private void NeuesRezeptErstellen()
        {
            LIBORezepte.SelectedIndex = -1;

            BTNrezSpeichern.Visible = true;
            BTNrezAbbrechen.Visible = true;

            PNLDetails.Enabled = true;

            RezeptdetailsAnzeigen();
        }

        private void RezeptLöschen()
        {
            Rezept r = LIBORezepte.SelectedItem as Rezept;

            if (MessageBox.Show("Wollen Sie das Rezept '" + r.GetSetRName + "' wirklich entgültig löschen?", "Wirklich löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LIBORezepte.Items.Remove(LIBORezepte.SelectedItem);
                LIBORezepte.SelectedIndex = -1;
            }
        }


        public void neuesDoc()
        {
            LIBORezepte.Items.Clear();
            ZutatelementeLeeren();
            RezeptelementeLeeren();
            PNLDetails.Enabled = false;
        }

        #endregion






    }
}
