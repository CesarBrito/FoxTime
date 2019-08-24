using Application.Service;
using System;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            TechnicalEvaluation te = new TechnicalEvaluation();
            te.FristQuestion();
            Console.WriteLine();
            te.SecondQuestion();
            Console.WriteLine();
            te.thirdQuestion();
            Console.ReadKey();

        }
    }
}
