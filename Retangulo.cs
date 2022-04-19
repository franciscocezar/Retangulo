using System;

namespace ProjetoRetangulo
{
    public class Retangulo
    {

        public double Largura, Altura;


        public double Area()
        {
            return Largura * Altura;
        }


        public double Perimetro()
        {
            return 2 * (Largura + Altura);
        }


        public double Diagonal()
        {
            return Math.Sqrt((Math.Pow(Altura, 2) + Math.Pow(Largura, 2)));
        }
    }
}
