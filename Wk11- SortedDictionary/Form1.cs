using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInfoSystem
{
    public partial class frmStudent : Form
    {
        // adding a private instance variable of the type SortedDictionary called students:
            //declaring and instantiating
        private SortedDictionary<int, Student> students = new SortedDictionary<int, Student>();
        public frmStudent()
        {
            InitializeComponent();
        }

        private void frmStudent_Load(object sender, EventArgs e)
        {
            string[] items = { "Biomedical Engineering Technology",
                "Computer Repair and Maintenance",
                "Computer Systems Technician – Networking",
                "Computer Systems Technology – Networking",
                "Electronics Engineering Technician",
                "Electronics Engineering Technology",
                "Health Informatics Technology",
                "Software Engineering Technician",
                "Software Engineering Technology",
                "Software Engineering Technology – Interactive Gaming",
                "Technology Foundations (ICET)" };

            foreach (string program in items)
            {
                cboProgram.Items.Add(program);
            }

            PopulatedStudents();
        }

     
        private void btnOk_Click(object sender, EventArgs e)
        {
            Student myStudent = new Student(
                Convert.ToInt32(txtStudentId.Text), // convert from string to int
                txtFirstName.Text,
                txtLastName.Text,
                txtCity.Text,
                rbtnDomestic.Checked,
                cboProgram.Text,
                (int)nrudSemester.Value,
                double.Parse(txtGpa.Text),
                (chkComp123.Checked ? (chkComp123.Text + ",") : "") +
                (chkComp225.Checked ? (chkComp225.Text + ",") : "") +
                (chkComp213.Checked ? (chkComp213.Text + ",") : "") +
                (chkComp301.Checked ? (chkComp301.Text + ",") : "") +
                (chkComp391.Checked ? (chkComp391.Text + ",") : "") +
                (chkMath185.Checked ? (chkMath185.Text + ",") : "") +
                (chkComp100.Checked ? (chkComp100.Text + ",") : "")
                );

            // when the "ok" button gets clicked, add the new student to students SortedDictionary after student gets created:
            students.Add(myStudent.Id, myStudent);

            MessageBox.Show("Object Student Created!");

            // COMP123, COMP229, MATH185
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            CleanAll();
        }

        private void CleanAll()
        {
            txtStudentId.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtCity.Text = "";

            rbtnDomestic.Checked = true;
            cboProgram.Text = "";
            nrudSemester.Value = 0;
            txtGpa.Text = "0";

            chkComp123.Checked = false;
            chkComp225.Checked = false;
            chkComp213.Checked = false;
            chkComp301.Checked = false;
            chkComp391.Checked = false;
            chkMath185.Checked = false;
            chkComp100.Checked = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            CleanAll();

            int key = Convert.ToInt32(txtSearch.Text);

            if (students.ContainsKey(key) == true) //if it exists
            {
                Student s = students[key]; //s becomes a student

                // assigning value to form controls 
                txtStudentId.Text = s.Id.ToString();
                txtFirstName.Text = s.FirstName; //already a string
                txtLastName.Text = s.LastName;
                txtCity.Text = s.City;

                //radio buttons
                rbtnDomestic.Checked = s.IsDomestic; // 
                rbtnForeign.Checked = !s.IsDomestic; // foreign is true = false (2nd radio button option) (get opposite value with '!')

                cboProgram.Text = s.Program;
                nrudSemester.Value = s.Semester;
                txtGpa.Text = s.Gpa.ToString(); // its a double so have to convert to string with ToString()

                // courses
                chkComp123.Checked = s.Courses.Contains("COMP123");
                chkComp225.Checked = s.Courses.Contains("COMP225");
                chkComp213.Checked = s.Courses.Contains("COMP213");
                chkComp301.Checked = s.Courses.Contains("COMP301");
                chkComp391.Checked = s.Courses.Contains("COMP391");
                chkMath185.Checked = s.Courses.Contains("MATH158");
                chkComp100.Checked = s.Courses.Contains("COMP100");
            }
            else // message if student does not exist
            {
                MessageBox.Show("No student was found");
            }
        }
        private void PopulatedStudents() // this method makes student objects for us 
        {
            //creating student1
            Student student1 = new Student(300123,
            "John",
            "Smith",
            "Toronto",
            true,
            "Electronics Engineering Technology",
            5,
            3.2,
            "COMP123,COMP391,MATH185");

            //adding student1 to the dictionary
            students.Add(student1.Id, student1);

            //creating student2
            Student student2 = new Student(300050,
            "Mike",
            "Knight",
            "Oshawa",
            false,
            "Computer Systems Technology – Networking",
            3,
            3.0,
            "COMP225,COMP213,COMP100");

            //adding student2 to the dictionary
            students.Add(student2.Id, student2);

            //creating student3
            Student student3 = new Student(300430,
            "Miles",
            "Davis",
            "Mississauga",
            true,
            "Health Informatics Technology",
            1,
            2.8,
            "COMP301,COMP391");

            //adding student3 to the dictionary
            students.Add(student3.Id, student3);
        }
    }
}
