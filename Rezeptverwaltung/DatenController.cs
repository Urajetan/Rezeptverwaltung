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

        #region XML

        public void XMLspeichern(List<Rezept> Lrezept)
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
                    Zutateinheitnode.InnerText = zut.GetSetZeinheit;
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

        public List<Rezept> XMLladen(MasterDetailForm Form1)
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
                    Form1.neuesDoc();

                    //Quellpfad der Datei
                    string path = ofd.FileName;


                    XmlDocument doc = new XmlDocument();
                    //Läd das XMLdokument
                    doc.Load(path);


                    XmlNodeList alleRezepte = doc.SelectNodes("//RezeptListe/Rezept");
                    List<Rezept> ListGeoeffneteRezept = new List<Rezept>();
                    //erstellt alle Rezepte
                    foreach (XmlNode RezeptNode in alleRezepte)
                    {
                        //Liste aller Titel dieser CD

                        //Um
                        //./Zutat
                        //zu verstehen
                        //schau auf Moodle XPath an
                        XmlNodeList alleZutaten = RezeptNode.SelectNodes("./Zutat");
                        XmlNodeList alleKategorien = RezeptNode.SelectNodes("./Kategorie");

                        //Dem Rezept muss eine List aller Zutaten übergeben werden
                        //Siehe Rezept Konstruktor
                        List<Zutat> ZutatList = new List<Zutat>();


                        //erstellt alle Zutaten für das Rezept und speichert diese
                        foreach (XmlNode ZutatNode in alleZutaten)
                        {
                            //läd die Titelatribute
                            //siehe Titelkonstruktor
                            XmlElement Zutatname = ZutatNode.SelectSingleNode("Zutatname") as XmlElement;
                            XmlElement Zutatmenge = ZutatNode.SelectSingleNode("Zutatmenge") as XmlElement;
                            XmlElement Zutateinheit = ZutatNode.SelectSingleNode("Zutateinheit") as XmlElement;

                            //erstellt einen Titel mit geladenen Attributen
                            Zutat z = new Zutat(Zutatname.InnerText, Zutatmenge.InnerText, Zutateinheit.InnerText);

                            //Fügt alle Titel der zu Liste für die CD hinzu
                            ZutatList.Add(z);
                        }

                        //läd restlichen Rezept-Attribute
                        XmlElement Rezeptname = RezeptNode.SelectSingleNode("Rezeptname") as XmlElement;
                        XmlElement Rezeptpersonen = RezeptNode.SelectSingleNode("Rezeptpersonen") as XmlElement;
                        XmlElement Rezeptzubereitung = RezeptNode.SelectSingleNode("Rezeptzubereitung") as XmlElement;
                        XmlElement Rezeptdauer = RezeptNode.SelectSingleNode("Rezeptdauer") as XmlElement;

                        List<string> KategorieList = new List<string>();

                        foreach (XmlNode KategorieNode in alleKategorien)
                        {
                            XmlElement Kategoriename = KategorieNode.SelectSingleNode("Kategoriename") as XmlElement;

                            KategorieList.Add(KategorieList.ToString());
                        }

                        XmlElement Rezeptnotiz = RezeptNode.SelectSingleNode("Rezeptnotiz") as XmlElement;

                        XmlElement Bildpfad = RezeptNode.SelectSingleNode("Bildpfad") as XmlElement;


                        //erstellt Rezept
                        Rezept loadedRezept = new Rezept(Rezeptname.InnerText, Convert.ToDecimal(Rezeptpersonen.InnerText), ZutatList, Rezeptzubereitung.InnerText, Convert.ToDecimal(Rezeptdauer.InnerText), KategorieList, Rezeptnotiz.InnerText, Bildpfad.InnerText);

                        //Fügt der Listbox die CD hinzu
                        ListGeoeffneteRezept.Add(loadedRezept);
                    }
                    return ListGeoeffneteRezept;
                }

                //falls die Datei manipulliert war, erscheint eine Fehlermeldung 
                catch (Exception)
                {
                    MessageBox.Show("Die Datei ist keine XML Datei oder die Datei ist beschädigt.");
                    return null;
                }
            }
            return null;
        }

        #endregion



    }
}
