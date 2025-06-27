using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GeradorDeFrase
{
   public class Frase
    {
        
        [JsonProperty("frase")]
        public string Frase_ { get; set; }

        [JsonProperty("autor")]
        public string Autor { get; set; }
    }

}

