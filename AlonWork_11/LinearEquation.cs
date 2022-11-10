using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlonWork_11
{
    struct LinearEquation
    {
        double k;
        double b;

        public LinearEquation(double k, double b)
        {
            this.k = k;
            this.b = b;
        }
        public string Root()
        {
            double x;
            if (k == 0 && b == 0)
            {
                return "Корень уравнения корень уравнения может принимать любое значение";
            }
            else if (k == 0 && b != 0)
            {
                return "Уравнение не имеет корней";
            }
            else if (k != 0 && b == 0)
            {
                return "Корень уравнения 0";
            }
            else if (k != 0 && b != 0)
            {
                x = -b / k;
                return $"Корень уравнения {x}";
            }   

        }
    }
}
