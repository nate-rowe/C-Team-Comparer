using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Net;

namespace StatsComparerThingy
{
    public partial class Form1 : Form
    {
        public Dictionary<string, Dictionary<string, string>> teams = new Dictionary<string, Dictionary<string, string>>();

        public Dictionary<string, bool> display = new Dictionary<string, bool>();

        List<string> teamsList = new List<string>();

        public DataTable dt = new DataTable();

        int year = DateTime.Now.Year;

        string teamNameColumnHeader = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbTeam1.Enabled = false;
            cmbTeam2.Enabled = false;
            btnAddRemoveStats.Enabled = false;
            dataGridView1.DataSource = dt;
        }

        private async Task loadKenPomAsync()
        {
            var url = "https://kenpom.com/";

            var httpClient = new HttpClient();
            var html = await httpClient.GetStringAsync(url);

            var htmlDocument = new HtmlAgilityPack.HtmlDocument();
            htmlDocument.LoadHtml(html);

            var htmlNodes = htmlDocument.DocumentNode.SelectNodes("//tbody/tr");

            foreach (var tr in htmlNodes)
            {
                var children = tr.ChildNodes.ToList();

                string teamName = children[2].InnerText;

                var updatedName = teamName.Split(' ');
                if (updatedName.Last().Any(char.IsDigit))
                {
                    Array.Resize(ref updatedName, updatedName.Length - 1);
                    teamName = String.Join(" ", updatedName);
                }

                string rank = children[1].InnerText;
                string conf = children[3].InnerText;
                string winloss = children[4].InnerText;
                string adjEM = children[5].InnerText;
                string adjO = children[6].InnerText;
                string adjORank = children[7].InnerText;
                string adjD = children[8].InnerText;
                string adjDRank = children[9].InnerText;
                string adjT = children[10].InnerText;
                string adjTrank = children[11].InnerText;
                string luck = children[12].InnerText;
                string luckRank = children[13].InnerText;
                string sos = children[15].InnerText;
                string oppO = children[16].InnerText + " (" + children[17].InnerText + ")";
                string oppD = children[18].InnerText + " (" + children[19].InnerText + ")";

                if (!teams.ContainsKey(teamName))
                {
                    teams.Add(teamName, new Dictionary<string, string>());
                }

                teams[teamName].Add("Rank", rank);
                teams[teamName].Add("Conf", conf);
                teams[teamName].Add("W-L", winloss);
                teams[teamName].Add("AdjEM", adjEM);
                teams[teamName].Add("AdjO (Rank)", adjO + " (" + adjORank + ")");
                teams[teamName].Add("AdjD (Rank)", adjD + " (" + adjDRank + ")");
                teams[teamName].Add("AdjT (Rank)", adjT + " (" + adjTrank + ")");
                teams[teamName].Add("Luck (Rank)", luck + " (" + luckRank + ")");
                teams[teamName].Add("SOS", sos);
                teams[teamName].Add("Opp. AdjO (Rank)", oppO);
                teams[teamName].Add("Opp. AdjD (Rank)", oppD);
            }

            foreach (var team in teams)
            {
                teamsList.Add(team.Key.ToString());
            }

            display.Add("Rank", true);
            display.Add("Conf", true);
            display.Add("W-L", true);
            display.Add("AdjEM", true);
            display.Add("AdjO (Rank)", true);
            display.Add("AdjD (Rank)", true);
            display.Add("AdjT (Rank)", true);
            display.Add("Luck (Rank)", true);
            display.Add("SOS", true);
            display.Add("Opp. AdjO (Rank)", true);
            display.Add("Opp. AdjD (Rank)", true);

            teamsList.Sort();
            cmbTeam1.Items.AddRange(teamsList.ToArray());
            cmbTeam2.Items.AddRange(teamsList.ToArray());
        }

