//// OOP (Objecct Oriented Programming - Nesne Yönelimli Programlama)
//// OOP  yapısı class lar üzerinden çalışır.

//using OOP;

//Student student = new Student(); // Öğrenci yaratıldı

//student.Name = "Barış";  // Bu kısımda öğrenciye ait özellikler eklendi.
//student.Lastname = "Esen";
//student.Age = 30;
//student.StudentNo = "5560";

//// Özelliklerini vermiş olsam bile bir nesneye nesne adı vererek ekrana yazdırmam veya getirmem mümkün değildir.

////Console.WriteLine(student);
//Console.WriteLine(student.Name);
//Console.WriteLine(student.Lastname);
//Console.WriteLine(student.Age);
//Console.WriteLine(student.StudentNo);

//Teacher teacher = new Teacher()
//{
//    Name = "Eda",
//    Lastname = "Sayan"
//};

//Console.WriteLine(teacher.Name);
//Console.WriteLine(teacher.Lastname);


//class Student
//{
//    // Özelliklere property denir. prop tap tap yaparak ulaşılabilir.
//    public string Name { get; set; }
//    public string Lastname { get; set; }
//    public int Age { get; set; }
//    public string StudentNo { get; set; }
//}



// OOP, 4 ana prensibe ayrılır. 
#region 1. Encapsulation(Kapsülleme)



//Car car = new();
//car.Age = 15;//Sizin verdiğiniz değer encapsulation içindeki value'ya eşittir.
//if (car.Age < 18)
//{
//    Console.WriteLine("asasd");
//}
//else
//{
//    Console.WriteLine("asfasf");
//}
//Console.WriteLine(car.Age);

//class Car
//{
//    private int _age;

//    public int Age
//    {
//        get { return _age; }     //get metodu getirme gösterme işini yapar.
//        set
//        {
//            _age = value;
//            if (_age < 18)
//            {
//                Console.WriteLine("Reşit Değil");
//            }
//            else
//            {
//                Console.WriteLine("Reşit");
//            }
//        }
//        //set metodu değer ataması yapar, eşitler.
//    }


//}
#endregion

#region 2. Inheritance (Kalıtım)


// Inheritance da en genel snıf daha özel sınıflara miras verir. Bu sayede hem kod okunabilirliliği hem kod tekrarı hem de kod özelleştirilmesi tek sınıf üzerinden yapılır ve işler kolaylaşır.

//ElectricCar electricCar = new ElectricCar();
//electricCar.Brand; // Burada brand gelme sebebi Car sınıfının ElectiricCar sınıfına miras vermesidir.

//Student student = new Student();
//student.Name = "Batın";
//student.Selamla(student.Name);
//class BaseClass
//{
//    public string Name { get; set; }
//    public string Surname { get; set; }
//    public int Age { get; set; }
//    public void Selamla(string name)
//    {
//        name = Name;
//        Console.WriteLine("Merhaba " + name);
//    }
//}

//class Student : BaseClass
//{

//}

//class Teacher : BaseClass
//{

//}

//class Parcipal : BaseClass
//{

//}
#endregion

#region Constructor
// newlenirken ilk önce ve bir kere yapılır.

//Student student = new Student("Berkay");
//Console.WriteLine(student.Name);
//class Student
//{
//    public Student(string name)
//    {
//        Name = name;
//    }
//    public string Name { get; set; }
//}
#endregion

#region 3. Polymorphism (Çok Biçimlilik)
// Aynı method farklı şekillerde davranabilmesi anlamına gelir. Genellikle methodun override edilmesi ile sağlanır.

// Virtual anahtar kelimesi methodların override edilmesini sağlar.
// virtual ve override tarzı anahtar kelimeler kullanılırken methodun başına public yazmak gerekir.
// Base ifadesi en genel miras veren class dakini kullan anlamına gelir.

//Dog dog = new();
//Cat cat = new();
//dog.MakeSound();
//cat.MakeSound();
//class Animal
//{
//    public virtual void MakeSound()
//    {
//        Console.WriteLine("Animal Sound");
//    }

//} 
//class Dog : Animal
//{
//    public override void MakeSound()
//    {
//        Console.WriteLine("Bark Bark");
//    }
//}

//class Cat : Animal
//{
//    public override void MakeSound()
//    {
//        Console.WriteLine("Meow Meow");
//    }
//}
#endregion

#region 4. Abstraction (Soyutlama)
// Soyutlama gereksiz detayları gizleyerek yalnızca önemli özellikleri ön plana çıkarmak anlamına gelir.

// Abstract class lar new lenemez. Yani yeni bir instance ı oluşturulamaz.
//Shape shape = new Shape();

Circle circle = new();
circle.Radius = 3;
Console.WriteLine(circle.GetArea());

Rectangle rectangle = new();
rectangle.Width = 10;
rectangle.Height = 5;
Console.WriteLine(rectangle.GetArea());
abstract class Shape
{
    public abstract double GetArea();
}
class Circle : Shape
{
    public double Radius { get; set; }
    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}
class Rectangle : Shape
{
    public int Width { get; set; }
    public int Height { get; set; }
    public override double GetArea()
    {
        return (Width * Height);
    }
}
#endregion