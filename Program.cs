using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp66
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] elements = new int[10, 10];
            Random random= new Random();

            int minNumber = 1;
            int maxNumber = 100;
            int maxElement = int.MinValue;

            for ( int i = 0; i < elements.GetLength(0); i++ )
            {
                for ( int j = 0; j < elements.GetLength(1); j++ ) 
                {
                    elements[i, j] = random.Next(minNumber, maxNumber + 1);
                   
                    if ( maxElement < elements[i,j] )
                    {
                        maxElement = elements[i,j];
                    }

                    Console.Write(elements[i, j] + " ");
                }

                Console.WriteLine();
            }
     
            Console.WriteLine(" Максимальный элемент массива " + maxElement);   

           for ( int i = 0; i < elements.GetLength(0); i++ )
            {
                for (int j = 0; j < elements.GetLength(1); j++)
                {
                    if ( maxElement == elements[i,j] )
                    {
                        elements[i, j] = 0;
                    }
                   
                    Console.Write(elements[i, j] + " ");
                }
               
                Console.WriteLine();
            }
        }
    }
}
