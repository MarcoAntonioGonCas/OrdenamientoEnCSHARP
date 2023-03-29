using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenamientoEnCSHARP.Utlitarios
{
    public static class MostrarArrUtil
    {
        public static void Mostrar<T>(this T[] arr,char separador = ',')
        {
            Console.Write("[");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);

                if (i != arr.Length - 1)
                {
                    Console.Write($" {separador} ");
                }
            }
            Console.WriteLine("]");
        }
        public static string ConvertirAString<T>(this T[] arr, char separador = ',')
        {
            string str = "[";
            
            for (int i = 0; i < arr.Length; i++)
            {
                str += arr[i].ToString();

                if (i != arr.Length - 1)
                {
                    str += $" {separador} ";
                }
            }
            str += "]";
            return str;
        }
    }
}
