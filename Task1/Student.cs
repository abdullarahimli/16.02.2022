using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    static class Student
    {
        static public string FullName
        {
            get
            {
                return FullName;
            }
            set
            {
                Console.WriteLine("Soyadinizi daxil edin: ");
                string soyad = Console.ReadLine();
                Console.WriteLine("Adinizi daxil edin: ");
                string ad = Console.ReadLine();

                FullName = soyad + " " + ad;
            }

        }


        static public int [] GroupNo
        {
            get
            {
                return GroupNo;
            }
            set
            {
                bool check = true;
                while (check)
                {
                    if (value.Length == 4)
                    {
                        bool checkerUpperCase = false;
                        bool checkerDigit = false;

                        foreach (char item in value)
                        {
                            if (char.IsUpper(item))
                            {
                                checkerUpperCase = true;
                            }
                            else if (char.IsDigit(item))
                            {
                                checkerDigit = true;
                            }
                            if (checkerUpperCase && checkerDigit)
                            {
                                GroupNo = value;
                                check = false;
                                break;
                            }

                        }

                    }
                    else if (value.Length > 4)
                    {
                        Console.WriteLine("GroupNo yalniz 4 simvoldan ibaret ola biler.");
                    }
                    
                }
               
            }
        }
        
        static public int Age { get; set; }




       

        static public string CheckGroupNo(this int [] y)
        {
            bool check = true;
            while (check)
            {
                if (y.Length == 4)
                {
                    bool checkerUpperCase = false;
                    bool checkerDigit = false;

                    foreach (char item in y)
                    {
                        if (char.IsUpper(item))
                        {
                            checkerUpperCase = true;
                        }
                        else if (char.IsDigit(item))
                        {
                            checkerDigit = true;
                        }
                        if (checkerUpperCase && checkerDigit)
                        {
                            GroupNo = y;
                            check = false;
                            break;
                        }

                    }

                }
                else if (y.Length > 4)
                {
                    Console.WriteLine("GroupNo yalniz 4 simvoldan ibaret ola biler.");
                }

            }
        }


        static public string CheckFullName(this string x, string t)
        {
            if (x == FullName)
            {
                return FullName;
            }
        }
    }
}
