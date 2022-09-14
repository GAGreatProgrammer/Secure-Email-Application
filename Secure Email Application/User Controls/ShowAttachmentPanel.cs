using Bunifu.UI.WinForms;
using System;
using System.Windows.Forms;

namespace Secure_Email_Application.User_Controls
{
    public partial class ShowAttachmentPanel : UserControl
    {
        private string FileFullPath = null;


        public BunifuLabel File
        {
            get { return lblFile; }
            set { lblFile = value; }
        }
        public ShowAttachmentPanel()
        {
            InitializeComponent();
        }

        private void ShowAttachmentPanel_Load(object sender, EventArgs e)
        {
            try
            {
                FileFullPath = lblFile.Text;

                if (lblFile.Text.Length > 8)
                {
                    lblFile.Text = lblFile.Text.Substring(0, 8) + "...";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
