using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class NumberMassiv
    {
        public int Number_Massiv()
        {
            bool flag = true;
            int i = 0;

            while (flag)
            {
                bool IsNumber = Int32.TryParse(Console.ReadLine(), out i);

                if (IsNumber == true)
                {
                    if (i > 0)
                    {
                        Console.WriteLine("Вы задали правильно размерность массива. Ваш массив состоит из {0} элементов", i);

                        break;
                    }
                    else if (i == 0)
                    {
                        Console.WriteLine("Ваш массив нулевой, как и вы!!!");
                    }
                    else if (i < 0)
                    {
                        Console.WriteLine("Вы ввели отрицательное число. Повторите снова ");
                    }
                }

                if (IsNumber == false)
                {
                    Console.WriteLine("Введите нормальный формат числа для массива ");
                }
            }

            int[] massiv = new int[i];

            Console.ReadLine();
            return i;
        }
    }
}
