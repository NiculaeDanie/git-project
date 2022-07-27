using Bookify.Domain.Exceptions;

namespace Bookify.Domain.Model
{

    public abstract class Book
    {
        private int id { get; set; }
        private string title { get; set; }
        private Author author { get; set; }
        private DateTime releaseDate { get; set; }
        private string descriprion { get; set; }
        private Status status { get; set; }
        public List<string> genre { get; set; } 
        public Book(int id, string title, Author author, DateTime releaseDate, string descriprion, Status status, List<string> genre)
        {
            this.id = id;
            this.title = title;
            this.author = author;
            this.releaseDate = releaseDate;
            this.descriprion = descriprion;
            this.status = status;
            this.genre = genre;
        }
        public string getContent()
        {
            if(this.status == (Status)2)
            {
                throw new BookNotReleasedException();
            }
            return this.descriprion;
        }
    }

    public enum Status
    {
        Released,
        ComingSoon
    }
}