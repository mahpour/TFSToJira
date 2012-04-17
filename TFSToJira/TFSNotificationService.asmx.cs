using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Diagnostics;

namespace Vastardis.TFSEventListenerService
{
    /// <summary>
    /// Summary description for TFSNotificationService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class TFSNotificationService : System.Web.Services.WebService
    {

        
        [SoapDocumentMethod(Action="http://schemas.microsoft.com/TeamFoundation/2005/06/Services/Notification/03/Notify", RequestNamespace = " http://schemas.microsoft.com/TeamFoundation/2005/06/Services/Notification/03")]
        [WebMethod(MessageName="Notify")]
        public void Notify(string eventXml)
        {
            Debug.WriteLine(eventXml);
        }
    }
}
