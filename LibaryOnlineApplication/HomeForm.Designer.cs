namespace LibaryOnlineApplication
{
    partial class HomeForm
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
            btnCategories = new Button();
            btnBook = new Button();
            btnAuthor = new Button();
            btnPublisher = new Button();
            btnLogout = new Button();
            label2 = new Label();
            labUser = new Label();
            labUsername = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(34, 9);
            label1.Name = "label1";
            label1.Size = new Size(312, 32);
            label1.TabIndex = 0;
            label1.Text = "He thong quan ly thu vien";
            // 
            // btnCategories
            // 
            btnCategories.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCategories.Location = new Point(34, 75);
            btnCategories.Name = "btnCategories";
            btnCategories.Size = new Size(142, 66);
            btnCategories.TabIndex = 1;
            btnCategories.Text = "Quan ly danh muc sach";
            btnCategories.UseVisualStyleBackColor = true;
            btnCategories.Click += btnCategories_Click;
            // 
            // btnBook
            // 
            btnBook.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnBook.Location = new Point(215, 75);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(163, 66);
            btnBook.TabIndex = 2;
            btnBook.Text = "Quan ly Sach";
            btnBook.UseVisualStyleBackColor = true;
            // 
            // btnAuthor
            // 
            btnAuthor.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAuthor.Location = new Point(412, 75);
            btnAuthor.Name = "btnAuthor";
            btnAuthor.Size = new Size(173, 66);
            btnAuthor.TabIndex = 3;
            btnAuthor.Text = "Quan ly tac gia";
            btnAuthor.UseVisualStyleBackColor = true;
            // 
            // btnPublisher
            // 
            btnPublisher.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnPublisher.Location = new Point(619, 75);
            btnPublisher.Name = "btnPublisher";
            btnPublisher.Size = new Size(149, 66);
            btnPublisher.TabIndex = 4;
            btnPublisher.Text = "QL Nha Xuat Ban";
            btnPublisher.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.Location = new Point(34, 173);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(142, 30);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Thoat";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(547, 23);
            label2.Name = "label2";
            label2.Size = new Size(19, 15);
            label2.TabIndex = 6;
            label2.Text = "Hi";
            // 
            // labUser
            // 
            labUser.AutoSize = true;
            labUser.Location = new Point(572, 23);
            labUser.Name = "labUser";
            labUser.Size = new Size(0, 15);
            labUser.TabIndex = 7;
            // 
            // labUsername
            // 
            labUsername.AutoSize = true;
            labUsername.Location = new Point(578, 23);
            labUsername.Name = "labUsername";
            labUsername.Size = new Size(43, 15);
            labUsername.TabIndex = 8;
            labUsername.Text = "Trieunt";
            labUsername.Click += labUsername_Click;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labUsername);
            Controls.Add(labUser);
            Controls.Add(label2);
            Controls.Add(btnLogout);
            Controls.Add(btnPublisher);
            Controls.Add(btnAuthor);
            Controls.Add(btnBook);
            Controls.Add(btnCategories);
            Controls.Add(label1);
            Name = "HomeForm";
            Text = "HomeForm";
            Load += HomeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCategories;
        private Button btnBook;
        private Button btnAuthor;
        private Button btnPublisher;
        private Button btnLogout;
        private Label label2;
        private Label labUser;
        private Label labUsername;
    }
}