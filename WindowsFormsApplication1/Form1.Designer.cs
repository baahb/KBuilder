namespace WindowsFormsApplication1
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
            this.stabRollButton = new System.Windows.Forms.Button();
            this.StabilityTabControl = new System.Windows.Forms.TabControl();
            this.sStabRollTab = new System.Windows.Forms.TabPage();
            this.StabDiceRollText = new System.Windows.Forms.TextBox();
            this.PostStabilityUnrestInfo = new System.Windows.Forms.TextBox();
            this.PostRollStabilityInfoBox = new System.Windows.Forms.TextBox();
            this.StabilityInfoBox = new System.Windows.Forms.TextBox();
            this.sConsumptionTab = new System.Windows.Forms.TabPage();
            this.PostConsumptionDebtNote = new System.Windows.Forms.TextBox();
            this.PostConsumptionInfoBox = new System.Windows.Forms.TextBox();
            this.ConsumptionInfoBox = new System.Windows.Forms.TextBox();
            this.consumptionPaymentButton = new System.Windows.Forms.Button();
            this.sUnrestTab = new System.Windows.Forms.TabPage();
            this.PostUnrestInfoBox = new System.Windows.Forms.TextBox();
            this.UnrestInfoBox = new System.Windows.Forms.TextBox();
            this.modifyUnrestButton = new System.Windows.Forms.Button();
            this.PrimaryTabControl = new System.Windows.Forms.TabControl();
            this.PrimaryTabPageUpkeep = new System.Windows.Forms.TabPage();
            this.PrimaryTabPageEdicts = new System.Windows.Forms.TabPage();
            this.EdictTabControl = new System.Windows.Forms.TabControl();
            this.eLeadershipTab = new System.Windows.Forms.TabPage();
            this.LeaderSelectBox = new System.Windows.Forms.ComboBox();
            this.eHexesTab = new System.Windows.Forms.TabPage();
            this.eTerrainTab = new System.Windows.Forms.TabPage();
            this.eSettlementTab = new System.Windows.Forms.TabPage();
            this.eArmyTab = new System.Windows.Forms.TabPage();
            this.eEdictTab = new System.Windows.Forms.TabPage();
            this.PrimaryTabPageIncome = new System.Windows.Forms.TabPage();
            this.IncomeTabControl = new System.Windows.Forms.TabControl();
            this.iWithdrawalTab = new System.Windows.Forms.TabPage();
            this.iDepositsTab = new System.Windows.Forms.TabPage();
            this.iSellItemsTab = new System.Windows.Forms.TabPage();
            this.iTaxesTab = new System.Windows.Forms.TabPage();
            this.PrimaryTabPageEvents = new System.Windows.Forms.TabPage();
            this.ChangeLeaderYesButton = new System.Windows.Forms.Button();
            this.LeaderShipYN = new System.Windows.Forms.TextBox();
            this.ChangeLeaderNoButton = new System.Windows.Forms.Button();
            this.LeadershipRoleQuestion = new System.Windows.Forms.TextBox();
            this.LeaderNameLabel = new System.Windows.Forms.Label();
            this.LeaderNameField = new System.Windows.Forms.TextBox();
            this.LeaderBonusLabel = new System.Windows.Forms.Label();
            this.LeaderBonusField = new System.Windows.Forms.MaskedTextBox();
            this.StabilityTabControl.SuspendLayout();
            this.sStabRollTab.SuspendLayout();
            this.sConsumptionTab.SuspendLayout();
            this.sUnrestTab.SuspendLayout();
            this.PrimaryTabControl.SuspendLayout();
            this.PrimaryTabPageUpkeep.SuspendLayout();
            this.PrimaryTabPageEdicts.SuspendLayout();
            this.EdictTabControl.SuspendLayout();
            this.eLeadershipTab.SuspendLayout();
            this.PrimaryTabPageIncome.SuspendLayout();
            this.IncomeTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // stabRollButton
            // 
            this.stabRollButton.Location = new System.Drawing.Point(164, 135);
            this.stabRollButton.Name = "stabRollButton";
            this.stabRollButton.Size = new System.Drawing.Size(121, 23);
            this.stabRollButton.TabIndex = 0;
            this.stabRollButton.Text = "Roll for Stability";
            this.stabRollButton.UseVisualStyleBackColor = true;
            this.stabRollButton.Click += new System.EventHandler(this.stabRollButton_Click);
            // 
            // StabilityTabControl
            // 
            this.StabilityTabControl.AccessibleName = "";
            this.StabilityTabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.StabilityTabControl.Controls.Add(this.sStabRollTab);
            this.StabilityTabControl.Controls.Add(this.sConsumptionTab);
            this.StabilityTabControl.Controls.Add(this.sUnrestTab);
            this.StabilityTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StabilityTabControl.Location = new System.Drawing.Point(3, 3);
            this.StabilityTabControl.Multiline = true;
            this.StabilityTabControl.Name = "StabilityTabControl";
            this.StabilityTabControl.SelectedIndex = 0;
            this.StabilityTabControl.Size = new System.Drawing.Size(471, 319);
            this.StabilityTabControl.TabIndex = 1;
            // 
            // sStabRollTab
            // 
            this.sStabRollTab.Controls.Add(this.StabDiceRollText);
            this.sStabRollTab.Controls.Add(this.PostStabilityUnrestInfo);
            this.sStabRollTab.Controls.Add(this.PostRollStabilityInfoBox);
            this.sStabRollTab.Controls.Add(this.StabilityInfoBox);
            this.sStabRollTab.Controls.Add(this.stabRollButton);
            this.sStabRollTab.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sStabRollTab.Location = new System.Drawing.Point(23, 4);
            this.sStabRollTab.Name = "sStabRollTab";
            this.sStabRollTab.Padding = new System.Windows.Forms.Padding(3);
            this.sStabRollTab.Size = new System.Drawing.Size(444, 311);
            this.sStabRollTab.TabIndex = 0;
            this.sStabRollTab.Text = "Stability Roll";
            this.sStabRollTab.UseVisualStyleBackColor = true;
            // 
            // StabDiceRollText
            // 
            this.StabDiceRollText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StabDiceRollText.Location = new System.Drawing.Point(71, 164);
            this.StabDiceRollText.Name = "StabDiceRollText";
            this.StabDiceRollText.Size = new System.Drawing.Size(301, 13);
            this.StabDiceRollText.TabIndex = 5;
            this.StabDiceRollText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.StabDiceRollText.Visible = false;
            // 
            // PostStabilityUnrestInfo
            // 
            this.PostStabilityUnrestInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PostStabilityUnrestInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PostStabilityUnrestInfo.Location = new System.Drawing.Point(71, 194);
            this.PostStabilityUnrestInfo.Name = "PostStabilityUnrestInfo";
            this.PostStabilityUnrestInfo.Size = new System.Drawing.Size(301, 13);
            this.PostStabilityUnrestInfo.TabIndex = 4;
            this.PostStabilityUnrestInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PostStabilityUnrestInfo.Visible = false;
            // 
            // PostRollStabilityInfoBox
            // 
            this.PostRollStabilityInfoBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PostRollStabilityInfoBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PostRollStabilityInfoBox.Location = new System.Drawing.Point(124, 213);
            this.PostRollStabilityInfoBox.Multiline = true;
            this.PostRollStabilityInfoBox.Name = "PostRollStabilityInfoBox";
            this.PostRollStabilityInfoBox.ReadOnly = true;
            this.PostRollStabilityInfoBox.Size = new System.Drawing.Size(198, 36);
            this.PostRollStabilityInfoBox.TabIndex = 2;
            this.PostRollStabilityInfoBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PostRollStabilityInfoBox.Visible = false;
            // 
            // StabilityInfoBox
            // 
            this.StabilityInfoBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.StabilityInfoBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StabilityInfoBox.Location = new System.Drawing.Point(124, 87);
            this.StabilityInfoBox.Multiline = true;
            this.StabilityInfoBox.Name = "StabilityInfoBox";
            this.StabilityInfoBox.ReadOnly = true;
            this.StabilityInfoBox.Size = new System.Drawing.Size(199, 42);
            this.StabilityInfoBox.TabIndex = 1;
            this.StabilityInfoBox.Text = "Your Stability is //placeholder .\r\n Your Unrest is //placeholder .";
            this.StabilityInfoBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sConsumptionTab
            // 
            this.sConsumptionTab.Controls.Add(this.PostConsumptionDebtNote);
            this.sConsumptionTab.Controls.Add(this.PostConsumptionInfoBox);
            this.sConsumptionTab.Controls.Add(this.ConsumptionInfoBox);
            this.sConsumptionTab.Controls.Add(this.consumptionPaymentButton);
            this.sConsumptionTab.Location = new System.Drawing.Point(23, 4);
            this.sConsumptionTab.Name = "sConsumptionTab";
            this.sConsumptionTab.Padding = new System.Windows.Forms.Padding(3);
            this.sConsumptionTab.Size = new System.Drawing.Size(444, 311);
            this.sConsumptionTab.TabIndex = 1;
            this.sConsumptionTab.Text = "Consumption";
            this.sConsumptionTab.UseVisualStyleBackColor = true;
            // 
            // PostConsumptionDebtNote
            // 
            this.PostConsumptionDebtNote.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PostConsumptionDebtNote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PostConsumptionDebtNote.Location = new System.Drawing.Point(124, 216);
            this.PostConsumptionDebtNote.Multiline = true;
            this.PostConsumptionDebtNote.Name = "PostConsumptionDebtNote";
            this.PostConsumptionDebtNote.ReadOnly = true;
            this.PostConsumptionDebtNote.Size = new System.Drawing.Size(198, 18);
            this.PostConsumptionDebtNote.TabIndex = 6;
            this.PostConsumptionDebtNote.Text = "Consumption results placeholder text";
            this.PostConsumptionDebtNote.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PostConsumptionDebtNote.Visible = false;
            // 
            // PostConsumptionInfoBox
            // 
            this.PostConsumptionInfoBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PostConsumptionInfoBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PostConsumptionInfoBox.Location = new System.Drawing.Point(124, 171);
            this.PostConsumptionInfoBox.Multiline = true;
            this.PostConsumptionInfoBox.Name = "PostConsumptionInfoBox";
            this.PostConsumptionInfoBox.ReadOnly = true;
            this.PostConsumptionInfoBox.Size = new System.Drawing.Size(198, 18);
            this.PostConsumptionInfoBox.TabIndex = 5;
            this.PostConsumptionInfoBox.Text = "Consumption results placeholder text";
            this.PostConsumptionInfoBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PostConsumptionInfoBox.Visible = false;
            // 
            // ConsumptionInfoBox
            // 
            this.ConsumptionInfoBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ConsumptionInfoBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ConsumptionInfoBox.Location = new System.Drawing.Point(124, 87);
            this.ConsumptionInfoBox.Multiline = true;
            this.ConsumptionInfoBox.Name = "ConsumptionInfoBox";
            this.ConsumptionInfoBox.ReadOnly = true;
            this.ConsumptionInfoBox.Size = new System.Drawing.Size(199, 42);
            this.ConsumptionInfoBox.TabIndex = 4;
            this.ConsumptionInfoBox.Text = "Your Treasury holds X BP. \r\nYou\'ll lose Y BP for consumption costs.\r\n";
            this.ConsumptionInfoBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ConsumptionInfoBox.TextChanged += new System.EventHandler(this.sConsumptionTab_Click);
            // 
            // consumptionPaymentButton
            // 
            this.consumptionPaymentButton.Location = new System.Drawing.Point(164, 135);
            this.consumptionPaymentButton.Name = "consumptionPaymentButton";
            this.consumptionPaymentButton.Size = new System.Drawing.Size(121, 23);
            this.consumptionPaymentButton.TabIndex = 0;
            this.consumptionPaymentButton.Text = "Pay Consumption";
            this.consumptionPaymentButton.UseVisualStyleBackColor = true;
            this.consumptionPaymentButton.Click += new System.EventHandler(this.consumptionPaymentButton_Click);
            // 
            // sUnrestTab
            // 
            this.sUnrestTab.BackColor = System.Drawing.Color.Transparent;
            this.sUnrestTab.Controls.Add(this.PostUnrestInfoBox);
            this.sUnrestTab.Controls.Add(this.UnrestInfoBox);
            this.sUnrestTab.Controls.Add(this.modifyUnrestButton);
            this.sUnrestTab.Location = new System.Drawing.Point(23, 4);
            this.sUnrestTab.Name = "sUnrestTab";
            this.sUnrestTab.Padding = new System.Windows.Forms.Padding(3);
            this.sUnrestTab.Size = new System.Drawing.Size(444, 311);
            this.sUnrestTab.TabIndex = 3;
            this.sUnrestTab.Text = "Unrest";
            this.sUnrestTab.UseVisualStyleBackColor = true;
            // 
            // PostUnrestInfoBox
            // 
            this.PostUnrestInfoBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PostUnrestInfoBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PostUnrestInfoBox.Location = new System.Drawing.Point(124, 171);
            this.PostUnrestInfoBox.Multiline = true;
            this.PostUnrestInfoBox.Name = "PostUnrestInfoBox";
            this.PostUnrestInfoBox.ReadOnly = true;
            this.PostUnrestInfoBox.Size = new System.Drawing.Size(198, 108);
            this.PostUnrestInfoBox.TabIndex = 5;
            this.PostUnrestInfoBox.Text = "Unrest modification results placeholder text";
            this.PostUnrestInfoBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UnrestInfoBox
            // 
            this.UnrestInfoBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.UnrestInfoBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UnrestInfoBox.Location = new System.Drawing.Point(124, 87);
            this.UnrestInfoBox.Multiline = true;
            this.UnrestInfoBox.Name = "UnrestInfoBox";
            this.UnrestInfoBox.ReadOnly = true;
            this.UnrestInfoBox.Size = new System.Drawing.Size(199, 42);
            this.UnrestInfoBox.TabIndex = 4;
            this.UnrestInfoBox.Text = "Do you wish to try to reduce your unrest?\r\nYour Unrest Modifier is {1}.";
            this.UnrestInfoBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // modifyUnrestButton
            // 
            this.modifyUnrestButton.Location = new System.Drawing.Point(164, 135);
            this.modifyUnrestButton.Name = "modifyUnrestButton";
            this.modifyUnrestButton.Size = new System.Drawing.Size(121, 23);
            this.modifyUnrestButton.TabIndex = 3;
            this.modifyUnrestButton.Text = "Modify Unrest";
            this.modifyUnrestButton.UseVisualStyleBackColor = true;
            this.modifyUnrestButton.Click += new System.EventHandler(this.modifyUnrestButton_Click);
            // 
            // PrimaryTabControl
            // 
            this.PrimaryTabControl.Controls.Add(this.PrimaryTabPageUpkeep);
            this.PrimaryTabControl.Controls.Add(this.PrimaryTabPageEdicts);
            this.PrimaryTabControl.Controls.Add(this.PrimaryTabPageIncome);
            this.PrimaryTabControl.Controls.Add(this.PrimaryTabPageEvents);
            this.PrimaryTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PrimaryTabControl.Location = new System.Drawing.Point(0, 0);
            this.PrimaryTabControl.Name = "PrimaryTabControl";
            this.PrimaryTabControl.SelectedIndex = 0;
            this.PrimaryTabControl.Size = new System.Drawing.Size(485, 351);
            this.PrimaryTabControl.TabIndex = 2;
            // 
            // PrimaryTabPageUpkeep
            // 
            this.PrimaryTabPageUpkeep.Controls.Add(this.StabilityTabControl);
            this.PrimaryTabPageUpkeep.Location = new System.Drawing.Point(4, 22);
            this.PrimaryTabPageUpkeep.Name = "PrimaryTabPageUpkeep";
            this.PrimaryTabPageUpkeep.Padding = new System.Windows.Forms.Padding(3);
            this.PrimaryTabPageUpkeep.Size = new System.Drawing.Size(477, 325);
            this.PrimaryTabPageUpkeep.TabIndex = 0;
            this.PrimaryTabPageUpkeep.Text = "Upkeep Phase";
            this.PrimaryTabPageUpkeep.UseVisualStyleBackColor = true;
            // 
            // PrimaryTabPageEdicts
            // 
            this.PrimaryTabPageEdicts.Controls.Add(this.EdictTabControl);
            this.PrimaryTabPageEdicts.Location = new System.Drawing.Point(4, 22);
            this.PrimaryTabPageEdicts.Name = "PrimaryTabPageEdicts";
            this.PrimaryTabPageEdicts.Padding = new System.Windows.Forms.Padding(3);
            this.PrimaryTabPageEdicts.Size = new System.Drawing.Size(477, 325);
            this.PrimaryTabPageEdicts.TabIndex = 1;
            this.PrimaryTabPageEdicts.Text = "Edict Phase";
            this.PrimaryTabPageEdicts.UseVisualStyleBackColor = true;
            // 
            // EdictTabControl
            // 
            this.EdictTabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.EdictTabControl.Controls.Add(this.eLeadershipTab);
            this.EdictTabControl.Controls.Add(this.eHexesTab);
            this.EdictTabControl.Controls.Add(this.eTerrainTab);
            this.EdictTabControl.Controls.Add(this.eSettlementTab);
            this.EdictTabControl.Controls.Add(this.eArmyTab);
            this.EdictTabControl.Controls.Add(this.eEdictTab);
            this.EdictTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EdictTabControl.Location = new System.Drawing.Point(3, 3);
            this.EdictTabControl.Multiline = true;
            this.EdictTabControl.Name = "EdictTabControl";
            this.EdictTabControl.SelectedIndex = 0;
            this.EdictTabControl.Size = new System.Drawing.Size(471, 319);
            this.EdictTabControl.TabIndex = 0;
            // 
            // eLeadershipTab
            // 
            this.eLeadershipTab.Controls.Add(this.LeaderBonusField);
            this.eLeadershipTab.Controls.Add(this.LeaderBonusLabel);
            this.eLeadershipTab.Controls.Add(this.LeaderNameField);
            this.eLeadershipTab.Controls.Add(this.LeaderNameLabel);
            this.eLeadershipTab.Controls.Add(this.LeadershipRoleQuestion);
            this.eLeadershipTab.Controls.Add(this.ChangeLeaderNoButton);
            this.eLeadershipTab.Controls.Add(this.LeaderShipYN);
            this.eLeadershipTab.Controls.Add(this.ChangeLeaderYesButton);
            this.eLeadershipTab.Controls.Add(this.LeaderSelectBox);
            this.eLeadershipTab.Location = new System.Drawing.Point(23, 4);
            this.eLeadershipTab.Name = "eLeadershipTab";
            this.eLeadershipTab.Padding = new System.Windows.Forms.Padding(3);
            this.eLeadershipTab.Size = new System.Drawing.Size(444, 311);
            this.eLeadershipTab.TabIndex = 0;
            this.eLeadershipTab.Text = "Leadership";
            this.eLeadershipTab.UseVisualStyleBackColor = true;
            // 
            // LeaderSelectBox
            // 
            this.LeaderSelectBox.FormattingEnabled = true;
            this.LeaderSelectBox.Items.AddRange(new object[] {
            "Ruler",
            "Consort",
            "Councilor",
            "General",
            "Grand Diplomat",
            "Heir",
            "High Priest",
            "Magister",
            "Marshal",
            "Royal Enforcer",
            "Spymaster",
            "Treasurer",
            "Viceroy",
            "Warden"});
            this.LeaderSelectBox.Location = new System.Drawing.Point(278, 33);
            this.LeaderSelectBox.Name = "LeaderSelectBox";
            this.LeaderSelectBox.Size = new System.Drawing.Size(121, 21);
            this.LeaderSelectBox.TabIndex = 0;
            this.LeaderSelectBox.Visible = false;
            this.LeaderSelectBox.SelectedIndexChanged += new System.EventHandler(this.LeaderSelectBox_SelectedIndexChanged);
            // 
            // eHexesTab
            // 
            this.eHexesTab.Location = new System.Drawing.Point(23, 4);
            this.eHexesTab.Name = "eHexesTab";
            this.eHexesTab.Padding = new System.Windows.Forms.Padding(3);
            this.eHexesTab.Size = new System.Drawing.Size(444, 311);
            this.eHexesTab.TabIndex = 1;
            this.eHexesTab.Text = "Hexes";
            this.eHexesTab.UseVisualStyleBackColor = true;
            // 
            // eTerrainTab
            // 
            this.eTerrainTab.Location = new System.Drawing.Point(23, 4);
            this.eTerrainTab.Name = "eTerrainTab";
            this.eTerrainTab.Padding = new System.Windows.Forms.Padding(3);
            this.eTerrainTab.Size = new System.Drawing.Size(444, 311);
            this.eTerrainTab.TabIndex = 2;
            this.eTerrainTab.Text = "Terrain";
            this.eTerrainTab.UseVisualStyleBackColor = true;
            // 
            // eSettlementTab
            // 
            this.eSettlementTab.Location = new System.Drawing.Point(23, 4);
            this.eSettlementTab.Name = "eSettlementTab";
            this.eSettlementTab.Padding = new System.Windows.Forms.Padding(3);
            this.eSettlementTab.Size = new System.Drawing.Size(444, 311);
            this.eSettlementTab.TabIndex = 3;
            this.eSettlementTab.Text = "Settlements";
            this.eSettlementTab.UseVisualStyleBackColor = true;
            // 
            // eArmyTab
            // 
            this.eArmyTab.Location = new System.Drawing.Point(23, 4);
            this.eArmyTab.Name = "eArmyTab";
            this.eArmyTab.Padding = new System.Windows.Forms.Padding(3);
            this.eArmyTab.Size = new System.Drawing.Size(444, 311);
            this.eArmyTab.TabIndex = 4;
            this.eArmyTab.Text = "Army";
            this.eArmyTab.UseVisualStyleBackColor = true;
            // 
            // eEdictTab
            // 
            this.eEdictTab.Location = new System.Drawing.Point(23, 4);
            this.eEdictTab.Name = "eEdictTab";
            this.eEdictTab.Padding = new System.Windows.Forms.Padding(3);
            this.eEdictTab.Size = new System.Drawing.Size(444, 311);
            this.eEdictTab.TabIndex = 5;
            this.eEdictTab.Text = "Edicts";
            this.eEdictTab.UseVisualStyleBackColor = true;
            // 
            // PrimaryTabPageIncome
            // 
            this.PrimaryTabPageIncome.Controls.Add(this.IncomeTabControl);
            this.PrimaryTabPageIncome.Location = new System.Drawing.Point(4, 22);
            this.PrimaryTabPageIncome.Name = "PrimaryTabPageIncome";
            this.PrimaryTabPageIncome.Padding = new System.Windows.Forms.Padding(3);
            this.PrimaryTabPageIncome.Size = new System.Drawing.Size(477, 325);
            this.PrimaryTabPageIncome.TabIndex = 2;
            this.PrimaryTabPageIncome.Text = "Income Phase";
            this.PrimaryTabPageIncome.UseVisualStyleBackColor = true;
            // 
            // IncomeTabControl
            // 
            this.IncomeTabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.IncomeTabControl.Controls.Add(this.iWithdrawalTab);
            this.IncomeTabControl.Controls.Add(this.iDepositsTab);
            this.IncomeTabControl.Controls.Add(this.iSellItemsTab);
            this.IncomeTabControl.Controls.Add(this.iTaxesTab);
            this.IncomeTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IncomeTabControl.Location = new System.Drawing.Point(3, 3);
            this.IncomeTabControl.Multiline = true;
            this.IncomeTabControl.Name = "IncomeTabControl";
            this.IncomeTabControl.SelectedIndex = 0;
            this.IncomeTabControl.Size = new System.Drawing.Size(471, 319);
            this.IncomeTabControl.TabIndex = 0;
            // 
            // iWithdrawalTab
            // 
            this.iWithdrawalTab.Location = new System.Drawing.Point(23, 4);
            this.iWithdrawalTab.Name = "iWithdrawalTab";
            this.iWithdrawalTab.Padding = new System.Windows.Forms.Padding(3);
            this.iWithdrawalTab.Size = new System.Drawing.Size(444, 311);
            this.iWithdrawalTab.TabIndex = 0;
            this.iWithdrawalTab.Text = "Withdrawals";
            this.iWithdrawalTab.UseVisualStyleBackColor = true;
            // 
            // iDepositsTab
            // 
            this.iDepositsTab.Location = new System.Drawing.Point(23, 4);
            this.iDepositsTab.Name = "iDepositsTab";
            this.iDepositsTab.Padding = new System.Windows.Forms.Padding(3);
            this.iDepositsTab.Size = new System.Drawing.Size(444, 311);
            this.iDepositsTab.TabIndex = 1;
            this.iDepositsTab.Text = "Deposits";
            this.iDepositsTab.UseVisualStyleBackColor = true;
            // 
            // iSellItemsTab
            // 
            this.iSellItemsTab.Location = new System.Drawing.Point(23, 4);
            this.iSellItemsTab.Name = "iSellItemsTab";
            this.iSellItemsTab.Padding = new System.Windows.Forms.Padding(3);
            this.iSellItemsTab.Size = new System.Drawing.Size(444, 311);
            this.iSellItemsTab.TabIndex = 2;
            this.iSellItemsTab.Text = "Sell Items";
            this.iSellItemsTab.UseVisualStyleBackColor = true;
            // 
            // iTaxesTab
            // 
            this.iTaxesTab.Location = new System.Drawing.Point(23, 4);
            this.iTaxesTab.Name = "iTaxesTab";
            this.iTaxesTab.Padding = new System.Windows.Forms.Padding(3);
            this.iTaxesTab.Size = new System.Drawing.Size(444, 311);
            this.iTaxesTab.TabIndex = 3;
            this.iTaxesTab.Text = "Taxes";
            this.iTaxesTab.UseVisualStyleBackColor = true;
            // 
            // PrimaryTabPageEvents
            // 
            this.PrimaryTabPageEvents.Location = new System.Drawing.Point(4, 22);
            this.PrimaryTabPageEvents.Name = "PrimaryTabPageEvents";
            this.PrimaryTabPageEvents.Padding = new System.Windows.Forms.Padding(3);
            this.PrimaryTabPageEvents.Size = new System.Drawing.Size(477, 325);
            this.PrimaryTabPageEvents.TabIndex = 3;
            this.PrimaryTabPageEvents.Text = "Events";
            this.PrimaryTabPageEvents.UseVisualStyleBackColor = true;
            // 
            // ChangeLeaderYesButton
            // 
            this.ChangeLeaderYesButton.Location = new System.Drawing.Point(54, 33);
            this.ChangeLeaderYesButton.Name = "ChangeLeaderYesButton";
            this.ChangeLeaderYesButton.Size = new System.Drawing.Size(75, 23);
            this.ChangeLeaderYesButton.TabIndex = 1;
            this.ChangeLeaderYesButton.Text = "Yes";
            this.ChangeLeaderYesButton.UseVisualStyleBackColor = true;
            this.ChangeLeaderYesButton.Click += new System.EventHandler(this.ChangeLeaderYesButton_Click);
            // 
            // LeaderShipYN
            // 
            this.LeaderShipYN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LeaderShipYN.Location = new System.Drawing.Point(54, 14);
            this.LeaderShipYN.Name = "LeaderShipYN";
            this.LeaderShipYN.Size = new System.Drawing.Size(170, 13);
            this.LeaderShipYN.TabIndex = 2;
            this.LeaderShipYN.Text = "Are you Changing Leadership?";
            this.LeaderShipYN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ChangeLeaderNoButton
            // 
            this.ChangeLeaderNoButton.Location = new System.Drawing.Point(149, 33);
            this.ChangeLeaderNoButton.Name = "ChangeLeaderNoButton";
            this.ChangeLeaderNoButton.Size = new System.Drawing.Size(75, 23);
            this.ChangeLeaderNoButton.TabIndex = 3;
            this.ChangeLeaderNoButton.Text = "No";
            this.ChangeLeaderNoButton.UseVisualStyleBackColor = true;
            this.ChangeLeaderNoButton.Click += new System.EventHandler(this.ChangeLeaderNoButton_Click);
            // 
            // LeadershipRoleQuestion
            // 
            this.LeadershipRoleQuestion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LeadershipRoleQuestion.Location = new System.Drawing.Point(54, 36);
            this.LeadershipRoleQuestion.Name = "LeadershipRoleQuestion";
            this.LeadershipRoleQuestion.Size = new System.Drawing.Size(170, 13);
            this.LeadershipRoleQuestion.TabIndex = 4;
            this.LeadershipRoleQuestion.Text = "Which Role is being changed?";
            this.LeadershipRoleQuestion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LeadershipRoleQuestion.Visible = false;
            // 
            // LeaderNameLabel
            // 
            this.LeaderNameLabel.AutoSize = true;
            this.LeaderNameLabel.Location = new System.Drawing.Point(65, 105);
            this.LeaderNameLabel.Name = "LeaderNameLabel";
            this.LeaderNameLabel.Size = new System.Drawing.Size(38, 13);
            this.LeaderNameLabel.TabIndex = 5;
            this.LeaderNameLabel.Text = "Name:";
            this.LeaderNameLabel.Visible = false;
            // 
            // LeaderNameField
            // 
            this.LeaderNameField.Location = new System.Drawing.Point(120, 102);
            this.LeaderNameField.Name = "LeaderNameField";
            this.LeaderNameField.Size = new System.Drawing.Size(154, 20);
            this.LeaderNameField.TabIndex = 6;
            this.LeaderNameField.Visible = false;
            this.LeaderNameField.WordWrap = false;
            // 
            // LeaderBonusLabel
            // 
            this.LeaderBonusLabel.AutoSize = true;
            this.LeaderBonusLabel.Location = new System.Drawing.Point(67, 140);
            this.LeaderBonusLabel.Name = "LeaderBonusLabel";
            this.LeaderBonusLabel.Size = new System.Drawing.Size(40, 13);
            this.LeaderBonusLabel.TabIndex = 7;
            this.LeaderBonusLabel.Text = "Bonus:";
            this.LeaderBonusLabel.Visible = false;
            // 
            // LeaderBonusField
            // 
            this.LeaderBonusField.Location = new System.Drawing.Point(248, 132);
            this.LeaderBonusField.Mask = "00000";
            this.LeaderBonusField.Name = "LeaderBonusField";
            this.LeaderBonusField.PromptChar = ' ';
            this.LeaderBonusField.Size = new System.Drawing.Size(26, 20);
            this.LeaderBonusField.TabIndex = 8;
            this.LeaderBonusField.ValidatingType = typeof(int);
            this.LeaderBonusField.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 351);
            this.Controls.Add(this.PrimaryTabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.StabilityTabControl.ResumeLayout(false);
            this.sStabRollTab.ResumeLayout(false);
            this.sStabRollTab.PerformLayout();
            this.sConsumptionTab.ResumeLayout(false);
            this.sConsumptionTab.PerformLayout();
            this.sUnrestTab.ResumeLayout(false);
            this.sUnrestTab.PerformLayout();
            this.PrimaryTabControl.ResumeLayout(false);
            this.PrimaryTabPageUpkeep.ResumeLayout(false);
            this.PrimaryTabPageEdicts.ResumeLayout(false);
            this.EdictTabControl.ResumeLayout(false);
            this.eLeadershipTab.ResumeLayout(false);
            this.eLeadershipTab.PerformLayout();
            this.PrimaryTabPageIncome.ResumeLayout(false);
            this.IncomeTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button stabRollButton;
        private System.Windows.Forms.TabControl StabilityTabControl;
        private System.Windows.Forms.TabPage sStabRollTab;
        private System.Windows.Forms.TabPage sConsumptionTab;
        private System.Windows.Forms.TabPage sUnrestTab;
        private System.Windows.Forms.TabControl PrimaryTabControl;
        private System.Windows.Forms.TabPage PrimaryTabPageUpkeep;
        private System.Windows.Forms.TabPage PrimaryTabPageEdicts;
        private System.Windows.Forms.TabControl EdictTabControl;
        private System.Windows.Forms.TabPage eLeadershipTab;
        private System.Windows.Forms.TabPage eHexesTab;
        private System.Windows.Forms.TabPage eTerrainTab;
        private System.Windows.Forms.TabPage eSettlementTab;
        private System.Windows.Forms.TabPage eArmyTab;
        private System.Windows.Forms.TabPage eEdictTab;
        private System.Windows.Forms.TabPage PrimaryTabPageIncome;
        private System.Windows.Forms.TabControl IncomeTabControl;
        private System.Windows.Forms.TabPage iWithdrawalTab;
        private System.Windows.Forms.TabPage iDepositsTab;
        private System.Windows.Forms.TabPage iSellItemsTab;
        private System.Windows.Forms.TabPage iTaxesTab;
        private System.Windows.Forms.TabPage PrimaryTabPageEvents;
        private System.Windows.Forms.TextBox StabilityInfoBox;
        private System.Windows.Forms.TextBox PostRollStabilityInfoBox;
        private System.Windows.Forms.TextBox PostConsumptionInfoBox;
        private System.Windows.Forms.TextBox ConsumptionInfoBox;
        private System.Windows.Forms.Button consumptionPaymentButton;
        private System.Windows.Forms.TextBox PostUnrestInfoBox;
        private System.Windows.Forms.TextBox UnrestInfoBox;
        private System.Windows.Forms.Button modifyUnrestButton;
        private System.Windows.Forms.TextBox PostStabilityUnrestInfo;
        private System.Windows.Forms.TextBox StabDiceRollText;
        private System.Windows.Forms.TextBox PostConsumptionDebtNote;
        private System.Windows.Forms.ComboBox LeaderSelectBox;
        private System.Windows.Forms.Button ChangeLeaderNoButton;
        private System.Windows.Forms.TextBox LeaderShipYN;
        private System.Windows.Forms.Button ChangeLeaderYesButton;
        private System.Windows.Forms.TextBox LeadershipRoleQuestion;
        private System.Windows.Forms.TextBox LeaderNameField;
        private System.Windows.Forms.Label LeaderNameLabel;
        private System.Windows.Forms.Label LeaderBonusLabel;
        private System.Windows.Forms.MaskedTextBox LeaderBonusField;
    }
}

