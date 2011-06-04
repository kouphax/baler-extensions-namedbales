using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using CodeSlice.Web.Baler.Extensions.NamedBales;

namespace CodeSlice.Web.Baler.Test
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            Baler.Build("~/src/single.js").NameAs("single");
        }
    }
}