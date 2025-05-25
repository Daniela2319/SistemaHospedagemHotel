using App_hotel.Models;
using System;
using System.Collections.Generic;

namespace App_hotel
{
    internal class Menu
    {
        private List<Pessoa> hospedes = new List<Pessoa>();
        private Suite suite;
        private Reserva reserva;

        public void Exibir()
        {
            string opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("=== MENU DO HOTEL ===");
                Console.WriteLine("1 - Cadastrar Hóspede");
                Console.WriteLine("2 - Cadastrar Suíte");
                Console.WriteLine("3 - Criar Reserva");
                Console.WriteLine("4 - Ver Detalhes da Reserva");
                Console.WriteLine("5 - Sair");
                Console.Write("Escolha uma opção: ");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        CadastrarHospede();
                        break;

                    case "2":
                        CadastrarSuite();
                        break;

                    case "3":
                        CriarReserva();
                        break;

                    case "4":
                        MostrarDetalhesReserva();
                        break;

                    case "5":
                        Console.WriteLine("Saindo do sistema...");
                        break;

                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }

                if (opcao != "5")
                {
                    Console.WriteLine("\nPressione qualquer tecla para continuar...");
                    Console.ReadKey();
                }

            } while (opcao != "5");
        }

        private void CadastrarHospede()
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Sobrenome: ");
            string sobrenome = Console.ReadLine();
            Console.Write("Telefone: ");
            string telefone = Console.ReadLine();

            hospedes.Add(new Pessoa(nome, sobrenome, telefone));
            Console.WriteLine("✅ Hóspede cadastrado com sucesso!");
        }

        private void CadastrarSuite()
        {
            Console.Write("Tipo da Suíte: ");
            string tipo = Console.ReadLine();
            Console.Write("Capacidade: ");
            int capacidade = int.Parse(Console.ReadLine());
            Console.Write("Valor da Diária: R$ ");
            decimal valor = decimal.Parse(Console.ReadLine());

            suite = new Suite(tipo, capacidade, valor);
            Console.WriteLine("✅ Suíte cadastrada com sucesso!");
        }

        private void CriarReserva()
        {
            if (suite == null)
            {
                Console.WriteLine("⚠️ Cadastre uma suíte antes de fazer a reserva.");
                return;
            }

            if (hospedes.Count == 0)
            {
                Console.WriteLine("⚠️ Cadastre pelo menos um hóspede.");
                return;
            }

            Console.Write("Dias reservados: ");
            int dias = int.Parse(Console.ReadLine());
            try
            {
                reserva = new Reserva(hospedes, suite, dias);
                Console.WriteLine("✅ Reserva criada com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao criar reserva: {ex.Message}");
            }
        }

        private void MostrarDetalhesReserva()
        {
            if (reserva == null)
            {
                Console.WriteLine("⚠️ Nenhuma reserva cadastrada ainda.");
                return;
            }

            Console.WriteLine("\n--- DETALHES DA RESERVA ---");
            Console.WriteLine($"Hóspedes: {reserva.obterQuantidadeHospedes()}");
            foreach (var h in reserva.Hospedes)
            {
                Console.WriteLine(h.ToString());
            }

            Console.WriteLine(suite.ToString());
            Console.WriteLine($"Dias: {reserva.DiasReservados}");
            Console.WriteLine($"Valor total: R$ {reserva.CalcularValorDiaria():F2}");
        }
    }
}

