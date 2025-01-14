using System;

namespace MainMethodAssignment
{
     class program
    {
        static void Main(stringp[] args)
        {
            //Instantiate the MathMethods2 class
            MainMethodAssignment math1 = new MathMethods2();
            //Call the first method with an int parameter
            Console.WriteLine(math1.MathOp(7));
            //Call the second method with a decimal parameter
            Console.WriteLine(math1.MathOp(7.3m));
            //Call the third method with a string parameter
            Console.WriteLine(math1.MathOp("7"));
            Console.ReadLine();
        }
    }
}
