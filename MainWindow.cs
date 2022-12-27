using Microsoft.VisualBasic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;

namespace WMK
{
    public partial class MainWindow : Form
    {
        TimeSpan timeThisSession = TimeSpan.FromSeconds(0);
        Stopwatch stopwatch = new();
        AllClients allClients = new();
        public MainWindow()
        {
            InitializeComponent();
            allClients.LoadClientList();
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
                KeyValuePair<Client, ClientInfo> clientData = new KeyValuePair<Client, ClientInfo>(client, new());
                allClients.AddClientToList(clientName);
                allClients.LoadClientList();
                comboBoxClient.SelectedIndex = comboBoxClient.FindString(clientName);
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

        private void button1_Click(object sender, EventArgs e)
        {
            ClientInfo info1 = new ClientInfo { Date = DateTime.Now, Time = TimeSpan.MinValue + TimeSpan.FromSeconds(190), Comment = Comments.Rozmowy };
            List<ClientInfo> infolist1 = new List<ClientInfo> {};
            infolist1.Add(info1);

            Months miesiac = Months.Wrzesieñ;
            Client client1 = new Client(){ Name = comboBoxClient.Text, UserEdited = false, Completed = new KeyValuePair<Months, bool>(miesiac, false) , Data = infolist1};
            File.WriteAllText(Directory.GetCurrentDirectory() + "/data.json", JsonSerializer.Serialize(client1));
        }
    }
}