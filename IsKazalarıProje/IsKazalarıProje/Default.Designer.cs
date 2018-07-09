namespace IsKazalarıProje
{
    partial class Default
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblNameSurname = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.anasayfaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcılarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.işKazasıBildirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kazalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uygulamadanÇıkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(718, 34);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(60, 13);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Çıkış Yap";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblNameSurname
            // 
            this.lblNameSurname.AutoSize = true;
            this.lblNameSurname.Location = new System.Drawing.Point(498, 34);
            this.lblNameSurname.Name = "lblNameSurname";
            this.lblNameSurname.Size = new System.Drawing.Size(0, 13);
            this.lblNameSurname.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anasayfaToolStripMenuItem,
            this.kullanıcılarToolStripMenuItem,
            this.işKazasıBildirToolStripMenuItem,
            this.kazalarToolStripMenuItem,
            this.uygulamadanÇıkToolStripMenuItem,
            this.profilToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(790, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // anasayfaToolStripMenuItem
            // 
            this.anasayfaToolStripMenuItem.Image = global::IsKazalarıProje.Properties.Resources.Homepage;
            this.anasayfaToolStripMenuItem.Name = "anasayfaToolStripMenuItem";
            this.anasayfaToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.anasayfaToolStripMenuItem.Text = "Anasayfa";
            this.anasayfaToolStripMenuItem.Click += new System.EventHandler(this.anasayfaToolStripMenuItem_Click);
            // 
            // kullanıcılarToolStripMenuItem
            // 
            this.kullanıcılarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullanıcıDüzenleToolStripMenuItem});
            this.kullanıcılarToolStripMenuItem.Image = global::IsKazalarıProje.Properties.Resources.Kullanici;
            this.kullanıcılarToolStripMenuItem.Name = "kullanıcılarToolStripMenuItem";
            this.kullanıcılarToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.kullanıcılarToolStripMenuItem.Text = "Kullanıcılar";
            // 
            // kullanıcıDüzenleToolStripMenuItem
            // 
            this.kullanıcıDüzenleToolStripMenuItem.Name = "kullanıcıDüzenleToolStripMenuItem";
            this.kullanıcıDüzenleToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.kullanıcıDüzenleToolStripMenuItem.Text = "Bekleyen Kullanıcılar";
            this.kullanıcıDüzenleToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıDüzenleToolStripMenuItem_Click);
            // 
            // işKazasıBildirToolStripMenuItem
            // 
            this.işKazasıBildirToolStripMenuItem.Image = global::IsKazalarıProje.Properties.Resources.BusinessCrash;
            this.işKazasıBildirToolStripMenuItem.Name = "işKazasıBildirToolStripMenuItem";
            this.işKazasıBildirToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.işKazasıBildirToolStripMenuItem.Text = "İş Kazası Bildir";
            this.işKazasıBildirToolStripMenuItem.Click += new System.EventHandler(this.işKazasıBildirToolStripMenuItem_Click);
            // 
            // kazalarToolStripMenuItem
            // 
            this.kazalarToolStripMenuItem.Image = global::IsKazalarıProje.Properties.Resources.BusinessCrash;
            this.kazalarToolStripMenuItem.Name = "kazalarToolStripMenuItem";
            this.kazalarToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.kazalarToolStripMenuItem.Text = "Kazalar";
            this.kazalarToolStripMenuItem.Click += new System.EventHandler(this.kazalarToolStripMenuItem_Click);
            // 
            // uygulamadanÇıkToolStripMenuItem
            // 
            this.uygulamadanÇıkToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.uygulamadanÇıkToolStripMenuItem.Image = global::IsKazalarıProje.Properties.Resources.Exit;
            this.uygulamadanÇıkToolStripMenuItem.Name = "uygulamadanÇıkToolStripMenuItem";
            this.uygulamadanÇıkToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.uygulamadanÇıkToolStripMenuItem.Text = "Uygulamadan Çık";
            this.uygulamadanÇıkToolStripMenuItem.Click += new System.EventHandler(this.uygulamadanÇıkToolStripMenuItem_Click);
            // 
            // profilToolStripMenuItem
            // 
            this.profilToolStripMenuItem.Image = global::IsKazalarıProje.Properties.Resources.Profile;
            this.profilToolStripMenuItem.Name = "profilToolStripMenuItem";
            this.profilToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.profilToolStripMenuItem.Text = "Profil";
            this.profilToolStripMenuItem.Click += new System.EventHandler(this.profilToolStripMenuItem_Click);
            // 
            // Default
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(790, 542);
            this.Controls.Add(this.lblNameSurname);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Default";
            this.Text = "Default";
            this.Load += new System.EventHandler(this.Default_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lblNameSurname;
        private System.Windows.Forms.ToolStripMenuItem anasayfaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcılarToolStripMenuItem;
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem kullanıcıDüzenleToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem işKazasıBildirToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem kazalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uygulamadanÇıkToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem profilToolStripMenuItem;
    }
}