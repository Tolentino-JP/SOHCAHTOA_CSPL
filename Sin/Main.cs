using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOHCAHTOABusLogic
{
    public class Main
    {
        Opposite oppClass= new Opposite();
        Hypotenuse hypClass = new Hypotenuse();
        Adjacent adjClass = new Adjacent();
        Angle angleClass = new Angle();
        Radian radianClass = new Radian();


        public string opposite;
        public string hypotenuse;
        public string angle;
        public string adjacent;

        public void Home()
        {

            if(opposite == "X")
            {
                Console.WriteLine($"Opposite using Sin: {oppClass.Opp(opposite, hypotenuse, adjacent, angle, 1)}");
                Console.WriteLine($"Opposite using Tan: {oppClass.Opp(opposite, hypotenuse, adjacent, angle, 2)}");
            }else if(hypotenuse == "X") 
            {
                Console.WriteLine($"Hypotenuse using Sin: {hypClass.Hyp(opposite, hypotenuse, adjacent, angle, 1)}");
                Console.WriteLine($"Hypotenuse using Cos: {hypClass.Hyp(opposite, hypotenuse, adjacent, angle, 2)}");
            }else if (adjacent == "X")
            {
                Console.WriteLine($"Adjacent using Cos: {adjClass.Adj(opposite, hypotenuse, adjacent, angle, 1)}");
                Console.WriteLine($"Adjacent using Tan: {adjClass.Adj(opposite, hypotenuse, adjacent, angle, 2)}");
            }else if(angle == "X")
            {
                Console.WriteLine($"Angle using Sin: {angleClass.Degree(opposite, hypotenuse, adjacent, angle, 1)}");
                Console.WriteLine($"Angle using Cos: {angleClass.Degree(opposite, hypotenuse, adjacent, angle, 2)}");
                Console.WriteLine($"Angle using Tan: {angleClass.Degree(opposite, hypotenuse, adjacent, angle, 3)}");
            }

            Console.WriteLine($"Radian based on opposite and hypotenuse: {radianClass.Rad(opposite, hypotenuse, angle, 1)}");
            Console.WriteLine($"Radian based on opposite and hypotenuse: {radianClass.Rad(opposite, hypotenuse, angle, 2)}");

        }

    }
}
