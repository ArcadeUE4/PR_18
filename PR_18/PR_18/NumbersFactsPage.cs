using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace PR_18
{
    public class NumbersFactsPage
    {
        public string Text { get; set; }
        public bool Found { get; set; }
        public int Number { get; set; }
        public string Type { get; set; }
        public DateTime Date { get; set; }
    }
}
