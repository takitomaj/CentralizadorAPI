using Centralizador.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;

namespace Centralizador.Controllers
{
    public class TVMazeController : ApiController
    {
        // GET api/TVMaze/"busqueda"
        /// <summary>
        /// este metodo buscare sultados en el servicio de busqueda de series de tv Maze y devuelve informacion relacionada con la busqueda
        /// </summary>
        /// <param name="serch">el texto con las palabras claves </param>
        /// <returns></returns>
        public List<JSon_TVMaze> Get(string serch)
        {

            string URL = "https://api.tvmaze.com/search/shows?q="+serch;
            var strJson = new WebClient().DownloadString(URL);
            var Output = JsonConvert.DeserializeObject<List<JSon_TVMaze>>(strJson);

            return Output;
        }
    }
}