using System;

namespace Ch05Ex02
{
    enum orientation : byte
    {
        north = 1,
        south = 2,
        east = 3,
        west = 4
    }
    class Program
    {
        static void Main(string[] args)
        {
            orientation myDirection = orientation.north;
            Console.WriteLine("myDirection = {0}", myDirection);


            byte directionByte;
            string directionString;
            Console.WriteLine("myDirection = {0}", myDirection);
            directionByte = (byte)myDirection;
            directionString = Convert.ToString(myDirection);
            Console.WriteLine("byte equivalent = {0}", directionByte);
            Console.WriteLine("string equivalent = {0}", directionString);
            Console.ReadKey();
        }
    }
}
