using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary1;

namespace DynamicContentExample
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var x = new Stuff
            {
                ID = 1
            };
        }

        protected void ShowDynamicContent_Click(object sender, EventArgs e)
        {
            Response.Redirect("DynamicPage");
        }
    }
}