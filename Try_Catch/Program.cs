
//int n = int.MaxValue;
//int m = int.MaxValue;
//int p = n + m;

//try
//{
//    string mystring = default;  // string.Empty =>""
//    mystring.Insert(0, "hello");

//    int i = 20;
//    int j = 0;
//    object value = default; int result = DivideNumber(i, j);

//    object obj = default;
//    int i2 = (int)obj;
//    // Suspect of casting error
//}
//catch (InvalidCastException ex)
//{
//    Console.WriteLine("Invalid casting. {0}", ex.Message);
//}
//catch (StackOverflowException ex)
//{
//    Console.WriteLine("Overflow. {0}", ex.Message);
//}
//catch (DivideByZeroException ex)
//{
//    Console.WriteLine("Attempted divide by zero. {0}", ex.Message);
//}
//catch(Exception ex)
//{
//    Console.WriteLine("General exceotion. {0}", ex.Message);
//}

//static  int DivideNumber(int num1, int num2)
//{
//    if (num1 < num2)

//        num1 += 20;
//        return num1 / num2;

//}
using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace Try_Catch
{
    class Student
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public int EnrollNumbert { get; set; }
    }
    public class Program
    {
        private static object student;

        public delegate void Makrid(string massage);
        public delegate TResult MyDelegate<T, TResult>(T value);
        public static void Main(string[] args)
        {
            Makrid makrid = new Makrid(MakridToConsole);

            makrid.Invoke("Krug");

            MyDelegate<int, int> myDelegate = new MyDelegate<int, int>(Increment);
            Console.WriteLine(myDelegate(1));

            List<Student> students = new()
            {
                new() { Age =24,Name ="Farxod", EnrollNumbert = 1002},
                new() { Age = 27, Name = "Rasul", EnrollNumbert= 2001},
            };

            Func<Student, string> stdNam = student => student.Name;
            IEnumerable<string> studentsNames = students.Select(stdNam);

            foreach (var name in studentsNames)
            {
                Console.WriteLine(name);
            }
            Action<Student> studentAction = student => Console.WriteLine(student.Name);
            students.ForEach(studentAction);

            Predicate<Student> isAdult = student => student.Age > 18;
            List<Student> adultStudents = students.FindAll(isAdult);

            foreach (var item in adultStudents)
            {
                Console.WriteLine(student);
            }
            
        }
        public static void MakridToConsole(string massage)
        {
            Console.WriteLine(massage);
        }
        public static int Increment(int arg)
        {
            return ++arg;
        }
    }
}
