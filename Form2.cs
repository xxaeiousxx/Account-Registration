using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AccountRegistration
{
    public partial class Form2 : Form
    {
        private DelegateText DelFirstName, DelLastName, DelMiddleName, DelAddress, DelProgram;
        private DelegateNumber DelAge, DelContactNo, DelStudentNo;

        public Form2()
        {
            InitializeComponent();
            DelFirstName = new DelegateText(StudentInfoClass.GetFirstName);
            DelLastName = new DelegateText(StudentInfoClass.GetLastName);
            DelMiddleName = new DelegateText(StudentInfoClass.GetMiddleName);
            DelAddress = new DelegateText(StudentInfoClass.GetAddress);
            DelProgram = new DelegateText(StudentInfoClass.GetProgram);
            DelAge = new DelegateNumber(StudentInfoClass.GetAge);
            DelContactNo = new DelegateNumber(StudentInfoClass.GetContactNo);
            DelStudentNo = new DelegateNumber(StudentInfoClass.GetStudentNo);

            StudentNo.Text = DelStudentNo(StudentInfoClass.StudentNo).ToString();
            Program.Text = DelProgram(StudentInfoClass.Program).ToString();
            LastName.Text = DelLastName(StudentInfoClass.LastName).ToString();
            FirstName.Text = DelFirstName(StudentInfoClass.FirstName).ToString();
            MiddleName.Text = DelMiddleName(StudentInfoClass.MiddleName).ToString();
            Age.Text = DelAge(StudentInfoClass.StudentNo).ToString();
            ContactNo.Text = DelContactNo(StudentInfoClass.ContactNo).ToString();
            Address.Text = DelAddress(StudentInfoClass.Address).ToString();
        }
    }
}
