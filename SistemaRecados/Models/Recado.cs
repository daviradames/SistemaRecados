using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaRecados.Models
{
    public class Recado
    {
        public long RecadoID { get; set; }
        public string Mensagem { get; set; }
        public DateTime DataHora { get; set; }
        public string Autor { get; set; }
        public string Destinatario { get; set; }
    }
}