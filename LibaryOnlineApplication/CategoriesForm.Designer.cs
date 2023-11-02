namespace LibaryOnlineApplication
{
    partial class CategoriesForm
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
            groupBox1 = new GroupBox();
            cboStatus = new ComboBox();
            label3 = new Label();
            txtDescription = new TextBox();
            label2 = new Label();
            txtName = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnExit = new Button();
            btnAdd = new Button();
            groupBox3 = new GroupBox();
            listViewCategories = new ListView();
            label4 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboStatus);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtDescription);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(31, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(578, 251);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Infomartion";
            // 
            // cboStatus
            // 
            cboStatus.FormattingEnabled = true;
            cboStatus.Items.AddRange(new object[] { "Active", "Deactive" });
            cboStatus.Location = new Point(120, 187);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(237, 23);
            cboStatus.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 195);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 3;
            label3.Text = "Status";
            label3.Click += label3_Click;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(120, 72);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(435, 90);
            txtDescription.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 80);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 1;
            label2.Text = "Description";
            // 
            // txtName
            // 
            txtName.Location = new Point(120, 27);
            txtName.Name = "txtName";
            txtName.Size = new Size(435, 23);
            txtName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 35);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnExit);
            groupBox2.Controls.Add(btnAdd);
            groupBox2.Location = new Point(615, 23);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(173, 251);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Actions";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(6, 222);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(161, 23);
            btnExit.TabIndex = 1;
            btnExit.Text = "EXit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(6, 26);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add +";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(listViewCategories);
            groupBox3.Location = new Point(34, 280);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(754, 215);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "List Categories";
            // 
            // listViewCategories
            // 
            listViewCategories.Location = new Point(21, 34);
            listViewCategories.Name = "listViewCategories";
            listViewCategories.Size = new Size(717, 160);
            listViewCategories.TabIndex = 0;
            listViewCategories.UseCompatibleStateImageBehavior = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(248, 0);
            label4.Name = "label4";
            label4.Size = new Size(267, 32);
            label4.TabIndex = 1;
            label4.Text = "Category Management";
            // 
            // CategoriesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 515);
            Controls.Add(label4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "CategoriesForm";
            Text = "CategoriesForm";
            Load += CategoriesForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cboStatus;
        private Label label3;
        private TextBox txtDescription;
        private Label label2;
        private TextBox txtName;
        private Label label1;
        private GroupBox groupBox2;
        private Button btnExit;
        private Button btnAdd;
        private GroupBox groupBox3;
        private ListView listViewCategories;
        private Label label4;
    }
}