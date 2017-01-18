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
            LIBORezepte.SelectedIndex = -1;
            RezeptelementeLeeren();
            ZutatelementeLeeren();
        }
        private void PNLDetails_Click(object sender, EventArgs e)
        {
            if (LIBOrezZutaten.SelectedIndex != -1)
            {
                LIBOrezZutaten.SelectedIndex = -1;
                ZutatelementeLeeren();
            }
            
        }

        private void erstellenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rezept r = new Rezeptverwaltung.Rezept();
            LIBORezepte.Items.Add(r);
            LIBORezepte.SelectedIndex = LIBORezepte.Items.Count - 1;

            BTNrezSpeichern.Visible = true;
            BTNrezAbbrechen.Visible = true;

            PNLDetails.Enabled = true;

            RezeptdetailsAnzeigen();
        }

        private void CLBrezKategorien_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CLBrezKategorien.SelectedIndex = -1;
        }

        private void LIBORezepte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LIBORezepte.SelectedIndex == -1)
            {
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
                ZutatelementeLeeren();
            }
            else
            {
                ZutatendetailsAnzeigen();
            }
        }


        private void BTNrezSpeichern_Click(object sender, EventArgs e)
        {
            RezeptattributeAktualisieren();
            RezeptelementeLeeren();

        }

        private void BTNzutHinzufuegen_Click(object sender, EventArgs e)
        {
            ZutatattributeAktualisieren();
            LIBOrezZutaten.SelectedIndex = -1;
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

                foreach (Zutat z in r.GetSetRzutaten)
                {
                    LIBOrezZutaten.Items.Add(z);
                }

                RTBrezZubereitung.Text = r.GetSetRzubereitung;
                NMRCrezDauer.Value = r.GetSetRdauer;

                foreach (string s in r.GetSetRkategorie)
                {
                    for (int i = 0; i < CLBrezKategorien.Items.Count - 1; i++)
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

        private void RezeptattributeAktualisieren()
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
                return;
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
                return;
            }
                
            
            
                
            
            r.GetSetRkategorie = kategorie;

            r.GetSetRNotiz = RTBrezNotizen.Text;

            LIBORezepte.Items.Add(r);
            LIBORezepte.Items.Remove(LIBORezepte.SelectedItem);
        }

        private void ZutatattributeAktualisieren()
        {
            
                Zutat zutat = new Zutat();
                zutat.GetSetZName = TBzutName.Text;
                zutat.GetSetZmenge = TBzutMenge.Text;
                zutat.GetSetZeinheit = TBzutEinheit.Text;

                LIBOrezZutaten.Items.Add(zutat);
                LIBOrezZutaten.Items.Remove(LIBOrezZutaten.SelectedItem);
            
            
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







        #endregion

        
    }
}
