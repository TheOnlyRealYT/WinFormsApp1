using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Formats.Tar;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootballLeague
{
    public partial class AddPlayer : Form
    {
        FileStream AddPlayerFile;
        StreamWriter sw;
        StreamReader sr;
        int player_id = 1;
        int fixedlen = 39;

        FileStream TeamFile;
        StreamReader TR;

        public AddPlayer()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string teamFile = @"D:\Work\game div\WinFormsApp1\teams.txt";
            player_id = 1;

            TeamFile = new FileStream(teamFile, FileMode.Open, FileAccess.Read);
            TR = new StreamReader(TeamFile);
            TeamFile.Seek(0, SeekOrigin.Begin);
            string? readTeam = TR.ReadLine();
            string[] field;
            string teamNum;
            bool flag = true;

            while (readTeam != null)
            {
                field = readTeam.Split('|');
                readTeam = TR.ReadLine();
                teamNum = field[0];
                if (teamNum == textBox3.Text)
                {
                    flag = true;
                    break;
                }
                else
                {
                    flag = false;
                }
            }
            if (flag == false)
            {
                MessageBox.Show("This team ID doesn't exist.");
                return;
            }

            TR.Close();
            TeamFile.Close();

            string addFile = @"D:\Work\game div\WinFormsApp1\players.txt";
            AddPlayerFile = new FileStream(addFile, FileMode.Open, FileAccess.Read);
            sr = new StreamReader(AddPlayerFile);
            string? read = sr.ReadLine();

            while (read != null)
            {
                read = sr.ReadLine();


                player_id++;
            }
            sr.Close();

            string record = Convert.ToString(player_id) + "|" + textBox1.Text + "|" + textBox2.Text + "|" + textBox3.Text;
            int recordlen = record.Length;

            while (recordlen > fixedlen)
            {

                if (recordlen > fixedlen)
                {
                    int dif = recordlen - fixedlen;
                    MessageBox.Show("Record is too long, please remove " + dif + " charachters.");

                }
                return;


            }

            if (textBox1.TextLength == 0)
            {
                MessageBox.Show("First Name is empty, Please add a Name.");
                return;

            }
            else if (textBox3.TextLength == 0)
            {
                MessageBox.Show("Team ID is empty, Please add an ID.");
                return;

            }
            else if (textBox2.TextLength == 0)
            {
                MessageBox.Show("Password is empty, Please add a Password.");
                return;
            }

            string s;
            s = record;
            while (s.Length < fixedlen)
            {
                s += " ";
            }
            AddPlayerFile = new FileStream(addFile, FileMode.Append, FileAccess.Write);
            sw = new StreamWriter(AddPlayerFile);
            sw.WriteLine(s);
            sw.Flush();
            sw.Close();

            MessageBox.Show("Player " + textBox1.Text + " " + "with ID " + player_id + " " + "Has been added.");
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1_Click(sender, e);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox2.Focus();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox3.Focus();
            }
        }
    }
}
