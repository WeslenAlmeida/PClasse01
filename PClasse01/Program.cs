using System;

namespace PClasse01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa[] pessoas = new Pessoa[3];

            for(int i = 0; i < pessoas.Length; i++)
            {
                string[] dados = Cadastro(i);
                pessoas[i] = new Pessoa(dados[0], dados[1], dados[2], dados[3]);
            }

            Console.Clear();

            for(int i = 0; i < pessoas.Length; i++)
            {
                Console.WriteLine($"\n{i+1}° CADASTRO");
                Console.WriteLine(pessoas[i].ToString());
            } 


        }
        static string[] Cadastro(int cont)
        {
            string[] dados = new string[4];

            Console.WriteLine($"{cont+1}° CADASTRO");
            Console.Write($"Digite seu nome: ");
            dados[0] = Console.ReadLine();

            Console.Write($"Digite sua data de nascimento: ");
            dados[1] = Console.ReadLine();

            Console.Write($"Digite seu CPF: ");
            dados[2] = Console.ReadLine();

            Console.Write("Digite seu telefone: ");
            dados[3] = Console.ReadLine();
            Console.WriteLine();

            return dados;
        }
    }
}
