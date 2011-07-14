using System;
using System.Collections;
using System.Text;
using System.Web.UI;

namespace Org.Xwt.Nscl.Core
{
    [ToolboxData("<{0}:ForEach Items=\"\" runat=\"server\"> </{0}:ForEach>")]
    public class ForEach : Control
    {

        private string items;
        private string var = "item";

        public string Items
        {
            set { items = value; }
            get { return items; }
        }

        public string Var
        {
            set { var = value; }
            get { return var; }
        }


        /// <summary>
        /// Perform validation
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPreRender(EventArgs e)
        {
            if(String.IsNullOrEmpty(items))
            {
                throw new ArgumentNullException("Items is required");
            }
            if (String.IsNullOrEmpty(var))
            {
                throw new ArgumentNullException("Var is required");
            }
            base.OnPreRender(e);
        }

        protected override void Render(HtmlTextWriter writer)
        {
            ICollection items = ELCache.Instance.GetCollection(Scope.GetInstance(Page), this.items);            
            foreach(object obj in items)
            {
                Page.Items[var] = obj;
                RenderChildren(writer);
            }
        }

    }
}
