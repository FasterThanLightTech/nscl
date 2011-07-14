using System;
using System.Collections.Generic;
using System.Text;
using System.Web.UI;

namespace Org.Xwt.Nscl.Core
{
    [ToolboxData("<{0}:Choose runat=\"server\"> </{0}:Choose>")]
    public class Choose : Control
    {
        public static readonly string When_Evaluated = "When_Evaluated";

        /// <summary>
        /// Perform validation
        /// 1. must have at least one when
        /// 2. must have one and only one otherwise
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPreRender(EventArgs e)
        {
            bool hasWhen = false;
            int otherwise = 0;
            foreach(Control control in Controls)
            {
                if(control.GetType().Equals(typeof(When)))
                {
                    hasWhen = true;
                }
                if(control.GetType().Equals(typeof(Othewise)))
                {
                    otherwise++;
                }
            }

            if(!hasWhen)
            {
                throw new Exception("At least one when tag is required.");
            }
            if(otherwise == 0)
            {
                throw new Exception("At least one otherwise tag is required.");
            }
            if (otherwise > 1)
            {
                throw new Exception("Only one otherwise tag is allowed.");
            }
            base.OnPreRender(e);
        }

        protected override void Render(HtmlTextWriter writer)
        {
            Page.Items[When_Evaluated] = false;
            base.Render(writer);
        }

    }
}
