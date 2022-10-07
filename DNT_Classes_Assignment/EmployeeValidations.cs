using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DNT_Classes_Assignment
{
    internal class EmployeeValidations
    {
        class Employee
        {
            string _firstName, _lastName;
            int _age;
            public string  firstName
            {
                get
                {
                    return _firstName;
                }
                set
                {
                    _firstName = value;
                }
            }

            public string lastName
            {
                get
                {
                    return _lastName;
                }
                set
                {
                    _lastName = value;
                }
            }


            public int age
            {
                get
                {
                    return _age;
                }
                set
                {
                    age = _age;
                }
            }


            public void DisplayDetails()
            {
                Console.Write("Please Enter employee first name : ");
                _firstName = Console.ReadLine();
                Console.Write("Please Enter employee last name  : ");
                _lastName = Console.ReadLine();
                Console.Write("Please Enter employee age        : ");
                _age = Convert.ToInt32(Console.ReadLine());



                if (_firstName != "")
                {
                    if(_lastName !="")
                    {
                        if(_age>=18)
                        {
                            Console.WriteLine();
                            Console.WriteLine("------------------------------------------------------------------------");
                            Console.WriteLine("Congratulation Dear."+"'"+_firstName+" "+_lastName+"'"+" Welcome To Transcend infosystem : ");
                            Console.WriteLine("------------------------------------------------------------------------");
                        }
                        else
                        {
                            Console.WriteLine("\nSorry Dear! You are not eligble for this company b'coz your age is less than 18 !!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nSorry Dear Last Name is required !");
                    }
                }
                else
                {
                    Console.WriteLine("\nSorry Dear First Name is required !");
                }

            }


        }

        public static void Main()
        {
            Employee emp = new Employee();
            emp.DisplayDetails();

            Console.ReadLine();
        }
    }
}
