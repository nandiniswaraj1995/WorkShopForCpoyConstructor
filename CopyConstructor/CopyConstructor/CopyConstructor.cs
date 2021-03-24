using System;

namespace CopyConstructor
{
    class CopyConstructor
    {
        int x;
        public CopyConstructor(int i)
        {
            Console.WriteLine("Default Constructor");
            x = i;
        }
        public CopyConstructor(CopyConstructor obj)
        {
            Console.WriteLine("Cpoy constructor called");
            x = obj.x;
            }
        public void Display()
        {
            Console.WriteLine("value of x = "+x);
        }
        static void Main(string[] args)
        {
            CopyConstructor obj1 = new CopyConstructor(20);
            CopyConstructor obj2 = new CopyConstructor(obj1);//copy constructor
            obj2.Display();
            }
    }
}
