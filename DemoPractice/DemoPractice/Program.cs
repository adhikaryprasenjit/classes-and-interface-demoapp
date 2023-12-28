using System;

namespace DemoPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

			//Emp objEmp1 = new Emp();
			//Emp objEmp2 = new Emp();
			//Emp objEmp3 = new Emp();
			//var x = objEmp1.GetCount();
			//var y = objEmp2.GetCount();
			//var z = objEmp3.GetCount();
			//Console.WriteLine(x);
			//Console.WriteLine(y);
			//Console.WriteLine(z);
			////x = ?

			//Function101();

			Itest2 obj = new Base101();
			obj.method2();



		}

		public static void Function101()
        {
			string str1 = "heater";
			string str2 = "reheat";
			char[] ch1 = str1.ToLower().ToCharArray();
			char[] ch2 = str2.ToLower().ToCharArray();
			Array.Sort(ch1);
			Array.Sort(ch2);
			string val1 = new string(ch1);
			string val2 = new string(ch2);
			str1 = new string(ch1);
			str2 = new string(ch2);

			if (val1 == val2)
			{
				Console.WriteLine("Both the strings are Anagrams");
				Console.WriteLine(str1);
				Console.WriteLine(str2);
			}
			else
			{
				Console.WriteLine("Both the strings are not Anagrams");
			}
		}


    }

	class Emp
	{
		private int count;

		public Emp()
		{
			count++;
		}

		public int GetCount()
		{
			return count;
		}
	}

	interface Itest1 
	{
		void method1();
	}
    interface Itest2
    {
		void method2();
    }


    public class Base101 : Itest1, Itest2
    {
		public void method1()
        {
			Console.WriteLine("print 1");
        }

		public void method2()
		{
			Console.WriteLine("print 2");
		}
	}
}
