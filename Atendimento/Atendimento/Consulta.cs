using System;
using System.Collections.Generic;
using System.Text;

namespace ReposicaoDeAulas
{
    public class Consulta
    {
        public int CodigoConsulta { get; set; }
        public DateTime DataDaConsulta { get; set; }
        public DateTime DataDoCadastro { get; set; }
        public int CodigoDoPaciente { get; set; }
        public int CodigoDoMedico { get; set; }

        private string MotivoConsulta;
        private string Diagnostico;

        public void Atender(string motivoConsulta, string diagnostico)
        {
            this.MotivoConsulta = motivoConsulta;
            this.Diagnostico = diagnostico;
            Console.Write("Motivo da consulta:");
            Console.WriteLine(MotivoConsulta);

            Console.Write("Diagnostico:");
            Console.WriteLine(Diagnostico);
        }
    }
}
