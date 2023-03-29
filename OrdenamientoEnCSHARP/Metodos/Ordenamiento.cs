using OrdenamientoEnCSHARP.Utlitarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenamientoEnCSHARP.Metodos
{
    public partial class Ordenamiento
    {
        public void BubbleSort<T>(T[] arr) where T : IComparable
        {
            if (arr == null)
            {
                throw new ArgumentNullException(nameof(arr));
            }

            for (int i = 1; i < arr.Length; i++)
            {

                for (int j = 0; j < arr.Length - i; j++)
                {
                    if (arr[j].CompareTo(arr[j + 1]) > 0)
                    {
                        IntercambioUtil.Intercambiar(ref arr[j], ref arr[j + 1]);
                    }
                }

            }
        }
        public void InsertionSort<T>(T[] arr) where T : IComparable
        {
            if (arr == null)
            {
                throw new ArgumentNullException(nameof(arr));
            }

            int posA;
            
            for(int i = 0;i< arr.Length; i++)
            {
                posA = i;

                while( posA>0 &&
                       arr[posA - 1].CompareTo(arr[posA])>0)
                {

                    IntercambioUtil.Intercambiar(ref arr[posA - 1],ref  arr[posA]);
                    posA--;
                }
            }
        }
        public void InsertionSortEvil<T>(T[] arr) where T : IComparable
        {
            if (arr == null)
            {
                throw new ArgumentNullException(nameof(arr));
            }

            int posA;
            T dato;

            for (int i = 0; i < arr.Length; i++)
            {
                posA = i;
                dato = arr[posA];
                while (posA > 0 &&
                       arr[posA - 1].CompareTo(dato) > 0)
                {

                    arr[posA] = arr[posA - 1];
                    posA--;
                }

                arr[posA] = dato;
            }
        }
        public void SelectionSort<T>(T[] arr) where T : IComparable
        {
            if (arr == null)
            {
                throw new ArgumentNullException(nameof(arr));
            }



            int imin = 0;

            for(int i =0;i < arr.Length;i++)
            {
                imin = i;


                for(int j = i + 1 ;j < arr.Length; j++)
                {
                    if (arr[j].CompareTo(arr[imin]) < 0)
                    {
                        imin = j;
                    }
                }
                if (i != imin)
                {
                    IntercambioUtil.Intercambiar(ref arr[i],ref arr[imin]);
                }
            }
        }
    }
}
