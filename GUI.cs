using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using WMK;

namespace WMK
{
    public class GUI
    {
        public static string lastSessionLogPath = Directory.GetCurrentDirectory() + "/data/logs/last_session.log";
        public static string allSessionsLogPath = Directory.GetCurrentDirectory() + "/data/logs/all_sessions.log";
        public static void changeCommentTextBox(TextBox textbox, Comments chosenComment)
        {
            textbox.Text = chosenComment.ToString();
            if (chosenComment == Comments.Inne)
            {
                textbox.Text = chosenComment.ToString() + ": ";
                textbox.Enabled = !textbox.Enabled;
            }
        }
        public static void SaveLastSession(ComboBox comboBoxClient, Stopwatch stopwatch, TextBox textBoxComment)
        {
            Months monthNow = (Months)Convert.ToInt32(DateTime.Now.Month);
            string today = DateTime.Now.Day.ToString("D");
            File.WriteAllText(lastSessionLogPath, $"<{comboBoxClient.Text}|{monthNow}|{today}|{stopwatch.Elapsed.Hours}:{stopwatch.Elapsed.Minutes}:{stopwatch.Elapsed.Seconds}|{textBoxComment.Text}>");
        }
        public static void AddSessionToLog(string client, Session sessionRecord)
        {

        }

        public static void GrantAccess(string filePath)
        {
            DirectoryInfo dInfo = new DirectoryInfo(filePath);
            DirectorySecurity dSecurity = dInfo.GetAccessControl();
            dSecurity.AddAccessRule(new FileSystemAccessRule(new SecurityIdentifier(WellKnownSidType.WorldSid, null), FileSystemRights.FullControl, InheritanceFlags.ObjectInherit | InheritanceFlags.ContainerInherit, PropagationFlags.NoPropagateInherit, AccessControlType.Allow));
            dInfo.SetAccessControl(dSecurity);
        }
    }
}
