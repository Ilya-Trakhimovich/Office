using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите пожалуйстa размер массива: ");

            try
            {
                int i = Int32.Parse(Console.ReadLine());
                {
                    switch (i)
                    {
                        case int k when k == 0:
                            Console.WriteLine("Ваш массив нулевой, как и вы!!!");
                            return;
                        case int k when k > 0:
                            Console.WriteLine("Вы задали правильно размерность массива. Ваш массив состоит из {0} элементов", i);
                            break;
                        case int k when k < 0:
                            Console.WriteLine("Вы ввели отрицательное число.Повторите снова ");
                            return;
                    }
                }

                int[] massiv = new int[i];

                Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("Введите нормальный размер массива ");
            }
        }
    }
}
