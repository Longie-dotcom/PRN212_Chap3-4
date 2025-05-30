using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    public static class MyUtils
    {
        public static int TongTu1ToiN(int n)
        {
            int i = 0;
            int sum = 0;
            while (i <= n)
            {
                i++;
                sum += i;
            }
            return sum;
        }

        public static void taoMangNgauNhien(this int[] arr)
        {
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next();
            }
        }

        public static void swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        public static void sort(this int[] arr)
        {
            int i = 0;
            int j = 0;
            while (i < arr.Length)
            {
                while (j < i)
                {
                    if (arr[j] > arr[i])
                    {
                        swap(ref arr[j], ref arr[i]);
                    }
                    j++;
                }
                j = 0;
                i++;
            }
            xuatMang(arr);
        }

        public static void xuatMang(this int[] arr)
        {
            foreach (int i in arr)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();

        }
    }
}
