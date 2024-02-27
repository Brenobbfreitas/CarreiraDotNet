using Balta.ContentContext;

namespace Balta
{
    class Program
    {
        static void Main(string[] args){
            Console.WriteLine("Hello World!");
            var course = new Course();
            course.Level = Batal.ContentContext.Enums.EContentLevel.Advanced;
            foreach (var item in course.Modules)
            {
                
            }
        }
    }
}