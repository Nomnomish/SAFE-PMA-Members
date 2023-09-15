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
            membersListbox = new ListBox();
            LastNameTextbox = new TextBox();
            LastNameLabel = new Label();
            SearchButton = new Button();
            SuspendLayout();
            // 
            // membersListbox
            // 
            membersListbox.FormattingEnabled = true;
            membersListbox.ItemHeight = 15;
            membersListbox.Location = new Point(12, 102);
            membersListbox.Name = "membersListbox";
            membersListbox.Size = new Size(277, 334);
            membersListbox.TabIndex = 0;
            // 
            // LastNameTextbox
            // 
            LastNameTextbox.Location = new Point(118, 29);
            LastNameTextbox.Name = "LastNameTextbox";
            LastNameTextbox.Size = new Size(171, 23);
            LastNameTextbox.TabIndex = 1;
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
            // viewEditMembers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SearchButton);
            Controls.Add(LastNameLabel);
            Controls.Add(LastNameTextbox);
            Controls.Add(membersListbox);
            Name = "viewEditMembers";
            Text = "viewEditMembers";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox membersListbox;
        private TextBox LastNameTextbox;
        private Label LastNameLabel;
        private Button SearchButton;
    }
}