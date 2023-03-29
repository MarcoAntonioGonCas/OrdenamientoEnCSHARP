using OrdenamientoEnCSHARP.Utlitarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OrdenamientoEnCSHARP.Metodos
{
    public partial class Ordenamiento
    {


        #region MargeSort
        private void MargeTemp<T>(T[] arr, int inicio, int mitad, int final) where T : IComparable
        {
            T[] temp = new T[final - inicio + 1];

            int i, j, k;
            i = j = k = 0;


            i = inicio;
            j = mitad + 1;

            while (i <= mitad && j <= final){

                if (arr[i].CompareTo(arr[j]) < 0)
                {
                    temp[k] = arr[i];
                    i++;
                }
                else
                {
                    temp[k] = arr[j];
                    j++;
                }

                k++;
            }
            while (i <= mitad)
            {
                temp[k] = arr[i];
                i++;
                k++;
            }
            while (j <= final)
            {
                temp[k] = arr[j];
                j++;
                k++;
            }

            for (k = 0; k < temp.Length; k++)
            {
                arr[inicio + k] = temp[k];
            }
        }
        private void MargeAux<T>(T[] arr, int inicio,int mitad, int final) where T : IComparable
        {
            T[] auxIzq = new T[mitad - inicio + 1];
            T[] auxDer = new T[final - mitad];

            int i, j, k = inicio;


            //for (i = 0; i < auxIzq.Length; i++)
            //{
            //    auxIzq[i] = arr[inicio + i];
            //}

            /*Otra forma de hacerlo*/
            for (i = inicio; i <=mitad ;i++)
            {
                auxIzq[i-inicio] = arr[i];
            }
            for(j = 0; j < auxDer.Length; j++)
            {
                
                auxDer[j] = arr[mitad + j+1];
            }

            i = j = 0;

            while(i< auxIzq.Length && j < auxDer.Length)
            {
                if (auxIzq[i].CompareTo(auxDer[j])<0)
                {
                    arr[k] = auxIzq[i];
                    i++;

                }
                else
                {
                    arr[k] = auxDer[j];
                    j++;
                }
                k++;
            }
            while (i < auxIzq.Length)
            {
                arr[k] = auxIzq[i];
                k++;
                i++;
            }
            while(j < auxDer.Length)
            {
                arr[k] = auxDer[j];
                k++;
                j++;
            }
        }
        private void MargeSort<T>(T[] arr,int inicio,int final) where T : IComparable
        {
            if (inicio >= final) return;

            int mitad = (inicio + final) / 2;
            MargeSort(arr, inicio, mitad);
            MargeSort(arr, mitad + 1, final);


            MargeAux(arr, inicio, mitad, final);
            /*MargeTemp(arr,inicio,mitad,final);*/

        }
        public void MargeSort<T>(T[] arr) where T : IComparable
        {
            MargeSort<T>(arr, 0, arr.Length-1);
        }

        #endregion
    }
}
