using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account_Rigestration
{
    public partial class Form2 : Form
    {
        private DelegateText delProgram, delLastName, delFirstName, delMiddleName, delAddress;
        private DelegateNumber delStudentNumber, delAge, delContactNumber;
        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        
       
        public Form2()
        {
            InitializeComponent();
            delStudentNumber = new DelegateNumber(StudentInfoClass.GetStudentNumber);
            delProgram = new DelegateText(StudentInfoClass.GetProgram);
            delLastName = new DelegateText(StudentInfoClass.GetLastName);
            delFirstName = new DelegateText(StudentInfoClass.GetLastName);
            delMiddleName = new DelegateText(StudentInfoClass.GetMiddleName);
            delAge = new DelegateNumber(StudentInfoClass.GetAge);
            delContactNumber = new DelegateNumber(StudentInfoClass.GetContactNumber);
            delAddress = new DelegateText(StudentInfoClass.GetAddress);



            lbl_StudentNumber.Text = delStudentNumber(StudentInfoClass.StudentNumber).ToString();
            lbl_Program.Text = delProgram(StudentInfoClass.Program);
            lbl_LastName.Text = delLastName(StudentInfoClass.LastName);
            lbl_FirstName.Text = delFirstName(StudentInfoClass.FirstName);
            lbl_MiddleName.Text = delMiddleName(StudentInfoClass.MiddleName);
            lbl_Age.Text = delAge(StudentInfoClass.Age).ToString();
            lbl_ContactNo.Text = delAge(StudentInfoClass.ContactNumber).ToString();
            lbl_Address.Text = delAddress(StudentInfoClass.Address);

        }

        
        private void Form2_Load_1(object sender, EventArgs e)
        {

        }
       


    }
}
