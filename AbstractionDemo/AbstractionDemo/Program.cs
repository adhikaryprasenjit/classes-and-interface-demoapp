using System;

namespace AbstractionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //int? id2 = null;

            mainclass obj1 = new mainclass(2);
            obj1.method1();
            obj1.method3();

            Myclass obj2 = new mainclass(2);
            obj2.method1();
            obj2.method3();


        }
    }

    public class mainclass : Myclass
    {
        public mainclass(int _id)
        {
            Id = _id;
        }
        //public int Id { get; set; }

        public new void method1()
        {
            Console.WriteLine(Id*3);
        }

        public void method2()
        {
            Console.WriteLine(Id*4);
        }
        public override void method3()
        {
            Console.WriteLine(Id * 10);
        }
    }

    public abstract class Myclass
    {
        //public Myclass(int _id)
        //{
        //    Id = _id;
        //}
        public int Id { get; set; }

        public void method1()
        {
            Console.WriteLine(Id*50);
        }

        public virtual void method3()
        {
            Console.WriteLine(Id+30);
        }

    }
}
