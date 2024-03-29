using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOHCAHTOABusLogic
{
    public class Angle
    {

        public double Degree(string opp, string hyp, string adj, string degree, int check)
        {

            double opposite = double.Parse(opp);
            double adjacent = double.Parse(adj);
            int hypotenuse = int.Parse(hyp);
            double teta = 0;

            if(check == 1)
            {
                teta = Math.Asin(opposite / hypotenuse) * (180 / Math.PI);
            }else if (check == 2)
            {
                teta = Math.Acos(adjacent / hypotenuse) * (180 / Math.PI);
            }
            else
            {
                teta = Math.Atan(opposite / adjacent) * (180 / Math.PI);
            }

            return Math.Round(teta,2);
        }

    }
}
