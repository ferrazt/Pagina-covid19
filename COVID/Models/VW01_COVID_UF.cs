using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COVID.Models
{
    public class VW01_COVID_UF
    {
        public string CIDADE { get; set; }

        public int? IBGE_CODE { get; set; }

        public DateTime? DATA { get; set; }

        public int? POPULACAO_ESTIMADA { get; set; }

        public string ULTIMA_CASO_CONFIRMADO { get; set; }

        public double? ULTIMO_CASO_MORTE { get; set; }

        public string TIPO_LUGAR { get; set; }

        public string ESTADO { get; set; }

        public string NOVA_CONFIRMACAO { get; set; }

        public string NOVA_MORTE { get; set; }
    }
}
