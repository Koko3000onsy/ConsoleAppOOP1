namespace ConsoleAppOOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region p1 Q1
            person p1 = new person();
            p1.name = "John";
            person p2 = new person();
            p2= p1;
            p2.name = "mina";
            Console.WriteLine(p1.name);
            Console.WriteLine(p2.name);
        }
        #endregion
    }
}
