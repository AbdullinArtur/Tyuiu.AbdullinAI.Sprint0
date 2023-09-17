using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.AbdullinAI.Sprint0.Task6.V0.Lib
{
    public class DataService
    {
        /* Пример циклической структуры (цикл с параметрами)    for */
        public static object AdditionArray(int[] numbers)
        {
            var total = 0;
            for (var i = 0; i < numbers.Length; i++) /*i < numbers.Length; - до длины массива; i++ - инкримент(увеличивает значение) */
            {
                total = total + numbers[i];
            }
            return total;
        }
        /* Пример циклической структуры (цикл с предусловием) while */
        
        public static object SubstractionArray(int[] numbers)
        {
            var total = 0;
            int index = 0;
            while (index < numbers.Length)
            {
                total = total - numbers[index];
                index++;
            }
            return total;
        }
        /* Пример циклической структуры (цикл с постусловием) do/while  */
        
        public static object MultiplicationArray(int[] numbers)
        {
            var total = 1;
            int index = 0;
            do
            {
                total = total * numbers[index];
                index++;
            }
            while (index < numbers.Length);
            return total;
        }
    }
}   
