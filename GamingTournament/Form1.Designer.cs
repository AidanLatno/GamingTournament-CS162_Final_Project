namespace GamingTournament
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AddTournamentLabel = new GroupBox();
            maxParticipantsInput = new TextBox();
            maxlabel = new Label();
            createTournamentButton = new Button();
            tournamentTypeInput = new ComboBox();
            label2 = new Label();
            tournamentGameInput = new TextBox();
            label1 = new Label();
            tournamentNameInput = new TextBox();
            tournamentNameLabel = new Label();
            tournamentListBox = new ListBox();
            groupBox1 = new GroupBox();
            searchByGameButton = new Button();
            searchByGameInput = new TextBox();
            label5 = new Label();
            resetSearchButton = new Button();
            searchButton = new Button();
            searchBoxInput = new TextBox();
            label3 = new Label();
            setStatusButton = new Button();
            openMenuButton = new Button();
            deleteSelectedButton = new Button();
            statusSelector = new ComboBox();
            label4 = new Label();
            AddTournamentLabel.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // AddTournamentLabel
            // 
            AddTournamentLabel.Controls.Add(maxParticipantsInput);
            AddTournamentLabel.Controls.Add(maxlabel);
            AddTournamentLabel.Controls.Add(createTournamentButton);
            AddTournamentLabel.Controls.Add(tournamentTypeInput);
            AddTournamentLabel.Controls.Add(label2);
            AddTournamentLabel.Controls.Add(tournamentGameInput);
            AddTournamentLabel.Controls.Add(label1);
            AddTournamentLabel.Controls.Add(tournamentNameInput);
            AddTournamentLabel.Controls.Add(tournamentNameLabel);
            AddTournamentLabel.Location = new Point(12, 12);
            AddTournamentLabel.Name = "AddTournamentLabel";
            AddTournamentLabel.Size = new Size(256, 387);
            AddTournamentLabel.TabIndex = 0;
            AddTournamentLabel.TabStop = false;
            AddTournamentLabel.Text = "Add new tournament";
            // 
            // maxParticipantsInput
            // 
            maxParticipantsInput.Location = new Point(25, 243);
            maxParticipantsInput.Name = "maxParticipantsInput";
            maxParticipantsInput.Size = new Size(170, 23);
            maxParticipantsInput.TabIndex = 8;
            // 
            // maxlabel
            // 
            maxlabel.AutoSize = true;
            maxlabel.Location = new Point(25, 225);
            maxlabel.Name = "maxlabel";
            maxlabel.Size = new Size(135, 15);
            maxlabel.TabIndex = 7;
            maxlabel.Text = "Max teams/participants:";
            // 
            // createTournamentButton
            // 
            createTournamentButton.Location = new Point(25, 299);
            createTournamentButton.Name = "createTournamentButton";
            createTournamentButton.Size = new Size(170, 43);
            createTournamentButton.TabIndex = 6;
            createTournamentButton.Text = "Create";
            createTournamentButton.UseVisualStyleBackColor = true;
            createTournamentButton.Click += createTournamentButton_Click;
            // 
            // tournamentTypeInput
            // 
            tournamentTypeInput.FormattingEnabled = true;
            tournamentTypeInput.Items.AddRange(new object[] { "Team", "Solo" });
            tournamentTypeInput.Location = new Point(25, 180);
            tournamentTypeInput.Name = "tournamentTypeInput";
            tournamentTypeInput.Size = new Size(121, 23);
            tournamentTypeInput.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 162);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 4;
            label2.Text = "Team Type:";
            // 
            // tournamentGameInput
            // 
            tournamentGameInput.Location = new Point(25, 118);
            tournamentGameInput.Name = "tournamentGameInput";
            tournamentGameInput.Size = new Size(170, 23);
            tournamentGameInput.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 100);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 2;
            label1.Text = "Game:";
            // 
            // tournamentNameInput
            // 
            tournamentNameInput.Location = new Point(25, 58);
            tournamentNameInput.Name = "tournamentNameInput";
            tournamentNameInput.Size = new Size(170, 23);
            tournamentNameInput.TabIndex = 1;
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
            // tournamentListBox
            // 
            tournamentListBox.FormattingEnabled = true;
            tournamentListBox.ItemHeight = 15;
            tournamentListBox.Location = new Point(308, 12);
            tournamentListBox.Name = "tournamentListBox";
            tournamentListBox.Size = new Size(334, 394);
            tournamentListBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(searchByGameButton);
            groupBox1.Controls.Add(searchByGameInput);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(resetSearchButton);
            groupBox1.Controls.Add(searchButton);
            groupBox1.Controls.Add(searchBoxInput);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(setStatusButton);
            groupBox1.Controls.Add(openMenuButton);
            groupBox1.Controls.Add(deleteSelectedButton);
            groupBox1.Controls.Add(statusSelector);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(687, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(338, 387);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tournament Editor";
            // 
            // searchByGameButton
            // 
            searchByGameButton.Location = new Point(25, 274);
            searchByGameButton.Name = "searchByGameButton";
            searchByGameButton.Size = new Size(121, 43);
            searchByGameButton.TabIndex = 17;
            searchByGameButton.Text = "Search";
            searchByGameButton.UseVisualStyleBackColor = true;
            searchByGameButton.Click += searchByGameButton_Click;
            // 
            // searchByGameInput
            // 
            searchByGameInput.Location = new Point(25, 241);
            searchByGameInput.Name = "searchByGameInput";
            searchByGameInput.Size = new Size(121, 23);
            searchByGameInput.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 223);
            label5.Name = "label5";
            label5.Size = new Size(95, 15);
            label5.TabIndex = 16;
            label5.Text = "Search by Game:";
            // 
            // resetSearchButton
            // 
            resetSearchButton.Location = new Point(106, 323);
            resetSearchButton.Name = "resetSearchButton";
            resetSearchButton.Size = new Size(121, 43);
            resetSearchButton.TabIndex = 14;
            resetSearchButton.Text = "Reset Search";
            resetSearchButton.UseVisualStyleBackColor = true;
            resetSearchButton.Click += resetSearchButton_Click;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(194, 274);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(121, 43);
            searchButton.TabIndex = 13;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // searchBoxInput
            // 
            searchBoxInput.Location = new Point(194, 241);
            searchBoxInput.Name = "searchBoxInput";
            searchBoxInput.Size = new Size(121, 23);
            searchBoxInput.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(194, 223);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 12;
            label3.Text = "Search:";
            // 
            // setStatusButton
            // 
            setStatusButton.Location = new Point(25, 149);
            setStatusButton.Name = "setStatusButton";
            setStatusButton.Size = new Size(121, 43);
            setStatusButton.TabIndex = 11;
            setStatusButton.Text = "Set";
            setStatusButton.UseVisualStyleBackColor = true;
            setStatusButton.Click += setStatusButton_Click;
            // 
            // openMenuButton
            // 
            openMenuButton.Location = new Point(194, 38);
            openMenuButton.Name = "openMenuButton";
            openMenuButton.Size = new Size(121, 43);
            openMenuButton.TabIndex = 10;
            openMenuButton.Text = "Open Menu";
            openMenuButton.UseVisualStyleBackColor = true;
            openMenuButton.Click += openMenuButton_Click;
            // 
            // deleteSelectedButton
            // 
            deleteSelectedButton.Location = new Point(25, 38);
            deleteSelectedButton.Name = "deleteSelectedButton";
            deleteSelectedButton.Size = new Size(121, 43);
            deleteSelectedButton.TabIndex = 9;
            deleteSelectedButton.Text = "Delete Selected";
            deleteSelectedButton.UseVisualStyleBackColor = true;
            deleteSelectedButton.Click += deleteSelectedButton_Click;
            // 
            // statusSelector
            // 
            statusSelector.FormattingEnabled = true;
            statusSelector.Items.AddRange(new object[] { "Upcoming", "Ongoing", "Completed" });
            statusSelector.Location = new Point(25, 118);
            statusSelector.Name = "statusSelector";
            statusSelector.Size = new Size(121, 23);
            statusSelector.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 100);
            label4.Name = "label4";
            label4.Size = new Size(125, 15);
            label4.TabIndex = 4;
            label4.Text = "Set Tournament Status";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 421);
            Controls.Add(groupBox1);
            Controls.Add(tournamentListBox);
            Controls.Add(AddTournamentLabel);
            Name = "Form1";
            Text = "Form1";
            AddTournamentLabel.ResumeLayout(false);
            AddTournamentLabel.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox AddTournamentLabel;
        private Label tournamentNameLabel;
        private TextBox tournamentGameInput;
        private Label label1;
        private TextBox tournamentNameInput;
        private ComboBox tournamentTypeInput;
        private Label label2;
        private Button createTournamentButton;
        private TextBox maxParticipantsInput;
        private Label maxlabel;
        private ListBox tournamentListBox;
        private GroupBox groupBox1;
        private Button openMenuButton;
        private Button deleteSelectedButton;
        private ComboBox statusSelector;
        private Label label4;
        private Button setStatusButton;
        private Button searchButton;
        private TextBox searchBoxInput;
        private Label label3;
        private Button resetSearchButton;
        private Button searchByGameButton;
        private TextBox searchByGameInput;
        private Label label5;
    }
}
