namespace Dataypes_And_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte myByte = 25;//Unsigned integer
            sbyte mySbyte = -2;//Signed integer	
            int myInt = -263;//Signed integer
            uint myUint = 45;//Unsigned integer
            short myShort = 526;//Signed integer
            ushort myUShort = 63;//Unsigned integer
            long myLong = 7777777;//Signed integer
            ulong myUlong = 8654899;//Unsigned integer
            float myFloat = -3.2289f;//Single-precision floating point type
            double myDouble = -12.123;//Double-precision floating point type
            char myChar = 'A';//A single Unicode character
            bool myBool = true;//Logical Boolean type
            string myString = "Hello, World!";//A sequence of characters
            decimal myDecimal = 0.3m;//Precise fractional or integral type that can represent decimal numbers with 29 significant digits
            Console.WriteLine(myByte);
            Console.WriteLine(mySbyte);
            Console.WriteLine(myInt);
            Console.WriteLine(myUint);
            Console.WriteLine(myShort);
            Console.WriteLine(myUShort);
            Console.WriteLine(myLong);
            Console.WriteLine(myUlong);
            Console.WriteLine(myFloat);
            Console.WriteLine(myDouble);
            Console.WriteLine(myChar);
            Console.WriteLine(myBool);
            Console.WriteLine(myString);
            Console.WriteLine(myDecimal);
        }
    }
}