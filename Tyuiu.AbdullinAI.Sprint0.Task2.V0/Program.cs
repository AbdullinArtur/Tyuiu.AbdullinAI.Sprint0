using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.AbdullinAI.Sprint0.Task2.V0.Lib;

namespace Tyuiu.AbdullinAI.Sprint0.Task2.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Вызов класс DataServise и метода GetMessage*/
            /*из библиотеки Tyuiu.AbdullinAI.Sprint0.Task2.V0.Lib*/
            Console.WriteLine(DataService.GetMessage("Артур"));
            Console.ReadKey();
        }
    }
}
