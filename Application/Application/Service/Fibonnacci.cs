using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Service
{
    public class Fibonnacci
    {
        private List<int> Sequence { get; set; }
        private bool normalized { get; set; }
        public Fibonnacci()
        {
            Sequence = new List<int>();
        }

        public List<int> GetSequence()
        {
            Normalize();
            return Sequence;
        }

        public void Normalize()
        {
            if (!normalized)
            {
                Sequence.RemoveAt(Sequence.Count - 1);
                Sequence.RemoveAt(Sequence.Count - 1);
                Sequence.Reverse();
                normalized = true;
            }
        }

        public Fibonnacci CreateSequence(int number)
        {
            Sequence.Add(Calculate(number));

            if (number > 0)
                CreateSequence(number - 1);

            return this;
        }

        private int Calculate(int number)
        {
            if (number <= 1)
            {
                return number;
            }
            else
            {
                return Calculate(number - 1) + Calculate(number - 2);
            }
        }
    }
}
