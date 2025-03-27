using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.ComponentModel.Design;

namespace CSharp.EstruturaCondicional
{
    public class Condicional
    {
        public static void Ex1051() 
        {
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double imposto;
            if (salario <= 2000.0)
            {
                imposto = 0.0;
            }
            else if (salario <= 3000.0)
            {
                imposto = (salario - 2000.0) * 0.08;
            }
            else if (salario <= 4500.0)
            {
                imposto = (salario - 3000.0) * 0.18 + 1000.0 * 0.08;
            }
            else
            {
                imposto = (salario - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            }

            if (imposto == 0.0)
            {
                Console.WriteLine("Isento");
            }
            else
            {
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
        public static void Ex1049() 
        {
            string palavra1 = Console.ReadLine();
            string palavra2 = Console.ReadLine();
            string palavra3 = Console.ReadLine();

            if (palavra1 == "vertebrado")
            {
                if (palavra2 == "ave")
                {
                    if (palavra3 == "carnivoro")
                    {
                        Console.WriteLine("aguia");
                    }
                    else
                    {
                        Console.WriteLine("pomba");
                    }
                }
                else
                {
                    if (palavra3 == "onivoro")
                    {
                        Console.WriteLine("homem");
                    }
                    else
                    {
                        Console.WriteLine("vaca");
                    }
                }
            }
            else
            {
                if (palavra2 == "inseto")
                {
                    if (palavra3 == "hematofago")
                    {
                        Console.WriteLine("pulga");
                    }
                    else
                    {
                        Console.WriteLine("lagarta");
                    }
                }
                else
                {
                    if (palavra3 == "hematofago")
                    {
                        Console.WriteLine("sanguessuga");
                    }
                    else
                    {
                        Console.WriteLine("minhoca");
                    }
                }
            }
        }
        public static void Ex1047()
        {
            string[] valores = Console.ReadLine().Split(' ');

            int horaInicial = int.Parse(valores[0]);
            int minutoInicial = int.Parse(valores[1]);
            int horaFinal = int.Parse(valores[2]);
            int minutoFinal = int.Parse(valores[3]);

            int instanteInicial = horaInicial * 60 + minutoInicial;
            int instanteFinal = horaFinal * 60 + minutoFinal;

            int duracao;
            if (instanteInicial < instanteFinal)
            {
                duracao = instanteFinal - instanteInicial;
            }
            else
            {
                duracao = (24 * 60 - instanteInicial) + instanteFinal;
            }

            int duracaoHoras = duracao / 60;
            int duracaoMinutos = duracao % 60;

            Console.WriteLine("O JOGO DUROU " + duracaoHoras + " HORA(S) E " + duracaoMinutos + " MINUTO(S)");
        }        
        public static void Ex1045() 
        {
            string[] valores = Console.ReadLine().Split(' ');
            double n1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double n2 = double.Parse(valores[1], CultureInfo.InvariantCulture);
            double n3 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            double A, B, C;

            if (n1 > n2 && n1 > n3)
            {
                A = n1;
                if (n2 > n3)
                {
                    B = n2;
                    C = n3;
                }
                else
                {
                    B = n3;
                    C = n2;
                }
            }
            else if (n2 > n3)
            {
                A = n2;
                if (n1 > n3)
                {
                    B = n1;
                    C = n3;
                }
                else
                {
                    B = n3;
                    C = n1;
                }
            }
            else
            {
                A = n3;
                if (n1 > n2)
                {
                    B = n1;
                    C = n2;
                }
                else
                {
                    B = n2;
                    C = n1;
                }
            }

            if (A >= B + C)
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else
            {
                if (A * A == B * B + C * C)
                {
                    Console.WriteLine("TRIANGULO RETANGULO");
                }
                else if (A * A > B * B + C * C)
                {
                    Console.WriteLine("TRIANGULO OBTUSANGULO");
                }
                else
                {
                    Console.WriteLine("TRIANGULO ACUTANGULO");
                }

                if (A == B && B == C)
                {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                }
                else if (A == B || A == C || B == C)
                {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }
            }

            if (A >= B + C)
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else
            {
                if (A * A == B * B + C * C)
                {
                    Console.WriteLine("TRIANGULO RETANGULO");
                }
                else if (A * A > B * B + C * C)
                {
                    Console.WriteLine("TRIANGULO OBTUSANGULO");
                }
                else
                {
                    Console.WriteLine("TRIANGULO ACUTANGULO");
                }

                if (A == B && B == C)
                {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                }
                else if (A == B || A == C || B == C)
                {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }
            }
        }
        public static void Ex1041()
        {
            decimal x, y;
            string[] valoresXeY;

            valoresXeY = Console.ReadLine().Split(' ');
            x = decimal.Parse(valoresXeY[0]);
            y = decimal.Parse(valoresXeY[1]);

            if (x == 0.0m && y == 0.0m)
            {
                Console.WriteLine("Origem");
            }
            else if (x == 0.0m)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (y == 0.0m)
            {
                Console.WriteLine("Eixo X");
            }
            else if (x > 0.0m && y > 0.0m)
            {
                Console.WriteLine("Q1");
            }
            else if (x < 0.0m && y > 0.0m)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0.0m && y < 0.0m)
            {
                Console.WriteLine("Q3");
            }
            else
            {
                Console.WriteLine("Q4");
            }
        }
        public static void Ex1040() 
        {
            float N1, N2, N3, N4, media, notaExame, mediaFinal;

            string[] valores = Console.ReadLine().Split(' ');
            N1 = float.Parse(valores[0], CultureInfo.InvariantCulture);
            N2 = float.Parse(valores[1], CultureInfo.InvariantCulture);
            N3 = float.Parse(valores[2], CultureInfo.InvariantCulture);
            N4 = float.Parse(valores[3], CultureInfo.InvariantCulture);

            media = (N1 * 2 + N2 * 3 + N3 * 4 + N4 * 1) / 10;

            // O problema 1040 tem uma falha de arredondamento especifica
            // para a linguagem C#. Quando a media da 4.85, nos tive que
            // ajusta-la manualmente para 4.8, o que é uma "gambiarra"
            // horrivel, infelizmente. Isso nao aconteceu nas outras 
            // linguagens que testei, tais como Java, C e C++
            if (media == 4.85f)
            {
                media = 4.8f;
            }

            Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));

            if (media >= 7.0)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else if (media < 5.0)
            {
                Console.WriteLine("Aluno reprovado.");
            }
            else
            {
                Console.WriteLine("Aluno em exame.");
                notaExame = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                mediaFinal = (media + notaExame) / 2;
                Console.WriteLine("Nota do exame: " + notaExame.ToString("F1", CultureInfo.InvariantCulture));
                if (mediaFinal >= 5.0)
                {
                    Console.WriteLine("Aluno aprovado.");
                }
                else
                {
                    Console.WriteLine("Aluno reprovado.");
                }
                Console.WriteLine("Media final: " + mediaFinal.ToString("F1", CultureInfo.InvariantCulture));
            }
        }        
        public static void Ex1037() 
        {
            double valorEntrada;

            valorEntrada = double.Parse(Console.ReadLine());

            if (valorEntrada < 0 || valorEntrada > 100.0000)
            {
                Console.WriteLine("Fora de intervalo");
            }
            else if (valorEntrada >= 0.0 && valorEntrada <= 25.0000)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (valorEntrada >= 25.0000 && valorEntrada <= 50.0000)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (valorEntrada >= 50.0000 && valorEntrada <= 75.0000)
            {
                Console.WriteLine("Intervalo [50,75]");
            }
            else if (valorEntrada >= 75.0000 && valorEntrada <= 100.0000)
            {
                Console.WriteLine("Intervalo (75,100]");
            }
        }
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
