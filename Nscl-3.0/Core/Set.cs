using System;
using System.Collections.Generic;
using System.Text;
using System.Web.UI;

namespace Org.Xwt.Nscl.Core
{
    [ToolboxData("<{0}:Set Var=\"\" Value=\"\" runat=\"server\"> </{0}:Set>")]
    public class Set : Control
    {
        private string var;
        private string val;

        public string Var
        {
            set { var = value; }
            get { return var; }
        }

        public string Value
        {
            set { val = value; }
            get { return val; }
        }

        /// <summary>
        /// Perform validation
        /// 1. should have no children
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPreRender(EventArgs e)
        {
            if(String.IsNullOrEmpty(var))
            {
                throw new ArgumentNullException("Var is required");
            }
            if (String.IsNullOrEmpty(val))
            {
                throw new ArgumentNullException("Value is required");
            }
            if(HasControls())
            {
                throw new Exception("Set tag can not have any children");
            }
            base.OnPreRender(e);
        }


        protected override void Render(HtmlTextWriter writer)
        {
            ELCache.Instance.SetValue(new Scope(Page), var, val);
        }

    }
}
