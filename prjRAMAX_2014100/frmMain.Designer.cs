namespace prjRAMAX_2014100
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dashboardremax = new System.Windows.Forms.ToolStripMenuItem();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.houseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.houseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.qUITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.MnuLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logout = new System.Windows.Forms.ToolStripMenuItem();
            this.agentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardremax,
            this.MnuLogin,
            this.logout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // dashboardremax
            // 
            this.dashboardremax.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.qUITToolStripMenuItem});
            this.dashboardremax.Name = "dashboardremax";
            this.dashboardremax.Size = new System.Drawing.Size(63, 20);
            this.dashboardremax.Text = "RE-MAX";
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerToolStripMenuItem,
            this.agentToolStripMenuItem,
            this.houseToolStripMenuItem});
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.manageToolStripMenuItem.Text = "Manage";
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.customerToolStripMenuItem.Text = "Customer";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
            // 
            // agentToolStripMenuItem
            // 
            this.agentToolStripMenuItem.Name = "agentToolStripMenuItem";
            this.agentToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.agentToolStripMenuItem.Text = "Agent";
            this.agentToolStripMenuItem.Click += new System.EventHandler(this.agentToolStripMenuItem_Click);
            // 
            // houseToolStripMenuItem
            // 
            this.houseToolStripMenuItem.Name = "houseToolStripMenuItem";
            this.houseToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.houseToolStripMenuItem.Text = "House";
            this.houseToolStripMenuItem.Click += new System.EventHandler(this.houseToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.houseToolStripMenuItem1});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // houseToolStripMenuItem1
            // 
            this.houseToolStripMenuItem1.Name = "houseToolStripMenuItem1";
            this.houseToolStripMenuItem1.Size = new System.Drawing.Size(108, 22);
            this.houseToolStripMenuItem1.Text = "House";
            this.houseToolStripMenuItem1.Click += new System.EventHandler(this.houseToolStripMenuItem1_Click);
            // 
            // qUITToolStripMenuItem
            // 
            this.qUITToolStripMenuItem.Name = "qUITToolStripMenuItem";
            this.qUITToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.qUITToolStripMenuItem.Text = "QUIT";
            // 
            // btnsearch
            // 
            this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.ForeColor = System.Drawing.Color.Black;
            this.btnsearch.Location = new System.Drawing.Point(655, 267);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(123, 42);
            this.btnsearch.TabIndex = 1;
            this.btnsearch.Text = "DIRECT SEARCH ";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(655, 326);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(123, 40);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MnuLogin
            // 
            this.MnuLogin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.agentToolStripMenuItem1});
            this.MnuLogin.Name = "MnuLogin";
            this.MnuLogin.Size = new System.Drawing.Size(54, 20);
            this.MnuLogin.Text = "LOGIN";
            this.MnuLogin.Click += new System.EventHandler(this.lOGINToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // logout
            // 
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(65, 20);
            this.logout.Text = "LOGOUT";
            this.logout.Click += new System.EventHandler(this.lOGOUTToolStripMenuItem_Click);
            // 
            // agentToolStripMenuItem1
            // 
            this.agentToolStripMenuItem1.Name = "agentToolStripMenuItem1";
            this.agentToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.agentToolStripMenuItem1.Text = "Agent";
            this.agentToolStripMenuItem1.Click += new System.EventHandler(this.agentToolStripMenuItem1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::prjRAMAX_2014100.Properties.Resources.remax;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardremax;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem houseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem houseToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem qUITToolStripMenuItem;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolStripMenuItem MnuLogin;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logout;
        private System.Windows.Forms.ToolStripMenuItem agentToolStripMenuItem1;
    }
}