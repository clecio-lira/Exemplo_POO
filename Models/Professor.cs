using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo_POO.Models
{
    public sealed class Professor : Pessoa
    {
        public decimal Salario { get; set; }

        public Professor()
        {

        }

        public Professor(string nome)
        {
            Nome = nome;
        }

        public sealed override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos, sou professor e ganho R${Salario}");
        }
    }
}