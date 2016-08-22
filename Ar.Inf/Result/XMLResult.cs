using System.Web.Mvc;
using System.Xml.Serialization;

namespace Ar.Inf.Result
{
    public class XMLResult : ActionResult
    {
        private object _data;
        
        public XMLResult(object data)
        {
            _data = data;
        }

        public override void ExecuteResult(ControllerContext context)
        {
            XmlSerializer serializer = new XmlSerializer(_data.GetType());
            var response = context.HttpContext.Response;
            response.ContentType = "text/xml";
            serializer.Serialize(response.Output, _data);
        }
    }
}