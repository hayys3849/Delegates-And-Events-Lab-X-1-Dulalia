using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using accountRegisrtation.StudentInfo;

namespace accountRegisrtation
{
    public partial class FrmConfirm : Form
    {
        //declaration
        private DelegateText DelProgram, DelLastName, DelFirstName, DelMiddleName, DelAddress;
        private DelegateNumber DelNumAge, DelNumContactNo, DelStudNo;
        public FrmConfirm()
        {
            InitializeComponent();



        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void FrmConfirm_Load(object sender, EventArgs e)
        {

            //instance
            DelProgram = new DelegateText(StudentInfoClass.GetProgram);
            DelLastName = new DelegateText(StudentInfoClass.GetLastName);
            DelFirstName = new DelegateText(StudentInfoClass.GetFirstName);
            DelMiddleName = new DelegateText(StudentInfoClass.GetMiddleName);
            DelAddress = new DelegateText(StudentInfoClass.GetAddress);

            DelNumAge = new DelegateNumber(StudentInfoClass.GetAge);
            DelNumContactNo = new DelegateNumber(StudentInfoClass.GetContactNo);
            DelStudNo = new DelegateNumber(StudentInfoClass.GetStudentNo);


            label10.Text = DelProgram(StudentInfoClass.Program);
            label11.Text = DelLastName(StudentInfoClass.LastName);
            label12.Text = DelFirstName(StudentInfoClass.FirstName);
            label13.Text = DelMiddleName(StudentInfoClass.MiddleName);
            label16.Text = DelAddress(StudentInfoClass.Address);

            label14.Text = DelNumAge(StudentInfoClass.Age).ToString();
            label15.Text = DelNumContactNo(StudentInfoClass.ContactNo).ToString();
            label9.Text = DelStudNo(StudentInfoClass.StudentNo).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FrmConfirm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;    
        }
    }
}
