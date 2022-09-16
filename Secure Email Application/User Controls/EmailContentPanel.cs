using Secure_Email_Application.Class;
using Secure_Email_Application.Forms;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Secure_Email_Application.User_Controls
{
    public partial class EmailContentPanel : UserControl
    {
        private static EmailContentPanel _instance;

        AppImagePanel appImagePanel = new AppImagePanel();

        string SelectedPath = null;

        string EmailFrom = null;

        string EncryptedSubject = null;
        string DecryptedSubject = null;

        string EncryptedBody = null;
        string DecryptedBody = null;
        
        string EmailDateTime = null;

        bool EmailTextDecrypted = false;


        Color _color;

        public static EmailContentPanel Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new EmailContentPanel();
                return _instance;
            }
        }

        public EmailContentPanel()
        {
            InitializeComponent();
        }

        private void EmailContentPanel_Load(object sender, EventArgs e)
        {
            bgwGetData.RunWorkerAsync();

            lblFrom.Text = null;
            lblDateTime.Text = null;
            btnDecrypt.Enabled = false;
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



        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            bgwDecrypt.RunWorkerAsync();
        }

        private void bgwDecrypt_DoWork(object sender, DoWorkEventArgs e)
        {
            if (EmailTextDecrypted == false)
            {
                new Password().ShowDialog();

                if (!string.IsNullOrEmpty(GlobalVariables.EncryptDecryptPassword))
                {
                    GetEmail.GetEmailText(GlobalVariables.InboxEmailFile);

                    DecryptedBody = Decryptor.TextDecrypt(EncryptedBody, GlobalVariables.EncryptDecryptPassword);
                    DecryptedSubject = Decryptor.TextDecrypt(EncryptedSubject, GlobalVariables.EncryptDecryptPassword);

                    EmailFrom = GetEmail.From;
                    EncryptedSubject = GetEmail.Subject;
                    EncryptedBody = GetEmail.Body;
                    EmailDateTime = GetEmail.DateTime;

                    EmailTextDecrypted = true;
                    GlobalVariables.EncryptDecryptPassword = null;
                }
                else
                {
                    return;
                }
            }

            else if(EmailTextDecrypted == true)
            {
                return;

            }
        }

        private void bgwDecrypt_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (EmailTextDecrypted == true)
            {
                lblFrom.Text = EmailFrom;
                txtSubject.Text = DecryptedSubject;
                txtBody.Text = DecryptedBody;
                lblDateTime.Text = EmailDateTime;

                AddRecord.AddLog("Email decrypted");
            }
        }

        


        private void bgwGetData_DoWork(object sender, DoWorkEventArgs e)
        {
            GetEmail.GetEmailText(GlobalVariables.InboxEmailFile);

            EmailFrom = GetEmail.From;
            EncryptedSubject = GetEmail.Subject;
            EncryptedBody = GetEmail.Body;
            EmailDateTime = GetEmail.DateTime;

            _color = GlobalVariables.Indicator;
        }

        private void bgwGetData_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblFrom.Text = EmailFrom;
            txtSubject.Text = EncryptedSubject;
            txtBody.Text = EncryptedBody;
            lblDateTime.Text = EmailDateTime;

            btnIndicator.IdleFillColor = _color;
            btnIndicator.onHoverState.FillColor = _color;
            btnIndicator.onHoverState.BorderColor = _color;

            Task.Delay(500);

            GetEmail.GetEmailAttachmentsFileName(GlobalVariables.InboxEmailFile);

            foreach (var file in GetEmail.EmailAttachmentsFileNames)
            {
                ShowAttachmentPanel showAttachmentPanel = new ShowAttachmentPanel();
                showAttachmentPanel.File.Text = file;

                AttachmentPanel.Controls.Add(showAttachmentPanel);
            }

            btnDecrypt.Enabled = true;

            if (AttachmentPanel.Controls.Count == 0)
            {
                btnDownloadEncryptedFiles.Enabled = false;
                btnDownloadDecryptedFiles.Enabled = false;
            }
            else if (AttachmentPanel.Controls.Count > 0)
            {
                btnDownloadEncryptedFiles.Enabled = true;
                btnDownloadDecryptedFiles.Enabled = true;
            }

            AddRecord.AddLog("Email data loaded");
        }



        private void btnDownloadEncryptedFiles_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog();

                fbd.Description = "Save encrypted files";
                fbd.ShowNewFolderButton = true;
                

                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    SelectedPath = fbd.SelectedPath;

                    bgwDownloadEncryptedFiles.RunWorkerAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bgwDownloadEncryptedFiles_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                btnBack.Enabled = false;

                btnDecrypt.Enabled = false;
                btnDownloadEncryptedFiles.Enabled = false;
                btnDownloadDecryptedFiles.Enabled = false;

                GetEmail.GetEmailAttachments(GlobalVariables.InboxEmailFile, SelectedPath + @"\");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bgwDownloadEncryptedFiles_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnBack.Enabled = true;

            btnDecrypt.Enabled = true;
            btnDownloadEncryptedFiles.Enabled = true;
            btnDownloadDecryptedFiles.Enabled = true;

            MessageBox.Show("Encrypted files downloaded!", System.Reflection.Assembly.GetExecutingAssembly().GetName().Name,
                buttons:MessageBoxButtons.OK, icon: MessageBoxIcon.Information);

            AddRecord.AddLog("Encrypted files downloaded!");
        }

        private void btnDownloadDecryptedFiles_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog();

                fbd.Description = "Save decrypted files";
                fbd.ShowNewFolderButton = true;


                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    SelectedPath = fbd.SelectedPath;

                    bgwDownloadDecryptedFiles.RunWorkerAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bgwDownloadDecryptedFiles_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                new Password().ShowDialog();

                if (!string.IsNullOrEmpty(GlobalVariables.EncryptDecryptPassword))
                {
                    btnBack.Enabled = false;

                    btnDecrypt.Enabled = false;
                    btnDownloadEncryptedFiles.Enabled = false;
                    btnDownloadDecryptedFiles.Enabled = false;

                    GetEmail.GetEmailAttachmentsFileName(GlobalVariables.InboxEmailFile);
                    GetEmail.GetEmailAttachments(GlobalVariables.InboxEmailFile, SelectedPath + @"\");

                    string tempPath = null;

                    foreach (var file in GetEmail.EmailAttachmentsFileNames)
                    {
                        tempPath = SelectedPath + @"\" + file;

                        Decryptor.FileDecrypt(tempPath, tempPath.Substring(0, tempPath.Length - 4), GlobalVariables.EncryptDecryptPassword);

                        if (File.Exists(tempPath))
                        {
                            try
                            {
                                File.Delete(tempPath);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }

                    }

                    GlobalVariables.EncryptDecryptPassword = null;
                }

                else
                {
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bgwDownloadDecryptedFiles_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnBack.Enabled = true;

            btnDecrypt.Enabled = true;
            btnDownloadEncryptedFiles.Enabled = true;
            btnDownloadDecryptedFiles.Enabled = true;

            MessageBox.Show("Decrypted files downloaded!", System.Reflection.Assembly.GetExecutingAssembly().GetName().Name,
            buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);

            AddRecord.AddLog("Decrypted files downloaded!");
        }
    }
}
