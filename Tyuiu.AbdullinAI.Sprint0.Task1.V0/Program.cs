using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.AbdullinAI.Sprint0.Task1.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //writeline - выводит текст; Console - обращаемся к классу
            string name = "Артур";
            /*            string -строка; name - переменная*/
            int age = 17;
            //int - задает числовое значение
            Console.WriteLine("здравствуйте! Меня зовут " + name + " и мне " + age + " лет) "); 
            Console.ReadKey();
            //readkey - метод; ждет нажатия клавиши, чтобы мы увидели надпись

        }
    }
}
