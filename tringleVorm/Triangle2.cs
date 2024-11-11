using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tringleVorm
{
    internal class Triangle2
    {
        public double AngleA { get; set; }
        public double AngleB { get; set; }
        public double AngleC { get; private set; }


        public Triangle2(double angleA, double angleB)
        {
            AngleA = angleA;
            AngleB = angleB;
            CalculateThirdAngle(); 
        }

        public void CalculateThirdAngle()
        {
            if (AngleA + AngleB < 180)
            {
                AngleC = 180 - (AngleA + AngleB);
            }
            else
            {
                throw new InvalidOperationException("Сумма двух углов не может быть больше или равна 180°.");
            }
        }
        public string TriangleType2
        {
            get
            {
                if (AngleA <= 0 || AngleB <= 0 || AngleC <= 0 || AngleA + AngleB + AngleC != 180)
                {
                    return "triangle doesn't exist";
                }
                else
                {
                    if (AngleA < 90 && AngleB < 90 && AngleC < 90)
                    {
                        return "terav";
                    }
                    else if (AngleA == 90 || AngleB == 90 || AngleC == 90)
                    {
                        return "täisnurkne";
                    }
                    else
                    {
                        return "nüri";
                    }
                }
            }
        }
    }
}
