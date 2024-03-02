namespace SalesWinApp
{
    partial class frmMain
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
            label1 = new Label();
            btnMemberManagement = new Button();
            btnOrderManagement = new Button();
            btnProductManagement = new Button();
            btnClose = new Button();
            btnLogout = new Button();
            infoText = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(31, 24);
            label1.Name = "label1";
            label1.Size = new Size(126, 54);
            label1.TabIndex = 0;
            label1.Text = "Menu";
            label1.Click += label1_Click;
            // 
            // btnMemberManagement
            // 
            btnMemberManagement.Location = new Point(31, 109);
            btnMemberManagement.Name = "btnMemberManagement";
            btnMemberManagement.Size = new Size(191, 35);
            btnMemberManagement.TabIndex = 1;
            btnMemberManagement.Text = "Member Management";
            btnMemberManagement.UseVisualStyleBackColor = true;
            btnMemberManagement.Click += btnMemberManagement_Click;
            // 
            // btnOrderManagement
            // 
            btnOrderManagement.Location = new Point(31, 221);
            btnOrderManagement.Name = "btnOrderManagement";
            btnOrderManagement.Size = new Size(191, 35);
            btnOrderManagement.TabIndex = 3;
            btnOrderManagement.Text = "Order Management";
            btnOrderManagement.UseVisualStyleBackColor = true;
            btnOrderManagement.Click += btnOrderManagement_Click;
            // 
            // btnProductManagement
            // 
            btnProductManagement.Location = new Point(31, 164);
            btnProductManagement.Name = "btnProductManagement";
            btnProductManagement.Size = new Size(191, 35);
            btnProductManagement.TabIndex = 2;
            btnProductManagement.Text = "Product Management";
            btnProductManagement.UseVisualStyleBackColor = true;
            btnProductManagement.Click += btnProductManagement_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(134, 339);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(89, 35);
            btnClose.TabIndex = 5;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(31, 339);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(89, 35);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Log out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // infoText
            // 
            infoText.AutoSize = true;
            infoText.Location = new Point(267, 24);
            infoText.Margin = new Padding(2, 0, 2, 0);
            infoText.Name = "infoText";
            infoText.Size = new Size(0, 20);
            infoText.TabIndex = 7;
            infoText.Click += label2_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 428);
            Controls.Add(infoText);
            Controls.Add(btnLogout);
            Controls.Add(btnClose);
            Controls.Add(btnProductManagement);
            Controls.Add(btnOrderManagement);
            Controls.Add(btnMemberManagement);
            Controls.Add(label1);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            FormClosing += frmMain_FormClosing;
            Load += frmMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnMemberManagement;
        private Button btnOrderManagement;
        private Button btnProductManagement;
        private Button btnClose;
        private Button btnLogout;
        private Label infoText;
    }
}