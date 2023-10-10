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
            SearchLastNameLabel = new Label();
            SearchLastNameTextBox = new TextBox();
            SearchMembersListView = new ListView();
            SearchReferralButton = new Button();
            SuspendLayout();
            // 
            // SearchLastNameLabel
            // 
            SearchLastNameLabel.AutoSize = true;
            SearchLastNameLabel.Location = new Point(31, 27);
            SearchLastNameLabel.Name = "SearchLastNameLabel";
            SearchLastNameLabel.Size = new Size(63, 15);
            SearchLastNameLabel.TabIndex = 0;
            SearchLastNameLabel.Text = "Last Name";
            // 
            // SearchLastNameTextBox
            // 
            SearchLastNameTextBox.Location = new Point(110, 24);
            SearchLastNameTextBox.Name = "SearchLastNameTextBox";
            SearchLastNameTextBox.Size = new Size(167, 23);
            SearchLastNameTextBox.TabIndex = 1;
            // 
            // SearchMembersListView
            // 
            SearchMembersListView.Location = new Point(12, 59);
            SearchMembersListView.Name = "SearchMembersListView";
            SearchMembersListView.Size = new Size(354, 329);
            SearchMembersListView.TabIndex = 2;
            SearchMembersListView.UseCompatibleStateImageBehavior = false;
            // 
            // SearchReferralButton
            // 
            SearchReferralButton.Location = new Point(224, 408);
            SearchReferralButton.Name = "SearchReferralButton";
            SearchReferralButton.Size = new Size(142, 23);
            SearchReferralButton.TabIndex = 3;
            SearchReferralButton.Text = "Select Referral";
            SearchReferralButton.UseVisualStyleBackColor = true;
            // 
            // searchMembers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 450);
            Controls.Add(SearchReferralButton);
            Controls.Add(SearchMembersListView);
            Controls.Add(SearchLastNameTextBox);
            Controls.Add(SearchLastNameLabel);
            Name = "searchMembers";
            Text = "searchMembers";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SearchLastNameLabel;
        private TextBox SearchLastNameTextBox;
        private ListView SearchMembersListView;
        private Button SearchReferralButton;
    }
}