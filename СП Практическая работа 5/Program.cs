using System;

namespace СП_Практическая_работа_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
        c:
            Console.Write("Введите номер задания=");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    {
                        Console.Write("Введите натуральное число (не менее трех цифр): ");
                        int numb = int.Parse(Console.ReadLine());
                        string numberString = numb.ToString();
                        int difference = numberString[1] - numberString[0];
                        //перебираем оставшиеся цифры начиная с третьей
                        for (int i = 2; i < numberString.Length; i++)
                        {
                            //проверяем явл ли разница между текущей и предыдущей цифрой равной общей разнице
                            if (numberString[i] - numberString[i - 1] != difference)
                            {
                                Console.WriteLine($"Цифры числа {numb} не образуют арифметическую прогрессию.");
                                return;
                            }
                        }
                        Console.WriteLine($"Цифры числа {numb} образуют арифметическую прогрессию с разницей {difference}.");
                        Console.ReadKey();
                    }
                    goto c;
                case 2:
                    {
                        Console.Write("Введите длину первого ноута=");
                        int l1 = int.Parse(Console.ReadLine());
                        Console.Write("Введите ширину первого ноута=");
                        int sh1 = int.Parse(Console.ReadLine());
                        Console.Write("Введите длину второго ноута=");
                        int l2 = int.Parse(Console.ReadLine());
                        Console.Write("Введите ширину второго ноута=");
                        int sh2 = int.Parse(Console.ReadLine());
                        int max_l = 0;
                        int max_sh = 0;
                        if (l1 > max_l && l1 <= l2)
                        {
                            max_l = l1;
                            Console.WriteLine($"Длина стола - {max_l}");
                        }
                        else if (l1 > max_l && l1 >= l2)
                        {
                            max_l = l1;
                            Console.WriteLine($"Длина стола - {max_l}");
                        }
                        if (sh1 > max_sh)
                        {
                            max_sh = sh1 + sh2;
                            Console.WriteLine($"Ширина стола - {max_sh}");
                        }
                        Console.ReadKey();
                    }
                    goto c;
                case 3://сдали
                    {
                        Console.Write("Введите длину каждого кольца=");
                        double K = double.Parse(Console.ReadLine());
                        Console.Write("Введите кол-во колец=");
                        int N = int.Parse(Console.ReadLine());
                        //Умножаем кол-во колец на длину каждого кольца кроме последнего, так как после него не нужно добавлять расстояние
                        double totalLength = (N - 1) * K;
                        int meters = (int)totalLength / 100; // переводим в метры
                        int centimeters = (int)totalLength % 100; // переводим в сантиметры

                        Console.WriteLine($"{meters} м {centimeters} см");
                        Console.ReadKey();
                    }
                    goto c;
                case 4:
                    {
                        // Считываем количество секторов на жестком диске и количество разделов
                        int M = int.Parse(Console.ReadLine());
                        int N = int.Parse(Console.ReadLine());

                        // Создаем массив для отслеживания занятых секторов
                        bool[] sectors = new bool[M + 1]; // индексы с 1 до M включительно

                        // Последовательно считываем и обрабатываем информацию о разделах
                        for (int i = 0; i < N; i++)
                        {
                            string[] input = Console.ReadLine().Split();
                            int start = int.Parse(input[0]);
                            int end = int.Parse(input[1]);

                            // Помечаем занятые сектора
                            for (int j = start; j <= end; j++)
                            {
                                sectors[j] = true;
                            }
                        }

                        // Считаем количество работающих операционных систем
                        int count = 0;
                        bool isOperatingSystem = false; // флаг для проверки наличия работающей ОС

                        foreach (bool sector in sectors)
                        {
                            if (sector)
                            {
                                // Если текущий сектор занят
                                if (!isOperatingSystem)
                                {
                                    // Если ОС еще не запущена, увеличиваем счетчик ОС
                                    count++;
                                    isOperatingSystem = true; // Помечаем, что ОС уже запущена
                                }
                            }
                            else
                            {
                                // Если текущий сектор свободен, сбрасываем флаг ОС
                                isOperatingSystem = false;
                            }
                        }

                        // Выводим результат
                        Console.WriteLine(count);
                        Console.ReadKey();
                    }
                    goto c;
            }
        }
    }
}
