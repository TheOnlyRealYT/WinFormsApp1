using System;

namespace WinFormsApp1
{
    public partial class MatchForm : Form
    {

        string pathToTeams = "D:\\Work\\game div\\WinFormsApp1\\teams.txt";
        FileStream fs;
        StreamReader sr;
        StreamWriter sw;
        int teamWon = 0;

        public MatchForm()
        {
            InitializeComponent();
        }

        private void UpdateTeamInFile(string id, string newName, string score, string wins, string losses, string goals)
        {
            string[] lines = File.ReadAllLines(pathToTeams);
            string line_ = "";
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i].Trim();
                if (line == null || line == " ") continue;
                string[] fields = line.Split('|');
                if (fields[0] == id)
                {
                    lines[i] = $"{id}|{newName}|{score}|{wins}|{losses}|{goals}";
                    for (int j = 0; j < 40; j++)
                    {
                        if (lines[j].Length >= 40) break;
                        lines[j] += " ";
                    }
                    break;
                }
                MessageBox.Show(fields[0] + " | " + id);
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


        private void DoubleSearch(string[] fields1, string[] fields2)
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] fields1 = new string[6];
            string[] fields2 = new string[6];
            DoubleSearch(fields1, fields2);
            MessageBox.Show($"Team 1: {fields1[1]} scored {textBox3.Text} goals.\nTeam 2: {fields2[1]} scored {textBox4.Text} goals.", "Match Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            UpdateTeamInFile(fields1[0], "fields1[1]",
                fields1[2],
                fields1[3],
                fields1[4],
                "10");
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
    }
}
