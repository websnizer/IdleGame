namespace IdleGame
{
	partial class FormJeu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormJeu));
            this.top = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.mnu_main = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnu_quitter = new System.Windows.Forms.ToolStripMenuItem();
            this.grp_left = new System.Windows.Forms.GroupBox();
            this.spl_feuillePerso = new System.Windows.Forms.SplitContainer();
            this.lst_persoInfo = new System.Windows.Forms.ListView();
            this.ch_info = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_infostat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl_personnage = new System.Windows.Forms.Label();
            this.spl_statscompetences = new System.Windows.Forms.SplitContainer();
            this.tit_stat = new System.Windows.Forms.Label();
            this.lst_persoStats = new System.Windows.Forms.ListView();
            this.ch_stat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_statval = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lst_persoCompetences = new System.Windows.Forms.ListBox();
            this.lbl_compet = new System.Windows.Forms.Label();
            this.grp_right = new System.Windows.Forms.GroupBox();
            this.spl_histoquetes = new System.Windows.Forms.SplitContainer();
            this.lst_histoire = new System.Windows.Forms.ListBox();
            this.lbl_histoire = new System.Windows.Forms.Label();
            this.lst_quetes = new System.Windows.Forms.ListBox();
            this.lbl_quetes = new System.Windows.Forms.Label();
            this.lst_equipements = new System.Windows.Forms.ListView();
            this.ch_piece = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_piecenom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl_equipements = new System.Windows.Forms.Label();
            this.lst_inventaire = new System.Windows.Forms.ListView();
            this.ch_inventaire = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_inventairenom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl_inventaire = new System.Windows.Forms.Label();
            this.time_statusbar = new System.Windows.Forms.Timer(this.components);
            this.lbl_info = new System.Windows.Forms.Label();
            this.grp_bottom = new System.Windows.Forms.GroupBox();
            this.lbl_vitesse = new System.Windows.Forms.Label();
            this.nud_Tick2 = new System.Windows.Forms.NumericUpDown();
            this.lbl_cashd = new System.Windows.Forms.Label();
            this.lbl_deathsd = new System.Windows.Forms.Label();
            this.lbl_killsd = new System.Windows.Forms.Label();
            this.grp_top = new System.Windows.Forms.GroupBox();
            this.lbl_hp = new System.Windows.Forms.Label();
            this.line_BottomLine = new System.Windows.Forms.PictureBox();
            this.img_statusbar = new System.Windows.Forms.PictureBox();
            this.pct_hp1 = new System.Windows.Forms.PictureBox();
            this.pct_hp2 = new System.Windows.Forms.PictureBox();
            this.pct_hp3 = new System.Windows.Forms.PictureBox();
            this.pct_hp10 = new System.Windows.Forms.PictureBox();
            this.pct_hp9 = new System.Windows.Forms.PictureBox();
            this.pct_hp4 = new System.Windows.Forms.PictureBox();
            this.pct_hp8 = new System.Windows.Forms.PictureBox();
            this.pct_hp7 = new System.Windows.Forms.PictureBox();
            this.pct_hp5 = new System.Windows.Forms.PictureBox();
            this.pct_hp6 = new System.Windows.Forms.PictureBox();
            this.pct_marchand = new System.Windows.Forms.PictureBox();
            this.img_bg = new System.Windows.Forms.PictureBox();
            this.line_RightLine = new System.Windows.Forms.PictureBox();
            this.line_TopLine = new System.Windows.Forms.PictureBox();
            this.line_LeftLine = new System.Windows.Forms.PictureBox();
            this.pct_Reduire = new System.Windows.Forms.PictureBox();
            this.pct_Fermer = new System.Windows.Forms.PictureBox();
            this.pct_Agrandir = new System.Windows.Forms.PictureBox();
            this.pct_icon = new System.Windows.Forms.PictureBox();
            this.top.SuspendLayout();
            this.mnu_main.SuspendLayout();
            this.grp_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spl_feuillePerso)).BeginInit();
            this.spl_feuillePerso.Panel1.SuspendLayout();
            this.spl_feuillePerso.Panel2.SuspendLayout();
            this.spl_feuillePerso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spl_statscompetences)).BeginInit();
            this.spl_statscompetences.Panel1.SuspendLayout();
            this.spl_statscompetences.Panel2.SuspendLayout();
            this.spl_statscompetences.SuspendLayout();
            this.grp_right.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spl_histoquetes)).BeginInit();
            this.spl_histoquetes.Panel1.SuspendLayout();
            this.spl_histoquetes.Panel2.SuspendLayout();
            this.spl_histoquetes.SuspendLayout();
            this.grp_bottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Tick2)).BeginInit();
            this.grp_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.line_BottomLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_statusbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_hp1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_hp2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_hp3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_hp10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_hp9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_hp4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_hp8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_hp7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_hp5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_hp6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_marchand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_bg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line_RightLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line_TopLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line_LeftLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_Reduire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_Fermer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_Agrandir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // top
            // 
            this.top.BackColor = System.Drawing.Color.Firebrick;
            this.top.Controls.Add(this.pct_Reduire);
            this.top.Controls.Add(this.pct_Fermer);
            this.top.Controls.Add(this.pct_Agrandir);
            this.top.Controls.Add(this.pct_icon);
            this.top.Controls.Add(this.lbl_title);
            this.top.Dock = System.Windows.Forms.DockStyle.Top;
            this.top.Location = new System.Drawing.Point(0, 0);
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(1167, 35);
            this.top.TabIndex = 0;
            this.top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.top_MouseDown);
            this.top.MouseMove += new System.Windows.Forms.MouseEventHandler(this.top_MouseMove);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_title.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(36, 7);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(68, 18);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "IdleGame";
            this.lbl_title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.top_MouseDown);
            this.lbl_title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.top_MouseMove);
            // 
            // mnu_main
            // 
            this.mnu_main.BackColor = System.Drawing.Color.Firebrick;
            this.mnu_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_quitter});
            this.mnu_main.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.mnu_main.Name = "contextMenuStrip1";
            this.mnu_main.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mnu_main.ShowImageMargin = false;
            this.mnu_main.Size = new System.Drawing.Size(96, 26);
            this.mnu_main.Text = "Menu";
            // 
            // mnu_quitter
            // 
            this.mnu_quitter.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnu_quitter.ForeColor = System.Drawing.Color.White;
            this.mnu_quitter.Name = "mnu_quitter";
            this.mnu_quitter.Size = new System.Drawing.Size(95, 22);
            this.mnu_quitter.Text = "Quitter";
            this.mnu_quitter.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // grp_left
            // 
            this.grp_left.Controls.Add(this.spl_feuillePerso);
            this.grp_left.Location = new System.Drawing.Point(1, 37);
            this.grp_left.Name = "grp_left";
            this.grp_left.Size = new System.Drawing.Size(211, 674);
            this.grp_left.TabIndex = 5;
            this.grp_left.TabStop = false;
            // 
            // spl_feuillePerso
            // 
            this.spl_feuillePerso.BackColor = System.Drawing.Color.Black;
            this.spl_feuillePerso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spl_feuillePerso.Location = new System.Drawing.Point(3, 16);
            this.spl_feuillePerso.Name = "spl_feuillePerso";
            this.spl_feuillePerso.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spl_feuillePerso.Panel1
            // 
            this.spl_feuillePerso.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.spl_feuillePerso.Panel1.Controls.Add(this.lst_persoInfo);
            this.spl_feuillePerso.Panel1.Controls.Add(this.lbl_personnage);
            this.spl_feuillePerso.Panel1.SizeChanged += new System.EventHandler(this.spl_feuillePerso_Panel1_SizeChanged);
            this.spl_feuillePerso.Panel1MinSize = 275;
            // 
            // spl_feuillePerso.Panel2
            // 
            this.spl_feuillePerso.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.spl_feuillePerso.Panel2.Controls.Add(this.spl_statscompetences);
            this.spl_feuillePerso.Panel2.SizeChanged += new System.EventHandler(this.spl_feuillePerso_Panel2_SizeChanged);
            this.spl_feuillePerso.Panel2MinSize = 350;
            this.spl_feuillePerso.Size = new System.Drawing.Size(205, 655);
            this.spl_feuillePerso.SplitterDistance = 300;
            this.spl_feuillePerso.SplitterWidth = 1;
            this.spl_feuillePerso.TabIndex = 6;
            // 
            // lst_persoInfo
            // 
            this.lst_persoInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lst_persoInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_info,
            this.ch_infostat});
            this.lst_persoInfo.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lst_persoInfo.Location = new System.Drawing.Point(0, 18);
            this.lst_persoInfo.MultiSelect = false;
            this.lst_persoInfo.Name = "lst_persoInfo";
            this.lst_persoInfo.ShowItemToolTips = true;
            this.lst_persoInfo.Size = new System.Drawing.Size(205, 247);
            this.lst_persoInfo.TabIndex = 7;
            this.lst_persoInfo.UseCompatibleStateImageBehavior = false;
            this.lst_persoInfo.View = System.Windows.Forms.View.Details;
            this.lst_persoInfo.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.ColumnWidthChanging);
            // 
            // ch_info
            // 
            this.ch_info.Text = "Info";
            this.ch_info.Width = 72;
            // 
            // ch_infostat
            // 
            this.ch_infostat.Text = "Valeur";
            this.ch_infostat.Width = 125;
            // 
            // lbl_personnage
            // 
            this.lbl_personnage.AutoSize = true;
            this.lbl_personnage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_personnage.Location = new System.Drawing.Point(2, 1);
            this.lbl_personnage.Name = "lbl_personnage";
            this.lbl_personnage.Size = new System.Drawing.Size(84, 15);
            this.lbl_personnage.TabIndex = 8;
            this.lbl_personnage.Text = "Personnage";
            // 
            // spl_statscompetences
            // 
            this.spl_statscompetences.BackColor = System.Drawing.Color.Black;
            this.spl_statscompetences.Location = new System.Drawing.Point(0, 2);
            this.spl_statscompetences.Name = "spl_statscompetences";
            this.spl_statscompetences.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spl_statscompetences.Panel1
            // 
            this.spl_statscompetences.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.spl_statscompetences.Panel1.Controls.Add(this.tit_stat);
            this.spl_statscompetences.Panel1.Controls.Add(this.lst_persoStats);
            this.spl_statscompetences.Panel1.SizeChanged += new System.EventHandler(this.splitContainer1_Panel1_SizeChanged);
            this.spl_statscompetences.Panel1MinSize = 175;
            // 
            // spl_statscompetences.Panel2
            // 
            this.spl_statscompetences.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.spl_statscompetences.Panel2.Controls.Add(this.lst_persoCompetences);
            this.spl_statscompetences.Panel2.Controls.Add(this.lbl_compet);
            this.spl_statscompetences.Panel2.SizeChanged += new System.EventHandler(this.spl_statscompetences_Panel2_SizeChanged);
            this.spl_statscompetences.Panel2MinSize = 125;
            this.spl_statscompetences.Size = new System.Drawing.Size(206, 470);
            this.spl_statscompetences.SplitterDistance = 209;
            this.spl_statscompetences.TabIndex = 7;
            // 
            // tit_stat
            // 
            this.tit_stat.AutoSize = true;
            this.tit_stat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tit_stat.Location = new System.Drawing.Point(0, 6);
            this.tit_stat.Name = "tit_stat";
            this.tit_stat.Size = new System.Drawing.Size(82, 15);
            this.tit_stat.TabIndex = 6;
            this.tit_stat.Text = "Statistiques";
            // 
            // lst_persoStats
            // 
            this.lst_persoStats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lst_persoStats.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_stat,
            this.ch_statval});
            this.lst_persoStats.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lst_persoStats.Location = new System.Drawing.Point(1, 24);
            this.lst_persoStats.MultiSelect = false;
            this.lst_persoStats.Name = "lst_persoStats";
            this.lst_persoStats.ShowItemToolTips = true;
            this.lst_persoStats.Size = new System.Drawing.Size(204, 187);
            this.lst_persoStats.TabIndex = 6;
            this.lst_persoStats.UseCompatibleStateImageBehavior = false;
            this.lst_persoStats.View = System.Windows.Forms.View.Details;
            this.lst_persoStats.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.ColumnWidthChanging);
            // 
            // ch_stat
            // 
            this.ch_stat.Text = "Stat";
            this.ch_stat.Width = 72;
            // 
            // ch_statval
            // 
            this.ch_statval.Text = "Valeur";
            this.ch_statval.Width = 125;
            // 
            // lst_persoCompetences
            // 
            this.lst_persoCompetences.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lst_persoCompetences.FormattingEnabled = true;
            this.lst_persoCompetences.Location = new System.Drawing.Point(-2, 19);
            this.lst_persoCompetences.Name = "lst_persoCompetences";
            this.lst_persoCompetences.Size = new System.Drawing.Size(204, 119);
            this.lst_persoCompetences.TabIndex = 7;
            // 
            // lbl_compet
            // 
            this.lbl_compet.AutoSize = true;
            this.lbl_compet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_compet.Location = new System.Drawing.Point(-1, 1);
            this.lbl_compet.Name = "lbl_compet";
            this.lbl_compet.Size = new System.Drawing.Size(94, 15);
            this.lbl_compet.TabIndex = 7;
            this.lbl_compet.Text = "Competences";
            // 
            // grp_right
            // 
            this.grp_right.Controls.Add(this.spl_histoquetes);
            this.grp_right.Location = new System.Drawing.Point(953, 37);
            this.grp_right.Name = "grp_right";
            this.grp_right.Size = new System.Drawing.Size(211, 674);
            this.grp_right.TabIndex = 7;
            this.grp_right.TabStop = false;
            // 
            // spl_histoquetes
            // 
            this.spl_histoquetes.BackColor = System.Drawing.Color.Black;
            this.spl_histoquetes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spl_histoquetes.Location = new System.Drawing.Point(3, 16);
            this.spl_histoquetes.Name = "spl_histoquetes";
            this.spl_histoquetes.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spl_histoquetes.Panel1
            // 
            this.spl_histoquetes.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.spl_histoquetes.Panel1.Controls.Add(this.lst_histoire);
            this.spl_histoquetes.Panel1.Controls.Add(this.lbl_histoire);
            this.spl_histoquetes.Panel1.SizeChanged += new System.EventHandler(this.splitContainer1_Panel1_SizeChanged_1);
            this.spl_histoquetes.Panel1MinSize = 125;
            // 
            // spl_histoquetes.Panel2
            // 
            this.spl_histoquetes.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.spl_histoquetes.Panel2.Controls.Add(this.lst_quetes);
            this.spl_histoquetes.Panel2.Controls.Add(this.lbl_quetes);
            this.spl_histoquetes.Panel2.SizeChanged += new System.EventHandler(this.spl_histoquetes_Panel2_SizeChanged);
            this.spl_histoquetes.Panel2MinSize = 350;
            this.spl_histoquetes.Size = new System.Drawing.Size(205, 655);
            this.spl_histoquetes.SplitterDistance = 209;
            this.spl_histoquetes.SplitterWidth = 1;
            this.spl_histoquetes.TabIndex = 6;
            // 
            // lst_histoire
            // 
            this.lst_histoire.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lst_histoire.FormattingEnabled = true;
            this.lst_histoire.Location = new System.Drawing.Point(0, 23);
            this.lst_histoire.Name = "lst_histoire";
            this.lst_histoire.Size = new System.Drawing.Size(204, 184);
            this.lst_histoire.TabIndex = 11;
            // 
            // lbl_histoire
            // 
            this.lbl_histoire.AutoSize = true;
            this.lbl_histoire.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_histoire.Location = new System.Drawing.Point(3, 3);
            this.lbl_histoire.Name = "lbl_histoire";
            this.lbl_histoire.Size = new System.Drawing.Size(57, 15);
            this.lbl_histoire.TabIndex = 12;
            this.lbl_histoire.Text = "Histoire";
            // 
            // lst_quetes
            // 
            this.lst_quetes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lst_quetes.FormattingEnabled = true;
            this.lst_quetes.Location = new System.Drawing.Point(1, 26);
            this.lst_quetes.Name = "lst_quetes";
            this.lst_quetes.Size = new System.Drawing.Size(204, 405);
            this.lst_quetes.TabIndex = 8;
            // 
            // lbl_quetes
            // 
            this.lbl_quetes.AutoSize = true;
            this.lbl_quetes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quetes.Location = new System.Drawing.Point(3, 7);
            this.lbl_quetes.Name = "lbl_quetes";
            this.lbl_quetes.Size = new System.Drawing.Size(52, 15);
            this.lbl_quetes.TabIndex = 10;
            this.lbl_quetes.Text = "Quetes";
            // 
            // lst_equipements
            // 
            this.lst_equipements.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lst_equipements.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_piece,
            this.ch_piecenom});
            this.lst_equipements.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lst_equipements.Location = new System.Drawing.Point(1, 99);
            this.lst_equipements.MultiSelect = false;
            this.lst_equipements.Name = "lst_equipements";
            this.lst_equipements.ShowItemToolTips = true;
            this.lst_equipements.Size = new System.Drawing.Size(361, 188);
            this.lst_equipements.TabIndex = 9;
            this.lst_equipements.UseCompatibleStateImageBehavior = false;
            this.lst_equipements.View = System.Windows.Forms.View.Details;
            // 
            // ch_piece
            // 
            this.ch_piece.Text = "Piece";
            this.ch_piece.Width = 85;
            // 
            // ch_piecenom
            // 
            this.ch_piecenom.Text = "Nom";
            this.ch_piecenom.Width = 263;
            // 
            // lbl_equipements
            // 
            this.lbl_equipements.AutoSize = true;
            this.lbl_equipements.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_equipements.Location = new System.Drawing.Point(0, 81);
            this.lbl_equipements.Name = "lbl_equipements";
            this.lbl_equipements.Size = new System.Drawing.Size(91, 15);
            this.lbl_equipements.TabIndex = 10;
            this.lbl_equipements.Text = "Equipements";
            // 
            // lst_inventaire
            // 
            this.lst_inventaire.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lst_inventaire.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_inventaire,
            this.ch_inventairenom});
            this.lst_inventaire.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lst_inventaire.Location = new System.Drawing.Point(373, 99);
            this.lst_inventaire.MultiSelect = false;
            this.lst_inventaire.Name = "lst_inventaire";
            this.lst_inventaire.ShowItemToolTips = true;
            this.lst_inventaire.Size = new System.Drawing.Size(361, 188);
            this.lst_inventaire.TabIndex = 11;
            this.lst_inventaire.UseCompatibleStateImageBehavior = false;
            this.lst_inventaire.View = System.Windows.Forms.View.Details;
            // 
            // ch_inventaire
            // 
            this.ch_inventaire.Text = "Quantité";
            this.ch_inventaire.Width = 55;
            // 
            // ch_inventairenom
            // 
            this.ch_inventairenom.Text = "Nom";
            this.ch_inventairenom.Width = 280;
            // 
            // lbl_inventaire
            // 
            this.lbl_inventaire.AutoSize = true;
            this.lbl_inventaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inventaire.Location = new System.Drawing.Point(664, 84);
            this.lbl_inventaire.Name = "lbl_inventaire";
            this.lbl_inventaire.Size = new System.Drawing.Size(70, 15);
            this.lbl_inventaire.TabIndex = 12;
            this.lbl_inventaire.Text = "Inventaire";
            // 
            // lbl_info
            // 
            this.lbl_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info.Location = new System.Drawing.Point(8, 9);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(728, 23);
            this.lbl_info.TabIndex = 2;
            this.lbl_info.Text = "Action en cours............";
            this.lbl_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grp_bottom
            // 
            this.grp_bottom.Controls.Add(this.lbl_vitesse);
            this.grp_bottom.Controls.Add(this.nud_Tick2);
            this.grp_bottom.Controls.Add(this.lst_inventaire);
            this.grp_bottom.Controls.Add(this.lbl_info);
            this.grp_bottom.Controls.Add(this.lbl_inventaire);
            this.grp_bottom.Controls.Add(this.img_statusbar);
            this.grp_bottom.Controls.Add(this.lst_equipements);
            this.grp_bottom.Controls.Add(this.lbl_equipements);
            this.grp_bottom.Location = new System.Drawing.Point(214, 394);
            this.grp_bottom.Name = "grp_bottom";
            this.grp_bottom.Size = new System.Drawing.Size(735, 317);
            this.grp_bottom.TabIndex = 14;
            this.grp_bottom.TabStop = false;
            // 
            // lbl_vitesse
            // 
            this.lbl_vitesse.AutoSize = true;
            this.lbl_vitesse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vitesse.Location = new System.Drawing.Point(544, 298);
            this.lbl_vitesse.Name = "lbl_vitesse";
            this.lbl_vitesse.Size = new System.Drawing.Size(101, 15);
            this.lbl_vitesse.TabIndex = 15;
            this.lbl_vitesse.Text = "Vitesse de jeu:";
            // 
            // nud_Tick2
            // 
            this.nud_Tick2.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_Tick2.Location = new System.Drawing.Point(647, 296);
            this.nud_Tick2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nud_Tick2.Name = "nud_Tick2";
            this.nud_Tick2.Size = new System.Drawing.Size(87, 20);
            this.nud_Tick2.TabIndex = 14;
            this.nud_Tick2.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nud_Tick2.ValueChanged += new System.EventHandler(this.nud_Tick2_ValueChanged);
            // 
            // lbl_cashd
            // 
            this.lbl_cashd.AutoSize = true;
            this.lbl_cashd.Location = new System.Drawing.Point(6, 301);
            this.lbl_cashd.Name = "lbl_cashd";
            this.lbl_cashd.Size = new System.Drawing.Size(13, 13);
            this.lbl_cashd.TabIndex = 16;
            this.lbl_cashd.Text = "0";
            // 
            // lbl_deathsd
            // 
            this.lbl_deathsd.AutoSize = true;
            this.lbl_deathsd.Location = new System.Drawing.Point(6, 331);
            this.lbl_deathsd.Name = "lbl_deathsd";
            this.lbl_deathsd.Size = new System.Drawing.Size(13, 13);
            this.lbl_deathsd.TabIndex = 20;
            this.lbl_deathsd.Text = "0";
            // 
            // lbl_killsd
            // 
            this.lbl_killsd.AutoSize = true;
            this.lbl_killsd.Location = new System.Drawing.Point(6, 316);
            this.lbl_killsd.Name = "lbl_killsd";
            this.lbl_killsd.Size = new System.Drawing.Size(13, 13);
            this.lbl_killsd.TabIndex = 19;
            this.lbl_killsd.Text = "0";
            // 
            // grp_top
            // 
            this.grp_top.Controls.Add(this.lbl_hp);
            this.grp_top.Controls.Add(this.lbl_deathsd);
            this.grp_top.Controls.Add(this.pct_hp1);
            this.grp_top.Controls.Add(this.lbl_killsd);
            this.grp_top.Controls.Add(this.pct_hp2);
            this.grp_top.Controls.Add(this.pct_hp3);
            this.grp_top.Controls.Add(this.pct_hp10);
            this.grp_top.Controls.Add(this.lbl_cashd);
            this.grp_top.Controls.Add(this.pct_hp9);
            this.grp_top.Controls.Add(this.pct_hp4);
            this.grp_top.Controls.Add(this.pct_hp8);
            this.grp_top.Controls.Add(this.pct_hp7);
            this.grp_top.Controls.Add(this.pct_hp5);
            this.grp_top.Controls.Add(this.pct_hp6);
            this.grp_top.Controls.Add(this.pct_marchand);
            this.grp_top.Controls.Add(this.img_bg);
            this.grp_top.Location = new System.Drawing.Point(215, 37);
            this.grp_top.Name = "grp_top";
            this.grp_top.Size = new System.Drawing.Size(735, 348);
            this.grp_top.TabIndex = 13;
            this.grp_top.TabStop = false;
            // 
            // lbl_hp
            // 
            this.lbl_hp.BackColor = System.Drawing.Color.Transparent;
            this.lbl_hp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hp.Location = new System.Drawing.Point(457, 330);
            this.lbl_hp.Name = "lbl_hp";
            this.lbl_hp.Size = new System.Drawing.Size(259, 15);
            this.lbl_hp.TabIndex = 13;
            this.lbl_hp.Text = ".";
            this.lbl_hp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // line_BottomLine
            // 
            this.line_BottomLine.Location = new System.Drawing.Point(158, 98);
            this.line_BottomLine.Name = "line_BottomLine";
            this.line_BottomLine.Size = new System.Drawing.Size(1, 50);
            this.line_BottomLine.TabIndex = 4;
            this.line_BottomLine.TabStop = false;
            // 
            // img_statusbar
            // 
            this.img_statusbar.Image = global::IdleGame.Properties.Resources.barempty;
            this.img_statusbar.Location = new System.Drawing.Point(-1, 38);
            this.img_statusbar.Name = "img_statusbar";
            this.img_statusbar.Size = new System.Drawing.Size(735, 39);
            this.img_statusbar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_statusbar.TabIndex = 0;
            this.img_statusbar.TabStop = false;
            // 
            // pct_hp1
            // 
            this.pct_hp1.BackColor = System.Drawing.Color.Green;
            this.pct_hp1.Location = new System.Drawing.Point(457, 301);
            this.pct_hp1.Name = "pct_hp1";
            this.pct_hp1.Size = new System.Drawing.Size(25, 26);
            this.pct_hp1.TabIndex = 12;
            this.pct_hp1.TabStop = false;
            this.pct_hp1.Visible = false;
            // 
            // pct_hp2
            // 
            this.pct_hp2.BackColor = System.Drawing.Color.Green;
            this.pct_hp2.Location = new System.Drawing.Point(483, 301);
            this.pct_hp2.Name = "pct_hp2";
            this.pct_hp2.Size = new System.Drawing.Size(25, 26);
            this.pct_hp2.TabIndex = 11;
            this.pct_hp2.TabStop = false;
            this.pct_hp2.Visible = false;
            // 
            // pct_hp3
            // 
            this.pct_hp3.BackColor = System.Drawing.Color.Green;
            this.pct_hp3.Location = new System.Drawing.Point(509, 301);
            this.pct_hp3.Name = "pct_hp3";
            this.pct_hp3.Size = new System.Drawing.Size(25, 26);
            this.pct_hp3.TabIndex = 10;
            this.pct_hp3.TabStop = false;
            this.pct_hp3.Visible = false;
            // 
            // pct_hp10
            // 
            this.pct_hp10.BackColor = System.Drawing.Color.Green;
            this.pct_hp10.Location = new System.Drawing.Point(691, 301);
            this.pct_hp10.Name = "pct_hp10";
            this.pct_hp10.Size = new System.Drawing.Size(25, 26);
            this.pct_hp10.TabIndex = 3;
            this.pct_hp10.TabStop = false;
            this.pct_hp10.Visible = false;
            // 
            // pct_hp9
            // 
            this.pct_hp9.BackColor = System.Drawing.Color.Green;
            this.pct_hp9.Location = new System.Drawing.Point(665, 301);
            this.pct_hp9.Name = "pct_hp9";
            this.pct_hp9.Size = new System.Drawing.Size(25, 26);
            this.pct_hp9.TabIndex = 4;
            this.pct_hp9.TabStop = false;
            this.pct_hp9.Visible = false;
            // 
            // pct_hp4
            // 
            this.pct_hp4.BackColor = System.Drawing.Color.Green;
            this.pct_hp4.Location = new System.Drawing.Point(535, 301);
            this.pct_hp4.Name = "pct_hp4";
            this.pct_hp4.Size = new System.Drawing.Size(25, 26);
            this.pct_hp4.TabIndex = 9;
            this.pct_hp4.TabStop = false;
            this.pct_hp4.Visible = false;
            // 
            // pct_hp8
            // 
            this.pct_hp8.BackColor = System.Drawing.Color.Green;
            this.pct_hp8.Location = new System.Drawing.Point(639, 301);
            this.pct_hp8.Name = "pct_hp8";
            this.pct_hp8.Size = new System.Drawing.Size(25, 26);
            this.pct_hp8.TabIndex = 5;
            this.pct_hp8.TabStop = false;
            this.pct_hp8.Visible = false;
            // 
            // pct_hp7
            // 
            this.pct_hp7.BackColor = System.Drawing.Color.Green;
            this.pct_hp7.Location = new System.Drawing.Point(613, 301);
            this.pct_hp7.Name = "pct_hp7";
            this.pct_hp7.Size = new System.Drawing.Size(25, 26);
            this.pct_hp7.TabIndex = 6;
            this.pct_hp7.TabStop = false;
            this.pct_hp7.Visible = false;
            // 
            // pct_hp5
            // 
            this.pct_hp5.BackColor = System.Drawing.Color.Green;
            this.pct_hp5.Location = new System.Drawing.Point(561, 301);
            this.pct_hp5.Name = "pct_hp5";
            this.pct_hp5.Size = new System.Drawing.Size(25, 26);
            this.pct_hp5.TabIndex = 8;
            this.pct_hp5.TabStop = false;
            this.pct_hp5.Visible = false;
            // 
            // pct_hp6
            // 
            this.pct_hp6.BackColor = System.Drawing.Color.Green;
            this.pct_hp6.Location = new System.Drawing.Point(587, 301);
            this.pct_hp6.Name = "pct_hp6";
            this.pct_hp6.Size = new System.Drawing.Size(25, 26);
            this.pct_hp6.TabIndex = 7;
            this.pct_hp6.TabStop = false;
            this.pct_hp6.Visible = false;
            // 
            // pct_marchand
            // 
            this.pct_marchand.Image = global::IdleGame.Properties.Resources.marchand;
            this.pct_marchand.Location = new System.Drawing.Point(434, 66);
            this.pct_marchand.Name = "pct_marchand";
            this.pct_marchand.Size = new System.Drawing.Size(298, 285);
            this.pct_marchand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pct_marchand.TabIndex = 2;
            this.pct_marchand.TabStop = false;
            this.pct_marchand.Visible = false;
            // 
            // img_bg
            // 
            this.img_bg.Image = global::IdleGame.Properties.Resources.MAP;
            this.img_bg.Location = new System.Drawing.Point(2, 5);
            this.img_bg.Name = "img_bg";
            this.img_bg.Size = new System.Drawing.Size(733, 348);
            this.img_bg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_bg.TabIndex = 1;
            this.img_bg.TabStop = false;
            // 
            // line_RightLine
            // 
            this.line_RightLine.Location = new System.Drawing.Point(150, 90);
            this.line_RightLine.Name = "line_RightLine";
            this.line_RightLine.Size = new System.Drawing.Size(1, 50);
            this.line_RightLine.TabIndex = 3;
            this.line_RightLine.TabStop = false;
            // 
            // line_TopLine
            // 
            this.line_TopLine.Location = new System.Drawing.Point(189, 117);
            this.line_TopLine.Name = "line_TopLine";
            this.line_TopLine.Size = new System.Drawing.Size(1, 50);
            this.line_TopLine.TabIndex = 2;
            this.line_TopLine.TabStop = false;
            // 
            // line_LeftLine
            // 
            this.line_LeftLine.Location = new System.Drawing.Point(2, 76);
            this.line_LeftLine.Name = "line_LeftLine";
            this.line_LeftLine.Size = new System.Drawing.Size(1, 100);
            this.line_LeftLine.TabIndex = 1;
            this.line_LeftLine.TabStop = false;
            // 
            // pct_Reduire
            // 
            this.pct_Reduire.Image = ((System.Drawing.Image)(resources.GetObject("pct_Reduire.Image")));
            this.pct_Reduire.Location = new System.Drawing.Point(196, 0);
            this.pct_Reduire.Name = "pct_Reduire";
            this.pct_Reduire.Size = new System.Drawing.Size(30, 36);
            this.pct_Reduire.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pct_Reduire.TabIndex = 1;
            this.pct_Reduire.TabStop = false;
            this.pct_Reduire.Click += new System.EventHandler(this.pct_Reduire_Click);
            this.pct_Reduire.MouseLeave += new System.EventHandler(this.pct_Reduire_MouseLeave);
            this.pct_Reduire.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pct_Reduire_MouseMove);
            // 
            // pct_Fermer
            // 
            this.pct_Fermer.Image = ((System.Drawing.Image)(resources.GetObject("pct_Fermer.Image")));
            this.pct_Fermer.Location = new System.Drawing.Point(268, -1);
            this.pct_Fermer.Name = "pct_Fermer";
            this.pct_Fermer.Size = new System.Drawing.Size(30, 36);
            this.pct_Fermer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pct_Fermer.TabIndex = 1;
            this.pct_Fermer.TabStop = false;
            this.pct_Fermer.Click += new System.EventHandler(this.pct_Fermer_Click);
            this.pct_Fermer.MouseLeave += new System.EventHandler(this.pct_Fermer_MouseLeave);
            this.pct_Fermer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pct_Fermer_MouseMove);
            // 
            // pct_Agrandir
            // 
            this.pct_Agrandir.Image = ((System.Drawing.Image)(resources.GetObject("pct_Agrandir.Image")));
            this.pct_Agrandir.Location = new System.Drawing.Point(232, -1);
            this.pct_Agrandir.Name = "pct_Agrandir";
            this.pct_Agrandir.Size = new System.Drawing.Size(30, 36);
            this.pct_Agrandir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pct_Agrandir.TabIndex = 1;
            this.pct_Agrandir.TabStop = false;
            this.pct_Agrandir.Visible = false;
            this.pct_Agrandir.Click += new System.EventHandler(this.pct_Agrandir_Click);
            this.pct_Agrandir.MouseLeave += new System.EventHandler(this.pct_Agrandir_MouseLeave);
            this.pct_Agrandir.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pct_Agrandir_MouseMove);
            // 
            // pct_icon
            // 
            this.pct_icon.ErrorImage = null;
            this.pct_icon.Image = ((System.Drawing.Image)(resources.GetObject("pct_icon.Image")));
            this.pct_icon.Location = new System.Drawing.Point(3, 7);
            this.pct_icon.Name = "pct_icon";
            this.pct_icon.Size = new System.Drawing.Size(20, 20);
            this.pct_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pct_icon.TabIndex = 1;
            this.pct_icon.TabStop = false;
            this.pct_icon.Click += new System.EventHandler(this.pct_icon_Click);
            this.pct_icon.MouseLeave += new System.EventHandler(this.pct_icon_MouseLeave);
            this.pct_icon.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pct_icon_MouseMove);
            // 
            // FormJeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 715);
            this.Controls.Add(this.line_BottomLine);
            this.Controls.Add(this.grp_bottom);
            this.Controls.Add(this.grp_top);
            this.Controls.Add(this.grp_right);
            this.Controls.Add(this.grp_left);
            this.Controls.Add(this.line_RightLine);
            this.Controls.Add(this.line_TopLine);
            this.Controls.Add(this.line_LeftLine);
            this.Controls.Add(this.top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormJeu";
            this.Text = "IdleGame";
            this.Load += new System.EventHandler(this.CharForm_Load);
            this.SizeChanged += new System.EventHandler(this.FormJeu_SizeChanged);
            this.Resize += new System.EventHandler(this.CharForm_Resize);
            this.top.ResumeLayout(false);
            this.top.PerformLayout();
            this.mnu_main.ResumeLayout(false);
            this.grp_left.ResumeLayout(false);
            this.spl_feuillePerso.Panel1.ResumeLayout(false);
            this.spl_feuillePerso.Panel1.PerformLayout();
            this.spl_feuillePerso.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spl_feuillePerso)).EndInit();
            this.spl_feuillePerso.ResumeLayout(false);
            this.spl_statscompetences.Panel1.ResumeLayout(false);
            this.spl_statscompetences.Panel1.PerformLayout();
            this.spl_statscompetences.Panel2.ResumeLayout(false);
            this.spl_statscompetences.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spl_statscompetences)).EndInit();
            this.spl_statscompetences.ResumeLayout(false);
            this.grp_right.ResumeLayout(false);
            this.spl_histoquetes.Panel1.ResumeLayout(false);
            this.spl_histoquetes.Panel1.PerformLayout();
            this.spl_histoquetes.Panel2.ResumeLayout(false);
            this.spl_histoquetes.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spl_histoquetes)).EndInit();
            this.spl_histoquetes.ResumeLayout(false);
            this.grp_bottom.ResumeLayout(false);
            this.grp_bottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Tick2)).EndInit();
            this.grp_top.ResumeLayout(false);
            this.grp_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.line_BottomLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_statusbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_hp1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_hp2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_hp3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_hp10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_hp9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_hp4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_hp8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_hp7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_hp5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_hp6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_marchand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_bg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line_RightLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line_TopLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line_LeftLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_Reduire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_Fermer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_Agrandir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_icon)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel top;
		private System.Windows.Forms.PictureBox pct_icon;
		private System.Windows.Forms.Label lbl_title;
		private System.Windows.Forms.PictureBox pct_Agrandir;
		private System.Windows.Forms.PictureBox pct_Fermer;
		private System.Windows.Forms.PictureBox pct_Reduire;
		private System.Windows.Forms.ContextMenuStrip mnu_main;
		private System.Windows.Forms.ToolStripMenuItem mnu_quitter;
		private System.Windows.Forms.PictureBox line_LeftLine;
		private System.Windows.Forms.PictureBox line_TopLine;
		private System.Windows.Forms.PictureBox line_RightLine;
		private System.Windows.Forms.PictureBox line_BottomLine;
		private System.Windows.Forms.GroupBox grp_left;
		private System.Windows.Forms.SplitContainer spl_feuillePerso;
		private System.Windows.Forms.Label tit_stat;
		private System.Windows.Forms.ListView lst_persoStats;
		private System.Windows.Forms.ColumnHeader ch_stat;
		private System.Windows.Forms.ColumnHeader ch_statval;
		private System.Windows.Forms.ListView lst_persoInfo;
		private System.Windows.Forms.ColumnHeader ch_info;
		private System.Windows.Forms.ColumnHeader ch_infostat;
		private System.Windows.Forms.Label lbl_personnage;
		private System.Windows.Forms.ListBox lst_persoCompetences;
		private System.Windows.Forms.SplitContainer spl_statscompetences;
		private System.Windows.Forms.Label lbl_compet;
		private System.Windows.Forms.GroupBox grp_right;
		private System.Windows.Forms.SplitContainer spl_histoquetes;
		private System.Windows.Forms.ListView lst_equipements;
		private System.Windows.Forms.ColumnHeader ch_piece;
		private System.Windows.Forms.ColumnHeader ch_piecenom;
		private System.Windows.Forms.Label lbl_equipements;
		private System.Windows.Forms.ListView lst_inventaire;
		private System.Windows.Forms.ColumnHeader ch_inventaire;
		private System.Windows.Forms.ColumnHeader ch_inventairenom;
		private System.Windows.Forms.Label lbl_inventaire;
		private System.Windows.Forms.ListBox lst_histoire;
		private System.Windows.Forms.Label lbl_histoire;
		private System.Windows.Forms.ListBox lst_quetes;
		private System.Windows.Forms.Label lbl_quetes;
		private System.Windows.Forms.PictureBox img_statusbar;
		private System.Windows.Forms.Timer time_statusbar;
		private System.Windows.Forms.Label lbl_info;
		private System.Windows.Forms.GroupBox grp_bottom;
        private System.Windows.Forms.NumericUpDown nud_Tick2;
        private System.Windows.Forms.Label lbl_vitesse;
        private System.Windows.Forms.Label lbl_cashd;
        private System.Windows.Forms.Label lbl_deathsd;
        private System.Windows.Forms.Label lbl_killsd;
        private System.Windows.Forms.PictureBox img_bg;
        private System.Windows.Forms.PictureBox pct_marchand;
        private System.Windows.Forms.PictureBox pct_hp10;
        private System.Windows.Forms.PictureBox pct_hp6;
        private System.Windows.Forms.PictureBox pct_hp5;
        private System.Windows.Forms.PictureBox pct_hp4;
        private System.Windows.Forms.PictureBox pct_hp3;
        private System.Windows.Forms.PictureBox pct_hp2;
        private System.Windows.Forms.PictureBox pct_hp1;
        private System.Windows.Forms.GroupBox grp_top;
        private System.Windows.Forms.PictureBox pct_hp9;
        private System.Windows.Forms.PictureBox pct_hp8;
        private System.Windows.Forms.PictureBox pct_hp7;
        private System.Windows.Forms.Label lbl_hp;
    }
}

