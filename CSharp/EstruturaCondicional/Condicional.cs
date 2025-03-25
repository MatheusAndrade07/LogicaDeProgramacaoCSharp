using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharp.EstruturaCondicional
{
    public class Condicional
    {
        public static void Ex1048() 
        {
            decimal salario, reajuste = 0.0m, diferenca;

            salario = decimal.Parse(Console.ReadLine());
            if (salario <= 400.00m)
            {
                reajuste = salario + (salario * 0.15m);
                diferenca = reajuste - salario;

                Console.WriteLine($"Novo salario: {reajuste.ToString("F2")}");
                Console.WriteLine($"Reajuste ganho: {diferenca.ToString("F2")}");
                Console.WriteLine("Em percentual: 15 %");
            }
            else if (salario >= 400.01m && salario <= 800.00m) 
            {
                reajuste = salario + (salario * 0.12m);
                diferenca = reajuste - salario;

                Console.WriteLine($"Novo salario: {reajuste.ToString("F2")}");
                Console.WriteLine($"Reajuste ganho: {diferenca.ToString("F2")}");
                Console.WriteLine("Em percentual: 12 %");
            }
            else if (salario >= 800.01m && salario <= 1200.00m)
            {
                reajuste = salario + (salario * 0.10m);
                diferenca = reajuste - salario;

                Console.WriteLine($"Novo salario: {reajuste.ToString("F2")}");
                Console.WriteLine($"Reajuste ganho: {diferenca.ToString("F2")}");
                Console.WriteLine("Em percentual: 10 %");
            }
            else if (salario >= 1200.01m && salario <= 2000.00m)
            {
                reajuste = salario + (salario * 0.07m);
                diferenca = reajuste - salario;

                Console.WriteLine($"Novo salario: {reajuste.ToString("F2")}");
                Console.WriteLine($"Reajuste ganho: {diferenca.ToString("F2")}");
                Console.WriteLine("Em percentual: 7 %");
            }
            else if (salario > 2000.00m)
            {
                reajuste = salario + (salario * 0.04m);
                diferenca = reajuste - salario;

                Console.WriteLine($"Novo salario: {reajuste.ToString("F2")}");
                Console.WriteLine($"Reajuste ganho: {diferenca.ToString("F2")}");
                Console.WriteLine("Em percentual: 4 %");
            }

        }

        public static void Ex1046() 
        {
            int horaInicial, horaFinal, duracao;
            string[] vetor;

            vetor = Console.ReadLine().Split(' ');

            horaInicial = int.Parse(vetor[0]);
            horaFinal = int.Parse(vetor[1]);

            if (horaFinal > horaInicial) 
            {
                duracao = horaFinal - horaInicial;

                Console.WriteLine($"O JOGO DUROU {duracao} HORA(S)");
            }
            else if (horaFinal <= horaInicial) 
            {
                duracao = (24 - horaInicial) + horaFinal;
                Console.WriteLine($"O JOGO DUROU {duracao} HORA(S)");
            }

        }
        public static void Ex1044() 
        {
            int A = 0, B = 0;
            string[] vetor;

            vetor = Console.ReadLine().Split(' ');
            A = int.Parse(vetor[0]);
            B = int.Parse(vetor[1]);

            if (A % B == 0 || B % A == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else 
            {
                Console.WriteLine("Nao sao Multiplos");
            }

        }
        public static void Ex1039()
        {
            decimal precoCachorroQuente = 4.00m, precoXSalada = 4.50m, precoXBacon = 5.00m,
                precoTorradaSimples = 2.0m, precoRefrigerante = 1.50m, preco = 0.0m, total = 0.0m;
            int codigo, quantidade;

            string[] vetor;

            vetor = Console.ReadLine().Split(' ');

            codigo = int.Parse(vetor[0]);
            quantidade = int.Parse(vetor[1]);


            switch (codigo) 
            {
                case 1:
                    preco = precoCachorroQuente;
                    break;
                case 2:
                    preco = precoXSalada;
                    break;
                case 3:
                    preco = precoXBacon;
                    break;
                case 4:
                    preco = precoTorradaSimples;
                    break;
                case 5:
                    preco = precoRefrigerante;
                    break;
                default:
                    Console.WriteLine("Insira um valor válido!!");
                    return;
            }

            total = quantidade * preco;

            Console.WriteLine($"Total: R$ {total.ToString("F2")}");            
        }

        public static void Ex1035()
        {
            int A, B, C, D;
            string[] vetor;

            vetor = Console.ReadLine().Split(' ');

            A = int.Parse(vetor[0]);
            B = int.Parse(vetor[1]);
            C = int.Parse(vetor[2]);
            D = int.Parse(vetor[3]);

            if (B > C && D > A && C + D > A + B && C > 0 && D > 0 && A % 2 == 0)
            {
                Console.WriteLine("Valores aceitos");
            }
            else 
            {
                Console.WriteLine("Valores nao aceitos");
            }

        }
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