        private async Task loadbasketballReferenceAdvancedStatsAsync()
        {
            var url = "https://www.sports-reference.com/cbb/seasons/" + year + "-advanced-school-stats.html";

            var httpClient = new HttpClient();
            var html = await httpClient.GetStringAsync(url);

            var htmlDocument = new HtmlAgilityPack.HtmlDocument();
            htmlDocument.LoadHtml(html);

            var htmlNodes = htmlDocument.DocumentNode.SelectNodes("//tbody/tr");

            foreach (var tr in htmlNodes)
            {
                if (tr.FirstChild.Name != "#text")
                {
                    var children = tr.ChildNodes.ToList();

                    string teamName = children[1].InnerText.ToString();

                    string formattedTeamName = formatBasketballReferenceTeamName(teamName);

                    if (teams.ContainsKey(formattedTeamName)) // Only add stats for teams found by Kenpom
                    {
                        string totalPointsScored = children[18].InnerText;
                        string OppTotalPointsScored = children[19].InnerText;
                        string pace = children[21].InnerText;
                        string ORtg = children[22].InnerText;
                        string FTr = children[23].InnerText;
                        string threePointRate = children[24].InnerText;
                        string BlockPercentage = children[29].InnerText;
                        string assistPercentage = children[27].InnerText;
                        string stealPercentage = children[28].InnerText;
                        string eFG = children[30].InnerText;
                        string TOPercentage = children[31].InnerText;
                        string offRBPercentage = children[32].InnerText;

                        teams[formattedTeamName].Add("Pts scored", totalPointsScored);
                        teams[formattedTeamName].Add("Opp. pts scored", OppTotalPointsScored);
                        teams[formattedTeamName].Add("Pace", pace);
                        teams[formattedTeamName].Add("ORtg", ORtg);
                        teams[formattedTeamName].Add("FT/FGA", FTr);
                        teams[formattedTeamName].Add("3PT/FGA", threePointRate);
                        teams[formattedTeamName].Add("BLK%", BlockPercentage);
                        teams[formattedTeamName].Add("AST%", assistPercentage);
                        teams[formattedTeamName].Add("STL%", stealPercentage);
                        teams[formattedTeamName].Add("eFG%", eFG);
                        teams[formattedTeamName].Add("TO%", TOPercentage);
                        teams[formattedTeamName].Add("ORB%", offRBPercentage);
                    }
                }
            }

            display.Add("Pts scored", true);
            display.Add("Opp. pts scored", true);
            display.Add("Pace", true);
            display.Add("ORtg", true);
            display.Add("FT/FGA", true);
            display.Add("3PT/FGA", true);
            display.Add("BLK%", true);
            display.Add("AST%", true);
            display.Add("STL%", true);
            display.Add("eFG%", true);
            display.Add("TO%", true);
            display.Add("ORB%", true);
        }

        private async Task loadbasketballReferenceBasicStatsAsync()
        {
            var url = "https://www.sports-reference.com/cbb/seasons/" + year + "-school-stats.html";

            var httpClient = new HttpClient();
            var html = await httpClient.GetStringAsync(url);

            var htmlDocument = new HtmlAgilityPack.HtmlDocument();
            htmlDocument.LoadHtml(html);

            var htmlNodes = htmlDocument.DocumentNode.SelectNodes("//tbody/tr");

            foreach (var tr in htmlNodes)
            {
                if (tr.FirstChild.Name != "#text")
                {
                    var children = tr.ChildNodes.ToList();

                    string teamName = children[1].InnerText.ToString();

                    string formattedTeamName = formatBasketballReferenceTeamName(teamName);

                    if (teams.ContainsKey(formattedTeamName)) // Only add stats for teams found by Kenpom
                    {
                        string homeWL = children[12].InnerText + "-" + children[13].InnerText;
                        string awayWL = children[15].InnerText + "-" + children[16].InnerText;
                        string fgAttempted = children[23].InnerText;
                        string fgPercentage = children[24].InnerText;
                        string threePtAttempts = children[26].InnerText;
                        string threePtPercentage = children[27].InnerText;

                        teams[formattedTeamName].Add("Home W-L", homeWL);
                        teams[formattedTeamName].Add("Away W-L", awayWL);
                        teams[formattedTeamName].Add("FGA", fgAttempted);
                        teams[formattedTeamName].Add("FG%", fgPercentage);
                        teams[formattedTeamName].Add("3PA", threePtAttempts);
                        teams[formattedTeamName].Add("3P%", threePtPercentage);

                    }
                }
            }

            display.Add("Home W-L", true);
            display.Add("Away W-L", true);
            display.Add("FGA", true);
            display.Add("FG%", true);
            display.Add("3PA", true);
            display.Add("3P%", true);
        }

