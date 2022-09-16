using Secure_Email_Application.Class;
using System;
using System.Windows.Forms;

namespace Secure_Email_Application.Forms
{
    public partial class Password : Form
    {
        public Password()
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
        private void Password_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            GlobalVariables.EncryptDecryptPassword = null;
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPassword.Text))
            {
                GlobalVariables.EncryptDecryptPassword = txtPassword.Text;
                this.Close();
            }
            else
            {
                txtPassword.PlaceholderText = "Enter the appropriate password!";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
        }
    }
}
