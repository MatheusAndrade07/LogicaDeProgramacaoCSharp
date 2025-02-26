using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.EstruturaCondicional
{
    public class Condicional
    {
        public static void ExParaleloEC(string[] args)
        {
            double notaPrimeiroSemestre, notaSegundoSemestre, mediaTotal;

            Console.WriteLine("DIGITE SUA NOTA DO PRIMEIRO SEMESTRE: ");

            notaPrimeiroSemestre = double.Parse(Console.ReadLine());

            if (notaPrimeiroSemestre == null)
            {
                Console.WriteLine("DIGITE SUA NOTA!!");
            }

            Console.WriteLine("DIGITE SUA NOTA DO SEGUNDO SEMESTRE: ");

            notaSegundoSemestre = double.Parse(Console.ReadLine());

            if (notaSegundoSemestre == null)
            {
                Console.WriteLine("DIGITE SUA NOTA!!");
            }

            mediaTotal = (notaPrimeiroSemestre + notaSegundoSemestre) / 2.0;

            if (mediaTotal > 60.0)
            {
                Console.WriteLine($"SUA NOTA FINAL FOI {mediaTotal.ToString("F1")} PARABÉNS VOCÊ PASSOU!!");
            }
            else
            {
                Console.WriteLine($"SUA NOTA FINAL FOI {mediaTotal.ToString("F1")} VOCÊ ESTÁ DE RECUPERAÇÃO!!");
            }

        }
    }
}
