using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Left_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {        

            int[]  a = new int[5] { 1, 2, 3, 4, 5 };
            int d = Convert.ToInt32(2);

            int[] result = rotLeft(a, d);

            Console.Write(result);
            Console.Read();
        }

        static int[] rotLeft(int[] a, int d)
        {
            /*  for (int x = 1; x <= d; x++)
              {
                  List<int> lst = a.OfType<int>().ToList();
                  lst.RemoveAt(0);
                  lst.Add(a[0]);
                  a = lst.ToArray();
              }*/

            /*for (int x=1;x<=d;x++)
            {
                int[] temporal = new int[a.Length];
                temporal[a.Length-1] = a[0];
                for(int i=1;i<a.Length;i++)
                {
                    temporal[i - 1] = a[i];
                }
                a = temporal;
            }*/

            /* for (int x=1;x<=d;x++)
             {               
                 int tem = a[0];
                 for(int i=1;i<a.Length;i++)
                 {
                     a[i - 1] = a[i];
                 }
                 a[a.Length-1] = tem;
             }*/
            int[] temporal = (int[]) a.Clone();        

            for (int i = 0; i < a.Length; i++)
            {
                int newLocation = (i + (a.Length - d)) % a.Length;
                a[newLocation] = temporal[i];
            }
            return a;
        }
    }
}
