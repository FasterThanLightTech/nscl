using System;
using System.Collections.Generic;
using System.Text;
using System.Web.UI;

namespace Org.Xwt.Nscl.Core
{
    [ToolboxData("<{0}:When runat=\"server\"> </{0}:When>")]
    public class Othewise : Control
    {
        protected override void Render(HtmlTextWriter writer)
        {
            if (!Convert.ToBoolean(Page.Items[Choose.When_Evaluated]))
            {
                RenderChildren(writer);
            }
        } 
    }
}
