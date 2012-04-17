using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Web.Services.Protocols;
using System.Web.Services;

namespace TFSEventListenerService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ITFSListenerService" in both code and config file together.
    [ServiceContract(Namespace = "http://schemas.microsoft.com/TeamFoundation/2005/06/Services/Notification/03")]
    
    public interface ITFSListenerService
    {
        [OperationContract(Action = "http://schemas.microsoft.com/TeamFoundation/2005/06/Services/Notification/03/Notify")]
        [XmlSerializerFormat(Style = OperationFormatStyle.Document)]
        void Notify(string eventXml, string tfsIdentityXml);
    }
}
