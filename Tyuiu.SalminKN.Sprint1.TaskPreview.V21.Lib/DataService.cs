using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.SalminKN.Sprint1.TaskPreview.V21.Lib
{
    public class DataService : ISprint1Task7V21
    {
        public double Calculate(double x, double y)
        {
            double res;
            double res1 = Math.Pow(y, x) / (Math.Cos(x) - (x / 3));
            double res2 = (Math.Sin(Math.Pow(x, 2)) + Math.Cos(y)) / (Math.Cos(x) - Math.Sin(y));
            double res33 = x * y;
            double res3 = Math.Tan(res33);
            res = res1 + res2 * res3;
            //res = (Math.Pow(y, x) / (Math.Cos(x) - x / 3) + (Math.Sin(Math.Pow(x, 2)) + (Math.Cos(y))) / (Math.Cos(x) - Math.Sin(y)) * Math.Tan(x * y));
            return res;
        }
    }
}
