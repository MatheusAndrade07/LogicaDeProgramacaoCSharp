﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.EstruturaSequencial
{
    public class Sequencial
    {
        public static void Ex1061Desafio()
        {
            int W1, X1, Y1, Z1, W2, X2, Y2, Z2, W, X, Y, Z, inicio, fim, duracao, resto;

            string[] valores = Console.ReadLine().Split(' ');
            W1 = int.Parse(valores[1]);

            valores = Console.ReadLine().Split(' ');
            X1 = int.Parse(valores[0]);
            Y1 = int.Parse(valores[2]);
            Z1 = int.Parse(valores[4]);

            valores = Console.ReadLine().Split(' ');
            W2 = int.Parse(valores[1]);

            valores = Console.ReadLine().Split(' ');
            X2 = int.Parse(valores[0]);
            Y2 = int.Parse(valores[2]);
            Z2 = int.Parse(valores[4]);

            inicio = (W1 - 1) * 24 * 60 * 60 + X1 * 60 * 60 + Y1 * 60 + Z1;
            fim = (W2 - 1) * 24 * 60 * 60 + X2 * 60 * 60 + Y2 * 60 + Z2;

            duracao = fim - inicio;

            W = duracao / (24 * 60 * 60);
            resto = duracao % (24 * 60 * 60);
            X = resto / (60 * 60);
            resto = resto % (60 * 60);
            Y = resto / 60;
            Z = resto % 60;

            Console.WriteLine(W + " dia(s)");
            Console.WriteLine(X + " hora(s)");
            Console.WriteLine(Y + " minuto(s)");
            Console.WriteLine(Z + " segundo(s)");
        }

        public static void Ex1021Desafio()
        {
            double N;
            int quociente, resto, nota, moeda;

            N = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            resto = (int)(N * 100.0 + 0.5);

            Console.WriteLine("NOTAS:");

            nota = 100;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto = resto % (nota * 100);

            nota = 50;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto = resto % (nota * 100);

            nota = 20;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto = resto % (nota * 100);

            nota = 10;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto = resto % (nota * 100);

            nota = 5;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto = resto % (nota * 100);

            nota = 2;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto = resto % (nota * 100);

            Console.WriteLine("MOEDAS:");

            moeda = 100;
            quociente = resto / moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ 1.00");
            resto = resto % moeda;

            moeda = 50;
            quociente = resto / moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ 0.50");
            resto = resto % moeda;

            moeda = 25;
            quociente = resto / moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ 0.25");
            resto = resto % moeda;

            moeda = 10;
            quociente = resto / moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ 0.10");
            resto = resto % moeda;

            moeda = 5;
            quociente = resto / moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ 0.05");
            resto = resto % moeda;

            Console.WriteLine(resto + " moeda(s) de R$ 0.01");
        }

        public static void Ex1020()
        {
            int N, anos, meses, resto, dias;

            N = int.Parse(Console.ReadLine());

            resto = N;

            anos = N / 365;
            resto = resto % 365;
            meses = resto / 30;
            dias = resto % 30;

            Console.WriteLine($"{anos} ano(s)");
            Console.WriteLine($"{meses} mes(es)");
            Console.WriteLine($"{dias} dia(s)");
        }
        public static void Ex1018()
        {
            int N, quociente, resto, nota;

            N = int.Parse(Console.ReadLine());

            Console.WriteLine(N);

            resto = N;

            nota = 100;
            quociente = resto / nota;
            Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");
            resto = resto % nota;

            nota = 50;
            quociente = resto / nota;
            Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");
            resto = resto % nota;

            nota = 20;
            quociente = resto / nota;
            Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");
            resto = resto % nota;

            nota = 10;
            quociente = resto / nota;
            Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");
            resto = resto % nota;

            nota = 5;
            quociente = resto / nota;
            Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");
            resto = resto % nota;

            nota = 2;
            quociente = resto / nota;
            Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");
            resto = resto % nota;

            Console.WriteLine($"{resto} nota(s) de R$ 1,00");

        }

        public static void Ex1019()
        {
            int N, horas, minutos, segundos, resto;

            N = int.Parse(Console.ReadLine());

            horas = N / 3600;
            resto = N % 3600;
            minutos = resto / 60;
            segundos = resto % 60;

            Console.WriteLine($"{horas}:{minutos}:{segundos}");
        }

        public static void Ex1015()
        {
            double x1, x2, y1, y2, distancia;
            string[] coletarDistanciaX, coletarDistanciaY;

            coletarDistanciaX = Console.ReadLine().Split(' ');

            x1 = double.Parse(coletarDistanciaX[0]);
            y1 = double.Parse(coletarDistanciaX[1]);

            coletarDistanciaY = Console.ReadLine().Split(' ');

            x2 = double.Parse(coletarDistanciaY[0]);
            y2 = double.Parse(coletarDistanciaY[1]);

            distancia = Math.Sqrt(Math.Pow(x1 - x2, 2.0) + Math.Pow(y2 - y1, 2.0));

            Console.WriteLine(distancia.ToString("F4", CultureInfo.InvariantCulture));
        }

        public static void Ex1013()
        {
            int valorA, valorB, valorC, maiorValorAB, maiorValorTotal;

            string[] vetor = Console.ReadLine().Split(' ');

            valorA = int.Parse(vetor[0]);
            valorB = int.Parse(vetor[1]);
            valorC = int.Parse(vetor[2]);

            maiorValorAB = (valorA + valorB + Math.Abs(valorA - valorB)) / 2;

            maiorValorTotal = (maiorValorAB + valorC + Math.Abs(maiorValorAB - valorC)) / 2;

            Console.WriteLine($"{maiorValorTotal} eh o maior");
        }

        public static void Ex1012()
        {
            double A, B, C, areaTriangulo, areaCirculo, areaTrapezio, areaQuadrado, areaRetangulo, valorPi;
            string[] vetor;

            valorPi = 3.14159;

            vetor = Console.ReadLine().Split(' ');

            A = double.Parse(vetor[0]);
            B = double.Parse(vetor[1]);
            C = double.Parse(vetor[2]);


            areaTriangulo = (A * C) / 2.0;
            areaCirculo = valorPi * Math.Pow(C, 2.0);
            areaTrapezio = ((B + A) * C) / 2.0;
            areaQuadrado = Math.Pow(B, 2.0);
            areaRetangulo = A * B;

            Console.WriteLine($"TRIANGULO: {areaTriangulo.ToString("F3")}");
            Console.WriteLine($"CIRCULO: {areaCirculo.ToString("F3")}");
            Console.WriteLine($"TRAPEZIO: {areaTrapezio.ToString("F3")}");
            Console.WriteLine($"QUADRADO: {areaQuadrado.ToString("F3")}");
            Console.WriteLine($"RETANGULO: {areaRetangulo.ToString("F3")}");

        }

        public static void Ex1011()
        {
            double resultadoVolume, raioEsfera, pi;

            pi = 3.14159;

            raioEsfera = double.Parse(Console.ReadLine());

            resultadoVolume = (4.0 / 3.0) * pi * Math.Pow(raioEsfera, 3.0);

            Console.WriteLine($"VOLUME = {resultadoVolume}");
        }

        public static void Ex1009()
        {
            string nomeFuncionario;
            double salarioFixo, vendaEfetuadasEmDinheiro, comissaoFuncionario, totalSalario;

            comissaoFuncionario = 0.15;

            nomeFuncionario = Console.ReadLine();
            salarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            vendaEfetuadasEmDinheiro = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            totalSalario = (vendaEfetuadasEmDinheiro * comissaoFuncionario) + salarioFixo;

            Console.WriteLine($"TOTAL = R$ {totalSalario.ToString("F2", CultureInfo.InvariantCulture)}");
        }

        public static void NomeIdadeParalela()
        {
            string nome1, nome2;
            int idade1, idade2;
            double media;

            string[] vetorUser1 = Console.ReadLine().Split(' ');

            nome1 = vetorUser1[0];
            idade1 = int.Parse(vetorUser1[1]);

            string[] vetorUser2 = Console.ReadLine().Split(' ');

            nome2 = vetorUser2[0];
            idade2 = int.Parse(vetorUser2[1]);

            media = (double) (idade1 + idade2) / 2.0;

            Console.WriteLine($"A idade média de {nome1} e {nome2} é de {media.ToString("F1")} anos");

        }

        public static void ExParalelo()
        {
            double baseRetangulo, alturaRetangulo, areaRetangulo, perimetroRetangulo, diagonalRetangulo;

            baseRetangulo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            alturaRetangulo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            areaRetangulo = baseRetangulo * alturaRetangulo;
            perimetroRetangulo = (baseRetangulo + alturaRetangulo) * 2.0;
            diagonalRetangulo = Math.Sqrt(Math.Pow(alturaRetangulo, 2.0) + Math.Pow(baseRetangulo, 2.0));

            Console.WriteLine($"AREA = {areaRetangulo.ToString("F4", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"PERIMETRO = {perimetroRetangulo.ToString("F4", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"DIAGONAL = {diagonalRetangulo.ToString("F4", CultureInfo.InvariantCulture)}");
        }

        public static void Ex117()
        {
            int tempoViagem, mediaKmPorHora, distancia;
            double litros;

            tempoViagem = int.Parse(Console.ReadLine());
            mediaKmPorHora = int.Parse(Console.ReadLine());

            distancia = tempoViagem * mediaKmPorHora;

            litros = (double) distancia / 12.0;

            Console.WriteLine($"{litros.ToString("F3", CultureInfo.InvariantCulture)}");
        }

        public static void Ex116()
        {
            int distanciaKm, tempoKm;

            distanciaKm = int.Parse(Console.ReadLine());

            tempoKm = distanciaKm * 2;

            Console.WriteLine($"{tempoKm} minutos");
        }

        public static void Ex114()
        {
            int distanciaPercorridaKM;
            double totalCombustivelGasto, quilometrosPorLitro;

            distanciaPercorridaKM = int.Parse(Console.ReadLine());
            totalCombustivelGasto = double.Parse(Console.ReadLine());

            quilometrosPorLitro = distanciaPercorridaKM / totalCombustivelGasto;

            Console.WriteLine($"{quilometrosPorLitro.ToString("F3")} km/l");

        }

        public static void Ex110()
        {
            int codigoPeca1, codigoPeca2, numeroPeca1, numeroPeca2;
            double valorPeca1, valorPeca2, precoTotal;


            string[] vetorPeca1 = Console.ReadLine().Split(' ');
            codigoPeca1 = int.Parse(vetorPeca1[0]);
            numeroPeca1 = int.Parse(vetorPeca1[1]);
            valorPeca1 = double.Parse(vetorPeca1[2]);

            string[] vetorPeca2 = Console.ReadLine().Split(' ');
            codigoPeca2 = int.Parse(vetorPeca2[0]);
            numeroPeca2 = int.Parse(vetorPeca2[1]);
            valorPeca2 = double.Parse(vetorPeca2[2]);

            precoTotal = (numeroPeca1 * valorPeca1) + (numeroPeca2 * valorPeca2);

            Console.WriteLine($"VALOR TOTAL A PAGAR: R$ {precoTotal.ToString("F2")}", CultureInfo.InvariantCulture);
        }

        public static void Ex108()
        {
            int numeroFuncionario, horasTrabalhadas;
            double salario, valorHoras;

            numeroFuncionario = int.Parse(Console.ReadLine());
            horasTrabalhadas = int.Parse(Console.ReadLine());
            valorHoras = double.Parse(Console.ReadLine());

            salario = horasTrabalhadas * valorHoras;

            Console.WriteLine($"NUMBER = {numeroFuncionario}");
            Console.WriteLine($"SALARY = U$ {salario.ToString("F2")}");
        }

        public static void Ex107()
        {
            int A, B, C, D, diferenca;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            D = int.Parse(Console.ReadLine());

            diferenca = (A * B) - (C * D);

            Console.WriteLine($"DIFERENCA = {diferenca}");

        }

        public static void Ex106()
        {
            double notaA, notaB, notaC, mediaNotas, pesoA, pesoB, pesoC;

            pesoA = 2;
            pesoB = 3;
            pesoC = 5;

            notaA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            notaB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            notaC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            mediaNotas = ((notaA * pesoA) + (notaB * pesoB) + (notaC * pesoC)) / (pesoA + pesoB + pesoC);

            Console.WriteLine($"MEDIA = {mediaNotas.ToString("F1", CultureInfo.InvariantCulture)}");

        }

        public static void Ex105()
        {
            double A, B, mediaNotas, pesoA, pesoB;

            pesoA = 3.5;

            pesoB = 7.5;

            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());

            mediaNotas = ((A * pesoA) + (B * pesoB)) / (pesoA + pesoB);

            Console.WriteLine($"MEDIA = {mediaNotas.ToString("F5", CultureInfo.InvariantCulture)}");

        }

        public static void Ex104()
        {
            int PROD, produto1, produto2;

            produto1 = int.Parse(Console.ReadLine());
            produto2 = int.Parse(Console.ReadLine());

            PROD = produto1 * produto2;

            Console.WriteLine($"PROD = {PROD}");
        }

        public static void Ex103()
        {
            int A, B, SOMA;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());

            SOMA = A + B;

            Console.WriteLine($"SOMA = {SOMA}");

        }

        public static void Ex102()
        {
            double area, raio, n;

            n = 3.14159;

            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = n * (Math.Pow(raio, 2));

            Console.WriteLine($"A={area.ToString("F4", CultureInfo.InvariantCulture)}");
        }


        public static void Ex101()
        {
            int A, B, X;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());

            X = A + B;

            Console.WriteLine($"X = {X}");
        }

        public static void Ex100()
        {
            Console.WriteLine("Hello World!");
        }
    }
}