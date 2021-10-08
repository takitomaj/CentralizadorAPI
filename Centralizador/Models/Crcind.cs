using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace Centralizador.Models
{

    public class Crcind
    {
		public static string ExesoSUperior = "<?xml version=\"1.0\" encoding=\"UTF-8\" ?>\r\n<SOAP-ENV:Envelope xmlns:SOAP-ENV='http://schemas.xmlsoap.org/soap/envelope/' xmlns:xsi='http://www.w3.org/2001/XMLSchema-instance' xmlns:s='http://www.w3.org/2001/XMLSchema'>\r\n  <SOAP-ENV:Body><FindPersonResponse xmlns=\"http://tempuri.org\">";
		public static string ExesoInferior = "</FindPersonResponse></SOAP-ENV:Body>\r\n</SOAP-ENV:Envelope>\r\n";

		/// <summary>
		/// metodo de dcepuracion de XML para poder analizarlos in encabezados ni pies de pagina este metodo devuelve un String que contiene el XML para ser evaluado desde el tag FindPersonResult
		/// </summary>
		/// <param name="XMlIn">parametro de tipo String que continr el Xml Crudo</param>
		/// <returns></returns>
		public static string ResumXML(string XMlIn) 
		{ 
			string salida="";
			XMlIn = XMlIn.Replace(Crcind.ExesoSUperior, "");
			XMlIn = XMlIn.Replace(Crcind.ExesoInferior, "");

			return XMlIn;

		}
	}
	[XmlRoot(ElementName = "Home")]
	public class Home
	{

		[XmlElement(ElementName = "Street")]
		public string Street { get; set; }

		[XmlElement(ElementName = "City")]
		public string City { get; set; }

		[XmlElement(ElementName = "State")]
		public string State { get; set; }

		[XmlElement(ElementName = "Zip")]
		public int Zip { get; set; }
	}

	[XmlRoot(ElementName = "Office")]
	public class Office
	{

		[XmlElement(ElementName = "Street")]
		public string Street { get; set; }

		[XmlElement(ElementName = "City")]
		public string City { get; set; }

		[XmlElement(ElementName = "State")]
		public string State { get; set; }

		[XmlElement(ElementName = "Zip")]
		public int Zip { get; set; }
	}

	[XmlRoot(ElementName = "FavoriteColors")]
	public class FavoriteColors
	{

		[XmlElement(ElementName = "FavoriteColorsItem")]
		public string FavoriteColorsItem { get; set; }
	}

	[XmlRoot(ElementName = "FindPersonResult")]
	public class FindPersonResult
	{

		[XmlElement(ElementName = "Name")]
		public string Name { get; set; }

		[XmlElement(ElementName = "SSN")]
		public string SSN { get; set; }

		[XmlElement(ElementName = "DOB")]
		public DateTime DOB { get; set; }

		[XmlElement(ElementName = "Home")]
		public Home Home { get; set; }

		[XmlElement(ElementName = "Office")]
		public Office Office { get; set; }

		[XmlElement(ElementName = "FavoriteColors")]
		public FavoriteColors FavoriteColors { get; set; }

		[XmlElement(ElementName = "Age")]
		public int Age { get; set; }
	}

	[XmlRoot(ElementName = "FindPersonResponse")]
	public class FindPersonResponse
	{

		[XmlElement(ElementName = "FindPersonResult")]
		public FindPersonResult FindPersonResult { get; set; }

		[XmlAttribute(AttributeName = "xmlns")]
		public string Xmlns { get; set; }

		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName = "Body")]
	public class Body
	{

		[XmlElement(ElementName = "FindPersonResponse")]
		public FindPersonResponse FindPersonResponse { get; set; }
	}

	[XmlRoot(ElementName = "Envelope")]
	public class Envelope
	{

		[XmlElement(ElementName = "Body")]
		public Body Body { get; set; }

		[XmlAttribute(AttributeName = "SOAP-ENV")]
		public string SOAPENV { get; set; }

		[XmlAttribute(AttributeName = "xsi")]
		public string Xsi { get; set; }

		[XmlAttribute(AttributeName = "s")]
		public string S { get; set; }

		[XmlText]
		public string Text { get; set; }
	}





}