using System;
using System.Collections.Generic;
using System.Text;

namespace ReposicaoDeAulas
{
    class Tela
    {
        public static void BemVindo()
        {
            Console.Clear();
            Console.WriteLine("Bem vindo ao nosso sistema, o que gostaria?\n1)Cadastro Médico\n2)Cadastro Paciente\n3) Cadastrar Consulta");
        }
        public static void MontaTelaMedico()
        {
            Medico medico = new Medico();

            Console.WriteLine("Digite seu código:");
            medico.CodigoPessoa = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite seu nome:");
            medico.Nome = Console.ReadLine();

            Console.WriteLine("Digite seu CPF:");
            medico.Cpf = Console.ReadLine();

            Console.WriteLine("Digite sua data de nascimento:");
            medico.DataNascimento = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Digite seu CRM:");
            medico.Crm = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite sua especialidade:");
            medico.Especialidade = Console.ReadLine();

            Console.WriteLine($"Cadastro médico:\nCódigo:{medico.CodigoPessoa}\nNome:{medico.Nome}\nCpf:{medico.Cpf}\n" +
                $"Data de nascimento:{medico.DataNascimento}\n Crm:{medico.Crm}\n Especialidade:{medico.Especialidade}");
        }

        public static void MontaTelaPaciente()
        {

            Paciente paciente = new Paciente();
            Console.WriteLine("Digite seu código:");
            paciente.CodigoPessoa = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Digite seu nome:");
            paciente.Nome = Console.ReadLine();


            Console.WriteLine("Digite seu CPF:");
            paciente.Cpf = Console.ReadLine();

            Console.WriteLine("Digite sua data de nascimento:");
            paciente.DataNascimento = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Digite o nome do seu conênio:");
            paciente.Convenio = Console.ReadLine();

            Console.WriteLine("Digite a Validade:");
            paciente.Validade = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Digite a data da primeira consulta:");
            paciente.DataPrimeiraConsulta = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine($"Código:{paciente.CodigoPessoa}\nNome:{paciente.Nome}\nCpf:{paciente.Cpf}\nData de nascimento:{paciente.DataNascimento}\n" +
                $"Convênio:{paciente.Convenio}\nValidade:{paciente.Validade}\n Data da primeira consulta:{paciente.DataPrimeiraConsulta}");
          
        }
        public static void MontaTelaConsulta()
        {
            Consulta consulta = new Consulta();

            Console.WriteLine("Digite o código da consulta:");
            consulta.CodigoConsulta = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a data da consulta:");
            consulta.DataDaConsulta = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Digite a data do cadastro:");
            consulta.DataDoCadastro = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Digite o código do paciente:");
            consulta.CodigoDoPaciente = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o código do médico:");
            consulta.CodigoDoMedico = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o motivo da consulta:");
            string MotivoConsulta = Console.ReadLine();

            Console.WriteLine("Diagnostico:");
            string Diagnostico = Console.ReadLine();

           
            Console.WriteLine($"Código da consulta:{consulta.CodigoConsulta}\n Data da consulta:{consulta.DataDaConsulta}\n" +
                $"Data do cadastro:{consulta.DataDoCadastro}\nCódigo do paciente:{consulta.CodigoDoPaciente}\n" +
                $"Código do paciente:{consulta.CodigoDoPaciente}");
            consulta.Atender(MotivoConsulta, Diagnostico);

        }
       
    }
}