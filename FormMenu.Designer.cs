namespace IdleGame
{
	partial class FormMenu
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
			this.top = new System.Windows.Forms.Panel();
			this.lbl_title = new System.Windows.Forms.Label();
			this.mnu_main = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.mnu_about = new System.Windows.Forms.ToolStripMenuItem();
			this.mnu_close = new System.Windows.Forms.ToolStripMenuItem();
			this.btn_exit = new System.Windows.Forms.PictureBox();
			this.btn_loadgame = new System.Windows.Forms.PictureBox();
			this.btn_newgame = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.BottomLine = new System.Windows.Forms.PictureBox();
			this.RightLine = new System.Windows.Forms.PictureBox();
			this.TopLine = new System.Windows.Forms.PictureBox();
			this.LeftLine = new System.Windows.Forms.PictureBox();
			this.pct_Reduire = new System.Windows.Forms.PictureBox();
			this.pct_Fermer = new System.Windows.Forms.PictureBox();
			this.pct_Agrandir = new System.Windows.Forms.PictureBox();
			this.pct_icon = new System.Windows.Forms.PictureBox();
			this.lbl_info = new System.Windows.Forms.Label();
			this.top.SuspendLayout();
			this.mnu_main.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btn_exit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btn_loadgame)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btn_newgame)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BottomLine)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.RightLine)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TopLine)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.LeftLine)).BeginInit();
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
			this.top.Size = new System.Drawing.Size(903, 35);
			this.top.TabIndex = 0;
			this.top.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.top_MouseDoubleClick);
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
            this.mnu_about,
            this.mnu_close});
			this.mnu_main.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
			this.mnu_main.Name = "contextMenuStrip1";
			this.mnu_main.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.mnu_main.ShowImageMargin = false;
			this.mnu_main.Size = new System.Drawing.Size(89, 48);
			this.mnu_main.Text = "Menu";
			// 
			// mnu_about
			// 
			this.mnu_about.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mnu_about.ForeColor = System.Drawing.Color.White;
			this.mnu_about.Name = "mnu_about";
			this.mnu_about.Size = new System.Drawing.Size(88, 22);
			this.mnu_about.Text = "About";
			this.mnu_about.MouseEnter += new System.EventHandler(this.saveToolStripMenuItem_MouseEnter);
			this.mnu_about.MouseLeave += new System.EventHandler(this.saveToolStripMenuItem_MouseLeave);
			// 
			// mnu_close
			// 
			this.mnu_close.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mnu_close.ForeColor = System.Drawing.Color.White;
			this.mnu_close.Name = "mnu_close";
			this.mnu_close.Size = new System.Drawing.Size(88, 22);
			this.mnu_close.Text = "Close";
			this.mnu_close.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
			this.mnu_close.MouseEnter += new System.EventHandler(this.saveToolStripMenuItem_MouseEnter);
			this.mnu_close.MouseLeave += new System.EventHandler(this.saveToolStripMenuItem_MouseLeave);
			// 
			// btn_exit
			// 
			this.btn_exit.Image = global::IdleGame.Properties.Resources.bouton_exit;
			this.btn_exit.Location = new System.Drawing.Point(17, 225);
			this.btn_exit.Name = "btn_exit";
			this.btn_exit.Size = new System.Drawing.Size(202, 52);
			this.btn_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.btn_exit.TabIndex = 7;
			this.btn_exit.TabStop = false;
			this.btn_exit.MouseLeave += new System.EventHandler(this.btn_exit_MouseLeave);
			this.btn_exit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_exit_MouseMove);
			// 
			// btn_loadgame
			// 
			this.btn_loadgame.Image = global::IdleGame.Properties.Resources.bouton_load_game;
			this.btn_loadgame.Location = new System.Drawing.Point(17, 167);
			this.btn_loadgame.Name = "btn_loadgame";
			this.btn_loadgame.Size = new System.Drawing.Size(202, 52);
			this.btn_loadgame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.btn_loadgame.TabIndex = 6;
			this.btn_loadgame.TabStop = false;
			this.btn_loadgame.MouseLeave += new System.EventHandler(this.btn_loadgame_MouseLeave);
			this.btn_loadgame.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_loadgame_MouseMove);
			// 
			// btn_newgame
			// 
			this.btn_newgame.Image = global::IdleGame.Properties.Resources.bouton_new_game;
			this.btn_newgame.Location = new System.Drawing.Point(17, 109);
			this.btn_newgame.Name = "btn_newgame";
			this.btn_newgame.Size = new System.Drawing.Size(202, 52);
			this.btn_newgame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.btn_newgame.TabIndex = 5;
			this.btn_newgame.TabStop = false;
			this.btn_newgame.MouseLeave += new System.EventHandler(this.btn_newgame_MouseLeave);
			this.btn_newgame.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_newgame_MouseMove);
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = global::IdleGame.Properties.Resources.Banniere;
			this.pictureBox4.Location = new System.Drawing.Point(3, 42);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(1000, 470);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox4.TabIndex = 8;
			this.pictureBox4.TabStop = false;
			// 
			// BottomLine
			// 
			this.BottomLine.Location = new System.Drawing.Point(158, 98);
			this.BottomLine.Name = "BottomLine";
			this.BottomLine.Size = new System.Drawing.Size(1, 50);
			this.BottomLine.TabIndex = 4;
			this.BottomLine.TabStop = false;
			// 
			// RightLine
			// 
			this.RightLine.Location = new System.Drawing.Point(150, 90);
			this.RightLine.Name = "RightLine";
			this.RightLine.Size = new System.Drawing.Size(1, 50);
			this.RightLine.TabIndex = 3;
			this.RightLine.TabStop = false;
			// 
			// TopLine
			// 
			this.TopLine.Location = new System.Drawing.Point(189, 117);
			this.TopLine.Name = "TopLine";
			this.TopLine.Size = new System.Drawing.Size(1, 50);
			this.TopLine.TabIndex = 2;
			this.TopLine.TabStop = false;
			// 
			// LeftLine
			// 
			this.LeftLine.Location = new System.Drawing.Point(2, 76);
			this.LeftLine.Name = "LeftLine";
			this.LeftLine.Size = new System.Drawing.Size(1, 100);
			this.LeftLine.TabIndex = 1;
			this.LeftLine.TabStop = false;
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
			// lbl_info
			// 
			this.lbl_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_info.Location = new System.Drawing.Point(225, 156);
			this.lbl_info.Name = "lbl_info";
			this.lbl_info.Size = new System.Drawing.Size(649, 142);
			this.lbl_info.TabIndex = 9;
			this.lbl_info.Text = "IdleGame est un projet d\'école réalisé par Laurie-Anne, Sam et Carl.";
			// 
			// FormMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(903, 290);
			this.Controls.Add(this.lbl_info);
			this.Controls.Add(this.btn_exit);
			this.Controls.Add(this.btn_loadgame);
			this.Controls.Add(this.btn_newgame);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.BottomLine);
			this.Controls.Add(this.RightLine);
			this.Controls.Add(this.TopLine);
			this.Controls.Add(this.LeftLine);
			this.Controls.Add(this.top);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormMenu";
			this.Text = "IdleGame";
			this.Load += new System.EventHandler(this.CharForm_Load);
			this.Resize += new System.EventHandler(this.CharForm_Resize);
			this.top.ResumeLayout(false);
			this.top.PerformLayout();
			this.mnu_main.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.btn_exit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btn_loadgame)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btn_newgame)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BottomLine)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.RightLine)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TopLine)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.LeftLine)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pct_Reduire)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pct_Fermer)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pct_Agrandir)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pct_icon)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel top;
		private System.Windows.Forms.PictureBox pct_icon;
		private System.Windows.Forms.Label lbl_title;
		private System.Windows.Forms.PictureBox pct_Agrandir;
		private System.Windows.Forms.PictureBox pct_Fermer;
		private System.Windows.Forms.PictureBox pct_Reduire;
		private System.Windows.Forms.ContextMenuStrip mnu_main;
		private System.Windows.Forms.ToolStripMenuItem mnu_about;
		private System.Windows.Forms.ToolStripMenuItem mnu_close;
		private System.Windows.Forms.PictureBox LeftLine;
		private System.Windows.Forms.PictureBox TopLine;
		private System.Windows.Forms.PictureBox RightLine;
		private System.Windows.Forms.PictureBox BottomLine;
		private System.Windows.Forms.PictureBox btn_newgame;
		private System.Windows.Forms.PictureBox btn_loadgame;
		private System.Windows.Forms.PictureBox btn_exit;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.Label lbl_info;
	}
}

