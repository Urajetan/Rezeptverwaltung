namespace Rezeptverwaltung
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
            this.PBrezBild = new System.Windows.Forms.PictureBox();
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
            this.TSHauptmenue = new System.Windows.Forms.ToolStrip();
            this.TSBneuesRezept = new System.Windows.Forms.ToolStripButton();
            this.TSBrezeptLöschen = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSBrezeptdateiOeffnen = new System.Windows.Forms.ToolStripButton();
            this.TSBspeichern = new System.Windows.Forms.ToolStripButton();
            this.TSBdrucken = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TSTBnamensuche = new System.Windows.Forms.ToolStripTextBox();
            this.TSBnamenssuche = new System.Windows.Forms.ToolStripButton();
            this.TSBfilter = new System.Windows.Forms.ToolStripSplitButton();
            this.vorspeiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suppeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hauptgerichtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beilageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dessertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kuchenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plätzchenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tortenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pralienenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speichernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öffnenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rezeptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.erstellenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.löschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.druckenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sucheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filternToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterAufhebenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MSHauptmenue = new System.Windows.Forms.MenuStrip();
            this.GBDetails.SuspendLayout();
            this.PNLDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBrezBild)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NMRCrezDauer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NMRCrezPersonen)).BeginInit();
            this.TSHauptmenue.SuspendLayout();
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
            this.PNLDetails.Controls.Add(this.PBrezBild);
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
            this.PNLDetails.EnabledChanged += new System.EventHandler(this.PNLDetails_EnabledChanged);
            this.PNLDetails.Click += new System.EventHandler(this.PNLDetails_Click);
            // 
            // PBrezBild
            // 
            this.PBrezBild.BackColor = System.Drawing.Color.White;
            this.PBrezBild.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PBrezBild.Location = new System.Drawing.Point(216, 23);
            this.PBrezBild.Name = "PBrezBild";
            this.PBrezBild.Size = new System.Drawing.Size(280, 109);
            this.PBrezBild.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBrezBild.TabIndex = 27;
            this.PBrezBild.TabStop = false;
            this.PBrezBild.WaitOnLoad = true;
            this.PBrezBild.DoubleClick += new System.EventHandler(this.PBrezBild_DoubleClick);
            // 
            // LABreInMin
            // 
            this.LABreInMin.AutoSize = true;
            this.LABreInMin.Location = new System.Drawing.Point(130, 111);
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
            this.NMRCrezDauer.Location = new System.Drawing.Point(9, 109);
            this.NMRCrezDauer.Name = "NMRCrezDauer";
            this.NMRCrezDauer.Size = new System.Drawing.Size(120, 23);
            this.NMRCrezDauer.TabIndex = 25;
            // 
            // LABrezDauer
            // 
            this.LABrezDauer.AutoSize = true;
            this.LABrezDauer.Location = new System.Drawing.Point(6, 92);
            this.LABrezDauer.Name = "LABrezDauer";
            this.LABrezDauer.Size = new System.Drawing.Size(47, 17);
            this.LABrezDauer.TabIndex = 24;
            this.LABrezDauer.Text = "Dauer";
            // 
            // BTNrezAbbrechen
            // 
            this.BTNrezAbbrechen.Location = new System.Drawing.Point(385, 627);
            this.BTNrezAbbrechen.Name = "BTNrezAbbrechen";
            this.BTNrezAbbrechen.Size = new System.Drawing.Size(111, 26);
            this.BTNrezAbbrechen.TabIndex = 23;
            this.BTNrezAbbrechen.Text = "Abbrechen";
            this.BTNrezAbbrechen.UseVisualStyleBackColor = true;
            this.BTNrezAbbrechen.Click += new System.EventHandler(this.BTNrezAbbrechen_Click);
            // 
            // BTNrezSpeichern
            // 
            this.BTNrezSpeichern.Location = new System.Drawing.Point(3, 627);
            this.BTNrezSpeichern.Name = "BTNrezSpeichern";
            this.BTNrezSpeichern.Size = new System.Drawing.Size(111, 26);
            this.BTNrezSpeichern.TabIndex = 22;
            this.BTNrezSpeichern.Text = "Speichern";
            this.BTNrezSpeichern.UseVisualStyleBackColor = true;
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
            this.RTBrezNotizen.Size = new System.Drawing.Size(266, 111);
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
            this.BTNzutLöschen.Location = new System.Drawing.Point(312, 322);
            this.BTNzutLöschen.Name = "BTNzutLöschen";
            this.BTNzutLöschen.Size = new System.Drawing.Size(72, 23);
            this.BTNzutLöschen.TabIndex = 15;
            this.BTNzutLöschen.Text = "-";
            this.BTNzutLöschen.UseVisualStyleBackColor = true;
            this.BTNzutLöschen.Click += new System.EventHandler(this.BTNzutLöschen_Click);
            // 
            // BTNzutHinzufuegen
            // 
            this.BTNzutHinzufuegen.Location = new System.Drawing.Point(216, 322);
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
            this.LABzutEinheit.Location = new System.Drawing.Point(213, 268);
            this.LABzutEinheit.Name = "LABzutEinheit";
            this.LABzutEinheit.Size = new System.Drawing.Size(51, 17);
            this.LABzutEinheit.TabIndex = 13;
            this.LABzutEinheit.Text = "Einheit";
            // 
            // TBzutEinheit
            // 
            this.TBzutEinheit.Location = new System.Drawing.Point(215, 288);
            this.TBzutEinheit.Name = "TBzutEinheit";
            this.TBzutEinheit.Size = new System.Drawing.Size(169, 23);
            this.TBzutEinheit.TabIndex = 12;
            // 
            // LABzutMenge
            // 
            this.LABzutMenge.AutoSize = true;
            this.LABzutMenge.Location = new System.Drawing.Point(212, 216);
            this.LABzutMenge.Name = "LABzutMenge";
            this.LABzutMenge.Size = new System.Drawing.Size(51, 17);
            this.LABzutMenge.TabIndex = 11;
            this.LABzutMenge.Text = "Menge";
            // 
            // TBzutMenge
            // 
            this.TBzutMenge.Location = new System.Drawing.Point(215, 236);
            this.TBzutMenge.Name = "TBzutMenge";
            this.TBzutMenge.Size = new System.Drawing.Size(169, 23);
            this.TBzutMenge.TabIndex = 10;
            // 
            // LABzutName
            // 
            this.LABzutName.AutoSize = true;
            this.LABzutName.Location = new System.Drawing.Point(212, 159);
            this.LABzutName.Name = "LABzutName";
            this.LABzutName.Size = new System.Drawing.Size(45, 17);
            this.LABzutName.TabIndex = 9;
            this.LABzutName.Text = "Name";
            // 
            // TBzutName
            // 
            this.TBzutName.Location = new System.Drawing.Point(215, 179);
            this.TBzutName.Name = "TBzutName";
            this.TBzutName.Size = new System.Drawing.Size(169, 23);
            this.TBzutName.TabIndex = 8;
            // 
            // LABrezZutaten
            // 
            this.LABrezZutaten.AutoSize = true;
            this.LABrezZutaten.Location = new System.Drawing.Point(6, 139);
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
            this.LIBOrezZutaten.Location = new System.Drawing.Point(7, 159);
            this.LIBOrezZutaten.Name = "LIBOrezZutaten";
            this.LIBOrezZutaten.Size = new System.Drawing.Size(169, 164);
            this.LIBOrezZutaten.Sorted = true;
            this.LIBOrezZutaten.TabIndex = 6;
            this.LIBOrezZutaten.SelectedIndexChanged += new System.EventHandler(this.LIBOrezZutaten_SelectedIndexChanged);
            // 
            // NMRCrezPersonen
            // 
            this.NMRCrezPersonen.Location = new System.Drawing.Point(9, 66);
            this.NMRCrezPersonen.Name = "NMRCrezPersonen";
            this.NMRCrezPersonen.Size = new System.Drawing.Size(56, 23);
            this.NMRCrezPersonen.TabIndex = 5;
            // 
            // LABrezPersonen
            // 
            this.LABrezPersonen.AutoSize = true;
            this.LABrezPersonen.Location = new System.Drawing.Point(6, 49);
            this.LABrezPersonen.Name = "LABrezPersonen";
            this.LABrezPersonen.Size = new System.Drawing.Size(151, 17);
            this.LABrezPersonen.TabIndex = 4;
            this.LABrezPersonen.Text = "Für wie viele Personen";
            // 
            // LABorezName
            // 
            this.LABorezName.AutoSize = true;
            this.LABorezName.Location = new System.Drawing.Point(3, 3);
            this.LABorezName.Name = "LABorezName";
            this.LABorezName.Size = new System.Drawing.Size(45, 17);
            this.LABorezName.TabIndex = 2;
            this.LABorezName.Text = "Name";
            // 
            // TBrezName
            // 
            this.TBrezName.Location = new System.Drawing.Point(6, 23);
            this.TBrezName.Name = "TBrezName";
            this.TBrezName.Size = new System.Drawing.Size(169, 23);
            this.TBrezName.TabIndex = 1;
            // 
            // TSHauptmenue
            // 
            this.TSHauptmenue.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.TSHauptmenue.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSBneuesRezept,
            this.TSBrezeptLöschen,
            this.toolStripSeparator1,
            this.TSBrezeptdateiOeffnen,
            this.TSBspeichern,
            this.TSBdrucken,
            this.toolStripSeparator2,
            this.TSTBnamensuche,
            this.TSBnamenssuche,
            this.TSBfilter,
            this.toolStripSeparator3});
            this.TSHauptmenue.Location = new System.Drawing.Point(0, 24);
            this.TSHauptmenue.Name = "TSHauptmenue";
            this.TSHauptmenue.Size = new System.Drawing.Size(1184, 31);
            this.TSHauptmenue.TabIndex = 4;
            this.TSHauptmenue.Text = "TSHauptmenue";
            // 
            // TSBneuesRezept
            // 
            this.TSBneuesRezept.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBneuesRezept.Image = global::Rezeptverwaltung.Properties.Resources.Dokument;
            this.TSBneuesRezept.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBneuesRezept.Name = "TSBneuesRezept";
            this.TSBneuesRezept.Size = new System.Drawing.Size(28, 28);
            this.TSBneuesRezept.Text = "Neues Rezept";
            this.TSBneuesRezept.Click += new System.EventHandler(this.TSBneuesRezept_Click);
            // 
            // TSBrezeptLöschen
            // 
            this.TSBrezeptLöschen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBrezeptLöschen.Image = global::Rezeptverwaltung.Properties.Resources.RotesX;
            this.TSBrezeptLöschen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBrezeptLöschen.Name = "TSBrezeptLöschen";
            this.TSBrezeptLöschen.Size = new System.Drawing.Size(28, 28);
            this.TSBrezeptLöschen.Text = "Rezept Löschen";
            this.TSBrezeptLöschen.Click += new System.EventHandler(this.TSBrezeptLöschen_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // TSBrezeptdateiOeffnen
            // 
            this.TSBrezeptdateiOeffnen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBrezeptdateiOeffnen.Image = global::Rezeptverwaltung.Properties.Resources.Öffnen;
            this.TSBrezeptdateiOeffnen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBrezeptdateiOeffnen.Name = "TSBrezeptdateiOeffnen";
            this.TSBrezeptdateiOeffnen.Size = new System.Drawing.Size(28, 28);
            this.TSBrezeptdateiOeffnen.Text = "Rezeptdatei öffnen";
            this.TSBrezeptdateiOeffnen.Click += new System.EventHandler(this.TSBrezeptdateiOeffnen_Click);
            // 
            // TSBspeichern
            // 
            this.TSBspeichern.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBspeichern.Image = global::Rezeptverwaltung.Properties.Resources.Speichern;
            this.TSBspeichern.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBspeichern.Name = "TSBspeichern";
            this.TSBspeichern.Size = new System.Drawing.Size(28, 28);
            this.TSBspeichern.Text = "Speichern";
            this.TSBspeichern.ToolTipText = "Speichern";
            this.TSBspeichern.Click += new System.EventHandler(this.TSBspeichern_Click);
            // 
            // TSBdrucken
            // 
            this.TSBdrucken.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBdrucken.Image = global::Rezeptverwaltung.Properties.Resources.Drucken;
            this.TSBdrucken.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBdrucken.Name = "TSBdrucken";
            this.TSBdrucken.Size = new System.Drawing.Size(28, 28);
            this.TSBdrucken.Text = "Drucken";
            this.TSBdrucken.ToolTipText = "Drucken";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // TSTBnamensuche
            // 
            this.TSTBnamensuche.Name = "TSTBnamensuche";
            this.TSTBnamensuche.Size = new System.Drawing.Size(100, 31);
            // 
            // TSBnamenssuche
            // 
            this.TSBnamenssuche.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBnamenssuche.Image = global::Rezeptverwaltung.Properties.Resources.Lupe;
            this.TSBnamenssuche.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBnamenssuche.Name = "TSBnamenssuche";
            this.TSBnamenssuche.Size = new System.Drawing.Size(28, 28);
            this.TSBnamenssuche.Text = "Suchen";
            // 
            // TSBfilter
            // 
            this.TSBfilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBfilter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vorspeiseToolStripMenuItem,
            this.suppeToolStripMenuItem,
            this.salatToolStripMenuItem,
            this.hauptgerichtToolStripMenuItem,
            this.beilageToolStripMenuItem,
            this.dessertToolStripMenuItem,
            this.kuchenToolStripMenuItem,
            this.plätzchenToolStripMenuItem,
            this.tortenToolStripMenuItem,
            this.pralienenToolStripMenuItem});
            this.TSBfilter.Image = global::Rezeptverwaltung.Properties.Resources.Filter;
            this.TSBfilter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBfilter.Name = "TSBfilter";
            this.TSBfilter.Size = new System.Drawing.Size(40, 28);
            this.TSBfilter.Text = "Filter aktivieren";
            // 
            // vorspeiseToolStripMenuItem
            // 
            this.vorspeiseToolStripMenuItem.Name = "vorspeiseToolStripMenuItem";
            this.vorspeiseToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.vorspeiseToolStripMenuItem.Text = "Vorspeise";
            // 
            // suppeToolStripMenuItem
            // 
            this.suppeToolStripMenuItem.Name = "suppeToolStripMenuItem";
            this.suppeToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.suppeToolStripMenuItem.Text = "Suppe";
            // 
            // salatToolStripMenuItem
            // 
            this.salatToolStripMenuItem.Name = "salatToolStripMenuItem";
            this.salatToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.salatToolStripMenuItem.Text = "Salat";
            // 
            // hauptgerichtToolStripMenuItem
            // 
            this.hauptgerichtToolStripMenuItem.Name = "hauptgerichtToolStripMenuItem";
            this.hauptgerichtToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.hauptgerichtToolStripMenuItem.Text = "Hauptgericht";
            // 
            // beilageToolStripMenuItem
            // 
            this.beilageToolStripMenuItem.Name = "beilageToolStripMenuItem";
            this.beilageToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.beilageToolStripMenuItem.Text = "Beilage";
            // 
            // dessertToolStripMenuItem
            // 
            this.dessertToolStripMenuItem.Name = "dessertToolStripMenuItem";
            this.dessertToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.dessertToolStripMenuItem.Text = "Dessert";
            // 
            // kuchenToolStripMenuItem
            // 
            this.kuchenToolStripMenuItem.Name = "kuchenToolStripMenuItem";
            this.kuchenToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.kuchenToolStripMenuItem.Text = "Kuchen";
            // 
            // plätzchenToolStripMenuItem
            // 
            this.plätzchenToolStripMenuItem.Name = "plätzchenToolStripMenuItem";
            this.plätzchenToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.plätzchenToolStripMenuItem.Text = "Plätzchen";
            // 
            // tortenToolStripMenuItem
            // 
            this.tortenToolStripMenuItem.Name = "tortenToolStripMenuItem";
            this.tortenToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.tortenToolStripMenuItem.Text = "Torten";
            // 
            // pralienenToolStripMenuItem
            // 
            this.pralienenToolStripMenuItem.Name = "pralienenToolStripMenuItem";
            this.pralienenToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.pralienenToolStripMenuItem.Text = "Pralienen";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.speichernToolStripMenuItem,
            this.öffnenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // speichernToolStripMenuItem
            // 
            this.speichernToolStripMenuItem.Name = "speichernToolStripMenuItem";
            this.speichernToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.speichernToolStripMenuItem.Text = "Speichern";
            this.speichernToolStripMenuItem.Click += new System.EventHandler(this.speichernToolStripMenuItem_Click);
            // 
            // öffnenToolStripMenuItem
            // 
            this.öffnenToolStripMenuItem.Name = "öffnenToolStripMenuItem";
            this.öffnenToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.öffnenToolStripMenuItem.Text = "Öffnen";
            this.öffnenToolStripMenuItem.Click += new System.EventHandler(this.öffnenToolStripMenuItem_Click);
            // 
            // rezeptToolStripMenuItem
            // 
            this.rezeptToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.erstellenToolStripMenuItem,
            this.löschenToolStripMenuItem,
            this.druckenToolStripMenuItem});
            this.rezeptToolStripMenuItem.Name = "rezeptToolStripMenuItem";
            this.rezeptToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.rezeptToolStripMenuItem.Text = "Rezept";
            // 
            // erstellenToolStripMenuItem
            // 
            this.erstellenToolStripMenuItem.Name = "erstellenToolStripMenuItem";
            this.erstellenToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.erstellenToolStripMenuItem.Text = "Erstellen";
            this.erstellenToolStripMenuItem.Click += new System.EventHandler(this.erstellenToolStripMenuItem_Click);
            // 
            // löschenToolStripMenuItem
            // 
            this.löschenToolStripMenuItem.Name = "löschenToolStripMenuItem";
            this.löschenToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.löschenToolStripMenuItem.Text = "Löschen";
            this.löschenToolStripMenuItem.Click += new System.EventHandler(this.löschenToolStripMenuItem_Click);
            // 
            // druckenToolStripMenuItem
            // 
            this.druckenToolStripMenuItem.Name = "druckenToolStripMenuItem";
            this.druckenToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.druckenToolStripMenuItem.Text = "Drucken";
            // 
            // sucheToolStripMenuItem
            // 
            this.sucheToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filternToolStripMenuItem,
            this.filterAufhebenToolStripMenuItem});
            this.sucheToolStripMenuItem.Name = "sucheToolStripMenuItem";
            this.sucheToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.sucheToolStripMenuItem.Text = "Filter";
            // 
            // filternToolStripMenuItem
            // 
            this.filternToolStripMenuItem.Name = "filternToolStripMenuItem";
            this.filternToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.filternToolStripMenuItem.Text = "Filter aktivieren";
            // 
            // filterAufhebenToolStripMenuItem
            // 
            this.filterAufhebenToolStripMenuItem.Name = "filterAufhebenToolStripMenuItem";
            this.filterAufhebenToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.filterAufhebenToolStripMenuItem.Text = "Filter aufheben";
            // 
            // MSHauptmenue
            // 
            this.MSHauptmenue.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MSHauptmenue.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.rezeptToolStripMenuItem,
            this.sucheToolStripMenuItem});
            this.MSHauptmenue.Location = new System.Drawing.Point(0, 0);
            this.MSHauptmenue.Name = "MSHauptmenue";
            this.MSHauptmenue.Size = new System.Drawing.Size(1184, 24);
            this.MSHauptmenue.TabIndex = 3;
            this.MSHauptmenue.Text = "Hauptmenue";
            // 
            // MasterDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 752);
            this.Controls.Add(this.TSHauptmenue);
            this.Controls.Add(this.GBDetails);
            this.Controls.Add(this.LIBORezepte);
            this.Controls.Add(this.MSHauptmenue);
            this.MainMenuStrip = this.MSHauptmenue;
            this.MaximumSize = new System.Drawing.Size(1200, 790);
            this.MinimumSize = new System.Drawing.Size(1200, 790);
            this.Name = "MasterDetailForm";
            this.Text = "Rezeptverwaltung";
            this.DoubleClick += new System.EventHandler(this.MasterDetailForm_DoubleClick);
            this.GBDetails.ResumeLayout(false);
            this.PNLDetails.ResumeLayout(false);
            this.PNLDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBrezBild)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NMRCrezDauer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NMRCrezPersonen)).EndInit();
            this.TSHauptmenue.ResumeLayout(false);
            this.TSHauptmenue.PerformLayout();
            this.MSHauptmenue.ResumeLayout(false);
            this.MSHauptmenue.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LIBORezepte;
        private System.Windows.Forms.GroupBox GBDetails;
        private System.Windows.Forms.Panel PNLDetails;
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
        private System.Windows.Forms.ToolStrip TSHauptmenue;
        private System.Windows.Forms.ToolStripButton TSBneuesRezept;
        private System.Windows.Forms.ToolStripButton TSBrezeptLöschen;
        private System.Windows.Forms.ToolStripButton TSBrezeptdateiOeffnen;
        private System.Windows.Forms.ToolStripButton TSBspeichern;
        private System.Windows.Forms.ToolStripButton TSBnamenssuche;
        private System.Windows.Forms.ToolStripButton TSBdrucken;
        private System.Windows.Forms.ToolStripTextBox TSTBnamensuche;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSplitButton TSBfilter;
        private System.Windows.Forms.ToolStripMenuItem vorspeiseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suppeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hauptgerichtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beilageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dessertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kuchenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plätzchenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tortenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pralienenToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speichernToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öffnenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rezeptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem erstellenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem löschenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem druckenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sucheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filternToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterAufhebenToolStripMenuItem;
        private System.Windows.Forms.MenuStrip MSHauptmenue;
        private System.Windows.Forms.PictureBox PBrezBild;
    }
}

