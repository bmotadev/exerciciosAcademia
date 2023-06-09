﻿using System.Diagnostics;
using System.Runtime.Intrinsics.X86;

namespace ExercicioPooUpaSaude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Uma Unidade de Saúde, ao receber pessoas para consultas, realiza cadastro do paciente(nome, cpf, dataNascimento, email).Feito isso, o paciente cadastrado participa de um processo de triagem(valida dados do paciente,
            //peso, altura, pressão arterial e temperatura). Em cima desses dados o técnico ou enfermeiro colocam a urgência
            //de atendimento(verde, amarelo, vermelho).Feito isso, o paciente é chamado a consulta, em que são guardados:
            //-paciente
            //- triagem
            //- nome e crm do médico
            //- prescrição gerada
            //UnidadeSaude
            //Paciente
            //Triagem
            //Consulta
            //ProfissionalSaude

            UnidadeSaude unidade = new UnidadeSaude("Teste", "TEST");

            unidade.Responsavel.Nome = "";
            unidade.Responsavel.Tipo = "";
            unidade.Responsavel.RegistroConselho = "";

            Paciente paciente = new Paciente("Bruno Mota", "32312321", DateOnly.Parse("21/10/1991"), "email@email.com");

            ProfissionalSaude profissional = new ProfissionalSaude("Bruno", "Teste", "teste");

            Triagem triagem = new Triagem(profissional, paciente, 78, 1.81, 118, 38, "verde");
        }
    }
}