
using Centralizador.Models;
using System;
using System.IO;
using System.Net;
using System.Web.Http;

using System.Xml.Serialization;

namespace Centralizador.Controllers
{
    public class crcidnController : ApiController
    {
        private object yourXml;

        // GET api/crcidn/"id"
        /// <summary>
        /// este metodo retorna la informacion personal de una persona medianto su ID numerico
        /// </summary>
        /// <param name="id">numero entero que representa el Identificador de la persona </param>
        /// <returns></returns>
        public FindPersonResult Get(int id)
        {

            string URL = "http://www.crcind.com/csp/samples/SOAP.Demo.cls?soap_method=FindPerson&id="+id ;
            string strXML = new WebClient().DownloadString(URL).ToString();
           

            strXML = Crcind.ResumXML(strXML);

            XmlSerializer serializer = new XmlSerializer(typeof(FindPersonResult));
            StringReader rdr = new StringReader(strXML);
            FindPersonResult resultingMessage = (FindPersonResult)serializer.Deserialize(rdr);

            //XmlSerializer serializer = new XmlSerializer(typeof(Envelope));
            //using (StringReader reader = new StringReader(strXML))
            //{
            //   var test = (Envelope)serializer.Deserialize(reader);
            //}



            return resultingMessage;
        }
    }
}