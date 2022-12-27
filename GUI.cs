using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMK;

namespace WMK
{
    internal class GUI
    {
        
        public static void changeCommentTextBox(Comments chosenComment)
        {
            MainWindow.textBoxComment.Text = chosenComment.ToString();
            if (chosenComment == Comments.Inne)
            {
                MainWindow.textBoxComment.Text = chosenComment.ToString() + ": ";
                MainWindow.textBoxComment.Enabled = !MainWindow.textBoxComment.Enabled;
            }
        }
        public static void SaveLastSession(ComboBox comboBoxClient, Stopwatch stopwatch, TextBox textBoxComment)
        {
            Months monthNow = (Months)Convert.ToInt32(DateTime.Now.Month);
            string today = DateTime.Now.Day.ToString("D");
            File.WriteAllText(Directory.GetCurrentDirectory() + "/last_session.log", $"<{comboBoxClient.Text}|{monthNow}|{today}|{stopwatch.Elapsed.Hours}:{stopwatch.Elapsed.Minutes}:{stopwatch.Elapsed.Seconds}|{textBoxComment.Text}>");
        }
    }
}
