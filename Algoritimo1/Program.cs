using System;

namespace Algoritimo1
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Exercicio3 Jogo da forca

            int maxTentativas = 7;
            string palavra = "DESENVOLVEDOR";
            int qtdDeCaracteres = palavra.Length;
            string segredo = "";

            for (int i = 0; i < qtdDeCaracteres; i++)
            {
                segredo = segredo + "_ ";
            }

            string letra = "";


            for (int i = 0; i < maxTentativas; i++)
            {
                Console.WriteLine(segredo);
                Console.WriteLine("Informe uma letra");
                letra = Console.ReadLine();
                letra = letra.ToUpper();

                if (letra.Length == 1)
                {
                    for (int l = 0; l < qtdDeCaracteres; l++)
                    {
                        string letter = palavra.Substring(l, 1);
                         Console.WriteLine("Existe essa letra");
                    }
                }

            }


            /// Exercicio2 Tempo de viagem

            // Console.WriteLine("DIgite a distancia");
            // double distancia = Convert.ToDouble(Console.ReadLine());

            // Console.WriteLine("DIgite a velocidade (KM/H)");
            // double velocidade = Convert.ToDouble(Console.ReadLine());

            //double tempo = distancia / velocidade;

            // Console.WriteLine($"Voce chegara em {tempo}horas");



            /////Exercicio 1
            ///do

            //Console.WriteLine("Digigte a primeira nota");
            //double nota1 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Digigte a segunda nota");
            //double nota2 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Digigte a terceira nota");
            //double nota3 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Digigte a quarta nota");
            //double nota4 = Convert.ToDouble(Console.ReadLine());

            //double media = (nota1 + nota2 + nota3 + nota4)/ 4;

            //if (media <= 6.9)
            //{
            //    Console.WriteLine($"A media do aluno foi: {media}");
            //    Console.WriteLine("aluno reprovado");
            //}
            //if (media >= 7)

            //        Console.WriteLine($"A media do aluno foi: {media}");
            //Console.WriteLine("aluno aprovado");

        }
    }
}  
