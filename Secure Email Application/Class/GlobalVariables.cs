using System.Collections.Generic;
using System.Drawing;

namespace Secure_Email_Application.Class
{
    public static class GlobalVariables
    {
        public static bool Attachment { get; set; } = false;
        public static List<string> AttachmentFile { get; set; } = null;
        public static List<string> EncryptedAttachmentFile { get; set; } = null;
        public static string InboxEmailFile { get; set; } = null;


        public static bool EmailSent { get; set; } = false;

        public static Color Indicator { get; set; }

        public static string EncryptDecryptPassword { get; set; }
    }
}
