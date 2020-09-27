using System;
using System.Collections.Generic;
using System.Text;

namespace ReposicaoDeAulas
{
    public class Paciente : Pessoa
    {
        public string Convenio { get; set; }
        public DateTime Validade { get; set; }
        public DateTime DataPrimeiraConsulta { get; set; }
    }
}