        private async Task loadbasketballReferenceAdvanceddOpponentStatsAsync()
        {
            var url = "https://www.sports-reference.com/cbb/seasons/" + year + "-advanced-opponent-stats.html";

            var httpClient = new HttpClient();
            var html = await httpClient.GetStringAsync(url);

            var htmlDocument = new HtmlAgilityPack.HtmlDocument();
            htmlDocument.LoadHtml(html);

            var htmlNodes = htmlDocument.DocumentNode.SelectNodes("//tbody/tr");

            foreach (var tr in htmlNodes)
            {
                if (tr.FirstChild.Name != "#text")
                {
                    var children = tr.ChildNodes.ToList();

                    string teamName = children[1].InnerText.ToString();

                    string formattedTeamName = formatBasketballReferenceTeamName(teamName);

                    if (teams.ContainsKey(formattedTeamName)) // Only add stats for teams found by Kenpom
                    {
                        string oppPace = children[21].InnerText;
                        string oppThreePtRate = children[24].InnerText;
                        string oppEFGPercentage = children[30].InnerText;
                        string oppTOPercentage = children[31].InnerText;
                        string oppORB = children[32].InnerText;

                        teams[formattedTeamName].Add("Opp. Pace", oppPace);
                        teams[formattedTeamName].Add("Opp. 3pt/FGA", oppThreePtRate);
                        teams[formattedTeamName].Add("Opp. eFG%", oppEFGPercentage);
                        teams[formattedTeamName].Add("Opp. TO%", oppTOPercentage);
                        teams[formattedTeamName].Add("Opp. ORB%", oppORB);
                    }
                }
            }

            display.Add("Opp. Pace", true);
            display.Add("Opp. 3pt/FGA", true);
            display.Add("Opp. eFG%", true);
            display.Add("Opp. TO%", true);
            display.Add("Opp. ORB%", true);
        }

        private async Task loadbasketballReferenceBasicdOpponentStatsAsync()
        {
            var url = "https://www.sports-reference.com/cbb/seasons/" + year + "-opponent-stats.html";

            var httpClient = new HttpClient();
            var html = await httpClient.GetStringAsync(url);

            var htmlDocument = new HtmlAgilityPack.HtmlDocument();
            htmlDocument.LoadHtml(html);

            var htmlNodes = htmlDocument.DocumentNode.SelectNodes("//tbody/tr");

            foreach (var tr in htmlNodes)
            {
                if (tr.FirstChild.Name != "#text")
                {
                    var children = tr.ChildNodes.ToList();

                    string teamName = children[1].InnerText.ToString();

                    string formattedTeamName = formatBasketballReferenceTeamName(teamName);

                    if (teams.ContainsKey(formattedTeamName)) // Only add stats for teams found by Kenpom
                    {
                        string oppFGPercentage = children[24].InnerText;
                        string opp3PA = children[26].InnerText;
                        string opp3PPercentage = children[27].InnerText;

                        teams[formattedTeamName].Add("Opp. FG%", oppFGPercentage);
                        teams[formattedTeamName].Add("Opp. 3PA", opp3PA);
                        teams[formattedTeamName].Add("Opp. 3P%", opp3PPercentage);
                    }
                }
            }

            display.Add("Opp. FG%", true);
            display.Add("Opp. 3PA", true);
            display.Add("Opp. 3P%", true);
        }

        private string formatBasketballReferenceTeamName(string teamName)
        {
            string formattedTeamName = teamName.Replace("State", "St.");
            formattedTeamName = formattedTeamName.Replace("&amp;", "&");

            if (formattedTeamName.Contains("&nbsp;"))
            {
                formattedTeamName = formattedTeamName.Replace("&nbsp;", "").Replace("NCAA", "");
            }

            if (formattedTeamName.Contains("("))
            {
                StringBuilder sb = new StringBuilder(formattedTeamName);
                int index = formattedTeamName.IndexOf("(");
                sb.Remove(index, 4);

                formattedTeamName = sb.ToString().Trim(); // removes any state abbreviations between paranthesis (WA) and any trailing spaces
            }

            return formattedTeamName;
        }


