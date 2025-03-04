using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{

    //class Person                                                                                  //Encapsulation
    //{
    //    private string name;
    //    public string Name
    //    {
    //        get 
    //        { 
    //            return name; 
    //        }
    //        set
    //        {
    //            name = value;
    //        }

    //    }


    //}                                                                                              //Encapsulation









    //class Animals                                                                                  //Inheritance
    //{
    //    public int num =100;
    //    public void Mammals()
    //    {
    //        Console.WriteLine("This is a group of mammals");
    //    }
    //    public void Birds()
    //    {
    //        Console.WriteLine("This is a group of Birds");
    //    }
    //    public void insects()
    //    {
    //        Console.WriteLine("This is a group of insects");
    //    }
    //}

    //class Child : Animals 
    //{
    //    public string word = "This is the child class";
    //}                                                                                            //Inheritance



    //class Vegetables                                                                               //Method Overriding
    //{
    //    public void color()
    //    {

    //        Console.WriteLine("Vegetables are mostly green");

    //    }
    //}

    //class Tomato : Vegetables 
    //{
    //    public void color()
    //    {
    //        Console.WriteLine("Tomatos are red");

    //    }
    //}                                                                                              //Method Overriding



    //abstract class Exam                                                                              //Abstraction
    //{
    //    public abstract void marks();
    //    public void grade()
    //    {
    //        Console.WriteLine("Student grades");
    //    }
    //}

    //class Student : Exam 
    //{ 
    //    public override void marks()
    //    {
    //        Console.WriteLine("Marks of student are assigned");
    //    }
    //}                                                                                               //Abstraction




    //interface Exam                                                                                  //Interface           (Multiple interface can also be used)
    //{
    //    void marks();
    //}


    //class Student : Exam
    //{
    //    public void marks()
    //    {
    //        Console.WriteLine("Student Marks are displayed");
    //    }
    //}                                                                                                //Interface




    //enum Level                                                                                       //Enum
    //{
    //    low,medium,high
    //}                                                                                                //Enum


    class Program
    {

        //string name = "Shahin";
        //int age = 24;

        //public Program()
        //{
        //    Console.WriteLine("Constructor is running");
        //}
        //public void Place()
        //{
        //    Console.WriteLine("The place is Kollam");
        //}
        static void Main(string[] args)
        {
            //Program obj = new Program();
            //Console.WriteLine(obj.name);
            //Console.WriteLine(obj.age);
            //obj.Place();



            //Person obj1 = new Person();                                                       //Encapsulation
            //obj1.Name = "Shahin(encap)";
            //Console.WriteLine(obj1.Name);                                                     //Encapsulation





            //Child obj = new Child();                                                         //Inheritance
            //obj.Mammals();
            //obj.insects();
            //Console.WriteLine(obj.num);
            //Console.WriteLine(obj.word);                                                     //Inheritance


            //Tomato obj = new Tomato();                                                         //Method overriding
            //obj.color();                                                                       //Method overriding



            //Student obj = new Student();                                                       //Abstraction
            //obj.marks();
            //obj.grade();                                                                       //Abstraction



            //Student obj = new Student();                                                       //Interface
            //obj.marks();                                                                       //Interface

            //Level var = Level.medium;                                                            //Enum            
            //Console.WriteLine(var);                                                              //Enum
            
        }
    }
}
