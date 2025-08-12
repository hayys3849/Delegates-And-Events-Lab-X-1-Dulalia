namespace accountRegisrtation
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblStudentNo = new Label();
            lblProgram = new Label();
            lblLastName = new Label();
            lblFirstName = new Label();
            lblMiddleName = new Label();
            lblAge = new Label();
            lblContactNo = new Label();
            tbStudentNo = new TextBox();
            tbLastnName = new TextBox();
            tbFirstName = new TextBox();
            tbMiddleName = new TextBox();
            tbAge = new TextBox();
            tbContactNo = new TextBox();
            cbProgram = new ComboBox();
            lblAddress = new Label();
            tbAddress = new TextBox();
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblStudentNo
            // 
            lblStudentNo.AutoSize = true;
            lblStudentNo.BackColor = Color.Transparent;
            lblStudentNo.Location = new Point(64, 86);
            lblStudentNo.Name = "lblStudentNo";
            lblStudentNo.Size = new Size(76, 15);
            lblStudentNo.TabIndex = 0;
            lblStudentNo.Text = "Student No. :";
            lblStudentNo.Click += label1_Click;
            // 
            // lblProgram
            // 
            lblProgram.AutoSize = true;
            lblProgram.BackColor = Color.Transparent;
            lblProgram.Location = new Point(207, 86);
            lblProgram.Name = "lblProgram";
            lblProgram.Size = new Size(56, 15);
            lblProgram.TabIndex = 1;
            lblProgram.Text = "Program:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.BackColor = Color.Transparent;
            lblLastName.Location = new Point(64, 151);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(66, 15);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.BackColor = Color.Transparent;
            lblFirstName.Location = new Point(207, 151);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(67, 15);
            lblFirstName.TabIndex = 3;
            lblFirstName.Text = "First Name:";
            // 
            // lblMiddleName
            // 
            lblMiddleName.AutoSize = true;
            lblMiddleName.BackColor = Color.Transparent;
            lblMiddleName.Location = new Point(350, 151);
            lblMiddleName.Name = "lblMiddleName";
            lblMiddleName.Size = new Size(82, 15);
            lblMiddleName.TabIndex = 4;
            lblMiddleName.Text = "Middle Name:";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.BackColor = Color.Transparent;
            lblAge.Location = new Point(64, 218);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(31, 15);
            lblAge.TabIndex = 5;
            lblAge.Text = "Age:";
            // 
            // lblContactNo
            // 
            lblContactNo.AutoSize = true;
            lblContactNo.BackColor = Color.Transparent;
            lblContactNo.Location = new Point(207, 218);
            lblContactNo.Name = "lblContactNo";
            lblContactNo.Size = new Size(77, 15);
            lblContactNo.TabIndex = 6;
            lblContactNo.Text = "Contact No. :";
            // 
            // tbStudentNo
            // 
            tbStudentNo.Location = new Point(64, 109);
            tbStudentNo.Name = "tbStudentNo";
            tbStudentNo.Size = new Size(137, 23);
            tbStudentNo.TabIndex = 7;
            // 
            // tbLastnName
            // 
            tbLastnName.Location = new Point(64, 169);
            tbLastnName.Name = "tbLastnName";
            tbLastnName.Size = new Size(137, 23);
            tbLastnName.TabIndex = 8;
            // 
            // tbFirstName
            // 
            tbFirstName.Location = new Point(207, 169);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(137, 23);
            tbFirstName.TabIndex = 9;
            // 
            // tbMiddleName
            // 
            tbMiddleName.Location = new Point(350, 169);
            tbMiddleName.Name = "tbMiddleName";
            tbMiddleName.Size = new Size(136, 23);
            tbMiddleName.TabIndex = 10;
            // 
            // tbAge
            // 
            tbAge.Location = new Point(64, 236);
            tbAge.Name = "tbAge";
            tbAge.Size = new Size(137, 23);
            tbAge.TabIndex = 11;
            // 
            // tbContactNo
            // 
            tbContactNo.Location = new Point(207, 236);
            tbContactNo.Name = "tbContactNo";
            tbContactNo.Size = new Size(137, 23);
            tbContactNo.TabIndex = 12;
            // 
            // cbProgram
            // 
            cbProgram.FormattingEnabled = true;
            cbProgram.Items.AddRange(new object[] { "BS in Information Technology", "BS in Computer Science ", "BS in Computer Engineering", "BS in Information System" });
            cbProgram.Location = new Point(207, 109);
            cbProgram.Name = "cbProgram";
            cbProgram.Size = new Size(279, 23);
            cbProgram.TabIndex = 13;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.BackColor = Color.Transparent;
            lblAddress.Location = new Point(64, 283);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(52, 15);
            lblAddress.TabIndex = 14;
            lblAddress.Text = "Address:";
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(64, 301);
            tbAddress.Multiline = true;
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(422, 112);
            tbAddress.TabIndex = 15;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(158, 198, 243);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(227, 466);
            button1.Name = "button1";
            button1.Size = new Size(85, 30);
            button1.TabIndex = 16;
            button1.Text = "Next";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(158, 198, 243);
            label1.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(101, 35);
            label1.TabIndex = 17;
            label1.Text = "Sign In";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(553, 525);
            Controls.Add(label1);
            Controls.Add(lblProgram);
            Controls.Add(button1);
            Controls.Add(lblStudentNo);
            Controls.Add(tbLastnName);
            Controls.Add(tbAddress);
            Controls.Add(tbFirstName);
            Controls.Add(lblLastName);
            Controls.Add(tbStudentNo);
            Controls.Add(lblAddress);
            Controls.Add(tbMiddleName);
            Controls.Add(lblFirstName);
            Controls.Add(lblContactNo);
            Controls.Add(cbProgram);
            Controls.Add(tbAge);
            Controls.Add(lblMiddleName);
            Controls.Add(lblAge);
            Controls.Add(tbContactNo);
            Name = "Form1";
            Text = "FrmRegistration";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStudentNo;
        private Label lblProgram;
        private Label lblLastName;
        private Label lblFirstName;
        private Label lblMiddleName;
        private Label lblAge;
        private Label lblContactNo;
        private TextBox tbStudentNo;
        private TextBox tbLastnName;
        private TextBox tbFirstName;
        private TextBox tbMiddleName;
        private TextBox tbAge;
        private TextBox tbContactNo;
        private ComboBox cbProgram;
        private Label lblAddress;
        private TextBox tbAddress;
        private Button button1;
        private Label label1;
    }
}
