using System;
using System.Collections.Generic;
using System.Text;
using System.Web.UI;

namespace Org.Xwt.Nscl.Core
{
    [ToolboxData("<{0}:When runat=\"server\"> </{0}:When>")]
    public class When : Control
    {
        private string test;

        public string Test 
        {
            set { test = value; }
            get { return test; }
        }

        /// <summary>
        /// Perform validation
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPreRender(EventArgs e)
        {
            if(String.IsNullOrEmpty(test))
            {
                throw new ArgumentNullException("Test is required");
            }
            base.OnPreRender(e);
        }
        

        protected override void Render(HtmlTextWriter writer)
        {
            if(!Convert.ToBoolean(Page.Items[Choose.When_Evaluated]))
            {
                if (ELCache.Instance.GetBooleanValue(Scope.GetInstance(Page), test))
                {
                    Page.Items[Choose.When_Evaluated] = true;
                    RenderChildren(writer);
                }
            }
        }
    }
}
