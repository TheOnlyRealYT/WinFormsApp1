using System.Xml.Linq;
using static System.Windows.Forms.AxHost;

namespace AdminNewInterface
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
           search.Enabled = false;
            Insert.Enabled = false;
            read.Enabled = false;
        }
        FileStream teamfile;
        StreamReader teamReader;
        StreamWriter teamWriter;
        string filepath = "C:\\Users\\Iway\\Downloads\\teams (1).txt";
        TextBox team_id;
        TextBox ShowRecord;
        TextBox team_name;
        TextBox team_score;
        TextBox team_wins;
        TextBox team_loses;
        TextBox team_goals;
        Button AddRec;
        Button ShowNext;
        TextBox Showinfo;
        Button RemoveRec;
        Button rename;
        private void open_Click(object sender, EventArgs e)
        {
            teamfile = new FileStream(filepath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            teamReader = new StreamReader(teamfile);
            teamWriter = new StreamWriter(teamfile);
          MessageBox.Show("File opened successfully.");
            search.Enabled = true;
            Insert.Enabled = true;
            read.Enabled = true;
        }

        private void search_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            Label l1 = new Label();   l1.Text = "Enter ID:";  l1.Location = new Point(20, 20); l1.AutoSize = true;
            splitContainer1.Panel2.Controls.Add(l1); l1.Font = new Font("Arial", 14, FontStyle.Regular);

            team_id = new TextBox(); team_id.Location = new Point(220, 20); team_id.Font = new Font("Arial", 12, FontStyle.Regular);
            team_id.KeyDown += Team_id_KeyDown;  splitContainer1.Panel2.Controls.Add(team_id); team_id.Width = 220;

            ShowRecord = new TextBox();
            ShowRecord.Location = new Point(20, 60);  ShowRecord.Multiline = true;
            ShowRecord.Width = 600;  ShowRecord.Height = 350; ShowRecord.Font = new Font("Arial", 12, FontStyle.Regular);
            splitContainer1.Panel2.Controls.Add(ShowRecord);

            RemoveRec = new Button(); RemoveRec.Text = "Remove Record"; 
            RemoveRec.Location = new Point(20, 420); RemoveRec.Width = 310; RemoveRec.Height = 50;
            splitContainer1.Panel2.Controls.Add(RemoveRec);
            RemoveRec.Click += RemoveRec_Click;

            rename = new Button(); rename.Text = "Rename Team";
            rename.Location = new Point(310, 420); rename.Width = 310; rename.Height = 50;
            splitContainer1.Panel2.Controls.Add(rename); rename.Click += rename_Click;
        }
        private void rename_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            Label l1 = new Label(); l1.Text = "Enter new team name:"; l1.AutoSize = true; l1.Font = new Font("Arial", 14, FontStyle.Regular);
            l1.Location = new Point( 20, 180); splitContainer1.Panel2.Controls.Add(l1);

            TextBox new_team_name = new TextBox(); new_team_name.Location = new Point(300, 180);
            splitContainer1.Panel2.Controls.Add(new_team_name); new_team_name.Width = 220; new_team_name.Font = new Font("Arial", 12, FontStyle.Regular);

            Button submit = new Button(); submit.Text = "Rename Record"; submit .Location = new Point(200, 250);
            splitContainer1.Panel2.Controls.Add(submit); submit.Click +=submit_Click; submit.Width = 150; submit.Height = 50;
        }
        private void submit_Click(object sender, EventArgs e)
        {

            if (teamfile == null)
            {
                MessageBox.Show("Please open the file first.");
                return;
            }
            string id = team_id.Text.Trim();
            string newName = ((TextBox)splitContainer1.Panel2.Controls[1]).Text.Trim();
            teamfile.Seek(0, SeekOrigin.Begin);
            teamReader.DiscardBufferedData();
            List<string> lines = new List<string>();
            string line;
            while ((line = teamReader.ReadLine()) != null)
            {
                if (string.IsNullOrWhiteSpace(line))
                {
                    lines.Add(line);
                    continue;
                }
                string[] fields = line.Split('|');
                if (fields[0] == id)
                {
                    fields[1] = newName; 
                }
                lines.Add(string.Join("|", fields));
            }
            teamfile.SetLength(0); 
            foreach (var l in lines)
            {
                teamWriter.WriteLine(l);
            }
            teamWriter.Flush();
            MessageBox.Show("Record renamed successfully.");
        }
        private void RemoveRec_Click(object sender, EventArgs e )
        { if (teamfile == null)
            {
                MessageBox.Show("Please open the file first.");
                return;
            }

            string id = team_id.Text.Trim();

            teamfile.Seek(0, SeekOrigin.Begin);
            teamReader.DiscardBufferedData();

            List<string> lines = new List<string>();
            string line;

            while ((line = teamReader.ReadLine()) != null)
            {
                if (string.IsNullOrWhiteSpace(line))
                {
                    lines.Add(line);
                    continue;
                }

                string[] fields = line.Split('|');

                if (fields[0] == id)
                {
                    fields[0] = "*"; 
                }

                lines.Add(string.Join("|", fields));
            }

            teamfile.SetLength(0); 
            foreach (var l in lines)
            {
                teamWriter.WriteLine(l);
            }
            teamWriter.Flush();
            MessageBox.Show("Record deleted .");
        }

        private void Team_id_KeyDown(object sender, KeyEventArgs e)
        {   if (teamfile == null)
            {
                MessageBox.Show("Please open the file first.");
                return;
            }

            if (teamfile == null)
            {
                MessageBox.Show("Please open the file first.");
                return;
            }
            if (e.KeyCode == Keys.Enter)
            {
                teamfile.Seek(0, SeekOrigin.Begin);
                teamReader.DiscardBufferedData();

                string record;
                while ((record = teamReader.ReadLine()) != null)
                {
                    if (string.IsNullOrWhiteSpace(record)) continue;

                    string[] field = record.Split('|');
                    int storedID;
                    if (!int.TryParse(field[0].Trim(), out storedID)) continue;

                    if (storedID == int.Parse(team_id.Text.Trim()))
                    {
                        ShowRecord.Text = "Team ID:" + field[0] + "\r\n" +
                                          "Team Name:" + field[1] + "\r\n" +
                                          "Team Score:" + field[2] + "\r\n" +
                                          "Team Wins:" + field[3] + "\r\n" +
                                          "Team Loses:" + field[4] + "\r\n" +
                                          "Team Goals:" + field[5] + "\r\n";
                        return;
                    }
                }
                if (record == null)
                {
                    MessageBox.Show("Record not found.");
                }
            }
           
        }            
        private void Insert_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            Label l1 = new Label(); l1.Text = "Enter team name:"; l1.AutoSize = true;
            l1.Location = new Point(50, 20); splitContainer1.Panel2.Controls.Add(l1); l1.Font = new Font("Arial", 14, FontStyle.Regular); 

            Label l2 = new Label(); l2.Text = "Enter team score:"; l2.AutoSize = true;
            l2.Location = new Point(50, 70); splitContainer1.Panel2.Controls.Add(l2); l2.Font = new Font("Arial", 14, FontStyle.Regular);

            Label l3 = new Label(); l3.Text = "Enter team Wins:"; l3.AutoSize = true;
            l3.Location = new Point(50, 120); splitContainer1.Panel2.Controls.Add(l3); l3.Font = new Font("Arial", 14, FontStyle.Regular);

            Label l4 = new Label(); l4.Text = "Enter team Loses:"; l4.AutoSize = true;
            l4.Location = new Point(50, 170); splitContainer1.Panel2.Controls.Add(l4); l4.Font = new Font("Arial", 14, FontStyle.Regular);

            Label l5 = new Label(); l5.Text = "Enter team Goals:"; l5.AutoSize = true;
            l5.Location = new Point(50, 220); splitContainer1.Panel2.Controls.Add(l5);l5.Font = new Font("Arial", 14, FontStyle.Regular);


            team_name = new TextBox(); team_name.Location = new Point(350, 20); team_name.Width = 220; team_name.Font = new Font("Arial", 12, FontStyle.Regular);
            splitContainer1.Panel2.Controls.Add(team_name); team_name.KeyDown += Team_name_KeyDown;
            team_score = new TextBox(); team_score.Location = new Point(350, 70); team_score.Width = 220; team_score.Font = new Font("Arial", 12, FontStyle.Regular);
            splitContainer1.Panel2.Controls.Add(team_score); team_score.KeyDown += Team_score_KeyDown;
            team_wins = new TextBox(); team_wins.Location = new Point(350, 120); team_wins.Width = 220; team_wins.Font = new Font("Arial", 12, FontStyle.Regular);
            splitContainer1.Panel2.Controls.Add(team_wins); team_wins.KeyDown += Team_wins_KeyDown;
            team_loses = new TextBox(); team_loses.Location = new Point(350, 170); team_loses.Width = 220; team_loses.Font = new Font("Arial", 12, FontStyle.Regular);
            splitContainer1.Panel2.Controls.Add(team_loses); team_loses.KeyDown += Team_loses_KeyDown;
            team_goals = new TextBox(); team_goals.Location = new Point(350, 220); team_goals.Width = 220; team_goals.Font = new Font("Arial", 12, FontStyle.Regular);
            splitContainer1.Panel2.Controls.Add(team_goals);

            AddRec = new Button(); AddRec.Text = "Add Record"; AddRec.Location = new Point(200, 350);
            splitContainer1.Panel2.Controls.Add(AddRec); AddRec.Click += AddRec_Click; AddRec.Width = 150;  AddRec.Height = 50;


        }
        private void Team_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                team_score.Focus();
            }
        }
        private void Team_score_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                team_wins.Focus();
            }
        }
        private void Team_wins_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                team_loses.Focus();
            }
        }
        private void Team_loses_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                team_goals.Focus();
            }
        }
        private void AddRec_Click(object sender, EventArgs e)
        {
            if (teamfile == null)
            {
                MessageBox.Show("Please open the file first.");
                return;
            }
            teamfile.Seek(0, SeekOrigin.Begin);
            teamReader.DiscardBufferedData();

            int count = 0;
            string line;
            while ((line = teamReader.ReadLine()) != null)
            {
                count++;
            }
            teamfile.Seek(0, SeekOrigin.End);
            int autoid = (count * 2) + 10;
            if ((team_name.Text == "") || (team_score.Text == "") || (team_wins.Text == "") || (team_loses.Text == "") || (team_goals.Text == ""))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            else
            {
                string newRecord = autoid.ToString() + "|" + team_name.Text + "|" + team_score.Text + "|" + team_wins.Text + "|" + team_loses.Text + "|" + team_goals.Text;
                teamWriter.WriteLine(newRecord);
                teamWriter.Flush();
                MessageBox.Show("Record Added Successfully with ID: " + autoid.ToString());
                team_name.Clear();
                team_score.Clear();
                team_wins.Clear();
                team_loses.Clear();
                team_goals.Clear();
                team_name.Focus();
            }
        }
        private void read_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();

            if (teamfile == null)
            {
                MessageBox.Show("Please open the file first.");
                return;
            }
            Label l1 = new Label(); l1.Text = "Read Team Info"; l1.AutoSize = true;
            l1.Location = new Point(220, 20); splitContainer1.Panel2.Controls.Add(l1); l1.Font = new Font("Arial", 16, FontStyle.Regular);
            Showinfo = new TextBox();  Showinfo. Location = new Point(10, 60);splitContainer1.Panel2.Controls.Add(Showinfo);
            Showinfo.Multiline = true; Showinfo.Width = 600; Showinfo.Height = 350; Showinfo.Font = new Font("Arial", 12, FontStyle.Regular);

            ShowNext = new Button(); ShowNext.Width = 310; ShowNext.Height = 50; splitContainer1.Panel2.Controls.Add(ShowNext);
            ShowNext.Text = "Show the next team"; ShowNext.Location = new Point(160,420); ShowNext.Click += ShowNext_Click;
        }
        private void ShowNext_Click(object sender, EventArgs e)
        {
            if (teamfile == null)
            {
                MessageBox.Show("Please open the file first.");
                return;
            }
            string record = teamReader.ReadLine();
            string[] field;
            if (record != null)
            {
                if (record[0] == '*')
                    return;
                field = record.Split('|');
                Showinfo.Text = "Team ID:" + field[0] + "\r\n" +
                                          "Team Name:" + field[1] + "\r\n" +
                                          "Team Score:" + field[2] + "\r\n" +
                                          "Team Wins:" + field[3] + "\r\n" +
                                          "Team Loses:" + field[4] + "\r\n" +
                                          "Team Goals:" + field[5] + "\r\n";
                return;
            }
        }
    }
}

