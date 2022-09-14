using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Secure_Email_Application.Class
{
    public static class GlobalMethods
    {
        public static string EncryptPassword(string password)
        {
            MD5CryptoServiceProvider md5Hash = new MD5CryptoServiceProvider();

            byte[] encrypt;

            UTF8Encoding encode = new UTF8Encoding();
            encrypt = md5Hash.ComputeHash(encode.GetBytes(password));

            StringBuilder encryptdata = new StringBuilder();

            for (int i = 0; i < encrypt.Length; i++)
            {
                encryptdata.Append(encrypt[i].ToString());
            }

            return encryptdata.ToString();
        }

        public static string RandomPassword(int length)
        {
            const string Uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string Lowercase = "abcdefghijklmnopqrstuvwxyz";
            const string Numbers = "1234567890";
            const string Symbols = @"~!@#$%^&*():;[]{}<>,.?/\|";

            try
            {
                char[] password = new char[length];
                string charSet = "";


                Random random = new Random();

                charSet += Uppercase;

                charSet += Lowercase;

                charSet += Numbers;

                charSet += Symbols;

                for (int i = 0; i < length; i++)
                    password[i] = charSet[random.Next(charSet.Length - 1)];

                return string.Join(null, password);
            }
            catch
            {
                return "Something went wrong!";
            }
        }

        public static string SecurityCode()
        {
            var numbers = "0123456789";
            var stringNumbers = new char[5];
            var random = new Random();

            for (int i = 0; i < stringNumbers.Length; i++)
            {
                stringNumbers[i] = numbers[random.Next(numbers.Length)];
            }

            var finalString = new String(stringNumbers);
            return finalString;
        }

        public static bool CheckAccountExists()
        {
            if (string.IsNullOrEmpty(Properties.Settings.Default.Username) &&
                string.IsNullOrEmpty(Properties.Settings.Default.Password))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static void CreateAccount(string FirstName, string LastName, string Email, string EmailPassword,
            string Username, string Password, string ConfirmPassword)
        {
            if (string.IsNullOrEmpty(Properties.Settings.Default.Username) && string.IsNullOrEmpty(Properties.Settings.Default.Password))
            {
                if (!Password.Equals(ConfirmPassword))
                {
                    MessageBox.Show("Password do not match!", System.Reflection.Assembly.GetExecutingAssembly().GetName().Name,
                        buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Warning);
                    return;
                }

                else
                {
                    Properties.Settings.Default.FirstName = FirstName;
                    Properties.Settings.Default.LastName = LastName;
                    Properties.Settings.Default.Email = Email;
                    Properties.Settings.Default.EmailPassword = EmailPassword;
                    Properties.Settings.Default.Username = Username;
                    Properties.Settings.Default.Password = GlobalMethods.EncryptPassword(Password);

                    Properties.Settings.Default.Save();

                    MessageBox.Show("New user registered!", System.Reflection.Assembly.GetExecutingAssembly().GetName().Name, 
                        buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("User exists!", System.Reflection.Assembly.GetExecutingAssembly().GetName().Name,
                     buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Warning);
                return;
            }

        }

    }
}
