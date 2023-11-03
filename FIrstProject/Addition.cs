using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIrstProject
{
    internal class Addition
    {
        public void Add() {
            Console.Write("Enter value of A:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter value of B :");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = a + b;
            Console.WriteLine("Addition of A and B is : "+ c);
            Console.Write(c);

        }
    }
}
