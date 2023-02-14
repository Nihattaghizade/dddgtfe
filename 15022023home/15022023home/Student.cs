using System;
using System.Collections.Generic;
using System.Text;

namespace _15022023home
{
    internal class Student
    {

        string _groupno;
        public int Age;
        string _fullname;

        public string GroupNo
        {
            get
            {
                return _groupno;
            }
            set
            {
                if (value.Length <= 4 && char.IsUpper(value[0]))
                {
                    _no = value;
                }
                else
                {
                    Console.WriteLine("Yazilisda sehv var");
                }
            }
        }

        public string FullName
        {
            get
            {
                return _fullname;
            }
            set
            {
                if (value.Length <= 2 && char.IsUpper(value[0]))
                {
                    _no = fullname;
                }
                else
                {
                    Console.WriteLine("Yazilisda sehv var");
                }

            }
        }

    }
}
