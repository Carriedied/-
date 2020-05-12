using System;

namespace Кортежи
{
    class Program
    {
        static void Main(string[] args)
        {
            Tuple<string, int, string>[] tuples =
            {
                Tuple.Create("A",5,"B"),
                Tuple.Create("A",9,"D"),
                Tuple.Create("B",5,"A"),
                Tuple.Create("B",9,"E"),
                Tuple.Create("C",7,"D"),
                Tuple.Create("C",8,"E"),
                Tuple.Create("D",9,"A"),
                Tuple.Create("D",7,"C"),
                Tuple.Create("D",6,"E"),
                Tuple.Create("E",9,"B"),
                Tuple.Create("E",8,"C"),
                Tuple.Create("E",6,"D")
            };
            Console.WriteLine("Введите номер задания");
            int n = 0;
            while (n != 5)
            {
                Console.WriteLine(
                    "1. Все города системы\n" +
                    "2. Самые близкие города, между которыми есть связь хотя бы в одну сторону\n" +
                    "3. Самые далекие города, между которыми есть связь хотя бы в одну сторону\n" +
                    "4. Сумма всех направлений\n" +
                    "5. Выход");
                string num = Console.ReadLine();
                if (String.IsNullOrEmpty(num))
                {
                    Console.WriteLine("Введите номер задания еще раз");
                }
                else
                {
                    n = Convert.ToInt32(num);
                    Class1 cl = new Class1();
                    switch (n)
                    {
                        case 1:
                            for (int i = 0; i < 5; i++)
                            {
                                string[] arr = cl.ShowCities(tuples);
                                Console.WriteLine(arr[i]);
                            }
                            break;
                        case 2:
                            cl.Minimal(tuples);
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                        case 5:
                            break;
                    }
                }
            }
        }
    }
}
