namespace Balta.ContentContext
{
    public class Content
    {
        //contrutor
        public Content() 
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; } //GUID é um identificador unico global
        public string Title { get; set; }
        public string Url { get; set; }
    }
}