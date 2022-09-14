using Bunifu.UI.WinForms;
using Secure_Email_Application.Class;
using Secure_Email_Application.User_Controls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Secure_Email_Application
{
    public partial class InboxEmailInfo : UserControl
    {
        private string File = null;

        private Random rnd = new Random();
        Color randomColor;

        public InboxEmailInfo()
        {
            InitializeComponent();
        }

        public BunifuLabel EmailFile
        {
            get { return lblFile; }
            set { lblFile = value; }
        }

        public string OriginalFilePath
        {
            get { return File; }
            set {File = value; }
        }

        private void InboxEmailInfo_Load(object sender, EventArgs e)
        {
            File = lblFile.Text;

            lblDateTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

            randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));

            btnIndicator.IdleFillColor = randomColor;
            btnIndicator.onHoverState.FillColor = randomColor;
            btnIndicator.onHoverState.BorderColor = randomColor;


            if (lblFile.Text.Length > 14)
            {
                lblFile.Text = lblFile.Text.Substring(0, 14) + "...";
            }
        }

        private void InboxEmailInfo_DoubleClick(object sender, EventArgs e)
        {
            GlobalVariables.InboxEmailFile = File;
            GlobalVariables.Indicator = randomColor;

            MainForm.Instance.ContentContainer.Controls.Clear();

            if (!MainForm.Instance.ContentContainer.Controls.ContainsKey("EmailContentPanel"))
            {
                EmailContentPanel emailContentPanel = new EmailContentPanel();
                emailContentPanel.Dock = DockStyle.Fill;
                MainForm.Instance.ContentContainer.Controls.Add(emailContentPanel);
            }

            MainForm.Instance.ContentContainer.Controls["EmailContentPanel"].BringToFront();
        }

        private void lblFile_DoubleClick(object sender, EventArgs e)
        {
            GlobalVariables.InboxEmailFile = File;
            GlobalVariables.Indicator = randomColor;

            MainForm.Instance.ContentContainer.Controls.Clear();


            if (!MainForm.Instance.ContentContainer.Controls.ContainsKey("EmailContentPanel"))
            {
                EmailContentPanel emailContentPanel = new EmailContentPanel();
                emailContentPanel.Dock = DockStyle.Fill;
                MainForm.Instance.ContentContainer.Controls.Add(emailContentPanel);
            }

            MainForm.Instance.ContentContainer.Controls["EmailContentPanel"].BringToFront();
        }
    }
}
