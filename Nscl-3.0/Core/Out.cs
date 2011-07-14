using System;
using System.Collections.Generic;
using System.Text;
using System.Web.UI;

namespace Org.Xwt.Nscl.Core
{
    [ToolboxData("<{0}:Out Value=\"\" runat=\"server\"> </{0}:Out>")]
    public class Out : Control
    {

        private string outVar;

        public string Value
        {
            set { outVar = value; }
        }

        protected override void OnPreRender(EventArgs e)
        {
            if(String.IsNullOrEmpty(outVar))
            {
                throw new ArgumentNullException("Value is required.");
            }
            if (HasControls())
            {
                throw new Exception("Out tag can not have any children");
            }
            base.OnPreRender(e);
        }

        protected override void Render(HtmlTextWriter writer)
        {

            writer.Write(ELCache.Instance.GetValue(new Scope(Page), outVar));
        }

    }
}
