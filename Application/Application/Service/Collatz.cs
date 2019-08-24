using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Application.Service
{
    public class Collatz
    {
        private List<int> Sequence;
        
        public Collatz Init(int number)
        {
            Sequence = new List<int>()
            {
                number
            };

            CreateSequence();

            return this;
        }

        public List<int> GetSequence()
        {
            return Sequence;
        }

        private void CreateSequence()
        {
            int item = Sequence.LastOrDefault();
            if (item > 1)
            {
                Sequence.Add(Next(item));
                CreateSequence();
            }
        }

        private int Next(int number)
        {
            return (number % 2) == 0 ? NextWithPair(number) : NextWithOdd(number);

        }

        private int NextWithPair(int number)
        {
            return number / 2;
        }

        private int NextWithOdd(int number)
        {
            
            return (3 * number) + 1;
        }
    }
}
