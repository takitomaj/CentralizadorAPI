using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Centralizador.Models
{
    public class JSon_itunes
    {
        public int resultCount { get; set; }
        public List<Result> results { get; set; }
    }
}