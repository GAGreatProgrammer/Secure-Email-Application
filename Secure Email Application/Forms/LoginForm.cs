using Secure_Email_Application.Class;
using Secure_Email_Application.User_Controls;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Secure_Email_Application.Forms
{
    public partial class LoginForm : Form
    {
        static LoginForm _object;

        public static LoginForm Instance
        {
            get
            {
                if (_object == null)
                {
                    _object = new LoginForm();
                }
                return _object;
            }
        }

        public Panel ContentContainer
        {
            get { return ContentPanel; }
            set { ContentPanel = value; }
        }
        public LoginForm()
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

        private void Login_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Properties.Settings.Default.Username) ||
                !string.IsNullOrEmpty(Properties.Settings.Default.Password))
            {
                if (Properties.Settings.Default.EncryptSettings == true)
                {
                    AppSettingsSecurity.DecryptSettings(Properties.Settings.Default.Password);
                }
            }
            else
            {

            }


            Image.Visible = false;
            ContentPanel.Visible = false;

            _object = this;

            if (!ContentPanel.Controls.Contains(Login.Instance))
            {
                ContentPanel.Controls.Add(Login.Instance);
                Login.Instance.Dock = DockStyle.Fill;
                Login.Instance.BringToFront();
            }

            else
            {
                Login.Instance.BringToFront();
            }
        }

        private async void Login_Shown(object sender, EventArgs e)
        {
            await Task.Delay(200);
            Image.Visible = true;
            ContentPanelTransition.ShowSync(ContentPanel);
        }

        private void Image_DoubleClick(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(Login.Instance))
            {
                ContentPanel.Controls.Add(Login.Instance);
                Login.Instance.Dock = DockStyle.Fill;
                Login.Instance.BringToFront();
            }

            else
            {
                Login.Instance.BringToFront();
            }
        }
    }
}
