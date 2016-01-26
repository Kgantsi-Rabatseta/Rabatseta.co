using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Web.WebPages.OAuth;

namespace Rabatseta.co.App_Start
{
    public class AuthConfig
    {
        //This class defines all authentications that are possible
        public static void RegisterAuthentication()
        {
            OAuthWebSecurity.RegisterGoogleClient();
        }
    }
}