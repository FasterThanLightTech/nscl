using System.Web.UI;
using System.Web;
using System.Web.SessionState;
using System.Collections;

namespace Org.Xwt.Nscl
{
    public class Scope
    {

        private HttpApplicationState application;
        private HttpSessionState session;
        private HttpRequest request;
        private Page page;
        private IDictionary items;
 
        public Scope(Page page)
        {
            application = page.Application;
            session = page.Session;
            request = page.Request;
            this.page = page;
            items = page.Items;
        }

        public static Scope GetInstance(Page page)
        {
            return new Scope(page);
        }

        public HttpApplicationState Application
        {
            get { return application; }
        }

        public HttpSessionState Session
        {
            get { return session; }
        }

        public HttpRequest Request
        {
            get { return request; }
        }

        public Page Page 
        {
            get { return page; }
        }

        public IDictionary Items
        {
            get { return items; }
        }

    }
}
