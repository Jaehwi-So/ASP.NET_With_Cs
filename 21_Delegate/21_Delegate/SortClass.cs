using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_Delegate
{
    public class SortClass
    {
        // 델리게이트 CompareDelegate 선언
        public delegate int CompareDelegate(int i1, int i2);

        //정렬
        public void sort(int[] arr, CompareDelegate comp)
        {
            if (arr.Length < 2) return;
            Console.WriteLine("함수 Prototype: " + comp.Method);  //델리게이트 프로토타입 확인

            int is_change;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    is_change = comp(arr[i], arr[j]); //오름차순, 내림차순 비교
                    if (is_change == -1)
                    {
                        // 교환
                        int tmp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = tmp;
                    }
                }
            }
            display(arr);
        }
        public void display(int[] arr)
        {
            foreach (var i in arr) Console.Write(i + " ");
            Console.WriteLine();
        }
        int AscendingCompare(int i1, int i2)
        {
            if (i1 == i2) return 0;
            return (i2 - i1) > 0 ? 1 : -1;
        }
        int DescendingCompare(int i1, int i2)
        {
            if (i1 == i2) return 0;
            return (i1 - i2) > 0 ? 1 : -1;
        }
        public void test(int[] array)
        {
            CompareDelegate ascendComp = AscendingCompare;
            CompareDelegate descendComp = DescendingCompare;
            sort(array, ascendComp);
            sort(array, descendComp);
        }
    }
}
