using System;
using System.Collections.Generic;
using System.Web.UI;

namespace Nscl_3._0.TestWebSite
{
    public partial class _Default : Page
    {
        public void Page_Load(object sender, System.EventArgs e)
        {
            Response.Redirect("~/Home");
        }
    }
}
