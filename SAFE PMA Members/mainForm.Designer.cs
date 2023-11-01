namespace SAFE_PMA_Members
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            addMembersButton = new Button();
            editViewMembersButton = new Button();
            mainMenuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exportCSVMenuItem = new ToolStripMenuItem();
            exitMenuItem = new ToolStripMenuItem();
            aboutMenuItem = new ToolStripMenuItem();
            addAdminButton = new Button();
            mainMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // addMembersButton
            // 
            addMembersButton.Location = new Point(97, 79);
            addMembersButton.Name = "addMembersButton";
            addMembersButton.Size = new Size(219, 23);
            addMembersButton.TabIndex = 0;
            addMembersButton.Text = "Add Members";
            addMembersButton.UseVisualStyleBackColor = true;
            addMembersButton.Click += addMembersButton_Click;
            // 
            // editViewMembersButton
            // 
            editViewMembersButton.Location = new Point(97, 108);
            editViewMembersButton.Name = "editViewMembersButton";
            editViewMembersButton.Size = new Size(219, 23);
            editViewMembersButton.TabIndex = 1;
            editViewMembersButton.Text = "View/Edit Members";
            editViewMembersButton.UseVisualStyleBackColor = true;
            editViewMembersButton.Click += editViewMembersButton_Click;
            // 
            // mainMenuStrip
            // 
            mainMenuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, aboutMenuItem });
            mainMenuStrip.Location = new Point(0, 0);
            mainMenuStrip.Name = "mainMenuStrip";
            mainMenuStrip.Size = new Size(427, 24);
            mainMenuStrip.TabIndex = 2;
            mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exportCSVMenuItem, exitMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // exportCSVMenuItem
            // 
            exportCSVMenuItem.Name = "exportCSVMenuItem";
            exportCSVMenuItem.Size = new Size(132, 22);
            exportCSVMenuItem.Text = "&Export CSV";
            // 
            // exitMenuItem
            // 
            exitMenuItem.Name = "exitMenuItem";
            exitMenuItem.Size = new Size(132, 22);
            exitMenuItem.Text = "E&xit";
            // 
            // aboutMenuItem
            // 
            aboutMenuItem.Name = "aboutMenuItem";
            aboutMenuItem.Size = new Size(52, 20);
            aboutMenuItem.Text = "&About";
            // 
            // addAdminButton
            // 
            addAdminButton.Location = new Point(97, 50);
            addAdminButton.Name = "addAdminButton";
            addAdminButton.Size = new Size(219, 23);
            addAdminButton.TabIndex = 3;
            addAdminButton.Text = "Add Administrator";
            addAdminButton.UseVisualStyleBackColor = true;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 175);
            Controls.Add(addAdminButton);
            Controls.Add(editViewMembersButton);
            Controls.Add(addMembersButton);
            Controls.Add(mainMenuStrip);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = mainMenuStrip;
            Name = "mainForm";
            Text = "S.A.F.E PMA Members";
            mainMenuStrip.ResumeLayout(false);
            mainMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addMembersButton;
        private Button editViewMembersButton;
        private MenuStrip mainMenuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exportCSVMenuItem;
        private ToolStripMenuItem exitMenuItem;
        private ToolStripMenuItem aboutMenuItem;
        private Button addAdminButton;
    }
}