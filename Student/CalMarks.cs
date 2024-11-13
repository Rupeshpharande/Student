using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    internal class CalMarks
    {

        //data members
        int Rollno;
        string Name;
        double Sub1, Sub2, Sub3, Sum,Percentage;

        
        public CalMarks(int rollno,string nm,double s1,double s2,double s3)
        {
            Rollno = rollno;
            Name = nm;
            Sub1 = s1;
            Sub2 = s2;  
            Sub3 = s3;
        }
        //calculate marks
        public void Calculate()
        {
            Sum = Sub1 + Sub2 + Sub3;
            Percentage = Sum/3;
        }
        //display 
        public string Print()
        {
            return $"RollNo={Rollno},Name={Name}, Percentage={Percentage}";
        }
    }
}
