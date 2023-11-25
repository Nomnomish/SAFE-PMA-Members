namespace SAFE_PMA_Members
{
    partial class viewEditMembers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewEditMembers));
            membersListbox = new ListBox();
            LastNameTextbox = new TextBox();
            LastNameLabel = new Label();
            SearchButton = new Button();
            editFirstNameLabel = new Label();
            editLastNameLabel = new Label();
            editPhoneNumberLabel = new Label();
            editEmailLabel = new Label();
            editReferralEmailLabel = new Label();
            editStreetAddressLabel = new Label();
            editCityLabel = new Label();
            editStateLabel = new Label();
            editZipCodeLabel = new Label();
            editCurrentBalanceLabel = new Label();
            editFirstNameTextBox = new TextBox();
            editLastNameTextBox = new TextBox();
            editPhoneNumberTextBox = new TextBox();
            editEmailTextBox = new TextBox();
            editStreetAddressTextBox = new TextBox();
            editCityTextBox = new TextBox();
            editStateTextBox = new TextBox();
            editZipCodeTextBox = new TextBox();
            editCurrentBalanceTextBox = new TextBox();
            updateMemberButton = new Button();
            editLastBalanceLabel = new Label();
            editBalanceLabel = new Label();
            editReferralIDLabel = new Label();
            memberReferralLabel = new Label();
            referralsListbox = new ListBox();
            membershipIDLabel = new Label();
            memberIDLabel = new Label();
            statusLabel = new Label();
            editMemberStatusComboBox = new ComboBox();
            SuspendLayout();
            // 
            // membersListbox
            // 
            membersListbox.FormattingEnabled = true;
            membersListbox.ItemHeight = 15;
            membersListbox.Location = new Point(12, 102);
            membersListbox.Name = "membersListbox";
            membersListbox.Size = new Size(277, 124);
            membersListbox.TabIndex = 0;
            membersListbox.SelectedIndexChanged += membersListbox_SelectedIndexChanged;
            // 
            // LastNameTextbox
            // 
            LastNameTextbox.Location = new Point(118, 29);
            LastNameTextbox.Name = "LastNameTextbox";
            LastNameTextbox.Size = new Size(171, 23);
            LastNameTextbox.TabIndex = 1;
            LastNameTextbox.KeyPress += LastNameTextbox_KeyPress;
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Location = new Point(34, 32);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(63, 15);
            LastNameLabel.TabIndex = 2;
            LastNameLabel.Text = "Last Name";
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(214, 58);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(75, 23);
            SearchButton.TabIndex = 3;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // editFirstNameLabel
            // 
            editFirstNameLabel.AutoSize = true;
            editFirstNameLabel.Location = new Point(334, 32);
            editFirstNameLabel.Name = "editFirstNameLabel";
            editFirstNameLabel.Size = new Size(64, 15);
            editFirstNameLabel.TabIndex = 4;
            editFirstNameLabel.Text = "First Name";
            // 
            // editLastNameLabel
            // 
            editLastNameLabel.AutoSize = true;
            editLastNameLabel.Location = new Point(335, 62);
            editLastNameLabel.Name = "editLastNameLabel";
            editLastNameLabel.Size = new Size(63, 15);
            editLastNameLabel.TabIndex = 5;
            editLastNameLabel.Text = "Last Name";
            // 
            // editPhoneNumberLabel
            // 
            editPhoneNumberLabel.AutoSize = true;
            editPhoneNumberLabel.Location = new Point(310, 91);
            editPhoneNumberLabel.Name = "editPhoneNumberLabel";
            editPhoneNumberLabel.Size = new Size(88, 15);
            editPhoneNumberLabel.TabIndex = 6;
            editPhoneNumberLabel.Text = "Phone Number";
            // 
            // editEmailLabel
            // 
            editEmailLabel.AutoSize = true;
            editEmailLabel.Location = new Point(362, 120);
            editEmailLabel.Name = "editEmailLabel";
            editEmailLabel.Size = new Size(36, 15);
            editEmailLabel.TabIndex = 7;
            editEmailLabel.Text = "Email";
            // 
            // editReferralEmailLabel
            // 
            editReferralEmailLabel.AutoSize = true;
            editReferralEmailLabel.Location = new Point(331, 149);
            editReferralEmailLabel.Name = "editReferralEmailLabel";
            editReferralEmailLabel.Size = new Size(67, 15);
            editReferralEmailLabel.TabIndex = 8;
            editReferralEmailLabel.Text = "Referred by";
            // 
            // editStreetAddressLabel
            // 
            editStreetAddressLabel.AutoSize = true;
            editStreetAddressLabel.Location = new Point(316, 181);
            editStreetAddressLabel.Name = "editStreetAddressLabel";
            editStreetAddressLabel.Size = new Size(82, 15);
            editStreetAddressLabel.TabIndex = 9;
            editStreetAddressLabel.Text = "Street Address";
            // 
            // editCityLabel
            // 
            editCityLabel.AutoSize = true;
            editCityLabel.Location = new Point(370, 211);
            editCityLabel.Name = "editCityLabel";
            editCityLabel.Size = new Size(28, 15);
            editCityLabel.TabIndex = 10;
            editCityLabel.Text = "City";
            // 
            // editStateLabel
            // 
            editStateLabel.AutoSize = true;
            editStateLabel.Location = new Point(365, 238);
            editStateLabel.Name = "editStateLabel";
            editStateLabel.Size = new Size(33, 15);
            editStateLabel.TabIndex = 11;
            editStateLabel.Text = "State";
            // 
            // editZipCodeLabel
            // 
            editZipCodeLabel.AutoSize = true;
            editZipCodeLabel.Location = new Point(343, 266);
            editZipCodeLabel.Name = "editZipCodeLabel";
            editZipCodeLabel.Size = new Size(55, 15);
            editZipCodeLabel.TabIndex = 12;
            editZipCodeLabel.Text = "Zip Code";
            // 
            // editCurrentBalanceLabel
            // 
            editCurrentBalanceLabel.AutoSize = true;
            editCurrentBalanceLabel.Location = new Point(304, 311);
            editCurrentBalanceLabel.Name = "editCurrentBalanceLabel";
            editCurrentBalanceLabel.Size = new Size(94, 15);
            editCurrentBalanceLabel.TabIndex = 13;
            editCurrentBalanceLabel.Text = "Current Balance:";
            // 
            // editFirstNameTextBox
            // 
            editFirstNameTextBox.Location = new Point(417, 29);
            editFirstNameTextBox.Name = "editFirstNameTextBox";
            editFirstNameTextBox.Size = new Size(254, 23);
            editFirstNameTextBox.TabIndex = 14;
            // 
            // editLastNameTextBox
            // 
            editLastNameTextBox.Location = new Point(417, 59);
            editLastNameTextBox.Name = "editLastNameTextBox";
            editLastNameTextBox.Size = new Size(254, 23);
            editLastNameTextBox.TabIndex = 15;
            // 
            // editPhoneNumberTextBox
            // 
            editPhoneNumberTextBox.Location = new Point(417, 88);
            editPhoneNumberTextBox.Name = "editPhoneNumberTextBox";
            editPhoneNumberTextBox.Size = new Size(254, 23);
            editPhoneNumberTextBox.TabIndex = 16;
            // 
            // editEmailTextBox
            // 
            editEmailTextBox.Location = new Point(417, 117);
            editEmailTextBox.Name = "editEmailTextBox";
            editEmailTextBox.Size = new Size(254, 23);
            editEmailTextBox.TabIndex = 17;
            // 
            // editStreetAddressTextBox
            // 
            editStreetAddressTextBox.Location = new Point(417, 178);
            editStreetAddressTextBox.Name = "editStreetAddressTextBox";
            editStreetAddressTextBox.Size = new Size(254, 23);
            editStreetAddressTextBox.TabIndex = 19;
            // 
            // editCityTextBox
            // 
            editCityTextBox.Location = new Point(417, 208);
            editCityTextBox.Name = "editCityTextBox";
            editCityTextBox.Size = new Size(254, 23);
            editCityTextBox.TabIndex = 20;
            // 
            // editStateTextBox
            // 
            editStateTextBox.Location = new Point(417, 235);
            editStateTextBox.Name = "editStateTextBox";
            editStateTextBox.Size = new Size(254, 23);
            editStateTextBox.TabIndex = 21;
            // 
            // editZipCodeTextBox
            // 
            editZipCodeTextBox.Location = new Point(417, 263);
            editZipCodeTextBox.Name = "editZipCodeTextBox";
            editZipCodeTextBox.Size = new Size(254, 23);
            editZipCodeTextBox.TabIndex = 22;
            // 
            // editCurrentBalanceTextBox
            // 
            editCurrentBalanceTextBox.Location = new Point(417, 308);
            editCurrentBalanceTextBox.Name = "editCurrentBalanceTextBox";
            editCurrentBalanceTextBox.Size = new Size(254, 23);
            editCurrentBalanceTextBox.TabIndex = 23;
            // 
            // updateMemberButton
            // 
            updateMemberButton.Location = new Point(596, 426);
            updateMemberButton.Name = "updateMemberButton";
            updateMemberButton.Size = new Size(75, 23);
            updateMemberButton.TabIndex = 24;
            updateMemberButton.Text = "Update";
            updateMemberButton.UseVisualStyleBackColor = true;
            updateMemberButton.Click += updateMemberButton_Click;
            // 
            // editLastBalanceLabel
            // 
            editLastBalanceLabel.AutoSize = true;
            editLastBalanceLabel.Location = new Point(300, 342);
            editLastBalanceLabel.Name = "editLastBalanceLabel";
            editLastBalanceLabel.Size = new Size(98, 15);
            editLastBalanceLabel.TabIndex = 25;
            editLastBalanceLabel.Text = "Last Balance Edit:";
            // 
            // editBalanceLabel
            // 
            editBalanceLabel.AutoSize = true;
            editBalanceLabel.Location = new Point(417, 342);
            editBalanceLabel.Name = "editBalanceLabel";
            editBalanceLabel.Size = new Size(91, 15);
            editBalanceLabel.TabIndex = 26;
            editBalanceLabel.Text = "Select Someone";
            // 
            // editReferralIDLabel
            // 
            editReferralIDLabel.AutoSize = true;
            editReferralIDLabel.Location = new Point(417, 149);
            editReferralIDLabel.Name = "editReferralIDLabel";
            editReferralIDLabel.Size = new Size(91, 15);
            editReferralIDLabel.TabIndex = 27;
            editReferralIDLabel.Text = "Select Someone";
            // 
            // memberReferralLabel
            // 
            memberReferralLabel.AutoSize = true;
            memberReferralLabel.Location = new Point(13, 240);
            memberReferralLabel.Name = "memberReferralLabel";
            memberReferralLabel.Size = new Size(100, 15);
            memberReferralLabel.TabIndex = 28;
            memberReferralLabel.Text = "Member Referrals";
            // 
            // referralsListbox
            // 
            referralsListbox.FormattingEnabled = true;
            referralsListbox.ItemHeight = 15;
            referralsListbox.Location = new Point(12, 263);
            referralsListbox.Name = "referralsListbox";
            referralsListbox.Size = new Size(277, 169);
            referralsListbox.TabIndex = 29;
            // 
            // membershipIDLabel
            // 
            membershipIDLabel.AutoSize = true;
            membershipIDLabel.Location = new Point(310, 369);
            membershipIDLabel.Name = "membershipIDLabel";
            membershipIDLabel.Size = new Size(88, 15);
            membershipIDLabel.TabIndex = 30;
            membershipIDLabel.Text = "Membership ID";
            // 
            // memberIDLabel
            // 
            memberIDLabel.AutoSize = true;
            memberIDLabel.Location = new Point(417, 369);
            memberIDLabel.Name = "memberIDLabel";
            memberIDLabel.Size = new Size(91, 15);
            memberIDLabel.TabIndex = 31;
            memberIDLabel.Text = "Select Someone";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new Point(356, 394);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(42, 15);
            statusLabel.TabIndex = 32;
            statusLabel.Text = "Status:";
            // 
            // editMemberStatusComboBox
            // 
            editMemberStatusComboBox.FormattingEnabled = true;
            editMemberStatusComboBox.Location = new Point(417, 387);
            editMemberStatusComboBox.Name = "editMemberStatusComboBox";
            editMemberStatusComboBox.Size = new Size(254, 23);
            editMemberStatusComboBox.TabIndex = 33;
            // 
            // viewEditMembers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(690, 461);
            Controls.Add(editMemberStatusComboBox);
            Controls.Add(statusLabel);
            Controls.Add(memberIDLabel);
            Controls.Add(membershipIDLabel);
            Controls.Add(referralsListbox);
            Controls.Add(memberReferralLabel);
            Controls.Add(editReferralIDLabel);
            Controls.Add(editBalanceLabel);
            Controls.Add(editLastBalanceLabel);
            Controls.Add(updateMemberButton);
            Controls.Add(editCurrentBalanceTextBox);
            Controls.Add(editZipCodeTextBox);
            Controls.Add(editStateTextBox);
            Controls.Add(editCityTextBox);
            Controls.Add(editStreetAddressTextBox);
            Controls.Add(editEmailTextBox);
            Controls.Add(editPhoneNumberTextBox);
            Controls.Add(editLastNameTextBox);
            Controls.Add(editFirstNameTextBox);
            Controls.Add(editCurrentBalanceLabel);
            Controls.Add(editZipCodeLabel);
            Controls.Add(editStateLabel);
            Controls.Add(editCityLabel);
            Controls.Add(editStreetAddressLabel);
            Controls.Add(editReferralEmailLabel);
            Controls.Add(editEmailLabel);
            Controls.Add(editPhoneNumberLabel);
            Controls.Add(editLastNameLabel);
            Controls.Add(editFirstNameLabel);
            Controls.Add(SearchButton);
            Controls.Add(LastNameLabel);
            Controls.Add(LastNameTextbox);
            Controls.Add(membersListbox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "viewEditMembers";
            Text = "Edit Members";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox membersListbox;
        private TextBox LastNameTextbox;
        private Label LastNameLabel;
        private Button SearchButton;
        private Label editFirstNameLabel;
        private Label editLastNameLabel;
        private Label editPhoneNumberLabel;
        private Label editEmailLabel;
        private Label editReferralEmailLabel;
        private Label editStreetAddressLabel;
        private Label editCityLabel;
        private Label editStateLabel;
        private Label editZipCodeLabel;
        private Label editCurrentBalanceLabel;
        private TextBox editFirstNameTextBox;
        private TextBox editLastNameTextBox;
        private TextBox editPhoneNumberTextBox;
        private TextBox editEmailTextBox;
        private TextBox editStreetAddressTextBox;
        private TextBox editCityTextBox;
        private TextBox editStateTextBox;
        private TextBox editZipCodeTextBox;
        private TextBox editCurrentBalanceTextBox;
        private Button updateMemberButton;
        private Label editLastBalanceLabel;
        private Label editBalanceLabel;
        private Label editReferralIDLabel;
        private Label memberReferralLabel;
        private ListBox referralsListbox;
        private Label membershipIDLabel;
        private Label memberIDLabel;
        private Label statusLabel;
        private ComboBox editMemberStatusComboBox;
    }
}