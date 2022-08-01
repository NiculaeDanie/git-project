// See https://aka.ms/new-console-template for more information
using Bookify.Domain.Model;
using Bookify.Domain.Services;
using Bookify.Domain.Exceptions;

List<User> users = new List<User>();
users.Add(new User("1", "daniel.nicu@amd.com", "1", "Daniel"));
users.Add(new User("2", "daniel.nicu@amd.com", "12", "Daniel"));
users.Add(new User("3", "daniel.nicu@amd.com", "123", "Daniel"));
users.Add(new User("4", "daniel.nicu@amd.com", "1234", "Daniel"));
users.Add(new User("5", "daniel.nicu@amd.com", "12345", "Daniel"));

var author = new Author("1", "Lee Child", new List<Book>() , "Lee Child is British but moved with his family from Cumbria to the United States to start a new career as an American thriller writer. His first novel, Killing Floor, won the Anthony Award");
var _books = new Book[2];
_books[0] = new Book("1", "How To Write a Mystery", new List<Author>() { author}, new DateTime(2022, 04, 22), "“Everything you wanted to know about how to plan, draft, write, revise, publish, and market a mystery”", (Status)2, new List<string>() { "Mistery", "Drama" });
_books[1] = new Book("2", "How To Write a Mystery", new List<Author>() { author }, new DateTime(2022, 04, 22), "“Everything you wanted to know about how to plan, draft, write, revise, publish, and market a mystery”", (Status)2, new List<string>() { "Comedy", "Action" });
var books = new Books(_books);
var currentUser = users.ElementAt(0);

    try
{
    var a = currentUser.getPreferences(books);
    Console.WriteLine(a.ElementAt(0));
}
catch(HistoryEmptyException ex)
{
    Console.WriteLine(ex.Message);
}
catch(ArgumentOutOfRangeException e)
{
    Console.WriteLine("There are no more unread books of your preferences");
}

Console.ReadLine();