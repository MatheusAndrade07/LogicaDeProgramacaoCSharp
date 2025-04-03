using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.EstruturaRepetitiva
{
    public class Repetitiva
    {

        public static void Ex1131()
        {
            int N;
            while (true)
            {
                N = int.Parse(Console.ReadLine());

                if (N == 0)
                    break;

                for (int m = 1; m <= N; m++)
                {
                    int[] regioes = new int[N];
                    for (int i = 0; i < N; i++)
                    {
                        regioes[i] = i + 1;
                    }

                    int atual = 0;
                    int desligadas = 0;

                    while (desligadas < N - 1)
                    {
                        atual = (atual + m - 1) % (N - desligadas);
                        regioes[atual] = 0;
                        desligadas++;
                    }

                    if (regioes[atual] == 13)
                    {
                        Console.WriteLine(m);
                        break;
                    }
                }
            }
        }
        public static void Ex1154() 
        {
            int idade, cont, soma;
            double media;

            cont = 0;
            soma = 0;

            idade = int.Parse(Console.ReadLine());

            while (idade >= 0) 
            {
                soma += idade;
                cont += 1;
                idade = int.Parse(Console.ReadLine());
            }
            media = (double) soma / cont;
            Console.WriteLine($"{media.ToString("F2")}");
        }
        public static void Ex1134() 
        {
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            int tipo = int.Parse(Console.ReadLine());

            while (tipo != 4)
            {
                if (tipo == 1)
                {
                    alcool += 1;
                }
                else if (tipo == 2)
                {
                    gasolina += 1;
                }
                else if (tipo == 3)
                {
                    diesel += 1;
                }

                tipo = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine($"Alcool: {alcool}");
            Console.WriteLine($"Gasolina: {gasolina}");
            Console.WriteLine($"Diesel: {diesel}");
        }
        public static void Ex1117() 
        {
            double primeiraNota, segundaNota, media;

            primeiraNota = double.Parse(Console.ReadLine());
            
            while (primeiraNota < 0.0 || primeiraNota > 10.0)
            {
                Console.WriteLine("nota invalida");

                primeiraNota = double.Parse(Console.ReadLine());                
            }

            segundaNota = double.Parse(Console.ReadLine());

            while (segundaNota < 0.0 || segundaNota > 10.0)
            {
                Console.WriteLine("nota invalida");

                segundaNota = double.Parse(Console.ReadLine());
            }
            media = (primeiraNota + segundaNota) / 2.0;

            Console.WriteLine($"media = {media.ToString("F2")}");

        }
        public static void Ex1115() 
        {
            int x, y;
            string[] valoresXeY;

            valoresXeY = Console.ReadLine().Split();
            x = int.Parse(valoresXeY[0]);
            y = int.Parse(valoresXeY[1]);

            while (x != 0 && y != 0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("primeiro");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("segundo");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("terceiro");
                }
                else
                {
                    Console.WriteLine("quarto");
                }

                valoresXeY = Console.ReadLine().Split(' ');
                x = int.Parse(valoresXeY[0]);
                y = int.Parse(valoresXeY[1]);
            }

        }
        public static void Ex1114() 
        {
            int senha = int.Parse(Console.ReadLine());

            while (senha != 2002)
            {
                Console.WriteLine("Senha Invalida");
                senha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido");
        }
        public static void ExParalelo2() 
        {
            double n1, soma, media;
            int cont;

            soma = 0.0;
            cont = 0;
            
            n1 = int.Parse(Console.ReadLine());

            if (n1 < 0)
            {
                Console.WriteLine("Impossivel Calcular");
            }
            else
            {
                while (n1 >= 0)
                {
                    soma += n1;
                    cont += 1;
                    n1 = double.Parse(Console.ReadLine());
                }
                media = soma / cont;
                Console.WriteLine($"Média: {media:F2}");
            }            
        }
        public static void Ex1113() 
        {
            string[] valores;
            int n1, n2;

            valores = Console.ReadLine().Split(' ');
            n1 = int.Parse(valores[0]);
            n2 = int.Parse(valores[1]);

            while (n1 != n2) 
            {
                if (n1 < n2)
                {
                    Console.WriteLine("Crescente");
                }
                else
                {
                    Console.WriteLine("Derescente");
                }
                valores = Console.ReadLine().Split(' ');
                n1 = int.Parse(valores[0]);
                n2 = int.Parse(valores[1]);
            }           
            
        }
        public static void ExParalelo() 
        {
            int x, soma;

            x = int.Parse(Console.ReadLine());
            soma = 0;

            while (x != 0) 
            {
                soma += x;
                x = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(soma);
        }
    }
}
