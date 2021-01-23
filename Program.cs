using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> Student = new MyDictionary<int, string>();
            Student.Add(134, "John Brown");
            Student.Add(158, "Angel McCarthy");
            Student.Add(115, "Smith Terry");
            Student.Add(174, "Catherine Fisherman");
            Console.Write("Enter student number: ");
            int No = int.Parse(Console.ReadLine());
            try
            {
                Console.WriteLine(Student[No]);
            }
            catch
            {
                Console.WriteLine("Öğrenci Bulunamadı.");
            }
        }

        class MyDictionary<T1, T2>
        {
            public void Add(T1 item1, T2 item2)
            {

            }

        }
    }
}
