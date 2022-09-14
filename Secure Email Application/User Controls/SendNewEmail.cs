using Secure_Email_Application.Class;
using Secure_Email_Application.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Secure_Email_Application.User_Controls
{
    public partial class SendNewEmail : UserControl
    {
        private static SendNewEmail _instance;

        private AppImagePanel appImagePanel = new AppImagePanel();

        private string SubjectCiphertext = null;
        private string BodyCiphertext = null;

        private string To = null;

        public static SendNewEmail Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SendNewEmail();
                return _instance;
            }
        }



        public SendNewEmail()
        {
            InitializeComponent();
        }

        private void SendNewEmail_Load(object sender, EventArgs e)
        {
            GlobalVariables.AttachmentFile = new List<string>();
            GlobalVariables.EncryptedAttachmentFile = new List<string>();
        }


        private void bgwSendEmail_DoWork(object sender, DoWorkEventArgs e)
        {
            if (GlobalVariables.Attachment == true)
            {
                new Password().ShowDialog();

                if (!string.IsNullOrWhiteSpace(GlobalVariables.EncryptDecryptPassword))
                {
                    btnSend.Enabled = false;
                    btnAddAttachment.Enabled = false;
                    AttachmentPanel.Enabled = false;

                    SubjectCiphertext = Encryptor.TextEncrypt(txtSubject.Text, GlobalVariables.EncryptDecryptPassword);
                    BodyCiphertext = Encryptor.TextEncrypt(txtBody.Text, GlobalVariables.EncryptDecryptPassword);

                    foreach (var file in GlobalVariables.AttachmentFile)
                    {
                        Encryptor.FileEncrypt(file, GlobalVariables.EncryptDecryptPassword);
                        GlobalVariables.EncryptedAttachmentFile.Add(file + ".aes");
                    }

                    SendEmail.Send(txtTo.Text, SubjectCiphertext, BodyCiphertext, GlobalVariables.EncryptedAttachmentFile);
                } 
            }

            else if (GlobalVariables.Attachment == false)
            {
                new Password().ShowDialog();

                if (!string.IsNullOrWhiteSpace(GlobalVariables.EncryptDecryptPassword))
                {
                    btnSend.Enabled = false;
                    btnAddAttachment.Enabled = false;
                    AttachmentPanel.Enabled = false;

                    SubjectCiphertext = Encryptor.TextEncrypt(txtSubject.Text, GlobalVariables.EncryptDecryptPassword);
                    BodyCiphertext = Encryptor.TextEncrypt(txtBody.Text, GlobalVariables.EncryptDecryptPassword);

                    SendEmail.Send(txtTo.Text, SubjectCiphertext, BodyCiphertext);
                }
            }
        }

        private void bgwSendEmail_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (GlobalVariables.EmailSent == true)
            {
                Snackbar.Show(MainForm.Instance, "Email sent successfully!", 
                    Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);

                AddRecord.AddLog($"New email sent to: {To}");

                MainForm.AddSentEmailInfoPanel(To);

                Clear();
                GlobalVariables.EmailSent = false;

                btnSend.Enabled = true;
                btnAddAttachment.Enabled = true;
                AttachmentPanel.Enabled = true;
            }
        }


        private void btnSend_Click(object sender, EventArgs e)
        {
            Regex validateEmailRegex = new Regex("^\\S+@\\S+\\.\\S+$"); 

            if (string.IsNullOrEmpty(txtTo.Text) || string.IsNullOrEmpty(txtSubject.Text) || 
                string.IsNullOrEmpty(txtBody.Text))
            {
                Snackbar.Show(MainForm.Instance, "Fill all necessary fields!", 
                    Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning);
            }

            else if (validateEmailRegex.IsMatch(txtTo.Text) == false)
            {
                Snackbar.Show(MainForm.Instance, "Enter correct email!",
                    Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning);
            }

            else
            {
                To = txtTo.Text;

                bgwSendEmail.RunWorkerAsync();
            }
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

        private void btnAddAttachment_Click_1(object sender, EventArgs e)
        {
            GlobalVariables.AttachmentFile.Clear();
            AttachmentPanel.Controls.Clear();

            OpenFileDialog ofdFile = new OpenFileDialog();

            try
            {

                ofdFile.InitialDirectory = @"C:\";
                ofdFile.Title = "Secure Email Application";
                ofdFile.CheckFileExists = true;
                ofdFile.CheckPathExists = true;
                ofdFile.Multiselect = true;

                if (ofdFile.ShowDialog() == DialogResult.OK)
                {
                    GlobalVariables.Attachment = true;

                    foreach (var file in ofdFile.FileNames)
                    {
                        GlobalVariables.AttachmentFile.Add(file);
                    }

                    foreach (var file in GlobalVariables.AttachmentFile)
                    {
                        AddAttachmentPanel addAttachmentPanel = new AddAttachmentPanel();
                        addAttachmentPanel.File.Text = file;
                        addAttachmentPanel.FileSize.Text = "Size: " + Convert.ToString(new FileInfo(file).Length / 1024) + " KB";

                        AttachmentPanel.Controls.Add(addAttachmentPanel);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Clear()
        {
            GlobalVariables.Attachment = false;
            GlobalVariables.AttachmentFile.Clear();
            GlobalVariables.EncryptedAttachmentFile.Clear();

            txtTo.Clear();
            txtSubject.Clear();
            txtBody.Clear();
            To = null;

            AttachmentPanel.Controls.Clear();
        }
    }
}
