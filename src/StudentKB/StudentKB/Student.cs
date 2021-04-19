using System;
using System.Collections.Generic;
using System.Text;

namespace StudentKB
{
    public class Student
    {
        public string surname;
        public string firstname;
        public int numberRecordBook;
        public Student(string sn, string fn, int nRB)
        {
            this.surname = sn;
            this.firstname = fn;
            this.numberRecordBook = nRB;
        }
    }
}
