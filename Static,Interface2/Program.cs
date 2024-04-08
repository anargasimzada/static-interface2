using Static_Interface2.Moduls;

namespace Static_Interface2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student=new Student("Anar","Qasimzade");
            Console.WriteLine($"Student email: {student.CodeAcademy});
        }
    }
}
