using System;
using System.Collections.Generic;
using System.Text;
using System.Web.UI;

namespace Org.Xwt.Nscl.Core
{
    [ToolboxData("<{0}:If Test=\"\" runat=\"server\"> </{0}:If>")]
    public class If : Control
    {

        private string test;
        
        public string Test
        {
            set { test = value; }
            get { return test; }
        }

        /// <summary>
        /// Performs validation
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPreRender(EventArgs e)
        {
            if(String.IsNullOrEmpty(test))
            {
                throw new ArgumentNullException("Test parameter is required");
            }
            base.OnPreRender(e);
        }

        protected override void Render(HtmlTextWriter writer)
        {
            if (ELCache.Instance.GetBooleanValue(Scope.GetInstance(Page), test))
            {
                RenderChildren(writer);
            }
        }
    }
}
