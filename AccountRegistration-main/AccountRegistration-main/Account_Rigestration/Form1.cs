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
    public delegate long DelegateNumber(long number);
    public delegate string DelegateText(string txt);

    public class StudentInfoClass
    {
        
        public static string Program = "";
        public static string LastName = "";
        public static string FirstName = "";
        public static string MiddleName = "";
        public static string Address = "";
        public static int StudentNumber = 0;
        public static int Age = 0;
        public static int ContactNumber = 0;

        //for string 
        public static string GetProgram(string Program)
        {
            return Program;
        }

        public static string GetLastName(string LastName)
        {
            return LastName;
        }

        public static string GetFirstName(string FirstName)
        {
            return FirstName;
        }

        public static string GetMiddleName(string MiddleName)
        {
            return MiddleName;
        }
        public static string GetAddress(string Address)
        {
            return Address;
        }

        //for long
        public static long GetStudentNumber(long StudentNumber)
        {
            return StudentNumber;
        }

        public static long GetAge(long Age)
        {
            return Age;
        }

        public static long GetContactNumber(long ContactNumber)
        {
            return ContactNumber;

        }


    }
    public partial class Form1 : Form
    {  
        public Form1()
        {
            InitializeComponent();
            cB_Program.Items.Add("");
            cB_Program.Items.Add("BS Computer Science");
            cB_Program.Items.Add("BS Information Technology");
            cB_Program.Items.Add("BS Business Administration");
            cB_Program.Items.Add("BS Criminology");
        }


       
        private void B_Next_Click(object sender, EventArgs e)
        {
           // Form2 frm = new Form2();
            //delPassData del = new delPassData(frm.lastName);
            //del(this.tB_LastName);
           // firt firsts = new firt(frm.firstName);
            //firsts(this.tB_FirstName);
           // frm.Show();
           StudentInfoClass.StudentNumber =(int)long.Parse(tB_StudentNumber.Text.ToString());
            StudentInfoClass.Program = cB_Program.Text.ToString();
            StudentInfoClass.LastName = tB_LastName.Text.ToString();
            StudentInfoClass.FirstName = tB_FirstName.Text.ToString();
            StudentInfoClass.MiddleName = tB_MiddleName.Text.ToString();
            StudentInfoClass.Age = (int)long.Parse(tB_Age.Text.ToString());
            StudentInfoClass.ContactNumber = (int)long.Parse(tB_ContactNo.Text.ToString());
            StudentInfoClass.Address = rTb_Address.Text.ToString();


           Form2 frm = new Form2();
            frm.Show();

            tB_StudentNumber.Text = String.Empty;
            cB_Program.Text = String.Empty;
            tB_LastName.Text = String.Empty;
            tB_FirstName.Text = String.Empty;
            tB_MiddleName.Text = String.Empty;
            tB_Age.Text = String.Empty;
            tB_ContactNo.Text = String.Empty;
            rTb_Address.Text = String.Empty;




           
        }
       
       
        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
