using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Application.Service
{
    public class TechnicalEvaluation
    {
        private int InitialValue = 1;
        private int FinalValue = 1000000;
        List<int> MaxSequence;

        public void FristQuestion()
        {
            Collatz collatz = new Collatz();

            MaxSequence = collatz.Init(InitialValue).GetSequence();

            for (int i = InitialValue + 1; i <= FinalValue; i++)
            {
                List<int> nextSequence = collatz.Init(i).GetSequence();
                if (nextSequence.Count > MaxSequence.Count)
                {
                    MaxSequence = nextSequence;
                }
            }
                
            Console.WriteLine("Resposta 1: {0}", MaxSequence.FirstOrDefault());
        }
        public void SecondQuestion()
        {
            Fibonnacci fibonnacci = new Fibonnacci();

            List<int> sequence = fibonnacci.CreateSequence(12).GetSequence();

            sequence.ForEach(i => Console.Write("{0} ", i));

            bool onlyOdd = sequence.Where(i => i % 2 == 0).Count() <= 0;

            Console.WriteLine("\nResposta 2: {0}", onlyOdd ? "A sequência acima só possui numeros impares." : "A sequência acima possui numeros pares e ímpares.");
        }


        public void thirdQuestion()
        {
            List<int> first = new List<int>
            {
                1, 3, 7, 29, 98, 234, 93
            };

            List<int> second = new List<int>
            {
                4, 6, 93, 7, 55, 32, 3
            };

            List<int> third = first.Where(i => second.Contains(i)).ToList();

            first.ForEach(i => Console.Write("{0} ", i));
            Console.WriteLine();
            second.ForEach(i => Console.Write("{0} ", i));
            Console.Write("\nResposta 3: ");
            third.ForEach(i => Console.Write("{0} ", i));
        }
    }
}
