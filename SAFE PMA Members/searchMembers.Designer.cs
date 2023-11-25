namespace SAFE_PMA_Members
{
    partial class searchMembers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(searchMembers));
            SearchLastNameLabel = new Label();
            SearchLastNameTextBox = new TextBox();
            SearchReferralButton = new Button();
            SearchMembersSearchButton = new Button();
            SearchMemberListBox = new ListBox();
            SuspendLayout();
            // 
            // SearchLastNameLabel
            // 
            SearchLastNameLabel.AutoSize = true;
            SearchLastNameLabel.Location = new Point(12, 27);
            SearchLastNameLabel.Name = "SearchLastNameLabel";
            SearchLastNameLabel.Size = new Size(63, 15);
            SearchLastNameLabel.TabIndex = 0;
            SearchLastNameLabel.Text = "Last Name";
            // 
            // SearchLastNameTextBox
            // 
            SearchLastNameTextBox.Location = new Point(81, 24);
            SearchLastNameTextBox.Name = "SearchLastNameTextBox";
            SearchLastNameTextBox.Size = new Size(167, 23);
            SearchLastNameTextBox.TabIndex = 1;
            SearchLastNameTextBox.KeyPress += SearchLastNameTextBox_KeyPress;
            // 
            // SearchReferralButton
            // 
            SearchReferralButton.Location = new Point(224, 408);
            SearchReferralButton.Name = "SearchReferralButton";
            SearchReferralButton.Size = new Size(142, 23);
            SearchReferralButton.TabIndex = 3;
            SearchReferralButton.Text = "Select Referral";
            SearchReferralButton.UseVisualStyleBackColor = true;
            SearchReferralButton.Click += SearchReferralButton_Click;
            // 
            // SearchMembersSearchButton
            // 
            SearchMembersSearchButton.Location = new Point(254, 23);
            SearchMembersSearchButton.Name = "SearchMembersSearchButton";
            SearchMembersSearchButton.Size = new Size(112, 23);
            SearchMembersSearchButton.TabIndex = 4;
            SearchMembersSearchButton.Text = "Search";
            SearchMembersSearchButton.UseVisualStyleBackColor = true;
            SearchMembersSearchButton.Click += SearchMembersSearchButton_Click;
            // 
            // SearchMemberListBox
            // 
            SearchMemberListBox.FormattingEnabled = true;
            SearchMemberListBox.ItemHeight = 15;
            SearchMemberListBox.Location = new Point(12, 53);
            SearchMemberListBox.Name = "SearchMemberListBox";
            SearchMemberListBox.Size = new Size(354, 349);
            SearchMemberListBox.TabIndex = 5;
            // 
            // searchMembers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 450);
            Controls.Add(SearchMemberListBox);
            Controls.Add(SearchMembersSearchButton);
            Controls.Add(SearchReferralButton);
            Controls.Add(SearchLastNameTextBox);
            Controls.Add(SearchLastNameLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "searchMembers";
            Text = "Search Members";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SearchLastNameLabel;
        private TextBox SearchLastNameTextBox;
        private Button SearchReferralButton;
        private Button SearchMembersSearchButton;
        private ListBox SearchMemberListBox;
    }
}