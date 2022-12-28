using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace WMK
{
    public class AllClients
    {
        static string clientsListPath = Directory.GetCurrentDirectory() + "/data/clients/";
        List<string> allClients = new();

        public void LoadClientList(ComboBox combobox)
        {
            combobox.Items.Clear();
            string[] allClientsList = Directory.EnumerateDirectories(clientsListPath).Select(d => new DirectoryInfo(d).Name).ToArray();
            foreach (string item in allClientsList)
            {
                allClients.Add(item.Replace(clientsListPath, string.Empty));
                combobox.Items.Add(item);
            }
        }
        public void AddClient(string client)
        {
            Directory.CreateDirectory(clientsListPath + client);
            GUI.GrantAccess(clientsListPath + client);
            File.WriteAllText($"{clientsListPath}/{client}/data.json", "");
        }

    }
}
