using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Itest obj1 = new Myclass2(3);
            obj1.method2();

            obj1 = new Myclass1(3);
            obj1.method2();

            Itest2 obj2 = new Myclass2(5);
            obj2.method2();

            //Console.WriteLine(obj1.method2);
        }
    }

    public class Myclass1 : Itest
    {
        public Myclass1(int _id)
        {
            id = _id;
        }
        public int id { get; set; }
        public void method2()
        {
            Console.WriteLine(id + id);
        }
    }

    public class Myclass2 : Itest, Itest2
    {
        public Myclass2(int _id)
        {
            id2 = _id;
        }
        public int id2 { get; set; }

        public void method2()
        {
            Console.WriteLine(id2 * id2);
        }
    }

    interface Itest 
    {
        void method2();
    }

    public interface Itest2
    {
        public void method2();
        //public void method1();
    }
}
