using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.EstruturaRepetitiva
{
    public class Repetitiva
    {
        public static void Ex1142()
        {
            int n = int.Parse(Console.ReadLine());

            int inicio = 1;

            for (int i = 1; i <= n; i++)
            {
                int segundo = inicio + 1;
                int terceiro = inicio + 2;
                Console.WriteLine($"{inicio} {segundo} {terceiro} PUM");

                inicio = inicio + 4;
            }
        }
        public static void Ex1133()
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if (x > y)
            {
                int aux = x;
                x = y;
                y = aux;
            }

            for (int i = x + 1; i < y; i++)
            {
                if (i % 5 == 2 || i % 5 == 3)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static void Ex1132()
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int menor = x;
            int maior = y;

            if (x > y)
            {
                menor = y;
                maior = x;
            }

            int soma = 0;
            for (int i = menor; i <= maior; i++)
            {
                if (i % 13 != 0)
                {
                    soma = soma + i;
                }
            }

            Console.WriteLine(soma);
        }        
        public static void Ex1116()
        {

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {

                string[] line = Console.ReadLine().Split(' ');
                int x = int.Parse(line[0]);
                int y = int.Parse(line[1]);

                if (y == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    double div = (double)x / y;
                    Console.WriteLine(div.ToString("F1", CultureInfo.InvariantCulture);
                }
            }
        }
        public static void Ex1097()
        {
            int j = 7;
            for (int i = 1; i <= 9; i = i + 2)
            {
                Console.WriteLine($"I={i} J={j}");
                Console.WriteLine($"I={i} J={j - 1}");
                Console.WriteLine($"I={i} J={j - 2}");
                j = j + 2;
            }
        }
        public static void Ex1096()
        {
            for (int i = 1; i <= 9; i += 2)
            {
                for (int j = 7; j >= 5; j--)
                {
                    Console.WriteLine($"I={i} J={j}");
                }
            }
        }
        public static void Ex1094()
        {
            int n = int.Parse(Console.ReadLine());

            int coelhos = 0;
            int ratos = 0;
            int sapos = 0;

            for (int i = 0; i < n; i++)
            {

                string[] valores = Console.ReadLine().Split(' ');
                int quantia = int.Parse(valores[0]);
                char tipo = char.Parse(valores[1]);

                if (tipo == 'C')
                {
                    coelhos = coelhos + quantia;
                }
                else if (tipo == 'R')
                {
                    ratos = ratos + quantia;
                }
                else
                {
                    sapos = sapos + quantia;
                }
            }

            int total = coelhos + ratos + sapos;
            double porcentagemCoelhos = (double)coelhos / total * 100.0;
            double porcentagemRatos = (double)ratos / total * 100.0;
            double porcentagemSapos = (double)sapos / total * 100.0;

            Console.WriteLine($"Total: {total} cobaias");
            Console.WriteLine($"Total de coelhos: {coelhos}");
            Console.WriteLine($"Total de ratos: {ratos}");
            Console.WriteLine($"Total de sapos: {sapos}");
            Console.WriteLine($"Percentual de coelhos: {porcentagemCoelhos:F2} %");
            Console.WriteLine($"Percentual de ratos: {porcentagemRatos:F2} %");
            Console.WriteLine($"Percentual de sapos: {porcentagemSapos:F2} %");
        }
        public static void Ex1080() 
        {
            int maior = int.Parse(Console.ReadLine());
            int posicao = 1;

            for (int i = 2; i <= 100; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x > maior)
                {
                    maior = x;
                    posicao = i;
                }
            }
            Console.WriteLine(maior);
            Console.WriteLine(posicao);
        }
        public static void Ex1079() 
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {

                string[] line = Console.ReadLine().Split(' ');
                double a = double.Parse(line[0], CultureInfo.InvariantCulture);
                double b = double.Parse(line[1], CultureInfo.InvariantCulture);
                double c = double.Parse(line[2], CultureInfo.InvariantCulture);

                double media = (a * 2.0 + b * 3.0 + c * 5.0) / 10.0;

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
        public static void Ex1075() 
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10000; i++)
            {
                if (i % N == 2)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static void Ex1074() 
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {

                int x = int.Parse(Console.ReadLine());

                if (x == 0)
                {
                    Console.WriteLine("NULL");
                }
                else if (x > 0)
                {
                    if (x % 2 == 0)
                    {
                        Console.WriteLine("EVEN POSITIVE");
                    }
                    else
                    {
                        Console.WriteLine("ODD POSITIVE");
                    }
                }
                else
                {
                    if (x % 2 == 0)
                    {
                        Console.WriteLine("EVEN NEGATIVE");
                    }
                    else
                    {
                        Console.WriteLine("ODD NEGATIVE");
                    }
                }
            }
        }
        public static void Ex1073()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 2; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    int quadrado = i * i;
                    Console.WriteLine($"{i} ^2 = {quadrado}");
                }
            }
        }
        public static void Ex1072() 
        {
            int n = int.Parse(Console.ReadLine());

            int cont_in = 0;
            int cont_out = 0;

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x >= 10 && x <= 20)
                {
                    cont_in = cont_in + 1;
                }
                else
                {
                    cont_out = cont_out + 1;
                }
            }

            Console.WriteLine($"{cont_in} in");
            Console.WriteLine($"{cont_out} out");
        }
        public static void ExParaleloDoWhile()
        {
            double C, F;
            char repetir;

            do
            {
                Console.Write("Descreva a temperatura em Celsius: ");
                C = double.Parse(Console.ReadLine());
                F = 9.0 * C / 5.0 + 32.0;
                Console.WriteLine($"Equivalente em Fahreinheit: {F.ToString("F2")}");
                Console.Write("Deseja repetir (s/n)?");
                repetir = char.Parse(Console.ReadLine());
            }
            while (repetir == 's');
        }
        public static void Ex1071() 
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int min, max;
            if (x < y)
            {
                min = x;
                max = y;
            }
            else
            {
                min = y;
                max = x;
            }

            int soma = 0;
            for (int i = min + 1; i < max; i++)
            {
                if (i % 2 != 0)
                {
                    soma = soma + i;
                }
            }

            Console.WriteLine(soma);
        }
        public static void Ex1067()
        {
            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }        
        public static void Ex1078() 
        {
            int n, resultado;

            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10 ; i++) 
            {
                resultado = n * i;
                Console.WriteLine($"{i} x {n} = {resultado}");
            }
        }
        public static void ExParaleloPara() 
        {
            int n, soma = 0;

            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) 
            {
                n = int.Parse(Console.ReadLine());
                soma += 1;
            }
            Console.WriteLine($"{soma}");
        }
        public static void Ex1159()
        {
            int x = int.Parse(Console.ReadLine());

            while (x != 0)
            {

                if (x % 2 != 0)
                {
                    x = x + 1;
                }

                int soma = x + x + 2 + x + 4 + x + 6 + x + 8;
                Console.WriteLine(soma);

                x = int.Parse(Console.ReadLine());
            }
        }

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
