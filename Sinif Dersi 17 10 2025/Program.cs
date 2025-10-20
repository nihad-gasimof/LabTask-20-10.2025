//// See https://aka.ms/new-console-template for more information
using Sinif_Dersi_17_10_2025;


//Person ali = new Person("Vuqar", "ab", -3);
//Person Nihad = new Person("Nihad", "Musayev", 33);
//Person Zakir = new Person("Zakir", "ab", -3);
//Person Vuqare = new Person("Vuqare", "ab", -3);
//Person Aydin = new Person("Aydin", "ab", -3);

//Person[] people = { ali, Nihad, Zakir, Vuqare, Aydin };
//foreach (var person in people)
//{
//    Console.WriteLine($"Name: {person.Name}, Surname: {person.Surname}, Age: {person.Age}");
//}

//Shape shape1 = new Shape("Red");
//shape1.Area = 20;
//shape1.GetInfo();



//Rectangle rectangle = new(5, "Blue");
//rectangle.GetInfo();
//Circle circle = new(9, "Red");
//circle.GetInfo();


//Vehicle vehicle = new Vehicle(2010);
//Car car = new Car("BMW", "X5", 2020, 33f, 150f);
//car.Drive(4);
//car.ShowInfo();
Liblary liblary = new Liblary("Milli Kitabxana");
Book book= new Book(1,"Xosbext Aile","Nihad Pamuk",1985);
Book book2= new Book(2,"Xosbext Baki","Murad Pamuk",1985);
Book book3= new Book(3,"Xosbext Ev","Orxan Pamuk",1985);
liblary.AddBook(book);
liblary.AddBook(book2);
liblary.AddBook(book3);
liblary.ShowBooks();
liblary.RemoveBook(2);
Console.WriteLine();
liblary.ShowBooks();