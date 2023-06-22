using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-Vindo ao Sistema de Usuários do Bruno");
            Console.WriteLine("Abaixo Estão as informações dos Usuários Cadastrados no Nosso Sistema\n\n");

            string nom1 = "Bruno";
            string nom2 = "Kat";
            int id1 = 20;
            int id2 = 21;
            bool vd = true;
            bool fs = false;


            Console.WriteLine("----- Listas de Usuários:");
            Console.WriteLine($" 1 - Nome: {nom1}, Idade: {id1}. É Cliente: {vd}");
            Console.WriteLine($" 2 - Nome: {nom2}, Idade: {id2}. É Cliente: {fs}");

            int cafe = 187;
            int cafes = 5;


            Console.WriteLine("----- Qauntidades de Cafés:");
            Console.WriteLine($"O Cliente {nom1} Já Tomou {cafe} Cafés!");
            Console.WriteLine($"O Cliente {nom2} Já Tomou {cafes} Cafés!\n\n");

            Console.WriteLine("----- Soma de Cafés Tomados Juntos");
            Console.WriteLine($"Os Clientes {nom1} e {nom2} Tomaram {cafe + cafes} Cafés! \n\n");

            Console.WriteLine("----- Quantos Cafés Faltam para Chegar em 200?");
            Console.WriteLine($"Faltam {200 - cafe} para {nom1}");
            Console.WriteLine($"Faltam {200 - cafes} para {nom2}\n\n");

            Console.WriteLine("----- Fim Do Sistema De Consultas");
            Console.WriteLine("- Obrigado e Volte Sempre");
            Console.ReadKey();
        }
    }
}
