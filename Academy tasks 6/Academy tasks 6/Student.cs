using System;
using System.Collections.Generic;
using System.Text;

namespace Academy_tasks_6
{
    class Student
    {
        public string FullName;
        public string GroupNo;
        public int Point;

        public bool IsGraduated()
        {
            if (Point >= 65 && Point <= 100)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
