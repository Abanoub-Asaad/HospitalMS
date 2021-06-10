﻿using System;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Data;
using System.Configuration;
using Oracle.DataAccess.Client;
using HospitalMS.HelperClasses;
using System.Windows.Forms;

namespace HospitalMS
{
    public partial class RegisterForm : Form
    {
        // ========================== Rounding Edges ==========================//
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // width of ellipse
           int nHeightEllipse // height of ellipse
        );
        // =====================================================================//
        private Thread thread;
        private OracleConnection conn;

        public RegisterForm()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            panelContainer.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelContainer.Width, panelContainer.Height, 30, 30));
            dateEmploymentYear.visibleIcon = false;
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            string dbConnection = ConfigurationManager.ConnectionStrings["databaseConnection"].ConnectionString;
            conn = new OracleConnection(dbConnection);
            conn.Open();

            loadClinicNames();
        }

        private void loadClinicNames()
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT ClinicName FROM clinic";
            cmd.CommandType = CommandType.Text;
            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
                comboClinics.Items.Add(reader[0]);
            reader.Close();
        }

        // ===================== CLOSE & LOGIN BUTTONS ===================== //
        private void pictureClose_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
            Close();
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            thread = new Thread(openForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            Close();
        }

        private void openForm(object obj)
        {
            Application.Run(new LoginForm());
        }

        // ========================= REGISTER PART ========================= //
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (isValidData())
            {
                if (isNewMember())
                {
                    MedicalStuff medicalStuff = new MedicalStuff();
                    medicalStuff.firstName = txtFirstName.Text;
                    medicalStuff.lastName = txtLastName.Text;
                    medicalStuff.age = DateTime.Now.Year - dateBirthdate.Value.Year;
                    medicalStuff.employmentYear = dateEmploymentYear.Value.Year;
                    medicalStuff.specialization = groupSpecialization.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;
                    medicalStuff.gender = groupGender.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;
                    medicalStuff.phone = txtPhone.Text;
                    medicalStuff.nationalID = txtNationalID.Text;
                    medicalStuff.password = txtPassword.Text;
                    if (radioDoctor.Checked)
                        medicalStuff.clinic = comboClinics.Text.ToString();
                    else
                        medicalStuff.clinic = null;

                    addMedicalStuff(medicalStuff);
                }
                else
                    MessageBox.Show("You are Registered Already !!", "REGISTRATION FAILED !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addMedicalStuff(MedicalStuff medicalStuff)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "addMedicalStuff";
            cmd.CommandType = CommandType.StoredProcedure;
            // START PARAMETERS
            cmd.Parameters.Add("NID", medicalStuff.nationalID);
            cmd.Parameters.Add("FirstName", medicalStuff.firstName);
            cmd.Parameters.Add("LastName", medicalStuff.lastName);
            cmd.Parameters.Add("uPassword", medicalStuff.password);
            cmd.Parameters.Add("Gender", medicalStuff.gender);
            cmd.Parameters.Add("Age", medicalStuff.age);
            cmd.Parameters.Add("Specialization", medicalStuff.specialization);
            cmd.Parameters.Add("YearOfEmployment", medicalStuff.employmentYear);
            cmd.Parameters.Add("ClinicName", medicalStuff.clinic);
            // END PARAMETERS
            cmd.ExecuteNonQuery();
            MessageBox.Show("You Have Been Registered Successfully !!", "Congratulations...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ======================= FIELDS VALIDATION ======================= //
        private bool isValidData()
        {
            // ------- FIRST & LAST NAME
            string name = txtFirstName.Text.Trim();
            if (name == "" || name == "First Name" || name == null)
            {
                MessageBox.Show("Please Enter Your First Name...", "Incomplete Data !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            foreach (char c in name)
                if (c <= '9' && c >= '0')
                {
                    MessageBox.Show("First Name Cannot Contains Numbers...", "Invalid Data !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            name = txtLastName.Text.Trim();
            if (name == "" || name == "Last Name" || name == null)
            {
                MessageBox.Show("Please Enter Your Last Name...", "Incomplete Data !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            foreach (char c in name)
                if (c <= '9' && c >= '0')
                {
                    MessageBox.Show("Last Name Cannot Contains Numbers...", "Invalid Data !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            // ------- CLINIC COMBOBOX
            if (radioDoctor.Checked == true && comboClinics.SelectedIndex == -1)
            {
                MessageBox.Show("Please Enter Your Assigned Clinic...", "Incomplete Data !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            // ------- PHONENUMBER
            string phone = txtPhone.Text.Trim();
            if (phone == "" || phone == "Phone Number" || phone == null)
            {
                MessageBox.Show("Please Enter Your Phone Number...", "Incomplete Data !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            for (int i = 0; i < phone.Length; ++i)
                if (phone[i] > '9' || phone[i] < '0')
                {
                    MessageBox.Show("Please Enter a Correct Phone Number...", "Invalid Phone Number !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            if (phone.Length != 11)
            {
                MessageBox.Show("Egypt Phone Number Should Consists of 11 Digits...", "Invalid Phone Number !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            // ------- NATIONAL ID
            string nationalID = txtNationalID.Text.Trim();
            if (nationalID == "" || nationalID == "National ID" || nationalID == null)
            {
                MessageBox.Show("Please Enter Your National ID...", "Incomplete Data !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            for (int i = 0; i < nationalID.Length; ++i)
                if (nationalID[i] > '9' || nationalID[i] < '0')
                {
                    MessageBox.Show("Please Enter a Correct Phone Number...", "Invalid National ID !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            if (nationalID.Length != 14)
            {
                MessageBox.Show("Egypt National ID Should Consists of 14 Digits...", "Invalid National ID !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            // ------- PASSWORDS
            string pass = txtPassword.Text.Trim();
            if (pass == "" || pass == "Password" || pass == null)
            {
                MessageBox.Show("Please Enter a Password...", "Incomplete Data !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            string rePass = txtConfirmPassword.Text.Trim();
            if (rePass == "" || rePass == "Confirm Password" || rePass == null)
            {
                MessageBox.Show("Please Confirm Password...", "Incomplete Data !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (pass != rePass)
            {
                MessageBox.Show("Passwords Doesn't Match !!", "Missmatch Passwords !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool isNewMember()
        {
            string nationalID = txtNationalID.Text;
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT COUNT (NationalID) FROM medical_stuff WHERE NationalID = :nationalID";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("nationalID", nationalID);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count != 0)     // MedicalStuff Already Registered Before
                return false;
            return true;
        }

        // ================== MOUSE ENTER LEAVE EFFECTS ==================== //
        private void txtFirstName_Enter(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "First Name")
            {
                txtFirstName.Text = ""; txtFirstName.ForeColor = Color.Gold;
            }
        }

        private void txtFirstName_Leave(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "")
            {
                txtFirstName.Text = "First Name"; txtFirstName.ForeColor = Color.WhiteSmoke;
            }
        }

        private void txtLastName_Enter(object sender, EventArgs e)
        {
            if (txtLastName.Text == "Last Name")
            {
                txtLastName.Text = ""; txtLastName.ForeColor = Color.Gold;
            }
        }

        private void txtLastName_Leave(object sender, EventArgs e)
        {
            if (txtLastName.Text == "")
            {
                txtLastName.Text = "Last Name"; txtLastName.ForeColor = Color.WhiteSmoke;
            }
        }

        private void txtPhone_Enter(object sender, EventArgs e)
        {
            if (txtPhone.Text == "Phone Number")
            {
                txtPhone.Text = ""; txtPhone.ForeColor = Color.Gold;
            }
        }

        private void txtPhone_Leave(object sender, EventArgs e)
        {
            if (txtPhone.Text == "")
            {
                txtPhone.Text = "Phone Number"; txtPhone.ForeColor = Color.WhiteSmoke;
            }
        }

        private void txtNationalID_Enter(object sender, EventArgs e)
        {
            if (txtNationalID.Text == "National ID")
            {
                txtNationalID.Text = ""; txtNationalID.ForeColor = Color.Gold;
            }
        }

        private void txtNationalID_Leave(object sender, EventArgs e)
        {
            if (txtNationalID.Text == "")
            {
                txtNationalID.Text = "National ID"; txtNationalID.ForeColor = Color.WhiteSmoke;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = ""; txtPassword.ForeColor = Color.Gold;
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password"; txtPassword.ForeColor = Color.WhiteSmoke;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtConfirmPassword_Enter(object sender, EventArgs e)
        {
            if (txtConfirmPassword.Text == "Confirm Password")
            {
                txtConfirmPassword.Text = ""; txtConfirmPassword.ForeColor = Color.Gold;
                txtConfirmPassword.UseSystemPasswordChar = false;
            }
        }

        private void txtConfirmPassword_Leave(object sender, EventArgs e)
        {
            if (txtConfirmPassword.Text == "")
            {
                txtConfirmPassword.Text = "Confirm Password"; txtConfirmPassword.ForeColor = Color.WhiteSmoke;
                txtConfirmPassword.UseSystemPasswordChar = true;
            }
        }

        private void radioDoctor_CheckedChanged(object sender, EventArgs e)
        {
            if (radioDoctor.Checked == true)
            {
                comboClinics.Visible = true;
                lblX.Visible = true;
            }
            else
            {
                comboClinics.Visible = false;
                lblX.Visible = false;
            }
                
        }

        private void lblX_Click(object sender, EventArgs e)
        {
            comboClinics.Visible = false;
            lblX.Visible = false;
            radioReceptionist.Checked = true;
        }

        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }

    }
}
