namespace StatsComparerThingy
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btnApply = new System.Windows.Forms.Button();
            this.cbSRSelectAll = new System.Windows.Forms.CheckBox();
            this.gbSportsReference = new System.Windows.Forms.GroupBox();
            this.gbDefensiveStats = new System.Windows.Forms.GroupBox();
            this.cbOpp3PPercentage = new System.Windows.Forms.CheckBox();
            this.cbOppPace = new System.Windows.Forms.CheckBox();
            this.cbOppPointsScored = new System.Windows.Forms.CheckBox();
            this.cbOpp3PA = new System.Windows.Forms.CheckBox();
            this.cbOppEFG = new System.Windows.Forms.CheckBox();
            this.cbOppORB = new System.Windows.Forms.CheckBox();
            this.cbOppFGPercentage = new System.Windows.Forms.CheckBox();
            this.cbOppTOPercentage = new System.Windows.Forms.CheckBox();
            this.cbOpp3PointRate = new System.Windows.Forms.CheckBox();
            this.cbFGA = new System.Windows.Forms.CheckBox();
            this.cbAwayWL = new System.Windows.Forms.CheckBox();
            this.cb3PA = new System.Windows.Forms.CheckBox();
            this.cbFGPercentage = new System.Windows.Forms.CheckBox();
            this.cb3PPercent = new System.Windows.Forms.CheckBox();
            this.cbHomeWL = new System.Windows.Forms.CheckBox();
            this.cbORB = new System.Windows.Forms.CheckBox();
            this.cbPointsScored = new System.Windows.Forms.CheckBox();
            this.cbeFG = new System.Windows.Forms.CheckBox();
            this.cbSTL = new System.Windows.Forms.CheckBox();
            this.cbTO = new System.Windows.Forms.CheckBox();
            this.cbAST = new System.Windows.Forms.CheckBox();
            this.cbBLK = new System.Windows.Forms.CheckBox();
            this.cbFTFGA = new System.Windows.Forms.CheckBox();
            this.cb3PTFGA = new System.Windows.Forms.CheckBox();
            this.cbORtg = new System.Windows.Forms.CheckBox();
            this.cbPace = new System.Windows.Forms.CheckBox();
            this.gbKenpom = new System.Windows.Forms.GroupBox();
            this.cbKPSelectAll = new System.Windows.Forms.CheckBox();
            this.cbRank = new System.Windows.Forms.CheckBox();
            this.cbOppDef = new System.Windows.Forms.CheckBox();
            this.cbOppOff = new System.Windows.Forms.CheckBox();
            this.cbLuckRank = new System.Windows.Forms.CheckBox();
            this.cbSOS = new System.Windows.Forms.CheckBox();
            this.cbAdjTRank = new System.Windows.Forms.CheckBox();
            this.cbAdjORank = new System.Windows.Forms.CheckBox();
            this.cbAdjDRank = new System.Windows.Forms.CheckBox();
            this.cbAdjEM = new System.Windows.Forms.CheckBox();
            this.cbWL = new System.Windows.Forms.CheckBox();
            this.cbConf = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gbSportsReference.SuspendLayout();
            this.gbDefensiveStats.SuspendLayout();
            this.gbKenpom.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(21, 475);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 1;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // cbSRSelectAll
            // 
            this.cbSRSelectAll.AutoSize = true;
            this.cbSRSelectAll.Checked = true;
            this.cbSRSelectAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSRSelectAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSRSelectAll.Location = new System.Drawing.Point(18, 237);
            this.cbSRSelectAll.Name = "cbSRSelectAll";
            this.cbSRSelectAll.Size = new System.Drawing.Size(156, 17);
            this.cbSRSelectAll.TabIndex = 2;
            this.cbSRSelectAll.Text = "Select All Sports-Reference";
            this.cbSRSelectAll.UseVisualStyleBackColor = true;
            this.cbSRSelectAll.CheckedChanged += new System.EventHandler(this.cbSRSelectAll_CheckedChanged);
            // 
            // gbSportsReference
            // 
            this.gbSportsReference.Controls.Add(this.gbDefensiveStats);
            this.gbSportsReference.Controls.Add(this.cbFGA);
            this.gbSportsReference.Controls.Add(this.cbAwayWL);
            this.gbSportsReference.Controls.Add(this.cbSRSelectAll);
            this.gbSportsReference.Controls.Add(this.cb3PA);
            this.gbSportsReference.Controls.Add(this.cbFGPercentage);
            this.gbSportsReference.Controls.Add(this.cb3PPercent);
            this.gbSportsReference.Controls.Add(this.cbHomeWL);
            this.gbSportsReference.Controls.Add(this.cbORB);
            this.gbSportsReference.Controls.Add(this.cbPointsScored);
            this.gbSportsReference.Controls.Add(this.cbeFG);
            this.gbSportsReference.Controls.Add(this.cbSTL);
            this.gbSportsReference.Controls.Add(this.cbTO);
            this.gbSportsReference.Controls.Add(this.cbAST);
            this.gbSportsReference.Controls.Add(this.cbBLK);
            this.gbSportsReference.Controls.Add(this.cbFTFGA);
            this.gbSportsReference.Controls.Add(this.cb3PTFGA);
            this.gbSportsReference.Controls.Add(this.cbORtg);
            this.gbSportsReference.Controls.Add(this.cbPace);
            this.gbSportsReference.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSportsReference.Location = new System.Drawing.Point(21, 21);
            this.gbSportsReference.Name = "gbSportsReference";
            this.gbSportsReference.Size = new System.Drawing.Size(370, 270);
            this.gbSportsReference.TabIndex = 13;
            this.gbSportsReference.TabStop = false;
            this.gbSportsReference.Text = "Sports-Reference.com";
            // 
            // gbDefensiveStats
            // 
            this.gbDefensiveStats.Controls.Add(this.cbOpp3PPercentage);
            this.gbDefensiveStats.Controls.Add(this.cbOppPace);
            this.gbDefensiveStats.Controls.Add(this.cbOppPointsScored);
            this.gbDefensiveStats.Controls.Add(this.cbOpp3PA);
            this.gbDefensiveStats.Controls.Add(this.cbOppEFG);
            this.gbDefensiveStats.Controls.Add(this.cbOppORB);
            this.gbDefensiveStats.Controls.Add(this.cbOppFGPercentage);
            this.gbDefensiveStats.Controls.Add(this.cbOppTOPercentage);
            this.gbDefensiveStats.Controls.Add(this.cbOpp3PointRate);
            this.gbDefensiveStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDefensiveStats.Location = new System.Drawing.Point(18, 128);
            this.gbDefensiveStats.Name = "gbDefensiveStats";
            this.gbDefensiveStats.Size = new System.Drawing.Size(325, 94);
            this.gbDefensiveStats.TabIndex = 21;
            this.gbDefensiveStats.TabStop = false;
            this.gbDefensiveStats.Text = "Defensive (opponent) Stats";
            // 
            // cbOpp3PPercentage
            // 
            this.cbOpp3PPercentage.AutoSize = true;
            this.cbOpp3PPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOpp3PPercentage.Location = new System.Drawing.Point(122, 42);
            this.cbOpp3PPercentage.Name = "cbOpp3PPercentage";
            this.cbOpp3PPercentage.Size = new System.Drawing.Size(73, 17);
            this.cbOpp3PPercentage.TabIndex = 27;
            this.cbOpp3PPercentage.Text = "Opp. 3P%";
            this.cbOpp3PPercentage.UseVisualStyleBackColor = true;
            // 
            // cbOppPace
            // 
            this.cbOppPace.AutoSize = true;
            this.cbOppPace.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOppPace.Location = new System.Drawing.Point(212, 65);
            this.cbOppPace.Name = "cbOppPace";
            this.cbOppPace.Size = new System.Drawing.Size(77, 17);
            this.cbOppPace.TabIndex = 24;
            this.cbOppPace.Text = "Opp. Pace";
            this.cbOppPace.UseVisualStyleBackColor = true;
            // 
            // cbOppPointsScored
            // 
            this.cbOppPointsScored.AutoSize = true;
            this.cbOppPointsScored.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOppPointsScored.Location = new System.Drawing.Point(15, 19);
            this.cbOppPointsScored.Name = "cbOppPointsScored";
            this.cbOppPointsScored.Size = new System.Drawing.Size(101, 17);
            this.cbOppPointsScored.TabIndex = 0;
            this.cbOppPointsScored.Text = "Opp. pts scored";
            this.cbOppPointsScored.UseVisualStyleBackColor = true;
            // 
            // cbOpp3PA
            // 
            this.cbOpp3PA.AutoSize = true;
            this.cbOpp3PA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOpp3PA.Location = new System.Drawing.Point(212, 19);
            this.cbOpp3PA.Name = "cbOpp3PA";
            this.cbOpp3PA.Size = new System.Drawing.Size(72, 17);
            this.cbOpp3PA.TabIndex = 25;
            this.cbOpp3PA.Text = "Opp. 3PA";
            this.cbOpp3PA.UseVisualStyleBackColor = true;
            // 
            // cbOppEFG
            // 
            this.cbOppEFG.AutoSize = true;
            this.cbOppEFG.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOppEFG.Location = new System.Drawing.Point(212, 42);
            this.cbOppEFG.Name = "cbOppEFG";
            this.cbOppEFG.Size = new System.Drawing.Size(80, 17);
            this.cbOppEFG.TabIndex = 23;
            this.cbOppEFG.Text = "Opp. eFG%";
            this.cbOppEFG.UseVisualStyleBackColor = true;
            // 
            // cbOppORB
            // 
            this.cbOppORB.AutoSize = true;
            this.cbOppORB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOppORB.Location = new System.Drawing.Point(122, 65);
            this.cbOppORB.Name = "cbOppORB";
            this.cbOppORB.Size = new System.Drawing.Size(83, 17);
            this.cbOppORB.TabIndex = 20;
            this.cbOppORB.Text = "Opp. ORB%";
            this.cbOppORB.UseVisualStyleBackColor = true;
            // 
            // cbOppFGPercentage
            // 
            this.cbOppFGPercentage.AutoSize = true;
            this.cbOppFGPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOppFGPercentage.Location = new System.Drawing.Point(122, 19);
            this.cbOppFGPercentage.Name = "cbOppFGPercentage";
            this.cbOppFGPercentage.Size = new System.Drawing.Size(74, 17);
            this.cbOppFGPercentage.TabIndex = 26;
            this.cbOppFGPercentage.Text = "Opp. FG%";
            this.cbOppFGPercentage.UseVisualStyleBackColor = true;
            // 
            // cbOppTOPercentage
            // 
            this.cbOppTOPercentage.AutoSize = true;
            this.cbOppTOPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOppTOPercentage.Location = new System.Drawing.Point(15, 65);
            this.cbOppTOPercentage.Name = "cbOppTOPercentage";
            this.cbOppTOPercentage.Size = new System.Drawing.Size(75, 17);
            this.cbOppTOPercentage.TabIndex = 21;
            this.cbOppTOPercentage.Text = "Opp. TO%";
            this.cbOppTOPercentage.UseVisualStyleBackColor = true;
            // 
            // cbOpp3PointRate
            // 
            this.cbOpp3PointRate.AutoSize = true;
            this.cbOpp3PointRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOpp3PointRate.Location = new System.Drawing.Point(15, 42);
            this.cbOpp3PointRate.Name = "cbOpp3PointRate";
            this.cbOpp3PointRate.Size = new System.Drawing.Size(93, 17);
            this.cbOpp3PointRate.TabIndex = 22;
            this.cbOpp3PointRate.Text = "Opp. 3pt/FGA";
            this.cbOpp3PointRate.UseVisualStyleBackColor = true;
            // 
            // cbFGA
            // 
            this.cbFGA.AutoSize = true;
            this.cbFGA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFGA.Location = new System.Drawing.Point(18, 19);
            this.cbFGA.Name = "cbFGA";
            this.cbFGA.Size = new System.Drawing.Size(47, 17);
            this.cbFGA.TabIndex = 19;
            this.cbFGA.Text = "FGA";
            this.cbFGA.UseVisualStyleBackColor = true;
            // 
            // cbAwayWL
            // 
            this.cbAwayWL.AutoSize = true;
            this.cbAwayWL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAwayWL.Location = new System.Drawing.Point(18, 89);
            this.cbAwayWL.Name = "cbAwayWL";
            this.cbAwayWL.Size = new System.Drawing.Size(75, 17);
            this.cbAwayWL.TabIndex = 18;
            this.cbAwayWL.Text = "Away W-L";
            this.cbAwayWL.UseVisualStyleBackColor = true;
            // 
            // cb3PA
            // 
            this.cb3PA.AutoSize = true;
            this.cb3PA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb3PA.Location = new System.Drawing.Point(153, 19);
            this.cb3PA.Name = "cb3PA";
            this.cb3PA.Size = new System.Drawing.Size(46, 17);
            this.cb3PA.TabIndex = 17;
            this.cb3PA.Text = "3PA";
            this.cb3PA.UseVisualStyleBackColor = true;
            // 
            // cbFGPercentage
            // 
            this.cbFGPercentage.AutoSize = true;
            this.cbFGPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFGPercentage.Location = new System.Drawing.Point(86, 19);
            this.cbFGPercentage.Name = "cbFGPercentage";
            this.cbFGPercentage.Size = new System.Drawing.Size(48, 17);
            this.cbFGPercentage.TabIndex = 15;
            this.cbFGPercentage.Text = "FG%";
            this.cbFGPercentage.UseVisualStyleBackColor = true;
            // 
            // cb3PPercent
            // 
            this.cb3PPercent.AutoSize = true;
            this.cb3PPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb3PPercent.Location = new System.Drawing.Point(221, 19);
            this.cb3PPercent.Name = "cb3PPercent";
            this.cb3PPercent.Size = new System.Drawing.Size(47, 17);
            this.cb3PPercent.TabIndex = 14;
            this.cb3PPercent.Text = "3P%";
            this.cb3PPercent.UseVisualStyleBackColor = true;
            // 
            // cbHomeWL
            // 
            this.cbHomeWL.AutoSize = true;
            this.cbHomeWL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHomeWL.Location = new System.Drawing.Point(286, 66);
            this.cbHomeWL.Name = "cbHomeWL";
            this.cbHomeWL.Size = new System.Drawing.Size(77, 17);
            this.cbHomeWL.TabIndex = 13;
            this.cbHomeWL.Text = "Home W-L";
            this.cbHomeWL.UseVisualStyleBackColor = true;
            // 
            // cbORB
            // 
            this.cbORB.AutoSize = true;
            this.cbORB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbORB.Location = new System.Drawing.Point(286, 43);
            this.cbORB.Name = "cbORB";
            this.cbORB.Size = new System.Drawing.Size(57, 17);
            this.cbORB.TabIndex = 12;
            this.cbORB.Text = "ORB%";
            this.cbORB.UseVisualStyleBackColor = true;
            // 
            // cbPointsScored
            // 
            this.cbPointsScored.AutoSize = true;
            this.cbPointsScored.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPointsScored.Location = new System.Drawing.Point(98, 89);
            this.cbPointsScored.Name = "cbPointsScored";
            this.cbPointsScored.Size = new System.Drawing.Size(76, 17);
            this.cbPointsScored.TabIndex = 11;
            this.cbPointsScored.Text = "Pts scored";
            this.cbPointsScored.UseVisualStyleBackColor = true;
            // 
            // cbeFG
            // 
            this.cbeFG.AutoSize = true;
            this.cbeFG.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbeFG.Location = new System.Drawing.Point(18, 43);
            this.cbeFG.Name = "cbeFG";
            this.cbeFG.Size = new System.Drawing.Size(54, 17);
            this.cbeFG.TabIndex = 10;
            this.cbeFG.Text = "eFG%";
            this.cbeFG.UseVisualStyleBackColor = true;
            // 
            // cbSTL
            // 
            this.cbSTL.AutoSize = true;
            this.cbSTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSTL.Location = new System.Drawing.Point(86, 66);
            this.cbSTL.Name = "cbSTL";
            this.cbSTL.Size = new System.Drawing.Size(54, 17);
            this.cbSTL.TabIndex = 9;
            this.cbSTL.Text = "STL%";
            this.cbSTL.UseVisualStyleBackColor = true;
            // 
            // cbTO
            // 
            this.cbTO.AutoSize = true;
            this.cbTO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTO.Location = new System.Drawing.Point(153, 66);
            this.cbTO.Name = "cbTO";
            this.cbTO.Size = new System.Drawing.Size(49, 17);
            this.cbTO.TabIndex = 8;
            this.cbTO.Text = "TO%";
            this.cbTO.UseVisualStyleBackColor = true;
            // 
            // cbAST
            // 
            this.cbAST.AutoSize = true;
            this.cbAST.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAST.Location = new System.Drawing.Point(153, 43);
            this.cbAST.Name = "cbAST";
            this.cbAST.Size = new System.Drawing.Size(55, 17);
            this.cbAST.TabIndex = 7;
            this.cbAST.Text = "AST%";
            this.cbAST.UseVisualStyleBackColor = true;
            // 
            // cbBLK
            // 
            this.cbBLK.AutoSize = true;
            this.cbBLK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBLK.Location = new System.Drawing.Point(18, 66);
            this.cbBLK.Name = "cbBLK";
            this.cbBLK.Size = new System.Drawing.Size(54, 17);
            this.cbBLK.TabIndex = 5;
            this.cbBLK.Text = "BLK%";
            this.cbBLK.UseVisualStyleBackColor = true;
            // 
            // cbFTFGA
            // 
            this.cbFTFGA.AutoSize = true;
            this.cbFTFGA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFTFGA.Location = new System.Drawing.Point(86, 43);
            this.cbFTFGA.Name = "cbFTFGA";
            this.cbFTFGA.Size = new System.Drawing.Size(65, 17);
            this.cbFTFGA.TabIndex = 4;
            this.cbFTFGA.Text = "FT/FGA";
            this.cbFTFGA.UseVisualStyleBackColor = true;
            // 
            // cb3PTFGA
            // 
            this.cb3PTFGA.AutoSize = true;
            this.cb3PTFGA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb3PTFGA.Location = new System.Drawing.Point(286, 19);
            this.cb3PTFGA.Name = "cb3PTFGA";
            this.cb3PTFGA.Size = new System.Drawing.Size(72, 17);
            this.cb3PTFGA.TabIndex = 3;
            this.cb3PTFGA.Text = "3PT/FGA";
            this.cb3PTFGA.UseVisualStyleBackColor = true;
            // 
            // cbORtg
            // 
            this.cbORtg.AutoSize = true;
            this.cbORtg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbORtg.Location = new System.Drawing.Point(221, 43);
            this.cbORtg.Name = "cbORtg";
            this.cbORtg.Size = new System.Drawing.Size(51, 17);
            this.cbORtg.TabIndex = 2;
            this.cbORtg.Text = "ORtg";
            this.cbORtg.UseVisualStyleBackColor = true;
            // 
            // cbPace
            // 
            this.cbPace.AutoSize = true;
            this.cbPace.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPace.Location = new System.Drawing.Point(221, 66);
            this.cbPace.Name = "cbPace";
            this.cbPace.Size = new System.Drawing.Size(51, 17);
            this.cbPace.TabIndex = 1;
            this.cbPace.Text = "Pace";
            this.cbPace.UseVisualStyleBackColor = true;
            // 
            // gbKenpom
            // 
            this.gbKenpom.Controls.Add(this.cbKPSelectAll);
            this.gbKenpom.Controls.Add(this.cbRank);
            this.gbKenpom.Controls.Add(this.cbOppDef);
            this.gbKenpom.Controls.Add(this.cbOppOff);
            this.gbKenpom.Controls.Add(this.cbLuckRank);
            this.gbKenpom.Controls.Add(this.cbSOS);
            this.gbKenpom.Controls.Add(this.cbAdjTRank);
            this.gbKenpom.Controls.Add(this.cbAdjORank);
            this.gbKenpom.Controls.Add(this.cbAdjDRank);
            this.gbKenpom.Controls.Add(this.cbAdjEM);
            this.gbKenpom.Controls.Add(this.cbWL);
            this.gbKenpom.Controls.Add(this.cbConf);
            this.gbKenpom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbKenpom.Location = new System.Drawing.Point(21, 311);
            this.gbKenpom.Name = "gbKenpom";
            this.gbKenpom.Size = new System.Drawing.Size(370, 134);
            this.gbKenpom.TabIndex = 12;
            this.gbKenpom.TabStop = false;
            this.gbKenpom.Text = "Kenpom.com";
            // 
            // cbKPSelectAll
            // 
            this.cbKPSelectAll.AutoSize = true;
            this.cbKPSelectAll.Checked = true;
            this.cbKPSelectAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbKPSelectAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKPSelectAll.Location = new System.Drawing.Point(18, 111);
            this.cbKPSelectAll.Name = "cbKPSelectAll";
            this.cbKPSelectAll.Size = new System.Drawing.Size(112, 17);
            this.cbKPSelectAll.TabIndex = 14;
            this.cbKPSelectAll.Text = "Select All Kenpom";
            this.cbKPSelectAll.UseVisualStyleBackColor = true;
            this.cbKPSelectAll.CheckedChanged += new System.EventHandler(this.cbKPSelectAll_CheckedChanged);
            // 
            // cbRank
            // 
            this.cbRank.AutoSize = true;
            this.cbRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRank.Location = new System.Drawing.Point(18, 19);
            this.cbRank.Name = "cbRank";
            this.cbRank.Size = new System.Drawing.Size(52, 17);
            this.cbRank.TabIndex = 11;
            this.cbRank.Text = "Rank";
            this.cbRank.UseVisualStyleBackColor = true;
            // 
            // cbOppDef
            // 
            this.cbOppDef.AutoSize = true;
            this.cbOppDef.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOppDef.Location = new System.Drawing.Point(221, 65);
            this.cbOppDef.Name = "cbOppDef";
            this.cbOppDef.Size = new System.Drawing.Size(110, 17);
            this.cbOppDef.TabIndex = 10;
            this.cbOppDef.Text = "Opp. AdjD (Rank)";
            this.cbOppDef.UseVisualStyleBackColor = true;
            // 
            // cbOppOff
            // 
            this.cbOppOff.AutoSize = true;
            this.cbOppOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOppOff.Location = new System.Drawing.Point(103, 65);
            this.cbOppOff.Name = "cbOppOff";
            this.cbOppOff.Size = new System.Drawing.Size(110, 17);
            this.cbOppOff.TabIndex = 9;
            this.cbOppOff.Text = "Opp. AdjO (Rank)";
            this.cbOppOff.UseVisualStyleBackColor = true;
            // 
            // cbLuckRank
            // 
            this.cbLuckRank.AutoSize = true;
            this.cbLuckRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLuckRank.Location = new System.Drawing.Point(276, 42);
            this.cbLuckRank.Name = "cbLuckRank";
            this.cbLuckRank.Size = new System.Drawing.Size(85, 17);
            this.cbLuckRank.TabIndex = 8;
            this.cbLuckRank.Text = "Luck (Rank)";
            this.cbLuckRank.UseVisualStyleBackColor = true;
            // 
            // cbSOS
            // 
            this.cbSOS.AutoSize = true;
            this.cbSOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSOS.Location = new System.Drawing.Point(18, 65);
            this.cbSOS.Name = "cbSOS";
            this.cbSOS.Size = new System.Drawing.Size(48, 17);
            this.cbSOS.TabIndex = 7;
            this.cbSOS.Text = "SOS";
            this.cbSOS.UseVisualStyleBackColor = true;
            // 
            // cbAdjTRank
            // 
            this.cbAdjTRank.AutoSize = true;
            this.cbAdjTRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAdjTRank.Location = new System.Drawing.Point(189, 42);
            this.cbAdjTRank.Name = "cbAdjTRank";
            this.cbAdjTRank.Size = new System.Drawing.Size(83, 17);
            this.cbAdjTRank.TabIndex = 5;
            this.cbAdjTRank.Text = "AdjT (Rank)";
            this.cbAdjTRank.UseVisualStyleBackColor = true;
            // 
            // cbAdjORank
            // 
            this.cbAdjORank.AutoSize = true;
            this.cbAdjORank.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAdjORank.Location = new System.Drawing.Point(18, 42);
            this.cbAdjORank.Name = "cbAdjORank";
            this.cbAdjORank.Size = new System.Drawing.Size(84, 17);
            this.cbAdjORank.TabIndex = 4;
            this.cbAdjORank.Text = "AdjO (Rank)";
            this.cbAdjORank.UseVisualStyleBackColor = true;
            // 
            // cbAdjDRank
            // 
            this.cbAdjDRank.AutoSize = true;
            this.cbAdjDRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAdjDRank.Location = new System.Drawing.Point(103, 42);
            this.cbAdjDRank.Name = "cbAdjDRank";
            this.cbAdjDRank.Size = new System.Drawing.Size(84, 17);
            this.cbAdjDRank.TabIndex = 3;
            this.cbAdjDRank.Text = "AdjD (Rank)";
            this.cbAdjDRank.UseVisualStyleBackColor = true;
            // 
            // cbAdjEM
            // 
            this.cbAdjEM.AutoSize = true;
            this.cbAdjEM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAdjEM.Location = new System.Drawing.Point(275, 19);
            this.cbAdjEM.Name = "cbAdjEM";
            this.cbAdjEM.Size = new System.Drawing.Size(57, 17);
            this.cbAdjEM.TabIndex = 2;
            this.cbAdjEM.Text = "AdjEM";
            this.cbAdjEM.UseVisualStyleBackColor = true;
            // 
            // cbWL
            // 
            this.cbWL.AutoSize = true;
            this.cbWL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWL.Location = new System.Drawing.Point(188, 19);
            this.cbWL.Name = "cbWL";
            this.cbWL.Size = new System.Drawing.Size(46, 17);
            this.cbWL.TabIndex = 1;
            this.cbWL.Text = "W-L";
            this.cbWL.UseVisualStyleBackColor = true;
            // 
            // cbConf
            // 
            this.cbConf.AutoSize = true;
            this.cbConf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbConf.Location = new System.Drawing.Point(103, 18);
            this.cbConf.Name = "cbConf";
            this.cbConf.Size = new System.Drawing.Size(48, 17);
            this.cbConf.TabIndex = 0;
            this.cbConf.Text = "Conf";
            this.cbConf.UseVisualStyleBackColor = true;
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.InitialDelay = 400;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 100;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 510);
            this.Controls.Add(this.gbSportsReference);
            this.Controls.Add(this.gbKenpom);
            this.Controls.Add(this.btnApply);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Add/Remove Stats";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.gbSportsReference.ResumeLayout(false);
            this.gbSportsReference.PerformLayout();
            this.gbDefensiveStats.ResumeLayout(false);
            this.gbDefensiveStats.PerformLayout();
            this.gbKenpom.ResumeLayout(false);
            this.gbKenpom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.CheckBox cbSRSelectAll;
        public System.Windows.Forms.GroupBox gbSportsReference;
        private System.Windows.Forms.CheckBox cbORB;
        private System.Windows.Forms.CheckBox cbPointsScored;
        private System.Windows.Forms.CheckBox cbeFG;
        private System.Windows.Forms.CheckBox cbSTL;
        private System.Windows.Forms.CheckBox cbTO;
        private System.Windows.Forms.CheckBox cbAST;
        private System.Windows.Forms.CheckBox cbBLK;
        private System.Windows.Forms.CheckBox cbFTFGA;
        private System.Windows.Forms.CheckBox cb3PTFGA;
        private System.Windows.Forms.CheckBox cbORtg;
        private System.Windows.Forms.CheckBox cbPace;
        public System.Windows.Forms.GroupBox gbKenpom;
        private System.Windows.Forms.CheckBox cbRank;
        private System.Windows.Forms.CheckBox cbOppDef;
        private System.Windows.Forms.CheckBox cbOppOff;
        private System.Windows.Forms.CheckBox cbLuckRank;
        private System.Windows.Forms.CheckBox cbSOS;
        private System.Windows.Forms.CheckBox cbAdjTRank;
        private System.Windows.Forms.CheckBox cbAdjORank;
        private System.Windows.Forms.CheckBox cbAdjDRank;
        private System.Windows.Forms.CheckBox cbAdjEM;
        private System.Windows.Forms.CheckBox cbWL;
        private System.Windows.Forms.CheckBox cbConf;
        private System.Windows.Forms.CheckBox cbKPSelectAll;
        private System.Windows.Forms.CheckBox cbFGA;
        private System.Windows.Forms.CheckBox cbAwayWL;
        private System.Windows.Forms.CheckBox cb3PA;
        private System.Windows.Forms.CheckBox cbFGPercentage;
        private System.Windows.Forms.CheckBox cb3PPercent;
        private System.Windows.Forms.CheckBox cbHomeWL;
        private System.Windows.Forms.GroupBox gbDefensiveStats;
        private System.Windows.Forms.CheckBox cbOpp3PPercentage;
        private System.Windows.Forms.CheckBox cbOppPace;
        private System.Windows.Forms.CheckBox cbOppPointsScored;
        private System.Windows.Forms.CheckBox cbOpp3PA;
        private System.Windows.Forms.CheckBox cbOppEFG;
        private System.Windows.Forms.CheckBox cbOppORB;
        private System.Windows.Forms.CheckBox cbOppFGPercentage;
        private System.Windows.Forms.CheckBox cbOppTOPercentage;
        private System.Windows.Forms.CheckBox cbOpp3PointRate;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}