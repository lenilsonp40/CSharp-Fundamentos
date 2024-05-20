using System;
using System.Globalization;

namespace uri1003
{
    class Program
    {
        static void Main(string[] args)
        {

            
        }
    }
}






/*
using System;
using System.Globalization;

namespace uri1003
{
    class Program
    {
        static void Main(string[] args)
        {

            int N, horas, resto, minutos, segundos;

            N = int.Parse(Console.ReadLine());

            horas = N / 3600;
            resto = N % 3600;

            minutos = resto / 60;
            segundos = resto % 60;

            Console.WriteLine(horas + ":" + minutos + ":" + segundos);
        }
    }
}
*/



/*
using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome1, nome2;
            int idade1, idade2;
            double media;
            string[] vet;

            vet = Console.ReadLine().Split(' ');
            nome1 = vet[0];
            idade1 = int.Parse(vet[1]);
            vet = Console.ReadLine().Split(' ');
            nome2 = vet[0];
            idade2 = int.Parse(vet[1]);
            media = (double)(idade1 + idade2) / 2.0;
            Console.WriteLine("A idade média de " + nome1 + " e " + nome2 + " é de "
            + media.ToString("F1", CultureInfo.InvariantCulture) + " anos");
            Console.ReadLine();
        }
    }
}
*/



/*

using System;

class URI
{

    static void Main(string[] args)
    {

        int A, B, X;
        A = int.Parse(Console.ReadLine());
        B = int.Parse(Console.ReadLine());

        X = A + B;

        Console.WriteLine("X = " + X);


    }
}

*/

/*
using System;
using System.Globalization;
namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            double b, a, area, perimetro, diagonal;
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            area = b * a;
            perimetro = 2 * (b + a);
            diagonal = Math.Sqrt(Math.Pow(b, 2.0) + Math.Pow(a, 2.0));
            Console.WriteLine("AREA = " + area.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " + perimetro.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + diagonal.ToString("F4", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
*/

/*

using System;

namespace Treinando
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o numero de A:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero de B:");
            int n2 = int.Parse(Console.ReadLine());

            int resultado = n1 + n2;

            Console.WriteLine("resultado = " + resultado);

        }
    }
}

*/

