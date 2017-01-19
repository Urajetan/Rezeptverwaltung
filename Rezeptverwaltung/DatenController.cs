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
using System.Xml;


namespace Rezeptverwaltung
{
    class DatenController
    {

        #region Persistenz

        private void XMLspeichern(List<Rezept> Lrezept)
        {
            //erstellt XMLDocument im Speicher
            XmlDocument xmlDoc = new XmlDocument();
            //Declarationzeile
            XmlDeclaration declaration = xmlDoc.CreateXmlDeclaration("1.0", "ISO-8859-1", null);
            //schreibt Declarationzeile als erste Zeile ins doc
            xmlDoc.InsertBefore(declaration, xmlDoc.DocumentElement);



            XmlNode rootnode = xmlDoc.CreateElement("RezeptListe");
            xmlDoc.AppendChild(rootnode);

            //für alle Rezepte
            foreach (Rezept rez in Lrezept)
            {
                XmlNode Rezeptnode = xmlDoc.CreateElement("Rezept");
                rootnode.AppendChild(Rezeptnode);

                XmlNode Rezeptnamenode = xmlDoc.CreateElement("Rezeptname");
                Rezeptnamenode.InnerText = rez.GetSetRName;
                Rezeptnode.AppendChild(Rezeptnamenode);

                XmlNode Rezeptpersonennode = xmlDoc.CreateElement("Rezeptpersonen");
                Rezeptpersonennode.InnerText = Convert.ToString(rez.GetSetRpersonen);
                Rezeptnode.AppendChild(Rezeptpersonennode);

                //für alle Zutaten in dem Rezept
                foreach (Zutat zut in rez.GetSetRzutaten)
                {
                    XmlNode Zutatnode = xmlDoc.CreateElement("Zutat");
                    Rezeptnode.AppendChild(Zutatnode);

                    XmlNode Zutatnamenode = xmlDoc.CreateElement("Zutatname");
                    Zutatnamenode.InnerText = zut.GetSetZName;
                    Zutatnode.AppendChild(Zutatnamenode);

                    XmlNode Zutatmengenode = xmlDoc.CreateElement("Zutatmenge");
                    Zutatmengenode.InnerText = zut.GetSetZmenge;
                    Zutatnode.AppendChild(Zutatmengenode);

                    XmlNode Zutateinheitnode = xmlDoc.CreateElement("Zutateinheit");
                    Zutateinheitnode.InnerText = zut.GetSetZmenge;
                    Zutatnode.AppendChild(Zutateinheitnode);
                }

                XmlNode Rezeptzubereitungnode = xmlDoc.CreateElement("Rezeptzubereitung");
                Rezeptzubereitungnode.InnerText = rez.GetSetRzubereitung;
                Rezeptnode.AppendChild(Rezeptzubereitungnode);

                XmlNode Rezeptdauernode = xmlDoc.CreateElement("Rezeptdauer");
                Rezeptdauernode.InnerText = Convert.ToString(rez.GetSetRdauer);
                Rezeptnode.AppendChild(Rezeptdauernode);

                //für alle Kategorien in dem Rezept
                foreach (string kat in rez.GetSetRkategorie)
                {
                    XmlNode Kategorienode = xmlDoc.CreateElement("Kategorie");
                    Rezeptnode.AppendChild(Kategorienode);

                    XmlNode Kategorienamenode = xmlDoc.CreateElement("Kategoriename");
                    Kategorienamenode.InnerText = kat;
                    Kategorienode.AppendChild(Kategorienamenode);
                }

                XmlNode Rezeptnotiznode = xmlDoc.CreateElement("Rezeptnotiz");
                Rezeptnotiznode.InnerText = rez.GetSetRNotiz;
                Rezeptnode.AppendChild(Rezeptnotiznode);

            }


            //Benutzer gibt Speicherpfad an
            SaveFileDialog sfd1 = new SaveFileDialog();

            //wenn der Pfad existiert
            if (sfd1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                xmlDoc.Save(sfd1.FileName);
            }
        }

        private void XMLladen(object sender, EventArgs e)
        {
            //Benutzer gibt die zu ladende Datei an
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult res = DialogResult.Abort;

            res = ofd.ShowDialog();

            //falls Benutzer eine Datei ausgewählt hat
            //andernfalls wäre im Dialogfenster der Abbrechen oder der Schließen Button gedückt worden
            if (res == DialogResult.OK)
            {
                //Try Catch damit das Programm an einer manipulierten Datei nicht abstürzt
                try
                {
                    //löscht alle Einträge
                    neuesDoc();

                    //Quellpfad der Datei
                    string path = ofd.FileName;


                    XmlDocument doc = new XmlDocument();
                    //Läd das XMLdokument
                    doc.Load(path);


                    XmlNodeList allCDs = doc.SelectNodes("//CDListe/CD");

                    //erstellt alle CDs
                    foreach (XmlNode cdNode in allCDs)
                    {
                        //Liste aller Titel dieser CD

                        //Um
                        //./Titel
                        //zu verstehen
                        //schau auf Moodle XPath an
                        XmlNodeList allTitel = cdNode.SelectNodes("./Titel");

                        //Der CD muss eine List aller Titel übergeben werden
                        //Siehe CD Konstruktor
                        List<Titel> titelList = new List<Titel>();

                        //läd den Albumname aus Datei
                        XmlElement albumname = cdNode.SelectSingleNode("Albumname") as XmlElement;

                        //erstellt alle Titel für die CD und speichert diese
                        foreach (XmlNode titelNode in allTitel)
                        {
                            //läd die Titelatribute
                            //siehe Titelkonstruktor
                            XmlElement titelname = titelNode.SelectSingleNode("Titelname") as XmlElement;
                            XmlElement interpret = titelNode.SelectSingleNode("Interpret") as XmlElement;
                            XmlElement titellaenge = titelNode.SelectSingleNode("Titellaenge") as XmlElement;
                            XmlElement titelnummer = titelNode.SelectSingleNode("Titelnummer") as XmlElement;
                            XmlElement titelbewertung = titelNode.SelectSingleNode("Titelbewertung") as XmlElement;

                            //erstellt einen Titel mit geladenen Attributen
                            Titel x = new Titel(titelname.InnerText, interpret.InnerText, TimeSpan.Parse(Convert.ToString(titellaenge.InnerText)), Convert.ToInt32(titelnummer.InnerText), Convert.ToInt32(titelbewertung.InnerText));

                            //Fügt alle Titel der zu Liste für die CD hinzu
                            titelList.Add(x);
                        }

                        //läd restlichen CD-Attribute
                        XmlElement albumbewertung = cdNode.SelectSingleNode("Albumbewertung") as XmlElement;
                        XmlElement erscheinungsjahr = cdNode.SelectSingleNode("Erscheinungsjahr") as XmlElement;
                        XmlElement genre = cdNode.SelectSingleNode("Genre") as XmlElement;

                        //erstellt CD
                        CD loadedCD = new CD(albumname.InnerText, titelList, genre.InnerText, erscheinungsjahr.InnerText, Convert.ToInt32(albumbewertung.InnerText));

                        //Fügt der Listbox die CD hinzu
                        CDListbox.Items.Add(loadedCD);
                    }
                }

                //falls die Datei manipulliert war, erscheint eine Fehlermeldung 
                catch (Exception)
                {
                    MessageBox.Show("Die Datei ist keine XML Datei oder die Datei ist beschädigt.");
                }
            }
        }

        #endregion
    }
}
