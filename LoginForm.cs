using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;
using AdminNewInterface;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FootballLeague
{
    public partial class LoginForm : Form
    {
        string pathToPlayers = "C:\\Users\\moham\\Source\\Repos\\WinFormsApp1\\players.txt";
        FileStream? fs;
        StreamReader? sr;
        string adminId = "0";
        string adminPassword = "123";
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string pass = textBox2.Text;
            if (id == adminId && pass == adminPassword)
            {
                MessageBox.Show("Welcome Admin");
                AdminForm admin = new AdminForm();
                admin.Show();
                this.Hide();
            }
            else
            {
                fs = new FileStream(pathToPlayers, FileMode.Open, FileAccess.ReadWrite);
                sr = new StreamReader(fs);
                string? line;
                string[] fields = new string[4];
                while (true)
                {
                    line = sr.ReadLine();
                    if (line == null) break;
                    line.Split('|').CopyTo(fields, 0);
                    if (int.Parse(fields[0]) != int.Parse(textBox1.Text)) continue;
                    if (fields[2] != textBox2.Text)
                    {
                        MessageBox.Show("Invalid Password, Try Again.", "Invalid Password",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        fs.Close();
                        sr.Close();
                        return;
                    }
                    TeamsForm player = new TeamsForm(int.Parse(fields[3]));
                    player.Show();
                    this.Hide();
                    fs.Close();
                    sr.Close();
                    return;
                }
                MessageBox.Show("Invalid ID, if you dont have an account enter as a guest.",
                    "Player Doesnt Exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
                fs.Close();
                sr.Close();
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBox2.Focus();
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TeamsForm player = new TeamsForm();
            player.Show();
            this.Hide();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
