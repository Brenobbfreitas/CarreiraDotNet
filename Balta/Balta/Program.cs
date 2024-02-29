using Balta.ContentContext;

namespace Balta
{
    class Program
    {
        static void Main(string[] args){

            //artigos propriedades tile & url
            var articles = new List<Article>();
            articles.Add(new Article("Artigo branco","orientacao-objetos"));
            articles.Add(new Article("Artigo cpi","politica-brasil"));
            articles.Add(new Article("Artigo sst","seguranca-trabalho"));

            //  foreach (var article in articles)
            //  {
            //      Console.WriteLine(article.Id);
            //      Console.WriteLine(article.Title);
            //      Console.WriteLine(article.Url);
            //  }
            //Cursos propriedades title & url
            var courseoop = new Course("Fundamentos OOP","fundamento-oop");
            var courseCsharp = new Course("Fundamentos C#","fundamento-Csharp");
            var courseAspNet = new Course("Fundamentos ASP.NET","fundamento-ASPNET");

            var courses = new List<Course>();
            courses.Add(new Course("Fundamentos OOP","fundamento-oop"));
            courses.Add(new Course("Fundamentos C#","fundamento-Csharp"));
            courses.Add(new Course("Fundamentos ASP.NET","fundamento-ASPNET"));

            // foreach (var course in courses)
            // {
            //     Console.WriteLine(course.Id);
            //     Console.WriteLine(course.Title);
            //     Console.WriteLine(course.Url);
            // }

            var carrers = new List<Career>();
            var carrerDotNet = new Career("Especialista DotNet","carreira-DotNet");
            var carrerItem = new CareerItem(1,"Comece por aqui", "", null);
            var carrerItem2 = new CareerItem(2,"Aprenda DotNet", "", null);
            carrerDotNet.Items.Add(carrerItem);
            carrerDotNet.Items.Add(carrerItem2);
            carrers.Add(carrerDotNet);

            foreach (var carrer in carrers)
            {
                Console.WriteLine("Titulo: "+carrer.Title);
                foreach (var item in carrer.Items)
                {
                    Console.WriteLine(item.Ordem + " - " + item.Title);
                    
                }
            }
        }
    }
}