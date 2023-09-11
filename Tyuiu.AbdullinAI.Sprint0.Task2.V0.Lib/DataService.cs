using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.AbdullinAI.Sprint0.Task2.V0.Lib
{
    public class DataService
    {
        public static string GetMessage(string name)
        {
            return $"Привет..., {name}"; /*строка в начале начитнается с $ */
                                        /* называется интерполяция строк*/
        }
            
    }
}
