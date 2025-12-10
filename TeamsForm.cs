using FootballLeague;

namespace WinFormsApp1
{
    public partial class TeamsForm : Form
    {
        string pathToTeams = "D:\\Work\\game div\\WinFormsApp1\\teams.txt";

        int pId;
        public TeamsForm(int pid = -1)
        {
            InitializeComponent();
            textBox1.AppendText("ID\t| Team Name\t| Score\t| Wins\t| Loses\t| Goals");
            pId = pid;
        }

        //ID | Team Name      | Score | Wins | Loses | Goals
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            string[] lines = File.ReadAllLines(pathToTeams);
            if (string.IsNullOrWhiteSpace(lines[0]))
            {
                MessageBox.Show("No teams available.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            lines = lines.OrderByDescending(line => int.Parse(line.Split('|')[2].Trim())).ToArray();
            textBox1.AppendText("ID\t| Team Name\t| Score\t| Wins\t| Loses\t| Goals");
            foreach (string line in lines)
            {
                if (line[0] == '*') continue;
                string[] fields = line.Trim().Split('|');
                if (fields[1].Length < 9) fields[1] += "\t";
                if (int.Parse(fields[0]) == pId)
                    textBox1.AppendText($"\r\n>> {fields[0]}\t| {fields[1]}\t| " +
                    $"{fields[2]}\t| {fields[3]}\t| {fields[4]}\t| {fields[5]} <<");
                else
                    textBox1.AppendText($"\r\n{fields[0]}\t| {fields[1]}\t| " +
                    $"{fields[2]}\t| {fields[3]}\t| {fields[4]}\t| {fields[5]}");
            }
        }

        private void TeamsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
