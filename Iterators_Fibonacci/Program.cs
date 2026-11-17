using System;
using System.Collections.Generic;
using System.Linq;

namespace Iterators_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            FibonacciGenerator generator = new FibonacciGenerator();

            Console.WriteLine("=== Бесконечная последовательность Фибоначчи (yield return) ===");
            Console.WriteLine("Метод Fibonacci() не принимает количество: он не знает, где закончить,");
            Console.WriteLine("и вычисляет следующее число только тогда, когда его просят.\n");

            Console.WriteLine("=== Fibonacci().Take(10) через foreach ===");

            foreach (int number in generator.Fibonacci().Take(10))
            {
                Console.WriteLine($"Получено: {number}");
            }

            Console.WriteLine();
            Console.WriteLine($"Строк трассировки: {generator.TraceCount} (ровно 10, а не бесконечно).");
            Console.WriteLine("Программа завершилась, потому что Take(10) после десятого элемента");
            Console.WriteLine("перестаёт вызывать MoveNext(), и итератор останавливается.\n");

            /*
             * Пункт 5. Почему Fibonacci().ToList() без Take подвешивает программу,
             * а Fibonacci().Take(10) — нет.
             *
             * ToList() — материализующий оператор: он перебирает источник до конца
             * и складывает всё в List<int>. У нашего Fibonacci() конца нет вообще
             * (while (true) + yield return), поэтому ToList() будет бесконечно
             * вызывать MoveNext(), добавлять числа в список и в итоге съест память
             * (OutOfMemoryException) — программа зависнет, не дойдя до конца.
             *
             * Take(10) — ленивый (отложенный) оператор: он забирает из источника
             * ровно 10 элементов и после этого сигнализирует foreach, что перебор
             * закончен. Итератор в этот момент уничтожается (вызывается Dispose),
             * и while (true) внутри Fibonacci() просто больше не продолжается.
             * Поэтому трассировка печатается 10 раз, а не бесконечно: итератор
             * останавливается ровно там, где остановился Take.
             */

            Console.WriteLine("=== Проверка: ToList() без Take не запускаем ===");
            Console.WriteLine("Fibonacci().ToList() перебирал бы последовательность до конца,");
            Console.WriteLine("а конца у неё нет — программа зависла бы. Поэтому демонстрация");
            Console.WriteLine("ограничена Take(10). Подробное объяснение — в комментарии к коду.");
        }
    }
}
