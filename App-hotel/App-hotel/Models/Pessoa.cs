using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_hotel.Models
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        public string Telefone { get; set; }

        public Pessoa(string nome, string sobrenome, string telefone)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Telefone = telefone;
        }
        public override string ToString()
        {
            return $"Nome: {Nome}, Sobrenome: {Sobrenome}, Telefone: {Telefone}".ToUpper();
        }
    }
}
