using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMK
{
    public enum Months { Styczeń, Luty, Marzec, Kwiecień, Maj, Czerwiec, Lipiec, Sierpień, Wrzesień, Październik, Listopad, Grudzień }
    public class Client
    {
        public string Name { get; set; }
        public List<ClientInfo>? Data { get; set; }
        public KeyValuePair<Months, bool> Completed { get; set; }
    }

    public class ClientInfo
    {
        public DateOnly Date { get; set; }
        public TimeSpan Time { get; set; }
        public string? Comment { get; set; }
    }
}
