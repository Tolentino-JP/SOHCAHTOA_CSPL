using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOHCAHTOABusLogic
{
    public class Opposite
    {

        public double Opp(string opp, string hyp, string adj, string degree, int check)
        {
            double hypotenuse = double.Parse(hyp);
            double adjacent = double.Parse(adj);
            int angle = int.Parse(degree);
            double opposite = 0;

            if(check == 1)
            {
                opposite = Math.Sin(angle * (Math.PI / 180) ) * hypotenuse;

            }
            else
            {
                opposite = Math.Tan(angle * (Math.PI / 180) ) * adjacent;
            }

            return Math.Round(opposite,2);
        }

    }
}
