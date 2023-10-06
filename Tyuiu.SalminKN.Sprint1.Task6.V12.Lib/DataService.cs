using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.SalminKN.Sprint1.Task6.V12.Lib
{

    public class DataService : ISprint1Task6V12
    {

        public bool CheckLastWordRepetiton(string value)
        {
            string stroka = value.Split(' ').Last();
            bool res = false;
            int start = value.IndexOf(stroka);
            int end = value.LastIndexOf(stroka);
            if (start != end)
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
    

