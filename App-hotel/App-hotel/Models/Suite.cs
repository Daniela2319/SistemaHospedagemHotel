using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_hotel.Models
{
    internal class Suite
    {
        public string TipoSuite { get; set; }
        public int Capacidade { get; set; }
        public decimal ValorDiaria { get; set; }

        public Suite(string tipoSuite, int capacidade, decimal valorDiaria)
        {
            TipoSuite = tipoSuite;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
        }

        public override string ToString()
        {
            return $"Tipo: {TipoSuite}, Capacidade: {Capacidade}, Valor Diária: R$ {ValorDiaria}";
        }
    }
}
