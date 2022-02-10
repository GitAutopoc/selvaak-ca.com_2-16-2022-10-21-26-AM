using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication_DotNet
{
    public class Summation
    {
        public Summation() { }

        public int calculate(int a, int b) 
        {
            return a + b;
        }

        public void hello(){
            Console.Write("Hello world");
        }

        public long calculate(long n1, long n2) 
        {
            return n1 + n2;
        }

        public decimal calculate(decimal num1, decimal num3) 
        {
            return num1 + num3;
        }
    }
}