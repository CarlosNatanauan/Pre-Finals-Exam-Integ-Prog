using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreFinals//Natanauan, Carlos   May 23
{

    class Circle {//for number 1
        public double getCircleDiameter(double radius)
        {
            double diameter = radius * 2;
            return diameter;
        }
    }

    struct Product//for number 2
    {
        public int code;
        public string description;
        public double price;
    }


    class Person {//for number three

        private string full_name;

        public Person() {
            Console.WriteLine("Full Name: Default Name");
        }

        public Person(string fname) {
            
            full_name = fname;
            if (full_name != "") {
            Console.WriteLine("Full Name: "+full_name);
            }  
        }
    }

    class Account {//for number four
        private int account_num;
        public Account(int num) {
            this.account_num = num;
            Console.WriteLine("Account Number: "+num);

        }
    }



    class MainClass
    {
        static void Main(string[] args)
        {
            //for number 1
            Circle one = new PreFinals.Circle();
            Console.WriteLine("Problem No.1\n");
            Console.Write("Enter the Radius   : " );
            int given = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("The Diameter of the circle is: "+one.getCircleDiameter(given));


            //for number 2
            Console.WriteLine("\nProblem No.2\n");
            Product two;
            Console.Write("Enter Code for product       : ");
            two.code = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Description for Product: ");
            two.description = Console.ReadLine();
            Console.Write("Enter price for Product      : ");
            two.price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nProduct details \nCode        : "+two.code+
            "\nDescription : "+two.description+"\nPrice       : "+two.price);


            //for number 3
            Console.WriteLine("\nProblem No.3");
            Console.Write("\nName: ");
            string fname = Console.ReadLine();

            if (string.IsNullOrEmpty(fname))
            {//this is just to avoid displaying the empty cunstructor when value is entered 
                Person three = new Person();
            }
            Person three1 = new Person(fname);

            //for number 4
            Console.WriteLine("\nProblem No.4\n");
            Console.Write("Enter Account number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Account four = new Account(num);


            Console.WriteLine("\nPress any key to exit....");
            Console.ReadKey();
        }
    }
}
