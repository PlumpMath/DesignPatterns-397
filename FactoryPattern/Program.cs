using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the type of polynomial Triangle/Rectangle :");
            string name = Console.ReadLine();

            Console.WriteLine("Input param1 and param2 :");
            double[] parameters = Array.ConvertAll(Console.ReadLine().Split(' '), Double.Parse);  
            PolynomialsFactory factory = new PolynomialsFactory();

            IPolynomial polynomial = factory.GetPolynomial(name);

            Console.WriteLine("Area of polynomial : " + polynomial.area(parameters[0],parameters[1]));

            Console.ReadLine();
        }
    }

    class PolynomialsFactory
    {
        public IPolynomial GetPolynomial(string name)
        {
            switch (name)
            {
                case "Triangle": return new Triangle();
                case "Rectangle": return new Rectangle();
                default: return null;
            }

        }
    }

    class Triangle : IPolynomial
    {
        public double area(double param1, double param2)
        {
            return 0.5 * param1 * param2;
        }
    }

    class Rectangle : IPolynomial
    {
        public double area(double param1, double param2)
        {
            return param1 * param2;
        }
    }
}
