using Secure_Email_Application.Class;
using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Secure_Email_Application.Forms
{
    public partial class AccountAuthenticator : Form
    {
        string Code = null;

        public AccountAuthenticator()
        {
            InitializeComponent();
        }

        private const int CS_DROPSHADOW = 0x00020000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        private void AccountAuthenticator_Load(object sender, EventArgs e)
        {
            Card.Visible = false;

            txt1.Enabled = false;
            txt2.Enabled = false;
            txt3.Enabled = false;
            txt4.Enabled = false;
            txt5.Enabled = false;

            btnSubmit.Enabled = false;

            bgwSendCode.RunWorkerAsync();
        }


        private async void CheckCode()
        {
            string EnteredCode = txt1.Text + txt2.Text + txt3.Text + txt4.Text + txt5.Text;

           if (EnteredCode == Code)
            {
                AddRecord.AddLog("User logged in (2FA)");

                new MainForm().Show();
                await Task.Delay(200);
                this.Close();
            }

            else
            {
                MessageBox.Show("Code not matches!", "Warning", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Warning);
                //Environment.Exit(0);
                this.Close();
                LoginForm.Instance.Show();
            }
        }

        private void ControlsStatus()
        {
            txt1.Enabled = true;
            txt1.Focus();
            txt2.Enabled = false;
            txt3.Enabled = false;
            txt4.Enabled = false;
            txt5.Enabled = false;
            btnSubmit.Enabled = false;
            btnSubmit.Text = "5 Digits Left";
        }

        private void AccountAuthenticator_Shown(object sender, EventArgs e)
        {
            MainTransition.ShowSync(Card);
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {
            if (txt1.Text.Length == 1)
            {
                txt1.Enabled = false;
                txt2.Enabled = true;
                txt2.Focus();
                btnSubmit.Text = "4 Digits Left";
            }
        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {
            if (txt2.Text.Length == 1)
            {
                txt2.Enabled = false;
                txt3.Enabled = true;
                txt3.Focus();
                btnSubmit.Text = "3 Digits Left";
            }
        }

        private void txt3_TextChanged(object sender, EventArgs e)
        {
            if (txt3.Text.Length == 1)
            {
                txt3.Enabled = false;
                txt4.Enabled = true;
                txt4.Focus();
                btnSubmit.Text = "2 Digits Left";
            }
        }

        private void txt4_TextChanged(object sender, EventArgs e)
        {
            if (txt4.Text.Length == 1)
            {
                txt4.Enabled = false;
                txt5.Enabled = true;
                txt5.Focus();
                btnSubmit.Text = "1 Digits Left";
            }
        }

        private void txt5_TextChanged(object sender, EventArgs e)
        {
            if (txt5.Text.Length == 1)
            {
                txt5.Enabled = false;
                btnSubmit.Enabled = true;
                btnSubmit.Focus();
                btnSubmit.Text = "Submit";
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            CheckCode();
        }

        private void bgwSendCode_DoWork(object sender, DoWorkEventArgs e)
        {
            Code = GlobalMethods.SecurityCode();
            SendEmail.Send(Properties.Settings.Default.Email, "Two-factor authentication code", Code);
        }

        private void bgwSendCode_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ControlsStatus();
        }
    }
}
