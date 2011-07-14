using System.Web.Mvc;
using System.Web.UI;
using System.Web.SessionState;
using System.Web;
using System.Collections;

namespace Org.Xwt.Nscl
{
    public class Scope
    {
        public HttpApplicationState Application { private set; get; }
        public HttpSessionState Session { private set; get; }
        public HttpRequest Request { private set; get; }
        public ViewPage Page { private set; get; }
        public ViewDataDictionary ViewData { private set; get; }
        public IDictionary Items { private set; get; }

        private Scope(Page page)
        {
            Application = page.Application;
            Session = page.Session;
            Request = page.Request;
            this.Page = page as ViewPage;
            ViewData = this.Page.ViewData;
            Items = this.Page.Items;
        }

        public static Scope GetInstance(Page page)
        {
            return new Scope(page);
        }

    }
}
