using accountRegisrtation.StudentInfo;
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
            FrmConfirm OutputFrm= new FrmConfirm();
            OutputFrm.ShowDialog();

            StudentInfoClass.FirstName = tbFirstName.Text.ToString();
            StudentInfoClass.LastName = tbLastnName.Text.ToString();
            StudentInfoClass.MiddleName = tbMiddleName.Text.ToString();
            StudentInfoClass.Address = tbAddress.Text.ToString();
            StudentInfoClass.Program = cbProgram.Text.ToString();

            StudentInfoClass.Age = long.Parse(tbAge.Text);
            StudentInfoClass.ContactNo = long.Parse(tbContactNo.Text);
            StudentInfoClass.StudentNo = long.Parse(tbStudentNo.Text);

           

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

                this.Close();

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
