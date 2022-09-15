# **Secure Email** 
---
![Developed_by](https://img.shields.io/badge/Developed_by-GAGreatProgrammer-green) ![OS](https://img.shields.io/badge/OS-_Windows-blue) ![.Net](https://img.shields.io/badge/.Net-_v4.7.2-red) ![GitHub last commit](https://img.shields.io/github/last-commit/GAGreatProgrammer/Secure-Email-Application) ![GitHub](https://img.shields.io/github/license/GAGreatProgrammer/Secure-Email-Application?color=orange)

<br/>

Secure Email is an application that is designed to ensure user's privacy when sending an email. Application is able to provide a high level of privacy using high encryption standards. The algorithms used in Secure Email allow user to quickly and efficiently encrypt any message and files that he sends to his interlocutor. After encrypting a message, user can be sure of its reliability. Even if this message is received by a hacker, he will not be able to decrypt it without having the appropriate password.


## Application Features
---
![Secure Email](https://raw.githubusercontent.com/GAGreatProgrammer/Secure-Email-Application/master/Secure%20Email%20Application/Assets/MainForm.PNG)

Secure Email allows you to quickly encrypt an email and deliver it to the recipient. To encrypt a text message, the program uses the Triple DES encryption algorithm. The choice of this algorithm is due to the fact that it takes less time to encrypt and decrypt a text message, thereby increasing its efficiency.

When sending files, Secure Email uses the AES encryption algorithm, which ensures that the encrypted files are highly secure. The files encrypted by the program are sent to the addressee, who, in turn, can decrypt them immediately, or download the encrypted files for further decryption. You can decrypt files [using this program.](https://github.com/GAGreatProgrammer/SecureFile)

Secure Email uses `smtp.gmail.com` to send email. To send a message, you do not need to encrypt the text or files yourself. You just need to write a message. Secure Email will take care of the rest.

<br/>

## Registration
---

After the first launch of the application, you will need to register. To register, click the `Register here` button and you will be redirected to the registration form.

![Secure Email](https://raw.githubusercontent.com/GAGreatProgrammer/Secure-Email-Application/master/Secure%20Email%20Application/Assets/Registration.PNG)

Fill all fields to complete registration. For the app to work properly, you need to enter your email address and password. BUT, Secure Email uses a 16 digit App Password, which you must create yourself in your account. [You can find out details here.](https://support.google.com/accounts/answer/185833?hl=en)

<n/>

After you fill all fields, click the `Create Account` button. If you correctly entered the email address and the 16-digit App Password, a message will be sent to your email about checking the validity of the email address. After that, the program will register a new user. You can change the settings at any time in the settings tab. To save your settings, you will need to enter your 16 digit google account App Password and Secure Email application password. Keep in mind that only one user can be registered in the program.

<n/>

If you want to reset your account, you can click the `Reset Account` button. To reset your account data, enter your username and password on the login form and click the reset button. After that, the program will reset all your settings and return to factory settings.


After successful registration, you will be able to log into your account by entering your username and password. Also, you can enable the `Remember me` feature by selecting it. After that, you won't have to enter your username every time you log into the app.

![Secure Email](https://raw.githubusercontent.com/GAGreatProgrammer/Secure-Email-Application/master/Secure%20Email%20Application/Assets/Login.PNG)

<br/>

## Sending email
---
To send an email, you need to enter the following data:

* Email of the user to whom you want to send the encrypted message.
* Subject. The text in this field will also be encrypted.
* Email text. Keep in mind that the maximum number of characters is 32767.
* Attachment. You can send files that will be encrypted with the appropriate algorithm. (Not necessary)

![Secure Email](https://raw.githubusercontent.com/GAGreatProgrammer/Secure-Email-Application/master/Secure%20Email%20Application/Assets/ComposeNewEmail.PNG)

You can remove the attachments you have selected by clicking the red button on the attachments panel. If you exceed the file size limit or an error occurs while sending the email, you will receive a corresponding message. 

The AES algorithm is used to encrypt files.

<n/>

#### Encrypting files
```csharp
public static void FileEncrypt(string inputFile, string password)
        {

            byte[] salt = Salt.GenerateRandomSalt();

            FileStream fsCrypt = new FileStream(inputFile + ".aes", FileMode.Create);

            byte[] passwordBytes = System.Text.Encoding.UTF8.GetBytes(password);

            RijndaelManaged AES = new RijndaelManaged();
            AES.KeySize = 256;
            AES.BlockSize = 128;
            AES.Padding = PaddingMode.PKCS7;

            var key = new Rfc2898DeriveBytes(passwordBytes, salt, 50000);
            AES.Key = key.GetBytes(AES.KeySize / 8);
            AES.IV = key.GetBytes(AES.BlockSize / 8);


            AES.Mode = CipherMode.CFB;

            fsCrypt.Write(salt, 0, salt.Length);

            CryptoStream cs = new CryptoStream(fsCrypt, AES.CreateEncryptor(), CryptoStreamMode.Write);

            FileStream fsIn = new FileStream(inputFile, FileMode.Open);

            byte[] buffer = new byte[1048576];
            int read;

            try
            {
                while ((read = fsIn.Read(buffer, 0, buffer.Length)) > 0)
                {
                    Application.DoEvents();
                    cs.Write(buffer, 0, read);
                }

                fsIn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cs.Close();
                fsCrypt.Close();
            }
        }
```

<br/>

## Decrypting email
---
To decrypt an email message, user needs to download it from his Gmail account. To download a message, `Open it from inbox > click More button > select Download message.` The downloaded message will have an `.eml`extension. The program only works with this extension.

After downloading the message, click the `Load file` button in the main menu and select the desired file. The file will appear in the sidebar. Then double click on the file name to open it. You will see an encrypted message.

![Secure Email](https://raw.githubusercontent.com/GAGreatProgrammer/Secure-Email-Application/master/Secure%20Email%20Application/Assets/Email.PNG)

<n/>

To decrypt the email message, click the `Decrypt` button. After that, the program will prompt you to enter the password with which the email was encrypted. After entering the correct password, the message will be decrypted. Keep in mind that the `Decrypt` button only decrypts the text of the message. To decrypt files (if they exist), click the `Download decrypted files` button. After that, the program will ask you to enter a password. If you don't want to decrypt the file, you can download the encrypted files. You can decrypt encrypted files [using this program.](https://github.com/GAGreatProgrammer/SecureFile)

The AES algorithm is used to decrypt files.

<n/>

#### Decrypting files

```csharp
public static void FileDecrypt(string inputFile, string outputFile, string password)
        {
            byte[] passwordBytes = System.Text.Encoding.UTF8.GetBytes(password);
            byte[] salt = new byte[32];

            FileStream fsCrypt = new FileStream(inputFile, FileMode.Open);
            fsCrypt.Read(salt, 0, salt.Length);

            RijndaelManaged AES = new RijndaelManaged();
            AES.KeySize = 256;
            AES.BlockSize = 128;
            var key = new Rfc2898DeriveBytes(passwordBytes, salt, 50000);
            AES.Key = key.GetBytes(AES.KeySize / 8);
            AES.IV = key.GetBytes(AES.BlockSize / 8);
            AES.Padding = PaddingMode.PKCS7;
            AES.Mode = CipherMode.CFB;

            CryptoStream cs = new CryptoStream(fsCrypt, AES.CreateDecryptor(), CryptoStreamMode.Read);

            FileStream fsOut = new FileStream(outputFile, FileMode.Create);

            int read;
            byte[] buffer = new byte[1048576];

            try
            {
                while ((read = cs.Read(buffer, 0, buffer.Length)) > 0)
                {
                    Application.DoEvents();
                    fsOut.Write(buffer, 0, read);
                }
            }
            catch (CryptographicException ex_CryptographicException)
            {
                MessageBox.Show("CryptographicException error: " + ex_CryptographicException.Message, 
                    "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                cs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error by closing CryptoStream: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                fsOut.Close();
                fsCrypt.Close();
            }
        }
```

<br/>

## Encrypting and Decrypting text data
---
Secure Email allows you to encrypt and decrypt text messages directly within the program. In order to encrypt or decrypt a text message, you need to go to the corresponding menu item. In the opening window, you must enter a password (it is possible to generate a complex password) and write the text that you want to encrypt or decrypt.

![Secure Email](https://raw.githubusercontent.com/GAGreatProgrammer/Secure-Email-Application/master/Secure%20Email%20Application/Assets/EncryptText.PNG)

<n/>

To encrypt and decrypt text message, the program uses the Triple DES encryption algorithm.

#### Encrypting text

```csharp
public static string TextEncrypt(string text, string key)
        {
            TripleDESCryptoServiceProvider tripleDESCryptoService = new TripleDESCryptoServiceProvider();
            MD5CryptoServiceProvider hashMD5Provider = new MD5CryptoServiceProvider();

            byte[] byteHash = hashMD5Provider.ComputeHash(Encoding.UTF8.GetBytes(key));
            tripleDESCryptoService.Key = byteHash;
            tripleDESCryptoService.Mode = CipherMode.ECB;
            byte[] data = Encoding.Unicode.GetBytes(text);
            return Convert.ToBase64String(tripleDESCryptoService.CreateEncryptor().TransformFinalBlock(data, 0, data.Length));
        }
```

<n/>

#### Decrypting text

```csharp
public static string TextDecrypt(string text, string key)
        {
            TripleDESCryptoServiceProvider tripleDESCryptoService = new TripleDESCryptoServiceProvider();
            MD5CryptoServiceProvider hashMD5Provider = new MD5CryptoServiceProvider();

            byte[] byteHash = hashMD5Provider.ComputeHash(Encoding.UTF8.GetBytes(key));
            tripleDESCryptoService.Key = byteHash;
            tripleDESCryptoService.Mode = CipherMode.ECB;
            byte[] byteBuff = Convert.FromBase64String(text);
            return Encoding.Unicode.GetString(tripleDESCryptoService.CreateDecryptor().TransformFinalBlock(byteBuff, 0, byteBuff.Length));
        }
```

<br/>

## Additional features
---
Secure Email has many additional features that are presented in the settings tab:
* Authentication method
    * Login with password. (To enter the program, you only need to enter a   username and password)

    * Two-factor authentication. (To enter the program, you must enter a username and password. After that, a 5-digit code will be sent to your email, which must be entered in the authorization form.)

    <br/>

* Encryption settings.
    * Encrypt the settings file. Recommended for greater privacy. In this case, all settings, including personal data, will be encrypted until the next launch of the program.

    * Do not encrypt the settings file. In this case, all settings, including personal data, will be stored in an unencrypted state. In this case, there is a possibility of information leakage.

        <br/>

* Send email on login. This function allows you to find out when the user is authorized in the program. After authorization, a message about entering the program is sent to the user's email. It is recommended to enable this feature.

<br/>

The programs provide additional features that can provide greater application reliability. One such feature is Quick App Lock. If you want to quickly block an app, you can tap the round white button with the lock icon in the bottom left corner of the app. After clicking, the program will be blocked and the authorization form will open. You can also change the purpose of this button and assign it a quick exit from the program. In this case, after pressing the lock button, the program will close.

