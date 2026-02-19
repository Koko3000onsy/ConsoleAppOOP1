using ConsoleAppOOP1.Enums;
using System;

namespace ConsoleAppOOP1
{
    internal class Program
    {
        static void Main()
        {
            #region p1 Q1
            //person p1 = new person();
            //p1.name = "John";
            //person p2 = new person();
            //p2= p1;
            //p2.name = "mina";
            //Console.WriteLine(p1.name);
            //Console.WriteLine(p2.name);
            #endregion
            #region p1 Q2
            //  Person p1 = new Person();
            //  p1.SetName("John");
            ////  p1.Name("mina") // this will not work because the name is private and we can only set it through the SetName method
            //  p1.age = 30;
            //  Console.WriteLine($"the age is { p1.age}");// we can access the age because it is public
            #endregion
            #region p1 Q3
            //1. new project chosse class library and name it 
            //2. add classes to the project must be public so other projects can use it.
            //3. build the library and it create dll file
            //4. open another project and add reference to the dll file of the library
            //5. Namespace must be imported using "using"
            //6. use the classes and methods of the library in the new project
            #endregion
            #region P1 Q4
            // class library is a collection of classes and methods that can be used by other projects.
            // it is a way to organize code and reuse it in different projects.
            // it can be created as a separate project in the solution and then referenced by other projects.
            // it can also be created as a dll file and then referenced by other projects.
            // use it because code reusability, maintainability, and separation of concerns.
            // it allows us to create modular code that can be easily tested and maintained.
            // it also allows us to share code between different projects and teams.

            #endregion
            #region P2
            //Console.WriteLine("Welcome to the Movie Ticket Booking System!");
            //Console.WriteLine("Please enter the movie name:");
            //string movieName = Console.ReadLine();
            //Console.WriteLine("Please select the ticket type (Standard, VIP, IMAX):");
            //TicketType type = (TicketType)Enum.Parse(typeof(TicketType), Console.ReadLine(), true);
            //Console.WriteLine("Please enter the seat number:");
            //int seatNumber = int.Parse(Console.ReadLine());
            //Console.WriteLine("Please enter the seat row:");
            //char row=char.Parse(Console.ReadLine());
            //Console.WriteLine("Please enter the price:");
            //double price = double.Parse(Console.ReadLine());
            //Console.WriteLine("Please enter the discount Amount:");
            //double discountamount = double.Parse(Console.ReadLine()); 
            //Ticket t = new Ticket(movieName,new Seat( 1, 'A'), type, price);
            //t.ApplyDiscount(ref discountamount);
            //Console.WriteLine("enter the tax %:");
            //double taxpercent = double.Parse(Console.ReadLine());
            //double total = t.CalcTotal(taxpercent);
            //Console.WriteLine($"The total price is: {total}");

            #endregion
        }














    }

}
