using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova___Vitor_Oliveira_Batista
{
    class Program
    {
        static void Main(string[] args)
        {
            Caminhão[] lista_C = new Caminhão[2];
            Ônibus[] lista_O = new Ônibus[2];

            for (int j = 0; j < 2; j++)
            {
                Console.WriteLine("Digite o ano do caminhão");
                int ano = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a placa do caminhão");
                string placa = Console.ReadLine();
                Console.WriteLine("Quantos eixos tem o caminhão?");
                int eixos = int.Parse(Console.ReadLine());

                Caminhão a = new Caminhão(placa, ano, eixos);

                lista_C[j] = a;
            }
            for (int k = 0; k < 2; k++)
            {
                Console.WriteLine("Digite o ano do onibus");
                int ano = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Digite a placa do onibus");
                string placa = Console.ReadLine();
                Console.WriteLine("Quantos assentos tem o onibus?");
                int assentos = Int32.Parse(Console.ReadLine());

                Ônibus a = new Ônibus(placa, ano, assentos);

                lista_O[k] = a;
            }

            Console.WriteLine("Cadastrado");
            for (int i = 0; i < lista_C.Length; i++)
            {
                double aluguel = lista_C[i].Alugar();
                Console.WriteLine(String.Format("{0} - Alugel Diário = {1}R$", lista_C[i].getPlaca(), aluguel));
            }
            for (int i = 0; i < lista_O.Length; i++)
            {
                double aluguel = lista_O[i].Alugar();
                Console.WriteLine(String.Format("{0} - Alugel Diário = {1}R$", lista_O[i].getPlaca(), aluguel));
            }
            string b = Console.ReadLine();
        }
    }
}