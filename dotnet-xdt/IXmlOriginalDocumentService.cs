using System.Xml;

#nullable enable
namespace DotNet.Xdt
{
    interface IXmlOriginalDocumentService
    {
        XmlNodeList? SelectNodes(string path, XmlNamespaceManager nsmgr);
    }
}
