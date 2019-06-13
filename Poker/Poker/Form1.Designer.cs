namespace Poker
{
    partial class Form1
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
            this.dicePanel5 = new Poker.DicePanel();
            this.dicePanel3 = new Poker.DicePanel();
            this.dicePanel4 = new Poker.DicePanel();
            this.dicePanel2 = new Poker.DicePanel();
            this.dicePanel1 = new Poker.DicePanel();
            this.pictureBoxRoll = new System.Windows.Forms.PictureBox();
            this.pictureBoxPass = new System.Windows.Forms.PictureBox();
            this.tableScore = new System.Windows.Forms.TableLayoutPanel();
            this.labelCategorySum = new System.Windows.Forms.Label();
            this.labelPause = new System.Windows.Forms.Label();
            this.labelCategoryPause = new System.Windows.Forms.Label();
            this.labelPointsChance = new System.Windows.Forms.Label();
            this.labelChance = new System.Windows.Forms.Label();
            this.labelPointsYahtzee = new System.Windows.Forms.Label();
            this.labelCategoryYahtzee = new System.Windows.Forms.Label();
            this.labelPointsLargeStraights = new System.Windows.Forms.Label();
            this.labelCategoryLargeStraight = new System.Windows.Forms.Label();
            this.labelPointsSmallStraights = new System.Windows.Forms.Label();
            this.labelCategorySmallStraight = new System.Windows.Forms.Label();
            this.labelPointsFullHouses = new System.Windows.Forms.Label();
            this.labelCategoryFullHouse = new System.Windows.Forms.Label();
            this.labelPointsFourKinds = new System.Windows.Forms.Label();
            this.labelCategoryFourKind = new System.Windows.Forms.Label();
            this.labelPointsThreeKinds = new System.Windows.Forms.Label();
            this.labelCategoryThreeKind = new System.Windows.Forms.Label();
            this.labelPointsSixes = new System.Windows.Forms.Label();
            this.labelCategorySixes = new System.Windows.Forms.Label();
            this.labelPointsFives = new System.Windows.Forms.Label();
            this.labelCategoryFives = new System.Windows.Forms.Label();
            this.labelPointsFours = new System.Windows.Forms.Label();
            this.labelCategoryFours = new System.Windows.Forms.Label();
            this.labelPointsThrees = new System.Windows.Forms.Label();
            this.labelCategoryThrees = new System.Windows.Forms.Label();
            this.labelPointsTwos = new System.Windows.Forms.Label();
            this.labelCategoryTwos = new System.Windows.Forms.Label();
            this.labelPointsAces = new System.Windows.Forms.Label();
            this.labelCategoryAces = new System.Windows.Forms.Label();
            this.labelPointsSum = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelPoints = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRoll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPass)).BeginInit();
            this.tableScore.SuspendLayout();
            this.SuspendLayout();
            // 
            // dicePanel5
            // 
            this.dicePanel5.Location = new System.Drawing.Point(587, 100);
            this.dicePanel5.Name = "dicePanel5";
            this.dicePanel5.Size = new System.Drawing.Size(99, 98);
            this.dicePanel5.TabIndex = 5;
            // 
            // dicePanel3
            // 
            this.dicePanel3.Location = new System.Drawing.Point(329, 100);
            this.dicePanel3.Name = "dicePanel3";
            this.dicePanel3.Size = new System.Drawing.Size(99, 98);
            this.dicePanel3.TabIndex = 3;
            // 
            // dicePanel4
            // 
            this.dicePanel4.Location = new System.Drawing.Point(466, 100);
            this.dicePanel4.Name = "dicePanel4";
            this.dicePanel4.Size = new System.Drawing.Size(99, 98);
            this.dicePanel4.TabIndex = 2;
            // 
            // dicePanel2
            // 
            this.dicePanel2.Location = new System.Drawing.Point(199, 100);
            this.dicePanel2.Name = "dicePanel2";
            this.dicePanel2.Size = new System.Drawing.Size(99, 98);
            this.dicePanel2.TabIndex = 1;
            // 
            // dicePanel1
            // 
            this.dicePanel1.Location = new System.Drawing.Point(61, 100);
            this.dicePanel1.Name = "dicePanel1";
            this.dicePanel1.Size = new System.Drawing.Size(99, 98);
            this.dicePanel1.TabIndex = 0;
            // 
            // pictureBoxRoll
            // 
            this.pictureBoxRoll.Image = global::Poker.Properties.Resources.DicePass;
            this.pictureBoxRoll.Location = new System.Drawing.Point(47, 307);
            this.pictureBoxRoll.Name = "pictureBoxRoll";
            this.pictureBoxRoll.Size = new System.Drawing.Size(304, 269);
            this.pictureBoxRoll.TabIndex = 8;
            this.pictureBoxRoll.TabStop = false;
            this.pictureBoxRoll.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBoxPass
            // 
            this.pictureBoxPass.Image = global::Poker.Properties.Resources.DiceRoll;
            this.pictureBoxPass.Location = new System.Drawing.Point(434, 307);
            this.pictureBoxPass.Name = "pictureBoxPass";
            this.pictureBoxPass.Size = new System.Drawing.Size(293, 278);
            this.pictureBoxPass.TabIndex = 7;
            this.pictureBoxPass.TabStop = false;
            this.pictureBoxPass.Click += new System.EventHandler(this.pictureBoxPass_Click);
            // 
            // tableScore
            // 
            this.tableScore.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tableScore.ColumnCount = 2;
            this.tableScore.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableScore.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableScore.Controls.Add(this.labelCategorySum, 0, 15);
            this.tableScore.Controls.Add(this.labelPause, 1, 14);
            this.tableScore.Controls.Add(this.labelCategoryPause, 0, 14);
            this.tableScore.Controls.Add(this.labelPointsChance, 1, 13);
            this.tableScore.Controls.Add(this.labelChance, 0, 13);
            this.tableScore.Controls.Add(this.labelPointsYahtzee, 1, 12);
            this.tableScore.Controls.Add(this.labelCategoryYahtzee, 0, 12);
            this.tableScore.Controls.Add(this.labelPointsLargeStraights, 1, 11);
            this.tableScore.Controls.Add(this.labelCategoryLargeStraight, 0, 11);
            this.tableScore.Controls.Add(this.labelPointsSmallStraights, 1, 10);
            this.tableScore.Controls.Add(this.labelCategorySmallStraight, 0, 10);
            this.tableScore.Controls.Add(this.labelPointsFullHouses, 1, 9);
            this.tableScore.Controls.Add(this.labelCategoryFullHouse, 0, 9);
            this.tableScore.Controls.Add(this.labelPointsFourKinds, 1, 8);
            this.tableScore.Controls.Add(this.labelCategoryFourKind, 0, 8);
            this.tableScore.Controls.Add(this.labelPointsThreeKinds, 1, 7);
            this.tableScore.Controls.Add(this.labelCategoryThreeKind, 0, 7);
            this.tableScore.Controls.Add(this.labelPointsSixes, 1, 6);
            this.tableScore.Controls.Add(this.labelCategorySixes, 0, 6);
            this.tableScore.Controls.Add(this.labelPointsFives, 1, 5);
            this.tableScore.Controls.Add(this.labelCategoryFives, 0, 5);
            this.tableScore.Controls.Add(this.labelPointsFours, 1, 4);
            this.tableScore.Controls.Add(this.labelCategoryFours, 0, 4);
            this.tableScore.Controls.Add(this.labelPointsThrees, 1, 3);
            this.tableScore.Controls.Add(this.labelCategoryThrees, 0, 3);
            this.tableScore.Controls.Add(this.labelPointsTwos, 1, 2);
            this.tableScore.Controls.Add(this.labelCategoryTwos, 0, 2);
            this.tableScore.Controls.Add(this.labelPointsAces, 1, 1);
            this.tableScore.Controls.Add(this.labelCategoryAces, 0, 1);
            this.tableScore.Controls.Add(this.labelPointsSum, 1, 15);
            this.tableScore.Controls.Add(this.labelCategory, 0, 0);
            this.tableScore.Controls.Add(this.labelPoints, 1, 0);
            this.tableScore.Location = new System.Drawing.Point(917, 114);
            this.tableScore.Name = "tableScore";
            this.tableScore.RowCount = 16;
            this.tableScore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableScore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableScore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableScore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableScore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableScore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableScore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableScore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableScore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableScore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableScore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableScore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableScore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableScore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableScore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableScore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableScore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableScore.Size = new System.Drawing.Size(200, 417);
            this.tableScore.TabIndex = 9;
            this.tableScore.Paint += new System.Windows.Forms.PaintEventHandler(this.tableScore_Paint);
            // 
            // labelCategorySum
            // 
            this.labelCategorySum.AutoSize = true;
            this.labelCategorySum.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCategorySum.Location = new System.Drawing.Point(3, 390);
            this.labelCategorySum.Name = "labelCategorySum";
            this.labelCategorySum.Size = new System.Drawing.Size(28, 13);
            this.labelCategorySum.TabIndex = 33;
            this.labelCategorySum.Text = "Sum";
            // 
            // labelPause
            // 
            this.labelPause.AutoSize = true;
            this.labelPause.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPause.Location = new System.Drawing.Point(103, 364);
            this.labelPause.Name = "labelPause";
            this.labelPause.Size = new System.Drawing.Size(91, 26);
            this.labelPause.TabIndex = 30;
            this.labelPause.Text = "====================================";
            // 
            // labelCategoryPause
            // 
            this.labelCategoryPause.AutoSize = true;
            this.labelCategoryPause.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCategoryPause.Location = new System.Drawing.Point(3, 364);
            this.labelCategoryPause.Name = "labelCategoryPause";
            this.labelCategoryPause.Size = new System.Drawing.Size(91, 26);
            this.labelCategoryPause.TabIndex = 29;
            this.labelCategoryPause.Text = "=============================================";
            // 
            // labelPointsChance
            // 
            this.labelPointsChance.AutoSize = true;
            this.labelPointsChance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPointsChance.Location = new System.Drawing.Point(103, 338);
            this.labelPointsChance.Name = "labelPointsChance";
            this.labelPointsChance.Size = new System.Drawing.Size(16, 13);
            this.labelPointsChance.TabIndex = 28;
            this.labelPointsChance.Text = "-1";
            // 
            // labelChance
            // 
            this.labelChance.AutoSize = true;
            this.labelChance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelChance.Location = new System.Drawing.Point(3, 338);
            this.labelChance.Name = "labelChance";
            this.labelChance.Size = new System.Drawing.Size(44, 13);
            this.labelChance.TabIndex = 27;
            this.labelChance.Text = "Chance";
            // 
            // labelPointsYahtzee
            // 
            this.labelPointsYahtzee.AutoSize = true;
            this.labelPointsYahtzee.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPointsYahtzee.Location = new System.Drawing.Point(103, 312);
            this.labelPointsYahtzee.Name = "labelPointsYahtzee";
            this.labelPointsYahtzee.Size = new System.Drawing.Size(16, 13);
            this.labelPointsYahtzee.TabIndex = 26;
            this.labelPointsYahtzee.Text = "-1";
            // 
            // labelCategoryYahtzee
            // 
            this.labelCategoryYahtzee.AutoSize = true;
            this.labelCategoryYahtzee.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCategoryYahtzee.Location = new System.Drawing.Point(3, 312);
            this.labelCategoryYahtzee.Name = "labelCategoryYahtzee";
            this.labelCategoryYahtzee.Size = new System.Drawing.Size(46, 13);
            this.labelCategoryYahtzee.TabIndex = 25;
            this.labelCategoryYahtzee.Text = "Yahtzee";
            // 
            // labelPointsLargeStraights
            // 
            this.labelPointsLargeStraights.AutoSize = true;
            this.labelPointsLargeStraights.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPointsLargeStraights.Location = new System.Drawing.Point(103, 286);
            this.labelPointsLargeStraights.Name = "labelPointsLargeStraights";
            this.labelPointsLargeStraights.Size = new System.Drawing.Size(16, 13);
            this.labelPointsLargeStraights.TabIndex = 24;
            this.labelPointsLargeStraights.Text = "-1";
            // 
            // labelCategoryLargeStraight
            // 
            this.labelCategoryLargeStraight.AutoSize = true;
            this.labelCategoryLargeStraight.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCategoryLargeStraight.Location = new System.Drawing.Point(3, 286);
            this.labelCategoryLargeStraight.Name = "labelCategoryLargeStraight";
            this.labelCategoryLargeStraight.Size = new System.Drawing.Size(78, 13);
            this.labelCategoryLargeStraight.TabIndex = 23;
            this.labelCategoryLargeStraight.Text = "Large Straights";
            // 
            // labelPointsSmallStraights
            // 
            this.labelPointsSmallStraights.AutoSize = true;
            this.labelPointsSmallStraights.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPointsSmallStraights.Location = new System.Drawing.Point(103, 260);
            this.labelPointsSmallStraights.Name = "labelPointsSmallStraights";
            this.labelPointsSmallStraights.Size = new System.Drawing.Size(16, 13);
            this.labelPointsSmallStraights.TabIndex = 22;
            this.labelPointsSmallStraights.Text = "-1";
            // 
            // labelCategorySmallStraight
            // 
            this.labelCategorySmallStraight.AutoSize = true;
            this.labelCategorySmallStraight.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCategorySmallStraight.Location = new System.Drawing.Point(3, 260);
            this.labelCategorySmallStraight.Name = "labelCategorySmallStraight";
            this.labelCategorySmallStraight.Size = new System.Drawing.Size(76, 13);
            this.labelCategorySmallStraight.TabIndex = 21;
            this.labelCategorySmallStraight.Text = "Small Straights";
            // 
            // labelPointsFullHouses
            // 
            this.labelPointsFullHouses.AutoSize = true;
            this.labelPointsFullHouses.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPointsFullHouses.Location = new System.Drawing.Point(103, 234);
            this.labelPointsFullHouses.Name = "labelPointsFullHouses";
            this.labelPointsFullHouses.Size = new System.Drawing.Size(16, 13);
            this.labelPointsFullHouses.TabIndex = 20;
            this.labelPointsFullHouses.Text = "-1";
            // 
            // labelCategoryFullHouse
            // 
            this.labelCategoryFullHouse.AutoSize = true;
            this.labelCategoryFullHouse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCategoryFullHouse.Location = new System.Drawing.Point(3, 234);
            this.labelCategoryFullHouse.Name = "labelCategoryFullHouse";
            this.labelCategoryFullHouse.Size = new System.Drawing.Size(62, 13);
            this.labelCategoryFullHouse.TabIndex = 19;
            this.labelCategoryFullHouse.Text = "Full Houses";
            // 
            // labelPointsFourKinds
            // 
            this.labelPointsFourKinds.AutoSize = true;
            this.labelPointsFourKinds.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPointsFourKinds.Location = new System.Drawing.Point(103, 208);
            this.labelPointsFourKinds.Name = "labelPointsFourKinds";
            this.labelPointsFourKinds.Size = new System.Drawing.Size(16, 13);
            this.labelPointsFourKinds.TabIndex = 18;
            this.labelPointsFourKinds.Text = "-1";
            // 
            // labelCategoryFourKind
            // 
            this.labelCategoryFourKind.AutoSize = true;
            this.labelCategoryFourKind.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCategoryFourKind.Location = new System.Drawing.Point(3, 208);
            this.labelCategoryFourKind.Name = "labelCategoryFourKind";
            this.labelCategoryFourKind.Size = new System.Drawing.Size(57, 13);
            this.labelCategoryFourKind.TabIndex = 17;
            this.labelCategoryFourKind.Text = "Four Kinds";
            // 
            // labelPointsThreeKinds
            // 
            this.labelPointsThreeKinds.AutoSize = true;
            this.labelPointsThreeKinds.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPointsThreeKinds.Location = new System.Drawing.Point(103, 182);
            this.labelPointsThreeKinds.Name = "labelPointsThreeKinds";
            this.labelPointsThreeKinds.Size = new System.Drawing.Size(16, 13);
            this.labelPointsThreeKinds.TabIndex = 16;
            this.labelPointsThreeKinds.Text = "-1";
            // 
            // labelCategoryThreeKind
            // 
            this.labelCategoryThreeKind.AutoSize = true;
            this.labelCategoryThreeKind.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCategoryThreeKind.Location = new System.Drawing.Point(3, 182);
            this.labelCategoryThreeKind.Name = "labelCategoryThreeKind";
            this.labelCategoryThreeKind.Size = new System.Drawing.Size(64, 13);
            this.labelCategoryThreeKind.TabIndex = 15;
            this.labelCategoryThreeKind.Text = "Three Kinds";
            // 
            // labelPointsSixes
            // 
            this.labelPointsSixes.AutoSize = true;
            this.labelPointsSixes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPointsSixes.Location = new System.Drawing.Point(103, 156);
            this.labelPointsSixes.Name = "labelPointsSixes";
            this.labelPointsSixes.Size = new System.Drawing.Size(16, 13);
            this.labelPointsSixes.TabIndex = 14;
            this.labelPointsSixes.Text = "-1";
            // 
            // labelCategorySixes
            // 
            this.labelCategorySixes.AutoSize = true;
            this.labelCategorySixes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCategorySixes.Location = new System.Drawing.Point(3, 156);
            this.labelCategorySixes.Name = "labelCategorySixes";
            this.labelCategorySixes.Size = new System.Drawing.Size(32, 13);
            this.labelCategorySixes.TabIndex = 13;
            this.labelCategorySixes.Text = "Sixes";
            // 
            // labelPointsFives
            // 
            this.labelPointsFives.AutoSize = true;
            this.labelPointsFives.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPointsFives.Location = new System.Drawing.Point(103, 130);
            this.labelPointsFives.Name = "labelPointsFives";
            this.labelPointsFives.Size = new System.Drawing.Size(16, 13);
            this.labelPointsFives.TabIndex = 12;
            this.labelPointsFives.Text = "-1";
            // 
            // labelCategoryFives
            // 
            this.labelCategoryFives.AutoSize = true;
            this.labelCategoryFives.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCategoryFives.Location = new System.Drawing.Point(3, 130);
            this.labelCategoryFives.Name = "labelCategoryFives";
            this.labelCategoryFives.Size = new System.Drawing.Size(32, 13);
            this.labelCategoryFives.TabIndex = 11;
            this.labelCategoryFives.Text = "Fives";
            // 
            // labelPointsFours
            // 
            this.labelPointsFours.AutoSize = true;
            this.labelPointsFours.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPointsFours.Location = new System.Drawing.Point(103, 104);
            this.labelPointsFours.Name = "labelPointsFours";
            this.labelPointsFours.Size = new System.Drawing.Size(16, 13);
            this.labelPointsFours.TabIndex = 10;
            this.labelPointsFours.Text = "-1";
            // 
            // labelCategoryFours
            // 
            this.labelCategoryFours.AutoSize = true;
            this.labelCategoryFours.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCategoryFours.Location = new System.Drawing.Point(3, 104);
            this.labelCategoryFours.Name = "labelCategoryFours";
            this.labelCategoryFours.Size = new System.Drawing.Size(33, 13);
            this.labelCategoryFours.TabIndex = 9;
            this.labelCategoryFours.Text = "Fours";
            // 
            // labelPointsThrees
            // 
            this.labelPointsThrees.AutoSize = true;
            this.labelPointsThrees.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPointsThrees.Location = new System.Drawing.Point(103, 78);
            this.labelPointsThrees.Name = "labelPointsThrees";
            this.labelPointsThrees.Size = new System.Drawing.Size(16, 13);
            this.labelPointsThrees.TabIndex = 8;
            this.labelPointsThrees.Text = "-1";
            // 
            // labelCategoryThrees
            // 
            this.labelCategoryThrees.AutoSize = true;
            this.labelCategoryThrees.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCategoryThrees.Location = new System.Drawing.Point(3, 78);
            this.labelCategoryThrees.Name = "labelCategoryThrees";
            this.labelCategoryThrees.Size = new System.Drawing.Size(40, 13);
            this.labelCategoryThrees.TabIndex = 7;
            this.labelCategoryThrees.Text = "Threes";
            // 
            // labelPointsTwos
            // 
            this.labelPointsTwos.AutoSize = true;
            this.labelPointsTwos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPointsTwos.Location = new System.Drawing.Point(103, 52);
            this.labelPointsTwos.Name = "labelPointsTwos";
            this.labelPointsTwos.Size = new System.Drawing.Size(16, 13);
            this.labelPointsTwos.TabIndex = 6;
            this.labelPointsTwos.Text = "-1";
            // 
            // labelCategoryTwos
            // 
            this.labelCategoryTwos.AutoSize = true;
            this.labelCategoryTwos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCategoryTwos.Location = new System.Drawing.Point(3, 52);
            this.labelCategoryTwos.Name = "labelCategoryTwos";
            this.labelCategoryTwos.Size = new System.Drawing.Size(33, 13);
            this.labelCategoryTwos.TabIndex = 5;
            this.labelCategoryTwos.Text = "Twos";
            // 
            // labelPointsAces
            // 
            this.labelPointsAces.AutoSize = true;
            this.labelPointsAces.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPointsAces.Location = new System.Drawing.Point(103, 26);
            this.labelPointsAces.Name = "labelPointsAces";
            this.labelPointsAces.Size = new System.Drawing.Size(16, 13);
            this.labelPointsAces.TabIndex = 4;
            this.labelPointsAces.Text = "-1";
            this.labelPointsAces.Click += new System.EventHandler(this.labelPointsAces_Click);
            // 
            // labelCategoryAces
            // 
            this.labelCategoryAces.AutoSize = true;
            this.labelCategoryAces.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCategoryAces.Location = new System.Drawing.Point(3, 26);
            this.labelCategoryAces.Name = "labelCategoryAces";
            this.labelCategoryAces.Size = new System.Drawing.Size(31, 13);
            this.labelCategoryAces.TabIndex = 3;
            this.labelCategoryAces.Text = "Aces";
            // 
            // labelPointsSum
            // 
            this.labelPointsSum.AutoSize = true;
            this.labelPointsSum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPointsSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPointsSum.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPointsSum.Location = new System.Drawing.Point(103, 390);
            this.labelPointsSum.Name = "labelPointsSum";
            this.labelPointsSum.Size = new System.Drawing.Size(94, 27);
            this.labelPointsSum.TabIndex = 0;
            this.labelPointsSum.Text = "0";
            this.labelPointsSum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCategory.Location = new System.Drawing.Point(3, 0);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(49, 13);
            this.labelCategory.TabIndex = 1;
            this.labelCategory.Text = "Category";
            this.labelCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPoints
            // 
            this.labelPoints.AutoSize = true;
            this.labelPoints.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPoints.Location = new System.Drawing.Point(103, 0);
            this.labelPoints.Name = "labelPoints";
            this.labelPoints.Size = new System.Drawing.Size(36, 13);
            this.labelPoints.TabIndex = 2;
            this.labelPoints.Text = "Points";
            this.labelPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1187, 620);
            this.Controls.Add(this.tableScore);
            this.Controls.Add(this.pictureBoxRoll);
            this.Controls.Add(this.pictureBoxPass);
            this.Controls.Add(this.dicePanel5);
            this.Controls.Add(this.dicePanel3);
            this.Controls.Add(this.dicePanel4);
            this.Controls.Add(this.dicePanel2);
            this.Controls.Add(this.dicePanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRoll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPass)).EndInit();
            this.tableScore.ResumeLayout(false);
            this.tableScore.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DicePanel dicePanel1;
        private DicePanel dicePanel2;
        private DicePanel dicePanel3;
        private DicePanel dicePanel4;
        private DicePanel dicePanel5;
        private System.Windows.Forms.PictureBox pictureBoxPass;
        private System.Windows.Forms.PictureBox pictureBoxRoll;
        private System.Windows.Forms.TableLayoutPanel tableScore;
        private System.Windows.Forms.Label labelPointsSum;
        private System.Windows.Forms.Label labelCategorySum;
        private System.Windows.Forms.Label labelPause;
        private System.Windows.Forms.Label labelCategoryPause;
        private System.Windows.Forms.Label labelPointsChance;
        private System.Windows.Forms.Label labelChance;
        private System.Windows.Forms.Label labelPointsYahtzee;
        private System.Windows.Forms.Label labelCategoryYahtzee;
        private System.Windows.Forms.Label labelPointsLargeStraights;
        private System.Windows.Forms.Label labelCategoryLargeStraight;
        private System.Windows.Forms.Label labelPointsSmallStraights;
        private System.Windows.Forms.Label labelCategorySmallStraight;
        private System.Windows.Forms.Label labelPointsFullHouses;
        private System.Windows.Forms.Label labelCategoryFullHouse;
        private System.Windows.Forms.Label labelPointsFourKinds;
        private System.Windows.Forms.Label labelCategoryFourKind;
        private System.Windows.Forms.Label labelPointsThreeKinds;
        private System.Windows.Forms.Label labelCategoryThreeKind;
        private System.Windows.Forms.Label labelPointsSixes;
        private System.Windows.Forms.Label labelCategorySixes;
        private System.Windows.Forms.Label labelPointsFives;
        private System.Windows.Forms.Label labelCategoryFives;
        private System.Windows.Forms.Label labelPointsFours;
        private System.Windows.Forms.Label labelCategoryFours;
        private System.Windows.Forms.Label labelPointsThrees;
        private System.Windows.Forms.Label labelCategoryThrees;
        private System.Windows.Forms.Label labelPointsTwos;
        private System.Windows.Forms.Label labelCategoryTwos;
        private System.Windows.Forms.Label labelPointsAces;
        private System.Windows.Forms.Label labelCategoryAces;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelPoints;
    }
}

