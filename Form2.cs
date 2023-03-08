using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatsComparerThingy
{
    public partial class Form2 : Form
    {
        public Dictionary<string, bool> Display
        {
            get;
            set;
        }

        public DataTable Dt
        {
            get;
            set;
        }

        private Form1 form1;

        public Form2(Form1 form1)
        {
            this.form1 = form1;
            InitializeComponent();
        }

        public void Form2_Load(object sender, EventArgs e)
        {
            foreach (CheckBox c in gbKenpom.Controls.OfType<CheckBox>())
            {
                if (c.Name != "cbKPSelectAll")
                {
                    string name = c.Text;
                    if (Display[name] == true)
                    {
                        c.Checked = true;
                    }
                    else
                    {
                        c.Checked = false;
                    }
                }
            }

            foreach (CheckBox c in gbSportsReference.Controls.OfType<CheckBox>())
            {
                if (c.Name != "cbSRSelectAll")
                {
                    string name = c.Text;
                    if (Display[name] == true)
                    {
                        c.Checked = true;
                    }
                    else
                    {
                        c.Checked = false;
                    }
                }
            }

            foreach (CheckBox c in gbDefensiveStats.Controls.OfType<CheckBox>())
            {
                string name = c.Text;
                if (Display[name] == true)
                {
                    c.Checked = true;
                }
                else
                {
                    c.Checked = false;
                }
            }

            toolTip1.SetToolTip(cbRank, "Kenpom rank (by Adjusted Efficiency Margin)");
            toolTip1.SetToolTip(cbOppDef, "Average adjusted defensive efficiency (points allowed per 100 possessions) of opponents. Rank in paranthesis.");
            toolTip1.SetToolTip(cbOppOff, "Average adjusted offensive efficiency (points scored per 100 possessions) of opponents. Rank in paranthesis.");
            toolTip1.SetToolTip(cbLuckRank, "The deviation in winning percentage between a team’s actual record and their expected record using the correlated gaussian method");
            toolTip1.SetToolTip(cbSOS, "Strength of schedule ranking by Adjusted Efficiency Margin");
            toolTip1.SetToolTip(cbAdjTRank, "Adjusted tempo: possessions per 40 minutes (adjusted for opponent)");
            toolTip1.SetToolTip(cbAdjORank, "Rank of adjusted offensive efficiency: points scored per 100 possessions (adjusted for opponent)");
            toolTip1.SetToolTip(cbAdjDRank, "Rank of adjusted defensive efficiency: points allowed per 100 possessions (adjusted for opponent)");
            toolTip1.SetToolTip(cbAdjEM, "Adjusted efficiency margin: Adjusted offensive efficiency subtracted by adjusted defensive efficiency. This is what Kenpom uses to establish rank.");
            toolTip1.SetToolTip(cbWL, "Wins-Losses");
            toolTip1.SetToolTip(cbConf, "Conference");
            toolTip1.SetToolTip(cbFGA, "Total field goals attempted");
            toolTip1.SetToolTip(cbAwayWL, "Away win-loss");
            toolTip1.SetToolTip(cb3PA, "Total 3 pointers attempted");
            toolTip1.SetToolTip(cbFGPercentage, "Field goal percentage");
            toolTip1.SetToolTip(cb3PPercent, "3 point field goal percentage");
            toolTip1.SetToolTip(cbHomeWL, "Home win-loss");
            toolTip1.SetToolTip(cbORB, "Offensive rebound percentage");
            toolTip1.SetToolTip(cbPointsScored, "Total points scored");
            toolTip1.SetToolTip(cbeFG, "Effective field goal percentage. Adjusts for the fact that a 3 point FG is worth more than a 2 point FG.");
            toolTip1.SetToolTip(cbSTL, "Steal percentage");
            toolTip1.SetToolTip(cbTO, "Turnover percentage");
            toolTip1.SetToolTip(cbAST, "Assist percentage");
            toolTip1.SetToolTip(cbBLK, "Block percentage");
            toolTip1.SetToolTip(cbFTFGA, "Free throw rate. This is free throws per field goal attempt.");
            toolTip1.SetToolTip(cb3PTFGA, "3 point rate. This is 3 point field goals per total field goals.");
            toolTip1.SetToolTip(cbORtg, "Offensive rating. Points scored per 100 possessions.");
            toolTip1.SetToolTip(cbPace, "An estimate of possessions per 40 minutes");
            toolTip1.SetToolTip(cbOpp3PPercentage, "Opponent 3 point field goal percentage");
            toolTip1.SetToolTip(cbOppPace, "Opponent estimate of possessions per 40 minutes");
            toolTip1.SetToolTip(cbOppPointsScored, "Total points scored of opponents");
            toolTip1.SetToolTip(cbOpp3PA, "Opponent total 3 point field goals attempted");
            toolTip1.SetToolTip(cbOppEFG, "Opponent effective field goal percentage. Adjusts for the fact that a 3 point FG is worth more than a 2 point FG.");
            toolTip1.SetToolTip(cbOppORB, "Opponent offensive rebounding percentage");
            toolTip1.SetToolTip(cbOppFGPercentage, "Opponent field goal percentage");
            toolTip1.SetToolTip(cbOppTOPercentage, "Opponent turnover percentage");
            toolTip1.SetToolTip(cbOpp3PointRate, "Opponent 3 point field goal rate. This is 3 point field goals per total field goals.");
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (Dt.Columns.Count == 0)
            {
                Dt.Columns.Add("Stat");
                Dt.Columns.Add("Team 1");
                Dt.Columns.Add("Team 2");
            }

            foreach (CheckBox c in gbKenpom.Controls.OfType<CheckBox>())
            {
                if (c.Name != "cbKPSelectAll")
                {
                    bool isChecked = c.Checked;
                    string name = c.Text;

                    Display[name] = isChecked;
                }
            }

            foreach (CheckBox c in gbSportsReference.Controls.OfType<CheckBox>())
            {
                if (c.Name != "cbSRSelectAll")
                {
                    bool isChecked = c.Checked;
                    string name = c.Text;

                    Display[name] = isChecked;
                }
            }

            foreach (CheckBox c in gbDefensiveStats.Controls.OfType<CheckBox>())
            {
                bool isChecked = c.Checked;
                string name = c.Text;

                Display[name] = isChecked;
            }

            if (Dt.Rows.Count > 0)
            {
                Dt.Rows.Clear();
            }

            foreach (var stat in Display.Keys) // Sets the stats column values (stat names in column 0)
            {
                if (Display[stat] == true)
                {
                    Dt.Rows.Add(stat);
                }
            }

            //Form1 form1 = new Form1();
            form1.populateTeamStats();
            this.Hide();
        }

        private void cbSRSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            foreach (CheckBox c in gbSportsReference.Controls.OfType<CheckBox>())
            {
                c.Checked = cbSRSelectAll.Checked;
            }

            foreach (CheckBox c in gbDefensiveStats.Controls.OfType<CheckBox>())
            {
                c.Checked = cbSRSelectAll.Checked;
            }
        }

        private void cbKPSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            foreach (CheckBox c in gbKenpom.Controls.OfType<CheckBox>())
            {
                c.Checked = cbKPSelectAll.Checked;
            }
        }
    }
}
