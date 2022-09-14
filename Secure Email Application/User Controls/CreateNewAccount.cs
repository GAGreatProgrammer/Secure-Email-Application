using Secure_Email_Application.Class;
using Secure_Email_Application.Forms;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Secure_Email_Application.User_Controls
{
    public partial class CreateNewAccount : UserControl
    {
        private static CreateNewAccount _instance;

        public static CreateNewAccount Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new CreateNewAccount();
                return _instance;
            }
        }

        public CreateNewAccount()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (!LoginForm.Instance.ContentContainer.Controls.ContainsKey("Login"))
            {
                CreateNewAccount createNewAccount = new CreateNewAccount();
                createNewAccount.Dock = DockStyle.Fill;
                LoginForm.Instance.ContentContainer.Controls.Add(createNewAccount);
            }

            LoginForm.Instance.ContentContainer.Controls["Login"].BringToFront();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            Regex validateEmailRegex = new Regex("^\\S+@\\S+\\.\\S+$");

            if (string.IsNullOrEmpty(txtFirstName.Text) ||
                string.IsNullOrEmpty(txtLastName.Text) ||
                string.IsNullOrEmpty(txtEmail.Text) || 
                string.IsNullOrEmpty(txtEmailPassword.Text) ||
                string.IsNullOrEmpty(txtUsername.Text) || 
                string.IsNullOrEmpty(txtPassword.Text) ||
                string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                MessageBox.Show("Fill all fields!", "Warning", buttons: MessageBoxButtons.OK,
                    icon: MessageBoxIcon.Warning);
            }

            else if (validateEmailRegex.IsMatch(txtEmail.Text) == false)
            {
                MessageBox.Show("Enter correct email!", "Warning", buttons: MessageBoxButtons.OK,
                    icon: MessageBoxIcon.Warning);
            }

            else
            {
                if (SendEmail.CheckEmailAvailability(txtEmail.Text, txtEmailPassword.Text) == true)
                {
                    GlobalMethods.CreateAccount(txtFirstName.Text, txtLastName.Text, txtEmail.Text, txtEmailPassword.Text,
                                txtUsername.Text, txtPassword.Text, txtConfirmPassword.Text);

                    txtFirstName.Clear();
                    txtLastName.Clear();
                    txtEmail.Clear();
                    txtUsername.Clear();
                    txtPassword.Clear();
                    txtConfirmPassword.Clear();

                    btnCreateAccount.Enabled = false;

                    if (!LoginForm.Instance.ContentContainer.Controls.ContainsKey("Login"))
                    {
                        CreateNewAccount createNewAccount = new CreateNewAccount();
                        createNewAccount.Dock = DockStyle.Fill;
                        LoginForm.Instance.ContentContainer.Controls.Add(createNewAccount);
                    }

                    LoginForm.Instance.ContentContainer.Controls["Login"].BringToFront();
                }

                else if (SendEmail.CheckEmailAvailability(txtEmail.Text, txtEmailPassword.Text) == false)
                {
                    MessageBox.Show("Email data error!", "Warning", buttons: MessageBoxButtons.OK,
                    icon: MessageBoxIcon.Warning);
                }
            } 
        }

        private void btnGeneratePassword_Click(object sender, EventArgs e)
        {
            txtPassword.Text = GlobalMethods.RandomPassword(15);
            txtConfirmPassword.Text = txtPassword.Text;
        }
    }
}
