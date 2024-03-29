using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOHCAHTOABusLogic
{
    public class Hypotenuse
    {

        public double Hyp(string opp, string hyp, string adj, string degree, int check)
        {
            double opposite = double.Parse(opp);
            double adjacent = double.Parse(adj);
            int angle = int.Parse(degree);
            double hypotenuse = 0;

            if(check == 1)
            {
                hypotenuse = opposite / Math.Sin(angle * (Math.PI / 180) );
            }
            else
            {
                hypotenuse = adjacent / Math.Cos(angle * (Math.PI / 180) );
            }


            return Math.Round(hypotenuse,2);
        }

    }
}
