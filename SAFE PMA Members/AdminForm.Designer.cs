namespace SAFE_PMA_Members
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            addAdminButton = new Button();
            changePassButton = new Button();
            changeAdminPasswordButton = new Button();
            SuspendLayout();
            // 
            // addAdminButton
            // 
            addAdminButton.Location = new Point(78, 30);
            addAdminButton.Name = "addAdminButton";
            addAdminButton.Size = new Size(200, 23);
            addAdminButton.TabIndex = 0;
            addAdminButton.Text = "Add Administrator";
            addAdminButton.UseVisualStyleBackColor = true;
            addAdminButton.Click += addAdminButton_Click;
            // 
            // changePassButton
            // 
            changePassButton.Location = new Point(78, 59);
            changePassButton.Name = "changePassButton";
            changePassButton.Size = new Size(200, 23);
            changePassButton.TabIndex = 1;
            changePassButton.Text = "Change Your Password";
            changePassButton.UseVisualStyleBackColor = true;
            // 
            // changeAdminPasswordButton
            // 
            changeAdminPasswordButton.Location = new Point(78, 88);
            changeAdminPasswordButton.Name = "changeAdminPasswordButton";
            changeAdminPasswordButton.Size = new Size(200, 23);
            changeAdminPasswordButton.TabIndex = 2;
            changeAdminPasswordButton.Text = "Reset an Administrator Password";
            changeAdminPasswordButton.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 146);
            Controls.Add(changeAdminPasswordButton);
            Controls.Add(changePassButton);
            Controls.Add(addAdminButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AdminForm";
            Text = "Admin Area";
            ResumeLayout(false);
        }

        #endregion

        private Button addAdminButton;
        private Button changePassButton;
        private Button changeAdminPasswordButton;
    }
}