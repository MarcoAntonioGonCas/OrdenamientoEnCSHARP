using OrdenamientoEnCSHARP.Metodos;
using OrdenamientoEnCSHARP.Utlitarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenamientoEnCSHARP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Ordenamiento ordenamiento = new Ordenamiento();
            int[] arrDes = { 4, 3, 2, 1 };
            arrDes.Mostrar();
            ordenamiento.MargeSort(arrDes);
            arrDes.Mostrar();
        }
    }
}
