﻿namespace Rezeptverwaltung
{
    partial class MasterDetailForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.LIBORezepte = new System.Windows.Forms.ListBox();
            this.GBDetails = new System.Windows.Forms.GroupBox();
            this.PNLDetails = new System.Windows.Forms.Panel();
            this.LABreInMin = new System.Windows.Forms.Label();
            this.NMRCrezDauer = new System.Windows.Forms.NumericUpDown();
            this.LABrezDauer = new System.Windows.Forms.Label();
            this.BTNrezAbbrechen = new System.Windows.Forms.Button();
            this.BTNrezSpeichern = new System.Windows.Forms.Button();
            this.LABrezNotizen = new System.Windows.Forms.Label();
            this.RTBrezNotizen = new System.Windows.Forms.RichTextBox();
            this.CLBrezKategorien = new System.Windows.Forms.CheckedListBox();
            this.LABrzKategorien = new System.Windows.Forms.Label();
            this.LABrezZubereitung = new System.Windows.Forms.Label();
            this.RTBrezZubereitung = new System.Windows.Forms.RichTextBox();
            this.BTNzutLöschen = new System.Windows.Forms.Button();
            this.BTNzutHinzufuegen = new System.Windows.Forms.Button();
            this.LABzutEinheit = new System.Windows.Forms.Label();
            this.TBzutEinheit = new System.Windows.Forms.TextBox();
            this.LABzutMenge = new System.Windows.Forms.Label();
            this.TBzutMenge = new System.Windows.Forms.TextBox();
            this.LABzutName = new System.Windows.Forms.Label();
            this.TBzutName = new System.Windows.Forms.TextBox();
            this.LABrezZutaten = new System.Windows.Forms.Label();
            this.LIBOrezZutaten = new System.Windows.Forms.ListBox();
            this.NMRCrezPersonen = new System.Windows.Forms.NumericUpDown();
            this.LABrezPersonen = new System.Windows.Forms.Label();
            this.LABorezName = new System.Windows.Forms.Label();
            this.TBrezName = new System.Windows.Forms.TextBox();
            this.MSHauptmenue = new System.Windows.Forms.MenuStrip();
            this.rezeptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.erstellenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.löschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.druckenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sucheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filternToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vorspeiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suppeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hauptgerichtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beilageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dessertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kuchenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.torteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plätzchenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pralinenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterAufhebenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GBDetails.SuspendLayout();
            this.PNLDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NMRCrezDauer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NMRCrezPersonen)).BeginInit();
            this.MSHauptmenue.SuspendLayout();
            this.SuspendLayout();
            // 
            // LIBORezepte
            // 
            this.LIBORezepte.DisplayMember = "GetSetRName";
            this.LIBORezepte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LIBORezepte.FormattingEnabled = true;
            this.LIBORezepte.ItemHeight = 16;
            this.LIBORezepte.Location = new System.Drawing.Point(12, 66);
            this.LIBORezepte.Name = "LIBORezepte";
            this.LIBORezepte.Size = new System.Drawing.Size(600, 676);
            this.LIBORezepte.Sorted = true;
            this.LIBORezepte.TabIndex = 1;
            this.LIBORezepte.SelectedIndexChanged += new System.EventHandler(this.LIBORezepte_SelectedIndexChanged);
            // 
            // GBDetails
            // 
            this.GBDetails.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GBDetails.Controls.Add(this.PNLDetails);
            this.GBDetails.Location = new System.Drawing.Point(641, 66);
            this.GBDetails.Name = "GBDetails";
            this.GBDetails.Size = new System.Drawing.Size(531, 680);
            this.GBDetails.TabIndex = 2;
            this.GBDetails.TabStop = false;
            this.GBDetails.Text = "Details";
            // 
            // PNLDetails
            // 
            this.PNLDetails.Controls.Add(this.LABreInMin);
            this.PNLDetails.Controls.Add(this.NMRCrezDauer);
            this.PNLDetails.Controls.Add(this.LABrezDauer);
            this.PNLDetails.Controls.Add(this.BTNrezAbbrechen);
            this.PNLDetails.Controls.Add(this.BTNrezSpeichern);
            this.PNLDetails.Controls.Add(this.LABrezNotizen);
            this.PNLDetails.Controls.Add(this.RTBrezNotizen);
            this.PNLDetails.Controls.Add(this.CLBrezKategorien);
            this.PNLDetails.Controls.Add(this.LABrzKategorien);
            this.PNLDetails.Controls.Add(this.LABrezZubereitung);
            this.PNLDetails.Controls.Add(this.RTBrezZubereitung);
            this.PNLDetails.Controls.Add(this.BTNzutLöschen);
            this.PNLDetails.Controls.Add(this.BTNzutHinzufuegen);
            this.PNLDetails.Controls.Add(this.LABzutEinheit);
            this.PNLDetails.Controls.Add(this.TBzutEinheit);
            this.PNLDetails.Controls.Add(this.LABzutMenge);
            this.PNLDetails.Controls.Add(this.TBzutMenge);
            this.PNLDetails.Controls.Add(this.LABzutName);
            this.PNLDetails.Controls.Add(this.TBzutName);
            this.PNLDetails.Controls.Add(this.LABrezZutaten);
            this.PNLDetails.Controls.Add(this.LIBOrezZutaten);
            this.PNLDetails.Controls.Add(this.NMRCrezPersonen);
            this.PNLDetails.Controls.Add(this.LABrezPersonen);
            this.PNLDetails.Controls.Add(this.LABorezName);
            this.PNLDetails.Controls.Add(this.TBrezName);
            this.PNLDetails.Enabled = false;
            this.PNLDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PNLDetails.Location = new System.Drawing.Point(6, 19);
            this.PNLDetails.Name = "PNLDetails";
            this.PNLDetails.Size = new System.Drawing.Size(509, 655);
            this.PNLDetails.TabIndex = 3;
            this.PNLDetails.Click += new System.EventHandler(this.PNLDetails_Click);
            // 
            // LABreInMin
            // 
            this.LABreInMin.AutoSize = true;
            this.LABreInMin.Location = new System.Drawing.Point(340, 82);
            this.LABreInMin.Name = "LABreInMin";
            this.LABreInMin.Size = new System.Drawing.Size(58, 17);
            this.LABreInMin.TabIndex = 26;
            this.LABreInMin.Text = "Minuten";
            // 
            // NMRCrezDauer
            // 
            this.NMRCrezDauer.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NMRCrezDauer.Location = new System.Drawing.Point(215, 80);
            this.NMRCrezDauer.Name = "NMRCrezDauer";
            this.NMRCrezDauer.Size = new System.Drawing.Size(120, 23);
            this.NMRCrezDauer.TabIndex = 25;
            // 
            // LABrezDauer
            // 
            this.LABrezDauer.AutoSize = true;
            this.LABrezDauer.Location = new System.Drawing.Point(216, 63);
            this.LABrezDauer.Name = "LABrezDauer";
            this.LABrezDauer.Size = new System.Drawing.Size(47, 17);
            this.LABrezDauer.TabIndex = 24;
            this.LABrezDauer.Text = "Dauer";
            // 
            // BTNrezAbbrechen
            // 
            this.BTNrezAbbrechen.Location = new System.Drawing.Point(385, 627);
            this.BTNrezAbbrechen.Name = "BTNrezAbbrechen";
            this.BTNrezAbbrechen.Size = new System.Drawing.Size(111, 25);
            this.BTNrezAbbrechen.TabIndex = 23;
            this.BTNrezAbbrechen.Text = "Abbrechen";
            this.BTNrezAbbrechen.UseVisualStyleBackColor = true;
            this.BTNrezAbbrechen.Visible = false;
            // 
            // BTNrezSpeichern
            // 
            this.BTNrezSpeichern.Location = new System.Drawing.Point(3, 627);
            this.BTNrezSpeichern.Name = "BTNrezSpeichern";
            this.BTNrezSpeichern.Size = new System.Drawing.Size(111, 25);
            this.BTNrezSpeichern.TabIndex = 22;
            this.BTNrezSpeichern.Text = "Speichern";
            this.BTNrezSpeichern.UseVisualStyleBackColor = true;
            this.BTNrezSpeichern.Visible = false;
            this.BTNrezSpeichern.Click += new System.EventHandler(this.BTNrezSpeichern_Click);
            // 
            // LABrezNotizen
            // 
            this.LABrezNotizen.AutoSize = true;
            this.LABrezNotizen.Location = new System.Drawing.Point(227, 480);
            this.LABrezNotizen.Name = "LABrezNotizen";
            this.LABrezNotizen.Size = new System.Drawing.Size(56, 17);
            this.LABrezNotizen.TabIndex = 21;
            this.LABrezNotizen.Text = "Notizen";
            // 
            // RTBrezNotizen
            // 
            this.RTBrezNotizen.Location = new System.Drawing.Point(230, 500);
            this.RTBrezNotizen.Name = "RTBrezNotizen";
            this.RTBrezNotizen.Size = new System.Drawing.Size(266, 108);
            this.RTBrezNotizen.TabIndex = 20;
            this.RTBrezNotizen.Text = "";
            // 
            // CLBrezKategorien
            // 
            this.CLBrezKategorien.CheckOnClick = true;
            this.CLBrezKategorien.FormattingEnabled = true;
            this.CLBrezKategorien.Items.AddRange(new object[] {
            "Vorspeise",
            "Suppe",
            "Salat",
            "Hauptgericht",
            "Beilage",
            "Dessert",
            "Kuchen",
            "Plätzchen",
            "Torte",
            "Pralienen",
            "Low Carb"});
            this.CLBrezKategorien.Location = new System.Drawing.Point(6, 499);
            this.CLBrezKategorien.Name = "CLBrezKategorien";
            this.CLBrezKategorien.Size = new System.Drawing.Size(204, 112);
            this.CLBrezKategorien.TabIndex = 19;
            this.CLBrezKategorien.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CLBrezKategorien_ItemCheck);
            // 
            // LABrzKategorien
            // 
            this.LABrzKategorien.AutoSize = true;
            this.LABrzKategorien.Location = new System.Drawing.Point(3, 479);
            this.LABrzKategorien.Name = "LABrzKategorien";
            this.LABrzKategorien.Size = new System.Drawing.Size(77, 17);
            this.LABrzKategorien.TabIndex = 18;
            this.LABrzKategorien.Text = "Kategorien";
            // 
            // LABrezZubereitung
            // 
            this.LABrezZubereitung.AutoSize = true;
            this.LABrezZubereitung.Location = new System.Drawing.Point(3, 341);
            this.LABrezZubereitung.Name = "LABrezZubereitung";
            this.LABrezZubereitung.Size = new System.Drawing.Size(85, 17);
            this.LABrezZubereitung.TabIndex = 17;
            this.LABrezZubereitung.Text = "Zubereitung";
            // 
            // RTBrezZubereitung
            // 
            this.RTBrezZubereitung.Location = new System.Drawing.Point(6, 361);
            this.RTBrezZubereitung.Name = "RTBrezZubereitung";
            this.RTBrezZubereitung.Size = new System.Drawing.Size(490, 108);
            this.RTBrezZubereitung.TabIndex = 16;
            this.RTBrezZubereitung.Text = "";
            // 
            // BTNzutLöschen
            // 
            this.BTNzutLöschen.Enabled = false;
            this.BTNzutLöschen.Location = new System.Drawing.Point(312, 300);
            this.BTNzutLöschen.Name = "BTNzutLöschen";
            this.BTNzutLöschen.Size = new System.Drawing.Size(72, 23);
            this.BTNzutLöschen.TabIndex = 15;
            this.BTNzutLöschen.Text = "-";
            this.BTNzutLöschen.UseVisualStyleBackColor = true;
            // 
            // BTNzutHinzufuegen
            // 
            this.BTNzutHinzufuegen.Location = new System.Drawing.Point(216, 300);
            this.BTNzutHinzufuegen.Name = "BTNzutHinzufuegen";
            this.BTNzutHinzufuegen.Size = new System.Drawing.Size(72, 23);
            this.BTNzutHinzufuegen.TabIndex = 14;
            this.BTNzutHinzufuegen.Text = "+";
            this.BTNzutHinzufuegen.UseVisualStyleBackColor = true;
            this.BTNzutHinzufuegen.Click += new System.EventHandler(this.BTNzutHinzufuegen_Click);
            // 
            // LABzutEinheit
            // 
            this.LABzutEinheit.AutoSize = true;
            this.LABzutEinheit.Location = new System.Drawing.Point(213, 246);
            this.LABzutEinheit.Name = "LABzutEinheit";
            this.LABzutEinheit.Size = new System.Drawing.Size(51, 17);
            this.LABzutEinheit.TabIndex = 13;
            this.LABzutEinheit.Text = "Einheit";
            // 
            // TBzutEinheit
            // 
            this.TBzutEinheit.Location = new System.Drawing.Point(215, 266);
            this.TBzutEinheit.Name = "TBzutEinheit";
            this.TBzutEinheit.Size = new System.Drawing.Size(169, 23);
            this.TBzutEinheit.TabIndex = 12;
            // 
            // LABzutMenge
            // 
            this.LABzutMenge.AutoSize = true;
            this.LABzutMenge.Location = new System.Drawing.Point(212, 194);
            this.LABzutMenge.Name = "LABzutMenge";
            this.LABzutMenge.Size = new System.Drawing.Size(51, 17);
            this.LABzutMenge.TabIndex = 11;
            this.LABzutMenge.Text = "Menge";
            // 
            // TBzutMenge
            // 
            this.TBzutMenge.Location = new System.Drawing.Point(215, 214);
            this.TBzutMenge.Name = "TBzutMenge";
            this.TBzutMenge.Size = new System.Drawing.Size(169, 23);
            this.TBzutMenge.TabIndex = 10;
            // 
            // LABzutName
            // 
            this.LABzutName.AutoSize = true;
            this.LABzutName.Location = new System.Drawing.Point(212, 137);
            this.LABzutName.Name = "LABzutName";
            this.LABzutName.Size = new System.Drawing.Size(45, 17);
            this.LABzutName.TabIndex = 9;
            this.LABzutName.Text = "Name";
            // 
            // TBzutName
            // 
            this.TBzutName.Location = new System.Drawing.Point(215, 157);
            this.TBzutName.Name = "TBzutName";
            this.TBzutName.Size = new System.Drawing.Size(169, 23);
            this.TBzutName.TabIndex = 8;
            // 
            // LABrezZutaten
            // 
            this.LABrezZutaten.AutoSize = true;
            this.LABrezZutaten.Location = new System.Drawing.Point(6, 117);
            this.LABrezZutaten.Name = "LABrezZutaten";
            this.LABrezZutaten.Size = new System.Drawing.Size(57, 17);
            this.LABrezZutaten.TabIndex = 7;
            this.LABrezZutaten.Text = "Zutaten";
            // 
            // LIBOrezZutaten
            // 
            this.LIBOrezZutaten.DisplayMember = "GetSetZName";
            this.LIBOrezZutaten.FormattingEnabled = true;
            this.LIBOrezZutaten.ItemHeight = 16;
            this.LIBOrezZutaten.Location = new System.Drawing.Point(7, 137);
            this.LIBOrezZutaten.Name = "LIBOrezZutaten";
            this.LIBOrezZutaten.Size = new System.Drawing.Size(169, 180);
            this.LIBOrezZutaten.Sorted = true;
            this.LIBOrezZutaten.TabIndex = 6;
            this.LIBOrezZutaten.SelectedIndexChanged += new System.EventHandler(this.LIBOrezZutaten_SelectedIndexChanged);
            // 
            // NMRCrezPersonen
            // 
            this.NMRCrezPersonen.Location = new System.Drawing.Point(7, 80);
            this.NMRCrezPersonen.Name = "NMRCrezPersonen";
            this.NMRCrezPersonen.Size = new System.Drawing.Size(56, 23);
            this.NMRCrezPersonen.TabIndex = 5;
            // 
            // LABrezPersonen
            // 
            this.LABrezPersonen.AutoSize = true;
            this.LABrezPersonen.Location = new System.Drawing.Point(4, 63);
            this.LABrezPersonen.Name = "LABrezPersonen";
            this.LABrezPersonen.Size = new System.Drawing.Size(151, 17);
            this.LABrezPersonen.TabIndex = 4;
            this.LABrezPersonen.Text = "Für wie viele Personen";
            // 
            // LABorezName
            // 
            this.LABorezName.AutoSize = true;
            this.LABorezName.Location = new System.Drawing.Point(4, 12);
            this.LABorezName.Name = "LABorezName";
            this.LABorezName.Size = new System.Drawing.Size(45, 17);
            this.LABorezName.TabIndex = 2;
            this.LABorezName.Text = "Name";
            // 
            // TBrezName
            // 
            this.TBrezName.Location = new System.Drawing.Point(7, 32);
            this.TBrezName.Name = "TBrezName";
            this.TBrezName.Size = new System.Drawing.Size(169, 23);
            this.TBrezName.TabIndex = 1;
            // 
            // MSHauptmenue
            // 
            this.MSHauptmenue.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rezeptToolStripMenuItem,
            this.sucheToolStripMenuItem});
            this.MSHauptmenue.Location = new System.Drawing.Point(0, 0);
            this.MSHauptmenue.Name = "MSHauptmenue";
            this.MSHauptmenue.Size = new System.Drawing.Size(1184, 24);
            this.MSHauptmenue.TabIndex = 3;
            this.MSHauptmenue.Text = "Hauptmenue";
            // 
            // rezeptToolStripMenuItem
            // 
            this.rezeptToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.erstellenToolStripMenuItem,
            this.bearbeitenToolStripMenuItem,
            this.löschenToolStripMenuItem,
            this.druckenToolStripMenuItem});
            this.rezeptToolStripMenuItem.Name = "rezeptToolStripMenuItem";
            this.rezeptToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.rezeptToolStripMenuItem.Text = "Rezept";
            // 
            // erstellenToolStripMenuItem
            // 
            this.erstellenToolStripMenuItem.Name = "erstellenToolStripMenuItem";
            this.erstellenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.erstellenToolStripMenuItem.Text = "Erstellen";
            this.erstellenToolStripMenuItem.Click += new System.EventHandler(this.erstellenToolStripMenuItem_Click);
            // 
            // bearbeitenToolStripMenuItem
            // 
            this.bearbeitenToolStripMenuItem.Name = "bearbeitenToolStripMenuItem";
            this.bearbeitenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.bearbeitenToolStripMenuItem.Text = "Bearbeiten";
            // 
            // löschenToolStripMenuItem
            // 
            this.löschenToolStripMenuItem.Name = "löschenToolStripMenuItem";
            this.löschenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.löschenToolStripMenuItem.Text = "Löschen";
            // 
            // druckenToolStripMenuItem
            // 
            this.druckenToolStripMenuItem.Name = "druckenToolStripMenuItem";
            this.druckenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.druckenToolStripMenuItem.Text = "Drucken";
            // 
            // sucheToolStripMenuItem
            // 
            this.sucheToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filternToolStripMenuItem,
            this.filterAufhebenToolStripMenuItem});
            this.sucheToolStripMenuItem.Name = "sucheToolStripMenuItem";
            this.sucheToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.sucheToolStripMenuItem.Text = "Suche";
            // 
            // filternToolStripMenuItem
            // 
            this.filternToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vorspeiseToolStripMenuItem,
            this.suppeToolStripMenuItem,
            this.salatToolStripMenuItem,
            this.hauptgerichtToolStripMenuItem,
            this.beilageToolStripMenuItem,
            this.dessertToolStripMenuItem,
            this.kuchenToolStripMenuItem,
            this.torteToolStripMenuItem,
            this.plätzchenToolStripMenuItem,
            this.pralinenToolStripMenuItem});
            this.filternToolStripMenuItem.Name = "filternToolStripMenuItem";
            this.filternToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.filternToolStripMenuItem.Text = "Filtern";
            // 
            // vorspeiseToolStripMenuItem
            // 
            this.vorspeiseToolStripMenuItem.Name = "vorspeiseToolStripMenuItem";
            this.vorspeiseToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.vorspeiseToolStripMenuItem.Text = "Vorspeisen";
            // 
            // suppeToolStripMenuItem
            // 
            this.suppeToolStripMenuItem.Name = "suppeToolStripMenuItem";
            this.suppeToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.suppeToolStripMenuItem.Text = "Suppen";
            // 
            // salatToolStripMenuItem
            // 
            this.salatToolStripMenuItem.Name = "salatToolStripMenuItem";
            this.salatToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.salatToolStripMenuItem.Text = "Salate";
            // 
            // hauptgerichtToolStripMenuItem
            // 
            this.hauptgerichtToolStripMenuItem.Name = "hauptgerichtToolStripMenuItem";
            this.hauptgerichtToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.hauptgerichtToolStripMenuItem.Text = "Hauptgerichte";
            // 
            // beilageToolStripMenuItem
            // 
            this.beilageToolStripMenuItem.Name = "beilageToolStripMenuItem";
            this.beilageToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.beilageToolStripMenuItem.Text = "Beilagen";
            // 
            // dessertToolStripMenuItem
            // 
            this.dessertToolStripMenuItem.Name = "dessertToolStripMenuItem";
            this.dessertToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.dessertToolStripMenuItem.Text = "Desserts";
            // 
            // kuchenToolStripMenuItem
            // 
            this.kuchenToolStripMenuItem.Name = "kuchenToolStripMenuItem";
            this.kuchenToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.kuchenToolStripMenuItem.Text = "Kuchen";
            // 
            // torteToolStripMenuItem
            // 
            this.torteToolStripMenuItem.Name = "torteToolStripMenuItem";
            this.torteToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.torteToolStripMenuItem.Text = "Torten";
            // 
            // plätzchenToolStripMenuItem
            // 
            this.plätzchenToolStripMenuItem.Name = "plätzchenToolStripMenuItem";
            this.plätzchenToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.plätzchenToolStripMenuItem.Text = "Plätzchen";
            // 
            // pralinenToolStripMenuItem
            // 
            this.pralinenToolStripMenuItem.Name = "pralinenToolStripMenuItem";
            this.pralinenToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.pralinenToolStripMenuItem.Text = "Pralinen";
            // 
            // filterAufhebenToolStripMenuItem
            // 
            this.filterAufhebenToolStripMenuItem.Name = "filterAufhebenToolStripMenuItem";
            this.filterAufhebenToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.filterAufhebenToolStripMenuItem.Text = "Filter aufheben";
            // 
            // MasterDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 762);
            this.Controls.Add(this.GBDetails);
            this.Controls.Add(this.LIBORezepte);
            this.Controls.Add(this.MSHauptmenue);
            this.MainMenuStrip = this.MSHauptmenue;
            this.Name = "MasterDetailForm";
            this.Text = "Rezeptverwaltung";
            this.Click += new System.EventHandler(this.MasterDetailForm_Click);
            this.GBDetails.ResumeLayout(false);
            this.PNLDetails.ResumeLayout(false);
            this.PNLDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NMRCrezDauer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NMRCrezPersonen)).EndInit();
            this.MSHauptmenue.ResumeLayout(false);
            this.MSHauptmenue.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LIBORezepte;
        private System.Windows.Forms.GroupBox GBDetails;
        private System.Windows.Forms.Panel PNLDetails;
        private System.Windows.Forms.MenuStrip MSHauptmenue;
        private System.Windows.Forms.ToolStripMenuItem rezeptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem erstellenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bearbeitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem löschenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem druckenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sucheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filternToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vorspeiseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suppeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hauptgerichtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beilageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dessertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kuchenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem torteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plätzchenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pralinenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterAufhebenToolStripMenuItem;
        private System.Windows.Forms.Label LABrezZutaten;
        private System.Windows.Forms.ListBox LIBOrezZutaten;
        private System.Windows.Forms.NumericUpDown NMRCrezPersonen;
        private System.Windows.Forms.Label LABrezPersonen;
        private System.Windows.Forms.Label LABorezName;
        private System.Windows.Forms.TextBox TBrezName;
        private System.Windows.Forms.Label LABzutName;
        private System.Windows.Forms.TextBox TBzutName;
        private System.Windows.Forms.Label LABrezZubereitung;
        private System.Windows.Forms.RichTextBox RTBrezZubereitung;
        private System.Windows.Forms.Button BTNzutLöschen;
        private System.Windows.Forms.Button BTNzutHinzufuegen;
        private System.Windows.Forms.Label LABzutEinheit;
        private System.Windows.Forms.TextBox TBzutEinheit;
        private System.Windows.Forms.Label LABzutMenge;
        private System.Windows.Forms.TextBox TBzutMenge;
        private System.Windows.Forms.Label LABrezNotizen;
        private System.Windows.Forms.RichTextBox RTBrezNotizen;
        private System.Windows.Forms.CheckedListBox CLBrezKategorien;
        private System.Windows.Forms.Label LABrzKategorien;
        private System.Windows.Forms.Button BTNrezAbbrechen;
        private System.Windows.Forms.Button BTNrezSpeichern;
        private System.Windows.Forms.Label LABrezDauer;
        private System.Windows.Forms.NumericUpDown NMRCrezDauer;
        private System.Windows.Forms.Label LABreInMin;
    }
}

