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
            // 1. there should be no empty text boxes
            if (string.IsNullOrWhiteSpace(tbFirstName.Text) ||
                string.IsNullOrWhiteSpace(tbLastnName.Text) ||
                string.IsNullOrWhiteSpace(tbMiddleName.Text) ||
                string.IsNullOrWhiteSpace(tbAddress.Text) ||
                string.IsNullOrWhiteSpace(cbProgram.Text) ||
                string.IsNullOrWhiteSpace(tbAge.Text) ||
                string.IsNullOrWhiteSpace(tbContactNo.Text) ||
                string.IsNullOrWhiteSpace(tbStudentNo.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. if numeric fields contain non-numeric values
            if (!long.TryParse(tbAge.Text, out long age) ||
                !long.TryParse(tbContactNo.Text, out long contactNo) ||
                !long.TryParse(tbStudentNo.Text, out long studentNo))
            {
                MessageBox.Show("Please enter valid numeric values for Age, Contact No, and Student No.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 3. Store all the values in StudentInfoClass
            StudentInfoClass.FirstName = tbFirstName.Text.ToString();
            StudentInfoClass.LastName = tbLastnName.Text.ToString();
            StudentInfoClass.MiddleName = tbMiddleName.Text.ToString();
            StudentInfoClass.Address = tbAddress.Text.ToString();
            StudentInfoClass.Program = cbProgram.Text.ToString();

            StudentInfoClass.Age = long.Parse(tbAge.Text);
            StudentInfoClass.ContactNo = long.Parse(tbContactNo.Text);
            StudentInfoClass.StudentNo = long.Parse(tbStudentNo.Text);

            // 4. Clear all fields using the "using method"
            using (FrmConfirm confirmForm = new FrmConfirm())
            {
                if (confirmForm.ShowDialog() == DialogResult.OK)
                {
                    ClearControls(this); // clears all text in the fields
                }
            }
            
        }


        // method for clearing text from field
        private void ClearControls(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl is TextBox txtBox)
                    txtBox.Clear();
                else if (ctrl is ComboBox cmbBox)
                    cmbBox.SelectedIndex = -1;
                else if (ctrl.HasChildren)
                    ClearControls(ctrl);
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
