using Bunifu.UI.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Secure_Email_Application.User_Controls
{
    public partial class SentEmailInfo : UserControl
    {
        private Random rnd = new Random();
        Color randomColor;

        string OriginalEmailTo = null;

        public SentEmailInfo()
        {
            InitializeComponent();
        }

        public BunifuLabel EmailTo
        {
            get { return lblTo; }
            set { lblTo = value; }
        }

        public BunifuLabel EmailDateTime
        {
            get { return lblDateTime; }
            set { lblDateTime = value; }
        }

        public string To
        {
            get { return OriginalEmailTo; }
            set { OriginalEmailTo = value; }
        }

        private void SentEmailInfo_Load(object sender, EventArgs e)
        {
            randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));

            btnIndicator.IdleFillColor = randomColor;
            btnIndicator.onHoverState.FillColor = randomColor;
            btnIndicator.onHoverState.BorderColor = randomColor;

            OriginalEmailTo = lblTo.Text;

            if (lblTo.Text.Length > 14)
            {
                lblTo.Text = lblTo.Text.Substring(0, 14) + "...";
            }
        }
    }
}
