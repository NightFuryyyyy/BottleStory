using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BottleStory {
    public partial class AdminDashboard : Form {

        Size panelSize = new Size(722, 526);
        public AdminDashboard() {
            InitializeComponent();
        }

        private void btnNavImpact_Click(object sender, EventArgs e) {

        }

        private void btnNavDash_Click(object sender, EventArgs e) {
            panel1.Size = panelSize;
            panel1.Visible = true;
            panel2.Visible = false;
        }

        private void btnNavOrders_Click(object sender, EventArgs e) {
            panel2.Size = panelSize;
            panel2.Location = panel1.Location;
            panel2.Visible = true;
            panel1.Visible = false;
        }

        private void AdminDashboard_Load(object sender, EventArgs e) {
            panel1.Size = panelSize;
            panel1.Visible = true;
        }
    }
}
