using System;
using System.Collections.Generic;
using System.Text;

namespace financial_accounting
{
    public class Operation
    {
        public DateTime Date { get; set;}
        public string Type { get; set; }
        public string Category { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
    }
}
