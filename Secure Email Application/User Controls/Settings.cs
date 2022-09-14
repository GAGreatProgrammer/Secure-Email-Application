using Bunifu.UI.WinForms;
using Secure_Email_Application.Class;
using Secure_Email_Application.Forms;
using System;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Secure_Email_Application.User_Controls
{
    public partial class Settings : UserControl
    {
        private static Settings _instance;

        public static Settings Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Settings();
                return _instance;
            }
        }

        public Settings()
        {
            InitializeComponent();
        }

        private void User_Load(object sender, EventArgs e)
        {
            GetAppData();
            GetUserData();
        }

        private void GetAppData()
        {
            lblUsername.Text = Properties.Settings.Default.Username;
            lblEmail.Text = Properties.Settings.Default.Email;

            btnUserInitials.Text = GetInitials(Properties.Settings.Default.FirstName + " " + Properties.Settings.Default.LastName);

            txtFirstName.Text = Properties.Settings.Default.FirstName;
            txtLastName.Text = Properties.Settings.Default.LastName;
            txtEmail.Text = Properties.Settings.Default.Email;

            txtEmailPassword.PlaceholderText = "**********";

            txtAppUsername.Text = Properties.Settings.Default.Username;

            txtAppPassword.PlaceholderText = "**********";
        }

        private void GetUserData()
        {
            if (Properties.Settings.Default.TwoFactorAuthentication == true)
                cboAuthenticationMethod.SelectedIndex = 0;
            else
                cboAuthenticationMethod.SelectedIndex = 1;



            if (Properties.Settings.Default.EncryptSettings == true)
                cboEncryptSettings.SelectedIndex = 0;
            else
                cboEncryptSettings.SelectedIndex = 1;



            if (Properties.Settings.Default.ProgramLockMethod == "Open authorization form")
                cboProgramLockMethod.SelectedIndex = 0;
            else if (Properties.Settings.Default.ProgramLockMethod == "Exit the program")
                cboProgramLockMethod.SelectedIndex = 1;



            if (Properties.Settings.Default.SendEmail == true)
                cboSendEmail.SelectedIndex = 0;
            else
                cboSendEmail.SelectedIndex = 1;



            if (Properties.Settings.Default.ActionAfterSaving == "Stay logged in")
                cboActcionAfterSave.SelectedIndex = 0;
            else if (Properties.Settings.Default.ActionAfterSaving == "Open login form")
                cboActcionAfterSave.SelectedIndex = 1;


            if (Properties.Settings.Default.GenerateLogFile == true)
                cboGenerateLogFile.SelectedIndex = 0;
            else
                cboGenerateLogFile.SelectedIndex = 1;
        }



        private void SaveAppData()
        {
            Regex validateEmailRegex = new Regex("^\\S+@\\S+\\.\\S+$");

            if (string.IsNullOrWhiteSpace(txtFirstName.Text) || 
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtEmailPassword.Text) ||
                string.IsNullOrWhiteSpace(txtAppUsername.Text) ||
                string.IsNullOrWhiteSpace(txtAppPassword.Text))
            {
                sbMessage.Show(MainForm.Instance, "Fill all fields!", BunifuSnackbar.MessageTypes.Warning,
                    duration: 2000, position: BunifuSnackbar.Positions.TopCenter);
            }

            else if (validateEmailRegex.IsMatch(txtEmail.Text) == false)
            {
                sbMessage.Show(MainForm.Instance, "Enter correct email!",
                    BunifuSnackbar.MessageTypes.Warning);
            }

            else
            {
                if (SendEmail.CheckEmailAvailability(txtEmail.Text, txtEmailPassword.Text) == true)
                {
                    Properties.Settings.Default.FirstName = txtFirstName.Text;
                    Properties.Settings.Default.LastName = txtLastName.Text;
                    Properties.Settings.Default.Email = txtEmail.Text;
                    Properties.Settings.Default.EmailPassword = txtEmailPassword.Text;
                    Properties.Settings.Default.Username = txtAppUsername.Text;
                    Properties.Settings.Default.Password = GlobalMethods.EncryptPassword(txtAppPassword.Text);

                    Properties.Settings.Default.Save();

                    sbMessage.Show(MainForm.Instance, "User information saved!", BunifuSnackbar.MessageTypes.Success,
                       duration: 2000, position: BunifuSnackbar.Positions.TopCenter);
                }

                else if (SendEmail.CheckEmailAvailability(txtEmail.Text, txtEmailPassword.Text) == false)
                {
                    sbMessage.Show(MainForm.Instance, "Email data error!",
                    BunifuSnackbar.MessageTypes.Warning);
                }
            }

            txtEmailPassword.Clear();
            txtAppPassword.Clear();

            txtEmailPassword.PlaceholderText = "**********";
            txtAppPassword.PlaceholderText = "**********";

            GetAppData();
        }

        private void SaveUserData()
        {
            if (cboAuthenticationMethod.SelectedIndex == 0)
                Properties.Settings.Default.TwoFactorAuthentication = true;
            else
                Properties.Settings.Default.TwoFactorAuthentication = false;



            if (cboEncryptSettings.SelectedIndex == 0)
                Properties.Settings.Default.EncryptSettings = true;
            else
                Properties.Settings.Default.EncryptSettings = false;



            if (cboProgramLockMethod.SelectedIndex == 0)
                Properties.Settings.Default.ProgramLockMethod = "Open authorization form";
            else if (cboProgramLockMethod.SelectedIndex == 1)
                Properties.Settings.Default.ProgramLockMethod = "Exit the program";



            if (cboSendEmail.SelectedIndex == 0)
                Properties.Settings.Default.SendEmail = true;
            else
                Properties.Settings.Default.SendEmail = false;



            if (cboActcionAfterSave.SelectedIndex == 0)
                Properties.Settings.Default.ActionAfterSaving = "Stay logged in";
            else if (cboActcionAfterSave.SelectedIndex == 1)
                Properties.Settings.Default.ActionAfterSaving = "Open login form";



            if (cboGenerateLogFile.SelectedIndex == 0)
                Properties.Settings.Default.GenerateLogFile = true;
            else
                Properties.Settings.Default.GenerateLogFile = false;



            Properties.Settings.Default.Save();
        }



        private string GetInitials(string value)
          => string.Concat(value
         .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
         .Where(x => x.Length >= 1 && char.IsLetter(x[0]))
         .Select(x => char.ToUpper(x[0])));

        private void btnGeneratePassword_Click(object sender, EventArgs e)
        {
            txtAppPassword.Text = GlobalMethods.RandomPassword(15);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            GetAppData();

            txtEmailPassword.Clear();
            txtAppPassword.Clear();

            txtEmailPassword.PlaceholderText = "**********";
            txtAppPassword.PlaceholderText = "**********";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveAppData();
            SaveUserData();

            if (Properties.Settings.Default.ActionAfterSaving == "Open login form")
            {
                MainForm.Instance.Close();
                LoginForm.Instance.Show();
            }
            else if (Properties.Settings.Default.ActionAfterSaving == "Stay logged in")
            {
                return;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to reset your settings?", "Reset settings",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialogResult == DialogResult.Yes)
            {
                Properties.Settings.Default.Username = null;
                Properties.Settings.Default.Password = null;
                Properties.Settings.Default.FirstName = null;
                Properties.Settings.Default.LastName = null;
                Properties.Settings.Default.Email = null;
                Properties.Settings.Default.EmailPassword = null;


                Properties.Settings.Default.TwoFactorAuthentication = true;
                Properties.Settings.Default.EncryptSettings = true;
                Properties.Settings.Default.ProgramLockMethod = "Open authorization form";
                Properties.Settings.Default.SendEmail = false;
                Properties.Settings.Default.ActionAfterSaving = "Stay logged in";
                Properties.Settings.Default.SendEmail = true;

                Properties.Settings.Default.Save();

                Environment.Exit(0);
            }

            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }
    }
}
