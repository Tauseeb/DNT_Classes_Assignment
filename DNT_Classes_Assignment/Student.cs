using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace DNT_Classes_Assignment
{
    public class Student
    {

        public string stdFirstName { get; set; }
        public string stdLastName { get; set; }
        public string stdAddress { get; set; }
        public string courese { get; set; }

        public void Adding()
        {
            
          
                Console.Write("Enter Student First Name  : ");
                stdFirstName = Console.ReadLine();
                Console.Write("Enter Studentn Last Name   : ");
                stdLastName = Console.ReadLine();
                Console.Write("Enter Student Address : ");
                stdAddress = Console.ReadLine();
                Console.Write("Enter Student Course  : ");
                courese = Console.ReadLine();

                Console.WriteLine("\n-------------------------------Student Successfully Added-------------------------------\n");
        }

        public void Listing()
        {
            List<string> userList = new List<string>();
            Console.WriteLine();
            userList.Add("Student First Name is: " + stdFirstName);
            userList.Add("Student Last Name is : " + stdLastName);
            userList.Add("Student Address is   : " + stdAddress);
            userList.Add("Student Course is    : " + courese);

            foreach (var user in userList)
            {
                Console.WriteLine(user);
            }
            Console.WriteLine();
        }

       


        static void Main(string[] args)
        {
            Student student = new Student();
            string repeat;
            do
            {
                int choice;
                Console.WriteLine("Dear User Please Enter Your Choice...\n");
                Console.WriteLine("\t 1. For Adding Student. \t\n         2. For Listing Student.\t\n         3. For Removing Student.\t\n         4. Other \t\n");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        student.Adding();
                        break;

                    case 2:
                        student.Listing();
                        break;
                  

                    default:
                        Console.WriteLine("Sorry Dear! You have selected wrong choice!!");
                        break;
                
                }
                Console.WriteLine("Do you want to repeat your program? Yes/No");
                repeat = Console.ReadLine().ToLower();
                
                Console.WriteLine();
            }
            while (repeat == "yes");
            Console.WriteLine("\nThank you !");

            Console.ReadLine();
        }
    }
}
