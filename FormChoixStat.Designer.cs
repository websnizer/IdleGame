namespace IdleGame
{
    partial class FormChoixStat
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
            this.lbl_choix = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lbl_tempsrestant = new System.Windows.Forms.Label();
            this.btn_dex = new System.Windows.Forms.PictureBox();
            this.btn_con = new System.Windows.Forms.PictureBox();
            this.btn_int = new System.Windows.Forms.PictureBox();
            this.btn_sag = new System.Windows.Forms.PictureBox();
            this.btn_for = new System.Windows.Forms.PictureBox();
            this.btn_cha = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_dex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_con)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_int)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_sag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_for)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cha)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_choix
            // 
            this.lbl_choix.AutoSize = true;
            this.lbl_choix.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_choix.Location = new System.Drawing.Point(7, 39);
            this.lbl_choix.Name = "lbl_choix";
            this.lbl_choix.Size = new System.Drawing.Size(243, 25);
            this.lbl_choix.TabIndex = 0;
            this.lbl_choix.Text = "Sélectionner une stat.";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lbl_tempsrestant
            // 
            this.lbl_tempsrestant.AutoSize = true;
            this.lbl_tempsrestant.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tempsrestant.Location = new System.Drawing.Point(1, -6);
            this.lbl_tempsrestant.Name = "lbl_tempsrestant";
            this.lbl_tempsrestant.Size = new System.Drawing.Size(41, 45);
            this.lbl_tempsrestant.TabIndex = 1;
            this.lbl_tempsrestant.Text = "a";
            // 
            // btn_dex
            // 
            this.btn_dex.Image = global::IdleGame.Properties.Resources.bouton_dexterite;
            this.btn_dex.Location = new System.Drawing.Point(32, 126);
            this.btn_dex.Name = "btn_dex";
            this.btn_dex.Size = new System.Drawing.Size(182, 38);
            this.btn_dex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_dex.TabIndex = 23;
            this.btn_dex.TabStop = false;
            this.btn_dex.Tag = "2";
            this.btn_dex.Click += new System.EventHandler(this.btn_click);
            // 
            // btn_con
            // 
            this.btn_con.Image = global::IdleGame.Properties.Resources.bouton_constitution;
            this.btn_con.Location = new System.Drawing.Point(32, 170);
            this.btn_con.Name = "btn_con";
            this.btn_con.Size = new System.Drawing.Size(182, 38);
            this.btn_con.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_con.TabIndex = 24;
            this.btn_con.TabStop = false;
            this.btn_con.Tag = "3";
            this.btn_con.Click += new System.EventHandler(this.btn_click);
            // 
            // btn_int
            // 
            this.btn_int.Image = global::IdleGame.Properties.Resources.bouton_intelligence;
            this.btn_int.Location = new System.Drawing.Point(32, 214);
            this.btn_int.Name = "btn_int";
            this.btn_int.Size = new System.Drawing.Size(182, 38);
            this.btn_int.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_int.TabIndex = 25;
            this.btn_int.TabStop = false;
            this.btn_int.Tag = "4";
            this.btn_int.Click += new System.EventHandler(this.btn_click);
            // 
            // btn_sag
            // 
            this.btn_sag.Image = global::IdleGame.Properties.Resources.bouton_sagesse;
            this.btn_sag.Location = new System.Drawing.Point(32, 258);
            this.btn_sag.Name = "btn_sag";
            this.btn_sag.Size = new System.Drawing.Size(182, 38);
            this.btn_sag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_sag.TabIndex = 26;
            this.btn_sag.TabStop = false;
            this.btn_sag.Tag = "5";
            this.btn_sag.Click += new System.EventHandler(this.btn_click);
            // 
            // btn_for
            // 
            this.btn_for.Image = global::IdleGame.Properties.Resources.bouton_force;
            this.btn_for.Location = new System.Drawing.Point(32, 82);
            this.btn_for.Name = "btn_for";
            this.btn_for.Size = new System.Drawing.Size(182, 38);
            this.btn_for.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_for.TabIndex = 27;
            this.btn_for.TabStop = false;
            this.btn_for.Tag = "1";
            this.btn_for.Click += new System.EventHandler(this.btn_click);
            // 
            // btn_cha
            // 
            this.btn_cha.Image = global::IdleGame.Properties.Resources.bouton_charisme;
            this.btn_cha.Location = new System.Drawing.Point(32, 302);
            this.btn_cha.Name = "btn_cha";
            this.btn_cha.Size = new System.Drawing.Size(182, 38);
            this.btn_cha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_cha.TabIndex = 28;
            this.btn_cha.TabStop = false;
            this.btn_cha.Tag = "6";
            this.btn_cha.Click += new System.EventHandler(this.btn_click);
            // 
            // FormChoixStat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(264, 360);
            this.Controls.Add(this.btn_cha);
            this.Controls.Add(this.btn_for);
            this.Controls.Add(this.btn_sag);
            this.Controls.Add(this.btn_int);
            this.Controls.Add(this.btn_con);
            this.Controls.Add(this.btn_dex);
            this.Controls.Add(this.lbl_tempsrestant);
            this.Controls.Add(this.lbl_choix);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormChoixStat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormChoixEquipement";
            ((System.ComponentModel.ISupportInitialize)(this.btn_dex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_con)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_int)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_sag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_for)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_choix;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lbl_tempsrestant;
        private System.Windows.Forms.PictureBox btn_dex;
        private System.Windows.Forms.PictureBox btn_con;
        private System.Windows.Forms.PictureBox btn_int;
        private System.Windows.Forms.PictureBox btn_sag;
        private System.Windows.Forms.PictureBox btn_for;
        private System.Windows.Forms.PictureBox btn_cha;
    }
}