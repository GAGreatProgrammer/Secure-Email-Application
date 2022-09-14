using Bunifu.UI.WinForms;
using Secure_Email_Application.Class;
using Secure_Email_Application.Forms;
using Secure_Email_Application.User_Controls;
using System;
using System.ComponentModel;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Settings = Secure_Email_Application.User_Controls.Settings;

namespace Secure_Email_Application
{
    public partial class MainForm : Form
    {
        static MainForm _object;

        OpenFileDialog ofdFile = new OpenFileDialog();

        AppImagePanel appImagePanel = new AppImagePanel();

        string SearchFileName = null;
        string EmailTo = null;

        string userControl = null;

        InboxContentPanel inboxContentPanel = new InboxContentPanel();
        static SentContentPanel sentContentPanel = new SentContentPanel();

        Settings settings = new Settings();

        public static MainForm Instance
        {
            get
            {
                if (_object == null)
                {
                    _object = new MainForm();
                }
                return _object;
            }
        }

        public BunifuPanel ContentContainer
        {
            get { return ContentPanel; }
            set { ContentPanel = value; }
        }


        public MainForm()
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


        private void MainForm_Load(object sender, EventArgs e)
        {
            _object = this;

            ContentPanel.Controls.Clear();

            if (!ContentContainer.Controls.ContainsKey("AppImagePanel"))
            {
                appImagePanel.Dock = DockStyle.Fill;
                ContentContainer.Controls.Add(appImagePanel);
            }


            ContentContainer.Controls["AppImagePanel"].BringToFront();

            ContentPanel.Visible = false;
            EmailInfoPanel.Visible = false;

            InboxSeparator.Visible = true;
            SentSeparator.Visible = false;
            EncryptDecryptTextSeparator.Visible = false;

            lblContent.Text = "Inbox";
            userControl = "Inbox";

            if (!EmailsPanel.Controls.ContainsKey("InboxContentPanel"))
            {
                inboxContentPanel.Dock = DockStyle.Fill;
                EmailsPanel.Controls.Add(inboxContentPanel);
            }

            EmailsPanel.Controls["InboxContentPanel"].BringToFront();

            bgwSendUserLogEmail.RunWorkerAsync();
        }

        private void FilteringInbox()
        {
            SearchFileName = Path.GetFileName(txtSearch.Text);

            foreach (InboxEmailInfo inboxEmailInfo in inboxContentPanel.EmailsPanel.Controls)
            {
                if (!inboxEmailInfo.OriginalFilePath.Contains(SearchFileName))
                {
                    inboxEmailInfo.Visible = false;
                }
                else
                {
                    inboxEmailInfo.Visible = true;
                }
            }
        }

        private void FilteringSent()
        {
            EmailTo = txtSearch.Text;

            foreach (SentEmailInfo sentEmailInfo in sentContentPanel.EmailsPanel.Controls)
            {
                if (!sentEmailInfo.To.Contains(EmailTo))
                {
                    sentEmailInfo.Visible = false;
                }
                else
                {
                    sentEmailInfo.Visible = true;
                }
            }
        }

        private void btnInbox_Click(object sender, EventArgs e)
        {
            if (!ContentContainer.Controls.ContainsKey("AppImagePanel"))
            {
                appImagePanel.Dock = DockStyle.Fill;
                ContentContainer.Controls.Add(appImagePanel);
            }

            ContentContainer.Controls["AppImagePanel"].BringToFront();


            InboxSeparator.Visible = true;
            SentSeparator.Visible = false;
            EncryptDecryptTextSeparator.Visible = false;

            lblContent.Text = "Inbox";
            userControl = "Inbox";


            if (!EmailsPanel.Controls.ContainsKey("InboxContentPanel"))
            {
                inboxContentPanel.Dock = DockStyle.Fill;
                EmailsPanel.Controls.Add(inboxContentPanel);
            }

            EmailsPanel.Controls["InboxContentPanel"].BringToFront();
        }


        private void btnSent_Click(object sender, EventArgs e)
        {
            if (!ContentContainer.Controls.ContainsKey("AppImagePanel"))
            {
                appImagePanel.Dock = DockStyle.Fill;
                ContentContainer.Controls.Add(appImagePanel);
            }

            ContentContainer.Controls["AppImagePanel"].BringToFront();


            InboxSeparator.Visible = false;
            SentSeparator.Visible = true;
            EncryptDecryptTextSeparator.Visible = false;

            lblContent.Text = "Sent";
            userControl = "Sent";

            if (!EmailsPanel.Controls.ContainsKey("SentContentPanel"))
            {
                sentContentPanel.Dock = DockStyle.Fill;
                EmailsPanel.Controls.Add(sentContentPanel);
            }

            EmailsPanel.Controls["SentContentPanel"].BringToFront();
        }


        private void btnClose_Click(object sender, EventArgs e)
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

