using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;
using StudentInfoSystem;

namespace BottleStory {
    public partial class Login : Form {
        public Login() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            string username = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();
            string loginResult = DBHelper.login(username, password);
            if (loginResult == "admin") {
                new AdminDashboard().Show();
            }
            if (loginResult == "user") {
                new ClientDashboard().Show();
            }
            if (loginResult == "Username not found!") {
                label3.Text = loginResult;
            } else if (loginResult == "Incorrect password!") {
                label3.Text = loginResult;
            }
        }
    }
}
