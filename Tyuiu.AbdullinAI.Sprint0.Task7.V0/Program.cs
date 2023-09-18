using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.AbdullinAI.Sprint0.Task7.V0.Lib;

namespace Tyuiu.AbdullinAI.Sprint0.Task7.V0
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Спринт #0 | Выполнил: Абдуллин А. И.  | АСОиУБ-23-1";
            //Длина строки 75 символов
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* Спринт #0                                                            *");
            Console.WriteLine("* Тема: Создание итогового решения по спринту                          *");
            Console.WriteLine("* Задание #7                                                           *");
            Console.WriteLine("* Вариант #0                                                           *");
            Console.WriteLine("* Выполнил: Абдуллин Артур Ильгизович | АСОиУБ-23-1                    *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                             *");
            Console.WriteLine("* Написать консольную программу на C#, которая суммирует значения двух *");
            Console.WriteLine("* одинаковых массивов по длинне.                                       *");
            Console.WriteLine("*                                                                      *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
            Console.WriteLine("************************************************************************");

            //Сама задача
            int[] arraysNums1 = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Значение эдементов массива №1 ");
            for (int i = 0; i < arraysNums1.Length; i++)
            {
                Console.Write(arraysNums1[i] + ", "); //выводим в строчку 
            }
            
            Console.WriteLine();

            Console.WriteLine("Значение эдементов массива №2");
            int[] arraysNums2 = new int[] { 1, 2, 3, 4, 5 };
            
            for (int i = 0; i < arraysNums2.Length; i++)
            {
                Console.Write(arraysNums2[i] + ", ");
            }


            Console.WriteLine();
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
            Console.WriteLine("************************************************************************");
            if (arraysNums1.Length == arraysNums2.Length)
            {
                int[] resultArray = DataService.AdditionArrays(arraysNums1, arraysNums2);

                Console.WriteLine("Сумма элементов массива равна: ");
                for (int i = 0; i < resultArray.Length; i++)
                {
                    Console.Write(resultArray[i] + ", ");
                }
            }
            else
            {
                Console.WriteLine("Ошибка! Исходные массивы имеют разное количество элементов ");
            }
            Console.ReadKey();

        }
    }
        
    
}
