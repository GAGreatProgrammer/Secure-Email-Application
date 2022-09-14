using Bunifu.UI.WinForms;
using Secure_Email_Application.Class;
using System;
using System.Windows.Forms;

namespace Secure_Email_Application.User_Controls
{
    public partial class AddAttachmentPanel : UserControl
    {
        
        private string FileFullPath = null;
        

        public AddAttachmentPanel()
        {
            InitializeComponent();
        }

        private void AddAttachmentPanel_Load(object sender, EventArgs e)
        {
            try
            {
                FileFullPath = lblFile.Text;

                if (lblFile.Text.Length > 10)
                {
                    lblFile.Text = lblFile.Text.Substring(0, 10) + "...";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public BunifuLabel File
        {
            get { return lblFile; }
            set { lblFile = value; }
        }

        public BunifuLabel FileSize
        {
            get { return lblSize; }
            set { lblSize = value; }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            GlobalVariables.AttachmentFile.Remove(FileFullPath);

            this.Dispose();
        }
    }
}
