using ConsoleAppOOP1.Enums;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOP1
{
    internal class Ticket
    {
        public string MovieName;
        public Seat Seat;
        public TicketType Type;
        private double Price;
        public Ticket(string movieName, Seat seat, TicketType type,double price)
        {
            MovieName = movieName;
            Seat = seat;
            Type = type;
            Price = price;
        }
        public Ticket(string moviename) : this(moviename, new Seat(0, 'A'), TicketType.Standard, 50.0)
        {
        }
        public double CalcTotal(double taxpercent)
        {
            return Price + (Price * taxpercent / 100);
        } 
        public void ApplyDiscount(ref double discountamount)
        {
           if(discountamount>0 && discountamount <= Price)
            {
                Price -= discountamount;
                discountamount = 0;
            }
        }
        public void PrintTicket() 
        {
            Console.WriteLine("===== Ticket Info =====");
            Console.WriteLine($"Movie: {MovieName}");
            Console.WriteLine($"Seat: {Seat.Row}{Seat.Number}");
            Console.WriteLine($"Type: {Type}");
            Console.WriteLine($"Price: {Price:C}");
            Console.WriteLine(CalcTotal(Price));
            Console.WriteLine();
            //Console.WriteLine("===== After Discount =====");
            //Console.WriteLine($"Discount Before : {discoun}");
        }
    }
}
