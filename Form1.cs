using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountRegistration
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void nextButton_Click(object sender, EventArgs e)
        {

            StudentInfoClass.FirstName = firstNameBox.Text.ToString();
            StudentInfoClass.LastName = lastNameBox.Text.ToString();
            StudentInfoClass.MiddleName = middleNameBox.Text.ToString();
            StudentInfoClass.Address = addressBox.Text.ToString();
            StudentInfoClass.Program = programBox.Text.ToString();


            string parseFails = "Incorrect input, Please Check your input for the following:\n";

            if (isEmpty(StudentInfoClass.FirstName))
                parseFails += "First Name, ";
            if (isEmpty(StudentInfoClass.LastName))
                parseFails += "Last Name, ";
            if (isEmpty(StudentInfoClass.MiddleName))
                parseFails += "Middle Name, ";
            if (isEmpty(StudentInfoClass.Address))
                parseFails += "Address, ";
            if (isEmpty(StudentInfoClass.Program))
                parseFails += "Program, ";


            if (!long.TryParse(ageBox.Text, out StudentInfoClass.Age))
                parseFails += "Age, ";
            if (!long.TryParse(contactBox.Text, out StudentInfoClass.ContactNo))
                parseFails += "Contact Number, ";
            if (!long.TryParse(studentNoBox.Text, out StudentInfoClass.StudentNo))
                parseFails += "Student Number, ";

            if (parseFails.Length > 60)
                MessageBox.Show(parseFails);
            else
                new Form2().Show();
        }

        private bool isEmpty(string input) => input.Length == 0;
    }
}
