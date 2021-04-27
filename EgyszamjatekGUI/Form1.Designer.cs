namespace EgyszamjatekGUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Fopanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.EgyszamJatek = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TippekSzama = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.JatekosHozzaadasa = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.JatekosTipp = new System.Windows.Forms.TextBox();
            this.JatekosT = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.JatekosNeve = new System.Windows.Forms.TextBox();
            this.JatekosN = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.BezarasGomb = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.OldalsoPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.menu = new Bunifu.Framework.UI.BunifuImageButton();
            this.FajlBeolvasas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Keszitő = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuFormFadeTransition1 = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            this.PanelAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.LabelAnimacio_Timer = new System.Windows.Forms.Timer(this.components);
            this.KeszitoTimer = new System.Windows.Forms.Timer(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Fopanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BezarasGomb)).BeginInit();
            this.panel1.SuspendLayout();
            this.OldalsoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Fopanel
            // 
            this.Fopanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Fopanel.BackgroundImage")));
            this.Fopanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Fopanel.Controls.Add(this.EgyszamJatek);
            this.Fopanel.Controls.Add(this.dataGridView1);
            this.Fopanel.Controls.Add(this.TippekSzama);
            this.Fopanel.Controls.Add(this.JatekosHozzaadasa);
            this.Fopanel.Controls.Add(this.tableLayoutPanel1);
            this.Fopanel.Controls.Add(this.BezarasGomb);
            this.Fopanel.Controls.Add(this.panel1);
            this.PanelAnimator.SetDecoration(this.Fopanel, BunifuAnimatorNS.DecorationType.None);
            this.Fopanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Fopanel.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(177)))), ((int)(((byte)(231)))));
            this.Fopanel.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(31)))), ((int)(((byte)(141)))));
            this.Fopanel.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(65)))), ((int)(((byte)(154)))));
            this.Fopanel.GradientTopRight = System.Drawing.Color.Black;
            this.Fopanel.Location = new System.Drawing.Point(0, 0);
            this.Fopanel.Name = "Fopanel";
            this.Fopanel.Quality = 10;
            this.Fopanel.Size = new System.Drawing.Size(911, 362);
            this.Fopanel.TabIndex = 0;
            // 
            // EgyszamJatek
            // 
            this.EgyszamJatek.AutoSize = true;
            this.EgyszamJatek.BackColor = System.Drawing.Color.Transparent;
            this.PanelAnimator.SetDecoration(this.EgyszamJatek, BunifuAnimatorNS.DecorationType.None);
            this.EgyszamJatek.Font = new System.Drawing.Font("Century Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EgyszamJatek.Location = new System.Drawing.Point(460, 9);
            this.EgyszamJatek.Name = "EgyszamJatek";
            this.EgyszamJatek.Size = new System.Drawing.Size(174, 30);
            this.EgyszamJatek.TabIndex = 14;
            this.EgyszamJatek.Text = "Egyszámjáték";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.PanelAnimator.SetDecoration(this.dataGridView1, BunifuAnimatorNS.DecorationType.None);
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(231, 203);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(680, 159);
            this.dataGridView1.TabIndex = 13;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Név";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tipp1";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tipp2";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tipp3";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Tipp4";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // TippekSzama
            // 
            this.TippekSzama.AutoSize = true;
            this.TippekSzama.BackColor = System.Drawing.Color.Transparent;
            this.PanelAnimator.SetDecoration(this.TippekSzama, BunifuAnimatorNS.DecorationType.None);
            this.TippekSzama.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TippekSzama.ForeColor = System.Drawing.Color.Black;
            this.TippekSzama.Location = new System.Drawing.Point(800, 106);
            this.TippekSzama.Name = "TippekSzama";
            this.TippekSzama.Size = new System.Drawing.Size(43, 21);
            this.TippekSzama.TabIndex = 12;
            this.TippekSzama.Text = "Tipp";
            this.TippekSzama.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // JatekosHozzaadasa
            // 
            this.JatekosHozzaadasa.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.JatekosHozzaadasa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.JatekosHozzaadasa.BackColor = System.Drawing.Color.Transparent;
            this.JatekosHozzaadasa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.JatekosHozzaadasa.BorderRadius = 0;
            this.JatekosHozzaadasa.ButtonText = "Játékos hozzáadása";
            this.JatekosHozzaadasa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.JatekosHozzaadasa, BunifuAnimatorNS.DecorationType.None);
            this.JatekosHozzaadasa.DisabledColor = System.Drawing.Color.Gray;
            this.JatekosHozzaadasa.Iconcolor = System.Drawing.Color.Transparent;
            this.JatekosHozzaadasa.Iconimage = ((System.Drawing.Image)(resources.GetObject("JatekosHozzaadasa.Iconimage")));
            this.JatekosHozzaadasa.Iconimage_right = null;
            this.JatekosHozzaadasa.Iconimage_right_Selected = ((System.Drawing.Image)(resources.GetObject("JatekosHozzaadasa.Iconimage_right_Selected")));
            this.JatekosHozzaadasa.Iconimage_Selected = null;
            this.JatekosHozzaadasa.IconMarginLeft = 0;
            this.JatekosHozzaadasa.IconMarginRight = 0;
            this.JatekosHozzaadasa.IconRightVisible = true;
            this.JatekosHozzaadasa.IconRightZoom = 0D;
            this.JatekosHozzaadasa.IconVisible = true;
            this.JatekosHozzaadasa.IconZoom = 100D;
            this.JatekosHozzaadasa.IsTab = false;
            this.JatekosHozzaadasa.Location = new System.Drawing.Point(406, 151);
            this.JatekosHozzaadasa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.JatekosHozzaadasa.Name = "JatekosHozzaadasa";
            this.JatekosHozzaadasa.Normalcolor = System.Drawing.Color.Transparent;
            this.JatekosHozzaadasa.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.JatekosHozzaadasa.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.JatekosHozzaadasa.selected = false;
            this.JatekosHozzaadasa.Size = new System.Drawing.Size(388, 51);
            this.JatekosHozzaadasa.TabIndex = 11;
            this.JatekosHozzaadasa.Text = "Játékos hozzáadása";
            this.JatekosHozzaadasa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.JatekosHozzaadasa.Textcolor = System.Drawing.Color.Black;
            this.JatekosHozzaadasa.TextFont = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JatekosHozzaadasa.Click += new System.EventHandler(this.JatekosHozzaadasa_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.JatekosTipp, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.JatekosT, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.JatekosNeve, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.JatekosN, 0, 0);
            this.PanelAnimator.SetDecoration(this.tableLayoutPanel1, BunifuAnimatorNS.DecorationType.None);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(356, 58);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.11243F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.88757F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(438, 74);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // JatekosTipp
            // 
            this.PanelAnimator.SetDecoration(this.JatekosTipp, BunifuAnimatorNS.DecorationType.None);
            this.JatekosTipp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.JatekosTipp.Location = new System.Drawing.Point(222, 39);
            this.JatekosTipp.Name = "JatekosTipp";
            this.JatekosTipp.Size = new System.Drawing.Size(195, 30);
            this.JatekosTipp.TabIndex = 3;
            this.JatekosTipp.Click += new System.EventHandler(this.JatekosTippjeiClick);
            this.JatekosTipp.TextChanged += new System.EventHandler(this.JatekosTippTextChange);
            // 
            // JatekosT
            // 
            this.JatekosT.AutoSize = true;
            this.PanelAnimator.SetDecoration(this.JatekosT, BunifuAnimatorNS.DecorationType.None);
            this.JatekosT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.JatekosT.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.JatekosT.ForeColor = System.Drawing.Color.Black;
            this.JatekosT.Location = new System.Drawing.Point(3, 36);
            this.JatekosT.Name = "JatekosT";
            this.JatekosT.Size = new System.Drawing.Size(213, 38);
            this.JatekosT.TabIndex = 5;
            this.JatekosT.Text = "Játékos Tippjei";
            this.JatekosT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // JatekosNeve
            // 
            this.PanelAnimator.SetDecoration(this.JatekosNeve, BunifuAnimatorNS.DecorationType.None);
            this.JatekosNeve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.JatekosNeve.Location = new System.Drawing.Point(222, 3);
            this.JatekosNeve.Name = "JatekosNeve";
            this.JatekosNeve.Size = new System.Drawing.Size(195, 30);
            this.JatekosNeve.TabIndex = 2;
            this.JatekosNeve.Click += new System.EventHandler(this.InformacioClick);
            this.JatekosNeve.TextChanged += new System.EventHandler(this.JatekosNeve_TextChanged);
            // 
            // JatekosN
            // 
            this.JatekosN.AutoSize = true;
            this.PanelAnimator.SetDecoration(this.JatekosN, BunifuAnimatorNS.DecorationType.None);
            this.JatekosN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.JatekosN.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.JatekosN.ForeColor = System.Drawing.Color.Black;
            this.JatekosN.Location = new System.Drawing.Point(3, 0);
            this.JatekosN.Name = "JatekosN";
            this.JatekosN.Size = new System.Drawing.Size(213, 36);
            this.JatekosN.TabIndex = 4;
            this.JatekosN.Text = "Játékos Neve";
            this.JatekosN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BezarasGomb
            // 
            this.BezarasGomb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BezarasGomb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PanelAnimator.SetDecoration(this.BezarasGomb, BunifuAnimatorNS.DecorationType.None);
            this.BezarasGomb.Image = ((System.Drawing.Image)(resources.GetObject("BezarasGomb.Image")));
            this.BezarasGomb.ImageActive = null;
            this.BezarasGomb.Location = new System.Drawing.Point(878, 3);
            this.BezarasGomb.Name = "BezarasGomb";
            this.BezarasGomb.Size = new System.Drawing.Size(30, 30);
            this.BezarasGomb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BezarasGomb.TabIndex = 5;
            this.BezarasGomb.TabStop = false;
            this.BezarasGomb.Zoom = 20;
            this.BezarasGomb.Click += new System.EventHandler(this.BezarasGomb_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.OldalsoPanel);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Keszitő);
            this.PanelAnimator.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 362);
            this.panel1.TabIndex = 0;
            // 
            // OldalsoPanel
            // 
            this.OldalsoPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OldalsoPanel.BackgroundImage")));
            this.OldalsoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OldalsoPanel.Controls.Add(this.menu);
            this.OldalsoPanel.Controls.Add(this.FajlBeolvasas);
            this.PanelAnimator.SetDecoration(this.OldalsoPanel, BunifuAnimatorNS.DecorationType.None);
            this.OldalsoPanel.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(177)))), ((int)(((byte)(231)))));
            this.OldalsoPanel.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(31)))), ((int)(((byte)(141)))));
            this.OldalsoPanel.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(65)))), ((int)(((byte)(154)))));
            this.OldalsoPanel.GradientTopRight = System.Drawing.Color.Black;
            this.OldalsoPanel.Location = new System.Drawing.Point(0, 0);
            this.OldalsoPanel.Name = "OldalsoPanel";
            this.OldalsoPanel.Quality = 10;
            this.OldalsoPanel.Size = new System.Drawing.Size(231, 362);
            this.OldalsoPanel.TabIndex = 0;
            // 
            // menu
            // 
            this.menu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelAnimator.SetDecoration(this.menu, BunifuAnimatorNS.DecorationType.None);
            this.menu.Image = ((System.Drawing.Image)(resources.GetObject("menu.Image")));
            this.menu.ImageActive = null;
            this.menu.Location = new System.Drawing.Point(201, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(30, 30);
            this.menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menu.TabIndex = 9;
            this.menu.TabStop = false;
            this.menu.Zoom = 20;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // FajlBeolvasas
            // 
            this.FajlBeolvasas.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.FajlBeolvasas.BackColor = System.Drawing.Color.Transparent;
            this.FajlBeolvasas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FajlBeolvasas.BorderRadius = 0;
            this.FajlBeolvasas.ButtonText = "Fájl Beolvasása";
            this.FajlBeolvasas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.FajlBeolvasas, BunifuAnimatorNS.DecorationType.None);
            this.FajlBeolvasas.DisabledColor = System.Drawing.Color.Gray;
            this.FajlBeolvasas.Iconcolor = System.Drawing.Color.Transparent;
            this.FajlBeolvasas.Iconimage = ((System.Drawing.Image)(resources.GetObject("FajlBeolvasas.Iconimage")));
            this.FajlBeolvasas.Iconimage_right = null;
            this.FajlBeolvasas.Iconimage_right_Selected = null;
            this.FajlBeolvasas.Iconimage_Selected = null;
            this.FajlBeolvasas.IconMarginLeft = 0;
            this.FajlBeolvasas.IconMarginRight = 0;
            this.FajlBeolvasas.IconRightVisible = true;
            this.FajlBeolvasas.IconRightZoom = 0D;
            this.FajlBeolvasas.IconVisible = true;
            this.FajlBeolvasas.IconZoom = 90D;
            this.FajlBeolvasas.IsTab = true;
            this.FajlBeolvasas.Location = new System.Drawing.Point(0, 48);
            this.FajlBeolvasas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FajlBeolvasas.Name = "FajlBeolvasas";
            this.FajlBeolvasas.Normalcolor = System.Drawing.Color.Transparent;
            this.FajlBeolvasas.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.FajlBeolvasas.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FajlBeolvasas.selected = false;
            this.FajlBeolvasas.Size = new System.Drawing.Size(231, 61);
            this.FajlBeolvasas.TabIndex = 0;
            this.FajlBeolvasas.Text = "Fájl Beolvasása";
            this.FajlBeolvasas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FajlBeolvasas.Textcolor = System.Drawing.Color.Black;
            this.FajlBeolvasas.TextFont = new System.Drawing.Font("Century Gothic", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FajlBeolvasas.Click += new System.EventHandler(this.FajlBeolvasas_Click);
            // 
            // pictureBox1
            // 
            this.PanelAnimator.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 329);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Keszitő
            // 
            this.Keszitő.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Keszitő.AutoSize = true;
            this.Keszitő.BackColor = System.Drawing.Color.Transparent;
            this.PanelAnimator.SetDecoration(this.Keszitő, BunifuAnimatorNS.DecorationType.None);
            this.Keszitő.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Keszitő.Location = new System.Drawing.Point(34, 332);
            this.Keszitő.Name = "Keszitő";
            this.Keszitő.Size = new System.Drawing.Size(151, 21);
            this.Keszitő.TabIndex = 10;
            this.Keszitő.Text = "By: Ádám Roland";
            this.Keszitő.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.Fopanel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuFormFadeTransition1
            // 
            this.bunifuFormFadeTransition1.Delay = 1;
            // 
            // PanelAnimator
            // 
            this.PanelAnimator.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic;
            this.PanelAnimator.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 20;
            animation1.Padding = new System.Windows.Forms.Padding(30);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.PanelAnimator.DefaultAnimation = animation1;
            // 
            // toolTip1
            // 
            this.toolTip1.Draw += new System.Windows.Forms.DrawToolTipEventHandler(this.toolTip1_Draw);
            // 
            // LabelAnimacio_Timer
            // 
            this.LabelAnimacio_Timer.Enabled = true;
            this.LabelAnimacio_Timer.Interval = 50;
            this.LabelAnimacio_Timer.Tick += new System.EventHandler(this.LabelAnimacio_Timer_Tick);
            // 
            // KeszitoTimer
            // 
            this.KeszitoTimer.Tick += new System.EventHandler(this.KeszitoTimer_Tick);
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.EgyszamJatek;
            this.bunifuDragControl2.Vertical = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 362);
            this.Controls.Add(this.Fopanel);
            this.PanelAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Fopanel.ResumeLayout(false);
            this.Fopanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BezarasGomb)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.OldalsoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel Fopanel;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton FajlBeolvasas;
        public Bunifu.Framework.UI.BunifuFlatButton JatekosHozzaadasa;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox JatekosTipp;
        private Bunifu.Framework.UI.BunifuCustomLabel JatekosT;
        private System.Windows.Forms.TextBox JatekosNeve;
        private Bunifu.Framework.UI.BunifuCustomLabel JatekosN;
        private Bunifu.Framework.UI.BunifuImageButton BezarasGomb;
        private Bunifu.Framework.UI.BunifuImageButton menu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private Bunifu.Framework.UI.BunifuCustomLabel TippekSzama;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuFormFadeTransition bunifuFormFadeTransition1;
        private System.Windows.Forms.ToolTip toolTip1;
        public Bunifu.Framework.UI.BunifuGradientPanel OldalsoPanel;
        public BunifuAnimatorNS.BunifuTransition PanelAnimator;
        public System.Windows.Forms.Label Keszitő;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer LabelAnimacio_Timer;
        private System.Windows.Forms.Label EgyszamJatek;
        private System.Windows.Forms.Timer KeszitoTimer;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
    }
}

