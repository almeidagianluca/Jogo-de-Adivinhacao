using System;

namespace Advinhação
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //instanciando o ojeto que irá sortear o número
            Random aleatorio = new Random();
            //Valor a ser acertado
            int valor = aleatorio.Next(1,51);
            //valor fornecido pelo jogador
            int palpite = 60;
            // numeros de vidas
            int vidas = 3;
            
            Console.WriteLine("Vamos jogar?");
            Console.WriteLine("Tente advinhar qual número de 1 a 50 estou pensando...");
            
                while ((palpite != valor) && (vidas > 0))
                {


                palpite = Int32.Parse(Console.ReadLine());
                        if (palpite != valor)
                        {
                            if (Math.Abs(palpite - valor) < 3)
                            {
                                Console.WriteLine("Você errou, mas não desista está quente!");
                                vidas = vidas - 1;
                                Console.WriteLine("Você tem " + vidas + " vidas restantes");
                            }
                            else
                            {
                                Console.WriteLine("Você errou feio, está frio. Tente novamente...");
                                vidas = vidas - 1;
                                Console.WriteLine("Você tem " + vidas + " vidas restantes");
                            }

                        }
                        else
                            Console.WriteLine("Parabéns!!! Você acertou!!!");

                    
                    
                }
                if (valor != palpite)
                    Console.WriteLine("\r\n--- Você ficou sem vidas ---");


        }
    }
}
