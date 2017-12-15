using System;
using System.IO;
using System.Xml;

namespace WebdriverAndLogging
{
    public class Xmll
    {
        public static string[] PickBrowserAndURLFromXmlFile()
        {
            try
            {
                string[] xmldata = new string[2];
                XmlDocument xmldoc = new XmlDocument();
                XmlNodeList xmlnode;
                int i = 0;
                FileStream fs = new FileStream("C:\\Testing\\Config.xml", FileMode.Open, FileAccess.Read); //C:\Jakhar\ProSeed Test Framework\ProSeed Test\ProSeed Test\FrameWork\Config.xml
                xmldoc.Load(fs);
                xmlnode = xmldoc.GetElementsByTagName("name");
                for (i = 0; i <= xmlnode.Count - 1; i++)
                {
                    if (xmlnode[i].ChildNodes.Item(2).InnerText.Trim() == "1")
                    {
                        xmldata[0] = xmlnode[i].ChildNodes.Item(0).InnerText.Trim();
                        xmldata[1] = xmlnode[i].ChildNodes.Item(1).InnerText.Trim();
                        break;
                    }
                }
                return xmldata;
            }
            catch (Exception)
            {
                return null;
            }
        }        
    }
}
