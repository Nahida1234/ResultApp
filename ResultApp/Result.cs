using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResultApp
{
    internal class Result
    {
        private double physics;
        private double chemistry;
        private double math;

        public double _physics
        {

            set { physics = value; }
            get { return physics; }


        }
        public double _chemistry
        {

            set { chemistry = value; }
            get { return chemistry; }


        }
        public double _math
        {

            set { math = value; }
            get { return math; }


        }

        public double Average(double a,double b,double c)
        {
            return (a + b + c)/3;

        }

        public string Grade(double average)
        {
            if (average >= 80)
            {
                return "A+";
            }
            else if (average >= 70)
            {
                return "B+"; 
            }
            else if (average >= 60)
            {
                return "C+";
            }
            else if (average >= 50)
            {
                return "D+";
            }
            else
            {
                return "F";
            }
        }



    }
}
