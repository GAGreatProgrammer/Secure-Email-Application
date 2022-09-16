using Secure_Email_Application.Class;
using Secure_Email_Application.Forms;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Secure_Email_Application.User_Controls
{
    public partial class Login : UserControl
    {
        private static Login _instance;

        public static Login Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Login();
                return _instance;
            }
        }

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.RememberMe == true)
            {
                txtUsername.Text = Properties.Settings.Default.Username;
                cbRememberMe.Checked = true;
            }
            else
            {
                txtUsername.Text = "";
                cbRememberMe.Checked = false;
            }
        }

        private void lblUserRegistration_Click(object sender, EventArgs e)
        {
            if (GlobalMethods.CheckAccountExists() == true)
            {
                MessageBox.Show("Account alredy exists!", "Warning",
                    buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Warning);
                return;
            }
            else if (GlobalMethods.CheckAccountExists() == false)
            {
                if (!LoginForm.Instance.ContentContainer.Controls.ContainsKey("CreateNewAccount"))
                {
                    CreateNewAccount createNewAccount = new CreateNewAccount();
                    createNewAccount.Dock = DockStyle.Fill;
                    LoginForm.Instance.ContentContainer.Controls.Add(createNewAccount);
                }

                LoginForm.Instance.ContentContainer.Controls["CreateNewAccount"].BringToFront();
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            if (GlobalMethods.CheckAccountExists() == true)
            {
                if (Properties.Settings.Default.EncryptSettings == true)
                {
                    AppSettingsSecurity.EncryptSettings(Properties.Settings.Default.Password);

                    Environment.Exit(0);
                }
                else
                {
                    Environment.Exit(0);
                }
            }

            else if (GlobalMethods.CheckAccountExists() == false)
            {
                Environment.Exit(0);
            }
        }

        private void CheckStatus()
        {
            if (cbRememberMe.Checked == true)
            {
                Properties.Settings.Default.RememberMe = true;
                Properties.Settings.Default.Save();
            }
            else if (cbRememberMe.Checked == false)
            {
                Properties.Settings.Default.RememberMe = false;
                Properties.Settings.Default.Save();
            }
        }

        private async void LoginMethod()
        {
            if (Properties.Settings.Default.Username.Equals(txtUsername.Text) &&
                Properties.Settings.Default.Password.Equals(GlobalMethods.EncryptPassword(txtPassword.Text)))
            {
                if (Properties.Settings.Default.TwoFactorAuthentication == true)
                {
                    LoginForm.Instance.Hide();
                    AccountAuthenticator accountAuthenticator = new AccountAuthenticator();

                    await Task.Delay(200);
                    accountAuthenticator.ShowDialog();
                }

                else if (Properties.Settings.Default.TwoFactorAuthentication == false)
                {
                    LoginForm.Instance.Hide();
                    MainForm mainForm = new MainForm();

                    await Task.Delay(200);
                    mainForm.Show();

                    AddRecord.AddLog("User logged in");
                }

            }
            else
            {
                MessageBox.Show("Wrong data. Try again!", "Error", 
                    buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }

        private void cbRememberMe_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            CheckStatus();
        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (GlobalMethods.CheckAccountExists() == true)
            {
                if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
                {
                    MessageBox.Show("Fill all necessary fields!", "Warning",
                        buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Warning);
                }

                else if (!string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrEmpty(txtPassword.Text))
                {
                    CheckStatus();
                    LoginMethod();

                    txtPassword.Clear();
                }
            }

            else if (GlobalMethods.CheckAccountExists() == false)
            {
                MessageBox.Show("Register a new account!", "Warning",
                    buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Warning);
            }
        }

        private void lblResetAccount_Click(object sender, EventArgs e)
        {
            if (GlobalMethods.CheckAccountExists() == true)
            {
                if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
                {
                    MessageBox.Show("Fill Username and Password field!", "Warning",
                        buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Warning);
                }

                else if (!string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrEmpty(txtPassword.Text))
                {
                    if (Properties.Settings.Default.Username.Equals(txtUsername.Text) &&
                        Properties.Settings.Default.Password.Equals(GlobalMethods.EncryptPassword(txtPassword.Text)))
                    {
                        DialogResult dialogResult = MessageBox.Show("Are you sure you want to reset your settings?", 
                            "Reset settings", MessageBoxButtons.YesNo, MessageBoxIcon.Information);


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

                            MessageBox.Show("Account reset successfully!",
                                System.Reflection.Assembly.GetExecutingAssembly().GetName().Name,
                                buttons: MessageBoxButtons.OK,
                                icon: MessageBoxIcon.Information);

                            AddRecord.AddLog("Account reset successfully");

                            Environment.Exit(0);
                        }

                        else if (dialogResult == DialogResult.No)
                        {
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Wrong data. Try again!", "Error",
                            buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                    }
                }
            }

            else if (GlobalMethods.CheckAccountExists() == false)
            {
                MessageBox.Show("User account not found. Unable to reset data!", "Warning",
                                    buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Warning);

                AddRecord.AddLog("User account not found. Unable to reset data!");
            }
        }
    }
}
