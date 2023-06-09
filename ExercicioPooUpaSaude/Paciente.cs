﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPooUpaSaude
{
    internal class Paciente
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateOnly DataNascimento { get; set; }
        public string Email { get; set; }

        public Paciente()
        {
        }

        public Paciente(string nome, string cpf, DateOnly dataNascimento, string email)
        {
            Nome = nome;
            Cpf = cpf;
            DataNascimento = dataNascimento;
            Email = email;
        }

        public Paciente(string nome, string cpf, DateOnly dataNascimento)
        {
            Nome = nome;
            Cpf = cpf;
            DataNascimento = dataNascimento;
        }

        public int Idade()
        {
            return DateTime.Now.Year - DataNascimento.Year;
        }
    }
}
