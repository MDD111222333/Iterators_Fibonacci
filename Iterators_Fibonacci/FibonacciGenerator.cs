using System;
using System.Collections.Generic;

namespace Iterators_Fibonacci
{
    public class FibonacciGenerator
    {
        public int TraceCount { get; private set; }

        public IEnumerable<int> Fibonacci()
        {
            TraceCount = 0;

            int previous = 0;
            int current = 1;

            while (true)
            {
                Console.WriteLine($"[трассировка] готовится число: {previous}");
                TraceCount++;

                yield return previous;

                int next = previous + current;
                previous = current;
                current = next;
            }
        }
    }
}
