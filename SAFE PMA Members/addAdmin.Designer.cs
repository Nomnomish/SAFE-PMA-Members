namespace SAFE_PMA_Members
{
    partial class addAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addAdmin));
            adminUsernameLabel = new Label();
            userTextBox = new TextBox();
            passTextBox = new TextBox();
            passwordLabel = new Label();
            confirmPasswordLabel = new Label();
            confirmPassTextBox = new TextBox();
            submitAdminButton = new Button();
            SuspendLayout();
            // 
            // adminUsernameLabel
            // 
            adminUsernameLabel.AutoSize = true;
            adminUsernameLabel.Location = new Point(50, 15);
            adminUsernameLabel.Name = "adminUsernameLabel";
            adminUsernameLabel.Size = new Size(63, 15);
            adminUsernameLabel.TabIndex = 0;
            adminUsernameLabel.Text = "Username:";
            // 
            // userTextBox
            // 
            userTextBox.Location = new Point(116, 12);
            userTextBox.Name = "userTextBox";
            userTextBox.Size = new Size(222, 23);
            userTextBox.TabIndex = 1;
            // 
            // passTextBox
            // 
            passTextBox.Location = new Point(116, 41);
            passTextBox.Name = "passTextBox";
            passTextBox.Size = new Size(222, 23);
            passTextBox.TabIndex = 3;
            passTextBox.UseSystemPasswordChar = true;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(50, 44);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(60, 15);
            passwordLabel.TabIndex = 2;
            passwordLabel.Text = "Password:";
            // 
            // confirmPasswordLabel
            // 
            confirmPasswordLabel.AutoSize = true;
            confirmPasswordLabel.Location = new Point(3, 73);
            confirmPasswordLabel.Name = "confirmPasswordLabel";
            confirmPasswordLabel.Size = new Size(107, 15);
            confirmPasswordLabel.TabIndex = 4;
            confirmPasswordLabel.Text = "Confirm Password:";
            // 
            // confirmPassTextBox
            // 
            confirmPassTextBox.Location = new Point(116, 70);
            confirmPassTextBox.Name = "confirmPassTextBox";
            confirmPassTextBox.Size = new Size(222, 23);
            confirmPassTextBox.TabIndex = 5;
            confirmPassTextBox.UseSystemPasswordChar = true;
            // 
            // submitAdminButton
            // 
            submitAdminButton.Location = new Point(140, 104);
            submitAdminButton.Name = "submitAdminButton";
            submitAdminButton.Size = new Size(113, 23);
            submitAdminButton.TabIndex = 6;
            submitAdminButton.Text = "Submit Admin";
            submitAdminButton.UseVisualStyleBackColor = true;
            // 
            // addAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 139);
            Controls.Add(submitAdminButton);
            Controls.Add(confirmPassTextBox);
            Controls.Add(confirmPasswordLabel);
            Controls.Add(passTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(userTextBox);
            Controls.Add(adminUsernameLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "addAdmin";
            Text = "Add Admin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label adminUsernameLabel;
        private TextBox userTextBox;
        private TextBox passTextBox;
        private Label passwordLabel;
        private Label confirmPasswordLabel;
        private TextBox confirmPassTextBox;
        private Button submitAdminButton;
    }
}