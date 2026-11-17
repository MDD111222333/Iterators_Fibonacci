# C_Sharp_Iterators_Fibonacci

## C#_Iterators_Fibonacci

### Задание «Контрольная точка №38 — перечислители и итераторы (yield return)»

Вариант 2. Бесконечная последовательность Фибоначчи
1. Метод `IEnumerable<int> Fibonacci()` без параметра количества — бесконечный, через `while (true)` и `yield return`.
2. Продемонстрируйте `Fibonacci().Take(10)` через `foreach`.
3. Добавьте `Console.WriteLine` перед каждым `yield return`, обозначающий, что готовится конкретное число.
4. Продемонстрируйте, что трассировка появляется ровно 10 раз для `Take(10)`, а не бесконечно — то есть итератор реально останавливается там, где останавливается `Take`.
5. Объясните (в коде комментарием) почему `Fibonacci().ToList()` без `Take` зависает программу, а `Fibonacci().Take(10)` — не зависит.

---

### Результаты и проверочные ключи:

<img width="1515" height="315" alt="изображение" src="https://github.com/user-attachments/assets/7352307e-35d3-43a3-a801-6f01ac595d95" />



### Результат работы программы:

<img width="1401" height="1197" alt="изображение" src="https://github.com/user-attachments/assets/36a9d645-eb91-4be5-b11d-8b40306e12ff" />

