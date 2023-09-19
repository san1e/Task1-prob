using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class TTriangle
    {
        protected double sideA;
        protected double sideB;
        protected double sideC;

        public TTriangle(double a, double b, double c)
        {
            if (IsValidT(a,b,c))
            {
                sideA = a; 
                sideB = b; 
                sideC = c;
            }
            else
            {
                Console.WriteLine("Трикутник не існує");
            }
        }

        //перевірка існування
        public bool IsValidT(double a, double b, double c)
        {
            return a + b > c & a + c > b & b + c > a && a > 0 && b >0 && c > 0;
        }
        //отримання сторін
        public double GetSideA()
        {
            return sideA;
        }
        public double GetSideB()
        { 
            return sideB;
        }
        public double GetSideC()
        {
            return sideC;
        }

        public void SetSideA(double a) 
        { 
            if (IsValidT(a, sideB, sideC))
            {
                sideA = a;
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
        public void SetSideB(double b) 
        {
            if (IsValidT(sideA, b, sideC))
            {
                sideB = b;
            }
            else
            {
                Console.WriteLine("Error");
            }
        }

        public void SetSideC(double c)
        {
            if (IsValidT(sideA, sideB, c))
            {
                sideC = c;
            }
            else
            {
                Console.WriteLine("Error");
            }
        }

        //обчислення периметру
        public double Per()
        {
            return sideA + sideB + sideC;
        }

        //обчислення площі Герон
       public double Area()
        {
            double s = Per() / 2;
            return Math.Sqrt(s*(s-sideA)*(s-sideB)*(s-sideC));

        }
    }
}
