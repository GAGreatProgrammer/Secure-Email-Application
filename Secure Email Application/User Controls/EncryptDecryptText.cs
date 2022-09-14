using Secure_Email_Application.Class;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Secure_Email_Application.User_Controls
{
    public partial class EncryptDecryptText : UserControl
    {
        private static EncryptDecryptText _instance;

        private AppImagePanel appImagePanel = new AppImagePanel();


        public static EncryptDecryptText Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new EncryptDecryptText();
                return _instance;
            }
        }

        public EncryptDecryptText()
        {
            InitializeComponent();
        }

        private void EncryptDecryptText_Load(object sender, EventArgs e)
        {

        }

        private void btnGeneratePassword_Click(object sender, EventArgs e)
        {
            txtPassword.Text = GlobalMethods.RandomPassword(15);
        }

        private void bgwEncrypt_DoWork(object sender, DoWorkEventArgs e)
        {
            Text = Encryptor.TextEncrypt(txtText.Text, txtPassword.Text);
        }

        private void bgwEncrypt_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            txtText.Text = Text;
        }

        private void bgwDecrypt_DoWork(object sender, DoWorkEventArgs e)
        {
            Text = Decryptor.TextDecrypt(txtText.Text, txtPassword.Text);
        }

        private void bgwDecrypt_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            txtText.Text = Text;
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            bgwEncrypt.RunWorkerAsync();
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            bgwDecrypt.RunWorkerAsync();
        }

        private void btnCopyText_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtText.Text))
                Clipboard.SetText(txtText.Text);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();

            if (!MainForm.Instance.ContentContainer.Controls.ContainsKey("AppImagePanel"))
            {
                appImagePanel.Dock = DockStyle.Fill;
                MainForm.Instance.ContentContainer.Controls.Add(appImagePanel);
            }

            MainForm.Instance.ContentContainer.Controls["AppImagePanel"].BringToFront();
        }
    }
}
