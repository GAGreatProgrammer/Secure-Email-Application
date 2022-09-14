using JsonFlatFileDataStore;
using System;
using System.IO;
using System.Windows.Forms;

namespace Secure_Email_Application.Class
{
    public static class AddRecord
    {
        public static async void AddLog(string _event)
        {
            try
            {
                if (Properties.Settings.Default.GenerateLogFile == true)
                {
                    //var Logs_Path = @"C:\Program Files\Secure Email";
                    //var Logs_File = @"C:\Program Files\Secure Email\Logs.json";

                    var Logs_Path = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)}\Secure Email";
                    var Logs_File = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)}\Secure Email\Logs.json";


                    if (!Directory.Exists(Logs_Path))
                    {
                        Directory.CreateDirectory(Logs_Path);
                    }

                    if (!File.Exists(Logs_File))
                    {
                        File.AppendAllText(Logs_File, "{}");
                    }


                    var database = new DataStore(Logs_File, reloadBeforeGetCollection: true);
                    var collection = database.GetCollection<Log>();

                    var newPassword = new Log
                    {
                        Username = Properties.Settings.Default.Username,
                        FullName = Properties.Settings.Default.FirstName + " " + Properties.Settings.Default.LastName,
                        Event = _event,
                        CreatedDate = DateTime.Now,
                    };

                    await collection.InsertOneAsync(newPassword);
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
    }
}
