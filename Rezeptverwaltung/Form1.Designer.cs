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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterDetailForm));
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
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.TSBdrucken = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TSTBnamensuche = new System.Windows.Forms.ToolStripTextBox();
            this.TSBnamenssuche = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
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
            resources.ApplyResources(this.LIBORezepte, "LIBORezepte");
            this.LIBORezepte.BackColor = System.Drawing.Color.White;
            this.LIBORezepte.DisplayMember = "GetSetRName";
            this.LIBORezepte.FormattingEnabled = true;
            this.LIBORezepte.Name = "LIBORezepte";
            this.LIBORezepte.Sorted = true;
            this.LIBORezepte.SelectedIndexChanged += new System.EventHandler(this.LIBORezepte_SelectedIndexChanged);
            // 
            // GBDetails
            // 
            resources.ApplyResources(this.GBDetails, "GBDetails");
            this.GBDetails.BackColor = System.Drawing.Color.White;
            this.GBDetails.Controls.Add(this.PNLDetails);
            this.GBDetails.Name = "GBDetails";
            this.GBDetails.TabStop = false;
            // 
            // PNLDetails
            // 
            resources.ApplyResources(this.PNLDetails, "PNLDetails");
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
            this.PNLDetails.Name = "PNLDetails";
            this.PNLDetails.EnabledChanged += new System.EventHandler(this.PNLDetails_EnabledChanged);
            this.PNLDetails.Click += new System.EventHandler(this.PNLDetails_Click);
            // 
            // PBrezBild
            // 
            resources.ApplyResources(this.PBrezBild, "PBrezBild");
            this.PBrezBild.BackColor = System.Drawing.Color.White;
            this.PBrezBild.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PBrezBild.Name = "PBrezBild";
            this.PBrezBild.TabStop = false;
            this.PBrezBild.DoubleClick += new System.EventHandler(this.PBrezBild_DoubleClick);
            // 
            // LABreInMin
            // 
            resources.ApplyResources(this.LABreInMin, "LABreInMin");
            this.LABreInMin.Name = "LABreInMin";
            // 
            // NMRCrezDauer
            // 
            resources.ApplyResources(this.NMRCrezDauer, "NMRCrezDauer");
            this.NMRCrezDauer.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NMRCrezDauer.Name = "NMRCrezDauer";
            // 
            // LABrezDauer
            // 
            resources.ApplyResources(this.LABrezDauer, "LABrezDauer");
            this.LABrezDauer.Name = "LABrezDauer";
            // 
            // BTNrezAbbrechen
            // 
            resources.ApplyResources(this.BTNrezAbbrechen, "BTNrezAbbrechen");
            this.BTNrezAbbrechen.Name = "BTNrezAbbrechen";
            this.BTNrezAbbrechen.UseVisualStyleBackColor = true;
            this.BTNrezAbbrechen.Click += new System.EventHandler(this.BTNrezAbbrechen_Click);
            // 
            // BTNrezSpeichern
            // 
            resources.ApplyResources(this.BTNrezSpeichern, "BTNrezSpeichern");
            this.BTNrezSpeichern.Name = "BTNrezSpeichern";
            this.BTNrezSpeichern.UseVisualStyleBackColor = true;
            this.BTNrezSpeichern.Click += new System.EventHandler(this.BTNrezSpeichern_Click);
            // 
            // LABrezNotizen
            // 
            resources.ApplyResources(this.LABrezNotizen, "LABrezNotizen");
            this.LABrezNotizen.Name = "LABrezNotizen";
            // 
            // RTBrezNotizen
            // 
            resources.ApplyResources(this.RTBrezNotizen, "RTBrezNotizen");
            this.RTBrezNotizen.Name = "RTBrezNotizen";
            // 
            // CLBrezKategorien
            // 
            resources.ApplyResources(this.CLBrezKategorien, "CLBrezKategorien");
            this.CLBrezKategorien.CheckOnClick = true;
            this.CLBrezKategorien.FormattingEnabled = true;
            this.CLBrezKategorien.Items.AddRange(new object[] {
            resources.GetString("CLBrezKategorien.Items"),
            resources.GetString("CLBrezKategorien.Items1"),
            resources.GetString("CLBrezKategorien.Items2"),
            resources.GetString("CLBrezKategorien.Items3"),
            resources.GetString("CLBrezKategorien.Items4"),
            resources.GetString("CLBrezKategorien.Items5"),
            resources.GetString("CLBrezKategorien.Items6"),
            resources.GetString("CLBrezKategorien.Items7"),
            resources.GetString("CLBrezKategorien.Items8"),
            resources.GetString("CLBrezKategorien.Items9"),
            resources.GetString("CLBrezKategorien.Items10")});
            this.CLBrezKategorien.Name = "CLBrezKategorien";
            this.CLBrezKategorien.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CLBrezKategorien_ItemCheck);
            // 
            // LABrzKategorien
            // 
            resources.ApplyResources(this.LABrzKategorien, "LABrzKategorien");
            this.LABrzKategorien.Name = "LABrzKategorien";
            // 
            // LABrezZubereitung
            // 
            resources.ApplyResources(this.LABrezZubereitung, "LABrezZubereitung");
            this.LABrezZubereitung.Name = "LABrezZubereitung";
            // 
            // RTBrezZubereitung
            // 
            resources.ApplyResources(this.RTBrezZubereitung, "RTBrezZubereitung");
            this.RTBrezZubereitung.Name = "RTBrezZubereitung";
            // 
            // BTNzutLöschen
            // 
            resources.ApplyResources(this.BTNzutLöschen, "BTNzutLöschen");
            this.BTNzutLöschen.Name = "BTNzutLöschen";
            this.BTNzutLöschen.UseVisualStyleBackColor = true;
            this.BTNzutLöschen.Click += new System.EventHandler(this.BTNzutLöschen_Click);
            // 
            // BTNzutHinzufuegen
            // 
            resources.ApplyResources(this.BTNzutHinzufuegen, "BTNzutHinzufuegen");
            this.BTNzutHinzufuegen.Name = "BTNzutHinzufuegen";
            this.BTNzutHinzufuegen.UseVisualStyleBackColor = true;
            this.BTNzutHinzufuegen.Click += new System.EventHandler(this.BTNzutHinzufuegen_Click);
            // 
            // LABzutEinheit
            // 
            resources.ApplyResources(this.LABzutEinheit, "LABzutEinheit");
            this.LABzutEinheit.Name = "LABzutEinheit";
            // 
            // TBzutEinheit
            // 
            resources.ApplyResources(this.TBzutEinheit, "TBzutEinheit");
            this.TBzutEinheit.Name = "TBzutEinheit";
            // 
            // LABzutMenge
            // 
            resources.ApplyResources(this.LABzutMenge, "LABzutMenge");
            this.LABzutMenge.Name = "LABzutMenge";
            // 
            // TBzutMenge
            // 
            resources.ApplyResources(this.TBzutMenge, "TBzutMenge");
            this.TBzutMenge.Name = "TBzutMenge";
            // 
            // LABzutName
            // 
            resources.ApplyResources(this.LABzutName, "LABzutName");
            this.LABzutName.Name = "LABzutName";
            // 
            // TBzutName
            // 
            resources.ApplyResources(this.TBzutName, "TBzutName");
            this.TBzutName.Name = "TBzutName";
            // 
            // LABrezZutaten
            // 
            resources.ApplyResources(this.LABrezZutaten, "LABrezZutaten");
            this.LABrezZutaten.Name = "LABrezZutaten";
            // 
            // LIBOrezZutaten
            // 
            resources.ApplyResources(this.LIBOrezZutaten, "LIBOrezZutaten");
            this.LIBOrezZutaten.DisplayMember = "GetSetZName";
            this.LIBOrezZutaten.FormattingEnabled = true;
            this.LIBOrezZutaten.Name = "LIBOrezZutaten";
            this.LIBOrezZutaten.Sorted = true;
            this.LIBOrezZutaten.SelectedIndexChanged += new System.EventHandler(this.LIBOrezZutaten_SelectedIndexChanged);
            // 
            // NMRCrezPersonen
            // 
            resources.ApplyResources(this.NMRCrezPersonen, "NMRCrezPersonen");
            this.NMRCrezPersonen.Name = "NMRCrezPersonen";
            // 
            // LABrezPersonen
            // 
            resources.ApplyResources(this.LABrezPersonen, "LABrezPersonen");
            this.LABrezPersonen.Name = "LABrezPersonen";
            // 
            // LABorezName
            // 
            resources.ApplyResources(this.LABorezName, "LABorezName");
            this.LABorezName.Name = "LABorezName";
            // 
            // TBrezName
            // 
            resources.ApplyResources(this.TBrezName, "TBrezName");
            this.TBrezName.Name = "TBrezName";
            // 
            // TSHauptmenue
            // 
            resources.ApplyResources(this.TSHauptmenue, "TSHauptmenue");
            this.TSHauptmenue.BackColor = System.Drawing.Color.Transparent;
            this.TSHauptmenue.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.TSHauptmenue.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSBneuesRezept,
            this.TSBrezeptLöschen,
            this.toolStripSeparator1,
            this.TSBrezeptdateiOeffnen,
            this.TSBspeichern,
            this.toolStripSeparator4,
            this.TSBdrucken,
            this.toolStripSeparator5,
            this.toolStripSeparator2,
            this.TSTBnamensuche,
            this.TSBnamenssuche,
            this.toolStripSeparator6,
            this.TSBfilter,
            this.toolStripSeparator3});
            this.TSHauptmenue.Name = "TSHauptmenue";
            // 
            // TSBneuesRezept
            // 
            resources.ApplyResources(this.TSBneuesRezept, "TSBneuesRezept");
            this.TSBneuesRezept.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBneuesRezept.Image = global::Rezeptverwaltung.Properties.Resources.Dokument;
            this.TSBneuesRezept.Name = "TSBneuesRezept";
            this.TSBneuesRezept.Click += new System.EventHandler(this.TSBneuesRezept_Click);
            // 
            // TSBrezeptLöschen
            // 
            resources.ApplyResources(this.TSBrezeptLöschen, "TSBrezeptLöschen");
            this.TSBrezeptLöschen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBrezeptLöschen.Image = global::Rezeptverwaltung.Properties.Resources.RotesX;
            this.TSBrezeptLöschen.Name = "TSBrezeptLöschen";
            this.TSBrezeptLöschen.Click += new System.EventHandler(this.TSBrezeptLöschen_Click);
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // TSBrezeptdateiOeffnen
            // 
            resources.ApplyResources(this.TSBrezeptdateiOeffnen, "TSBrezeptdateiOeffnen");
            this.TSBrezeptdateiOeffnen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBrezeptdateiOeffnen.Image = global::Rezeptverwaltung.Properties.Resources.Öffnen;
            this.TSBrezeptdateiOeffnen.Name = "TSBrezeptdateiOeffnen";
            this.TSBrezeptdateiOeffnen.Click += new System.EventHandler(this.TSBrezeptdateiOeffnen_Click);
            // 
            // TSBspeichern
            // 
            resources.ApplyResources(this.TSBspeichern, "TSBspeichern");
            this.TSBspeichern.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBspeichern.Image = global::Rezeptverwaltung.Properties.Resources.Speichern;
            this.TSBspeichern.Name = "TSBspeichern";
            this.TSBspeichern.Click += new System.EventHandler(this.TSBspeichern_Click);
            // 
            // toolStripSeparator4
            // 
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            // 
            // TSBdrucken
            // 
            resources.ApplyResources(this.TSBdrucken, "TSBdrucken");
            this.TSBdrucken.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBdrucken.Image = global::Rezeptverwaltung.Properties.Resources.Drucken;
            this.TSBdrucken.Name = "TSBdrucken";
            this.TSBdrucken.Click += new System.EventHandler(this.TSBdrucken_Click);
            // 
            // toolStripSeparator5
            // 
            resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            // 
            // toolStripSeparator2
            // 
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            // 
            // TSTBnamensuche
            // 
            resources.ApplyResources(this.TSTBnamensuche, "TSTBnamensuche");
            this.TSTBnamensuche.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TSTBnamensuche.Name = "TSTBnamensuche";
            // 
            // TSBnamenssuche
            // 
            resources.ApplyResources(this.TSBnamenssuche, "TSBnamenssuche");
            this.TSBnamenssuche.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBnamenssuche.Image = global::Rezeptverwaltung.Properties.Resources.Lupe;
            this.TSBnamenssuche.Name = "TSBnamenssuche";
            // 
            // toolStripSeparator6
            // 
            resources.ApplyResources(this.toolStripSeparator6, "toolStripSeparator6");
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            // 
            // TSBfilter
            // 
            resources.ApplyResources(this.TSBfilter, "TSBfilter");
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
            this.TSBfilter.Name = "TSBfilter";
            // 
            // vorspeiseToolStripMenuItem
            // 
            resources.ApplyResources(this.vorspeiseToolStripMenuItem, "vorspeiseToolStripMenuItem");
            this.vorspeiseToolStripMenuItem.Name = "vorspeiseToolStripMenuItem";
            // 
            // suppeToolStripMenuItem
            // 
            resources.ApplyResources(this.suppeToolStripMenuItem, "suppeToolStripMenuItem");
            this.suppeToolStripMenuItem.Name = "suppeToolStripMenuItem";
            // 
            // salatToolStripMenuItem
            // 
            resources.ApplyResources(this.salatToolStripMenuItem, "salatToolStripMenuItem");
            this.salatToolStripMenuItem.Name = "salatToolStripMenuItem";
            // 
            // hauptgerichtToolStripMenuItem
            // 
            resources.ApplyResources(this.hauptgerichtToolStripMenuItem, "hauptgerichtToolStripMenuItem");
            this.hauptgerichtToolStripMenuItem.Name = "hauptgerichtToolStripMenuItem";
            // 
            // beilageToolStripMenuItem
            // 
            resources.ApplyResources(this.beilageToolStripMenuItem, "beilageToolStripMenuItem");
            this.beilageToolStripMenuItem.Name = "beilageToolStripMenuItem";
            // 
            // dessertToolStripMenuItem
            // 
            resources.ApplyResources(this.dessertToolStripMenuItem, "dessertToolStripMenuItem");
            this.dessertToolStripMenuItem.Name = "dessertToolStripMenuItem";
            // 
            // kuchenToolStripMenuItem
            // 
            resources.ApplyResources(this.kuchenToolStripMenuItem, "kuchenToolStripMenuItem");
            this.kuchenToolStripMenuItem.Name = "kuchenToolStripMenuItem";
            // 
            // plätzchenToolStripMenuItem
            // 
            resources.ApplyResources(this.plätzchenToolStripMenuItem, "plätzchenToolStripMenuItem");
            this.plätzchenToolStripMenuItem.Name = "plätzchenToolStripMenuItem";
            // 
            // tortenToolStripMenuItem
            // 
            resources.ApplyResources(this.tortenToolStripMenuItem, "tortenToolStripMenuItem");
            this.tortenToolStripMenuItem.Name = "tortenToolStripMenuItem";
            // 
            // pralienenToolStripMenuItem
            // 
            resources.ApplyResources(this.pralienenToolStripMenuItem, "pralienenToolStripMenuItem");
            this.pralienenToolStripMenuItem.Name = "pralienenToolStripMenuItem";
            // 
            // toolStripSeparator3
            // 
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            // 
            // dateiToolStripMenuItem
            // 
            resources.ApplyResources(this.dateiToolStripMenuItem, "dateiToolStripMenuItem");
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.speichernToolStripMenuItem,
            this.öffnenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            // 
            // speichernToolStripMenuItem
            // 
            resources.ApplyResources(this.speichernToolStripMenuItem, "speichernToolStripMenuItem");
            this.speichernToolStripMenuItem.Name = "speichernToolStripMenuItem";
            this.speichernToolStripMenuItem.Click += new System.EventHandler(this.speichernToolStripMenuItem_Click);
            // 
            // öffnenToolStripMenuItem
            // 
            resources.ApplyResources(this.öffnenToolStripMenuItem, "öffnenToolStripMenuItem");
            this.öffnenToolStripMenuItem.Name = "öffnenToolStripMenuItem";
            this.öffnenToolStripMenuItem.Click += new System.EventHandler(this.öffnenToolStripMenuItem_Click);
            // 
            // rezeptToolStripMenuItem
            // 
            resources.ApplyResources(this.rezeptToolStripMenuItem, "rezeptToolStripMenuItem");
            this.rezeptToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.erstellenToolStripMenuItem,
            this.löschenToolStripMenuItem,
            this.druckenToolStripMenuItem});
            this.rezeptToolStripMenuItem.Name = "rezeptToolStripMenuItem";
            // 
            // erstellenToolStripMenuItem
            // 
            resources.ApplyResources(this.erstellenToolStripMenuItem, "erstellenToolStripMenuItem");
            this.erstellenToolStripMenuItem.Name = "erstellenToolStripMenuItem";
            this.erstellenToolStripMenuItem.Click += new System.EventHandler(this.erstellenToolStripMenuItem_Click);
            // 
            // löschenToolStripMenuItem
            // 
            resources.ApplyResources(this.löschenToolStripMenuItem, "löschenToolStripMenuItem");
            this.löschenToolStripMenuItem.Name = "löschenToolStripMenuItem";
            this.löschenToolStripMenuItem.Click += new System.EventHandler(this.löschenToolStripMenuItem_Click);
            // 
            // druckenToolStripMenuItem
            // 
            resources.ApplyResources(this.druckenToolStripMenuItem, "druckenToolStripMenuItem");
            this.druckenToolStripMenuItem.Name = "druckenToolStripMenuItem";
            // 
            // sucheToolStripMenuItem
            // 
            resources.ApplyResources(this.sucheToolStripMenuItem, "sucheToolStripMenuItem");
            this.sucheToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filternToolStripMenuItem,
            this.filterAufhebenToolStripMenuItem});
            this.sucheToolStripMenuItem.Name = "sucheToolStripMenuItem";
            // 
            // filternToolStripMenuItem
            // 
            resources.ApplyResources(this.filternToolStripMenuItem, "filternToolStripMenuItem");
            this.filternToolStripMenuItem.Name = "filternToolStripMenuItem";
            // 
            // filterAufhebenToolStripMenuItem
            // 
            resources.ApplyResources(this.filterAufhebenToolStripMenuItem, "filterAufhebenToolStripMenuItem");
            this.filterAufhebenToolStripMenuItem.Name = "filterAufhebenToolStripMenuItem";
            // 
            // MSHauptmenue
            // 
            resources.ApplyResources(this.MSHauptmenue, "MSHauptmenue");
            this.MSHauptmenue.BackColor = System.Drawing.Color.White;
            this.MSHauptmenue.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MSHauptmenue.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.rezeptToolStripMenuItem,
            this.sucheToolStripMenuItem});
            this.MSHauptmenue.Name = "MSHauptmenue";
            // 
            // MasterDetailForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TSHauptmenue);
            this.Controls.Add(this.GBDetails);
            this.Controls.Add(this.LIBORezepte);
            this.Controls.Add(this.MSHauptmenue);
            this.MainMenuStrip = this.MSHauptmenue;
            this.Name = "MasterDetailForm";
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
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
    }
}

