using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DynamicContentExample
{
    public class WhatShouldBeShown
    {
        public WhatShouldBeShown()
        {
            BankTransferItem bti;
            NumberOfThingsToShow = 10;
            TypeOfStuff = "CarInfo";
            ListOfStuff = new List<BankTransferItem>();
            //create a few.  This would normally come from a database.

            bti = new BankTransferItem("SWIFTCODE")
            {
                Label = "Swift Code",
                RegExpValidator = "^[A-Z]{6}[A-Z0-9]{2}([A-Z0-9]{3})?$",
                Order = 1,
                Mask = ">???? >?? >AA >AAA",
                Length = 12
            };
            ListOfStuff.Add(bti);

            bti = new BankTransferItem("RoutingNumber")
            {
                Label = "Routing Number",
                RegExpValidator = "^((0[0-9])|(1[0-2])|(2[1-9])|(3[0-2])|(6[1-9])|(7[0-2])|80)([0-9]{7})$ ",
                Order = 1,
                Mask = "",
                Length = 8
            };
            ListOfStuff.Add(bti);

            bti = new BankTransferItem("AccountNumber")
            {
                Label = "Bank Account Number",
                RegExpValidator = "",
                Order = 1,
                Mask = "",
                Length = 10
            };
            ListOfStuff.Add(bti);
        }
        public int NumberOfThingsToShow { get; set; }
        public string TypeOfStuff { get; set; }
        public List<BankTransferItem> ListOfStuff { get; set; }
    }
}