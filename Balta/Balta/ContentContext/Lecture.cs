using Batal.ContentContext.Enums;

namespace Balta.ContentContext
{
    //Duração da aula
        public class Lecture{
        public int Ordem { get; set; }
        public string Title { get; set; }
        public int DurationInMinutes { get; set; }
        public EContentLevel Level { get; set; }
    }
    
}