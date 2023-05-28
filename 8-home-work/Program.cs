using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _8_home_work
{
    internal class Program
    {
        // Заполнение List случайными числами в диапазоне от 0 до 100
        static void NumbersAdd(List<int> numbers)
        {
            Random random = new Random();

            for (int number = 0; number < 100; number++)
                numbers.Add(random.Next(101));
            Console.WriteLine("Выполнен NumbersAdd");
        }

        // Вывод List на экран
        static void Print(List<int> numbers)
        {
            foreach (int number in numbers)
                Console.WriteLine(number);
            Console.WriteLine("Выполнен Print");
        }

        // Удаление чисел, имеющими значение от 25 до 50
        static void Remove(List<int> numbers)
        {
            numbers.RemoveAll(number => number > 25 && number < 50);
            Console.WriteLine("Выполнен Remove");
        }

        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            NumbersAdd(numbers);
            Print(numbers);
            Remove(numbers);
            Print(numbers);
            Console.ReadKey();
        }
    }
}
