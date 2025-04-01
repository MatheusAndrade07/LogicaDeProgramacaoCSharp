using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.EstruturaRepetitiva
{
    public class Repetitiva
    {
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
