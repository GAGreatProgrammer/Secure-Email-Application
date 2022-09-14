using System;
using System.Drawing;
using System.Windows.Forms;

namespace Secure_Email_Application.User_Controls
{
    public partial class SentContentPanel : UserControl
    {

        private static SentContentPanel _instance;

        public static SentContentPanel Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SentContentPanel();
                return _instance;
            }
        }

        public FlowLayoutPanel EmailsPanel
        {
            get { return SentEmailsContentPanel; }
            set { SentEmailsContentPanel = value; }
        }

        public SentContentPanel()
        {
            InitializeComponent();
        }

        private void SentContentPanel_Load(object sender, EventArgs e)
        {
            ScrollBar.Maximum = EmailsPanel.VerticalScroll.Maximum;
            ScrollBar.BindTo(EmailsPanel);
        }

        private void ScrollBar_Scroll(object sender, Bunifu.UI.WinForms.BunifuVScrollBar.ScrollEventArgs e)
        {
            EmailsPanel.AutoScrollPosition = new Point(EmailsPanel.AutoScrollPosition.X, e.Value);
        }
    }
}
