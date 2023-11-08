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
            Console.WriteLine("Como posso te chamar?");
            String nome = Convert.ToString(Console.ReadLine());
            Console.WriteLine($"{nome}? Perfeito!\n");

            Console.WriteLine("Para continuarmos digite o numero do Programa que deseja:\n");
            Console.WriteLine(" - Para Calcular a area de formas geometrica digite 1");
            Console.WriteLine(" - Para Jogar Pedra, Papel e Tesoura digite 2");

            int program = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("---------------------------------------\n");

            switch (program)
            {

                case 1:

                    Console.WriteLine($"{nome}, voce escolheu 'Calcular a area de formas geometricas'\n");
                    Console.WriteLine("Agora, dentre as opcoes: quadrado, retangulo, triangulo, circulo e pentagono,");
                    Console.WriteLine("Digite qual das formas deseja calcular a area!\n");
                    String forma = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("---------------------------------------\n");
                    switch (forma.ToLower())
                    {
                        case "quadrado":
                            double quadradoSideA = 0;
                            Console.WriteLine("Vamos Descobrir a area do Quadrado!\n");
                            Console.WriteLine("Qual o valor do lado do Quadrado?\n");
                            quadradoSideA = Convert.ToDouble(Console.ReadLine());
                            double area = Math.Pow(quadradoSideA, 2);
                            Console.WriteLine($"A area do Quadrado e igual a {area}!\n");
                            break;

                        case "retangulo":
                            double retanguloSideA = 0;
                            double retanguloSideB = 0;
                            Console.WriteLine("Vamos Descobrir a area do Retangulo!\n");
                            Console.WriteLine("Qual o valor do lado primeiro lado do Retangulo?\n");
                            retanguloSideA = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Qual o valor do lado segundo lado do Retangulo?\n");
                            retanguloSideB = Convert.ToDouble(Console.ReadLine());
                            area = retanguloSideA * retanguloSideB;
                            Console.WriteLine($"A area do Retangulo e igual a {area}!\n");
                            break;

                        case "triangulo":
                            double trianguloBase = 0;
                            double trianguloHeight = 0;
                            Console.WriteLine("Vamos Descobrir a area do Triangulo!\n");
                            Console.WriteLine("Qual o valor da base do Triangulo?\n");
                            trianguloBase = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Qual o valor da altura do Triangulo?\n");
                            trianguloHeight = Convert.ToDouble(Console.ReadLine()); ;
                            area = (trianguloHeight * trianguloBase) / 2;
                            Console.WriteLine($"A area do Triangulo e igual a {area}!\n");

                            break;

                        case "pentagono":
                            double pentagonoSide = 0;
                            double pentagonoApolema = 0;
                            Console.WriteLine("Vamos Descobrir a area do Pentagono!\n");
                            Console.WriteLine("Qual o valor de um dos lados do Pentagono?\n");
                            trianguloBase = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Qual o valor do apolema do Pentagono?\n");
                            trianguloHeight = Convert.ToDouble(Console.ReadLine()); ;
                             area = (pentagonoSide * 5) * pentagonoApolema;
                            Console.WriteLine($"A area do Pentagono e igual a {area}!\n");
                            break;

                        case "circulo":
                            double circuloRadius = 0;
                            Console.WriteLine("Vamos Descobrir a area do Circulo!\n");
                            Console.WriteLine("Qual o valor do raio do Circulo?\n");
                            circuloRadius = Convert.ToDouble(Console.ReadLine());
                            double value = Math.PI * Math.Pow(circuloRadius, 2);
                             area = value;
                            Console.WriteLine($"A area do Circulo e igual a {area}!\n");

                            break;
                    }
                    Console.WriteLine("Crtl + C Para Fechar.");

                    while (true)
                    {
                        string linha = Console.ReadLine();
                        if (linha == null)
                        {
                            break;
                        }
                    }
                        break;
                case 2:
                    Console.WriteLine("Voce escolheu 'Pedra, Papel e Tesoura'\n");
                    Console.WriteLine("Seu oponente sera... a Maquina!");
                    Console.WriteLine($"Esta pronto {nome}?");
                    for (int i = 3; i >= 0; i--)
                    { 
                        if (i != 0)
                        {
                            Console.WriteLine($"{i}...");
                        }
                        else 
                        {
                            Console.WriteLine("JA!");

                        }
                    }
                    String jogada = Convert.ToString(Console.ReadLine());
                    List<string> jogadaBot = new List<string> { "Pedra", "Papel", "Tesoura" };
                    int randomIndex = new Random().Next(0, jogadaBot.Count);
                    string randomJogadaBot = jogadaBot[randomIndex];
                    Console.WriteLine($"{nome} jogou {jogada.ToUpper().Substring(0, 1) + jogada.ToLower().Substring(1)}, e a Maquina jogou {randomJogadaBot}");
                    Console.WriteLine("ou seja...");

                    if (jogada.ToLower() == "pedra")
                    {
                        if (randomJogadaBot.ToLower() == "pedra")
                        {
                            Console.WriteLine("Empate!");

                        }
                        else if (randomJogadaBot.ToLower() == "papel")
                        {
                            Console.WriteLine("Maquina Venceu!");

                        }
                        else
                        {
                            Console.WriteLine($"{nome} Venceu!\nParabens!");

                        }
                    }
                    else if (jogada.ToLower() == "papel")
                    {
                        if (randomJogadaBot.ToLower() == "pedra")
                        {
                            Console.WriteLine($"{nome} Venceu!\nParabens!");

                        }
                        else if (randomJogadaBot.ToLower() == "papel")
                        {
                            Console.WriteLine("Empate!");

                        }
                        else
                        {
                            Console.WriteLine("Maquina Venceu!");

                        }
                    }
                    else
                    {
                        if (randomJogadaBot.ToLower() == "pedra")
                        {
                            Console.WriteLine("Maquina Venceu!");

                        }
                        else if (randomJogadaBot.ToLower() == "papel")
                        {
                            Console.WriteLine($"{nome} Venceu!\nParabens!");

                        }
                        else
                        {
                            Console.WriteLine("Empate!");

                        }
                    }
                    Console.WriteLine("Crtl + C Para Fechar.");





                    while (true)
                    {
                        string linha = Console.ReadLine();
                        if (linha == null)
                        {
                            break;
                        }
                    }
                    break;
            }
        }
    }
}
