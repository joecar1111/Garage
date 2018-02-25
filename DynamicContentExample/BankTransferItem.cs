using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DynamicContentExample
{
    public class BankTransferItem
    {
        public BankTransferItem(string BankTransferItemID)
        {
            ID = BankTransferItemID;
        }
        public string ID { get; set; }
        public int Order { get; set; }
        public string Label { get; set; }
        public string HelpMessage { get; set; }
        public int Length { get; set; }
        public string RegExpValidator { get; set; }
        public string Mask { get; set; }
    }
}