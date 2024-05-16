using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBuscaCep.Models
{
    internal class Cep
    {
        public int CEP { get; set; }

        public int id_logradouro { get; set; }

        public string tipo { get; set; }

        public string descricao { get; set; }

        public int id_cidade { get; set; }

        public string UF { get; set; }

        public string complemento { get; set; }

        public string descricao_sem_numero { get; set; }

        public string descricao_cidade { get; set; }

        public int codigo_cidade_ibge { get; set; }

        public string descricao_bairro { get; set; }

    }
}
