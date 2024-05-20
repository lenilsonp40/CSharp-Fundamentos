using System;

namespace checklist {
    class Program {
        static void Main(string[] args) {
            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());

            string[] vet = Console.ReadLine().Split(' ');// desestruturar uma string com split
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3]);


            Console.WriteLine("Você digitou:");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura);
        }
    }
}