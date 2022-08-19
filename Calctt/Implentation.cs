using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calctt
{
    internal class Implentation
    {


        //-----Class Attributes
        public string Course;
        public int Unit;
        public int point;
        public string grade;

        //----Method that helps calculate total score
        public int CalcFunc(string sCourse, int ssUnit, int sPoint)
        {

            Course = sCourse;
            Unit = ssUnit;
            point = sPoint;
            int Total = Unit * point;
            return Total;


        }

        //----Method that helps calculate grade
        public string GradeCalc(int sPoint)
        {
            int pp = sPoint;

            if (pp < 0 || pp > 5)
            {
                this.grade = "Wrong Input";
            }
            else if (pp == 1)
            {
                this.grade = "E";
            }
            else if (pp == 2)
            {
                this.grade = "D";
            }else if(pp == 3)
            {
                this.grade = "C";
            }else if(pp == 4)
            {
                this.grade ="B";
            }
            else
            {
                this.grade = "A";
            }
            return this.grade;
        }
    }
}
