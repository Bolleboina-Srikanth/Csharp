using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EXCEPTION_HANDLING
{
    internal class Program
    {
        public static void DivideByZeroException()
        {
            try
            {
                Console.WriteLine("Enter any number");
                int dividend = int.Parse(Console.ReadLine());
                Console.WriteLine("enter a divisor to divide");
                int divisor = int.Parse(Console.ReadLine());
                int result = dividend / divisor;
                Console.WriteLine(result);
                Console.ReadLine();
                

            }
            catch (ArithmeticException ex)
            {
               // Console.WriteLine("catch block executed");
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
            catch (FormatException ex)
            {
              //  Console.WriteLine("catch block executed");
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.Write("finally block is used to close connections");
                Console.ReadLine();

            }
        }
         static  void IndexOutOfBoundEx()
         {
            try
            {
             int[] arr = new int[5];
             Console.WriteLine("enter 5 inter numbers");
             for (int i = 0; i <= arr.Length; i++)
             {
                 arr[i] = int.Parse(Console.ReadLine());
             }
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);

            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(MinimumAccountBalance ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();

         }

       /* public static void Main(string[] args)
           {
            DivideByZeroException();
            IndexOutOfBoundEx();

           }*/
    }
}
