using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOHCAHTOABusLogic
{
    public class Adjacent
    {

        public double Adj(string opp, string hyp, string adj, string degree, int check)
        {
            double opposite = double.Parse(opp);
            double hypotenuse = double.Parse(hyp);
            int angle = int.Parse(degree);
            double adjacent = 0;

            if(check == 1)
            {
                adjacent = Math.Cos(angle * (Math.PI / 180) ) * hypotenuse;
            }
            else
            {
                adjacent = opposite / Math.Tan(angle * (Math.PI / 180) );
            }

            return Math.Round(adjacent,2);
        }

    }
}
