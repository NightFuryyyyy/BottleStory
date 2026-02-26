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
                textBox1.Text = "";
                textBox2.Text = "";
                Hide();
                AdminDashboard adminDashboard = new AdminDashboard();
                adminDashboard.FormClosed += (s, argd) => Show();
                adminDashboard.Show();
            }
            if (loginResult == "user") {
                textBox1.Text = "";
                textBox2.Text = "";
                Hide();
                ClientDashboard clientDashboard = new ClientDashboard();
                clientDashboard.FormClosed += (s, argd) => Show();
                clientDashboard.Show();
            }
            if (loginResult == "Username not found!") {
                label3.Text = loginResult;
            } else if (loginResult == "Incorrect password!") {
                label3.Text = loginResult;
            }
        }
    }
}
