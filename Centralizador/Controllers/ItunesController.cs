using Centralizador.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

using System.Web.Http;

namespace Centralizador.Controllers
{
    public class ItunesController  : ApiController
    {
        // GET api/Itunes/"busqueda"
        /// <summary>
        /// este metodo buscaresultados en el servicio de busqueda de Itunes y devuelve informacion relacionada con esto
        /// </summary>
        /// <param name="serch">el texto con las palabras claves que deseas buscar</param>
        /// <returns></returns>
        public JSon_itunes Get(string serch)
        {

            string URL = "https://itunes.apple.com/search?term="+serch;
            var strJson = new WebClient().DownloadString(URL);
            var Output= JsonConvert.DeserializeObject<JSon_itunes>(strJson);

            return Output;
        }
    }
}