        private void btnLoadFiles_Click(object sender, EventArgs e)
        {
            try
            {
                InboxSeparator.Visible = true;
                SentSeparator.Visible = false;

                lblContent.Text = "Inbox";
                userControl = "Inbox";

                if (!EmailsPanel.Controls.ContainsKey("InboxContentPanel"))
                {
                    inboxContentPanel.Dock = DockStyle.Fill;
                    EmailsPanel.Controls.Add(inboxContentPanel);
                }

                EmailsPanel.Controls["InboxContentPanel"].BringToFront();


                ofdFile.InitialDirectory = @"C:\";
                ofdFile.Title = "Secure Email Application";
                ofdFile.CheckFileExists = true;
                ofdFile.CheckPathExists = true;
                ofdFile.Multiselect = false;

                if (ofdFile.ShowDialog() == DialogResult.OK)
                {
                    if (ofdFile.FileName.EndsWith(".eml"))
                    {
                        GlobalVariables.InboxEmailFile = ofdFile.FileName;

                        InboxEmailInfo inboxEmailInfo = new InboxEmailInfo();

                        inboxEmailInfo.EmailFile.Text = ofdFile.FileName;

                        inboxContentPanel.EmailsPanel.Controls.Add(inboxEmailInfo);

                        AddRecord.AddLog("File loaded: " + ofdFile.FileName);
                    }
                    else
                    {
                        MessageBox.Show("The file you uploaded is not a mail file!", "Warning",
                            buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnComposeNewEmail_Click(object sender, EventArgs e)
        {
            if (!ContentContainer.Controls.ContainsKey("SendNewEmail"))
            {
                SendNewEmail sendNewEmail = new SendNewEmail();
                sendNewEmail.Dock = DockStyle.Fill;
                ContentContainer.Controls.Add(sendNewEmail);
            }

            ContentContainer.Controls["SendNewEmail"].BringToFront();

            InboxSeparator.Visible = false;
            SentSeparator.Visible = true;

            lblContent.Text = "Sent";
            userControl = "Sent";

            if (!EmailsPanel.Controls.ContainsKey("SentContentPanel"))
            {
                sentContentPanel.Dock = DockStyle.Fill;
                EmailsPanel.Controls.Add(sentContentPanel);
            }

            EmailsPanel.Controls["SentContentPanel"].BringToFront();
        }


        public static void AddSentEmailInfoPanel(string To)
        {
            SentEmailInfo sentEmailInfo = new SentEmailInfo();
            sentEmailInfo.EmailTo.Text = To;
            sentEmailInfo.EmailDateTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

            sentContentPanel.EmailsPanel.Controls.Add(sentEmailInfo);
        }

        private void txtSearch_OnIconRightClick(object sender, EventArgs e)
        {
            if (userControl == "Inbox")
            {
                FilteringInbox();
            }
            else if (userControl == "Sent")
            {
                FilteringSent();
            }
        }

        private void txtSearch_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtSearch.Clear();
            FilteringInbox();
            FilteringSent();
        }

        private void btnLock_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.EncryptSettings == true)
            {
                if (Properties.Settings.Default.ProgramLockMethod == "Open authorization form")
                {
                    this.Close();
                    LoginForm.Instance.Show();
                }

                else if (Properties.Settings.Default.ProgramLockMethod == "Exit the program")
                {
                    AppSettingsSecurity.EncryptSettings(Properties.Settings.Default.Password);

                    Environment.Exit(0);
                }
            }
            else
            {
                if (Properties.Settings.Default.ProgramLockMethod == "Open authorization form")
                {
                    this.Close();
                    LoginForm.Instance.Show();
                }

                else if (Properties.Settings.Default.ProgramLockMethod == "Exit the program")
                {
                    Environment.Exit(0);
                }
            }
        }

        private void btnEncryptDecryptText_Click(object sender, EventArgs e)
        {
            InboxSeparator.Visible = false;
            SentSeparator.Visible = false;
            EncryptDecryptTextSeparator.Visible = true;

            lblContent.Text = "Encrypt & Decrypt";

            ContentPanel.Controls.Clear();

            if (!ContentContainer.Controls.ContainsKey("EncryptDecryptText"))
            {
                EncryptDecryptText encryptDecryptText = new EncryptDecryptText();
                encryptDecryptText.Dock = DockStyle.Fill;
                ContentContainer.Controls.Add(encryptDecryptText);
            }

            ContentContainer.Controls["EncryptDecryptText"].BringToFront();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            InboxSeparator.Visible = false;
            SentSeparator.Visible = false;

            if (!ContentPanel.Controls.ContainsKey("Settings"))
            {
                settings.Dock = DockStyle.Fill;
                ContentPanel.Controls.Add(settings);
            }

            ContentPanel.Controls["Settings"].BringToFront();
        }

        private void bgwSendUserLogEmail_DoWork(object sender, DoWorkEventArgs e)
        {
            AddRecord.AddLog("Application opened");
            SendEmail.SendUserInfo(true);
        }

        private async void MainForm_Shown(object sender, EventArgs e)
        {
            await Task.Delay(300);
            Transition1.ShowSync(EmailInfoPanel);
            Transition2.ShowSync(ContentPanel);
        }

        private void pbIcon_Click(object sender, EventArgs e)
        {

        } 
    }
}
