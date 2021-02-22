using System;

namespace Week5
{
    class Test
    {
        public static void Main(string[] args)
        {
            Rectangle rec = new Rectangle();
            rec.setWidth(5);
            rec.setHeight(7);
            Console.WriteLine(rec.getHeight());
            //Print the area of the object.
            Console.WriteLine(rec.getArea());
            //按任意一个键，返回。
            Console.ReadKey();
        }
    }
}
