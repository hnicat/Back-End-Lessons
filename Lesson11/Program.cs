using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Lesson11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //while (true)
            //{
            //    Console.WriteLine("Select 1 to Add Student:");
            //    Console.WriteLine("Select 2 to Exit:");
            //    byte num=Convert.ToByte(Console.ReadLine());
            //    if (num == 1)
            //    {
            //        Console.WriteLine("Please Enter Your Name:");
            //        string name = Console.ReadLine();
            //        Console.WriteLine("Enter your last name if you don't mind");
            //        string surname = Console.ReadLine();
            //        Console.WriteLine("Please Enter Your Mourning:");
            //        byte age = Convert.ToByte(Console.ReadLine());
            //        Students students = new Students(name, surname, age);
            //        Console.WriteLine(Students.counter + " " + students.name + " " + students.surname + " " + students.age);
            //        Console.ReadLine();
            //    }
            //    else if( num == 2)
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("There Is No Such Option");
            //    }
            //}
            #endregion
            #region Task2
            //Console.WriteLine("If you don't mind, choose a figure");
            //string figure = Console.ReadLine();
            //string a1 = "Rectangle";
            //string a2 = "Triangle";
            //string a3 = "Circle";
            //string a4 = "Square";
            //if (figure.ToLower() == a1.ToLower())
            //{
            //    Console.WriteLine("1st please Enter the width");
            //    int a = Convert.ToInt16(Console.ReadLine());
            //    Console.WriteLine("2st please Enter the length");
            //    int b = Convert.ToInt16(Console.ReadLine());
            //    Rectangle rectangle = new Rectangle(a, b);
            //    rectangle.CalculateArea();
            //    rectangle.CalculatePerimeter();
            //    Console.WriteLine("Area: " + rectangle.Area + " Perimeter:  " + rectangle.Perimeter);
            //}
            //else if (figure.ToLower() == a2.ToLower())
            //{
            //    Console.WriteLine("Please Enter First Party:");
            //    int a = Convert.ToInt16(Console.ReadLine());
            //    Console.WriteLine("Please Enter Second Party:");
            //    int b = Convert.ToInt16(Console.ReadLine());
            //    Console.WriteLine("Enter the seat if you don't mind:");
            //    int c = Convert.ToInt16(Console.ReadLine());
            //    Console.WriteLine("Please enter pride:");
            //    int d = Convert.ToInt16(Console.ReadLine());
            //    Triangle triangle = new Triangle(a, b, c, d);
            //    triangle.CalculateArea();
            //    triangle.CalculatePerimeter();
            //    Console.WriteLine("Area: " + triangle.Area + " Perimeter:  " + triangle.Perimeter);
            //}
            //else if(figure.ToLower()==a3.ToLower())
            //{
            //    Console.WriteLine("Please Enter Radius:");
            //    int a= Convert.ToInt16(Console.ReadLine());
            //   Circle circle = new Circle(a);
            //    circle.CalculateArea();
            //    circle.CalculatePerimeter();
            //    Console.WriteLine("Area: " + circle.Area + " Perimeter:  " + circle.Perimeter);
               
            //}
            //else if(figure.ToLower()==a4.ToLower())
            //{
            //    Console.WriteLine("1st please Enter the width");
            //    int a = Convert.ToInt16(Console.ReadLine());
            //    Console.WriteLine("2st please Enter the length");
            //    int b = Convert.ToInt16(Console.ReadLine());
            //    Square square = new Square(a, b);
            //    square.CalculateArea();
            //    square.CalculatePerimeter();
            //    Console.WriteLine("Area: " + square.Area + " Perimeter:  " + square.Perimeter);
            //}
            //else
            //{
            //    Console.WriteLine("Unfortunately, such a figure was not found");
            //}
            //Console.ReadLine();
            #endregion
            Calculate calculate=new Calculate();
           double resulat= calculate.sum(21, 34, 32, 2);
            double resulat2 = calculate.multiply(2, 5, 3, 4);
            double resulat3 = calculate.differance(9, 7, 6, 5);
            double resulat4 = calculate.divide(15, 5, 3);
            Console.WriteLine(resulat+" "+resulat2+" "+resulat3+" "+resulat4);
            Console.ReadLine();
        }
    }
    //class Students
    //{
    //    public static int counter;
    //    public Students(string Name,string Surname,byte Age)
    //    {
    //        name = Name;
    //        surname = Surname;
    //        age = Age;

    //        counter++;

    //        Counter = counter;

    //    }

    //    public  string name { get; }
    //    public  string surname { get; }
    //    public  byte age { get; }
    //    public int Counter { get; set; }

    //}
    #region task2
    interface IFigure
    {
        void CalculateArea();
        void CalculatePerimeter();
    }
    abstract class Parties
    {
        protected int parties1 { get; set; }
        protected int parties2 { get; set; }
        public Parties(int prt1, int prt2)
        {
            parties1 = prt1;
            parties2 = prt2;
        }
    }
    class Rectangle : Parties, IFigure
    {
        public Rectangle(int Prt1, int Prt2) : base(Prt1, Prt2) { }

        private int _Area;
        private int _Perimeter;
        public void CalculateArea()
        {
            _Area = parties1 * parties2;
        }

        public void CalculatePerimeter()
        {
            _Perimeter = 2 * (parties1 + parties2);
        }
        public int Area
        {
            get { return _Area; }
        }
        public int Perimeter
        {
            get { return _Perimeter; }
        }
    }
    
    class Circle
    {
        public Circle(int radius)
        {
            Radius = radius;
        }
        public int Radius { get; set; }
        private double _Area;
        private double _Perimeter;
        double a = 3.14;
        public void CalculateArea()
        {

            _Area = a * (Radius * Radius);
        }
        public void CalculatePerimeter()
        {
            _Perimeter = a * (Radius + Radius);
        }
        public double Area
        {
            get { return _Area; }
        }
        public double Perimeter
        {
            get { return _Perimeter; }
        }

    } 
    class Triangle : Parties, IFigure
    {
        public Triangle(int Prt1, int Prt2, int seat, int pride) : base(Prt1, Prt2)
        {
            Seat = seat;
            Pride = pride;
        }

        public int Seat { get; set; }

        public int Pride { get; set; }
        private int _Area;
        private int _Perimeter;

        public void CalculateArea()
        {
            _Area = (parties1 * Pride) / 2;
        }

        public void CalculatePerimeter()
        {
            _Perimeter = parties1 + parties2 + Seat;
        }
        public int Area
        {
            get { return _Area; }
        }
        public int Perimeter
        {
            get
            { return _Perimeter; }
        }
    }
    class Square:Parties,IFigure
    {
        public Square(int Pries1,int Pries2):base(Pries1, Pries2)
        {

        }
        private int _Area;
        private int _Perimeter;
        public void CalculateArea()
        {
            _Area = parties1 * parties2; 
        }


        public void CalculatePerimeter()
        {
            _Perimeter = 4 * parties1;
        }
        public int Area
        {
            get { return _Area; }
        }
        public int Perimeter
        {
            get { return _Perimeter; }
        }
    }
    #endregion 
    interface ISum
    {
        double  sum(params double[] Numbers);
    }
    interface IMultiply
    {
        double multiply(params double[] Numbers);
    }
    interface IDifferance
    {
        double differance(params double[] Numbers);
    }
    interface IDivide
    {
        double divide(params double[] Numbers);
    }
 
    class Calculate:ISum,IMultiply,IDifferance,IDivide
    {
        public double sum(params double[] Numbers)
        {
            double  a = 0;
            for (int i = 0; i < Numbers.Length; i++)
            {
                a = a + Numbers[i];
            }
            return a;

        }
        public double multiply(params double[] Numbers)
        {
            double b = 1;
            for (int i=0;i < Numbers.Length; i++)
            {
                b = b * Numbers[i];
            }
            return b;
        }
        public double differance(params double[] Numbers)
        {
            double d = Numbers[0];
            for (int i = 0; i < Numbers.Length; i++)
            {
                if (i < Numbers.Length - 1)
                {
                    d = d - Numbers[i + 1];
                }
                
            }
            return d;
        }

        public double divide(params double[] Numbers)
        {
            double c = Numbers[0];
            for(int i = 0; i < Numbers.Length; i++)
            {
                if (i < Numbers.Length - 1)
                {
                    c= c / Numbers[i + 1];
                }

            }
            return c;
        }
        
       
    }
}
