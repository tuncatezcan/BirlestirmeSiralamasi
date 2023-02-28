using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirleştirmeSıralaması
{
    class Program
    {

        //Bu algoritma, bir tamsayı dizisini sıralamak için bir böl ve
        //fethet yaklaşımı kullanan popüler bir sıralama algoritması olan
        //birleştirme sıralama algoritmasını uygular.
        //Diziyi daha küçük alt dizilere böler, bu alt dizileri sıralar
        //ve sonra tekrar bir araya getirir.
        //Algoritmanın zaman karmaşıklığı O(n log n)'dir,
        //bu da onu büyük diziler için çok verimli kılar.
        static void Main(string[] args)
        {
            int[] array = { 3, 5, 7, 2, 1, 9, 8, 4, 6 };
            MergeSort(array, 0, array.Length - 1);
            Console.WriteLine("Sorted Array:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.ReadKey();
        }

        static void MergeSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;
                MergeSort(array, left, middle);
                MergeSort(array, middle + 1, right);
                Merge(array, left, middle, right);
            }
        }

        static void Merge(int[] array, int left, int middle, int right)
        {
            int[] temp = new int[array.Length];
            int i, j, k;
            i = left;
            j = middle + 1;
            k = left;
            while (i <= middle && j <= right)
            {
                if (array[i] < array[j])
                {
                    temp[k] = array[i];
                    i++;
                }
                else
                {
                    temp[k] = array[j];
                    j++;
                }
                k++;
            }
            while (i <= middle)
            {
                temp[k] = array[i];
                i++;
                k++;
            }
            while (j <= right)
            {
                temp[k] = array[j];
                j++;
                k++;
            }
            for (int x = left; x <= right; x++)
            {
                array[x] = temp[x];
            }
        }
    }

}
