using System;

namespace ProjetoRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo x = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo:");
            x.Largura = double.Parse(Console.ReadLine());
            x.Altura = double.Parse(Console.ReadLine());


            Console.WriteLine("AREA = " + x.Area().ToString("F2"));
            Console.WriteLine("PERÍMETRO = " + x.Perimetro().ToString("F2"));
            Console.WriteLine("DIAGONAL = " + x.Diagonal().ToString("F2"));



        }
    }
}
