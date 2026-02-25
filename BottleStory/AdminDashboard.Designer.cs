namespace BottleStory {
    partial class AdminDashboard {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent() {
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnNavPayment = new System.Windows.Forms.Button();
            this.btnNavClients = new System.Windows.Forms.Button();
            this.btnNavOrders = new System.Windows.Forms.Button();
            this.btnNavDash = new System.Windows.Forms.Button();
            this.lblBrand = new System.Windows.Forms.Label();
            this.pnlCard1 = new System.Windows.Forms.Panel();
            this.lblCard1Value = new System.Windows.Forms.Label();
            this.lblCard1Title = new System.Windows.Forms.Label();
            this.pnlCard2 = new System.Windows.Forms.Panel();
            this.lblCard2Value = new System.Windows.Forms.Label();
            this.lblCard2Title = new System.Windows.Forms.Label();
            this.pnlCard3 = new System.Windows.Forms.Panel();
            this.lblCard3Value = new System.Windows.Forms.Label();
            this.lblCard3Title = new System.Windows.Forms.Label();
            this.lstRecentOrders = new System.Windows.Forms.ListBox();
            this.lblRecentOrdersTitle = new System.Windows.Forms.Label();
            this.lstSecurityLog = new System.Windows.Forms.ListBox();
            this.lblLogTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlSidebar.SuspendLayout();
            this.pnlCard1.SuspendLayout();
            this.pnlCard2.SuspendLayout();
            this.pnlCard3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(35)))), ((int)(((byte)(91)))));
            this.pnlSidebar.Controls.Add(this.btnNavPayment);
            this.pnlSidebar.Controls.Add(this.btnNavClients);
            this.pnlSidebar.Controls.Add(this.btnNavOrders);
            this.pnlSidebar.Controls.Add(this.btnNavDash);
            this.pnlSidebar.Controls.Add(this.lblBrand);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(220, 550);
            this.pnlSidebar.TabIndex = 0;
            // 
            // btnNavPayment
            // 
            this.btnNavPayment.FlatAppearance.BorderSize = 0;
            this.btnNavPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavPayment.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnNavPayment.ForeColor = System.Drawing.Color.White;
            this.btnNavPayment.Location = new System.Drawing.Point(0, 300);
            this.btnNavPayment.Name = "btnNavPayment";
            this.btnNavPayment.Size = new System.Drawing.Size(220, 50);
            this.btnNavPayment.TabIndex = 0;
            this.btnNavPayment.Text = "💳 Payment Status";
            // 
            // btnNavClients
            // 
            this.btnNavClients.FlatAppearance.BorderSize = 0;
            this.btnNavClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavClients.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnNavClients.ForeColor = System.Drawing.Color.White;
            this.btnNavClients.Location = new System.Drawing.Point(0, 250);
            this.btnNavClients.Name = "btnNavClients";
            this.btnNavClients.Size = new System.Drawing.Size(220, 50);
            this.btnNavClients.TabIndex = 1;
            this.btnNavClients.Text = "🏢 Clients";
            // 
            // btnNavOrders
            // 
            this.btnNavOrders.FlatAppearance.BorderSize = 0;
            this.btnNavOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavOrders.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnNavOrders.ForeColor = System.Drawing.Color.White;
            this.btnNavOrders.Location = new System.Drawing.Point(0, 200);
            this.btnNavOrders.Name = "btnNavOrders";
            this.btnNavOrders.Size = new System.Drawing.Size(220, 50);
            this.btnNavOrders.TabIndex = 2;
            this.btnNavOrders.Text = "📦 Orders";
            this.btnNavOrders.Click += new System.EventHandler(this.btnNavOrders_Click);
            // 
            // btnNavDash
            // 
            this.btnNavDash.FlatAppearance.BorderSize = 0;
            this.btnNavDash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavDash.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnNavDash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(154)))), ((int)(((byte)(77)))));
            this.btnNavDash.Location = new System.Drawing.Point(0, 150);
            this.btnNavDash.Name = "btnNavDash";
            this.btnNavDash.Size = new System.Drawing.Size(220, 50);
            this.btnNavDash.TabIndex = 3;
            this.btnNavDash.Text = "📊 Dashboard";
            this.btnNavDash.Click += new System.EventHandler(this.btnNavDash_Click);
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblBrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(154)))), ((int)(((byte)(77)))));
            this.lblBrand.Location = new System.Drawing.Point(20, 30);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(172, 74);
            this.lblBrand.TabIndex = 4;
            this.lblBrand.Text = "Bottle Story\nBusiness";
            // 
            // pnlCard1
            // 
            this.pnlCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(35)))), ((int)(((byte)(91)))));
            this.pnlCard1.Controls.Add(this.lblCard1Value);
            this.pnlCard1.Controls.Add(this.lblCard1Title);
            this.pnlCard1.Location = new System.Drawing.Point(15, 18);
            this.pnlCard1.Name = "pnlCard1";
            this.pnlCard1.Size = new System.Drawing.Size(200, 120);
            this.pnlCard1.TabIndex = 6;
            // 
            // lblCard1Value
            // 
            this.lblCard1Value.AutoSize = true;
            this.lblCard1Value.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblCard1Value.ForeColor = System.Drawing.Color.White;
            this.lblCard1Value.Location = new System.Drawing.Point(10, 45);
            this.lblCard1Value.Name = "lblCard1Value";
            this.lblCard1Value.Size = new System.Drawing.Size(206, 54);
            this.lblCard1Value.TabIndex = 0;
            this.lblCard1Value.Text = "₹1,45,500";
            // 
            // lblCard1Title
            // 
            this.lblCard1Title.AutoSize = true;
            this.lblCard1Title.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCard1Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(154)))), ((int)(((byte)(77)))));
            this.lblCard1Title.Location = new System.Drawing.Point(15, 15);
            this.lblCard1Title.Name = "lblCard1Title";
            this.lblCard1Title.Size = new System.Drawing.Size(140, 23);
            this.lblCard1Title.TabIndex = 1;
            this.lblCard1Title.Text = "TOTAL REVENUE";
            // 
            // pnlCard2
            // 
            this.pnlCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(35)))), ((int)(((byte)(91)))));
            this.pnlCard2.Controls.Add(this.lblCard2Value);
            this.pnlCard2.Controls.Add(this.lblCard2Title);
            this.pnlCard2.Location = new System.Drawing.Point(237, 18);
            this.pnlCard2.Name = "pnlCard2";
            this.pnlCard2.Size = new System.Drawing.Size(200, 120);
            this.pnlCard2.TabIndex = 5;
            // 
            // lblCard2Value
            // 
            this.lblCard2Value.AutoSize = true;
            this.lblCard2Value.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblCard2Value.ForeColor = System.Drawing.Color.White;
            this.lblCard2Value.Location = new System.Drawing.Point(15, 45);
            this.lblCard2Value.Name = "lblCard2Value";
            this.lblCard2Value.Size = new System.Drawing.Size(81, 62);
            this.lblCard2Value.TabIndex = 0;
            this.lblCard2Value.Text = "24";
            // 
            // lblCard2Title
            // 
            this.lblCard2Title.AutoSize = true;
            this.lblCard2Title.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCard2Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(154)))), ((int)(((byte)(77)))));
            this.lblCard2Title.Location = new System.Drawing.Point(15, 15);
            this.lblCard2Title.Name = "lblCard2Title";
            this.lblCard2Title.Size = new System.Drawing.Size(157, 23);
            this.lblCard2Title.TabIndex = 1;
            this.lblCard2Title.Text = "PENDING ORDERS";
            // 
            // pnlCard3
            // 
            this.pnlCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(154)))), ((int)(((byte)(77)))));
            this.pnlCard3.Controls.Add(this.lblCard3Value);
            this.pnlCard3.Controls.Add(this.lblCard3Title);
            this.pnlCard3.Location = new System.Drawing.Point(464, 18);
            this.pnlCard3.Name = "pnlCard3";
            this.pnlCard3.Size = new System.Drawing.Size(200, 120);
            this.pnlCard3.TabIndex = 4;
            // 
            // lblCard3Value
            // 
            this.lblCard3Value.AutoSize = true;
            this.lblCard3Value.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblCard3Value.ForeColor = System.Drawing.Color.White;
            this.lblCard3Value.Location = new System.Drawing.Point(10, 45);
            this.lblCard3Value.Name = "lblCard3Value";
            this.lblCard3Value.Size = new System.Drawing.Size(149, 54);
            this.lblCard3Value.TabIndex = 0;
            this.lblCard3Value.Text = "₹7,275";
            // 
            // lblCard3Title
            // 
            this.lblCard3Title.AutoSize = true;
            this.lblCard3Title.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCard3Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(35)))), ((int)(((byte)(91)))));
            this.lblCard3Title.Location = new System.Drawing.Point(15, 15);
            this.lblCard3Title.Name = "lblCard3Title";
            this.lblCard3Title.Size = new System.Drawing.Size(162, 23);
            this.lblCard3Title.TabIndex = 1;
            this.lblCard3Title.Text = "CSR IMPACT FUND";
            // 
            // lstRecentOrders
            // 
            this.lstRecentOrders.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lstRecentOrders.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstRecentOrders.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lstRecentOrders.ItemHeight = 23;
            this.lstRecentOrders.Items.AddRange(new object[] {
            "• Madeena Hotel: 500x 500ml Bottles",
            "• Payment Rcvd: Al Filfilah - ₹4,500",
            "• New Client Reg: Empire Restaurant",
            "• Order Dispatched: ID #41",
            "• Design Approved: ID #42"});
            this.lstRecentOrders.Location = new System.Drawing.Point(377, 211);
            this.lstRecentOrders.Name = "lstRecentOrders";
            this.lstRecentOrders.Size = new System.Drawing.Size(320, 232);
            this.lstRecentOrders.TabIndex = 3;
            // 
            // lblRecentOrdersTitle
            // 
            this.lblRecentOrdersTitle.AutoSize = true;
            this.lblRecentOrdersTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblRecentOrdersTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(35)))), ((int)(((byte)(91)))));
            this.lblRecentOrdersTitle.Location = new System.Drawing.Point(372, 171);
            this.lblRecentOrdersTitle.Name = "lblRecentOrdersTitle";
            this.lblRecentOrdersTitle.Size = new System.Drawing.Size(278, 28);
            this.lblRecentOrdersTitle.TabIndex = 2;
            this.lblRecentOrdersTitle.Text = "📈 Recent Business Activity";
            // 
            // lstSecurityLog
            // 
            this.lstSecurityLog.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lstSecurityLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstSecurityLog.Font = new System.Drawing.Font("Consolas", 9F);
            this.lstSecurityLog.ItemHeight = 18;
            this.lstSecurityLog.Items.AddRange(new object[] {
            "[SYS] User Admin logged in.",
            "[SEC] AES-256 Auth initialized.",
            "[DB] Encrypted payload saved.",
            "[SYS] Order #44 decrypted by Admin.",
            "[SEC] DB connection secure."});
            this.lstSecurityLog.Location = new System.Drawing.Point(15, 211);
            this.lstSecurityLog.Name = "lstSecurityLog";
            this.lstSecurityLog.Size = new System.Drawing.Size(320, 236);
            this.lstSecurityLog.TabIndex = 1;
            // 
            // lblLogTitle
            // 
            this.lblLogTitle.AutoSize = true;
            this.lblLogTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblLogTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(35)))), ((int)(((byte)(91)))));
            this.lblLogTitle.Location = new System.Drawing.Point(10, 171);
            this.lblLogTitle.Name = "lblLogTitle";
            this.lblLogTitle.Size = new System.Drawing.Size(265, 28);
            this.lblLogTitle.TabIndex = 0;
            this.lblLogTitle.Text = "🔒 Live Security Audit Log";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblLogTitle);
            this.panel1.Controls.Add(this.lblRecentOrdersTitle);
            this.panel1.Controls.Add(this.pnlCard1);
            this.panel1.Controls.Add(this.pnlCard2);
            this.panel1.Controls.Add(this.pnlCard3);
            this.panel1.Controls.Add(this.lstRecentOrders);
            this.panel1.Controls.Add(this.lstSecurityLog);
            this.panel1.Location = new System.Drawing.Point(226, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(226, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(722, 526);
            this.panel2.TabIndex = 7;
            this.panel2.Visible = false;
            // 
            // AdminDashboard
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 550);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlSidebar);
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.pnlCard1.ResumeLayout(false);
            this.pnlCard1.PerformLayout();
            this.pnlCard2.ResumeLayout(false);
            this.pnlCard2.PerformLayout();
            this.pnlCard3.ResumeLayout(false);
            this.pnlCard3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Button btnNavDash;
        private System.Windows.Forms.Button btnNavOrders;
        private System.Windows.Forms.Button btnNavClients;
        private System.Windows.Forms.Button btnNavPayment;
        private System.Windows.Forms.Panel pnlCard1;
        private System.Windows.Forms.Label lblCard1Title;
        private System.Windows.Forms.Label lblCard1Value;
        private System.Windows.Forms.Panel pnlCard2;
        private System.Windows.Forms.Label lblCard2Title;
        private System.Windows.Forms.Label lblCard2Value;
        private System.Windows.Forms.Panel pnlCard3;
        private System.Windows.Forms.Label lblCard3Title;
        private System.Windows.Forms.Label lblCard3Value;
        private System.Windows.Forms.ListBox lstRecentOrders;
        private System.Windows.Forms.Label lblRecentOrdersTitle;
        private System.Windows.Forms.ListBox lstSecurityLog;
        private System.Windows.Forms.Label lblLogTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}