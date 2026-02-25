namespace BottleStory
{
    partial class AdminPayments
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

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlHeaderLine = new System.Windows.Forms.Panel();
            this.dgvAdminPayments = new System.Windows.Forms.DataGridView();
            this.btnMarkPaid = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminPayments)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(35)))), ((int)(((byte)(91)))));
            this.lblTitle.Location = new System.Drawing.Point(18, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(317, 32);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Admin - Payment Tracking";
            // 
            // pnlHeaderLine
            // 
            this.pnlHeaderLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(154)))), ((int)(((byte)(77)))));
            this.pnlHeaderLine.Location = new System.Drawing.Point(24, 70);
            this.pnlHeaderLine.Name = "pnlHeaderLine";
            this.pnlHeaderLine.Size = new System.Drawing.Size(830, 4);
            this.pnlHeaderLine.TabIndex = 2;
            // 
            // dgvAdminPayments
            // 
            this.dgvAdminPayments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAdminPayments.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(35)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(35)))), ((int)(((byte)(91)))));
            this.dgvAdminPayments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAdminPayments.EnableHeadersVisualStyles = false;
            this.dgvAdminPayments.Location = new System.Drawing.Point(24, 100);
            this.dgvAdminPayments.Name = "dgvAdminPayments";
            this.dgvAdminPayments.Size = new System.Drawing.Size(830, 300);
            this.dgvAdminPayments.TabIndex = 1;
            // 
            // btnMarkPaid
            // 
            this.btnMarkPaid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(154)))), ((int)(((byte)(77)))));
            this.btnMarkPaid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarkPaid.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnMarkPaid.ForeColor = System.Drawing.Color.White;
            this.btnMarkPaid.Location = new System.Drawing.Point(24, 420);
            this.btnMarkPaid.Name = "btnMarkPaid";
            this.btnMarkPaid.Size = new System.Drawing.Size(200, 45);
            this.btnMarkPaid.TabIndex = 0;
            this.btnMarkPaid.Text = "✅ Mark as Paid";
            this.btnMarkPaid.UseVisualStyleBackColor = false;
            // 
            // AdminPayments
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(880, 500);
            this.Controls.Add(this.btnMarkPaid);
            this.Controls.Add(this.dgvAdminPayments);
            this.Controls.Add(this.pnlHeaderLine);
            this.Controls.Add(this.lblTitle);
            this.Name = "AdminPayments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Payments";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminPayments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlHeaderLine;
        private System.Windows.Forms.DataGridView dgvAdminPayments;
        private System.Windows.Forms.Button btnMarkPaid;
    }
}