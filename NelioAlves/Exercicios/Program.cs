/*
Fazer um programa para executar a seguinte interação com o
usuário, lendo os valores destacados em vermelho, e depois
mostrar os dados na tela:
Entre com seu nome completo:
Alex Green
Quantos quartos tem na sua casa?
3
Entre com o preço de um produto:
500,50
Entre com seu último nome, idade e altura (mesma linha):
Green 21 1.73
 
*/


using System;
using System.Globalization;


namespace Exercicio01
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo:");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o preço?:");
            double preco = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha):");
            
            string[] dados = Console.ReadLine().Split(' ');
            string sobreNome = dados[0];
            int idade = int.Parse(dados[1]);
            double altura = double.Parse(dados[2]);

            Console.WriteLine("Você digitou:");
            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString(new CultureInfo("en-US")));
            Console.WriteLine(sobreNome);
            Console.WriteLine(idade);
            Console.WriteLine(altura);
            
        }
    }
}
