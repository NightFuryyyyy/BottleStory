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
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            string username = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();
            string loginResult = DBHelper.login(username, password);
        }
    }
}
