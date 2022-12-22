using System;
using System.Collections.Generic;
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
    }
}
