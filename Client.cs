using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMK
{
    public enum Months { Brak, Styczeń, Luty, Marzec, Kwiecień, Maj, Czerwiec, Lipiec, Sierpień, Wrzesień, Październik, Listopad, Grudzień }
    public enum Comments { Rozmowy, Rozprawy, Korespondencja, Pisma, Analiza, Rekomendacje, Inne }
    public class Client
    {
        public string Name { get; set; }
        public List<Session>? Data { get; set; }
        public KeyValuePair<Months, bool> Completed { get; set; }
    }

    public class Session
    {
        public DateTime Date { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public TimeSpan Time { get; set; }
        public Comments Comment { get; set; }
        public string? CustomComment { get; set; }
        public bool UserEdited { get; set; }
    }
}
