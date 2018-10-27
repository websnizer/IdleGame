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
			this.pct_Reduire = new System.Windows.Forms.PictureBox();
			this.pct_Fermer = new System.Windows.Forms.PictureBox();
			this.pct_Agrandir = new System.Windows.Forms.PictureBox();
			this.pct_icon = new System.Windows.Forms.PictureBox();
			this.lbl_title = new System.Windows.Forms.Label();
			this.mnu_main = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.mnu_about = new System.Windows.Forms.ToolStripMenuItem();
			this.mnu_close = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.top.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pct_Reduire)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pct_Fermer)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pct_Agrandir)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pct_icon)).BeginInit();
			this.mnu_main.SuspendLayout();
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
			this.top.Size = new System.Drawing.Size(301, 35);
			this.top.TabIndex = 0;
			this.top.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.top_MouseDoubleClick);
			this.top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.top_MouseDown);
			this.top.MouseMove += new System.Windows.Forms.MouseEventHandler(this.top_MouseMove);
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
			// lbl_title
			// 
			this.lbl_title.AutoSize = true;
			this.lbl_title.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_title.ForeColor = System.Drawing.Color.White;
			this.lbl_title.Location = new System.Drawing.Point(36, 7);
			this.lbl_title.Name = "lbl_title";
			this.lbl_title.Size = new System.Drawing.Size(63, 17);
			this.lbl_title.TabIndex = 0;
			this.lbl_title.Text = "IdleGame";
			this.lbl_title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.top_MouseDown);
			this.lbl_title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.top_MouseMove);
			// 
			// mnu_main
			// 
			this.mnu_main.BackColor = System.Drawing.Color.Firebrick;
			this.mnu_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.mnu_about,
            this.mnu_close});
			this.mnu_main.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
			this.mnu_main.Name = "contextMenuStrip1";
			this.mnu_main.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.mnu_main.ShowImageMargin = false;
			this.mnu_main.Size = new System.Drawing.Size(156, 114);
			this.mnu_main.Text = "Menu";
			// 
			// mnu_about
			// 
			this.mnu_about.ForeColor = System.Drawing.Color.White;
			this.mnu_about.Name = "mnu_about";
			this.mnu_about.Size = new System.Drawing.Size(155, 22);
			this.mnu_about.Text = "About";
			// 
			// mnu_close
			// 
			this.mnu_close.ForeColor = System.Drawing.Color.White;
			this.mnu_close.Name = "mnu_close";
			this.mnu_close.Size = new System.Drawing.Size(155, 22);
			this.mnu_close.Text = "Close";
			this.mnu_close.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
			this.saveToolStripMenuItem.Text = "Save";
			// 
			// loadToolStripMenuItem
			// 
			this.loadToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
			this.loadToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
			this.loadToolStripMenuItem.Text = "Load";
			// 
			// FormMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(301, 231);
			this.Controls.Add(this.top);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormMenu";
			this.Text = "IdleGame";
			this.Load += new System.EventHandler(this.CharForm_Load);
			this.Resize += new System.EventHandler(this.CharForm_Resize);
			this.top.ResumeLayout(false);
			this.top.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pct_Reduire)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pct_Fermer)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pct_Agrandir)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pct_icon)).EndInit();
			this.mnu_main.ResumeLayout(false);
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
		private System.Windows.Forms.ToolStripMenuItem mnu_about;
		private System.Windows.Forms.ToolStripMenuItem mnu_close;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
	}
}

