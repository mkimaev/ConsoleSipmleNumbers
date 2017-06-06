using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во чисел в диапазоне - ");
            int inputLenght = Convert.ToInt32(Console.Read());
            GetSimpleNumber_2(inputLenght);
            //GetSimpleNumber_1(inputLenght);
        }

        // версия 2
        public static void GetSimpleNumber_2(int countElements)
        {
            if (countElements > 1)
            {

                double[] array = new double[countElements];
                for (int i = 1; i < array.Length; i++)
                {
                    array[i] = i;
                }
                for (int i = 1; i <= array.Length - 1; i++)
                {
                    int badNumber = 0;
                    for (int j = 2; j < i; j++)
                    {
                        if (array[i] % j == 0) //если число может делиться на значение меньше от нашего числа
                        {
                            badNumber = i; //запоминаем это ненужное для нас число
                        }
                    }
                    if (i > 2 & array[i] != badNumber) // пропускаем 1 и 2 и пропускаем ненужное число
                    {
                        Console.WriteLine(array[i]);
                    }
                }
            }
        }
        //GetSimpleNumber_1 - это моя версия первая версия, но она не заработала полноценно
        public static void GetSimpleNumber_1(int countElements)
        {
            if (countElements > 1)
            {
                double[] array = new double[countElements];
                for (int i = 1; i < array.Length; i++)
                {
                    array[i] = i;
                }
                for (int i = 2; i < array.Length - 1; i++)
                {
                    if ((array[i] > 2) & (array[i] % 2 != 0) & (array[i] % Math.Sqrt(array[i]) != 0))
                    {
                        Console.WriteLine(array[i]);
                    }
                }
            }
        }
    }
}
