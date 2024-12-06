namespace GamingTournament
{
    partial class TeamTournamentLeaderboardForm
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
            groupBox1 = new GroupBox();
            addScoreButton = new Button();
            addScoreInput = new TextBox();
            label4 = new Label();
            AddTournamentLabel = new GroupBox();
            playerNameInput = new TextBox();
            label2 = new Label();
            createTeamButton = new Button();
            scoreInput = new TextBox();
            label1 = new Label();
            nameInput = new TextBox();
            tournamentNameLabel = new Label();
            teamList = new TreeView();
            scoreAddNameInput = new TextBox();
            label3 = new Label();
            groupBox1.SuspendLayout();
            AddTournamentLabel.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(scoreAddNameInput);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(addScoreButton);
            groupBox1.Controls.Add(addScoreInput);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(657, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(256, 244);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Modify Teams";
            // 
            // addScoreButton
            // 
            addScoreButton.Location = new Point(133, 69);
            addScoreButton.Name = "addScoreButton";
            addScoreButton.Size = new Size(75, 38);
            addScoreButton.TabIndex = 7;
            addScoreButton.Text = "Add";
            addScoreButton.UseVisualStyleBackColor = true;
            addScoreButton.Click += addScoreButton_Click;
            // 
            // addScoreInput
            // 
            addScoreInput.Location = new Point(16, 58);
            addScoreInput.Name = "addScoreInput";
            addScoreInput.Size = new Size(94, 23);
            addScoreInput.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 40);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 0;
            label4.Text = "Add to Score";
            // 
            // AddTournamentLabel
            // 
            AddTournamentLabel.Controls.Add(playerNameInput);
            AddTournamentLabel.Controls.Add(label2);
            AddTournamentLabel.Controls.Add(createTeamButton);
            AddTournamentLabel.Controls.Add(scoreInput);
            AddTournamentLabel.Controls.Add(label1);
            AddTournamentLabel.Controls.Add(nameInput);
            AddTournamentLabel.Controls.Add(tournamentNameLabel);
            AddTournamentLabel.Location = new Point(6, 12);
            AddTournamentLabel.Name = "AddTournamentLabel";
            AddTournamentLabel.Size = new Size(256, 285);
            AddTournamentLabel.TabIndex = 9;
            AddTournamentLabel.TabStop = false;
            AddTournamentLabel.Text = "Add new team";
            // 
            // playerNameInput
            // 
            playerNameInput.Location = new Point(25, 154);
            playerNameInput.Name = "playerNameInput";
            playerNameInput.Size = new Size(170, 23);
            playerNameInput.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 136);
            label2.Name = "label2";
            label2.Size = new Size(170, 15);
            label2.TabIndex = 7;
            label2.Text = "Player Names (Seperated by ',')";
            // 
            // createTeamButton
            // 
            createTeamButton.Location = new Point(25, 226);
            createTeamButton.Name = "createTeamButton";
            createTeamButton.Size = new Size(170, 43);
            createTeamButton.TabIndex = 6;
            createTeamButton.Text = "Create";
            createTeamButton.UseVisualStyleBackColor = true;
            createTeamButton.Click += createTeamButton_Click;
            // 
            // scoreInput
            // 
            scoreInput.Location = new Point(25, 96);
            scoreInput.Name = "scoreInput";
            scoreInput.Size = new Size(170, 23);
            scoreInput.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 78);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 2;
            label1.Text = "Score:";
            // 
            // nameInput
            // 
            nameInput.Location = new Point(25, 47);
            nameInput.Name = "nameInput";
            nameInput.Size = new Size(170, 23);
            nameInput.TabIndex = 1;
            // 
            // tournamentNameLabel
            // 
            tournamentNameLabel.AutoSize = true;
            tournamentNameLabel.Location = new Point(25, 29);
            tournamentNameLabel.Name = "tournamentNameLabel";
            tournamentNameLabel.Size = new Size(42, 15);
            tournamentNameLabel.TabIndex = 0;
            tournamentNameLabel.Text = "Name:";
            // 
            // teamList
            // 
            teamList.Location = new Point(268, 12);
            teamList.Name = "teamList";
            teamList.Size = new Size(383, 426);
            teamList.TabIndex = 11;
            // 
            // scoreAddNameInput
            // 
            scoreAddNameInput.Location = new Point(16, 110);
            scoreAddNameInput.Name = "scoreAddNameInput";
            scoreAddNameInput.Size = new Size(94, 23);
            scoreAddNameInput.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 92);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 8;
            label3.Text = "Team Name";
            // 
            // TeamTournamentLeaderboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(925, 450);
            Controls.Add(teamList);
            Controls.Add(groupBox1);
            Controls.Add(AddTournamentLabel);
            Name = "TeamTournamentLeaderboardForm";
            Text = "TeamTournamentLeaderboardForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            AddTournamentLabel.ResumeLayout(false);
            AddTournamentLabel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button addScoreButton;
        private TextBox addScoreInput;
        private Label label4;
        private GroupBox AddTournamentLabel;
        private Button createTeamButton;
        private TextBox scoreInput;
        private Label label1;
        private TextBox nameInput;
        private Label tournamentNameLabel;
        private ListBox playerList;
        private TreeView teamList;
        private TextBox playerNameInput;
        private Label label2;
        private TextBox scoreAddNameInput;
        private Label label3;
    }
}