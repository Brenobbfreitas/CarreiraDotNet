namespace Balta.ContentContext
{
    public class Content
    {
        //contrutor
        public Content(string title, string url) 
        {
            Id = Guid.NewGuid();
            Title = title;
            Url = url;
        }
        public Guid Id { get; set; } //GUID é um identificador unico global
        public string Title { get; set; }
        public string Url { get; set; }
    }
}