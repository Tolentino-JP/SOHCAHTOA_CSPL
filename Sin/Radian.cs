using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOHCAHTOABusLogic
{
    public class Radian
    {

        public double Rad(string opp, string hyp, string degree, int check)
        {

            double opposite = double.Parse(opp);
            int hypotenuse = int.Parse(hyp);
            double teta = int.Parse(degree);
            double radian = 0;

            if(check == 1)
            {
                radian = (opposite/hypotenuse) * (Math.PI/180);
            }
            else
            {
                radian = teta * (Math.PI / 180);
            }





            return radian;
        }

    }
}
