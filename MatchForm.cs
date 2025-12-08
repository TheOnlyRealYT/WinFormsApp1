using FootballLeague;
using System;

namespace WinFormsApp1
{
    public partial class MatchForm : Form
    {

        string pathToTeams = "D:\\Work\\game div\\WinFormsApp1\\teams.txt";
        FileStream? fs;
        StreamReader? sr;
        StreamWriter? sw;
        int teamWon = 0;

        public MatchForm()
        {
            InitializeComponent();
        }

        private void UpdateTeamInFile(string id, string newName, int score, int wins, int losses, int goals)
        {
            string[] lines = File.ReadAllLines(pathToTeams);
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i].Trim();
                if (line == null || line == " ") continue;
                string[] fields = line.Split('|');
                if (fields[0] == id)
                {
                    lines[i] = $"{id}|{newName}|{score}|{wins}|{losses}|{goals}";
                    if (lines[i].Length < 40)
                    {
                        for (int j = lines[i].Length; j < 39; j++)
                        {
                            lines[i] += " ";
                        }
                    }
                    else if (lines[i].Length > 40)
                    {
                        lines[i] = lines[i].Substring(0, 39); //to cut if its too long :yum::thumbes-up:
                    }
                    break;
                }
            }
            fs = new FileStream(pathToTeams, FileMode.Truncate, FileAccess.Write);
            sw = new StreamWriter(fs);
            foreach (string line in lines)
            {
                sw.WriteLine(line);
            }
            sw.Flush();
            sw.Close();
            fs.Close();
        }


        private bool DoubleSearch(string[] fields1, string[] fields2)
        {
            bool successFlag = true;
            fs = new FileStream(pathToTeams, FileMode.Open, FileAccess.ReadWrite);
            sr = new StreamReader(fs);
            string? line;
            while (true)
            {
                line = sr.ReadLine();
                if (line == null) { successFlag = false; break; }
                line.Trim().Split('|').CopyTo(fields1, 0);
                if (int.Parse(fields1[0]) == int.Parse(textBox1.Text)) break;
            }
            sr.DiscardBufferedData();
            fs.Seek(0, SeekOrigin.Begin);
            while (true)
            {
                line = sr.ReadLine();
                if (line == null) { successFlag = false; break; }
                line.Trim().Split('|').CopyTo(fields2, 0);
                if (int.Parse(fields2[0]) == int.Parse(textBox2.Text)) break;
            }
            if (!successFlag)
            {
                MessageBox.Show("One of the IDs was not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            sr.Close();
            fs.Close();
            return successFlag;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] fields1 = new string[6];
            string[] fields2 = new string[6];
            bool successFlag = DoubleSearch(fields1, fields2);
            if (!successFlag) return;
            int t1goals = int.Parse(textBox3.Text);
            int t2goals = int.Parse(textBox4.Text);
            MessageBox.Show($"Team 1: {fields1[1]} scored {t1goals} goals.\nTeam 2: {fields2[1]} scored {t2goals} goals.", "Match Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (t1goals > t2goals)
            {
                UpdateTeamInFile(fields1[0], fields1[1], int.Parse(fields1[2]) + 3, int.Parse(fields1[3]) + 1, int.Parse(fields1[4]) + 0, int.Parse(fields1[5]) + t1goals);
                UpdateTeamInFile(fields2[0], fields2[1], int.Parse(fields2[2]) + 0, int.Parse(fields1[3]) + 0, int.Parse(fields2[4]) + 1, int.Parse(fields2[5]) + t2goals);
            }
            else if (t1goals < t2goals)
            {
                UpdateTeamInFile(fields1[0], fields1[1], int.Parse(fields1[2]) + 0, int.Parse(fields1[3]) + 0, int.Parse(fields1[4]) + 1, int.Parse(fields1[5]) + t1goals);
                UpdateTeamInFile(fields2[0], fields2[1], int.Parse(fields2[2]) + 3, int.Parse(fields1[3]) + 1, int.Parse(fields2[4]) + 0, int.Parse(fields2[5]) + t2goals);
            }
            else
            {
                UpdateTeamInFile(fields1[0], fields1[1], int.Parse(fields1[2]) + 1, int.Parse(fields1[3]) + 0, int.Parse(fields1[4]) + 0, int.Parse(fields1[5]) + t1goals);
                UpdateTeamInFile(fields2[0], fields2[1], int.Parse(fields2[2]) + 1, int.Parse(fields1[3]) + 0, int.Parse(fields2[4]) + 0, int.Parse(fields2[5]) + t2goals);
            }
            MessageBox.Show("Team statistics updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            textBox3.Text = rand.Next(0, 9).ToString();
            textBox4.Text = rand.Next(0, 9).ToString();
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

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox4.Focus();
            }
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TeamsForm teamsForm = new TeamsForm();
            teamsForm.Show();
            this.Hide();
        }
    }
}
