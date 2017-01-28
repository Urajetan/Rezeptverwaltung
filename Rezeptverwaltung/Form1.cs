using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace Rezeptverwaltung
{
    public partial class MasterDetailForm : Form
    {
        public MasterDetailForm()
        {
            InitializeComponent();
        }

        #region EVENST
        /// <summary>
        /// Setzt den Selected Index der RezeptListbox = -1 wenn keine Änderungen vorgenommen werden
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MasterDetailForm_DoubleClick(object sender, EventArgs e)
        {

            if (LIBORezepte.SelectedIndex > -1)
            {

                //True heißt es ist alles gleich geblieben
                if (RezeptpanelAenderungsüberprüfung())
                {
                    LIBORezepte.SelectedIndex = -1;
                    RezeptelementeLeeren();
                    ZutatelementeLeeren();
                }
                //es gab eine Verändeung die man speichern kann
                else
                {
                    DialogResult res = MessageBox.Show("Wollen Sie das Rezept erst speichern?", "Änderungen speichern?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                    //Rezept welches derzeit bearbeitet wird, wird gespeichert
                    //Steuerelemente für Rezepte und Zutaten werden geleert
                    if (res == DialogResult.Yes)
                    {
                        RezeptattributeAktualisieren();

                        LIBORezepte.SelectedIndex = -1;
                        RezeptelementeLeeren();
                        ZutatelementeLeeren();
                    }
                    //Steuerelemente für Rezepte und Zutaten werden geleert
                    else if (res == DialogResult.No)
                    {
                        LIBORezepte.SelectedIndex = -1;
                        RezeptelementeLeeren();
                        ZutatelementeLeeren();
                    }
                    else if (res == DialogResult.Cancel)
                    {
                        //nichts passiert
                    }
                }

            }


        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PNLDetails_Click(object sender, EventArgs e)
        {

            Zutat z = LIBOrezZutaten.SelectedItem as Zutat;

            //falls eins der TBzut Steuerelemente nicht den Wert enthält der in der Zutat gespeichert ist
            if (z != null && (!z.GetSetZName.Equals(TBzutName.Text) || !z.GetSetZmenge.Equals(TBzutMenge.Text) || !z.GetSetZeinheit.Equals(TBzutEinheit.Text)))
            {
                DialogResult res = MessageBox.Show("Wollen Sie die Zutat speichern?", "Speichern?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (res == DialogResult.Yes)
                {
                    ZutatattributeAktualisieren();
                }
                else if (res == DialogResult.No)
                {
                    LIBOrezZutaten.SelectedIndex = -1;
                    ZutatelementeLeeren();
                }
                else if (res == DialogResult.Cancel)
                {
                    // nix
                }

            }
            //Falls alle TBzut Steuerelemente den Wert haben der in der Zutat gespeichert ist
            else if (z != null && (z.GetSetZName.Equals(TBzutName.Text) && z.GetSetZmenge.Equals(TBzutMenge.Text) && z.GetSetZeinheit.Equals(TBzutEinheit.Text)))
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

        private void TSBspeichern_Click(object sender, EventArgs e)
        {
            InXMLSpeichern();
        }
        private void speichernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InXMLSpeichern();
        }

        private void TSBrezeptdateiOeffnen_Click(object sender, EventArgs e)
        {
            XMLOeffnen();
        }
        private void öffnenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XMLOeffnen();
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
            if (MessageBox.Show("Sind Sie sicher, dass Sie das Rezept nicht speichern möchten?", "Achtung!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                RezeptelementeLeeren();
                ZutatelementeLeeren();
                PNLDetails.Enabled = false;
                LIBORezepte.SelectedIndex = -1;
            }
        }

        private void PBrezBild_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog OrginalPfad = new OpenFileDialog();
            OrginalPfad.Title = "Bild einfügen";

            if (OrginalPfad.ShowDialog() == DialogResult.OK)
            {
                string Zielpfad = ZielpfadErstellen(OrginalPfad.FileName, OrginalPfad.SafeFileName);

                //wenn die Datei .png oder .jpg ist aber der Opfad nicht der ZPfad ist
                if (Bildvalidierung(OrginalPfad.FileName) && OrginalPfad.FileName != Zielpfad)
                {
                    Bildverschieben(Zielpfad, OrginalPfad.FileName);
                }

                if (File.Exists(Zielpfad))
                {
                    PBrezBild.Image = Image.FromFile(Zielpfad);
                    PBrezBild.Image.Tag = Zielpfad;
                }

            }

        }

        private void PNLDetails_EnabledChanged(object sender, EventArgs e)
        {
            if (PNLDetails.Enabled == true)
            {
                LIBORezepte.Enabled = false;
                TSHauptmenue.Enabled = false;
                MSHauptmenue.Enabled = false;
            }
            else if (PNLDetails.Enabled == false)
            {
                LIBORezepte.Enabled = true;
                TSHauptmenue.Enabled = true;
                MSHauptmenue.Enabled = true;
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

                //kategorien auswählen
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

                //Bild laden falls vorhanden
                if (File.Exists(r.GetSetRBildPath))
                {
                    PBrezBild.Image = Image.FromFile(r.GetSetRBildPath);
                    PBrezBild.Image.Tag = r.GetSetRBildPath;
                }
                else if (r.GetSetRBildPath == null)
                {
                    //Wurde kein Bild eingefügt
                }
                else
                {
                    MessageBox.Show("Das Bild muss neu eingebunden werden!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

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

            //Der speicherpfad ist als string im Tag gespeichert
            if (PBrezBild.Image != null)
            {
                r.GetSetRBildPath = PBrezBild.Image.Tag.ToString();
            }



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
            if (PBrezBild.Image != null)
            {
                PBrezBild.Image.Dispose();
                PBrezBild.Image = null;
            }

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
            if (LIBORezepte.SelectedIndex >= 0)
            {
                Rezept r = LIBORezepte.SelectedItem as Rezept;

                if (MessageBox.Show("Wollen Sie das Rezept '" + r.GetSetRName + "' wirklich entgültig löschen?", "Wirklich löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    LIBORezepte.Items.Remove(LIBORezepte.SelectedItem);
                    LIBORezepte.SelectedIndex = -1;
                }
            }
        }

        private void InXMLSpeichern()
        {
            if (LIBORezepte.Items.Count > 0)
            {
                DatenController dc = new Rezeptverwaltung.DatenController();
                List<Rezept> SaveRezepte = new List<Rezept>();

                foreach (var item in LIBORezepte.Items)
                {
                    SaveRezepte.Add(item as Rezept);
                }

                dc.XMLspeichern(SaveRezepte);
            }
            else
            {
                MessageBox.Show("Es gibt keine Rezepte die zu speichern sind!");
            }
        }

        public void neuesDoc()
        {
            LIBORezepte.Items.Clear();
            ZutatelementeLeeren();
            RezeptelementeLeeren();
            PNLDetails.Enabled = false;
        }

        private void XMLOeffnen()
        {
            if (LIBORezepte.Items.Count == 0)
            {
                List<Rezept> openRezepte = XMLOeffnungsprotokoll();

                if (openRezepte != null)
                {
                    //löscht alle Einträge
                    this.neuesDoc();

                    foreach (Rezept rez in openRezepte)
                    {
                        LIBORezepte.Items.Add(rez);
                    }
                }

            }
            else
            {
                DialogResult res = MessageBox.Show("Sollen Sie die Rezepte vorher noch speichern?", "Speichern?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);


                if (res == DialogResult.Yes)
                {
                    try
                    {
                        InXMLSpeichern();
                    }
                    catch
                    {
                        MessageBox.Show("Die rezepte konnten nicht gespeichert werden. Schließen Sie das Programm nicht sondern kontaktieren Sie den Programmierer!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    List<Rezept> openRezepte = XMLOeffnungsprotokoll();


                    if (openRezepte != null)
                    {
                        //löscht alle Einträge
                        this.neuesDoc();

                        foreach (Rezept rez in openRezepte)
                        {
                            LIBORezepte.Items.Add(rez);
                        }
                    }


                }
                else if (res == DialogResult.No)
                {
                    List<Rezept> openRezepte = XMLOeffnungsprotokoll();

                    if (openRezepte != null)
                    {
                        //löscht alle Einträge
                        this.neuesDoc();

                        foreach (Rezept rez in openRezepte)
                        {
                            LIBORezepte.Items.Add(rez);
                        }
                    }

                }
                else if (res == DialogResult.Cancel)
                {
                    return;
                }
            }
        }
        private List<Rezept> XMLOeffnungsprotokoll()
        {
            DatenController dc = new DatenController();
            try
            {
                List<Rezept> openRezepte = dc.XMLladen();
                return openRezepte;
            }
            catch (Exception)
            {
                MessageBox.Show("Die Datei ist beschädigt und kann nicht geladen werden!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        private bool Bildvalidierung(string BildPfad)
        {
            if (File.Exists(BildPfad))
            {
                FileInfo fi = new FileInfo(BildPfad);
                string dateiendung = fi.Extension;
                if (dateiendung == ".png" || dateiendung == ".jpg")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Es gibt die Bilddatei nicht!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


        }
        private string ZielpfadErstellen(string Orginalbildpfad, string Bildname)
        {
            string destinationPath = "";

            try
            {
                #region DestinationPath erstellen

                //Der Pfad der .exe Datei um die Gesammte Ordnerhirachie einzulesen
                string lokalPath = Directory.GetCurrentDirectory();

                string[] splitedLocalPath = lokalPath.Split('\\');
                //nehme \Rezeptverwaltung\bin\debug weg und hänge \Speicherungen\Bilder an
                //Bilddatei soll in \Speicherungen\Bilder kopiert werden um von dort aus genutzt zu werden
                string[] splitedTargetPath = new string[splitedLocalPath.Length - 1];

                //füllt den destinationPath mit der Vorrausgehenden Ordnerhirachie
                for (int i = 0; i < splitedLocalPath.Length - 3; i++)
                {
                    splitedTargetPath[i] = splitedLocalPath[i];
                }

                // ergänzt \Speicherungen\Bilder\
                splitedTargetPath[splitedTargetPath.Length - 2] = "Speicherungen";
                splitedTargetPath[splitedTargetPath.Length - 1] = "Bilder";

                //Bildet aus dem Array einen string
                foreach (string s in splitedTargetPath)
                {
                    destinationPath = destinationPath + s + "\\";
                }
                //Dateinamen Anhängen
                destinationPath = destinationPath + Bildname;


                #endregion

                return destinationPath;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            return null;
        }
        private void Bildverschieben(string BildZielpfad, string Orginalbildpfad)
        {
            try
            {
                if (File.Exists(BildZielpfad))
                {
                    File.Delete(BildZielpfad);
                }

                //Bilddatei kopieren
                File.Copy(Orginalbildpfad, BildZielpfad);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private bool RezeptpanelAenderungsüberprüfung()
        {
            try
            {
                Rezept r = LIBORezepte.SelectedItem as Rezept;

                #region konvertirungen
                List<Zutat> zList = new List<Zutat>();
                foreach (Zutat zut in LIBOrezZutaten.Items)
                {
                    zList.Add(zut);
                }

                string Bildpfad = null;
                if (PBrezBild.Image != null)
                {
                    Bildpfad = PBrezBild.Image.Tag.ToString();
                }

                List<string> chekedKategorie = new List<string>();
                foreach (string CheckKat in CLBrezKategorien.CheckedItems)
                {
                    chekedKategorie.Add(CheckKat);
                }

                #endregion

                if (TBrezName.Text.Equals(r.GetSetRName) &&
                    NMRCrezPersonen.Value.Equals(r.GetSetRpersonen) &&
                    NMRCrezDauer.Value.Equals(r.GetSetRdauer) &&
                    Bildpfad.Equals(r.GetSetRBildPath) &&
                    zList.SequenceEqual(r.GetSetRzutaten) &&
                    RTBrezZubereitung.Text.Equals(r.GetSetRzubereitung) &&
                    chekedKategorie.SequenceEqual(r.GetSetRkategorie) &&
                    RTBrezNotizen.Text.Equals(r.GetSetRNotiz)
                    )
                {
                    return true;
                }


            }
            catch (Exception e)
            {
                MessageBox.Show("Konvertierungsfehler in RezeptpanelAenderungsüberprüfung()\n" + e.Message);
            }

            return false;
        }



        #endregion







    }
}
