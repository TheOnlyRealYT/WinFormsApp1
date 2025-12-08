namespace WinFormsApp1
{
    public partial class TeamsForm : Form
    {
        string pathToTeams = "D:\\Work\\game div\\WinFormsApp1\\teams.txt";
        FileStream? League_fs;
        StreamReader? League_sr;
        StreamWriter? league_sw;
        int pId;
        public TeamsForm(int pid = -1)
        {
            InitializeComponent();
            pId = pid;
        }

        //ID | Team Name      | Score | Wins | Loses | Goals
        private void button1_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(pathToTeams);
            lines = lines.OrderByDescending(line => int.Parse(line.Split('|')[2].Trim())).ToArray();
            foreach (string line in lines)
            {
                string[] fields = line.Trim().Split('|');
                textBox1.AppendText($"\r\n{fields[0]}\t| {fields[1]}\t| " +
                    $"{fields[2]}\t| {fields[3]}\t| {fields[4]}\t| {fields[5]}");
            }
        }

        private void TeamsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
