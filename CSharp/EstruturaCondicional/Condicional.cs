using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}