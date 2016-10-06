using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Web;

namespace WebAPI.Util
{
    public class MessagesHandler
    {
        public static string GetMessage(string key)
        {
            ResourceManager rm = new ResourceManager("WebApi.Util.MessagesAPI", Assembly.GetExecutingAssembly());
            return rm.GetString(key);
        }
    }
}