using MySqlConnector;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineChallange3
{
    public class Anuncio
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Ano { get; set; }
        public string Versao { get; set; }
        public string Quilometragem { get; set; }
        public string Observacao { get; set; }

        
    }
}
