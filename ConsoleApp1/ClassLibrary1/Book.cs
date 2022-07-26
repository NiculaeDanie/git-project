namespace Bookify.Domain
{
    public abstract class Book
    {
        private int id { get; set; }
        private string title { get; set; }  
        private Author author { get; set; }
        private DateTime releaseDate { get; set; } 
        private string descriprion { get; set; } 
        public Book(int id, string title, Author author, DateTime releaseDate, string descriprion)
        {
            this.id = id;
            this.title = title;
            this.author = author;
            this.releaseDate = releaseDate;
            this.descriprion = descriprion;
        }
    }
}