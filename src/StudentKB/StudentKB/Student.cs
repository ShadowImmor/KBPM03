using System;
using System.Collections.Generic;
using System.Text;

namespace StudentKB
{
    class Student
    {
        string surname;
        string firstname;
        int numberRecordBook;
        Student(string sn, string fn, int nRB)
        {
            this.surname = sn;
            this.firstname = fn;
            this.numberRecordBook = nRB;
        }
    }
}
