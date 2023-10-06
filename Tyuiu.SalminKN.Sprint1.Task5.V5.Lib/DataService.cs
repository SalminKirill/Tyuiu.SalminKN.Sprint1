using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.SalminKN.Sprint1.Task5.V5.Lib
{
    public class DataService 
    {
        public double Calculate(double x)
        {
            double fraction = Math.Abs(x) - Math.Abs((int)x);  
            int firstDigit = (int)(fraction * 10);  
            return firstDigit;
        }
    }
}
