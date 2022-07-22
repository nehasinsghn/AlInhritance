using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{

    /* // class member

     class withoutinheriteclass                    *//* this is simple external class*//*
     {
         public void show()                         *//*parameter less mathode*//*
         {

             Console.WriteLine("This is show mathod of withoutinherit class");
         }

     }
     // Single Inheritence
     class parentclass                        *//* this is parent class*//*
     {
         public int parentMethod(int a, int b)
         {
             int c = a + b;
             Console.Write("thie is parentMethod of parentclass");
             Console.WriteLine("and sum is {0}", c);
             return 0;
         }
     }
     class Childclass : parentclass          *//*this is inherited class with parentclass*//*
     {
         public void childMethod()
         {
             Console.WriteLine("This is childMethod of childclass");
         }
         static void Main(string[] args)
         {
             withoutinheriteclass obj = new withoutinheriteclass();  *//*ctreted obj of withoutinheriteclass*//*
             obj.show();                                             *//* call show method of withoutinheriteclass*//*


             parentclass objp = new parentclass();
             objp.parentMethod(20, 10);
             *//* objp.childmethod(); => parent obj is not called child method but child obj can called parent method*//*
             Childclass objc = new Childclass();
             objc.childMethod();
             objc.parentMethod(20, 20);
             Console.ReadLine();

         }
     } */

    // Heirerical Inheritance

   /* public class Parentclass
    {
        public void ParentMethod()
        {
            Console.WriteLine("this is Method of class A");
        }
    }
    public class Childclass1 : Parentclass
    {
        public void Child1Method()
        {
            Console.WriteLine("this is Method of class B");
        }
    }
    class Childclass2 : Parentclass
    {
        public void Child2Method()
        {
            Console.WriteLine("This is method of childclass2");
        }
        static void Main(string[] args)
        {
            Parentclass objp = new Parentclass();
            objp.ParentMethod();
            //   objp.Child1Method(); => this is not accese of child method
            // objp.ChildMethod();=> this is not access of child method

            Childclass1 objc1 = new Childclass1();
            objc1.ParentMethod();      // it can be called both child and parent method 
            objc1.Child1Method();

            Childclass2 objc2 = new Childclass2();
            objc2.ParentMethod();
            objc2.Child2Method();

            Console.ReadLine();

        }
    }*/


    // MultiLevel Inheritance

    public class A
    {
        public void MethodA()
        {
            Console.WriteLine("This is MethodA of Class A ");
        }
    }
    public class B:A
    {
        public void MethodB()
        {
            Console.WriteLine("This is MethodB of Class B ");
        }
    }
    public class C:B
    {
        public void MethodC()
        {
            Console.WriteLine("This is MethodC of Class C");
        }
        static void Main()
        {
            A objA = new A();
            objA.MethodA();
            // objA.MethodB();
            // objA.Methodc();

            B objB = new B();
            objB.MethodA();
            objB.MethodB();

            C objC = new C();
            objC.MethodA();
            objC.MethodB();
            objC.MethodC();

            Console.ReadLine();
        }
    }
}

// Multiple Inheritance AND Hybride Inheritence Used in Interface