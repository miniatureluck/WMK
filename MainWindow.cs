using Microsoft.VisualBasic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.Json;

namespace WMK
{
    public partial class MainWindow : Form
    {
        TimeSpan timeThisSession = TimeSpan.FromSeconds(0);
        Stopwatch stopwatch = new();
        AllClients allClients = new();
        int windowHeight = 337;
        int tabHeight = 257;
        public MainWindow()
        {
            InitializeComponent();
            Height = 144;
            tabControl1.Height = 134;
            allClients.LoadClientList(comboBoxClient);
            if (comboBoxClient.Items.Count != 0)
            {
                comboBoxClient.SelectedIndex = 0;
            }
            ControlsVisibility();
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
            stopwatch.Start();
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            buttonPlay.Enabled = true;
            buttonPause.Enabled = false;
            timerTime.Enabled = false;
            stopwatch.Stop();
        }

        private void buttonAddClient_Click(object sender, EventArgs e)
        {
            string clientName = Interaction.InputBox("Podaj nazwê klienta");
            if (clientName != null)
            {
                Client client = new();
                client.Name = clientName;
                KeyValuePair<Client, Session> clientData = new KeyValuePair<Client, Session>(client, new());
                allClients.AddClient(clientName);
                allClients.LoadClientList(comboBoxClient);
                comboBoxClient.SelectedIndex = comboBoxClient.FindString(clientName);
                ControlsVisibility();
            }
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            timeThisSession += TimeSpan.FromSeconds(1);
            labelTime.Text = timeThisSession.ToString();
            GUI.SaveLastSession(comboBoxClient, stopwatch, textBoxComment);
        }

        private void radioButtonOther_CheckedChanged(object sender, EventArgs e)
        {
            GUI.changeCommentTextBox(textBoxComment, Comments.Inne);
        }

        private void radioButtonCall_CheckedChanged(object sender, EventArgs e)
        {
            GUI.changeCommentTextBox(textBoxComment, Comments.Rozmowy);
        }

        private void radioButtonCourt_CheckedChanged(object sender, EventArgs e)
        {
            GUI.changeCommentTextBox(textBoxComment, Comments.Rozprawy);
        }

        private void radioButtonEmail_CheckedChanged(object sender, EventArgs e)
        {
            GUI.changeCommentTextBox(textBoxComment, Comments.Korespondencja);
        }

        private void radioButtonDocument_CheckedChanged(object sender, EventArgs e)
        {
            GUI.changeCommentTextBox(textBoxComment, Comments.Pisma);
        }

        private void radioButtonAnalysis_CheckedChanged(object sender, EventArgs e)
        {
            GUI.changeCommentTextBox(textBoxComment, Comments.Analiza);
        }

        private void radioButtonRecommendation_CheckedChanged(object sender, EventArgs e)
        {
            GUI.changeCommentTextBox(textBoxComment, Comments.Rekomendacje);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void ControlsVisibility()
        {
            if (comboBoxClient.Items.Count != 0)
            {
                radioButtonAnalysis.Visible = !radioButtonAnalysis.Visible;
                radioButtonCall.Visible = !radioButtonCall.Visible;
                radioButtonCourt.Visible = !radioButtonCourt.Visible;
                radioButtonDocument.Visible = !radioButtonDocument.Visible;
                radioButtonEmail.Visible = !radioButtonEmail.Visible;
                radioButtonOther.Visible = !radioButtonOther.Visible;
                radioButtonRecommendation.Visible = !radioButtonRecommendation.Visible;
                textBoxComment.Visible = !textBoxComment.Visible;
                buttonPause.Visible = !buttonPause.Visible;
                buttonPlay.Visible = !buttonPlay.Visible;
                buttonSave.Visible = !buttonSave.Visible;
                Height = windowHeight;
                tabControl1.Height = tabHeight;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

        }
    }
}