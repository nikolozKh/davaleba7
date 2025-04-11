using System.Runtime.InteropServices;
using System.Transactions;
//1
//Book book = new Book("Maria Stuart", "Stefan Zweig", 382, "History", 1935 );
//Book book1 = new Book();
//book.Print();
//class Book
//{
//    public string Name;
//    public string Author;
//    public int Page;
//    public string Genre;
//    public int Year;

//    public Book()
//    {

//    }
//    public Book(string name, string author, int page, string genre, int year )
//    {
//        Name = name;
//        Author = author;
//        Page = page;
//        Genre = genre;
//        Year = year;
//    }

//   public void Print()
//    {
//        Console.WriteLine($"Book Name: {Name}");
//        Console.WriteLine($"Author: {Author}");
//        Console.WriteLine($"Pages: {Page}");
//        Console.WriteLine($"Genre: {Genre}");
//        Console.WriteLine($"Published: {Year}");

//    }


//}


//2

Circle circle = new Circle(34);
circle.Print();
class Circle
{
    public double Radius;
    public double Diameter;
    public double Circumference;
    public double Area;

    public Circle()
    {

    }
    public Circle(double radius)
    {
        Radius = radius;
        Diameter = radius * 2;
        Circumference = 2 * Math.PI * radius;
        Area = Math.PI * (radius * radius);

    }

    public void Print()
    {
        Console.WriteLine($"Circle Radius = {Radius}");
        Console.WriteLine($"Circle Diameter = {Diameter}");
        Console.WriteLine($"Circle Circumference  = {Circumference}");
        Console.WriteLine($"Circle Area = {Area}");

    }
}
