namespace GamingTournament
{
    partial class SoloTournamentLeaderboardForm
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
            playerList = new ListBox();
            AddTournamentLabel = new GroupBox();
            createPlayerButton = new Button();
            scoreInput = new TextBox();
            label1 = new Label();
            nameInput = new TextBox();
            tournamentNameLabel = new Label();
            groupBox1 = new GroupBox();
            addScoreButton = new Button();
            addScoreInput = new TextBox();
            label4 = new Label();
            AddTournamentLabel.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // playerList
            // 
            playerList.FormattingEnabled = true;
            playerList.ItemHeight = 15;
            playerList.Location = new Point(299, 12);
            playerList.Name = "playerList";
            playerList.Size = new Size(214, 244);
            playerList.TabIndex = 0;
            // 
            // AddTournamentLabel
            // 
            AddTournamentLabel.Controls.Add(createPlayerButton);
            AddTournamentLabel.Controls.Add(scoreInput);
            AddTournamentLabel.Controls.Add(label1);
            AddTournamentLabel.Controls.Add(nameInput);
            AddTournamentLabel.Controls.Add(tournamentNameLabel);
            AddTournamentLabel.Location = new Point(12, 12);
            AddTournamentLabel.Name = "AddTournamentLabel";
            AddTournamentLabel.Size = new Size(256, 244);
            AddTournamentLabel.TabIndex = 1;
            AddTournamentLabel.TabStop = false;
            AddTournamentLabel.Text = "Add new player";
            // 
            // createPlayerButton
            // 
            createPlayerButton.Location = new Point(25, 170);
            createPlayerButton.Name = "createPlayerButton";
            createPlayerButton.Size = new Size(170, 43);
            createPlayerButton.TabIndex = 6;
            createPlayerButton.Text = "Create";
            createPlayerButton.UseVisualStyleBackColor = true;
            createPlayerButton.Click += createPlayerButton_Click;
            // 
            // scoreInput
            // 
            scoreInput.Location = new Point(25, 118);
            scoreInput.Name = "scoreInput";
            scoreInput.Size = new Size(170, 23);
            scoreInput.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 100);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 2;
            label1.Text = "Score:";
            // 
            // nameInput
            // 
            nameInput.Location = new Point(25, 58);
            nameInput.Name = "nameInput";
            nameInput.Size = new Size(170, 23);
            nameInput.TabIndex = 1;
            // 
            // tournamentNameLabel
            // 
            tournamentNameLabel.AutoSize = true;
            tournamentNameLabel.Location = new Point(25, 40);
            tournamentNameLabel.Name = "tournamentNameLabel";
            tournamentNameLabel.Size = new Size(42, 15);
            tournamentNameLabel.TabIndex = 0;
            tournamentNameLabel.Text = "Name:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(addScoreButton);
            groupBox1.Controls.Add(addScoreInput);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(544, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(256, 244);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Modify Players";
            // 
            // addScoreButton
            // 
            addScoreButton.Location = new Point(25, 87);
            addScoreButton.Name = "addScoreButton";
            addScoreButton.Size = new Size(75, 38);
            addScoreButton.TabIndex = 7;
            addScoreButton.Text = "Add";
            addScoreButton.UseVisualStyleBackColor = true;
            addScoreButton.Click += addScoreButton_Click;
            // 
            // addScoreInput
            // 
            addScoreInput.Location = new Point(25, 58);
            addScoreInput.Name = "addScoreInput";
            addScoreInput.Size = new Size(75, 23);
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
            // SoloTournamentLeaderboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 276);
            Controls.Add(groupBox1);
            Controls.Add(AddTournamentLabel);
            Controls.Add(playerList);
            Name = "SoloTournamentLeaderboardForm";
            Text = "SoloTournamentLeaderboardForm";
            AddTournamentLabel.ResumeLayout(false);
            AddTournamentLabel.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox playerList;
        private GroupBox AddTournamentLabel;
        private TextBox maxParticipantsInput;
        private Label maxlabel;
        private Button createPlayerButton;
        private ComboBox tournamentTypeInput;
        private Label label2;
        private TextBox scoreInput;
        private Label label1;
        private TextBox nameInput;
        private Label tournamentNameLabel;
        private GroupBox groupBox1;
        private Button button1;
        private TextBox textBox1;
        private Label label3;
        private TextBox addScoreInput;
        private Label label4;
        private Button addScoreButton;
    }
}