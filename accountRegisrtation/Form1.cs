using accountRegisrtation.StudentInfo;
using static System.Net.Mime.MediaTypeNames;
namespace accountRegisrtation
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            foreach (Control txt in this.Controls)
            {
                if (txt is TextBox && string.IsNullOrWhiteSpace(((TextBox)txt).Text))
                {
                    MessageBox.Show("Please fill in all text fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (txt is ComboBox && string.IsNullOrWhiteSpace(((ComboBox)txt).Text))
                {
                    MessageBox.Show("Please select a program.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (!long.TryParse(tbAge.Text, out long age))
            {
                MessageBox.Show("Age must be a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!long.TryParse(tbContactNo.Text, out long contactNo))
            {
                MessageBox.Show("Contact number must be a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!long.TryParse(tbStudentNo.Text, out long studentNo))
            {
                MessageBox.Show("Student number must be a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            StudentInfoClass.FirstName = tbFirstName.Text.ToString();
            StudentInfoClass.LastName = tbLastnName.Text.ToString();
            StudentInfoClass.MiddleName = tbMiddleName.Text.ToString();
            StudentInfoClass.Address = tbAddress.Text.ToString();
            StudentInfoClass.Program = cbProgram.Text.ToString();

            StudentInfoClass.Age = long.Parse(tbAge.Text);
            StudentInfoClass.ContactNo = long.Parse(tbContactNo.Text);
            StudentInfoClass.StudentNo = long.Parse(tbStudentNo.Text);


            



            FrmConfirm OutputFrm = new FrmConfirm();
            if (OutputFrm.ShowDialog() == DialogResult.OK)
            {
                foreach (Control txt in this.Controls)
                {
                    if (txt is TextBox)
                    {
                        ((TextBox)txt).Clear();
                    }
                    else if (txt is ComboBox)
                    {
                        ((ComboBox)txt).SelectedIndex = -1;
                    }

                    

                    
                }
            }

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
