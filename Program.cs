using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public  class Program
    {


          public static void Main(string[] args)
          {
        Console.WriteLine("-------*******--------");
        Console.WriteLine("prees 1 to enter friends names");
        Console.WriteLine("prees 2 for sq of numbers");
        Console.WriteLine("prees 3 to enter place name");
        Console.WriteLine("prees 4 to print a number 10 times");
        Console.WriteLine("prees 5 to enter random numbers");
        Console.WriteLine("prees 6 to calculate area of circle");
            Console.WriteLine("prees 7 to print numbers divisible by 7 not by 5");
            Console.WriteLine("prees 8 to find factorial of a number");
            Console.WriteLine("prees 9 to print 1-100");
            Console.WriteLine("prees 10 to find quadratic roots");
            Console.WriteLine("prees 11 to convert number to string");
            Console.WriteLine("prees 12 to find characters present");
            Console.WriteLine("prees 13 to find average of array               ");
            Console.WriteLine("prees 14 to find array of prime numbers");
            Console.WriteLine("prees 15 to shift zeros to right");
            Console.WriteLine("prees 16 to delete an element in an array");
            Console.WriteLine("prees 17 to remove duplicate element in array");
            Console.WriteLine("prees 18 to find smallest gap in array");
            Console.WriteLine("prees 19 to square root");
            Console.WriteLine("prees 20 to days into years");
            Console.WriteLine("prees 21 to inheritance");
            Console.WriteLine("prees 22 to find bubble sort ");



          int choice = int.Parse(Console.ReadLine());
              switch(choice)
              {
                  case 1:
                   new FriendsName().meth1();
                      break;
                  case 2:
                      new SquareOfNumbers().meth5();
                      break;
                  case 3:
                      new PlaceName().meth2();
                      break;
                  case 4:
                    new  PrintNumber10Times().print();
                      break;
                  case 5:
                     new RandomNumbers().meth6();
                      break;
                  case 6:
                      new Circle().meth7();
                      break;
                  case 7:
                      new DivisibleBySeven();
                      break;
                  case 8:
                      new Factorial();
                      break;
                  case 9:
                      new PrintNumbers1To100();
                      break;
                  case 10:
                      new QuadraticEquation();
                      break;
                  case 11:
                    new NUmberToString().String();
                          break;
                  case 12:
                    new CharactersPresent().print();
                      break;
                case 13:
                    new FloatArray().FloatArrays();
                    break;
                  case 14:
                  new ArrayOfPrime().primeNumbers();
                      break;
                case 15:
                    new ShiftZeroToRight();
                    break;
                case 16:
                    new DeletionOfElement().delete();
                    break;
                case 17:
                    new RemoveDuplicateElements().removeElements();
                    break;
                case 18:
                    new SmallestGapInArray().smallestGap();
                    break;
                case 19:
                    new SquareRoot().squareRoot();
                    break;
                  case  20:
                      new DaysInToYears().days();
                      break;
                  case 21:
                      new InheritanceB().meth1();
                      break;
                  case 22:
                      new BubbleSort();
                      break;
              }
            Console.WriteLine("---------**********************------------");
            Console.Read();
          }
    }

}