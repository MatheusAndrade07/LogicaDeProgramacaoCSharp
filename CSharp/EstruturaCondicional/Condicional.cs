﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharp.EstruturaCondicional
{
    public class Condicional
    {
        public static void ExParaleloEC()
        {
            double notaPrimeiroSemestre, notaSegundoSemestre, mediaTotal;

            Console.Write("DIGITE SUA NOTA DO PRIMEIRO SEMESTRE: ");
            while (!double.TryParse(Console.ReadLine(), out notaPrimeiroSemestre))
            {
                Console.Write("ENTRADA INVÁLIDA! DIGITE UM NÚMERO VÁLIDO: ");
            }

            Console.Write("DIGITE SUA NOTA DO SEGUNDO SEMESTRE: ");
            while (!double.TryParse(Console.ReadLine(), out notaSegundoSemestre))
            {
                Console.Write("ENTRADA INVÁLIDA! DIGITE UM NÚMERO VÁLIDO: ");
            }

            mediaTotal = (notaPrimeiroSemestre + notaSegundoSemestre) / 2.0;

            Console.WriteLine($"SUA NOTA FINAL FOI {mediaTotal:F1}");

            if (mediaTotal > 60.0)
            {
                Console.WriteLine("PARABÉNS! VOCÊ PASSOU!!");
            }
            else
            {
                Console.WriteLine("VOCÊ ESTÁ DE RECUPERAÇÃO!!");
            }

        }
        public static void VerificarNumeroParOuImpar()
        {
            Console.Write("DIGITE UM NÚMERO: ");
            if (int.TryParse(Console.ReadLine(), out int numero))
            {
                if (numero % 2 == 0)
                {
                    Console.WriteLine("O NÚMERO É PAR!");
                }
                else
                {
                    Console.WriteLine("O NÚMERO É ÍMPAR!");
                }
            }
            else
            {
                Console.WriteLine("ENTRADA INVÁLIDA! DIGITE UM NÚMERO INTEIRO.");
            }
        }

        public static void ExercicioParaleloSimples()
        {
            double notaPrimeiroSemestre, notaSegundoSemestre, mediaTotal;
            string[] notas = new string[2];

            Console.WriteLine("Digite suas duas notas, escreva a do seu primeiro semestre e em seguida o do segundo!");
            notas = Console.ReadLine().Split(' ');

            notaPrimeiroSemestre = double.Parse(notas[0]);
            notaSegundoSemestre = double.Parse(notas[1]);

            mediaTotal = (notaPrimeiroSemestre + notaSegundoSemestre) / 2.0;

            if (mediaTotal >= 60)
            {
                Console.WriteLine($"Parabéns você está aprovado! sua média no final foi {mediaTotal}");
            }
            else if (mediaTotal < 60)
            {
                Console.WriteLine($"Infelizmente você está reprovado sua média total foi {mediaTotal}");
            }
        }
        public static void Bhaskara()
        {
            double a, b, c, delta, r1, r2;
            string[] vetor;

            vetor = Console.ReadLine().Split(' ');

            a = double.Parse(vetor[0]);
            b = double.Parse(vetor[1]);
            c = double.Parse(vetor[2]);

            delta = Math.Pow(b, 2.0) - 4 * a * c;

            if (a == 0 || delta < 0.0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                r1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
                r2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

                Console.WriteLine($"R1 = {r1.ToString("F5")}");
                Console.WriteLine($"R2 = {r2.ToString("F5")}");
            }
        }
        public static void MenorNumero()
        {
            int a, b, c;
            string[] vetor;

            vetor = Console.ReadLine().Split(' ');

            a = int.Parse(vetor[0]);
            b = int.Parse(vetor[1]);
            c = int.Parse(vetor[2]);

            if (a < b && a < c)
            {
                Console.WriteLine($"MENOR = {a}");
            }
            else if (b < c) 
            {
                Console.WriteLine($"MENOR = {b}");
            }
            else 
            {
                Console.WriteLine($"MENOR = {c}");
            }
        }
        public static void ContaTelefonica() 
        {
            int minutosDeLigacao;
            double valorConta;

            valorConta = 50.0;

            Console.WriteLine("Digite quantos minutos de ligação você realizou! ");
            minutosDeLigacao = int.Parse(Console.ReadLine());

            if (minutosDeLigacao < 100) 
            {
                Console.WriteLine($"Valor a pagar: R$ 50.00");
            }
            else 
            {
                valorConta += (minutosDeLigacao - 100) * 2.0;

                Console.WriteLine($"Valor a pagar: R$ {valorConta.ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }

    }
}
