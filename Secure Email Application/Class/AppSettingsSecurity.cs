using Secure_Email_Application.Properties;


namespace Secure_Email_Application.Class
{
    public static class AppSettingsSecurity
    {
        public static void EncryptSettings(string Password)
        {
            Settings.Default.Username = Encryptor.TextEncrypt(Settings.Default.Username, Password);
            Settings.Default.FirstName = Encryptor.TextEncrypt(Settings.Default.FirstName, Password);
            Settings.Default.LastName = Encryptor.TextEncrypt(Settings.Default.LastName, Password);
            Settings.Default.Email = Encryptor.TextEncrypt(Settings.Default.Email, Password);
            Settings.Default.EmailPassword = Encryptor.TextEncrypt(Settings.Default.EmailPassword, Password);
            Settings.Default.ProgramLockMethod = Encryptor.TextEncrypt(Settings.Default.ProgramLockMethod, Password);
            Settings.Default.ActionAfterSaving = Encryptor.TextEncrypt(Settings.Default.ActionAfterSaving, Password);

            Settings.Default.Save();
        }

        public static void DecryptSettings(string Password)
        {
            Settings.Default.Username = Decryptor.TextDecrypt(Settings.Default.Username, Password);
            Settings.Default.FirstName = Decryptor.TextDecrypt(Settings.Default.FirstName, Password);
            Settings.Default.LastName = Decryptor.TextDecrypt(Settings.Default.LastName, Password);
            Settings.Default.Email = Decryptor.TextDecrypt(Settings.Default.Email, Password);
            Settings.Default.EmailPassword = Decryptor.TextDecrypt(Settings.Default.EmailPassword, Password);
            Settings.Default.ProgramLockMethod = Decryptor.TextDecrypt(Settings.Default.ProgramLockMethod, Password);
            Settings.Default.ActionAfterSaving = Decryptor.TextDecrypt(Settings.Default.ActionAfterSaving, Password);

            Settings.Default.Save();
        }
    }
}