        private async void btnLoad_Click(object sender, EventArgs e)
        {
            lblLoading.Visible = true;
            await loadKenPomAsync();
            await loadbasketballReferenceAdvancedStatsAsync();
            await loadbasketballReferenceBasicStatsAsync();
            await loadbasketballReferenceAdvanceddOpponentStatsAsync();
            await loadbasketballReferenceBasicdOpponentStatsAsync();
            lblLoading.Visible = false;
            btnLoad.Text = "Loaded";
            btnLoad.Enabled = false;
            btnAddRemoveStats.Enabled = true;
            cmbTeam1.Enabled = true;
        }

        private void cmbTeam1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int columnIndex = 1;
            populateColumns();
        }

        private void cmbTeam2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int columnIndex = 2;
            populateColumns();
        }

        private void populateColumns()
        {
            if (dt.Columns.Count == 0)
            {
                dt.Columns.Add("Stat");
                dt.Columns.Add("Team 1");
                dt.Columns.Add("Team 2");
            }

            if (dt.Rows.Count == 0)
            {
                foreach (var stat in display.Keys) // Sets the stats column values (stat names in column 0)
                {
                    if (display[stat] == true) // Only add the stat if it's enabled
                    {
                        dt.Rows.Add(stat);
                    }
                }
            }

            populateTeamStats();

            dataGridView1.DataSource = dt;
        }

        public void populateTeamStats()
        {
            foreach (ComboBox cb in groupBox1.Controls.OfType<ComboBox>())
            {
                if (!cb.Text.Contains("Select team"))
                {
                    string selectedTeam = "";
                    int columnIndex = 0;

                    if (cb.Name == "cmbTeam1")
                    {
                        selectedTeam = cmbTeam1.SelectedItem.ToString();
                        columnIndex = 1;
                        cmbTeam2.Enabled = true;
                    }
                    else if (cb.Name == "cmbTeam2")
                    {
                        selectedTeam = cmbTeam2.SelectedItem.ToString();
                        columnIndex = 2;
                    }

                    dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dataGridView1.Columns[0].DefaultCellStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, FontStyle.Bold);

                    dt.Columns[columnIndex].ColumnName = selectedTeam; // overwrite the existing column name

                    for (int i = 0; i < dt.Rows.Count; i++) // sets the column stat values
                    {
                        string rowStatName = dt.Rows[i][0].ToString();
                        foreach (var teamStatName in teams[selectedTeam].Keys)
                        {
                            if (rowStatName == teamStatName) // If the stat name in the dictionary matches one listed in the stat column for the current row
                            {
                                dt.Rows[i][columnIndex] = teams[selectedTeam][teamStatName]; // Set the stat value for the current row for the current team

                            }
                        }
                    }
                    dataGridView1.DataSource = dt;
                    dataGridView1.Refresh();
                }
            }

        }

        private void btnAddRemoveStats_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Display = display;
            form2.Dt = dt;
            form2.Show();
            dataGridView1.Refresh();
        }

        void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //if ((e.ColumnIndex == this.dataGridView1.Columns["Stats"].Index) && e.Value != null)
            //{
                DataGridViewCell cell = this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (e.Value.Equals("Rank")) { cell.ToolTipText = "Kenpom rank (by Adjusted Efficiency Margin"; }
                if (e.Value.Equals("Opp. AdjD (Rank)")) { cell.ToolTipText = "Average adjusted defensive efficiency (points allowed per 100 possessions) of opponents. Rank in paranthesis."; }
                if (e.Value.Equals("Opp. AdjO (Rank)")) { cell.ToolTipText = "Average adjusted offensive efficiency (points scored per 100 possessions) of opponents. Rank in paranthesis."; }
                if (e.Value.Equals("Luck (Rank)")) { cell.ToolTipText = "The deviation in winning percentage between a team’s actual record and their expected record using the correlated gaussian method"; }
                if (e.Value.Equals("SOS")) { cell.ToolTipText = "Strength of schedule ranking by Adjusted Efficiency Margin"; }
                if (e.Value.Equals("AdjT (Rank)")) { cell.ToolTipText = "Adjusted tempo: possessions per 40 minutes (adjusted for opponent)"; }
                if (e.Value.Equals("AdjO (Rank)")) { cell.ToolTipText = "Rank of adjusted offensive efficiency: points scored for 100 possessions (adjusted for opponent)"; }
                if (e.Value.Equals("AdjD (Rank)")) { cell.ToolTipText = "Rank of adjusted defensive efficiency: points allowed per 100 possessions (adjusted for opponent)"; }
                if (e.Value.Equals("AdjEM")) { cell.ToolTipText = "Adjusted efficiency margin: Adjusted offensive efficiency subtracted by adjusted defensive efficiency. This is what Kenpom uses to establish rank."; }
                if (e.Value.Equals("W-L")) { cell.ToolTipText = "Wins-Losses"; }
                if (e.Value.Equals("Conf")) { cell.ToolTipText = "Conference"; }
                if (e.Value.Equals("FGA")) { cell.ToolTipText = "Total field goals attempted"; }
                if (e.Value.Equals("Away W-L")) { cell.ToolTipText = "Away win - loss"; }
                if (e.Value.Equals("3PA")) { cell.ToolTipText = "Total 3 pointers attempted"; }
                if (e.Value.Equals("FG%")) { cell.ToolTipText = "Field goal percentage"; }
                if (e.Value.Equals("3P%")) { cell.ToolTipText = "3 point field goal percentage"; }
                if (e.Value.Equals("Home W-L")) { cell.ToolTipText = "Home win-loss"; }
                if (e.Value.Equals("ORB%")) { cell.ToolTipText = "Offensive rebound percentage"; }
                if (e.Value.Equals("Pts scored")) { cell.ToolTipText = "Total points scored"; }
                if (e.Value.Equals("eFG%")) { cell.ToolTipText = "Effective field goal percentage.Adjusts for the fact that a 3 point FG is worth more than a 2 point FG."; }
                if (e.Value.Equals("STL%")) { cell.ToolTipText = "Steal percentage"; }
                if (e.Value.Equals("TO%")) { cell.ToolTipText = "Turnover percentage"; }
                if (e.Value.Equals("AST%")) { cell.ToolTipText = "Assist percentage"; }
                if (e.Value.Equals("BLK%")) { cell.ToolTipText = "Block percentage"; }
                if (e.Value.Equals("FT/FGA")) { cell.ToolTipText = "Free throw rate. This is free throws per field goal attempt."; }
                if (e.Value.Equals("3PT/FGA")) { cell.ToolTipText = "3 point rate. This is 3 point field goals per total field goals."; }
                if (e.Value.Equals("ORtg")) { cell.ToolTipText = "Offensive rating. Points scored per 100 possessions."; }
                if (e.Value.Equals("Pace")) { cell.ToolTipText = "An estimate of possessions per 40 minutes"; }
                if (e.Value.Equals("Opp. 3P%")) { cell.ToolTipText = "Opponent 3 point field goal percentage"; }
                if (e.Value.Equals("Opp. Pace")) { cell.ToolTipText = "Opponent estimate of possessions per 40 minutes"; }
                if (e.Value.Equals("Opp. pts scored")) { cell.ToolTipText = "Total points scored of opponents"; }
                if (e.Value.Equals("Opp. 3PA")) { cell.ToolTipText = "Opponent total 3 point field goals attempted"; }
                if (e.Value.Equals("Opp. EFG%")) { cell.ToolTipText = "Opponent effective field goal percentage. Adjusts for the fact that a 3 point FG is worth more than a 2 point FG."; }
                if (e.Value.Equals("Opp. ORB%")) { cell.ToolTipText = "Opponent offensive rebounding percentage"; }
                if (e.Value.Equals("Opp. FG%")) { cell.ToolTipText = "Opponent field goal percentage"; }
                if (e.Value.Equals("Opp. TO%")) { cell.ToolTipText = "Opponent turnover percentage"; }
                if (e.Value.Equals("Opp. 3pt/FGA")) { cell.ToolTipText = "Opponent 3 point field goal rate. This is 3 point field goals per total field goals."; }

            //}
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int headerIndex = e.ColumnIndex;
                teamNameColumnHeader = dataGridView1.Columns[headerIndex].Name;
                teamNameColumnHeader = teamNameColumnHeader.Replace(" ", "-").Replace(".", "").ToLower();

                contextMenuStrip1.Show(dataGridView1, dataGridView1.PointToClient(Cursor.Position));
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://sports.yahoo.com/ncaab/teams/" + teamNameColumnHeader + "/schedule/?scheduleType=list");
        }

        private void viewIndividualPlayerStatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.sports-reference.com/cbb/schools/" + teamNameColumnHeader.Replace("st","state") + "/" + year + ".html");
        }
    }
}
