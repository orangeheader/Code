using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    static class Calculator
    {

           static public double Calculate(double First, double Second, char Oper)
           {

            double ret = 0;
              switch (Oper)
              {

                case '+':
                    ret = Sum(First , Second);
                    break;
                case '-':
                    ret = Razn(First , Second);
                    break;
                case '*':
                    ret = Umn(First , Second);
                    break;
                case '/':
                    ret = Diff(First , Second);
                    break;

              }
            return ret;

           }

        

        static private double Sum (double First, double Second)

           {

             return First + Second;

           }


           static private double Razn(double First, double Second)

           {

            return First - Second;
 
           }

           static private double Umn(double First, double Second)

           {

            return First * Second;

           }

           static private double Diff(double First, double Second)

           {

            return First / Second;

           }





    }
}
