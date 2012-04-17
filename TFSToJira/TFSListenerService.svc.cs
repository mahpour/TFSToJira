using System;
using System.Configuration;
using System.Text.RegularExpressions;
using System.Web.Services;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Diagnostics;
using System.Xml;
using TFSToJira.JiraServices;
using System.Xml.Xsl;
using System.Xml.XPath;
using System.Web.Hosting;
using System.IO;
using log4net;


namespace TFSEventListenerService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "TFSListenerService" in code, svc and config file together.
    [ServiceBehavior(AddressFilterMode = AddressFilterMode.Any)]
    public class TFSListenerService : ITFSListenerService
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(TFSListenerService).Name);

        /// <summary>
        /// Transforms Input XML to text with given XSL 
        /// </summary>
        /// <param name="xml">xml content</param>
        /// <param name="xslt">xsl content</param>
        /// <returns></returns>
        public static String TransformXmlInMemory(String xml, String xslt)
        {
            StringReader sr;
            StringWriter sw;

            // Load the transform
            XslTransform transform = new XslTransform();
            sr = new StringReader(xslt);
            transform.Load(new XPathDocument(sr), null, null);

            // Perform the transform
            sr = new StringReader(xml);
            sw = new StringWriter();

            transform.Transform(new XPathDocument(sr), null, sw, null);
            return sw.ToString();

        }

        /// <summary>
        /// Receives XML notification from TFS event subscription service and sends updated to Jira as a WorkLog
        /// </summary>
        /// <param name="eventXml">Xml content</param>
        /// <param name="tfsIdentityXml">TFS Instance Information</param>
        public void Notify(string eventXml, string tfsIdentityXml)
        {
            XmlDocument xml = new XmlDocument();
            xml.LoadXml(eventXml);
            string comment = xml.SelectSingleNode("//Comment").InnerText;
            string creationDate = xml.SelectSingleNode("//CreationDate").InnerText;
            
            string content = TransformXmlInMemory(eventXml, File.ReadAllText(HostingEnvironment.ApplicationPhysicalPath + "\\commenter.xslt"));

            //Uses the ISSUE_ID_PATTERN to determine related Issues to comment on them.
            string matchingPattern=ConfigurationManager.AppSettings["ISSUE_ID_PATTERN"];
            var matches = System.Text.RegularExpressions.Regex.Matches(comment, matchingPattern );
            if (matches.Count > 0)
            {
                using (JiraSoapServiceService jiraSvc = new JiraSoapServiceService())
                {
                    
                    try
                    {
                        // HttpException Happens if Login Fails. Exception logged. 
                        var token = jiraSvc.login(ConfigurationManager.AppSettings["jiraAccount"], ConfigurationManager.AppSettings["jiraAccountPassword"]);
                        foreach (Match match in matches)
                        {
                            //Ignore non existing Issues
                            try
                            {
                                RemoteIssue issue = jiraSvc.getIssue(token, match.Value);
                                if (issue != null)
                                {
                                    var workLog = new RemoteWorklog()
                                    {
                                        timeSpent = "1m",
                                        startDate = Convert.ToDateTime(creationDate),
                                        comment = content
                                    };
                                    jiraSvc.addWorklogAndRetainRemainingEstimate(token, match.Value, workLog);
                                    //jiraSvc.addComment(token, "EV-1", new RemoteComment() { body = content});
                                }
                                
                            }
                            catch (Exception ex)
                            {
                                log.Debug(String.Format("Issue {0} Not Found.", match.Value),ex);
                            }
                        }
                    }
                    catch(Exception ex)
                    {
                        log.Error("Unhandled Exception",ex);
                    }
                    
                }
            }
            //log.Debug(eventXml);
        }
    }
}
