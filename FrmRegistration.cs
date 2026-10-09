using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Linq;

namespace Sulit_Justin_LabStream
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                //student number
                if (!long.TryParse(txtStudentNo.Text, out long studentNumber))
                    throw new FormatException("Invalid Input. Letters/Special characters are not allowed.");

                //last name
                if (string.IsNullOrWhiteSpace(txtLastName.Text) || !txtLastName.Text.All(character => char.IsLetter(character) || character == ' '))
                    throw new FormatException("Invalid input. Numbers/Special characters are not allowed.");

                //first name
                if (string.IsNullOrWhiteSpace(txtFirstName.Text) || !txtFirstName.Text.All(character => char.IsLetter(character) || character == ' '))
                    throw new FormatException("Invalid input. Numbers/Special characters are not allowed.");

                //age
                if (!int.TryParse(txtAge.Text, out int age))
                    throw new FormatException("Invalid Input.  Letters/Special characters are not allowed.");

                //gender
                if (cboGender.SelectedIndex == -1)
                    throw new FormatException("Gender cannot be empty.");

                //program
                if (cboProgram.SelectedIndex == -1)
                    throw new FormatException("Program cannot be empty.");

                //birthday
                if (dtpBirthday.Value.Date > DateTime.Today)
                    throw new FormatException("Invalid birthday. Past to present date only.");

                //contact number
                if (string.IsNullOrWhiteSpace(txtContact.Text) || !txtContact.Text.All(char.IsDigit))
                    throw new FormatException("Invalid contact number. Letters/Special characters are not allowed.");

                //textfile path
                string folderPath = Application.StartupPath;

                string[] studentInfo =
                {
                    "Student No.: " + txtStudentNo.Text,
                    "Full Name: " + txtLastName.Text + ", " + txtFirstName.Text + " " + txtMI.Text + ".",
                    "Program: " + cboProgram.Text,
                    "Gender: " + cboGender.Text,
                    "Age: " + txtAge.Text,
                    "Birthday: " + dtpBirthday.Value.ToString("yyyy-MM-dd"),
                    "Contact No.: " + txtContact.Text
                };

                using (StreamWriter outputFile = new StreamWriter(Path.Combine(folderPath, txtStudentNo.Text + ".txt")))
                {
                    foreach (string infoLine in studentInfo)
                    {
                        outputFile.WriteLine(infoLine);
                    }
                }

                MessageBox.Show("Registration successful! Check " + folderPath);
            }
            catch (FormatException ex)
            {
                //warning message
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}