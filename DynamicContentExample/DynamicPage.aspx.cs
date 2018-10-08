using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using AjaxControlToolkit;

namespace DynamicContentExample
{
    public partial class DynamicPage : System.Web.UI.Page
    {
        WhatShouldBeShown whatShouldBeShown = new WhatShouldBeShown();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void ShowIt_Click(object sender, EventArgs e)
        {
            Response.Write(whatShouldBeShown.TypeOfStuff);
            var tb = new Table();
            foreach (BankTransferItem s in whatShouldBeShown.ListOfStuff)
            {
                var tr = new TableRow();
                var tc1 = new TableCell();
                var tc2 = new TableCell();
                var lb = new Label()
                {
                    Text = s.Label
                };
                tc1.Controls.Add(lb);
                var txtBx = new TextBox()
                {
                    ID=s.ID,
                    MaxLength=s.Length
                };
                tc2.Controls.Add(txtBx);
                if (s.Mask != "")
                {
                    var mex = new MaskedEditExtender()
                    {
                        ID = s.ID + "_MASK",
                        Mask = s.Mask,
                        MaskType = MaskedEditType.None,
                        TargetControlID = s.ID
                    };
                    tc2.Controls.Add(mex);
                }
                tr.Cells.Add(tc1);
                tr.Cells.Add(tc2);
                tb.Rows.Add(tr);
            }
            PlaceHolder1.Controls.Add(tb);
        }
    }
}