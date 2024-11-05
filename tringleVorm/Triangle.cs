using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace tringleVorm
{
    internal class Triangle
    {
        public double a;
        public double b;
        public double c;
        public double H;

        public Triangle() { }
        public Triangle(double A, double B, double C)
        {
            a = A;
            b = B;
            c = C;
        }
        public Triangle(double ha, double A)
        {
            H = ha;
            a = A;
        }

        public string TriangleType
        {
            get
            {
                if (ExistTriangle)
                {
                    if (a == b && b == c)
                    {
                        return "Равносторонний";
                    }
                    else if (a == b || b == c || a == c)
                    {
                        return "Равнобедренный";
                    }
                    else
                    {
                        return "Разносторонний";
                    }
                }
                else
                {
                    return "Не существует";
                }
            }
        }

        public string OutputA()
        {
            return Convert.ToString(a);
        }
        public string OutputB()
        {
            return Convert.ToString(b);
        }
        public string OutputC()
        {
            return Convert.ToString(c);
        }

        public double Perimeter()
        {
            double p = 0;
            p = a + b + c;
            return p;
        }
        public double Surface()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public double GetSetA
        {
            get { return a; }
            set { a = value; }
        }
        public double GetSetB
        {
            get { return b; }
            set { b = value; }
        }
        public double GetSetC
        {
            get { return c; }
            set { c = value; }
        }

        public bool ExistTriangle
        {
            get
            {
                return (a + b > c) && (a + c > b) && (b + c > a);
            }
        }
    }
}