using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] arr = { 1, 2, 3 };
                arr[2] = 4;
                Console.Write(arr[2]);
                arr[3] = 5;
                Console.Write(arr[3]);
            }
            catch (Exception e){
                throw new Exception("error", e);
            }
            finally
            {
                Console.Write("end");
            }
        }
    }
}
