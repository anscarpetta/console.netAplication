using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem Vindos ao Compilado de mini Programas do Angelo\n");
            Console.WriteLine("Para continuar digite o numero do Programa que deseja:\n");
            Console.WriteLine(" - Para Calcular a area de formas geometrica digite 1");
            int program = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("---------------------------------------\n");

            switch (program)
            {

                case 1:

                    Console.WriteLine("Voce escolheu 'Calcular a area de formas geometricas'\n");
                    Console.WriteLine("Agora, dentre as opcoes: quadrado, retangulo, triangulo, circulo e pentagono,");
                    Console.WriteLine("Digite qual forma voce deseja calcular a area!\n");
                    String forma = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("---------------------------------------\n");
                    switch (forma.ToLower())
                    {
                        case "quadrado":
                            double quadradoSideA = 0;
                            Console.WriteLine("Vamos Descobrir a area do Quadrado!\n");
                            Console.Write("Qual o valor do lado do Quadrado?\n");
                            quadradoSideA = Convert.ToDouble(Console.ReadLine());
                            double areaQuadrado = Math.Pow(quadradoSideA, 2);
                            Console.WriteLine($"A area do Quadrado e igual a {areaQuadrado}!");
                            break;

                        case "retangulo":
                            double retanguloSideA = 0;
                            double retanguloSideB = 0;
                            Console.WriteLine("Vamos Descobrir a area do Retangulo!\n");
                            Console.Write("Qual o valor do lado primeiro lado do Retangulo?\n");
                            retanguloSideA = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Qual o valor do lado segundo lado do Retangulo?\n");
                            retanguloSideB = Convert.ToDouble(Console.ReadLine());
                            double areaRetangulo = retanguloSideA * retanguloSideB;
                            Console.WriteLine($"A area do Retangulo e igual a {areaRetangulo}!");
                            break;

                        case "triangulo":
                            double trianguloBase = 0;
                            double trianguloHeight = 0;
                            Console.WriteLine("Vamos Descobrir a area do Triangulo!\n");
                            Console.Write("Qual o valor da base do Triangulo?\n");
                            trianguloBase = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Qual o valor da altura do Triangulo?\n");
                            trianguloHeight = Convert.ToDouble(Console.ReadLine()); ;
                            double areaTriangulo = (trianguloHeight * trianguloBase) / 2;
                            Console.WriteLine($"A area do Triangulo e igual a {areaTriangulo}!");
                            break;

                        case "pentagono":
                            double pentagonoSide = 0;
                            double pentagonoApolema = 0;
                            Console.WriteLine("Vamos Descobrir a area do Pentagono!\n");
                            Console.Write("Qual o valor de um dos lados do Pentagono?\n");
                            trianguloBase = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Qual o valor do apolema do Pentagono?\n");
                            trianguloHeight = Convert.ToDouble(Console.ReadLine()); ;
                            double areaPentagono = (pentagonoSide * 5) * pentagonoApolema;
                            Console.WriteLine($"A area do Pentagono e igual a {areaPentagono}!");
                            break;

                        case "circulo":
                            double circuloRadius = 0;
                            Console.WriteLine("Vamos Descobrir a area do Circulo!\n");
                            Console.Write("Qual o valor do raio do Circulo?\n");
                            circuloRadius = Convert.ToDouble(Console.ReadLine());
                            double areaCirculo = Math.PI * Math.Pow(circuloRadius, 2);
                            Console.WriteLine($"A area do Circulo e igual a {areaCirculo}!");
                            break;
                    }


                    break;
            }
        }
    }
}
