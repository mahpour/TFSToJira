To Subscribe this web service to TFS Notification services:

C:\Program Files\Microsoft Team Foundation Server 2010\Tools>BisSubscribe.exe /eventType CheckinEvent /address http://localhost:53862/TFSListenerService.svc /deliveryType Soap /collection http://localhost:8080/tfs/DefaultCollection

To Unsubscribe:

C:\Program Files\Microsoft Team Foundation Server 2010\Tools>BisSubscribe.exe /unsubscribe /id 3 /collection http://localhost:8080/tfs/DefaultCollection

Where 3 is the current subscription ID for service

For TFS Task Debugging: http://blogs.msdn.com/b/granth/archive/2009/10/28/tfs2010-diagnosing-email-and-soap-subscription-failures.aspx



References: http://www.ewaldhofman.nl/post/2010/08/02/How-to-use-WCF-to-subscribe-to-the-TFS-2010-Event-Service-rolling-up-hours.aspx