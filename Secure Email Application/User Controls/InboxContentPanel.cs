using Bunifu.UI.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Secure_Email_Application.User_Controls
{
    public partial class InboxContentPanel : UserControl
    {
        private static InboxContentPanel _instance;

        public static InboxContentPanel Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new InboxContentPanel();
                return _instance;
            }
        }

        public FlowLayoutPanel EmailsPanel
        {
            get { return InboxEmailsContentPanel; }
            set { InboxEmailsContentPanel = value; }
        }

        public InboxContentPanel()
        {
            InitializeComponent();
        }

        private void InboxContentPanel_Load(object sender, EventArgs e)
        {
            ScrollBar.Maximum = EmailsPanel.VerticalScroll.Maximum;
            ScrollBar.BindTo(EmailsPanel);
        }

        private void ScrollBar_Scroll(object sender, BunifuVScrollBar.ScrollEventArgs e)
        {
            EmailsPanel.AutoScrollPosition = new Point(EmailsPanel.AutoScrollPosition.X, e.Value);
        }
    }
}
