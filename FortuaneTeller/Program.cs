using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuaneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string lastName;
            int age;
            int birthMonth;
            string favroiteColor;
            int siblings;
            string travel = "";
            string location = "";

            //Users first name
            Console.WriteLine("What is your first name?");
            firstName = Console.ReadLine();

            //Users Last name
            Console.WriteLine("What is your last name?");
            lastName = Console.ReadLine();

            //Users age 
            Console.WriteLine("What is your age?");
            age = int.Parse(Console.ReadLine());

            //Users birth month
            Console.WriteLine("What month were you born?");
            birthMonth = int.Parse(Console.ReadLine());

            /*Select favorite color and if type 'help' for menu
            Please type 'Help' for more information on ROYGBIV */
            Console.WriteLine("Select your favorite ROYGIBV color? Please type 'help' for more information on ROYGBIV colors. ");
            favroiteColor = Console.ReadLine();

            if (favroiteColor == "help")
            {
                Console.WriteLine("ROYGBIV stands for: Red, Orange, Yellow, Green, Blue, Indigo, Violet.");
                Console.WriteLine("Please slect your favoite color");
                favroiteColor = Console.ReadLine();
                
            }
            else 
            {
                favroiteColor = Console.ReadLine();
            }

            //chose travel method based on color
            favroiteColor = Console.ReadLine();
            if (favroiteColor == "red")
            {
                travel ="plane";
            }
            else if (favroiteColor == "Orange")
            {
                travel = " bus";
            }
            else if (favroiteColor == "Yellow")
            {
                travel = " boat";
            }

            else if (favroiteColor == "Blue")
            {
                travel = "Car";
            }

            else if (favroiteColor == "Green")
            {
                travel = " Bike";
            }
            else if (favroiteColor == "Indigo")
            {
                travel = " Truck";
            }

            else if (favroiteColor == "Violet")
            {
                travel = "Walk";
            }

            //# of siblings 
            Console.WriteLine("Enter the number of siblings you have");
            siblings = int.Parse(Console.ReadLine());



            //Calcualte years until retirement based on even or odd years
            int retirement = 65;
            if (age <= 65)
            {
                age = retirement - age;
            }
            else
            {
                Console.WriteLine("Happy Retirement!");
            }


            //Choose vacation home based on silbings
            if (siblings > 3)
            {
                 Console.ReadLine();
            }

            else if (siblings < 0)
            {
                location=  "Gray, Indiana";
            }

            else if (siblings == 1)
            {
                location = "LA";
            }
            else if (siblings == 2)
            {
                location=" Miami";
            }
            else if (siblings == 3)
            {
                location="Maui";
            }
            //Display name, # of retirment yrs, money, vactino home and transpo. 
            Console.WriteLine(firstName + " "+ lastName + " will retire at the age of " + age + " with $" + birthMonth + ", a vacation home in " + location + " and will travel by " + travel + ".");
        }
    }
}
