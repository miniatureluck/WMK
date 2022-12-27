using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace WMK
{
    public class AllClients
    {
        static string clientListPath = Directory.GetCurrentDirectory() + "/clients.dat";
        List<string> allClients = new();

        public void LoadClientList()
        {
            MainWindow.comboBoxClient.Items.Clear();
            string[] alLClientsFromFile = File.ReadAllLines(clientListPath);
            foreach (string line in alLClientsFromFile)
            {
                allClients.Add(line);
                MainWindow.comboBoxClient.Items.Add(line);
            }
        }
        public void AddClientToList(string client)
        {
            if (!allClients.Contains<string>(client))
            {
                File.AppendAllText(clientListPath, client + "\n");
            }
            LoadClientList();
        }

    }
}
