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
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblStudentNo
            // 
            lblStudentNo.AutoSize = true;
            lblStudentNo.BackColor = Color.Transparent;
            lblStudentNo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblStudentNo.Location = new Point(25, 122);
            lblStudentNo.Name = "lblStudentNo";
            lblStudentNo.Size = new Size(77, 15);
            lblStudentNo.TabIndex = 0;
            lblStudentNo.Text = "Student No. :";
            lblStudentNo.Click += label1_Click;
            // 
            // lblProgram
            // 
            lblProgram.AutoSize = true;
            lblProgram.BackColor = Color.Transparent;
            lblProgram.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblProgram.Location = new Point(165, 122);
            lblProgram.Name = "lblProgram";
            lblProgram.Size = new Size(56, 15);
            lblProgram.TabIndex = 1;
            lblProgram.Text = "Program:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.BackColor = Color.Transparent;
            lblLastName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblLastName.Location = new Point(25, 187);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(66, 15);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.BackColor = Color.Transparent;
            lblFirstName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblFirstName.Location = new Point(165, 187);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(67, 15);
            lblFirstName.TabIndex = 3;
            lblFirstName.Text = "First Name:";
            // 
            // lblMiddleName
            // 
            lblMiddleName.AutoSize = true;
            lblMiddleName.BackColor = Color.Transparent;
            lblMiddleName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblMiddleName.Location = new Point(305, 187);
            lblMiddleName.Name = "lblMiddleName";
            lblMiddleName.Size = new Size(82, 15);
            lblMiddleName.TabIndex = 4;
            lblMiddleName.Text = "Middle Name:";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.BackColor = Color.Transparent;
            lblAge.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblAge.Location = new Point(25, 252);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(31, 15);
            lblAge.TabIndex = 5;
            lblAge.Text = "Age:";
            // 
            // lblContactNo
            // 
            lblContactNo.AutoSize = true;
            lblContactNo.BackColor = Color.Transparent;
            lblContactNo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblContactNo.Location = new Point(165, 252);
            lblContactNo.Name = "lblContactNo";
            lblContactNo.Size = new Size(76, 15);
            lblContactNo.TabIndex = 6;
            lblContactNo.Text = "Contact No. :";
            // 
            // tbStudentNo
            // 
            tbStudentNo.BackColor = SystemColors.Window;
            tbStudentNo.Cursor = Cursors.IBeam;
            tbStudentNo.Location = new Point(25, 145);
            tbStudentNo.Name = "tbStudentNo";
            tbStudentNo.Size = new Size(137, 23);
            tbStudentNo.TabIndex = 7;
            // 
            // tbLastnName
            // 
            tbLastnName.Cursor = Cursors.IBeam;
            tbLastnName.Location = new Point(25, 205);
            tbLastnName.Name = "tbLastnName";
            tbLastnName.Size = new Size(137, 23);
            tbLastnName.TabIndex = 8;
            // 
            // tbFirstName
            // 
            tbFirstName.Cursor = Cursors.IBeam;
            tbFirstName.Location = new Point(165, 205);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(137, 23);
            tbFirstName.TabIndex = 9;
            // 
            // tbMiddleName
            // 
            tbMiddleName.Cursor = Cursors.IBeam;
            tbMiddleName.Location = new Point(305, 205);
            tbMiddleName.Name = "tbMiddleName";
            tbMiddleName.Size = new Size(136, 23);
            tbMiddleName.TabIndex = 10;
            // 
            // tbAge
            // 
            tbAge.Cursor = Cursors.IBeam;
            tbAge.Location = new Point(25, 270);
            tbAge.Name = "tbAge";
            tbAge.Size = new Size(137, 23);
            tbAge.TabIndex = 11;
            // 
            // tbContactNo
            // 
            tbContactNo.Cursor = Cursors.IBeam;
            tbContactNo.Location = new Point(165, 270);
            tbContactNo.Name = "tbContactNo";
            tbContactNo.Size = new Size(137, 23);
            tbContactNo.TabIndex = 12;
            // 
            // cbProgram
            // 
            cbProgram.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbProgram.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbProgram.Cursor = Cursors.Hand;
            cbProgram.DropDownStyle = ComboBoxStyle.DropDownList;
            cbProgram.FormattingEnabled = true;
            cbProgram.Items.AddRange(new object[] { "BS in Information Technology", "BS in Computer Science ", "BS in Computer Engineering", "BS in Information System" });
            cbProgram.Location = new Point(165, 145);
            cbProgram.Name = "cbProgram";
            cbProgram.Size = new Size(279, 23);
            cbProgram.TabIndex = 13;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.BackColor = Color.Transparent;
            lblAddress.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddress.Location = new Point(25, 319);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(52, 15);
            lblAddress.TabIndex = 14;
            lblAddress.Text = "Address:";
            // 
            // tbAddress
            // 
            tbAddress.Cursor = Cursors.IBeam;
            tbAddress.Location = new Point(25, 337);
            tbAddress.Multiline = true;
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(422, 112);
            tbAddress.TabIndex = 15;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(183, 502);
            button1.Name = "button1";
            button1.Size = new Size(85, 30);
            button1.TabIndex = 16;
            button1.Text = "Next";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Comic Sans MS", 21.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(98, 38);
            label1.Name = "label1";
            label1.Size = new Size(268, 40);
            label1.TabIndex = 17;
            label1.Text = "Registration Form";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(tbContactNo);
            panel1.Controls.Add(lblProgram);
            panel1.Controls.Add(lblAge);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(lblMiddleName);
            panel1.Controls.Add(lblStudentNo);
            panel1.Controls.Add(tbAge);
            panel1.Controls.Add(tbLastnName);
            panel1.Controls.Add(cbProgram);
            panel1.Controls.Add(tbAddress);
            panel1.Controls.Add(lblContactNo);
            panel1.Controls.Add(tbFirstName);
            panel1.Controls.Add(lblFirstName);
            panel1.Controls.Add(lblLastName);
            panel1.Controls.Add(tbMiddleName);
            panel1.Controls.Add(tbStudentNo);
            panel1.Controls.Add(lblAddress);
            panel1.Location = new Point(59, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(461, 557);
            panel1.TabIndex = 18;
            panel1.Paint += panel1_Paint_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(584, 695);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmRegistration";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
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
        private Panel panel1;
    }
}
