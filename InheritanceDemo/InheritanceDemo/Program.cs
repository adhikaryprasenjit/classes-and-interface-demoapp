using System;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Parentclass1 obj2 = new Parentclass1();
            obj2.method1();
            obj2.method4();
            obj2.method3();

            //obj2.Id = "test";
            //obj2.Id = null;

            //obj2.Id = 1;
            //obj2.Id = null;

            Console.WriteLine("---------------");

            Childclass2 obj1 = new Childclass2();
            obj1.method1();
            obj1.method2();
            obj1.method3();
            obj1.method4();

            Console.WriteLine("---------------");

            Childclass3 obj3 = new Childclass3();
            obj3.method1();
            obj3.method4();
            obj3.method3();

            //Child method 1
            //Child method 2
            //Child method 3
            //Parent method 4
            //-------------- -
            //Parent method 1
            //Parent method 4
            //Parent method 3
            //---------------
            //Child 3 method 1
            //Parent method 4
            //Child 3 method 3

        }
    }

    class Parentclass1
    {
        public Parentclass1()
        { }
        public int Id { get; set; }
        public void method1()
        {
            Console.WriteLine("Parent method 1");
        }

        public void method4()
        {
            Console.WriteLine("Parent method 4");
        }

        public void method3()
        {
            Console.WriteLine("Parent method 3");
        }
    }

    class Childclass2 : Parentclass1
    {
        public void method1()
        {
            Console.WriteLine("Child method 1");
        }

        public void method2()
        {
            Console.WriteLine("Child method 2");
        }

        private void method3()
        {
            Console.WriteLine("Child method 3");
        }
    }

    class Childclass3 : Childclass2
    {
        public void method1()
        {
            Console.WriteLine("Child 3 method 1");
        }

        public void method2()
        {
            Console.WriteLine("Child 3 method 2");
        }

        //public void method3()
        //{
        //    Console.WriteLine("Child 3 method 3");
        //}
    }
}
