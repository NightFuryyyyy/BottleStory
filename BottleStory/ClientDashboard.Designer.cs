namespace BottleStory
{
    partial class ClientDashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnNavPayments = new System.Windows.Forms.Button();
            this.btnNavHistory = new System.Windows.Forms.Button();
            this.btnNavNewOrder = new System.Windows.Forms.Button();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pnlHeaderLine = new System.Windows.Forms.Panel();
            this.lblOrderDetails = new System.Windows.Forms.Label();
            this.cmbBottleSize = new System.Windows.Forms.ComboBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.cmbCSR = new System.Windows.Forms.ComboBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblDesignUpload = new System.Windows.Forms.Label();
            this.picLogoPreview = new System.Windows.Forms.PictureBox();
            this.btnBrowseLogo = new System.Windows.Forms.Button();
            this.txtDesignNotes = new System.Windows.Forms.TextBox();
            this.btnSubmitOrder = new System.Windows.Forms.Button();
            this.pnlImpactCard = new System.Windows.Forms.Panel();
            this.lblImpactValue = new System.Windows.Forms.Label();
            this.lblImpactTitle = new System.Windows.Forms.Label();
            this.pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoPreview)).BeginInit();
            this.pnlImpactCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(35)))), ((int)(((byte)(91)))));
            this.pnlSidebar.Controls.Add(this.btnNavPayments);
            this.pnlSidebar.Controls.Add(this.btnNavHistory);
            this.pnlSidebar.Controls.Add(this.btnNavNewOrder);
            this.pnlSidebar.Controls.Add(this.lblBrand);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(220, 550);
            this.pnlSidebar.TabIndex = 13;
            // 
            // btnNavPayments
            // 
            this.btnNavPayments.FlatAppearance.BorderSize = 0;
            this.btnNavPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavPayments.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnNavPayments.ForeColor = System.Drawing.Color.White;
            this.btnNavPayments.Location = new System.Drawing.Point(0, 250);
            this.btnNavPayments.Name = "btnNavPayments";
            this.btnNavPayments.Size = new System.Drawing.Size(220, 50);
            this.btnNavPayments.TabIndex = 0;
            this.btnNavPayments.Text = "💳 Invoices";
            // 
            // btnNavHistory
            // 
            this.btnNavHistory.FlatAppearance.BorderSize = 0;
            this.btnNavHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavHistory.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnNavHistory.ForeColor = System.Drawing.Color.White;
            this.btnNavHistory.Location = new System.Drawing.Point(0, 200);
            this.btnNavHistory.Name = "btnNavHistory";
            this.btnNavHistory.Size = new System.Drawing.Size(220, 50);
            this.btnNavHistory.TabIndex = 1;
            this.btnNavHistory.Text = "📦 Order History";
            this.btnNavHistory.Click += new System.EventHandler(this.btnNavHistory_Click);
            // 
            // btnNavNewOrder
            // 
            this.btnNavNewOrder.FlatAppearance.BorderSize = 0;
            this.btnNavNewOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavNewOrder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnNavNewOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(154)))), ((int)(((byte)(77)))));
            this.btnNavNewOrder.Location = new System.Drawing.Point(0, 150);
            this.btnNavNewOrder.Name = "btnNavNewOrder";
            this.btnNavNewOrder.Size = new System.Drawing.Size(220, 50);
            this.btnNavNewOrder.TabIndex = 2;
            this.btnNavNewOrder.Text = "➕ New Order";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblBrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(154)))), ((int)(((byte)(77)))));
            this.lblBrand.Location = new System.Drawing.Point(20, 30);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(142, 60);
            this.lblBrand.TabIndex = 3;
            this.lblBrand.Text = "Bottle Story\nClient Portal";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(35)))), ((int)(((byte)(91)))));
            this.lblWelcome.Location = new System.Drawing.Point(240, 20);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(254, 32);
            this.lblWelcome.TabIndex = 12;
            this.lblWelcome.Text = "Create Custom Order";
            // 
            // pnlHeaderLine
            // 
            this.pnlHeaderLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(154)))), ((int)(((byte)(77)))));
            this.pnlHeaderLine.Location = new System.Drawing.Point(245, 70);
            this.pnlHeaderLine.Name = "pnlHeaderLine";
            this.pnlHeaderLine.Size = new System.Drawing.Size(680, 4);
            this.pnlHeaderLine.TabIndex = 11;
            // 
            // lblOrderDetails
            // 
            this.lblOrderDetails.AutoSize = true;
            this.lblOrderDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblOrderDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(35)))), ((int)(((byte)(91)))));
            this.lblOrderDetails.Location = new System.Drawing.Point(245, 90);
            this.lblOrderDetails.Name = "lblOrderDetails";
            this.lblOrderDetails.Size = new System.Drawing.Size(181, 21);
            this.lblOrderDetails.TabIndex = 10;
            this.lblOrderDetails.Text = "1. Order Specifications";
            // 
            // cmbBottleSize
            // 
            this.cmbBottleSize.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbBottleSize.Items.AddRange(new object[] {
            "250ml",
            "500ml",
            "1 Liter"});
            this.cmbBottleSize.Location = new System.Drawing.Point(245, 130);
            this.cmbBottleSize.Name = "cmbBottleSize";
            this.cmbBottleSize.Size = new System.Drawing.Size(300, 28);
            this.cmbBottleSize.TabIndex = 9;
            this.cmbBottleSize.Text = "Select Bottle Size...";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtQuantity.Location = new System.Drawing.Point(245, 180);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(300, 27);
            this.txtQuantity.TabIndex = 8;
            this.txtQuantity.Text = "Quantity (e.g., 500)";
            // 
            // cmbCSR
            // 
            this.cmbCSR.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbCSR.Items.AddRange(new object[] {
            "Clean Water Fund (SDG 6)",
            "Ocean Cleanup",
            "Reforestation Project"});
            this.cmbCSR.Location = new System.Drawing.Point(245, 230);
            this.cmbCSR.Name = "cmbCSR";
            this.cmbCSR.Size = new System.Drawing.Size(300, 28);
            this.cmbCSR.TabIndex = 7;
            this.cmbCSR.Text = "Select CSR / NGO Initiative...";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtAddress.Location = new System.Drawing.Point(245, 280);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(300, 80);
            this.txtAddress.TabIndex = 6;
            this.txtAddress.Text = "Delivery Address (Will be AES Encrypted)";
            // 
            // lblDesignUpload
            // 
            this.lblDesignUpload.AutoSize = true;
            this.lblDesignUpload.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblDesignUpload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(35)))), ((int)(((byte)(91)))));
            this.lblDesignUpload.Location = new System.Drawing.Point(600, 90);
            this.lblDesignUpload.Name = "lblDesignUpload";
            this.lblDesignUpload.Size = new System.Drawing.Size(176, 21);
            this.lblDesignUpload.TabIndex = 5;
            this.lblDesignUpload.Text = "2. Label Design Assets";
            // 
            // picLogoPreview
            // 
            this.picLogoPreview.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picLogoPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLogoPreview.Location = new System.Drawing.Point(600, 130);
            this.picLogoPreview.Name = "picLogoPreview";
            this.picLogoPreview.Size = new System.Drawing.Size(150, 150);
            this.picLogoPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogoPreview.TabIndex = 4;
            this.picLogoPreview.TabStop = false;
            // 
            // btnBrowseLogo
            // 
            this.btnBrowseLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(154)))), ((int)(((byte)(77)))));
            this.btnBrowseLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseLogo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBrowseLogo.ForeColor = System.Drawing.Color.White;
            this.btnBrowseLogo.Location = new System.Drawing.Point(760, 130);
            this.btnBrowseLogo.Name = "btnBrowseLogo";
            this.btnBrowseLogo.Size = new System.Drawing.Size(150, 40);
            this.btnBrowseLogo.TabIndex = 3;
            this.btnBrowseLogo.Text = "📂 Upload Logo";
            this.btnBrowseLogo.UseVisualStyleBackColor = false;
            // 
            // txtDesignNotes
            // 
            this.txtDesignNotes.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtDesignNotes.Location = new System.Drawing.Point(600, 290);
            this.txtDesignNotes.Multiline = true;
            this.txtDesignNotes.Name = "txtDesignNotes";
            this.txtDesignNotes.Size = new System.Drawing.Size(310, 70);
            this.txtDesignNotes.TabIndex = 2;
            this.txtDesignNotes.Text = "Any design notes? (e.g., Include Dome symbol)";
            // 
            // btnSubmitOrder
            // 
            this.btnSubmitOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(35)))), ((int)(((byte)(91)))));
            this.btnSubmitOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitOrder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSubmitOrder.ForeColor = System.Drawing.Color.White;
            this.btnSubmitOrder.Location = new System.Drawing.Point(245, 400);
            this.btnSubmitOrder.Name = "btnSubmitOrder";
            this.btnSubmitOrder.Size = new System.Drawing.Size(300, 60);
            this.btnSubmitOrder.TabIndex = 1;
            this.btnSubmitOrder.Text = "🛒 Place Secure Order";
            this.btnSubmitOrder.UseVisualStyleBackColor = false;
            // 
            // pnlImpactCard
            // 
            this.pnlImpactCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(154)))), ((int)(((byte)(77)))));
            this.pnlImpactCard.Controls.Add(this.lblImpactValue);
            this.pnlImpactCard.Controls.Add(this.lblImpactTitle);
            this.pnlImpactCard.Location = new System.Drawing.Point(600, 380);
            this.pnlImpactCard.Name = "pnlImpactCard";
            this.pnlImpactCard.Size = new System.Drawing.Size(310, 80);
            this.pnlImpactCard.TabIndex = 0;
            // 
            // lblImpactValue
            // 
            this.lblImpactValue.AutoSize = true;
            this.lblImpactValue.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblImpactValue.ForeColor = System.Drawing.Color.White;
            this.lblImpactValue.Location = new System.Drawing.Point(10, 35);
            this.lblImpactValue.Name = "lblImpactValue";
            this.lblImpactValue.Size = new System.Drawing.Size(271, 30);
            this.lblImpactValue.TabIndex = 0;
            this.lblImpactValue.Text = "💧 1,200L Water Funded";
            // 
            // lblImpactTitle
            // 
            this.lblImpactTitle.AutoSize = true;
            this.lblImpactTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblImpactTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(35)))), ((int)(((byte)(91)))));
            this.lblImpactTitle.Location = new System.Drawing.Point(10, 10);
            this.lblImpactTitle.Name = "lblImpactTitle";
            this.lblImpactTitle.Size = new System.Drawing.Size(139, 15);
            this.lblImpactTitle.TabIndex = 1;
            this.lblImpactTitle.Text = "YOUR LIFETIME IMPACT";
            // 
            // ClientDashboard
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 550);
            this.Controls.Add(this.pnlImpactCard);
            this.Controls.Add(this.btnSubmitOrder);
            this.Controls.Add(this.txtDesignNotes);
            this.Controls.Add(this.btnBrowseLogo);
            this.Controls.Add(this.picLogoPreview);
            this.Controls.Add(this.lblDesignUpload);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.cmbCSR);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.cmbBottleSize);
            this.Controls.Add(this.lblOrderDetails);
            this.Controls.Add(this.pnlHeaderLine);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.pnlSidebar);
            this.Name = "ClientDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client - New Order";
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoPreview)).EndInit();
            this.pnlImpactCard.ResumeLayout(false);
            this.pnlImpactCard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Button btnNavNewOrder;
        private System.Windows.Forms.Button btnNavHistory;
        private System.Windows.Forms.Button btnNavPayments;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel pnlHeaderLine;

        private System.Windows.Forms.Label lblOrderDetails;
        private System.Windows.Forms.ComboBox cmbBottleSize;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.ComboBox cmbCSR;
        private System.Windows.Forms.TextBox txtAddress;

        private System.Windows.Forms.Label lblDesignUpload;
        private System.Windows.Forms.PictureBox picLogoPreview;
        private System.Windows.Forms.Button btnBrowseLogo;
        private System.Windows.Forms.TextBox txtDesignNotes;

        private System.Windows.Forms.Button btnSubmitOrder;
        private System.Windows.Forms.Panel pnlImpactCard;
        private System.Windows.Forms.Label lblImpactTitle;
        private System.Windows.Forms.Label lblImpactValue;
    }
}