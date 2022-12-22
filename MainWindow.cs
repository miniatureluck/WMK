using Microsoft.VisualBasic;

namespace WMK
{
    public partial class MainWindow : Form
    {
        TimeSpan timeThisSession = TimeSpan.FromSeconds(0);
        public MainWindow()
        {
            
            if (!File.Exists(""))
            {
                File.Create(Directory.GetCurrentDirectory() + "/data.json");
            }
            InitializeComponent();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("asd");
        }

        public void buttonPlay_Click(object sender, EventArgs e)
        {
            buttonPlay.Enabled = false;
            buttonPause.Enabled = true;
            timerTime.Enabled = true;
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            buttonPlay.Enabled = true;
            buttonPause.Enabled = false;
            timerTime.Enabled = false;
        }

        private void buttonAddClient_Click(object sender, EventArgs e)
        {
            string clientName = Interaction.InputBox("Podaj nazwê klienta");
            if (clientName != null)
            {
                Client client = new();
                client.Name = clientName;
                KeyValuePair<Client, ClientInfo> clientData = new KeyValuePair<Client, ClientInfo>(client, new());
                comboBoxClient.Items.Add(client.Name);
                comboBoxClient.Refresh();
                comboBoxClient.SelectedIndex = comboBoxClient.FindString(clientName);
            }
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            timeThisSession += TimeSpan.FromSeconds(1);
            labelTime.Text = timeThisSession.ToString();
        }

        private void radioButtonOther_CheckedChanged(object sender, EventArgs e)
        {
            GUI.changeCommentTextBox(Comments.Inne);
        }

        private void radioButtonCall_CheckedChanged(object sender, EventArgs e)
        {
            GUI.changeCommentTextBox(Comments.Rozmowy);
        }

        private void radioButtonCourt_CheckedChanged(object sender, EventArgs e)
        {
            GUI.changeCommentTextBox(Comments.Rozprawy);
        }

        private void radioButtonEmail_CheckedChanged(object sender, EventArgs e)
        {
            GUI.changeCommentTextBox(Comments.Korespondencja);
        }

        private void radioButtonDocument_CheckedChanged(object sender, EventArgs e)
        {
            GUI.changeCommentTextBox(Comments.Pisma);
        }

        private void radioButtonAnalysis_CheckedChanged(object sender, EventArgs e)
        {
            GUI.changeCommentTextBox(Comments.Analiza);
        }

        private void radioButtonRecommendation_CheckedChanged(object sender, EventArgs e)
        {
            GUI.changeCommentTextBox(Comments.Rekomendacje);
        }
    }
}