﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StudentKB
{
    [Serializable]
    public class Student
    {
        public string surname;
        public string firstname;
        public int numberRecordBook;
        public Student() { }
        public Student(string sn, string fn, int nRB)
        {
            this.surname = sn;
            this.firstname = fn;
            this.numberRecordBook = nRB;
        }
        public static void sortUpSF(Student[] st, int nRecord)
        {
            Student stbool = new Student();
            int cRecord;
            int rSort;
            for (int i = 0; i < nRecord; i++)
            {
                stbool = st[i];
                cRecord = i;
                for (int j=i+1;j< nRecord; j++)
                {
                    rSort = String.Compare(st[j].surname, stbool.surname);
                    if (rSort < 0)
                    {
                        stbool = st[j];
                        cRecord = j;
                    }
                    if(rSort == 0)
                    {
                        rSort = String.Compare(st[j].firstname, stbool.firstname);
                        if (rSort < 0)
                        {
                            stbool = st[j];
                            cRecord = j;
                        }
                    }
                }
                st[cRecord] = st[i];
                st[i] = stbool;
            }

        }
        public static void cout(Student[] st,int nRecord)
        {
            for(int i = 0; i < nRecord; i++)
            {
                Console.WriteLine("Фамилия:{0},Имя:{1},Номер зачётной книжки:{2}", [i].surname, st[i].firstname, st[i].numberRecordBook);
            }
        }
    }
}
