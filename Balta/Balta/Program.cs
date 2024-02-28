using Balta.ContentContext;

namespace Balta
{
    class Program
    {
        static void Main(string[] args){
            var articles = new List<Article>();
            articles.Add(new Article("Artigo branco","orientacao-objetos"));

            foreach (var article in articles)
            {
                Console.WriteLine(article.Id);
                Console.WriteLine(article.Title);
                Console.WriteLine(article.Url);
            }
        }
    }
}