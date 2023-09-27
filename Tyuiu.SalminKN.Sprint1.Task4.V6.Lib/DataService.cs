using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.SalminKN.Sprint1.Task4.V6.Lib
{
    public class DataService : ISprint1Task4V6
    {
        public double Calculate(double x, double y)
        {

            double res = Math.Log(x * y) / (x - Math.Sqrt(1 + Math.Pow(y, 2)));

            return Math.Round(res, 3);
        }
    }
}
